namespace AppEvenement
{
    partial class UCLancerInvitation
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnInviter = new System.Windows.Forms.Button();
            this.lblQuestionl1 = new System.Windows.Forms.Label();
            this.btnSansInviter = new System.Windows.Forms.Button();
            this.flpSelectionInvite = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSelection = new System.Windows.Forms.Label();
            this.cboEvenement = new AppEvenement.UCComboBox();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.Location = new System.Drawing.Point(941, 440);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(214, 55);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnInviter
            // 
            this.btnInviter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInviter.Location = new System.Drawing.Point(941, 516);
            this.btnInviter.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnInviter.Name = "btnInviter";
            this.btnInviter.Size = new System.Drawing.Size(214, 55);
            this.btnInviter.TabIndex = 6;
            this.btnInviter.Text = "Inviter";
            this.btnInviter.UseVisualStyleBackColor = true;
            this.btnInviter.Click += new System.EventHandler(this.btnInviter_Click);
            // 
            // lblQuestionl1
            // 
            this.lblQuestionl1.AutoSize = true;
            this.lblQuestionl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionl1.Location = new System.Drawing.Point(28, 20);
            this.lblQuestionl1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuestionl1.Name = "lblQuestionl1";
            this.lblQuestionl1.Size = new System.Drawing.Size(361, 25);
            this.lblQuestionl1.TabIndex = 4;
            this.lblQuestionl1.Text = "Quels sont les invités à cet évènement ?";
            // 
            // btnSansInviter
            // 
            this.btnSansInviter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSansInviter.Location = new System.Drawing.Point(941, 363);
            this.btnSansInviter.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSansInviter.Name = "btnSansInviter";
            this.btnSansInviter.Size = new System.Drawing.Size(214, 57);
            this.btnSansInviter.TabIndex = 8;
            this.btnSansInviter.Text = "Inviter plus tard";
            this.btnSansInviter.UseVisualStyleBackColor = true;
            this.btnSansInviter.Click += new System.EventHandler(this.btnSansInviter_Click);
            // 
            // flpSelectionInvite
            // 
            this.flpSelectionInvite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpSelectionInvite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flpSelectionInvite.Location = new System.Drawing.Point(20, 100);
            this.flpSelectionInvite.Margin = new System.Windows.Forms.Padding(5);
            this.flpSelectionInvite.Name = "flpSelectionInvite";
            this.flpSelectionInvite.Size = new System.Drawing.Size(863, 471);
            this.flpSelectionInvite.TabIndex = 5;
            this.flpSelectionInvite.TabStop = true;
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Location = new System.Drawing.Point(15, 69);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(399, 29);
            this.lblSelection.TabIndex = 10;
            this.lblSelection.Text = "Séléctionnez les personnes à inviter";
            // 
            // cboEvenement
            // 
            this.cboEvenement.DataSource = null;
            this.cboEvenement.DisplayMember = "";
            this.cboEvenement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboEvenement.Location = new System.Drawing.Point(471, 20);
            this.cboEvenement.Name = "cboEvenement";
            this.cboEvenement.SelectedIndex = -1;
            this.cboEvenement.SelectedItem = null;
            this.cboEvenement.SelectedValue = null;
            this.cboEvenement.Size = new System.Drawing.Size(236, 30);
            this.cboEvenement.TabIndex = 11;
            this.cboEvenement.ValueMember = "";
            this.cboEvenement.SelectionChangeCommitted += new System.EventHandler(this.cboEvenement_SelectionChangeCommitted);
            // 
            // UCLancerInvitation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboEvenement);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.flpSelectionInvite);
            this.Controls.Add(this.btnSansInviter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnInviter);
            this.Controls.Add(this.lblQuestionl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "UCLancerInvitation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1180, 650);
            this.Load += new System.EventHandler(this.UCLancerInvitation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnInviter;
        private System.Windows.Forms.Label lblQuestionl1;
        private System.Windows.Forms.Button btnSansInviter;
        private System.Windows.Forms.FlowLayoutPanel flpSelectionInvite;
        private System.Windows.Forms.Label lblSelection;
        private UCComboBox cboEvenement;
    }
}
