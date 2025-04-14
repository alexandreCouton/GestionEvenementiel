using Evenement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEvenement
{
    public partial class UCNewEvent : UserControl
    {
        private SQLiteConnection conn;
        public UCNewEvent(SQLiteConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            string sql = "SELECT codeParticipant, prenomPart || ' ' || nomPart as createur from Participants"; // requête pour récupérer les participants
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboCreateur.DataSource = dt; // on lie le combobox à la datatable
            cboCreateur.DisplayMember = "createur";
            cboCreateur.ValueMember = "codeParticipant";
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(txtEvent.Text == "" || txtDescription.Text == "" || dtpDebut.Value == null || dtpFin.Value == null) // vérification des champs
            {
                MessageBox.Show("Veuillez remplir tous les champs"); // message d'erreur
                return;
            }
            else
            {
                if (!frmAccueil.Instance.panelCentre.Controls.ContainsKey("UCLancerInvitation")) // si le panel n'existe pas
                {
                    UCLancerInvitation un = new UCLancerInvitation(conn, txtDescription.Text, txtEvent.Text,  dtpDebut.Value, dtpFin.Value, cboCreateur.SelectedValue.ToString());
                    un.Dock = DockStyle.Fill;
                    frmAccueil.Instance.panelCentre.Controls.Add(un);
                }
                frmAccueil.Instance.panelCentre.Controls["UCLancerInvitation"].BringToFront(); // on affiche le panel
                frmAccueil.Instance.nbUcClick += 1;
            }
        }

        private void txtEvent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( char.IsPunctuation(e.KeyChar)|| !char.IsLetterOrDigit(e.KeyChar)) // on vérifie si le caractère est une ponctuation ou un caractère spécial
            {
                e.Handled = true; // on bloque la saisie
            }
            if (e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar)) // on vérifie si le caractère est un espace ou une touche de retour
            {
                e.Handled = false; // on autorise la saisie
            }
        }
    }
}
