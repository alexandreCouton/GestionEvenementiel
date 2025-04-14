namespace AppEvenement
{
    partial class UCBilanGlobal
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
            this.lblEventSelecText = new System.Windows.Forms.Label();
            this.lblEventSelec = new System.Windows.Forms.Label();
            this.flpDepense = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCodeParticipant = new System.Windows.Forms.Label();
            this.lblSolde = new System.Windows.Forms.Label();
            this.lblMoins = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtQuiDoitQuoi = new System.Windows.Forms.TextBox();
            this.btnQuiDoitQuoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEventSelecText
            // 
            this.lblEventSelecText.AutoSize = true;
            this.lblEventSelecText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblEventSelecText.Location = new System.Drawing.Point(210, 78);
            this.lblEventSelecText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEventSelecText.Name = "lblEventSelecText";
            this.lblEventSelecText.Size = new System.Drawing.Size(335, 29);
            this.lblEventSelecText.TabIndex = 1;
            this.lblEventSelecText.Text = "↓Evènement séléctionné ↓";
            // 
            // lblEventSelec
            // 
            this.lblEventSelec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEventSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventSelec.Location = new System.Drawing.Point(195, 121);
            this.lblEventSelec.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEventSelec.Name = "lblEventSelec";
            this.lblEventSelec.Size = new System.Drawing.Size(326, 44);
            this.lblEventSelec.TabIndex = 2;
            this.lblEventSelec.Text = "EventSelec";
            this.lblEventSelec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpDepense
            // 
            this.flpDepense.AutoScroll = true;
            this.flpDepense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDepense.Location = new System.Drawing.Point(86, 205);
            this.flpDepense.Name = "flpDepense";
            this.flpDepense.Size = new System.Drawing.Size(544, 413);
            this.flpDepense.TabIndex = 13;
            // 
            // lblCodeParticipant
            // 
            this.lblCodeParticipant.AutoSize = true;
            this.lblCodeParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeParticipant.ForeColor = System.Drawing.Color.Black;
            this.lblCodeParticipant.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCodeParticipant.Location = new System.Drawing.Point(97, 175);
            this.lblCodeParticipant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodeParticipant.Name = "lblCodeParticipant";
            this.lblCodeParticipant.Size = new System.Drawing.Size(143, 20);
            this.lblCodeParticipant.TabIndex = 14;
            this.lblCodeParticipant.Text = "CodeParticipant";
            this.lblCodeParticipant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSolde
            // 
            this.lblSolde.AutoSize = true;
            this.lblSolde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolde.ForeColor = System.Drawing.Color.Black;
            this.lblSolde.Location = new System.Drawing.Point(544, 174);
            this.lblSolde.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(64, 24);
            this.lblSolde.TabIndex = 18;
            this.lblSolde.Text = "Solde";
            // 
            // lblMoins
            // 
            this.lblMoins.AutoSize = true;
            this.lblMoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoins.ForeColor = System.Drawing.Color.Black;
            this.lblMoins.Location = new System.Drawing.Point(467, 174);
            this.lblMoins.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMoins.Name = "lblMoins";
            this.lblMoins.Size = new System.Drawing.Size(66, 24);
            this.lblMoins.TabIndex = 17;
            this.lblMoins.Text = "Moins";
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus.ForeColor = System.Drawing.Color.Black;
            this.lblPlus.Location = new System.Drawing.Point(388, 174);
            this.lblPlus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(50, 24);
            this.lblPlus.TabIndex = 16;
            this.lblPlus.Text = "Plus";
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(154, 165);
            this.lblNom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(276, 36);
            this.lblNom.TabIndex = 15;
            this.lblNom.Text = "Nom participant";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuiDoitQuoi
            // 
            this.txtQuiDoitQuoi.BackColor = System.Drawing.Color.White;
            this.txtQuiDoitQuoi.Location = new System.Drawing.Point(658, 205);
            this.txtQuiDoitQuoi.Multiline = true;
            this.txtQuiDoitQuoi.Name = "txtQuiDoitQuoi";
            this.txtQuiDoitQuoi.ReadOnly = true;
            this.txtQuiDoitQuoi.Size = new System.Drawing.Size(504, 413);
            this.txtQuiDoitQuoi.TabIndex = 20;
            // 
            // btnQuiDoitQuoi
            // 
            this.btnQuiDoitQuoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuiDoitQuoi.Location = new System.Drawing.Point(810, 102);
            this.btnQuiDoitQuoi.Name = "btnQuiDoitQuoi";
            this.btnQuiDoitQuoi.Size = new System.Drawing.Size(222, 43);
            this.btnQuiDoitQuoi.TabIndex = 21;
            this.btnQuiDoitQuoi.Text = "Qui doit quoi à qui ?";
            this.btnQuiDoitQuoi.UseVisualStyleBackColor = true;
            this.btnQuiDoitQuoi.Click += new System.EventHandler(this.btnQuiDoitQuoi_Click);
            // 
            // UCBilanGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnQuiDoitQuoi);
            this.Controls.Add(this.txtQuiDoitQuoi);
            this.Controls.Add(this.lblCodeParticipant);
            this.Controls.Add(this.lblSolde);
            this.Controls.Add(this.lblMoins);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.flpDepense);
            this.Controls.Add(this.lblEventSelec);
            this.Controls.Add(this.lblEventSelecText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCBilanGlobal";
            this.Size = new System.Drawing.Size(1177, 653);
            this.Load += new System.EventHandler(this.UCBilanGlobal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventSelecText;
        private System.Windows.Forms.Label lblEventSelec;
        private System.Windows.Forms.FlowLayoutPanel flpDepense;
        private System.Windows.Forms.Label lblCodeParticipant;
        private System.Windows.Forms.Label lblSolde;
        private System.Windows.Forms.Label lblMoins;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtQuiDoitQuoi;
        private System.Windows.Forms.Button btnQuiDoitQuoi;
    }
}
