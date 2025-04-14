using Evenement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEvenement
{
    public partial class frmAccueil : Form
    {
        static frmAccueil _obj;

        public static frmAccueil Instance
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

        public Panel panelCentre
        {
            get { return pnlCentre; }
            set { pnlCentre = value; }
        }
        public Button bouttonRetour
        {
            get { return btnBack; }
            set { btnBack = value; }
        }

        public frmAccueil()
        {
            InitializeComponent();
            btnBack.Visible = false;
            _obj = this;
            
        }
        
        private void frmAccueil_Load(object sender, EventArgs e)
        {

            LPAccueil.Visible = true;
            LPBilan.Visible = false;
            LPDepenses.Visible = false;
            LPEvenements.Visible = false;
            LPParticipants.Visible = false;

            pnlCentre.Controls.Clear();

            lblNomPage.Text = "Accueil";

            UCAjoutDepense uc = new UCAjoutDepense();
            uc.Dock = DockStyle.Fill;
            pnlCentre.Controls.Add(uc);

        }

        private void btnEvenement_Click(object sender, EventArgs e)
        {

            TransitionFlowLayoutPanel(LPAccueil, false, LPAccueil.Width);
            TransitionFlowLayoutPanel(LPBilan, false, LPBilan.Width);
            TransitionFlowLayoutPanel(LPDepenses, false, LPDepenses.Width);
            TransitionFlowLayoutPanel(LPParticipants, false, LPParticipants.Width);
            TransitionFlowLayoutPanel(LPEvenements, true, LPEvenements.Width);
            pnlCentre.Controls.Clear();

            lblNomPage.Text = "Evenements";

            if (!pnlCentre.Controls.ContainsKey("parcours11")){
                Parcours11 uc = new Parcours11();
                uc.Dock = DockStyle.Fill;
                pnlCentre.Controls.Add(uc);
            }
            pnlCentre.Controls["parcours11"].BringToFront(); 



        }


        private void btnAccueil_Click(object sender, EventArgs e)
        {

            TransitionFlowLayoutPanel(LPBilan, false, LPBilan.Width);
            TransitionFlowLayoutPanel(LPDepenses, false, LPDepenses.Width);
            TransitionFlowLayoutPanel(LPEvenements, false, LPEvenements.Width);
            TransitionFlowLayoutPanel(LPParticipants, false, LPParticipants.Width);
            TransitionFlowLayoutPanel(LPAccueil, true, LPAccueil.Width);
            pnlCentre.Controls.Clear();

            lblNomPage.Text = "Accueil";

            if (!pnlCentre.Controls.ContainsKey("UCAjoutDepense"))
            {
                UCAjoutDepense uc = new UCAjoutDepense();
                uc.Dock = DockStyle.Fill;
                pnlCentre.Controls.Add(uc);
            }
            pnlCentre.Controls["UCAjoutDepense"].BringToFront();
        }

        private void btnParticipants_Click(object sender, EventArgs e)
        {

            TransitionFlowLayoutPanel(LPAccueil, false, LPAccueil.Width);
            TransitionFlowLayoutPanel(LPBilan, false, LPBilan.Width);
            TransitionFlowLayoutPanel(LPDepenses, false, LPDepenses.Width);
            TransitionFlowLayoutPanel(LPEvenements, false, LPEvenements.Width);
            TransitionFlowLayoutPanel(LPParticipants, true, LPParticipants.Width);
            pnlCentre.Controls.Clear();

            lblNomPage.Text = "Participants";

            if (!pnlCentre.Controls.ContainsKey("UCParticipants"))
            {
                UCParticipants uc = new UCParticipants();
                uc.Dock = DockStyle.Fill;
                pnlCentre.Controls.Add(uc);
            }
            pnlCentre.Controls["UCParticipants"].BringToFront();

        }

        private void btnDepenses_Click(object sender, EventArgs e)
        {
            TransitionFlowLayoutPanel(LPAccueil, false, LPAccueil.Width);
            TransitionFlowLayoutPanel(LPBilan, false, LPBilan.Width);
            TransitionFlowLayoutPanel(LPEvenements, false, LPEvenements.Width);
            TransitionFlowLayoutPanel(LPParticipants, false, LPParticipants.Width);
            TransitionFlowLayoutPanel(LPDepenses, true, LPDepenses.Width);
            pnlCentre.Controls.Clear();

            lblNomPage.Text = "Dépenses";

            if (!pnlCentre.Controls.ContainsKey("UCDepense"))
            {
                UCDepense uc = new UCDepense();
                uc.Dock = DockStyle.Fill;
                pnlCentre.Controls.Add(uc);
            }
            pnlCentre.Controls["UCDepense"].BringToFront();

        }

        private void btnBilan_Click(object sender, EventArgs e)
        {
            pnlCentre.Controls.Clear();

            TransitionFlowLayoutPanel(LPAccueil, false, LPAccueil.Width);
            TransitionFlowLayoutPanel(LPDepenses, false, LPDepenses.Width);
            TransitionFlowLayoutPanel(LPEvenements, false, LPEvenements.Width);
            TransitionFlowLayoutPanel(LPParticipants, false, LPParticipants.Width);
            TransitionFlowLayoutPanel(LPBilan, true, LPBilan.Width);
            pnlCentre.Controls.Clear();

            lblNomPage.Text = "Bilan";

            if (!pnlCentre.Controls.ContainsKey("UCBilan")){
                UCBilan uc = new UCBilan();
                uc.Dock = DockStyle.Fill;
                pnlCentre.Controls.Add(uc);
            }
            pnlCentre.Controls["UCBilan"].BringToFront();

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            LPAccueil.Visible = false;
            LPBilan.Visible = false;
            LPDepenses.Visible = false;
            LPEvenements.Visible = false;
            LPParticipants.Visible = false;
            Application.Exit();
        }
        private void TransitionFlowLayoutPanel(FlowLayoutPanel targetPanel, bool show, int width)
        {
            targetPanel.Visible = true;

            if (show)
            {
                targetPanel.Left = -width;

                timerPourLayout.Start();
            }
            else
            {
                targetPanel.Visible = false;
            }
        }

        private void timerPourLayout_Tick(object sender, EventArgs e)
        {
            foreach (FlowLayoutPanel panel in new FlowLayoutPanel[] { LPAccueil, LPBilan, LPDepenses, LPEvenements, LPParticipants })
            {
                if (panel.Left < 0)
                {
                    panel.Left += 10;

                    if (panel.Left >= 0)
                    {
                        panel.Left = 0;

                        timerPourLayout.Stop();
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlCentre.Controls["parcours11"].BringToFront();
            btnBack.Visible = false;        
        }
    }

}