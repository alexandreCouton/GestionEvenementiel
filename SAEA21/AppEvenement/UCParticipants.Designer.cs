namespace AppEvenement
{
    partial class UCParticipants
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
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.cboSelectEvent = new System.Windows.Forms.ComboBox();
            this.flpParticipant = new System.Windows.Forms.FlowLayoutPanel();
            this.lblQuestion3 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.pnlInviter = new System.Windows.Forms.Panel();
            this.cboParticip = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.TIP = new System.Windows.Forms.ToolTip(this.components);
            this.pnlInviter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.AutoSize = true;
            this.lblQuestion2.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.lblQuestion2.Location = new System.Drawing.Point(270, 32);
            this.lblQuestion2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(312, 34);
            this.lblQuestion2.TabIndex = 0;
            this.lblQuestion2.Text = "Filtrer par évènement ?";
            // 
            // cboSelectEvent
            // 
            this.cboSelectEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectEvent.FormattingEnabled = true;
            this.cboSelectEvent.Location = new System.Drawing.Point(230, 85);
            this.cboSelectEvent.Margin = new System.Windows.Forms.Padding(5);
            this.cboSelectEvent.Name = "cboSelectEvent";
            this.cboSelectEvent.Size = new System.Drawing.Size(400, 37);
            this.cboSelectEvent.TabIndex = 1;
            this.cboSelectEvent.SelectedIndexChanged += new System.EventHandler(this.cboSelectEvent_SelectedIndexChanged);
            // 
            // flpParticipant
            // 
            this.flpParticipant.AutoScroll = true;
            this.flpParticipant.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flpParticipant.Location = new System.Drawing.Point(657, 8);
            this.flpParticipant.Margin = new System.Windows.Forms.Padding(5);
            this.flpParticipant.Name = "flpParticipant";
            this.flpParticipant.Size = new System.Drawing.Size(518, 637);
            this.flpParticipant.TabIndex = 2;
            // 
            // lblQuestion3
            // 
            this.lblQuestion3.AutoSize = true;
            this.lblQuestion3.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.lblQuestion3.Location = new System.Drawing.Point(270, 17);
            this.lblQuestion3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuestion3.Name = "lblQuestion3";
            this.lblQuestion3.Size = new System.Drawing.Size(318, 34);
            this.lblQuestion3.TabIndex = 3;
            this.lblQuestion3.Text = "Filtrer par participant ?";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BackgroundImage = global::AppEvenement.Properties.Resources.boutonBleu;
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.Location = new System.Drawing.Point(369, 440);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(224, 134);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Inviter à l\'évènement";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // pnlInviter
            // 
            this.pnlInviter.Controls.Add(this.cboParticip);
            this.pnlInviter.Controls.Add(this.lblQuestion3);
            this.pnlInviter.Location = new System.Drawing.Point(5, 202);
            this.pnlInviter.Margin = new System.Windows.Forms.Padding(5);
            this.pnlInviter.Name = "pnlInviter";
            this.pnlInviter.Size = new System.Drawing.Size(651, 203);
            this.pnlInviter.TabIndex = 7;
            this.pnlInviter.Visible = false;
            // 
            // cboParticip
            // 
            this.cboParticip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboParticip.FormattingEnabled = true;
            this.cboParticip.Location = new System.Drawing.Point(231, 62);
            this.cboParticip.Margin = new System.Windows.Forms.Padding(5);
            this.cboParticip.Name = "cboParticip";
            this.cboParticip.Size = new System.Drawing.Size(400, 37);
            this.cboParticip.TabIndex = 2;
            this.cboParticip.SelectedIndexChanged += new System.EventHandler(this.cboParticip_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboSelectEvent);
            this.panel1.Controls.Add(this.lblQuestion2);
            this.panel1.Location = new System.Drawing.Point(5, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 141);
            this.panel1.TabIndex = 8;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.BackgroundImage = global::AppEvenement.Properties.Resources.addUser;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Location = new System.Drawing.Point(60, 440);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(193, 134);
            this.btnAddUser.TabIndex = 9;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // UCParticipants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.pnlInviter);
            this.Controls.Add(this.flpParticipant);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "UCParticipants";
            this.Size = new System.Drawing.Size(1180, 650);
            this.Load += new System.EventHandler(this.UCParticipants_Load);
            this.pnlInviter.ResumeLayout(false);
            this.pnlInviter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.ComboBox cboSelectEvent;
        private System.Windows.Forms.FlowLayoutPanel flpParticipant;
        private System.Windows.Forms.Label lblQuestion3;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Panel pnlInviter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ComboBox cboParticip;
        private System.Windows.Forms.ToolTip TIP;
    }
}
