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
    public partial class UCCarteInvite : UserControl
    {
        public UCCarteInvite()
        {
            InitializeComponent();
        }
        //Déclaration des variables
        private string _Nom;
        private string _Num;
        private string _Part;
        private Image _Image;

        /*
         * Méthode qui permet de récupérer et de modifier les valeurs des variables
         * Elles permettent de modifier les valeurs des labels et de l'image
         */
        public string Nom //Modification du texte du label Nom
        {
            get { return _Nom; }
            set { _Nom = value; lblNom.Text = value; }
        }

        public string Num //Modification du texte du label Num
        {
            get { return _Num; }
            set { _Num = value; lblNumTel.Text = value; }
        }
        public string Part //Modification du texte du label Part
        {
            get { return _Part; }
            set { _Part = value; lblPart.Text = value; }
        }

        public Image Image //Modification de l'image
        {
            get { return _Image; }
            set { _Image = value; pictureBox1.Image = value; }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UCCarteInvite_Load(object sender, EventArgs e)
        {

        }
    }
}
