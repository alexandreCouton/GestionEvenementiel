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
    public partial class UCAjoutNVUtilisateur : UserControl
    {
        public UCAjoutNVUtilisateur()
        {
            InitializeComponent();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            //ucCarteInvite.Name = txtNom.Text + txtPrenom.Text;
            //ucCarteInvite.Num = txtNumero.Text;
            //ucCarteInvite.Part = txtPart.Text;
        }

        private void ucCarteInvite_Load(object sender, EventArgs e)
        {

        }
        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ucCarteInvite.Name = txtNom.Text + txtPrenom.Text;
            //ucCarteInvite.Num = txtNumero.Text;
            //ucCarteInvite.Part = txtPart.Text;
            //ucCarteInvite.BringToFront();
        }
    }
}
