using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEvenement;
using System.Data.SQLite;

namespace Evenement
{
    public partial class Parcours11 : UserControl
    {
        SQLiteConnection conn;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();

        public Parcours11(SQLiteConnection conn)
        {
            InitializeComponent();
            this.conn = conn; // Connexion à la base de données
        }
        
        private void Parcours11_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                // Tooltips pour les boutons
                TIP.SetToolTip(btnFullGauche,"Aller à l'évènement le plus ancien"); 
                TIP.SetToolTip(btnGauche,"Aller à l'évènement précédent");
                TIP.SetToolTip(btnFullDroite,"Aller à l'évènement le plus récent");
                TIP.SetToolTip(btnDroite, "Aller à l'évènement suivant");
                chkSolde.Size = new Size(32, 32) ;
                // Remplissage de la DataTable
                string requete = @"select titreEvent, p.nomPart || ' ' || p.prenomPart as Createur, description, dateDebut, dateFin, soldeON 
                           from Evenements e 
                           join Participants p on p.codeParticipant = e.codeCreateur";
                SQLiteDataAdapter da = new SQLiteDataAdapter(requete, this.conn);
                da.Fill(this.dt);
                // Création d'une vue triée sur la DataTable
                DataView dv = new DataView(this.dt);
                dv.Sort = "dateDebut DESC";
                bs.DataSource = dv;

                setBinding();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données: " + ex.Message);
            }
        }

        private void btnFullGauche_Click(object sender, EventArgs e)
        {
            bs.MoveLast(); // Aller à l'évènement le plus ancien
        }

        private void btnGauche_Click(object sender, EventArgs e)
        {
            bs.MoveNext(); // Aller à l'évènement précédent
        }

        /*
         * Méthode pour lier les données de la DataTable à l'interface
         * 
         */
        public void setBinding()
        {
            lblEveRemplir.DataBindings.Add("Text", bs, "titreEvent"); 
            lblCreeParRemplir.DataBindings.Add("Text", bs, "Createur");
            lblDesciptionRemplir.DataBindings.Add("Text", bs, "description");
            lblDuRemplir.DataBindings.Add("Text", bs, "dateDebut");
            lblAuRemplir.DataBindings.Add("Text", bs, "dateFin");
            chkSolde.DataBindings.Add("Checked", bs, "soldeON");

        }

        private void btnAddEve_Click(object sender, EventArgs e)
        {
            if (!frmAccueil.Instance.panelCentre.Controls.ContainsKey("UCNewEvent"))
            { // Vérifie si le contrôle UCNewEvent n'existe pas
                UCNewEvent un = new UCNewEvent(conn);
                un.Dock = DockStyle.Fill;
                frmAccueil.Instance.panelCentre.Controls.Add(un);
            }
            frmAccueil.Instance.panelCentre.Controls["UCNewEvent"].BringToFront(); // Affiche le contrôle UCNewEvent
            frmAccueil.Instance.boutonRetour.Visible = true; // Affiche le bouton "Retour"
            frmAccueil.Instance.nbUcClick += 1; // Incrémentation du nombre de clics sur le bouton "Nouvel évènement" pour pouvoir revenir à l'écran précédent
        }

        private void lblCreeParRemplir_Click(object sender, EventArgs e)
        {

        }

        private void lblSolde_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            bs.MoveFirst(); // Aller à l'évènement le plus récent
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void bs_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnDroite_Click(object sender, EventArgs e)
        {
            bs.MovePrevious(); // Aller à l'évènement suivant
        }
    }
}
