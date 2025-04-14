using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavBar
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            LPAccueil.Visible = true;
            LPBilan.Visible = false;
            LPDepenses.Visible = false;
            LPEvenements.Visible = false;
            LPParticipants.Visible = false;

            lblNomPage.Text = "Accueil";
        }

        private void btnEvenement_Click(object sender, EventArgs e)
        {
            LPAccueil.Visible = false;
            LPBilan.Visible = false;
            LPDepenses.Visible = false;
            LPEvenements.Visible = true;
            LPParticipants.Visible = false;
            lblNomPage.Text = "Evenements";
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            LPAccueil.Visible = true;
            LPBilan.Visible = false;
            LPDepenses.Visible = false;
            LPEvenements.Visible = false;
            LPParticipants.Visible = false;
            lblNomPage.Text = "Accueil";
        }

        private void btnParticipants_Click(object sender, EventArgs e)
        {
            LPAccueil.Visible = false;
            LPBilan.Visible = false;
            LPDepenses.Visible = false;
            LPEvenements.Visible = false;
            LPParticipants.Visible = true;
            lblNomPage.Text = "Participants";
        }

        private void btnDepenses_Click(object sender, EventArgs e)
        {
            LPAccueil.Visible = false;
            LPBilan.Visible = false;
            LPDepenses.Visible = true;
            LPEvenements.Visible = false;
            LPParticipants.Visible = false;
            lblNomPage.Text = "Dépenses";
        }

        private void btnBilan_Click(object sender, EventArgs e)
        {
            LPAccueil.Visible = false;
            LPBilan.Visible = true;
            LPDepenses.Visible = false;
            LPEvenements.Visible = false;
            LPParticipants.Visible = false;
            lblNomPage.Text = "Bilan";
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
    }
}
