using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppEvenement
{
    public partial class UCRemboursement : UserControl
    {
        public UCRemboursement()
        {
            InitializeComponent();
            TTP.SetToolTip(lblNbParts, "Le nombre de parts de la dépense");
            TTP.SetToolTip(lblDateEvent, "La date de la dépense");
            TTP.SetToolTip(lblDescription, "La description de la dépense"); 
            TTP.SetToolTip(lblMontant, "Le montant de la dépense");

        }

        // Propriétés des labels
        private string _montant;
        private string _description;
        private string _date;
        private string _part;

        /* Méthodes pour les propriétés des labels */
        public string Montant // Propriété pour le label Montant
        {
            get { return _montant; }
            set { _montant = value; lblMontant.Text = value; }
        }

        public string Description // Propriété pour le label Description
        {
            get { return _description; }
            set { _description = value; lblDescription.Text = value; }
        }

        public string Date // Propriété pour le label Date
        {
            get { return _date; }
            set { _date = value; lblDateEvent.Text = value; }
        }

        public string Part // Propriété pour le label Part
        {
            get { return _part; }
            set { _part = value; lblNbParts.Text = value; }
        }
    }
}
