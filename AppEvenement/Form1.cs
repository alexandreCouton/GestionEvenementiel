using Evenement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEvenement
{
    public partial class frmAccueil : Form
    {
        static frmAccueil _obj;
        SQLiteConnection conn;
        string chaine = "Data Source=Events.sqlite";

        public static frmAccueil Instance //Permet d'accéder à au forme Accueil depuis les usercontrols sans devoir créer une nouvelle instance
        {
            get 
            {
                if (_obj == null)
                {
                    _obj = new frmAccueil();
                }
                return _obj; 
            }
        }

        public Panel panelCentre //Permet d'accéder au panelCentre depuis les usercontrols
        {
            get { return pnlCentre; }
            set { pnlCentre = value; }
        }

        public string labelTitre //Permet d'accéder au labelTitre depuis les usercontrols
        {
            get { return lblNomPage.Text; }
        }

        private int _nbUcClick;
        public int nbUcClick //Permet de savoir quel usercontrol est affiché et utilisé pour le bouton retour
        {
            get { return _nbUcClick; }
            set { _nbUcClick = value; }
        }

        public Button boutonRetour //Permet d'accéder au bouton retour depuis les usercontrols
        {
            get { return btnBack; }
            set { btnBack = value; }
        }

        public frmAccueil() 
        {
            InitializeComponent();
            btnBack.Visible = false; //Le bouton retour est caché au démarrage de l'application
            _obj = this; //Permet d'accéder à la forme Accueil depuis les usercontrols

        }

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            LPAccueil.Visible = true; 
            LPBilan.Visible = false;
            LPDepenses.Visible = false;
            LPEvenements.Visible = false;
            LPParticipants.Visible = false;

            pnlCentre.Controls.Clear(); //On vide la pile de usercontrols 

            lblNomPage.Text = "Accueil";

            conn = new SQLiteConnection(chaine); //Connexion à la base de données

            UCAjoutDepense uc = new UCAjoutDepense(conn); //On charge le usercontrol UCAjoutDepense
            uc.Dock = DockStyle.Fill; //On adapte le usercontrol à la taille du panel
            pnlCentre.Controls.Add(uc); //On ajoute le usercontrol au panel

        }

        private void btnEvenement_Click(object sender, EventArgs e)
        {
            conn.Close(); 
            btnBack.Visible = false;
            nbUcClick = 0; //On réinitialise le numéro de l'élément de la pile de usercontrols
            LPAccueil.Visible = false;
            LPBilan.Visible = false;
            LPDepenses.Visible = false;
            LPParticipants.Visible = false;
            TransitionFlowLayoutPanel(LPEvenements, true, LPEvenements.Width); // animation de la barre de navigation
            pnlCentre.Controls.Clear(); //On vide la pile de usercontrols pour les recharger

            lblNomPage.Text = "Evènements";

            if (!pnlCentre.Controls.ContainsKey("parcours11")) //On vérifie si le usercontrol est déjà chargé
            {
                Parcours11 uc = new Parcours11(conn); //On charge le usercontrol
                uc.Dock = DockStyle.Fill; //On adapte le usercontrol à la taille du panel
                pnlCentre.Controls.Add(uc); //On ajoute le usercontrol au panel
            }
            pnlCentre.Controls["parcours11"].BringToFront(); //On affiche le usercontrol



        }


        private void btnAccueil_Click(object sender, EventArgs e)
        {
            panelCentre.Controls.Clear();
            conn.Close();
            btnBack.Visible = false;
            nbUcClick = 0; //On réinitialise le numéro de l'élément de la pile de usercontrols
            LPEvenements.Visible = false;
            LPBilan.Visible = false;
            LPDepenses.Visible = false;
            LPParticipants.Visible = false;
            TransitionFlowLayoutPanel(LPAccueil, true, LPAccueil.Width); // animation de la barre de navigation
            pnlCentre.Controls.Clear(); //On vide la pile de usercontrols pour les recharger

            lblNomPage.Text = "Accueil";

            if (!pnlCentre.Controls.ContainsKey("UCAjoutDepense")) //On vérifie si le usercontrol est déjà chargé
            {
                UCAjoutDepense uc = new UCAjoutDepense(conn);
                uc.Dock = DockStyle.None;
                pnlCentre.Controls.Add(uc);
            }
            pnlCentre.Controls["UCAjoutDepense"].BringToFront(); //On affiche le usercontrol
        }

        private void btnParticipants_Click(object sender, EventArgs e)
        {
            panelCentre.Controls.Clear(); //On vide le panelCentre
            conn.Close();
            btnBack.Visible = false;
            nbUcClick = 0; //On réinitialise le numéro de l'élément de la pile de usercontrols
            LPEvenements.Visible = false;
            LPBilan.Visible = false;
            LPDepenses.Visible = false;
            LPAccueil.Visible = false;
            TransitionFlowLayoutPanel(LPParticipants, true, LPParticipants.Width); // animation de la barre de navigation
            pnlCentre.Controls.Clear(); //On vide la pile de usercontrols pour les recharger

            lblNomPage.Text = "Participants";

            if (!pnlCentre.Controls.ContainsKey("UCParticipants")) //On vérifie si le usercontrol est déjà chargé
            {
                UCParticipants uc = new UCParticipants(conn);
                uc.Dock = DockStyle.Fill;
                pnlCentre.Controls.Add(uc);
            }
            pnlCentre.Controls["UCParticipants"].BringToFront(); //On affiche le usercontrol

        }

        private void btnDepenses_Click(object sender, EventArgs e)
        {
            panelCentre.Controls.Clear(); //On vide le panelCentre
            conn.Close();
            btnBack.Visible = false;
            nbUcClick = 0; //On réinitialise le numéro de l'élément de la pile de usercontrols
            LPEvenements.Visible = false;
            LPBilan.Visible = false;
            LPParticipants.Visible = false;
            LPAccueil.Visible = false;
            TransitionFlowLayoutPanel(LPDepenses, true, LPDepenses.Width); // animation de la barre de navigation
            pnlCentre.Controls.Clear(); //On vide la pile de usercontrols pour les recharger

            lblNomPage.Text = "Dépenses";

            if (!pnlCentre.Controls.ContainsKey("UCDepense")) //On vérifie si le usercontrol est déjà chargé
            {
                UCDepense uc = new UCDepense(conn);
                uc.Dock = DockStyle.Fill;
                pnlCentre.Controls.Add(uc);
                uc.BringToFront();
            }
            pnlCentre.Controls["UCDepense"].BringToFront(); //On affiche le usercontrol

        }

        private void btnBilan_Click(object sender, EventArgs e)
        {
            panelCentre.Controls.Clear();
            conn.Close();
            btnBack.Visible = false;
            nbUcClick = 0; //On réinitialise le numéro de l'élément de la pile de usercontrols

            LPEvenements.Visible = false;
            LPDepenses.Visible = false;
            LPParticipants.Visible = false;
            LPAccueil.Visible = false;
            TransitionFlowLayoutPanel(LPBilan, true, LPBilan.Width);
            pnlCentre.Controls.Clear();

            lblNomPage.Text = "Bilan";
            pnlCentre.Controls.Clear(); //On vide la pile de usercontrols pour les recharger
            if (!pnlCentre.Controls.ContainsKey("UCBilan")) //On vérifie si le usercontrol est déjà chargé
            {
                UCBilan uc = new UCBilan(conn);
                uc.Dock = DockStyle.Fill;
                pnlCentre.Controls.Add(uc);
                uc.BringToFront();

            }
            pnlCentre.Controls["UCBilan"].BringToFront(); //On affiche le usercontrol

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            conn.Close(); //Ferme la connexion à la base de données
            LPAccueil.Visible = false;
            LPBilan.Visible = false;
            LPDepenses.Visible = false;
            LPEvenements.Visible = false;
            LPParticipants.Visible = false;
            Application.Exit(); //Ferme l'application   
        }

        private void TransitionFlowLayoutPanel(FlowLayoutPanel targetPanel, bool show, int width)
        {
            targetPanel.Visible = true;

            if (show) //Si on veut afficher le FlowLayoutPanel
            {
                targetPanel.Left = -width;

                timerPourLayout.Start();
            }
            else //Si on veut cacher le FlowLayoutPanel
            {
                targetPanel.Visible = false;
            }
        }

        private void timerPourLayout_Tick(object sender, EventArgs e) //Timer pour l'animation de la barre de navigation
        {
            foreach (FlowLayoutPanel panel in new FlowLayoutPanel[] { LPAccueil, LPBilan, LPDepenses, LPEvenements, LPParticipants }) //On parcourt tous les FlowLayoutPanel est on leur applique un timer
            {
                if (panel.Left < 0) //Si le FlowLayoutPanel est caché
                {
                    panel.Left += 10;

                    if (panel.Left >= 0) //Si le FlowLayoutPanel est affiché
                    {
                        panel.Left = 0;

                        timerPourLayout.Stop(); //On arrête le timer
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlCentre.Controls[nbUcClick].BringToFront(); //On affiche le usercontrol précédent
            btnBack.Visible = false;
            nbUcClick = 0; //On réinitialise le numéro du usercontrol
            if (pnlCentre.Controls[nbUcClick].Text == "UCDepense") 
            {
                pnlCentre.Controls.RemoveByKey("UCAjoutNVUtilisateur"); //On supprime le usercontrol ajoutNVUtilisateur pour pouvoir le recharger
            }

        }

        private void pnlTitre_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}