using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Xml.Linq;
using iTextSharp.text.pdf.draw;
using System.Data.SQLite;
using Org.BouncyCastle.Utilities.Collections;


namespace AppEvenement
{
    public partial class UCBilanGlobal : UserControl
    {
        // Liste pour stocker les données à insérer
        List<String> insertCodeEventTMP = new List<string> ();
        List<String> insertCodeDonneurTMP = new List<string> ();
        List<String> insertCodeReceveurTMP = new List<string> ();
        List<String> insertCodeMontantTMP = new List<string> ();

        string nomEvent;
        string dateDebut;
        string dateFin;
        string description;
        DataTable dtDepense;
        DataTable dtRemboursement;
        SQLiteConnection conn;

        DataTable dtBilan = new DataTable();
        public UCBilanGlobal(SQLiteConnection conn,string nomEvent, DataTable dtBilan, string dateDebut, string dateFin, string description)
        {
            InitializeComponent();
            ResetControls();
            this.nomEvent = nomEvent;
            this.dtBilan = dtBilan;
            flpDepense.Controls.Clear();
            lblEventSelec.Text = string.Empty;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.description = description;
            this.dtDepense = dtDepense;
            this.dtRemboursement= dtRemboursement;
            this.conn = conn;
        }

        private void UCBilanGlobal_Load(object sender, EventArgs e)
        {
            ResetControls();
            lblEventSelec.Text = nomEvent;

            foreach(DataRow ligne in dtBilan.Rows)
            { // ligne dans dtBilan
                UCSoldeBG solde = new UCSoldeBG();
                solde.CodeParticipant = ligne["CodeParticipant"].ToString();
                solde.NomParticipant = ligne["Prenom"].ToString()+" ";
                solde.NomParticipant += ligne["Nom"].ToString();
                solde.Plus = Convert.ToDouble(ligne["Plus"]).ToString("F2");
                solde.Moins = Convert.ToDouble(ligne["Moins"]).ToString("F2");
                solde.Solde = Convert.ToDouble(ligne["Solde"]).ToString("F2");
                if (Convert.ToDouble(solde.Plus) != 0.00 || Convert.ToDouble(solde.Moins) != 0.00 || Convert.ToDouble(solde.Solde) != 0.00) // Si le solde est différent de 0, on l'ajoute
                {
                    flpDepense.Controls.Add(solde);
                }
            }
        }
        /*
         * Méthode pour réinitialiser les contrôles
         */
        public void ResetControls()
        {
            // Réinitialiser les contrôles nécessaires
            lblEventSelec.Text = string.Empty;
            flpDepense.Controls.Clear();
        }

        private void btnQuiDoitQuoi_Click(object sender, EventArgs e)
        {
            txtQuiDoitQuoi.AppendText($"Remboursement(s) à prévoir :{Environment.NewLine}{Environment.NewLine}"); 
            bool compteaZero=false;

            while (!compteaZero)
            {
                double min = 10e9; // 1 000 000 000 On se dit que personne a autant de thune que ça a mettre dans un event de cette app
                double max = -10e9; // Meme chose que en haut
                string donneur = "";
                string donneurCode="";
                string receveur = "";
                string receveurCode="";

                compteaZero = true;
                foreach (DataRow ligne in dtBilan.Rows) // Pour chaque ligne dans dtBilan
                {
                    if (Math.Truncate(Convert.ToDouble(ligne["Solde"])) != 0.00) // Si le solde est différent de 0
                    {
                        compteaZero = false; 
                        break;
                    }
                }
                if (compteaZero) // Si tous les soldes sont à 0, on sort de la boucle
                {
                    break;
                }
                foreach (DataRow ligne in dtBilan.Rows) // Pour chaque ligne dans dtBilan
                {
                    if (Convert.ToDouble(ligne["Solde"]) < min)
                    { // Si le solde est inférieur à min
                        min = Convert.ToDouble(ligne["Solde"]);
                        donneur = ligne["Prenom"].ToString() + " " + ligne["Nom"].ToString();
                        donneurCode = ligne["CodeParticipant"].ToString();
                    }
                    if (Convert.ToDouble(ligne["Solde"])>max) // Si le solde est supérieur à max
                    {
                        max = Convert.ToDouble(ligne["Solde"]);
                        receveur = ligne["Prenom"].ToString() + " " + ligne["Nom"].ToString();
                        receveurCode = ligne["CodeParticipant"].ToString();
                    }
                }
                if (Math.Abs(min) > max) // Si la valeur absolue de min est supérieure à max
                {
                    insertCodeEventTMP.Add(dtBilan.Rows[0]["CodeEvent"].ToString()); 
                    insertCodeReceveurTMP.Add(receveurCode);
                    insertCodeDonneurTMP.Add(donneurCode);
                    insertCodeMontantTMP.Add(max.ToString("F2"));

                    txtQuiDoitQuoi.AppendText($"{donneur} doit {max.ToString("F2")} € à {receveur}{Environment.NewLine}");
                    DataRow[] ligneReceveur = dtBilan.Select($"CodeParticipant = {receveurCode}");
                    foreach(DataRow ligne in ligneReceveur) // Pour chaque ligne dans ligneReceveur
                    {
                        ligne["Solde"] = 0; // On met le solde à 0
                    }
                    DataRow[] ligneDonneur = dtBilan.Select($"CodeParticipant = {donneurCode}");
                    foreach (DataRow ligne in ligneDonneur) // Pour chaque ligne dans ligneDonneur
                    {
                        ligne["Solde"] = min+max; // On met le solde à min+max
                    }
                }
                else // Sinon
                {
                    insertCodeEventTMP.Add(dtBilan.Rows[0]["CodeEvent"].ToString());
                    insertCodeReceveurTMP.Add(receveurCode);
                    insertCodeDonneurTMP.Add(donneurCode);
                    insertCodeMontantTMP.Add(Math.Abs(min).ToString("F2"));

                    txtQuiDoitQuoi.AppendText($"{donneur} doit {Math.Abs(min).ToString("F2")} € à {receveur}{Environment.NewLine}");
                    DataRow[] ligneReceveur = dtBilan.Select($"CodeParticipant = {receveurCode}");
                    foreach (DataRow ligne in ligneReceveur) // Pour chaque ligne dans ligneReceveur
                    {
                        ligne["Solde"] = min + max; // On met le solde à min+max
                    }
                    DataRow[] ligneDonneur = dtBilan.Select($"CodeParticipant = {donneurCode}");
                    foreach (DataRow ligne in ligneDonneur) // Pour chaque ligne dans ligneDonneur
                    {
                        ligne["Solde"] = 0; // On met le solde à 0
                    }

                }                
            }


            foreach(DataRow ligne in dtBilan.Rows)
            {
                //Creation du pdf avec nom special et redirection avec le bon path pour la creation
                Document pdfDoc = new Document(PageSize.A4);
                PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, new FileStream($"..\\..\\..\\Bilans\\Bilan{nomEvent}_{ligne["Nom"]}_{ligne["Prenom"]}.pdf", FileMode.Create));
                pdfDoc.Open();


                //Oblige de mettre iText.Sharp...... au lieu de simplement Font car il y a une référence entre le Font de Itext et de .net form
                iTextSharp.text.Font TitrePolice = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 18, iTextSharp.text.Font.BOLD);
                Paragraph p1 = new Paragraph("MoneyMatesss!", TitrePolice);
                p1.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(p1);

                //Ajout de l'image
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance("..\\..\\..\\logo.jpg");
                img.ScaleToFit(150, 150);
                img.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(img);
                ajouterSeparateur(pdfDoc, 2.5f, 10f);

                // Ajout de paragraphes pour les informations de l'événement
                Paragraph p2 = new Paragraph("\n");
                pdfDoc.Add(p2);
                iTextSharp.text.Font PoliceTexte = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA,13,iTextSharp.text.Font.UNDERLINE);
                p2 = new Paragraph($"- Récapitulatif de l'évènement : {nomEvent}", PoliceTexte);
                pdfDoc.Add(p2);
                sauterLigne(pdfDoc);
                p2 = new Paragraph($"Date de debut d'évènement : \t{dateDebut}");
                p2.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(p2);

                p2 = new Paragraph($"Date de fin d'évènement : \t{dateFin}");

                p2.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(p2);
                p2 = new Paragraph($"Description de l'évènement : \t{description}");
                p2.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(p2);

                ajouterSeparateur(pdfDoc, 2.5f, 30f);

                sauterLigne(pdfDoc);
                // Ajout de paragraphes pour les informations du participant
                PoliceTexte = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.UNDERLINE);
                p2 = new Paragraph($"- Récapitulatif du participant : ", PoliceTexte);
                pdfDoc.Add(p2);
                sauterLigne(pdfDoc);
                p2 = new Paragraph($"Prénom : {ligne["Prenom"]}");
                p2.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(p2);

                p2 = new Paragraph($"Nom : {ligne["Nom"]}");
                p2.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(p2);

                ajouterSeparateur(pdfDoc, 2.5f, 30f);

                sauterLigne(pdfDoc);
                // Ajout de paragraphes pour les informations des dépenses
                PoliceTexte = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.UNDERLINE);
                p2 = new Paragraph($"- Dépenses effectuées par : {ligne["Nom"]} ", PoliceTexte);
                pdfDoc.Add(p2);
                sauterLigne(pdfDoc);

                
                PdfPTable table = new PdfPTable(3); 
                table.WidthPercentage = 95; 
                string[] titreTableau = { "Code de la dépense","Description", "Montant en euros" };
                foreach (string titre in titreTableau) // Pour chaque titre dans titreTableau
                {
                    // Création de la cellule avec le titre et ajout à la table dans le PDF
                    iTextSharp.text.Font eventFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD); 
                    PdfPCell cell = new PdfPCell(new Phrase(titre, eventFont));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    table.AddCell(cell);
                }
                sauterLigne(pdfDoc);

                DataTable depenses = MesDepenses(dtBilan.Rows[0]["CodeEvent"].ToString(), ligne["CodeParticipant"].ToString()); // Récupération des dépenses du participant

                foreach (DataRow ligneDepense in depenses.Rows) // Pour chaque ligne dans depenses
                {
                    // Ajout des cellules à la table dans le PDF
                    table.AddCell(new Phrase(ligneDepense["numDepense"].ToString()));
                    table.AddCell(new Phrase(ligneDepense["description"].ToString()));
                    table.AddCell(new Phrase(ligneDepense["montant"].ToString()+" €"));
                }

                pdfDoc.Add(table);

                ajouterSeparateur(pdfDoc, 2.5f, 30f);
                // paragraphes pour les informations des dépenses dont bénéficie le participant
                PoliceTexte = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.UNDERLINE);
                p2 = new Paragraph($"- Dépenses dont bénéficie : {ligne["Nom"]} ", PoliceTexte);
                pdfDoc.Add(p2);
                sauterLigne(pdfDoc);
                DataTable depensesBenef = DepensesQuiMeConcernent(dtBilan.Rows[0]["CodeEvent"].ToString(), ligne["CodeParticipant"].ToString());

                table = new PdfPTable(3);
                table.WidthPercentage = 95;
                string[] titreTableauBenef = { "Code de la dépense", "Description", "Montant en euros" };
                foreach (string titre in titreTableauBenef)
                {
                    // Création de la cellule avec le titre et ajout à la table dans le PDF
                    iTextSharp.text.Font eventFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);
                    PdfPCell cell = new PdfPCell(new Phrase(titre, eventFont));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    table.AddCell(cell);
                }

                foreach (DataRow ligneBenef in depensesBenef.Rows)
                {
                    // Ajout des cellules à la table dans le PDF
                    table.AddCell(new Phrase(ligneBenef["numDepense"].ToString()));
                    table.AddCell(new Phrase(ligneBenef["description"].ToString()));
                    table.AddCell(new Phrase(ligneBenef["montant"].ToString() + " €"));
                }

                pdfDoc.Add(table);

                
                pdfDoc.NewPage();
                
                if (!insertCodeDonneurTMP.Contains(ligne["CodeParticipant"])) // Si le participant ne doit rien à personne
                {
                    // Ajout de paragraphes pour les informations des remboursements ne devant rien à personne
                    ajouterSeparateur(pdfDoc, 2.5f, 30f);
                    sauterLigne(pdfDoc);
                    PoliceTexte = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.UNDERLINE);
                    p2 = new Paragraph($"- {ligne["Nom"]} ne doit rien à personne", PoliceTexte);
                    pdfDoc.Add(p2);
                    ajouterSeparateur(pdfDoc, 2.5f, 30f);
                } 
                else 
                {
                    // Ajout de paragraphes pour les informations des remboursements devant de l'argent
                    ajouterSeparateur(pdfDoc, 2.5f, 30f);
                    sauterLigne(pdfDoc);
                    PoliceTexte = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.UNDERLINE);
                    p2 = new Paragraph($"- {ligne["Nom"]} doit payer à : ", PoliceTexte);
                    pdfDoc.Add(p2);
                    sauterLigne(pdfDoc);

                    // Création du tableau pour les remboursements
                    table = new PdfPTable(2);
                    table.WidthPercentage = 95;
                    string[] titreDoitA = { "Nom","Montant en euros" };
                    foreach (string titre in titreDoitA)
                    {
                        // Création de la cellule avec le titre et ajout à la table dans le PDF
                        iTextSharp.text.Font eventFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);
                        PdfPCell cell = new PdfPCell(new Phrase(titre, eventFont));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        table.AddCell(cell);
                    }

                    DataRow[] drDoitA;

                    for (int i=0;i<insertCodeDonneurTMP.Count;i++)
                    {
                        // Pour chaque ligne dans insertCodeDonneurTMP
                        if (insertCodeDonneurTMP[i].Equals(ligne["CodeParticipant"].ToString())) {
                            drDoitA = dtBilan.Select($"CodeParticipant = {insertCodeReceveurTMP[i]}");
                            foreach(DataRow ligneDoitA in drDoitA) { 
                                table.AddCell(new Phrase(ligneDoitA["Nom"].ToString()));
                                table.AddCell(new Phrase(insertCodeMontantTMP[i].ToString()));
                            }
                        }
                    }
                    ajouterSeparateur(pdfDoc, 2.5f, 30f);
                    pdfDoc.Add(table);
                }
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                sauterLigne(pdfDoc);
                if (!insertCodeReceveurTMP.Contains(ligne["CodeParticipant"])) // Si le participant ne doit rien à personne
                {
                    PoliceTexte = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.UNDERLINE);
                    p2 = new Paragraph($"- {ligne["Nom"]} ne doit rien recevoir de personne", PoliceTexte);
                    pdfDoc.Add(p2);
                    ajouterSeparateur(pdfDoc, 2.5f, 30f);
                }
                else
                {
                    // Ajout de paragraphes pour les informations des remboursements devant de l'argent
                    PoliceTexte = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.UNDERLINE);
                    p2 = new Paragraph($"- {ligne["Nom"]} doit recevoir de : ", PoliceTexte);
                    pdfDoc.Add(p2);
                    sauterLigne(pdfDoc);

                    table = new PdfPTable(2);
                    table.WidthPercentage = 95;
                    string[] titreRecoitDe = { "Nom", "Montant en euros" };
                    foreach (string titre in titreRecoitDe)
                    {
                        // Création de la cellule avec le titre et ajout à la table dans le PDF
                        iTextSharp.text.Font eventFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);
                        PdfPCell cell = new PdfPCell(new Phrase(titre, eventFont));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        table.AddCell(cell);
                    }

                    DataRow[] drRembDe;

                    for (int i = 0; i < insertCodeReceveurTMP.Count; i++)
                    {
                        if (insertCodeReceveurTMP[i].Equals(ligne["CodeParticipant"].ToString())) // Si le participant doit recevoir de l'argent
                        {
                            drRembDe = dtBilan.Select($"CodeParticipant = {insertCodeDonneurTMP[i]}");
                            foreach (DataRow ligneRemA in drRembDe)
                            {
                                // Ajout des cellules à la table dans le PDF
                                table.AddCell(new Phrase(ligneRemA["Nom"].ToString()));
                                table.AddCell(new Phrase(insertCodeMontantTMP[i].ToString()));
                            }
                        }
                    }
                    pdfDoc.Add(table);
                    ajouterSeparateur(pdfDoc, 2.5f, 30f);
                }

                sauterLigne(pdfDoc);
                // Ajout de paragraphes pour les informations de fin
                PoliceTexte = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.ITALIC);
                p2 = new Paragraph($"Nous vous remercions pour votre participation à l'événement {nomEvent}. Si vous avez des questions ou des préoccupations concernant ce rapport financier, n'hésitez pas à nous contacter.\r\n\r\nCordialement,\r\nVotre équipe MoneyMatesss", PoliceTexte);
                pdfDoc.Add(p2);

                img = iTextSharp.text.Image.GetInstance("..\\..\\..\\FauxTampon.png");
                img.ScaleToFit(180, 180);
                img.Alignment = Element.ALIGN_LEFT;
                pdfDoc.Add(img);
                ajouterSeparateur(pdfDoc, 2.5f, 10f);

                pdfDoc.Close();
              }


            //pdfDoc.Close();


            // ouvrir le pdf
            MessageBox.Show("PDF(s) générés!");

            try
            {
                conn.Open();

                // Boucler à travers les données à insérer
                for (int i = 0; i < insertCodeEventTMP.Count; i++)
                {
                    string codeEvent = insertCodeEventTMP[i];
                    string codeDonneur = insertCodeDonneurTMP[i];
                    string codeReceveur = insertCodeReceveurTMP[i];
                    string montant = insertCodeMontantTMP[i];
                    //Mettre a jour le soldeON
                    string MAJEvent = $@"UPDATE Evenements
                                            Set soldeON = 1
                                            where codeEvent = {insertCodeEventTMP[0]}";

                    SQLiteCommand cdMajEvent = new SQLiteCommand(MAJEvent, conn);
                    cdMajEvent.ExecuteNonQuery();
                    // Commande SQL pour insérer les données
                    string insertSql = "INSERT INTO BilanPart (codeEvent, codeDonneur, codeReceveur, montant) " +
                                        "VALUES ('" + codeEvent + "', '" + codeDonneur + "', '" + codeReceveur + "', '" + montant + "')";

                    // Exécuter la commande SQL d'insertion
                    SQLiteCommand insertCommand = new SQLiteCommand(insertSql, conn);
                    insertCommand.ExecuteNonQuery();
                }
            }catch(SQLiteException)
            {
                MessageBox.Show("Insertion déjà présente dans la BDD, seul les PDF ont été mis à jour");
            }
            finally
            {
                // Fermer la connexion à la base de données dans le bloc finally
                conn.Close();
            }

        }
        /*
         * Méthode pour ajouter un séparateur
         */
        private void ajouterSeparateur(Document pdfDoc, float largeurLigne, float espaceAvant)
        {
            LineSeparator separator = new LineSeparator(0.0F, 80.0F, BaseColor.BLUE, Element.ALIGN_CENTER, 1);
            separator.LineWidth = largeurLigne;
            Chunk linebreak = new Chunk(separator);
            linebreak.setLineHeight(espaceAvant);
            pdfDoc.Add(linebreak);
        }

        /*
         * Méthode pour récupérer les dépenses d'un participant
         */
        private DataTable MesDepenses(string pEvent, string pPart)
        {
            DataTable dtRembourseTMP = new DataTable();
            string requeteRemboursement = $@"select codePart as codePart, numDepense as numDepense, dateDepense as dateDepense, description as description, montant as montant
                                            from Depenses
                                            where codePart = {pPart}
                                            and codeEvent = {pEvent}"; // Requête SQL pour récupérer les dépenses du participant
            SQLiteDataAdapter daRemboursement = new SQLiteDataAdapter(requeteRemboursement, conn);

            daRemboursement.Fill(dtRembourseTMP);

            return dtRembourseTMP;
        }

        /*
         * Méthode pour récupérer les dépenses dont bénéficie un participant
         */
        private DataTable DepensesQuiMeConcernent(string pEvent, string pPart)
        {
            DataTable dtRembourseTMP = new DataTable();
            string requeteRemboursement = $@"select d.dateDepense as dateDepense,d.description as description, d.numDepense as numDepense, d.montant as montant, sum(p.nbParts) as SommeDenbParts
                                            from Depenses as d
                                            join Beneficiaires as b on d.numDepense=b.numDepense
                                            join Participants as p on b.codePart = P.codeParticipant
                                            where d.numDepense in (select d1.numDepense
                                                                    from Beneficiaires b1
                                                                    join Depenses d1 on b1.numDepense = d1.numDepense
                                                                    where d1.codeEvent={pEvent}
                                                                    and b1.codePart={pPart})
                                                    GROUP BY d.numDepense, d.montant"; // Requête SQL pour récupérer les dépenses dont bénéficie le participant
            SQLiteDataAdapter daRemboursement = new SQLiteDataAdapter(requeteRemboursement, conn);

            daRemboursement.Fill(dtRembourseTMP);

            return dtRembourseTMP;
        }

        /*
         * Méthode pour sauter une ligne
         */
        private void sauterLigne(Document pdfDoc)
        {
            Paragraph p2 = new Paragraph("\n");
            pdfDoc.Add(p2);
        }
    }
}
