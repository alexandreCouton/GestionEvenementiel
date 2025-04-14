using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEvenement
{
    public partial class UCBilan : UserControl
    {
        SQLiteConnection conn;
        DataTable dtParticipants = new DataTable();
        DataTable dtEventCBO = new DataTable();
        double totalRemboursement = 0;
        DataTable dtmesDepense; 
        DataTable dtceQueJeDois;
        public UCBilan(SQLiteConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }
        private void UCBilan_Load(object sender, EventArgs e)
        {
            // Ajout des nombres des Participants dans la CBO PAR LIAISON DE DONNEES et on garde les parts pour le total
            string chaine = "select codeParticipant as codePart, prenomPart ||' '|| nomPart as partNom, nbParts from Participants;";
            SQLiteDataAdapter daPartCBO = new SQLiteDataAdapter(chaine,conn);
            DataTable dtPartCBO = new DataTable();
            daPartCBO.Fill(dtPartCBO);

            cboParticip.DataSource = dtPartCBO;
            cboParticip.DisplayMember = "partNom";
            cboParticip.ValueMember = "codePart";

            //Ajout de tout les participants dans un datatable pour la selection du nbPart après
            string requeteParticipant = "select * from Participants";
            SQLiteDataAdapter daParticipants = new SQLiteDataAdapter(requeteParticipant,conn);
            daParticipants.Fill(dtParticipants);

            // Ajout des Evenemnts dans la CBO PAR LIAISON DE DONNEES
            string chaine2 = "select codeEvent as codeEv, titreEvent as titreEv, description as description, dateDebut as dateDebut, dateFin as dateFin from Evenements;";
            SQLiteDataAdapter daEventCBO = new SQLiteDataAdapter(chaine2, conn);
            daEventCBO.Fill(dtEventCBO);
            cboEvent.DataSource= dtEventCBO;
            cboEvent.DisplayMember = "titreEv";
            cboEvent.ValueMember = "codeEv";


            //Ajout des phrases utiles Au début de chaque combo box
            DataRow rowPart = dtPartCBO.NewRow();
            rowPart["codePart"] = DBNull.Value;
            rowPart["partNom"] = "Sélectionnez un participant";
            dtPartCBO.Rows.InsertAt(rowPart, 0);
            cboParticip.SelectedIndex = 0;

            DataRow rowEvent = dtEventCBO.NewRow();
            rowEvent["codeEv"] = DBNull.Value;
            rowEvent["titreEv"] = "Sélectionnez un évènement";
            dtEventCBO.Rows.InsertAt(rowEvent, 0);
            cboEvent.SelectedIndex = 0;
        }

        private void lblDepenser_Click(object sender, EventArgs e)
        {

        }

        private void cboEvent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboEvent.SelectedIndex != 0 && cboParticip.SelectedIndex!=0) // Si un évènement est sélectionné
            {
                flpDepense.Controls.Clear();
                flpGDoit.Controls.Clear();
                cboParticip.SelectedIndex = 0;
                lblDepenseMontant.Text = string.Empty;
                lblRembMontant.Text = string.Empty;
                lblDepenseMontant.Visible = false;
                lblRembMontant.Visible = false;
            }
            else
            {
                flpDepense.Controls.Clear();
                flpGDoit.Controls.Clear();
                cboParticip.SelectedIndex = 0;
                lblDepenseMontant.Text = string.Empty;
                lblRembMontant.Text = string.Empty;
                lblDepenseMontant.Visible = false;
                lblRembMontant.Visible = false;
            }
        }

        private void cboParticip_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboEvent.SelectedIndex != 0 && cboParticip.SelectedIndex!=0) // Si un évènement est sélectionné
            {
                // initialisation des variables
                DataRow[] nbPartParticipantSelec;
                double totalDepense =0;
                flpDepense.Controls.Clear();
                flpGDoit.Controls.Clear();
                lblDepenseMontant.Text = string.Empty;
                lblRembMontant.Text = string.Empty;
                lblDepenseMontant.Visible = false;
                lblRembMontant.Visible = false;
                dtmesDepense = MesDepenses(cboEvent.SelectedValue.ToString(), cboParticip.SelectedValue.ToString()); 
                dtceQueJeDois = DepensesQuiMeConcernent(cboEvent.SelectedValue.ToString(), cboParticip.SelectedValue.ToString());


                foreach (DataRow ligne in dtmesDepense.Rows) // Pour chaque dépense
                {
                    UCArgent ucDepense = new UCArgent();
                    ucDepense.Montant = ligne["montant"].ToString();
                    ucDepense.Description = ligne["description"].ToString();
                    ucDepense.Date = ligne["dateDepense"].ToString();
                    flpDepense.Controls.Add(ucDepense);
                }

                foreach (DataRow ligne in dtceQueJeDois.Rows) // Pour chaque dépense de ce que je dois
                {
                    UCRemboursement ucRemb = new UCRemboursement();
                    ucRemb.Montant = ligne["montant"].ToString();
                    ucRemb.Description = ligne["description"].ToString();
                    ucRemb.Date = ligne["dateDepense"].ToString();
                    ucRemb.Part = ligne["SommeDenbParts"].ToString();
                    flpGDoit.Controls.Add(ucRemb);
                }
                // Calcul des dépenses et remboursements pour affichage
                totalRemboursement = DepensesDebit(cboEvent.SelectedValue.ToString(), cboParticip.SelectedValue.ToString());
                lblRembMontant.Text = totalRemboursement.ToString("F2") + " €";
                lblRembMontant.Visible = true;

                // Calcul des dépenses
                totalDepense = DepensesCredit(cboEvent.SelectedValue.ToString(), cboParticip.SelectedValue.ToString());

                // Affichage du total des dépenses
                lblDepenseMontant.Text = totalDepense.ToString("F2") + " €";
                lblDepenseMontant.Visible=true;
            }
            else // Si un évènement n'est pas sélectionné
            {
                flpDepense.Controls.Clear();
                flpGDoit.Controls.Clear();
                cboParticip.SelectedIndex = 0;
            }
        }

        /**
         * Méthode pour récupérer les dépenses
         */
        private DataTable MesDepenses(string pEvent, string pPart)
        {
            DataTable dtRembourseTMP = new DataTable();
            string requeteRemboursement = $@"select codePart as codePart, numDepense as numDepense, dateDepense as dateDepense, description as description, montant as montant
                                            from Depenses
                                            where codePart = {pPart}
                                            and codeEvent = {pEvent}"; // Requête pour récupérer les remboursements que les participants doivent
            SQLiteDataAdapter daRemboursement = new SQLiteDataAdapter(requeteRemboursement, conn);

            daRemboursement.Fill(dtRembourseTMP);

            return dtRembourseTMP;
        }

        /*
         * Méthode pour récupérer les dépenses qui me concernent
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
                                                    GROUP BY d.numDepense, d.montant"; // Requête pour récupérer les remboursements qui me concernent
            SQLiteDataAdapter daRemboursement = new SQLiteDataAdapter(requeteRemboursement, conn);

            daRemboursement.Fill(dtRembourseTMP);

            return dtRembourseTMP;
        }

        private void btnBilanGlboal_Click(object sender, EventArgs e)
        {
            if (cboEvent.SelectedIndex != 0) { 
            // Création d'un DataTable pour le bilan global
            string codeEvt = cboEvent.SelectedValue.ToString();
            DataTable dtBilan = new DataTable();
            dtBilan.Columns.Add("CodeEvent", typeof(string));
            dtBilan.Columns.Add("CodeParticipant", typeof(string));
            dtBilan.Columns.Add("Nom", typeof(string));
            dtBilan.Columns.Add("Prenom", typeof(string));
            dtBilan.Columns.Add("Plus", typeof(double));
            dtBilan.Columns.Add("Moins", typeof(double));
            dtBilan.Columns.Add("Solde", typeof(double)); 

            foreach (DataRow participant in dtParticipants.Rows) // Pour chaque participant
            {
                string codeEvent = cboEvent.SelectedValue.ToString();
                string codePart = participant["codeParticipant"].ToString();
                string nom = participant["nomPart"].ToString();
                string prenom = participant["prenomPart"].ToString();
                double depenseCredit = DepensesCredit(codeEvt, codePart);
                double depenseDebit = DepensesDebit(codeEvt, codePart);
                double solde = depenseCredit - depenseDebit; 

                dtBilan.Rows.Add(codeEvent, codePart, nom, prenom, depenseCredit, depenseDebit, solde); // Ajout des valeurs dans le DataTable
            }
            frmAccueil.Instance.nbUcClick += 1; 

            frmAccueil.Instance.panelCentre.Controls.RemoveByKey("UCBilanGlobal");
            //Select pour dateDebut, dateFin et description
            DataRow[] drArgumentBilanGlobal = dtEventCBO.Select($"codeEv = {cboEvent.SelectedValue}");
            string dateDebutBG = drArgumentBilanGlobal[0]["dateDebut"].ToString();
            string dateFinBG = drArgumentBilanGlobal[0]["dateFin"].ToString();
            string descriptionBG = drArgumentBilanGlobal[0]["description"].ToString();

            UCBilanGlobal ucBilan = new UCBilanGlobal(conn,cboEvent.Text,dtBilan,dateDebutBG,dateFinBG,descriptionBG); // Création de l'UC Bilan Global
            ucBilan.ResetControls(); // Réinitialisation des contrôles
            ucBilan.Dock = DockStyle.Fill;
            frmAccueil.Instance.panelCentre.Controls.Add(ucBilan); // Ajout de l'UC Bilan Global
            frmAccueil.Instance.panelCentre.Controls["UCBilanGlobal"].BringToFront();
            frmAccueil.Instance.boutonRetour.Visible = true;
            }
        }

        /**
         * Méthode pour le calcul des dépenses
         */
        private double DepensesCredit(string codeEvt, string numeroParticipant)
        {
            DataTable dtCreditTMP = MesDepenses(codeEvt, numeroParticipant); // Récupération des dépenses

            if (dtCreditTMP.Rows.Count == 0) // Si aucune dépense
            {
                return 0.0;
            }

            // Calcul de la somme des montants
            object sommeObject = dtCreditTMP.Compute("Sum(montant)", $"");

            // Gestion des valeurs nulles
            double somme = sommeObject != DBNull.Value ? Convert.ToDouble(sommeObject) : 0.0;

            return somme;
        }

        /**
         * Méthode pour le calcul des remboursements
         */
        private double DepensesDebit(string codeEvt, string numeroParticipant)
        {
            totalRemboursement = 0;
            DataTable dtDepenseConcerne = DepensesQuiMeConcernent(codeEvt, numeroParticipant);
            DataRow[] dtParticipantPART;
            if (dtDepenseConcerne.Rows.Count == 0) // Si aucune dépense
            {
                return 0.00;
            }
            dtParticipantPART = dtParticipants.Select($"codeParticipant = {numeroParticipant}"); // Récupération du nombre de parts du participant
            double nbPartSelecDouble = Convert.ToDouble(dtParticipantPART[0]["nbParts"].ToString()); 

            foreach (DataRow ligne in dtDepenseConcerne.Rows) // Pour chaque dépense
            {
                totalRemboursement += (nbPartSelecDouble / Convert.ToDouble(ligne["SommeDenbParts"])) * Convert.ToDouble(ligne["montant"]); // Calcul du remboursement
            }

            object sommeObject = dtDepenseConcerne.Compute("Sum(montant)",""); // Calcul de la somme des montants

            return totalRemboursement;
        }
    }
}
