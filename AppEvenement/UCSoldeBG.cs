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
    public partial class UCSoldeBG : UserControl
    {
        public UCSoldeBG()
        {
            InitializeComponent();
            TTP.SetToolTip(lblCodeParticipant, "Le code du participant");
            TTP.SetToolTip(lblMoins, "Le \"moins\"");
            TTP.SetToolTip(lblNom, "Le nom du participants");
            TTP.SetToolTip(lblPlus, "Le \"plus\"");
            TTP.SetToolTip(lblSolde, "Le \"solde\"");
        }

        // Propriétés des labels
        private string _codeParticipant;
        private string _nomParticipant;
        private string _plus;
        private string _moins;
        private string _solde;

        /* Méthodes pour les propriétés des labels */
        public string CodeParticipant // Propriété pour le label CodeParticipant
        {
            get { return _codeParticipant; }
            set { _codeParticipant = value; lblCodeParticipant.Text = value; }
        }
        public string NomParticipant // Propriété pour le label Nom
        {
            get { return _nomParticipant; }
            set { _nomParticipant = value; lblNom.Text = value; }
        }
        public string Plus // Propriété pour le label Plus
        {
            get { return _plus; }
            set { _plus = value; lblPlus.Text = value; }
        }
        public string Moins // Propriété pour le label Moins
        {
            get { return _moins; }
            set { _moins = value; lblMoins.Text = value; }
        }
        public string Solde // Propriété pour le label Solde
        {
            get { return _solde; }
            set { _solde = value; lblSolde.Text = value; }
        }
    }
}
