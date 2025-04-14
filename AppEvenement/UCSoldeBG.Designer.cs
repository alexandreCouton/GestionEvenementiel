namespace AppEvenement
{
    partial class UCSoldeBG
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
            this.pnlImage = new System.Windows.Forms.Panel();
            this.lblCodeParticipant = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.TTP = new System.Windows.Forms.ToolTip(this.components);
            this.lblMoins = new System.Windows.Forms.Label();
            this.lblSolde = new System.Windows.Forms.Label();
            this.pnlImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImage
            // 
            this.pnlImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(80)))), ((int)(((byte)(148)))));
            this.pnlImage.Controls.Add(this.lblCodeParticipant);
            this.pnlImage.Location = new System.Drawing.Point(0, -2);
            this.pnlImage.Margin = new System.Windows.Forms.Padding(5);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(76, 71);
            this.pnlImage.TabIndex = 8;
            // 
            // lblCodeParticipant
            // 
            this.lblCodeParticipant.AutoSize = true;
            this.lblCodeParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.2F, System.Drawing.FontStyle.Bold);
            this.lblCodeParticipant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodeParticipant.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCodeParticipant.Location = new System.Drawing.Point(21, 18);
            this.lblCodeParticipant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodeParticipant.Name = "lblCodeParticipant";
            this.lblCodeParticipant.Size = new System.Drawing.Size(33, 35);
            this.lblCodeParticipant.TabIndex = 1;
            this.lblCodeParticipant.Text = "1";
            this.lblCodeParticipant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus.Location = new System.Drawing.Point(291, 24);
            this.lblPlus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(42, 20);
            this.lblPlus.TabIndex = 10;
            this.lblPlus.Text = "Plus";
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(45, 15);
            this.lblNom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(276, 36);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "Nom participant";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoins
            // 
            this.lblMoins.AutoSize = true;
            this.lblMoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoins.Location = new System.Drawing.Point(370, 24);
            this.lblMoins.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMoins.Name = "lblMoins";
            this.lblMoins.Size = new System.Drawing.Size(54, 20);
            this.lblMoins.TabIndex = 11;
            this.lblMoins.Text = "Moins";
            // 
            // lblSolde
            // 
            this.lblSolde.AutoSize = true;
            this.lblSolde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolde.Location = new System.Drawing.Point(447, 24);
            this.lblSolde.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(51, 20);
            this.lblSolde.TabIndex = 12;
            this.lblSolde.Text = "Solde";
            // 
            // UCSoldeBG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSolde);
            this.Controls.Add(this.lblMoins);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.lblNom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCSoldeBG";
            this.Size = new System.Drawing.Size(513, 66);
            this.pnlImage.ResumeLayout(false);
            this.pnlImage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.ToolTip TTP;
        private System.Windows.Forms.Label lblMoins;
        private System.Windows.Forms.Label lblSolde;
        private System.Windows.Forms.Label lblCodeParticipant;
    }
}
