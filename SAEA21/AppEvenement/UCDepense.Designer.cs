namespace AppEvenement
{
    partial class UCDepense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDepense));
            this.btnNouvelDep = new System.Windows.Forms.Button();
            this.lblParticip = new System.Windows.Forms.Label();
            this.lblEventN = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flpDepense = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDepenser = new System.Windows.Forms.Label();
            this.cboParticip = new AppEvenement.UCComboBox();
            this.cboEvent = new AppEvenement.UCComboBox();
            this.flpPart = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPart = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAjouterDepense = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNouvelDep
            // 
            this.btnNouvelDep.BackColor = System.Drawing.Color.Transparent;
            this.btnNouvelDep.BackgroundImage = global::AppEvenement.Properties.Resources.boutonBleu;
            this.btnNouvelDep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNouvelDep.FlatAppearance.BorderSize = 0;
            this.btnNouvelDep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNouvelDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouvelDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvelDep.Location = new System.Drawing.Point(923, 29);
            this.btnNouvelDep.Name = "btnNouvelDep";
            this.btnNouvelDep.Size = new System.Drawing.Size(203, 109);
            this.btnNouvelDep.TabIndex = 27;
            this.btnNouvelDep.Text = "Saisir une nouvelle dépense";
            this.btnNouvelDep.UseVisualStyleBackColor = false;
            this.btnNouvelDep.Click += new System.EventHandler(this.btnNouvelDep_Click);
            // 
            // lblParticip
            // 
            this.lblParticip.AutoSize = true;
            this.lblParticip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticip.Location = new System.Drawing.Point(24, 98);
            this.lblParticip.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblParticip.Name = "lblParticip";
            this.lblParticip.Size = new System.Drawing.Size(151, 20);
            this.lblParticip.TabIndex = 29;
            this.lblParticip.Text = "Quel participant ?";
            // 
            // lblEventN
            // 
            this.lblEventN.AutoSize = true;
            this.lblEventN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventN.Location = new System.Drawing.Point(24, 29);
            this.lblEventN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEventN.Name = "lblEventN";
            this.lblEventN.Size = new System.Drawing.Size(154, 20);
            this.lblEventN.TabIndex = 28;
            this.lblEventN.Text = "Quel évènement ?";
            // 
            // flpDepense
            // 
            this.flpDepense.AutoScroll = true;
            this.flpDepense.Location = new System.Drawing.Point(3, 237);
            this.flpDepense.Name = "flpDepense";
            this.flpDepense.Size = new System.Drawing.Size(616, 411);
            this.flpDepense.TabIndex = 36;
            // 
            // lblDepenser
            // 
            this.lblDepenser.AutoSize = true;
            this.lblDepenser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepenser.Location = new System.Drawing.Point(99, 187);
            this.lblDepenser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDepenser.Name = "lblDepenser";
            this.lblDepenser.Size = new System.Drawing.Size(167, 17);
            this.lblDepenser.TabIndex = 33;
            this.lblDepenser.Text = "Ce que j\'ai dépensé : ";
            // 
            // cboParticip
            // 
            this.cboParticip.DataSource = null;
            this.cboParticip.DisplayMember = "";
            this.cboParticip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboParticip.Location = new System.Drawing.Point(253, 98);
            this.cboParticip.Name = "cboParticip";
            this.cboParticip.SelectedIndex = -1;
            this.cboParticip.SelectedItem = null;
            this.cboParticip.SelectedValue = null;
            this.cboParticip.Size = new System.Drawing.Size(592, 30);
            this.cboParticip.TabIndex = 38;
            this.cboParticip.ValueMember = "";
            // 
            // cboEvent
            // 
            this.cboEvent.DataSource = null;
            this.cboEvent.DisplayMember = "";
            this.cboEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboEvent.Location = new System.Drawing.Point(253, 31);
            this.cboEvent.Name = "cboEvent";
            this.cboEvent.SelectedIndex = -1;
            this.cboEvent.SelectedItem = null;
            this.cboEvent.SelectedValue = null;
            this.cboEvent.Size = new System.Drawing.Size(592, 30);
            this.cboEvent.TabIndex = 37;
            this.cboEvent.ValueMember = "";
            this.cboEvent.SelectionChangeCommitted += new System.EventHandler(this.cboEvent_SelectionChangeCommitted);
            // 
            // flpPart
            // 
            this.flpPart.Location = new System.Drawing.Point(621, 237);
            this.flpPart.Name = "flpPart";
            this.flpPart.Size = new System.Drawing.Size(558, 413);
            this.flpPart.TabIndex = 39;
            // 
            // lblPart
            // 
            this.lblPart.AutoSize = true;
            this.lblPart.Location = new System.Drawing.Point(753, 182);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(0, 22);
            this.lblPart.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppEvenement.Properties.Resources.participants;
            this.pictureBox1.Location = new System.Drawing.Point(638, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 167);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // btnAjouterDepense
            // 
            this.btnAjouterDepense.BackgroundImage = global::AppEvenement.Properties.Resources.boutonBleu;
            this.btnAjouterDepense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterDepense.FlatAppearance.BorderSize = 0;
            this.btnAjouterDepense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAjouterDepense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAjouterDepense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterDepense.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterDepense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(194)))));
            this.btnAjouterDepense.Location = new System.Drawing.Point(1238, 923);
            this.btnAjouterDepense.Margin = new System.Windows.Forms.Padding(5);
            this.btnAjouterDepense.Name = "btnAjouterDepense";
            this.btnAjouterDepense.Size = new System.Drawing.Size(211, 109);
            this.btnAjouterDepense.TabIndex = 26;
            this.btnAjouterDepense.Text = "Ajouter";
            this.btnAjouterDepense.UseVisualStyleBackColor = true;
            this.btnAjouterDepense.Click += new System.EventHandler(this.btnAjouterDepense_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackgroundImage = global::AppEvenement.Properties.Resources.boutonValider;
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnValider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btnValider.Location = new System.Drawing.Point(1680, 923);
            this.btnValider.Margin = new System.Windows.Forms.Padding(5);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(211, 109);
            this.btnValider.TabIndex = 25;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackgroundImage = global::AppEvenement.Properties.Resources.boutonAnnuler;
            this.btnEffacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEffacer.FlatAppearance.BorderSize = 0;
            this.btnEffacer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEffacer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffacer.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffacer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(89)))), ((int)(((byte)(12)))));
            this.btnEffacer.Location = new System.Drawing.Point(1459, 923);
            this.btnEffacer.Margin = new System.Windows.Forms.Padding(5);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(211, 109);
            this.btnEffacer.TabIndex = 23;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            // 
            // UCDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPart);
            this.Controls.Add(this.flpPart);
            this.Controls.Add(this.cboParticip);
            this.Controls.Add(this.cboEvent);
            this.Controls.Add(this.flpDepense);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDepenser);
            this.Controls.Add(this.lblParticip);
            this.Controls.Add(this.lblEventN);
            this.Controls.Add(this.btnNouvelDep);
            this.Controls.Add(this.btnAjouterDepense);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnEffacer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCDepense";
            this.Size = new System.Drawing.Size(1180, 650);
            this.Load += new System.EventHandler(this.UCDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAjouterDepense;
        private System.Windows.Forms.Button btnNouvelDep;
        private System.Windows.Forms.Label lblParticip;
        private System.Windows.Forms.Label lblEventN;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FlowLayoutPanel flpDepense;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDepenser;
        private UCComboBox cboEvent;
        private UCComboBox cboParticip;
        private System.Windows.Forms.FlowLayoutPanel flpPart;
        private System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
