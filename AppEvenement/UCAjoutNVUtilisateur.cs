using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEvenement
{
    public partial class UCAjoutNVUtilisateur : UserControl
    {
        SQLiteConnection conn;
        public UCAjoutNVUtilisateur(SQLiteConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            ucCarteInvite.Image = Properties.Resources.icons8_user_94;
            ucCarteInvite.Nom = "Nom Prénom";
            ucCarteInvite.Num = "Num Tel";
            ucCarteInvite.Part = "Part";
            txtEmail.Text = "";
            txtNom.Text = "";
            txtNumero.Text = "";
            txtPart.Text = "";
            txtPrenom.Text = "";
            InitializeTextBoxes();
            if(conn.State!=ConnectionState.Open) { 
            conn.Open();
            }
        }

        private void InitializeTextBoxes()
        {
            txtNom.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            txtPrenom.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            txtNumero.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            txtPart.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            txtEmail.KeyDown += new KeyEventHandler(TextBox_KeyDown);
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // pour enlever le bip
                if (sender == txtNom)
                {
                    txtPrenom.Focus();
                }
                else if (sender == txtPrenom)
                {
                    txtNumero.Focus();
                }
                else if (sender == txtNumero)
                {
                    txtPart.Focus();
                }
                else if (sender == txtPart)
                {
                    txtEmail.Focus();
                }
                else if (sender == txtEmail)
                {
                    btnValider.Focus();
                }
            }
        }

        private void ucCarteInvite_Load(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open) { 
                conn.Open();

            }
            btnValider.Enabled = false;
        }
        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsDigit(e.KeyChar)) //si c'est un espace, un caractère spécial ou un chiffre
            {
                e.Handled = true; //ne pas prendre en compte le caractère
                return;
            }

            if (txtNom.Text == "" || txtPrenom.Text == "" || txtNumero.Text == "" || txtPart.Text == "" || txtEmail.Text == "") //si un des champs est vide
            {
                btnValider.Enabled = false; //le bouton valider est désactivé
            }
            else
            {
                btnValider.Enabled = true;
            }
            ucCarteInvite.Nom = txtNom.Text + " " + txtPrenom.Text; //affichage du nom et prénom sur la carte
            ucCarteInvite.Num = txtNumero.Text; //affichage du numéro de téléphone sur la carte
            ucCarteInvite.Part = txtPart.Text; //affichage du nombre de parts sur la carte
        }

        private void UCAjoutNVUtilisateur_Load(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // récupération des données
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string numeroTel = txtNumero.Text;
            string mail = txtNom.Text;
            int nbPart = int.Parse(txtPart.Text);

            string requeteIDDepense = "select count(*) from Participants"; //récupération du nombre de participants pour l'ID

            SQLiteCommand cdIDDepense = new SQLiteCommand(requeteIDDepense, conn);
            
            int idDernier = Convert.ToInt32(cdIDDepense.ExecuteScalar());
            idDernier++;

            string requeteClient = $@"INSERT INTO Participants (`codeParticipant`, `nomPart`, `prenomPart`, `mobile`, `nbParts`, `adresseMail`) 
                                    VALUES ({idDernier.ToString()},'{nom}','{prenom}','{numeroTel}','{nbPart.ToString()}','{mail}')"; //requête d'ajout du participant
            SQLiteCommand cd = new SQLiteCommand(requeteClient, conn);
            cd.ExecuteNonQuery();
            MessageBox.Show("Ajout effectué avec succès");
                        
            frmAccueil.Instance.panelCentre.Controls.Clear(); //nettoyage du panel pour actualiser les données

            UCParticipants uc = new UCParticipants(conn); 
            uc.Dock = DockStyle.Fill;
            frmAccueil.Instance.panelCentre.Controls.Add(uc);

            // Nettoyage des champs
            frmAccueil.Instance.panelCentre.Controls["UCParticipants"].BringToFront();
            txtEmail.Text = "";
            txtNom.Text = "";
            txtNumero.Text = "";
            txtPart.Text = "";
            txtPrenom.Text = "";
            ucCarteInvite.Nom = "Nom Prénom";
            ucCarteInvite.Num = "Num Tel";
            ucCarteInvite.Part = "Part";
            frmAccueil.Instance.boutonRetour.Visible = false;
            frmAccueil.Instance.nbUcClick = 0;

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            // Nettoyage des champs
            txtEmail.Text = "";
            txtNom.Text = "";
            txtNumero.Text = "";
            txtPart.Text = "";
            txtPrenom.Text = "";
            ucCarteInvite.Nom = "Nom Prénom";
            ucCarteInvite.Num = "Num Tel";
            ucCarteInvite.Part = "Part";
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) //si ce n'est pas un chiffre
            {
                e.Handled = true; //ne pas prendre en compte le caractère
                return;
            }


            if (txtNom.Text == "" || txtPrenom.Text == "" || txtNumero.Text == "" || txtPart.Text == "" || txtEmail.Text == "") // si le champs est vide
            {
                btnValider.Enabled = false; //le bouton valider est désactivé
            }
            else
            {
                btnValider.Enabled = true; //le bouton valider est activé
            }
            // affichage des données sur la carte
            ucCarteInvite.Nom = txtNom.Text + " " + txtPrenom.Text;
            ucCarteInvite.Num = txtNumero.Text;
            ucCarteInvite.Part = txtPart.Text;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (txtNom.Text == "" || txtPrenom.Text == "" || txtNumero.Text == "" || txtPart.Text == "" || txtEmail.Text == "") //si un des champs est vide
            {
                btnValider.Enabled = false; //le bouton valider est désactivé
            }
            else
            {
                btnValider.Enabled = true; //le bouton valider est activé
            }
            // affichage des données sur la carte
            ucCarteInvite.Nom = txtNom.Text + " " + txtPrenom.Text;
            ucCarteInvite.Num = txtNumero.Text;
            ucCarteInvite.Part = txtPart.Text;
        }
    }
}
