namespace AppEvenement
{
    partial class UCAjoutNVUtilisateur
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNumTel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPart = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.ucCarteInvite = new AppEvenement.UCCarteInvite();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Ink Free", 19.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(373, 43);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(425, 39);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Ajout d\'un nouvel utilisateur";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.lblNom.Location = new System.Drawing.Point(54, 153);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(246, 34);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Quel est son nom ?";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.lblPrenom.Location = new System.Drawing.Point(54, 223);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(287, 34);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Quel est son prénom ?";
            // 
            // lblNumTel
            // 
            this.lblNumTel.AutoSize = true;
            this.lblNumTel.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.lblNumTel.Location = new System.Drawing.Point(54, 288);
            this.lblNumTel.Name = "lblNumTel";
            this.lblNumTel.Size = new System.Drawing.Size(286, 34);
            this.lblNumTel.TabIndex = 3;
            this.lblNumTel.Text = "Quel est son numéro ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(54, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quel est son nombre de part ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(54, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quel est son Email ?";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(380, 149);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(292, 32);
            this.txtNom.TabIndex = 6;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // txtPart
            // 
            this.txtPart.Location = new System.Drawing.Point(380, 346);
            this.txtPart.Name = "txtPart";
            this.txtPart.Size = new System.Drawing.Size(292, 32);
            this.txtPart.TabIndex = 7;
            this.txtPart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(380, 285);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(292, 32);
            this.txtNumero.TabIndex = 8;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(380, 219);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(292, 32);
            this.txtPrenom.TabIndex = 9;
            this.txtPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(380, 403);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 32);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // btnValider
            // 
            this.btnValider.BackgroundImage = global::AppEvenement.Properties.Resources.boutonValider;
            this.btnValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnValider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btnValider.Location = new System.Drawing.Point(1018, 557);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(162, 91);
            this.btnValider.TabIndex = 26;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackgroundImage = global::AppEvenement.Properties.Resources.boutonAnnuler;
            this.btnEffacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEffacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEffacer.FlatAppearance.BorderSize = 0;
            this.btnEffacer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEffacer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffacer.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffacer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(89)))), ((int)(((byte)(12)))));
            this.btnEffacer.Location = new System.Drawing.Point(864, 553);
            this.btnEffacer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(150, 99);
            this.btnEffacer.TabIndex = 28;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // ucCarteInvite
            // 
            this.ucCarteInvite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCarteInvite.Image = null;
            this.ucCarteInvite.Location = new System.Drawing.Point(804, 207);
            this.ucCarteInvite.Margin = new System.Windows.Forms.Padding(5);
            this.ucCarteInvite.Name = "ucCarteInvite";
            this.ucCarteInvite.Nom = null;
            this.ucCarteInvite.Num = null;
            this.ucCarteInvite.Part = null;
            this.ucCarteInvite.Size = new System.Drawing.Size(157, 202);
            this.ucCarteInvite.TabIndex = 11;
            // 
            // UCAjoutNVUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.ucCarteInvite);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtPart);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNumTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCAjoutNVUtilisateur";
            this.Size = new System.Drawing.Size(1180, 650);
            this.Load += new System.EventHandler(this.UCAjoutNVUtilisateur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNumTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPart;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtEmail;
        private UCCarteInvite ucCarteInvite;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnEffacer;
    }
}
