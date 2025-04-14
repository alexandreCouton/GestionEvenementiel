using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Evenement;

namespace AppEvenement
{
    public partial class UCLancerInvitation : UserControl
    {
        private SQLiteConnection _conn;
        private string _description;
        private string _titre;
        private DateTime _debut;
        private DateTime _fin;
        private string _createur;
        private bool particpantPage = false;
        public UCLancerInvitation(SQLiteConnection conn, string description, string titre, DateTime debut, DateTime fin, string createur)
        {
            InitializeComponent();
            this._conn = conn;
            this._description = description;
            this._titre = titre; 
            this._debut = debut;
            this._fin = debut;
            this._createur = createur;
            cboEvenement.Enabled = false;
            cboEvenement.Visible = false;
            flpSelectionInvite.AutoScroll = true;

            flpSelectionInvite.Controls.Clear();
            string sql = "SELECT codeParticipant, prenomPart || ' ' || nomPart as createur, mobile, nbParts from Participants"; // requete pour recuperer les participants
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++) // boucle pour afficher les participants
            {
                UCCarteInvite uc = new UCCarteInvite();
                foreach (Control control in uc.Controls)
                {
                    control.Click += (s, ev) =>
                    {
                        if (uc.BackColor == Color.LightGray)
                        {
                            uc.BackColor = Color.Gray;
                            uc.Image = Properties.Resources.cancel;
                        }
                        else
                        {
                            uc.BackColor = Color.LightGray;
                            uc.Image = Properties.Resources.icons8_tick_box_94;
                        }
                    };
                }
                uc.BackColor = Color.Gray;
                uc.Image = Properties.Resources.cancel;
                uc.Nom = dt.Rows[i]["createur"].ToString();
                uc.Num = dt.Rows[i]["mobile"].ToString();
                uc.Part = dt.Rows[i]["nbParts"].ToString();
                uc.Tag = dt.Rows[i]["codeParticipant"];
                flpSelectionInvite.Controls.Add(uc);
            }
        }
        public UCLancerInvitation(SQLiteConnection conn)
        {
            InitializeComponent();
            this._conn = conn;
            flpSelectionInvite.AutoScroll = true;

            flpSelectionInvite.Controls.Clear();
            particpantPage = true; // pour savoir si on vient de la page participant

            string requeteEvent = "SELECT codeEvent, titreEvent FROM Evenements"; // requete pour recuperer les evenements
            SQLiteDataAdapter daEvent = new SQLiteDataAdapter(requeteEvent, _conn);
            DataTable dtEvenement = new DataTable();
            daEvent.Fill(dtEvenement);

            cboEvenement.DataSource = dtEvenement; //on remplit la combobox avec les evenements
            cboEvenement.DisplayMember = "titreEvent";
            cboEvenement.ValueMember = "codeEvent";

            DataRow rowEvent = dtEvenement.NewRow();
            rowEvent["codeEvent"] = DBNull.Value;
            rowEvent["titreEvent"] = "Selectionez un évènement";
            dtEvenement.Rows.InsertAt(rowEvent, 0);
            cboEvenement.SelectedIndex = 0;
            btnSansInviter.Visible = false;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (!particpantPage) // si on vient de la page new event
            {
                this.Dispose();
                if (!frmAccueil.Instance.panelCentre.Controls.ContainsKey("UCNewEvent")) // on verifie si le user control existe
                {
                    UCNewEvent un = new UCNewEvent(_conn);
                    un.Dock = DockStyle.Fill;
                    frmAccueil.Instance.panelCentre.Controls.Add(un);
                }
                frmAccueil.Instance.panelCentre.Controls["UCNewEvent"].BringToFront(); // on affiche le user control
                frmAccueil.Instance.nbUcClick--;
            }
            else
            {
                this.Dispose();
                if (!frmAccueil.Instance.panelCentre.Controls.ContainsKey("UCParticipants")) // on verifie si le user control existe
                {
                    UCParticipants un = new UCParticipants(_conn);
                    un.Dock = DockStyle.Fill;
                    frmAccueil.Instance.panelCentre.Controls.Add(un);
                }
                frmAccueil.Instance.panelCentre.Controls["UCParticipants"].BringToFront(); // on affiche le user control
                frmAccueil.Instance.nbUcClick--;
                frmAccueil.Instance.boutonRetour.Visible = false;
            }
        }

        private void btnInviter_Click(object sender, EventArgs e)
        {
            //effectuer requete pour inviter les gens
            try
            {
                _conn.Open();
                if (particpantPage) // si on vient de la page participant
                {
                    foreach (UCCarteInvite uc in flpSelectionInvite.Controls) // on parcourt les participants
                    { 
                        if (uc.BackColor == Color.LightGray) // si le participant est selectionné
                        {
                            string login = uc.Nom.Substring(0, 1) + uc.Nom.Substring(uc.Nom.IndexOf(" ") + 1);
                            string mdp = uc.Nom.Substring(0, 1) + uc.Num.Substring(3, 1) + uc.Nom.Substring(uc.Nom.IndexOf(" ") + 1);
                            string sql2 = $@"INSERT INTO Invites (codePart, codeEvent, login, mdp) VALUES ('{uc.Tag}', '{cboEvenement.SelectedValue}', '{login}', '{mdp}')"; // requete pour inviter le participant
                            MessageBox.Show(sql2);
                            SQLiteCommand cmd2 = new SQLiteCommand(sql2, _conn);
                            cmd2.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Invitation envoyée avec succès"); // message de confirmation
                    if (!frmAccueil.Instance.panelCentre.Controls.ContainsKey("UCParticipants")) // on verifie si le user control existe
                    {
                        UCParticipants un = new UCParticipants(_conn);
                        un.Dock = DockStyle.Fill;
                        frmAccueil.Instance.panelCentre.Controls.Add(un);
                    }
                    frmAccueil.Instance.panelCentre.Controls["UCParticipants"].BringToFront(); // on affiche le user control
                    frmAccueil.Instance.boutonRetour.Visible = false;
                    frmAccueil.Instance.nbUcClick = 0;
                }
                else // si on vient de la page new event
                {
                    string sql = @"INSERT INTO Evenements (titreEvent, dateDebut, dateFin, description, soldeON, codeCreateur)
                                VALUES ('" + _titre + "', '" + _debut.ToString("yyyy-MM-dd") + "', '"
                    + _fin.ToString("yyyy-MM-dd") + "', '" + _description + "', '" + 0 + "', '" + _createur + "')"; // requete pour ajouter l'evenement
                    SQLiteCommand cmd = new SQLiteCommand(sql, _conn);
                    cmd.ExecuteNonQuery();
                    foreach (UCCarteInvite uc in flpSelectionInvite.Controls)
                    {
                        if (uc.BackColor == Color.LightGray)
                        {
                            string login = uc.Nom.Substring(0, 1) + uc.Nom.Substring(uc.Nom.IndexOf(" ") + 1);
                            string mdp = uc.Nom.Substring(0, 1) + uc.Num.Substring(3, 1) + uc.Nom.Substring(uc.Nom.IndexOf(" ") + 1);
                            string sql2 = $@"INSERT INTO Invites (codePart, codeEvent, login, mdp) VALUES ('{uc.Tag}', (SELECT MAX(codeEvent) FROM Evenements), '{login}', '{mdp}')"; // requete pour inviter le participant
                            MessageBox.Show(sql2);
                            SQLiteCommand cmd2 = new SQLiteCommand(sql2, _conn);
                            cmd2.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Evenement ajouté avec succès");
                    if (!frmAccueil.Instance.panelCentre.Controls.ContainsKey("parcours11")) // on verifie si le user control existe
                    {
                        Parcours11 un = new Parcours11(_conn);
                        un.Dock = DockStyle.Fill;
                        frmAccueil.Instance.panelCentre.Controls.Add(un);
                    }
                    frmAccueil.Instance.panelCentre.Controls["parcours11"].BringToFront(); // on affiche le user control
                    frmAccueil.Instance.boutonRetour.Visible = false;
                    frmAccueil.Instance.nbUcClick = 0;
                }



            }catch(Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }


        private void btnSansInviter_Click(object sender, EventArgs e)
        {            
            try
            {
                _conn.Open();
                string sql = @"INSERT INTO Evenements (titreEvent, dateDebut, dateFin, description, soldeON,codeCreateur)
                                VALUES ('" + _titre + "', '" + _debut.ToString("yyyy-MM-dd") + "', '" 
                                + _fin.ToString("yyyy-MM-dd") + "', '" + _description + "', '" + 0 + "', '"+_createur+ "')"; // requete pour ajouter l'evenement
                SQLiteCommand cmd = new SQLiteCommand(sql, _conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Evenement ajouté avec succès"); // message de confirmation
                if (!frmAccueil.Instance.panelCentre.Controls.ContainsKey("parcours11")) // on verifie si le user control existe
                {
                    Parcours11 un = new Parcours11(_conn);
                    un.Dock = DockStyle.Fill;
                    frmAccueil.Instance.panelCentre.Controls.Add(un);
                }
                frmAccueil.Instance.panelCentre.Controls["parcours11"].BringToFront(); // on affiche le user control
                frmAccueil.Instance.boutonRetour.Visible = false;
                frmAccueil.Instance.nbUcClick = 0;
                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void UCLancerInvitation_Load(object sender, EventArgs e)
        {

        }

        private void cboEvenement_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // si on vient de la page participant on met les participants qui n'ont pas encore été invités à l'evenement selectionné
            flpSelectionInvite.Controls.Clear();
            if (cboEvenement.SelectedValue != null && cboEvenement.SelectedValue != DBNull.Value && cboEvenement.SelectedValue.ToString() != string.Empty) // si on a selectionné un evenement
            {
                string sql = $@"SELECT codeParticipant, prenomPart || ' ' || nomPart as createur, mobile, nbParts from Participants where codeParticipant NOT IN (select codePart from Invites where codeEvent = {cboEvenement.SelectedValue})"; // requete pour recuperer les participants
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, _conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++) // boucle pour afficher les participants
                {
                    UCCarteInvite uc = new UCCarteInvite();
                    foreach (Control control in uc.Controls) // on ajoute un evenement click sur chaque participant
                    {
                        control.Click += (s, ev) =>
                        {
                            if (uc.BackColor == Color.LightGray)
                            {
                                uc.BackColor = Color.Gray;
                                uc.Image = Properties.Resources.cancel;
                            }
                            else
                            {
                                uc.BackColor = Color.LightGray;
                                uc.Image = Properties.Resources.icons8_tick_box_94;
                            }
                        };
                    }
                    // on ajoute les informations du participant
                    uc.BackColor = Color.Gray;
                    uc.Image = Properties.Resources.cancel;
                    uc.Nom = dt.Rows[i]["createur"].ToString();
                    uc.Num = dt.Rows[i]["mobile"].ToString();
                    uc.Part = dt.Rows[i]["nbParts"].ToString();
                    uc.Tag = dt.Rows[i]["codeParticipant"];
                    flpSelectionInvite.Controls.Add(uc);
                }
            }
        }
    }
}
