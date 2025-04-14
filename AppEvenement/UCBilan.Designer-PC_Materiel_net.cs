namespace AppEvenement
{
    partial class UCBilan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBilan));
            this.lblEventN = new System.Windows.Forms.Label();
            this.lblParticip = new System.Windows.Forms.Label();
            this.cboEvent = new System.Windows.Forms.ComboBox();
            this.cboParticip = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDepenser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCeQueJeDois = new System.Windows.Forms.Label();
            this.flpDepense = new System.Windows.Forms.FlowLayoutPanel();
            this.flpGDoit = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDepenseMontant = new System.Windows.Forms.Label();
            this.lblRembMontant = new System.Windows.Forms.Label();
            this.btnBilanGlboal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEventN
            // 
            this.lblEventN.AutoSize = true;
            this.lblEventN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventN.Location = new System.Drawing.Point(141, 29);
            this.lblEventN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEventN.Name = "lblEventN";
            this.lblEventN.Size = new System.Drawing.Size(178, 20);
            this.lblEventN.TabIndex = 0;
            this.lblEventN.Text = "Quelle evenemenet ?";
            // 
            // lblParticip
            // 
            this.lblParticip.AutoSize = true;
            this.lblParticip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticip.Location = new System.Drawing.Point(141, 98);
            this.lblParticip.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblParticip.Name = "lblParticip";
            this.lblParticip.Size = new System.Drawing.Size(165, 20);
            this.lblParticip.TabIndex = 2;
            this.lblParticip.Text = "Quelle participant ?";
            // 
            // cboEvent
            // 
            this.cboEvent.FormattingEnabled = true;
            this.cboEvent.Location = new System.Drawing.Point(370, 24);
            this.cboEvent.Margin = new System.Windows.Forms.Padding(5);
            this.cboEvent.Name = "cboEvent";
            this.cboEvent.Size = new System.Drawing.Size(592, 30);
            this.cboEvent.TabIndex = 3;
            this.cboEvent.SelectionChangeCommitted += new System.EventHandler(this.cboEvent_SelectionChangeCommitted);
            // 
            // cboParticip
            // 
            this.cboParticip.FormattingEnabled = true;
            this.cboParticip.Location = new System.Drawing.Point(370, 93);
            this.cboParticip.Margin = new System.Windows.Forms.Padding(5);
            this.cboParticip.Name = "cboParticip";
            this.cboParticip.Size = new System.Drawing.Size(592, 30);
            this.cboParticip.TabIndex = 4;
            this.cboParticip.SelectionChangeCommitted += new System.EventHandler(this.cboParticip_SelectionChangeCommitted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(779, 171);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblDepenser
            // 
            this.lblDepenser.AutoSize = true;
            this.lblDepenser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepenser.Location = new System.Drawing.Point(141, 191);
            this.lblDepenser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDepenser.Name = "lblDepenser";
            this.lblDepenser.Size = new System.Drawing.Size(167, 17);
            this.lblDepenser.TabIndex = 9;
            this.lblDepenser.Text = "Ce que j\'ai dépensé : ";
            this.lblDepenser.Click += new System.EventHandler(this.lblDepenser_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(76, 171);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // lblCeQueJeDois
            // 
            this.lblCeQueJeDois.AutoSize = true;
            this.lblCeQueJeDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCeQueJeDois.Location = new System.Drawing.Point(853, 191);
            this.lblCeQueJeDois.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCeQueJeDois.Name = "lblCeQueJeDois";
            this.lblCeQueJeDois.Size = new System.Drawing.Size(122, 17);
            this.lblCeQueJeDois.TabIndex = 11;
            this.lblCeQueJeDois.Text = "Ce que je dois :";
            // 
            // flpDepense
            // 
            this.flpDepense.AutoScroll = true;
            this.flpDepense.Location = new System.Drawing.Point(4, 239);
            this.flpDepense.Name = "flpDepense";
            this.flpDepense.Size = new System.Drawing.Size(597, 413);
            this.flpDepense.TabIndex = 12;
            // 
            // flpGDoit
            // 
            this.flpGDoit.AutoScroll = true;
            this.flpGDoit.Location = new System.Drawing.Point(600, 239);
            this.flpGDoit.Name = "flpGDoit";
            this.flpGDoit.Size = new System.Drawing.Size(577, 411);
            this.flpGDoit.TabIndex = 13;
            // 
            // lblDepenseMontant
            // 
            this.lblDepenseMontant.AutoSize = true;
            this.lblDepenseMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepenseMontant.ForeColor = System.Drawing.Color.Red;
            this.lblDepenseMontant.Location = new System.Drawing.Point(304, 192);
            this.lblDepenseMontant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDepenseMontant.Name = "lblDepenseMontant";
            this.lblDepenseMontant.Size = new System.Drawing.Size(41, 18);
            this.lblDepenseMontant.TabIndex = 14;
            this.lblDepenseMontant.Text = "XXX";
            this.lblDepenseMontant.Visible = false;
            // 
            // lblRembMontant
            // 
            this.lblRembMontant.AutoSize = true;
            this.lblRembMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRembMontant.ForeColor = System.Drawing.Color.Red;
            this.lblRembMontant.Location = new System.Drawing.Point(983, 193);
            this.lblRembMontant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRembMontant.Name = "lblRembMontant";
            this.lblRembMontant.Size = new System.Drawing.Size(41, 18);
            this.lblRembMontant.TabIndex = 15;
            this.lblRembMontant.Text = "XXX";
            this.lblRembMontant.Visible = false;
            // 
            // btnBilanGlboal
            // 
            this.btnBilanGlboal.Location = new System.Drawing.Point(1018, 51);
            this.btnBilanGlboal.Name = "btnBilanGlboal";
            this.btnBilanGlboal.Size = new System.Drawing.Size(118, 54);
            this.btnBilanGlboal.TabIndex = 16;
            this.btnBilanGlboal.Text = "button1";
            this.btnBilanGlboal.UseVisualStyleBackColor = true;
            this.btnBilanGlboal.Click += new System.EventHandler(this.btnBilanGlboal_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UCBilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBilanGlboal);
            this.Controls.Add(this.lblRembMontant);
            this.Controls.Add(this.lblDepenseMontant);
            this.Controls.Add(this.flpGDoit);
            this.Controls.Add(this.flpDepense);
            this.Controls.Add(this.lblCeQueJeDois);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDepenser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboParticip);
            this.Controls.Add(this.cboEvent);
            this.Controls.Add(this.lblParticip);
            this.Controls.Add(this.lblEventN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCBilan";
            this.Size = new System.Drawing.Size(1177, 653);
            this.Load += new System.EventHandler(this.UCBilan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventN;
        private System.Windows.Forms.Label lblParticip;
        private System.Windows.Forms.ComboBox cboEvent;
        private System.Windows.Forms.ComboBox cboParticip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDepenser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCeQueJeDois;
        private System.Windows.Forms.FlowLayoutPanel flpDepense;
        private System.Windows.Forms.FlowLayoutPanel flpGDoit;
        private System.Windows.Forms.Label lblDepenseMontant;
        private System.Windows.Forms.Label lblRembMontant;
        private System.Windows.Forms.Button btnBilanGlboal;
        private System.Windows.Forms.Button button1;
    }
}
