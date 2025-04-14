using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppEvenement
{
    public partial class UCParticipants : UserControl
    {
        SQLiteConnection conn;
        private DataSet ds = new DataSet();

        public UCParticipants(SQLiteConnection conn)
        {
            InitializeComponent();
            this.conn = conn;

            System.Drawing.Font newFont = new System.Drawing.Font("Ink Free", 13, FontStyle.Bold);
            cboParticip.Font = newFont;
            cboSelectEvent.Font = newFont;
        }

        private void UCParticipants_Load(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open) // Si la connexion n'est pas ouverte
            {
                conn.Open();
            }

            string requeteInvites = "SELECT codeEvent, codePart FROM Invites"; // On récupère les données de la table Invites
            SQLiteDataAdapter daInvites = new SQLiteDataAdapter(requeteInvites, conn);
            daInvites.Fill(ds, "Invites");

            string requeteParticipant = "SELECT codeParticipant, prenomPart || ' ' || nomPart AS participant, mobile, nbParts FROM Participants"; // On récupère les données de la table Participants
            SQLiteDataAdapter daParticipant = new SQLiteDataAdapter(requeteParticipant, conn);
            daParticipant.Fill(ds, "Participants");

            cboParticip.DataSource = ds.Tables["Participants"]; // On remplit la combobox avec les données de la table Participants
            cboParticip.DisplayMember = "participant";
            cboParticip.ValueMember = "codeParticipant";

            DataRow rowParticipant = ds.Tables["Participants"].NewRow(); // On ajoute une ligne vide à la combobox
            rowParticipant["codeParticipant"] = DBNull.Value;
            rowParticipant["participant"] = "Tous les participants"; // On affiche "Tous les participants" dans la combobox
            ds.Tables["Participants"].Rows.InsertAt(rowParticipant, 0);
            cboParticip.SelectedIndex = 0;

            string requeteEvent = "SELECT codeEvent, titreEvent FROM Evenements"; // On récupère les données de la table Evenements
            SQLiteDataAdapter daEvent = new SQLiteDataAdapter(requeteEvent, conn);
            daEvent.Fill(ds, "Evenements");

            cboSelectEvent.DataSource = ds.Tables["Evenements"]; // On remplit la combobox avec les données de la table Evenements
            cboSelectEvent.DisplayMember = "titreEvent";
            cboSelectEvent.ValueMember = "codeEvent";

            DataRow rowEvent = ds.Tables["Evenements"].NewRow();
            rowEvent["codeEvent"] = DBNull.Value;
            rowEvent["titreEvent"] = "Tous les évènements";
            ds.Tables["Evenements"].Rows.InsertAt(rowEvent, 0);
            cboSelectEvent.SelectedIndex = 0;

            pnlInviter.Visible = true;
            TIP.SetToolTip(btnAddUser, "Ajouter un utilisateur à la liste principale"); // Affiche une info-bulle

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!frmAccueil.Instance.panelCentre.Controls.ContainsKey("UCAjoutNVUtilisateur")) // Si le panelCentre ne contient pas la clé "UCAjoutNVUtilisateur"
            {
                UCAjoutNVUtilisateur uc = new UCAjoutNVUtilisateur(conn); // On crée une instance de la classe UCAjoutNVUtilisateur
                uc.Dock = DockStyle.Fill; // On remplit le panel
                frmAccueil.Instance.panelCentre.Controls.Add(uc); // On ajoute le panel UCAjoutNVUtilisateur au panelCentre
            }
            frmAccueil.Instance.panelCentre.Controls["UCAjoutNVUtilisateur"].BringToFront(); // On affiche le panel UCAjoutNVUtilisateur
            frmAccueil.Instance.nbUcClick += 1;
            frmAccueil.Instance.boutonRetour.Visible = true;
        }

        private void cboSelectEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateParticipantsForSelectedEvent(); // On met à jour les participants pour l'évènement sélectionné
        }

        private void UpdateParticipantsForSelectedEvent()
        {
            ClearParticipants();

            if (cboSelectEvent.SelectedValue == null || cboSelectEvent.SelectedValue == DBNull.Value) // Si la valeur sélectionnée est nulle ou vide
            {
                UpdateParticipantCards(ds.Tables["Participants"]); // On met à jour les cartes des participants
                return;
            }

            int codeEventNum = Convert.ToInt32(cboSelectEvent.SelectedValue is DataRowView drvEvent ? drvEvent["codeEvent"] : cboSelectEvent.SelectedValue); // On récupère le code de l'évènement sélectionné

            DataRow[] inviteRows = ds.Tables["Invites"].Select($"codeEvent = {codeEventNum}"); // On récupère les lignes de la table Invites où le code de l'évènement est égal au code de l'évènement sélectionné

            DataTable filteredParticipants = ds.Tables["Participants"].Clone();

            foreach (DataRow inviteRow in inviteRows)
            {
                DataRow[] participantRows = ds.Tables["Participants"].Select($"codeParticipant = {inviteRow["codePart"]}"); // On récupère les lignes de la table Participants où le code du participant est égal au code du participant de la table Invites
                foreach (DataRow participantRow in participantRows)
                {
                    filteredParticipants.ImportRow(participantRow); // On importe la ligne du participant dans la table filteredParticipants
                }
            }

            cboParticip.DataSource = filteredParticipants;
            cboParticip.DisplayMember = "participant";
            cboParticip.ValueMember = "codeParticipant";

            DataRow rowParticipant = filteredParticipants.NewRow();
            rowParticipant["codeParticipant"] = DBNull.Value;
            rowParticipant["participant"] = "Tous les participants";
            filteredParticipants.Rows.InsertAt(rowParticipant, 0);
            cboParticip.SelectedIndex = 0;

            UpdateParticipantCards(filteredParticipants);
        }

        /*
         * Méthode permettant de vider les participants
         */
        private void ClearParticipants()
        {
            flpParticipant.Controls.Clear();
            cboParticip.DataSource = ds.Tables["Participants"];
            cboParticip.DisplayMember = "participant";
            cboParticip.ValueMember = "codeParticipant";
            cboParticip.SelectedIndex = 0;
        }

        /*
         * Méthode permettant de mettre à jour les cartes des participants
         */
        private void UpdateParticipantCards(DataTable participants)
        {
            flpParticipant.Controls.Clear();

            if (cboParticip.SelectedValue != null && cboParticip.SelectedValue != DBNull.Value && cboParticip.SelectedValue.ToString() != string.Empty) // Si la valeur sélectionnée n'est pas nulle ou vide
            {
                int codeParticip = Convert.ToInt32(cboParticip.SelectedValue is DataRowView drvParticip ? drvParticip["codeParticipant"] : cboParticip.SelectedValue);

                DataRow[] participantChoisi = participants.Select($"codeParticipant = {codeParticip}"); // On récupère les lignes de la table Participants où le code du participant est égal au code du participant sélectionné

                if (participantChoisi.Length > 0) // Si la longueur de participantChoisi est supérieure à 0
                {
                    DataRow row = participantChoisi[0];
                    UCCarteInvite uc = new UCCarteInvite { Nom = $"{row["participant"]}", Num = row["mobile"].ToString(), Part = row["nbParts"].ToString() }; // On crée une instance de la classe UCCarteInvite
                    flpParticipant.Controls.Add(uc);
                }
                return;
            }

            if (cboParticip.SelectedValue == null || cboParticip.SelectedValue == DBNull.Value || cboParticip.SelectedValue.ToString() == string.Empty && (cboSelectEvent.SelectedValue != null && cboSelectEvent.SelectedValue != DBNull.Value && cboSelectEvent.SelectedValue.ToString() != string.Empty))
            {

            }

            foreach (DataRow row in participants.Rows)
            {
                if (row.Table.Columns.Contains("participant") && row["participant"] != DBNull.Value && row.Table.Columns.Contains("mobile") && row["mobile"] != DBNull.Value && row.Table.Columns.Contains("nbParts") && row["nbParts"] != DBNull.Value) // Si la colonne participant et mobile et nbParts de la table contiennent des valeurs
                {
                    UCCarteInvite uc = new UCCarteInvite { Nom = $"{row["participant"]}", Num = row["mobile"].ToString(), Part = row["nbParts"].ToString() }; // On crée une instance de la classe UCCarteInvite
                    flpParticipant.Controls.Add(uc);
                }
            }
        }

        private void btnAjInv_Click(object sender, EventArgs e)
        {
        }

        private void cboParticip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboParticip.SelectedValue != null && cboParticip.SelectedValue != DBNull.Value && cboParticip.SelectedValue.ToString() != string.Empty) // si la valeur sélectionnée n'est pas nulle ou vide
            {
                UpdateParticipantCards(ds.Tables["Participants"]); // On met à jour les cartes des participants
            }
            else if (cboSelectEvent.SelectedValue != null && cboSelectEvent.SelectedValue != DBNull.Value && cboSelectEvent.SelectedValue.ToString() != string.Empty) // Si la valeur sélectionnée n'est pas nulle ou vide
            {
                // On récupère le code de l'évènement sélectionné
                int codeEventNum = Convert.ToInt32(cboSelectEvent.SelectedValue is DataRowView drvEvent ? drvEvent["codeEvent"] : cboSelectEvent.SelectedValue);

                DataRow[] inviteRows = ds.Tables["Invites"].Select($"codeEvent = {codeEventNum}");

                DataTable filteredParticipants = ds.Tables["Participants"].Clone();

                foreach (DataRow inviteRow in inviteRows) 
                {
                    // On récupère les lignes de la table Participants où le code du participant est égal au code du participant de la table Invites et on les stocke dans participantRows
                    DataRow[] participantRows = ds.Tables["Participants"].Select($"codeParticipant = {inviteRow["codePart"]}");
                    foreach (DataRow participantRow in participantRows)
                    {
                        filteredParticipants.ImportRow(participantRow);
                    }
                }
                UpdateParticipantCards(filteredParticipants); // On met à jour les cartes des participants
            }
            else
            {
                UpdateParticipantCards(ds.Tables["Participants"]); // On met à jour les cartes des participants
            }

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!frmAccueil.Instance.panelCentre.Controls.ContainsKey("UCLancerInvitation")) // Si le panelCentre ne contient pas la clé "UCLancerInvitation"
            {
                UCLancerInvitation un = new UCLancerInvitation(conn);
                un.Dock = DockStyle.Fill;
                frmAccueil.Instance.panelCentre.Controls.Add(un);
            }
            frmAccueil.Instance.panelCentre.Controls["UCLancerInvitation"].BringToFront(); // On affiche le panel UCLancerInvitation
            frmAccueil.Instance.boutonRetour.Visible = true;
            frmAccueil.Instance.nbUcClick += 1;
        }
    }
}