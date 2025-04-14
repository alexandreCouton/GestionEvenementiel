using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEvenement;
using System.Globalization;

namespace AppEvenement
{
    public partial class UCAjoutDepense : UserControl
    {
        SQLiteConnection conn; 
        private List<string> beneficiairesCode = new List<string>(); // Liste des codes des bénéficiaires
        public UCAjoutDepense(SQLiteConnection conn) 
        {
            InitializeComponent();
            this.conn = conn; // Connexion à la base de données

        }

        private void UCAjoutDepense_Load(object sender, EventArgs e)
        {
            conn.Open();
            string requeteEvent = "select codeEvent as codeEvent, titreEvent as titreEvent from Evenements"; // Requête pour récupérer les événements
            SQLiteDataAdapter da = new SQLiteDataAdapter(requeteEvent, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboEvenement.DataSource = dt;
            cboEvenement.DisplayMember = "titreEvent";
            cboEvenement.ValueMember = "codeEvent";
            DataRow row = dt.NewRow(); // Ajout d'une ligne vide pour le premier élément de la combobox et afficher un message par défaut
            row["codeEvent"] = DBNull.Value;
            row["titreEvent"] = "Sélectionnez un événement"; // Message par défaut
            dt.Rows.InsertAt(row, 0); // Insertion de la ligne vide à la première position
            cboEvenement.SelectedIndex = 0;

            string categorie = "select codeCateg, nomCateg from Categories"; // Requête pour récupérer les catégories
            SQLiteDataAdapter daCateg = new SQLiteDataAdapter(categorie, conn);
            DataTable dtCateg = new DataTable();
            daCateg.Fill(dtCateg); // Remplissage de la table des catégories
            cboCategorie.DataSource = dtCateg;
            cboCategorie.DisplayMember = "nomCateg";
            cboCategorie.ValueMember = "codeCateg";

            pnlCommentaire.Visible = false;
            txtCommentaire.Text = string.Empty;
            pctF6.Visible = false;
            pnlDate.Visible = false;
            pctF5.Visible = false;
            pnlBeneficiaire.Visible = false;
            chklbBeneficiaires.Items.Clear();
            chkTousBeneficiaires.Checked = false;
            pctF4.Visible = false;
            pnlPayeur.Visible = false;
            cboQuiPaye.Items.Clear();
            pctF3.Visible = false;
            pnlCombien.Visible = false;
            txtCombien.Text = string.Empty;
            pctF2.Visible = false;
            pnlQuoi.Visible = false;
            txtQuoi.Text = string.Empty;
            pctF1.Visible = false;
            cboCategorie.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void txtQuoi_TextChanged(object sender, EventArgs e) 
        {
            if (txtQuoi.Text.Length != 0) // Si le champ n'est pas vide
            {
                pctF2.Visible = true; 
                pnlCombien.Visible = true; // Affichage du champ suivant
            }
            else // Si le champ est vide
            {
                pctF2.Visible = false;
                pnlCombien.Visible=false; // Masquage du champ suivant
            }
        }

        private void txtCombien_TextChanged(object sender, EventArgs e)
        {
            if (txtCombien.Text.Length != 0) // Si le champ n'est pas vide
            {
                pctF3.Visible = true;
                pnlPayeur.Visible = true; // Affichage du champ suivant
            }
            else
            {
                pctF3.Visible = false;
                pnlPayeur.Visible = false; // Masquage du champ suivant
            }
        }

        private void ucComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {                      
        }

        private void cboEvenement_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void cboEvenement_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cboEvenement_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboEvenement.SelectedIndex >0)
            { // Si un événement est sélectionné
                dtpQuandCaSePasse.MinDate = DateTime.Parse("01/01/1800"); // Date minimale
                dtpQuandCaSePasse.MaxDate = DateTime.Parse("01/01/2300"); // Date maximale
                string codeEventNum = cboEvenement.SelectedValue.ToString();
                string requeteQuiPaye = $@"select codeParticipant as codePart, prenomPart || ' ' || nomPart as payeur 
                                        from Participants where codeParticipant 
                                        in (select codePart from Invites where codeEvent = {codeEventNum})"; // Requête pour récupérer les participants de l'événement sélectionné 
                SQLiteDataAdapter daQuiPaye = new SQLiteDataAdapter(requeteQuiPaye, conn);
                daQuiPaye.SelectCommand.Parameters.AddWithValue("@codeEvent", codeEventNum); // Ajout du paramètre codeEvent
                DataTable dtQuiPaye = new DataTable();
                daQuiPaye.Fill(dtQuiPaye); // Remplissage de la table des participants
                cboQuiPaye.DataSource = dtQuiPaye;
                cboQuiPaye.DisplayMember = "payeur";
                cboQuiPaye.ValueMember = "codePart";
                DataRow row = dtQuiPaye.NewRow(); // Ajout d'une ligne vide pour le premier élément de la combobox et afficher un message par défaut
                row["codePart"] = DBNull.Value;
                row["payeur"] = "Sélectionnez qui paye"; // Message par défaut
                dtQuiPaye.Rows.InsertAt(row, 0); // Insertion de la ligne vide à la première position
                cboQuiPaye.SelectedIndex = 0;

                chklbBeneficiaires.Items.Clear(); // Effacement des éléments de la checkboxlist des bénéficiaires
                beneficiairesCode.Clear(); // Effacement des codes des bénéficiaires

                foreach (DataRow ligne in dtQuiPaye.Rows) // Parcours des participants
                {
                    if (!ligne["payeur"].Equals("Sélectionnez qui paye")) // Si le participant n'est pas celui qui paye
                    {
                        chklbBeneficiaires.Items.Add(ligne["payeur"]); // Ajout du participant à la checkboxlist des bénéficiaires
                        beneficiairesCode.Add(ligne["codePart"].ToString()); // Ajout du code du participant à la liste des codes des bénéficiaires
                    }
                }

                string requeteDate = $"SELECT dateDebut as debut, dateFin as fin from Evenements where codeEvent={codeEventNum}"; // Requête pour récupérer la date de début et la date de fin de l'événement
                SQLiteDataAdapter daDate = new SQLiteDataAdapter(requeteDate, conn);
                DataTable dtDate = new DataTable();
                daDate.Fill(dtDate); // Remplissage de la table des dates
                DateTime dateDebutDATE;
                string dateDebut;
                DateTime dateFinDATE;
                string dateFin;
                dateDebut = dtDate.Rows[0]["debut"].ToString(); // Récupération de la date de début
                dateFin = dtDate.Rows[0]["fin"].ToString(); // Récupération de la date de fin
                dateDebutDATE = DateTime.ParseExact(dateDebut, "yyyy-MM-dd", CultureInfo.InvariantCulture); // Conversion de la date de début en format date
                dateFinDATE = DateTime.ParseExact(dateFin, "yyyy-MM-dd", CultureInfo.InvariantCulture); // Conversion de la date de fin en format date
                dtpQuandCaSePasse.MinDate = dateDebutDATE; // Date de début de l'événement
                dtpQuandCaSePasse.MaxDate = dateFinDATE; // Date de fin de l'événement

                pctF1.Visible = true;
                pnlQuoi.Visible = true;
                erp.Clear();
            }
            else // Si aucun événement n'est sélectionné
            {
                cboQuiPaye.DataSource = null; // Effacement des éléments de la combobox des payeurs
            }
        }

        private void txtQuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtQuoi.Text.Length > 0) // Si le champ n'est pas vide
            {
                pctF2.Visible = true;
                pnlCombien.Visible = true; // Affichage du champ suivant
            }
            else    // Si le champ est vide
            {
                pctF2.Visible = false;
                pnlCombien.Visible = false; // Masquage du champ suivant
            }

        }

        private void txtCombien_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back) // Si le caractère n'est pas un chiffre, un point, une virgule ou une touche de retour
            {
                e.Handled = true; // Le caractère n'est pas pris en compte
            }
            if ((e.KeyChar == '.' || e.KeyChar == ',')  && (txtCombien.Text.Contains('.') || txtCombien.Text.Contains(','))) // Si le caractère est un point ou une virgule et que le champ contient déjà un point ou une virgule
            {
                e.Handled = true; // Le caractère n'est pas pris en compte
            }

            if (txtCombien.Text.Length > 0) 
            {
                pctF3.Visible = true;
                pnlPayeur.Visible = true;
            }
            else
            {
                pctF3.Visible = false;
                pnlPayeur.Visible = false;
            }
        }

        private void chkTousBeneficiaires_CheckedChanged(object sender, EventArgs e)
        {
            if(chkTousBeneficiaires.Checked) // Si la case est cochée
            {
                for(int i=0;i<chklbBeneficiaires.Items.Count;i++) // Parcours des éléments de la checkboxlist
                {
                    chklbBeneficiaires.SetItemChecked(i, true); // Cocher tous les éléments
                }

            }
            else // Si la case n'est pas cochée
            {
                for (int i = 0; i < chklbBeneficiaires.Items.Count; i++) // Parcours des éléments de la checkboxlist
                {
                    chklbBeneficiaires.SetItemChecked(i, false); // Décocher tous les éléments
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            toutEffacer(); // Appel de la méthode pour effacer les champs
        }

        private void cboQuiPaye_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cboQuiPaye.SelectedIndex>0)
            { // Si un participant est sélectionné
                pctF4.Visible = true;
                pnlBeneficiaire.Visible = true; // Affichage du champ suivant
            }
        }

        private void chkTousBeneficiaires_Click(object sender, EventArgs e)
        {
            if(chklbBeneficiaires.CheckedItems.Count>0) // Si au moins un bénéficiaire est sélectionné
            {
                pctF5.Visible=true;
                pnlDate.Visible=true;
                pctF6.Visible=true;
                pnlCommentaire.Visible=true;
                cboCategorie.Visible=true;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try { 
                if(cboEvenement.SelectedIndex==0) // Si aucun événement n'est sélectionné
                {
                    erp.SetError(cboEvenement,"Selectionnez un évènement pour continuer !");
                }
                else if(cboQuiPaye.SelectedIndex==0) // Si aucun participant n'est sélectionné
                {
                    erp.SetError(cboQuiPaye, "Selectionnez qui va payer pour continuer !");
                }
                else if(txtCombien.Text.Length==0)
                { // Si le champ du montant est vide
                    erp.SetError(txtCombien, "Entrez un montant");
                }
                else if(txtQuoi.Text.Length<1) // Si le champ de la description est vide
                {
                    erp.SetError(pnlQuoi, "Entrez le sujet de la dépense");
                }
                else if(chklbBeneficiaires.CheckedIndices.Count==0)
                { // Si aucun bénéficiaire n'est sélectionné
                    erp.SetError(chklbBeneficiaires, "Mettez un ou plusieurs bénéficiaires");
                }else if (cboCategorie.SelectedIndex < 0) // Si aucune catégorie n'est sélectionnée
                {
                    erp.SetError(cboCategorie, "Choisissez une catégorie !");
                }
                else // Si tous les champs sont remplis
                {
                    // Récupération des valeurs des champs
                    string codeEvent = cboEvenement.SelectedValue.ToString();
                    string description = txtQuoi.Text;
                    string combien = txtCombien.Text;
                    string quiPaye = cboQuiPaye.SelectedValue.ToString();
                    string commentaire = txtCommentaire.Text;
                    DateTime dateChoisis = dtpQuandCaSePasse.Value;
                    string dateChosisSTRING = dateChoisis.ToString("yyyy-MM-dd");

                    string insertDepense = $@"INSERT into Depenses (description,montant,dateDepense,commentaire,codeEvent,codePart) 
                                            values ('{description}',{combien},'{dateChosisSTRING}','{commentaire}',{codeEvent},{quiPaye})"; // Requête pour ajouter la dépense
                    SQLiteCommand cdInsertDepense = new SQLiteCommand(insertDepense,conn);

                    if(cdInsertDepense.ExecuteNonQuery() < 1) // Si l'ajout de la dépense n'a pas réussi
                    {
                        throw new Exception("Erreur ! Une erreur s'est produite lors de l'ajout de la dépense. Veuillez réessayer.");
                    }

                    string requeteIDDepense = "select count(numDepense) from Depenses"; // Requête pour récupérer le nombre de dépenses

                    SQLiteCommand cdIDDepense = new SQLiteCommand(requeteIDDepense, conn);

                    int idDernier = Convert.ToInt32(cdIDDepense.ExecuteScalar());

                    foreach (int index in chklbBeneficiaires.CheckedIndices) // Parcours des bénéficiaires sélectionnés
                    {
                        string insertBeneficiaires = $"INSERT into Beneficiaires(numDepense,codePart) values ({idDernier},{beneficiairesCode[index]})"; // Requête pour ajouter les bénéficiaires
                        SQLiteCommand cdInsertBeneficiaires = new SQLiteCommand(insertBeneficiaires,conn);
                        cdInsertBeneficiaires.ExecuteNonQuery();
                    }

                    string categChoisis = cboCategorie.SelectedValue.ToString();

                    string categDepense = $"insert into CategDepense(numDepense,codeCateg) values ({idDernier},{categChoisis})"; // Requête pour ajouter la catégorie de la dépense

                    SQLiteCommand cdCateg = new SQLiteCommand(categDepense, conn);

                    if (cdCateg.ExecuteNonQuery() > 0) // Si l'ajout de la catégorie a réussi
                    {
                        MessageBox.Show("Succès ! La dépense a été ajouté avec succès !\r\n");
                        toutEffacer();
                    }
                    else // Si l'ajout de la catégorie n'a pas réussi
                    {
                        throw new Exception("Erreur ! Une erreur s'est produite lors de l'ajout de la dépense. Veuillez réessayer.");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void chklbBeneficiaires_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si au moins un bénéficiaire est sélectionné
            pnlDate.Visible = true;
            pctF5.Visible = true;
            pnlCommentaire.Visible=true;
            pctF6.Visible = true;
            cboCategorie.Visible = true;
        }

        /*
         * Méthode pour effacer les champs
         */
        private void toutEffacer()
        {
            pnlCommentaire.Visible = false;
            txtCommentaire.Text = string.Empty;
            pctF6.Visible = false;
            pnlDate.Visible = false;
            pctF5.Visible = false;
            pnlBeneficiaire.Visible = false;
            chklbBeneficiaires.Items.Clear();
            chkTousBeneficiaires.Checked = false;
            pctF4.Visible = false;
            pnlPayeur.Visible = false;
            cboQuiPaye.DataSource = null;
            pctF3.Visible = false;
            pnlCombien.Visible = false;
            txtCombien.Text = string.Empty;
            pctF2.Visible = false;
            pnlQuoi.Visible = false;
            txtQuoi.Text = string.Empty;
            pctF1.Visible = false;
            cboEvenement.SelectedIndex = 0;
        }
    }
}
