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
    public partial class UCArgent : UserControl
    {
        public UCArgent()
        {
            InitializeComponent();
        }
        //Déclaration des variables 
        private string _montant;
        private string _description;
        private string _date;

        /*Déclaration des propriétés pour les variables ci-dessus
         * Les propriétés permettent de définir les valeurs des variables ci-dessus
         * et de les afficher dans les labels correspondants
         */
        public string Montant // Propriété pour le montant
        {
            get { return _montant; }
            set { _montant = value; lblMontant.Text = value; }
        }

        public string Description // Propriété pour la description
        {
            get { return _description; }
            set { _description = value; lblDescription.Text = value; }
        }

        public string Date // Propriété pour la date
        {
            get { return _date; }
            set { _date = value; lblDateEvent.Text = value; }
        }

    }
}
