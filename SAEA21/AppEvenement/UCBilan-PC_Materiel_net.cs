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
        //33,333333333333333333333333333333
        //27,2
        //30
        //30
        //26,6

        SQLiteConnection conn;
        DataTable dtParticipants = new DataTable();
        double totalRemboursement = 0;
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
            string chaine2 = "select codeEvent as codeEv, titreEvent as titreEv from Evenements;";
            SQLiteDataAdapter daEventCBO = new SQLiteDataAdapter(chaine2, conn);
            DataTable dtEventCBO = new DataTable();
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
            if (cboEvent.SelectedIndex != 0 && cboParticip.SelectedIndex!=0)
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
            /*//mettre requete en place 

            //Remplir table Depense
            for (int i = 0; i < 10; i++)
            {
                UCArgent ucDepense = new UCArgent();
                ucDepense.Montant = "100";
                ucDepense.Description = "test";
                ucDepense.Date = "12/12/2012";
                flpDepense.Controls.Add(ucDepense);
            }
            //remplire table ce que je dois
            for (int i = 0; i < 10; i++)
            {
                UCArgent ucDoit = new UCArgent();
                ucDoit.Montant = "100";
                ucDoit.Description = "test";
                ucDoit.Date = "12/12/2012";
                flpGDoit.Controls.Add(ucDoit);
            }*/
            if (cboEvent.SelectedIndex != 0 && cboParticip.SelectedIndex!=0)
            {
                DataRow[] nbPartParticipantSelec;
                double totalDepense =0;
                flpDepense.Controls.Clear();
                flpGDoit.Controls.Clear();
                lblDepenseMontant.Text = string.Empty;
                lblRembMontant.Text = string.Empty;
                lblDepenseMontant.Visible = false;
                lblRembMontant.Visible = false;
                DataTable dtmesDepense = MesDepenses(cboEvent.SelectedValue.ToString(), cboParticip.SelectedValue.ToString());
                DataTable dtceQueJeDois = DepensesQuiMeConcernent(cboEvent.SelectedValue.ToString(), cboParticip.SelectedValue.ToString());


                foreach (DataRow ligne in dtmesDepense.Rows)
                {
                    UCArgent ucDepense = new UCArgent();
                    ucDepense.Montant = ligne["montant"].ToString();
                    ucDepense.Description = ligne["description"].ToString();
                    ucDepense.Date = ligne["dateDepense"].ToString();
                    flpDepense.Controls.Add(ucDepense);
                }

                foreach (DataRow ligne in dtceQueJeDois.Rows)
                {
                    UCRemboursement ucRemb = new UCRemboursement();
                    ucRemb.Montant = ligne["montant"].ToString();
                    ucRemb.Description = ligne["description"].ToString();
                    ucRemb.Date = ligne["dateDepense"].ToString();
                    ucRemb.Part = ligne["SommeDenbParts"].ToString();
                    flpGDoit.Controls.Add(ucRemb);
                }


                totalRemboursement = DepensesDebit(cboEvent.SelectedValue.ToString(), cboParticip.SelectedValue.ToString());
                lblRembMontant.Text = totalRemboursement.ToString("F2") + " €";
                lblRembMontant.Visible = true;


                totalDepense = DepensesCredit(cboEvent.SelectedValue.ToString(), cboParticip.SelectedValue.ToString());

                lblDepenseMontant.Text = totalDepense.ToString("F2") + " €";
                lblDepenseMontant.Visible=true;

            }
            else
            {
                flpDepense.Controls.Clear();
                flpGDoit.Controls.Clear();
                cboParticip.SelectedIndex = 0;
            }
        }
        private DataTable MesDepenses(string pEvent, string pPart)
        {
            DataTable dtRembourseTMP = new DataTable();
            string requeteRemboursement = $@"select numDepense as numDepense, dateDepense as dateDepense, description as description, montant as montant
                                            from Depenses
                                            where codePart = {pPart}
                                            and codeEvent = {pEvent}";
            SQLiteDataAdapter daRemboursement = new SQLiteDataAdapter(requeteRemboursement, conn);

            daRemboursement.Fill(dtRembourseTMP);

            return dtRembourseTMP;
        }

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
                                                    GROUP BY d.numDepense, d.montant";
            SQLiteDataAdapter daRemboursement = new SQLiteDataAdapter(requeteRemboursement, conn);

            daRemboursement.Fill(dtRembourseTMP);

            return dtRembourseTMP;
        }

        private void btnBilanGlboal_Click(object sender, EventArgs e)
        {



            string codeEvt = cboEvent.SelectedValue.ToString();
            DataTable dtBilan = new DataTable();
            dtBilan.Columns.Add("CodeEvent", typeof(string));
            dtBilan.Columns.Add("CodeParticipant", typeof(string));
            dtBilan.Columns.Add("Nom", typeof(string));
            dtBilan.Columns.Add("Prenom", typeof(string));
            dtBilan.Columns.Add("Plus", typeof(double));
            dtBilan.Columns.Add("Moins", typeof(double));
            dtBilan.Columns.Add("Solde", typeof(double)); 

            foreach (DataRow participant in dtParticipants.Rows)
            {
                string codeEvent = cboEvent.SelectedValue.ToString();
                string codePart = participant["codeParticipant"].ToString();
                string nom = participant["nomPart"].ToString();
                string prenom = participant["prenomPart"].ToString();
                double depenseCredit = DepensesCredit(codeEvt, codePart);
                double depenseDebit = DepensesDebit(codeEvt, codePart);
                double solde = depenseCredit - depenseDebit; 

                dtBilan.Rows.Add(codeEvent, codePart, nom, prenom, depenseCredit, depenseDebit, solde);
            }
            frmAccueil.Instance.nbUcClick += 1;

            frmAccueil.Instance.panelCentre.Controls.RemoveByKey("UCBilanGlobal");
            UCBilanGlobal ucBilan = new UCBilanGlobal(cboEvent.Text,dtBilan);
            ucBilan.ResetControls();

            ucBilan.Dock = DockStyle.Fill;
            frmAccueil.Instance.panelCentre.Controls.Add(ucBilan);
            frmAccueil.Instance.panelCentre.Controls["UCBilanGlobal"].BringToFront();
            frmAccueil.Instance.boutonRetour.Visible = true;

        }

        private double DepensesCredit(string codeEvt, string numeroParticipant)
        {
            DataTable dtCreditTMP = MesDepenses(codeEvt, numeroParticipant);

            if (dtCreditTMP.Rows.Count == 0)
            {
                return 0.0;
            }

            // Calcul de la somme des montants
            object sommeObject = dtCreditTMP.Compute("Sum(montant)", $"");

            // Gestion des valeurs nulles
            double somme = sommeObject != DBNull.Value ? Convert.ToDouble(sommeObject) : 0.0;

            return somme;
        }

        private double DepensesDebit(string codeEvt, string numeroParticipant)
        {
            totalRemboursement = 0;
            DataTable dtDepenseConcerne = DepensesQuiMeConcernent(codeEvt, numeroParticipant);
            DataRow[] dtParticipantPART;
            if (dtDepenseConcerne.Rows.Count == 0)
            {
                return 0.00;
            }
            dtParticipantPART = dtParticipants.Select($"codeParticipant = {numeroParticipant}");
            double nbPartSelecDouble = Convert.ToDouble(dtParticipantPART[0]["nbParts"].ToString());

            foreach (DataRow ligne in dtDepenseConcerne.Rows)
            {
                totalRemboursement += (nbPartSelecDouble / Convert.ToDouble(ligne["SommeDenbParts"])) * Convert.ToDouble(ligne["montant"]);
            }

            object sommeObject = dtDepenseConcerne.Compute("Sum(montant)","");

            return totalRemboursement;
        }
    }
}
