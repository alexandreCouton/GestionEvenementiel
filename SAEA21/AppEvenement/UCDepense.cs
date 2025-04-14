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
    public partial class UCDepense : UserControl
    {
        SQLiteConnection conn;
        DataSet ds = new DataSet();
        public UCDepense(SQLiteConnection conn)
        {
            InitializeComponent();
            this.conn = conn;

            toolTip1.SetToolTip(btnAjouterDepense, "Cliquez pour ouvrir le menu afin d'ajouter une dépense");
            cboEvent.SelectionChangeCommitted += cboEvent_SelectionChangeCommitted;
            cboParticip.SelectionChangeCommitted += cboParticip_SelectionChangeCommitted;
            // pour changer la police du label
            Font newFont = new Font("Ink Free", 14, FontStyle.Bold);
            lblDepenser.Font = newFont;
            lblPart.Font = newFont;

        }

        private void btnAjouterDepense_Click(object sender, EventArgs e)
        {

        }

        private void btnNouvelDep_Click(object sender, EventArgs e)
        {
            if (!frmAccueil.Instance.panelCentre.Controls.ContainsKey("UCAjoutDepense")) // si le user control n'existe pas
            {
                UCAjoutDepense uc = new UCAjoutDepense(conn);
                uc.Dock = DockStyle.Fill;
                frmAccueil.Instance.panelCentre.Controls.Add(uc);
            }
            frmAccueil.Instance.panelCentre.Controls["UCAjoutDepense"].BringToFront(); // afficher le user control
            frmAccueil.Instance.boutonRetour.Visible = true;
            frmAccueil.Instance.nbUcClick += 1; // ajouter 1 au nombre de click
        }

        private void UCDepense_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM Depenses"; // requête pour récupérer les dépenses
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
                da.Fill(ds, "Depenses");
                sql = "Select * from Beneficiaires"; // requête pour récupérer les bénéficiaires
                da = new SQLiteDataAdapter(sql, conn);
                da.Fill(ds, "Beneficiaires");
                sql = "Select * from Invites"; // requête pour récupérer les invités
                da = new SQLiteDataAdapter(sql, conn);
                da.Fill(ds, "Invites");
                sql = "Select * from Evenements"; // requête pour récupérer les événements
                da = new SQLiteDataAdapter(sql, conn);
                da.Fill(ds, "Evenements");
                sql = "Select codeParticipant, nomPart ||' '|| prenomPart as participantNom, mobile, nbParts, adresseMail, solde from Participants"; // requête pour récupérer les participants
                da = new SQLiteDataAdapter(sql, conn);
                da.Fill(ds, "Participants");
                conn.Close();


                cboEvent.DataSource = ds.Tables["Evenements"];
                cboEvent.DisplayMember = "titreEvent";
                cboEvent.ValueMember = "codeEvent";
                DataRow rw = ds.Tables["Evenements"].NewRow(); // ajouter une ligne vide pour afficher un message
                rw["codeEvent"] = DBNull.Value;
                rw["titreEvent"] = "Sélectionner un évenement"; // afficher ce message
                ds.Tables["Evenements"].Rows.InsertAt(rw, 0);
                cboEvent.SelectedIndex = 0;
                // remplir le combobox des participants 
                cboParticip.DataSource = ds.Tables["Participants"];
                cboParticip.DisplayMember = "participantNom";
                cboParticip.ValueMember = "codeParticipant";
                DataRow rwParticipant = ds.Tables["Participants"].NewRow();
                rwParticipant["codeParticipant"] = DBNull.Value;
                rwParticipant["participantNom"] = "Sélectionner un participant";
                ds.Tables["Participants"].Rows.InsertAt(rwParticipant, 0);
                cboParticip.SelectedIndex = 0;

                lblDepenser.Text = "Choisisez un évenement";
                lblPart.Text = "Choisisez un participant";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /*
         *  Méthode pour mettre à jour les labels
         */
        private void UpdateLabel()
        {
            string eventText = "";
            string participantText = "";
            // remplir les labels
            if (cboEvent.SelectedValue != DBNull.Value && cboEvent.SelectedValue != null && cboEvent.SelectedIndex > 0)
            {
                eventText = cboEvent.Text;
            }

            if (cboParticip.SelectedValue != DBNull.Value && cboParticip.SelectedValue != null && cboParticip.SelectedIndex > 0)
            {
                participantText = cboParticip.Text;
            }

            if (!string.IsNullOrEmpty(eventText) && participantText == "Tous les participants")
            {
                lblDepenser.Text = "Dépenses de l'événement : " + eventText;
                lblPart.Text = "Dépenses du participant : ";
            }
            else if (!string.IsNullOrEmpty(eventText) && !string.IsNullOrEmpty(participantText))
            {
                lblDepenser.Text = "Dépenses de " + participantText + " dans l'événement " + eventText;
                lblPart.Text = "Dépenses du participant : " + participantText;
            }
            else if (!string.IsNullOrEmpty(participantText))
            {
                lblDepenser.Text = "Dépenses de " + participantText;
                lblPart.Text = "Dépenses du participant : " + participantText;
            }
            else
            {
                lblDepenser.Text = "Dépenses de l'événement : ";
                lblPart.Text = "Dépenses du participant : ";
            }
        }


        private void cboEvent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            flpDepense.Controls.Clear();
            flpPart.Controls.Clear();

            int codeEvent = 0;
            if (cboEvent.SelectedValue != DBNull.Value && cboEvent.SelectedValue != null) // si la valeur sélectionnée n'est pas vide
            {
                codeEvent = Convert.ToInt32(cboEvent.SelectedValue);
            }

            int codeParticipant = 0;
            if (cboParticip.SelectedValue != DBNull.Value && cboParticip.SelectedValue != null) // si la valeur sélectionnée n'est pas vide
            {
                codeParticipant = Convert.ToInt32(cboParticip.SelectedValue);
            }

            UpdateLabel(); // mettre à jour les labels


            DataTable filteredParticipants = ds.Tables["Participants"].Clone();

            if (codeEvent != 0) // si l'événement est sélectionné
            {
                DataRow[] inviteRows = ds.Tables["Invites"].Select($"codeEvent = {codeEvent}");

                foreach (DataRow inviteRow in inviteRows)
                {
                    DataRow[] participantRows = ds.Tables["Participants"].Select($"codeParticipant = {inviteRow["codePart"]}"); // récupérer les participants
                    foreach (DataRow participantRow in participantRows) // ajouter les participants à la liste
                    {
                        filteredParticipants.ImportRow(participantRow);
                    }
                }
                // remplir le combobox des participants avec les participants de l'événement
                cboParticip.DataSource = filteredParticipants;
                cboParticip.DisplayMember = "participantNom";
                cboParticip.ValueMember = "codeParticipant";

                DataRow rowParticipant = filteredParticipants.NewRow();
                rowParticipant["codeParticipant"] = DBNull.Value;
                rowParticipant["participantNom"] = "Tous les participants";
                filteredParticipants.Rows.InsertAt(rowParticipant, 0);
                cboParticip.SelectedIndex = 0;
            }

            foreach (DataRow depense in ds.Tables["Depenses"].Rows)
            {
                if (codeEvent != 0 && depense["codeEvent"].ToString() != codeEvent.ToString())
                {
                    continue;
                }

                if (codeParticipant != 0 && depense["codePart"].ToString() != codeParticipant.ToString())
                {
                    continue;
                }
                // afficher les dépenses
                UCArgent uCArgent = new UCArgent();
                uCArgent.Montant = depense["montant"].ToString();
                uCArgent.Date = depense["dateDepense"].ToString();
                uCArgent.Description = depense["description"].ToString();
                uCArgent.Tag = depense["numDepense"];
                foreach (Control control in uCArgent.Controls) // ajouter un événement click sur chaque dépense
                {
                    control.Click += (s, ev) =>
                    {
                        flpPart.Controls.Clear();
                        foreach (Control ctrl in flpDepense.Controls) // mettre toutes les dépenses en gris
                        {
                            ctrl.BackColor = Color.FromArgb(224, 224, 224);
                        }
                        uCArgent.BackColor = Color.FromArgb(240, 240, 240); // mettre la dépense cliquée en blanc
                        DataRow[] listeBeneficiaire = ds.Tables["Beneficiaires"].Select($"numDepense = {uCArgent.Tag}");
                        foreach (DataRow dataRow in listeBeneficiaire) // afficher les bénéficiaires de la dépense avec un user control
                        {
                            int codePart = Convert.ToInt32(dataRow["codePart"]);

                            UCCarteInvite uCCarteInvite = new UCCarteInvite();
                            uCCarteInvite.Nom = ds.Tables["Participants"].Select($"codeParticipant = {codePart.ToString()}")[0]["participantNom"].ToString();
                            uCCarteInvite.Part = ds.Tables["Participants"].Select($"codeParticipant = {codePart.ToString()}")[0]["nbParts"].ToString();
                            uCCarteInvite.Num = "";

                            flpPart.Controls.Add(uCCarteInvite);
                        }
                    };
                }
                flpDepense.Controls.Add(uCArgent);
            }
        }

        private void cboParticip_SelectionChangeCommitted(object sender, EventArgs e)
        {
            flpDepense.Controls.Clear();
            flpPart.Controls.Clear();

            int codeEvent = 0;
            if (cboEvent.SelectedValue != DBNull.Value && cboEvent.SelectedValue != null) // si la valeur sélectionnée n'est pas vide
            {
                codeEvent = Convert.ToInt32(cboEvent.SelectedValue);
            }

            int codeParticipant = 0;
            if (cboParticip.SelectedValue != DBNull.Value && cboParticip.SelectedValue != null) // si la valeur sélectionnée n'est pas vide
            {
                codeParticipant = Convert.ToInt32(cboParticip.SelectedValue);
            }

            UpdateLabel();

            foreach (DataRow depense in ds.Tables["Depenses"].Rows) 
            {
                if (codeEvent != 0 && depense["codeEvent"].ToString() != codeEvent.ToString()) // si l'événement est sélectionné
                {
                    continue;
                }

                if (codeParticipant != 0 && depense["codePart"].ToString() != codeParticipant.ToString()) // si le participant est sélectionné
                {
                    continue;
                }
                // afficher les dépenses
                UCArgent uCArgent = new UCArgent();
                uCArgent.Montant = depense["montant"].ToString();
                uCArgent.Date = depense["dateDepense"].ToString();
                uCArgent.Description = depense["description"].ToString();
                uCArgent.Tag = depense["numDepense"];
                foreach (Control control in uCArgent.Controls) // ajouter un événement click sur chaque dépense
                {
                    control.Click += (s, ev) =>
                    {
                        flpPart.Controls.Clear();
                        foreach (Control ctrl in flpDepense.Controls)
                        {
                            ctrl.BackColor = Color.FromArgb(224, 224, 224); // mettre toutes les dépenses en gris
                        }
                        uCArgent.BackColor = Color.FromArgb(240, 240, 240); // mettre la dépense cliquée en blanc
                        DataRow[] listeBeneficiaire = ds.Tables["Beneficiaires"].Select($"numDepense = {uCArgent.Tag}");
                        foreach (DataRow dataRow in listeBeneficiaire)
                        {
                            int codePart = Convert.ToInt32(dataRow["codePart"]);
                            // afficher les bénéficiaires de la dépense
                            UCCarteInvite uCCarteInvite = new UCCarteInvite();
                            uCCarteInvite.Nom = ds.Tables["Participants"].Select($"codeParticipant = {codePart.ToString()}")[0]["participantNom"].ToString();
                            uCCarteInvite.Part = ds.Tables["Participants"].Select($"codeParticipant = {codePart.ToString()}")[0]["nbParts"].ToString();
                            uCCarteInvite.Num = "";

                            flpPart.Controls.Add(uCCarteInvite);
                        }
                    };
                }
                flpDepense.Controls.Add(uCArgent);
            }
        }
    }
}
