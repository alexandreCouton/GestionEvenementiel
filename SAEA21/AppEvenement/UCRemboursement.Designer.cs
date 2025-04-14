namespace AppEvenement
{
    partial class UCRemboursement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRemboursement));
            this.pnlImage = new System.Windows.Forms.Panel();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblDateEvent = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNbParts = new System.Windows.Forms.Label();
            this.TTP = new System.Windows.Forms.ToolTip(this.components);
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlImage
            // 
            this.pnlImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(80)))), ((int)(((byte)(148)))));
            this.pnlImage.Controls.Add(this.lblMontant);
            this.pnlImage.Controls.Add(this.pictureBox1);
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Margin = new System.Windows.Forms.Padding(5);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(108, 71);
            this.pnlImage.TabIndex = 4;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMontant.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMontant.Location = new System.Drawing.Point(28, 24);
            this.lblMontant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(35, 17);
            this.lblMontant.TabIndex = 1;
            this.lblMontant.Text = "500";
            this.lblMontant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateEvent
            // 
            this.lblDateEvent.AutoSize = true;
            this.lblDateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEvent.Location = new System.Drawing.Point(360, 25);
            this.lblDateEvent.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDateEvent.Name = "lblDateEvent";
            this.lblDateEvent.Size = new System.Drawing.Size(80, 17);
            this.lblDateEvent.TabIndex = 6;
            this.lblDateEvent.Text = "01/01/2024";
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(94, 15);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(276, 36);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description de la depense";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNbParts
            // 
            this.lblNbParts.AutoSize = true;
            this.lblNbParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNbParts.ForeColor = System.Drawing.Color.Black;
            this.lblNbParts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNbParts.Location = new System.Drawing.Point(463, 22);
            this.lblNbParts.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNbParts.Name = "lblNbParts";
            this.lblNbParts.Size = new System.Drawing.Size(23, 25);
            this.lblNbParts.TabIndex = 2;
            this.lblNbParts.Text = "9";
            this.lblNbParts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCRemboursement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lblNbParts);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.lblDateEvent);
            this.Controls.Add(this.lblDescription);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UCRemboursement";
            this.Size = new System.Drawing.Size(513, 66);
            this.pnlImage.ResumeLayout(false);
            this.pnlImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDateEvent;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblNbParts;
        private System.Windows.Forms.ToolTip TTP;
    }
}
