namespace NavBar
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnBilan = new System.Windows.Forms.Button();
            this.btnDepenses = new System.Windows.Forms.Button();
            this.btnParticipants = new System.Windows.Forms.Button();
            this.btnEvenement = new System.Windows.Forms.Button();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LPAccueil = new System.Windows.Forms.FlowLayoutPanel();
            this.LPEvenements = new System.Windows.Forms.FlowLayoutPanel();
            this.LPParticipants = new System.Windows.Forms.FlowLayoutPanel();
            this.LPDepenses = new System.Windows.Forms.FlowLayoutPanel();
            this.LPBilan = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNomPage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.LPBilan);
            this.panel1.Controls.Add(this.LPDepenses);
            this.panel1.Controls.Add(this.LPParticipants);
            this.panel1.Controls.Add(this.LPEvenements);
            this.panel1.Controls.Add(this.LPAccueil);
            this.panel1.Controls.Add(this.btnQuitter);
            this.panel1.Controls.Add(this.btnBilan);
            this.panel1.Controls.Add(this.btnDepenses);
            this.panel1.Controls.Add(this.btnParticipants);
            this.panel1.Controls.Add(this.btnEvenement);
            this.panel1.Controls.Add(this.btnAccueil);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 768);
            this.panel1.TabIndex = 0;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Maroon;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Roboto Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitter.Image")));
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnQuitter.Location = new System.Drawing.Point(0, 720);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(182, 45);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnBilan
            // 
            this.btnBilan.FlatAppearance.BorderSize = 0;
            this.btnBilan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.btnBilan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBilan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilan.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnBilan.ForeColor = System.Drawing.Color.White;
            this.btnBilan.Image = ((System.Drawing.Image)(resources.GetObject("btnBilan.Image")));
            this.btnBilan.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBilan.Location = new System.Drawing.Point(0, 538);
            this.btnBilan.Name = "btnBilan";
            this.btnBilan.Size = new System.Drawing.Size(182, 45);
            this.btnBilan.TabIndex = 7;
            this.btnBilan.Text = "Bilan";
            this.btnBilan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBilan.UseVisualStyleBackColor = true;
            this.btnBilan.Click += new System.EventHandler(this.btnBilan_Click);
            // 
            // btnDepenses
            // 
            this.btnDepenses.FlatAppearance.BorderSize = 0;
            this.btnDepenses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.btnDepenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDepenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepenses.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnDepenses.ForeColor = System.Drawing.Color.White;
            this.btnDepenses.Image = ((System.Drawing.Image)(resources.GetObject("btnDepenses.Image")));
            this.btnDepenses.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDepenses.Location = new System.Drawing.Point(0, 451);
            this.btnDepenses.Name = "btnDepenses";
            this.btnDepenses.Size = new System.Drawing.Size(182, 45);
            this.btnDepenses.TabIndex = 6;
            this.btnDepenses.Text = "Dépenses";
            this.btnDepenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepenses.UseVisualStyleBackColor = true;
            this.btnDepenses.Click += new System.EventHandler(this.btnDepenses_Click);
            // 
            // btnParticipants
            // 
            this.btnParticipants.FlatAppearance.BorderSize = 0;
            this.btnParticipants.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.btnParticipants.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnParticipants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParticipants.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnParticipants.ForeColor = System.Drawing.Color.White;
            this.btnParticipants.Image = ((System.Drawing.Image)(resources.GetObject("btnParticipants.Image")));
            this.btnParticipants.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnParticipants.Location = new System.Drawing.Point(0, 370);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Size = new System.Drawing.Size(182, 45);
            this.btnParticipants.TabIndex = 5;
            this.btnParticipants.Text = "Participants";
            this.btnParticipants.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParticipants.UseVisualStyleBackColor = true;
            this.btnParticipants.Click += new System.EventHandler(this.btnParticipants_Click);
            // 
            // btnEvenement
            // 
            this.btnEvenement.FlatAppearance.BorderSize = 0;
            this.btnEvenement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.btnEvenement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEvenement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvenement.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnEvenement.ForeColor = System.Drawing.Color.White;
            this.btnEvenement.Image = ((System.Drawing.Image)(resources.GetObject("btnEvenement.Image")));
            this.btnEvenement.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEvenement.Location = new System.Drawing.Point(0, 285);
            this.btnEvenement.Name = "btnEvenement";
            this.btnEvenement.Size = new System.Drawing.Size(182, 45);
            this.btnEvenement.TabIndex = 4;
            this.btnEvenement.Text = "Evenements";
            this.btnEvenement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvenement.UseVisualStyleBackColor = true;
            this.btnEvenement.Click += new System.EventHandler(this.btnEvenement_Click);
            // 
            // btnAccueil
            // 
            this.btnAccueil.FlatAppearance.BorderSize = 0;
            this.btnAccueil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.btnAccueil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccueil.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnAccueil.ForeColor = System.Drawing.Color.White;
            this.btnAccueil.Image = ((System.Drawing.Image)(resources.GetObject("btnAccueil.Image")));
            this.btnAccueil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAccueil.Location = new System.Drawing.Point(0, 202);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(182, 45);
            this.btnAccueil.TabIndex = 3;
            this.btnAccueil.Text = "Accueil";
            this.btnAccueil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblNomPage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(182, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 116);
            this.panel2.TabIndex = 1;
            // 
            // LPAccueil
            // 
            this.LPAccueil.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LPAccueil.Location = new System.Drawing.Point(0, 244);
            this.LPAccueil.Name = "LPAccueil";
            this.LPAccueil.Size = new System.Drawing.Size(185, 4);
            this.LPAccueil.TabIndex = 9;
            // 
            // LPEvenements
            // 
            this.LPEvenements.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LPEvenements.Location = new System.Drawing.Point(0, 326);
            this.LPEvenements.Name = "LPEvenements";
            this.LPEvenements.Size = new System.Drawing.Size(185, 4);
            this.LPEvenements.TabIndex = 10;
            // 
            // LPParticipants
            // 
            this.LPParticipants.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LPParticipants.Location = new System.Drawing.Point(0, 411);
            this.LPParticipants.Name = "LPParticipants";
            this.LPParticipants.Size = new System.Drawing.Size(185, 4);
            this.LPParticipants.TabIndex = 10;
            // 
            // LPDepenses
            // 
            this.LPDepenses.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LPDepenses.Location = new System.Drawing.Point(0, 492);
            this.LPDepenses.Name = "LPDepenses";
            this.LPDepenses.Size = new System.Drawing.Size(185, 4);
            this.LPDepenses.TabIndex = 11;
            // 
            // LPBilan
            // 
            this.LPBilan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LPBilan.Location = new System.Drawing.Point(0, 579);
            this.LPBilan.Name = "LPBilan";
            this.LPBilan.Size = new System.Drawing.Size(185, 4);
            this.LPBilan.TabIndex = 10;
            // 
            // lblNomPage
            // 
            this.lblNomPage.AutoSize = true;
            this.lblNomPage.Font = new System.Drawing.Font("Roboto Black", 30.2F, System.Drawing.FontStyle.Bold);
            this.lblNomPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.lblNomPage.Location = new System.Drawing.Point(61, 32);
            this.lblNomPage.Name = "lblNomPage";
            this.lblNomPage.Size = new System.Drawing.Size(169, 61);
            this.lblNomPage.TabIndex = 0;
            this.lblNomPage.Text = "label1";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1366, 768);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBilan;
        private System.Windows.Forms.Button btnDepenses;
        private System.Windows.Forms.Button btnParticipants;
        private System.Windows.Forms.Button btnEvenement;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.FlowLayoutPanel LPAccueil;
        private System.Windows.Forms.FlowLayoutPanel LPParticipants;
        private System.Windows.Forms.FlowLayoutPanel LPEvenements;
        private System.Windows.Forms.FlowLayoutPanel LPBilan;
        private System.Windows.Forms.FlowLayoutPanel LPDepenses;
        private System.Windows.Forms.Label lblNomPage;
    }
}
