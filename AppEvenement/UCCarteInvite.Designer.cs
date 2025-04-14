namespace AppEvenement
{
    partial class UCCarteInvite
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblNumTel = new System.Windows.Forms.Label();
            this.lblPart = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(8, 99);
            this.lblNom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(141, 50);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom Prenom";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNom.Click += new System.EventHandler(this.UCCarteInvite_Load);
            // 
            // lblNumTel
            // 
            this.lblNumTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTel.Location = new System.Drawing.Point(0, 147);
            this.lblNumTel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumTel.Name = "lblNumTel";
            this.lblNumTel.Size = new System.Drawing.Size(157, 30);
            this.lblNumTel.TabIndex = 2;
            this.lblNumTel.Text = "Num Tel";
            this.lblNumTel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNumTel.Click += new System.EventHandler(this.UCCarteInvite_Load);
            // 
            // lblPart
            // 
            this.lblPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPart.Location = new System.Drawing.Point(8, 165);
            this.lblPart.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(141, 36);
            this.lblPart.TabIndex = 3;
            this.lblPart.Text = "Part";
            this.lblPart.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPart.Click += new System.EventHandler(this.UCCarteInvite_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppEvenement.Properties.Resources.icons8_user_94;
            this.pictureBox1.Location = new System.Drawing.Point(33, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.UCCarteInvite_Load);
            // 
            // UCCarteInvite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPart);
            this.Controls.Add(this.lblNumTel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCCarteInvite";
            this.Size = new System.Drawing.Size(157, 202);
            this.Load += new System.EventHandler(this.UCCarteInvite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNumTel;
        private System.Windows.Forms.Label lblPart;
    }
}
