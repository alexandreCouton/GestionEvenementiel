namespace AppEvenement
{
    partial class frmAccueil
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.LPBilan = new System.Windows.Forms.FlowLayoutPanel();
            this.LPDepenses = new System.Windows.Forms.FlowLayoutPanel();
            this.LPParticipants = new System.Windows.Forms.FlowLayoutPanel();
            this.LPEvenements = new System.Windows.Forms.FlowLayoutPanel();
            this.LPAccueil = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnBilan = new System.Windows.Forms.Button();
            this.btnDepenses = new System.Windows.Forms.Button();
            this.btnParticipants = new System.Windows.Forms.Button();
            this.btnEvenement = new System.Windows.Forms.Button();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNomPage = new System.Windows.Forms.Label();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.timerPourLayout = new System.Windows.Forms.Timer(this.components);
            this.pnlCentre = new System.Windows.Forms.Panel();
            this.pnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.pnlNavigation.Controls.Add(this.LPBilan);
            this.pnlNavigation.Controls.Add(this.LPDepenses);
            this.pnlNavigation.Controls.Add(this.LPParticipants);
            this.pnlNavigation.Controls.Add(this.LPEvenements);
            this.pnlNavigation.Controls.Add(this.LPAccueil);
            this.pnlNavigation.Controls.Add(this.btnQuitter);
            this.pnlNavigation.Controls.Add(this.btnBilan);
            this.pnlNavigation.Controls.Add(this.btnDepenses);
            this.pnlNavigation.Controls.Add(this.btnParticipants);
            this.pnlNavigation.Controls.Add(this.btnEvenement);
            this.pnlNavigation.Controls.Add(this.btnAccueil);
            this.pnlNavigation.Controls.Add(this.pictureBox1);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(182, 768);
            this.pnlNavigation.TabIndex = 2;
            // 
            // LPBilan
            // 
            this.LPBilan.BackColor = System.Drawing.Color.RoyalBlue;
            this.LPBilan.Location = new System.Drawing.Point(0, 579);
            this.LPBilan.Name = "LPBilan";
            this.LPBilan.Size = new System.Drawing.Size(185, 4);
            this.LPBilan.TabIndex = 10;
            // 
            // LPDepenses
            // 
            this.LPDepenses.BackColor = System.Drawing.Color.RoyalBlue;
            this.LPDepenses.Location = new System.Drawing.Point(0, 492);
            this.LPDepenses.Name = "LPDepenses";
            this.LPDepenses.Size = new System.Drawing.Size(185, 4);
            this.LPDepenses.TabIndex = 11;
            // 
            // LPParticipants
            // 
            this.LPParticipants.BackColor = System.Drawing.Color.RoyalBlue;
            this.LPParticipants.Location = new System.Drawing.Point(0, 411);
            this.LPParticipants.Name = "LPParticipants";
            this.LPParticipants.Size = new System.Drawing.Size(185, 4);
            this.LPParticipants.TabIndex = 10;
            // 
            // LPEvenements
            // 
            this.LPEvenements.BackColor = System.Drawing.Color.RoyalBlue;
            this.LPEvenements.Location = new System.Drawing.Point(0, 326);
            this.LPEvenements.Name = "LPEvenements";
            this.LPEvenements.Size = new System.Drawing.Size(185, 4);
            this.LPEvenements.TabIndex = 10;
            // 
            // LPAccueil
            // 
            this.LPAccueil.BackColor = System.Drawing.Color.RoyalBlue;
            this.LPAccueil.Location = new System.Drawing.Point(0, 244);
            this.LPAccueil.Name = "LPAccueil";
            this.LPAccueil.Size = new System.Drawing.Size(185, 4);
            this.LPAccueil.TabIndex = 9;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Maroon;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitter.Image")));
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnQuitter.Location = new System.Drawing.Point(0, 711);
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
            this.btnBilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
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
            this.btnDepenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
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
            this.btnParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
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
            this.btnEvenement.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnEvenement.ForeColor = System.Drawing.Color.White;
            this.btnEvenement.Image = ((System.Drawing.Image)(resources.GetObject("btnEvenement.Image")));
            this.btnEvenement.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEvenement.Location = new System.Drawing.Point(0, 285);
            this.btnEvenement.Name = "btnEvenement";
            this.btnEvenement.Size = new System.Drawing.Size(182, 45);
            this.btnEvenement.TabIndex = 4;
            this.btnEvenement.Text = "Evènements";
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
            this.btnAccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
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
            // lblNomPage
            // 
            this.lblNomPage.AutoSize = true;
            this.lblNomPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.2F, System.Drawing.FontStyle.Bold);
            this.lblNomPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.lblNomPage.Location = new System.Drawing.Point(362, 32);
            this.lblNomPage.Name = "lblNomPage";
            this.lblNomPage.Size = new System.Drawing.Size(165, 59);
            this.lblNomPage.TabIndex = 0;
            this.lblNomPage.Text = "label1";
            // 
            // pnlTitre
            // 
            this.pnlTitre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlTitre.Controls.Add(this.label1);
            this.pnlTitre.Controls.Add(this.pictureBox3);
            this.pnlTitre.Controls.Add(this.pictureBox2);
            this.pnlTitre.Controls.Add(this.btnBack);
            this.pnlTitre.Controls.Add(this.lblNomPage);
            this.pnlTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitre.Location = new System.Drawing.Point(182, 0);
            this.pnlTitre.Name = "pnlTitre";
            this.pnlTitre.Size = new System.Drawing.Size(1184, 116);
            this.pnlTitre.TabIndex = 3;
            this.pnlTitre.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitre_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(696, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "MoneyMates";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AppEvenement.Properties.Resources._3TraitInverse;
            this.pictureBox3.Location = new System.Drawing.Point(964, -12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(235, 128);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppEvenement.Properties.Resources._3Trait;
            this.pictureBox2.Location = new System.Drawing.Point(-5, -9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 132);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(230, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 56);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // timerPourLayout
            // 
            this.timerPourLayout.Interval = 10;
            this.timerPourLayout.Tick += new System.EventHandler(this.timerPourLayout_Tick);
            // 
            // pnlCentre
            // 
            this.pnlCentre.BackColor = System.Drawing.SystemColors.Window;
            this.pnlCentre.Location = new System.Drawing.Point(182, 116);
            this.pnlCentre.Name = "pnlCentre";
            this.pnlCentre.Size = new System.Drawing.Size(1184, 652);
            this.pnlCentre.TabIndex = 4;
            // 
            // frmAccueil
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlCentre);
            this.Controls.Add(this.pnlTitre);
            this.Controls.Add(this.pnlNavigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de dépenses";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.pnlNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.FlowLayoutPanel LPBilan;
        private System.Windows.Forms.FlowLayoutPanel LPDepenses;
        private System.Windows.Forms.FlowLayoutPanel LPParticipants;
        private System.Windows.Forms.FlowLayoutPanel LPEvenements;
        private System.Windows.Forms.FlowLayoutPanel LPAccueil;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnBilan;
        private System.Windows.Forms.Button btnDepenses;
        private System.Windows.Forms.Button btnParticipants;
        private System.Windows.Forms.Button btnEvenement;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNomPage;
        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Timer timerPourLayout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlCentre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}

