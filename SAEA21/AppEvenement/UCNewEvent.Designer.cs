namespace AppEvenement
{
    partial class UCNewEvent
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
            this.lblTitreEvent = new System.Windows.Forms.Label();
            this.lblDebut = new System.Windows.Forms.Label();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDescriptioon = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblCreateur = new System.Windows.Forms.Label();
            this.cboCreateur = new AppEvenement.UCComboBox();
            this.SuspendLayout();
            // 
            // lblTitreEvent
            // 
            this.lblTitreEvent.AutoSize = true;
            this.lblTitreEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreEvent.Location = new System.Drawing.Point(136, 66);
            this.lblTitreEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreEvent.Name = "lblTitreEvent";
            this.lblTitreEvent.Size = new System.Drawing.Size(322, 29);
            this.lblTitreEvent.TabIndex = 1;
            this.lblTitreEvent.Text = "Entrez le titre de l\'événement";
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebut.Location = new System.Drawing.Point(45, 199);
            this.lblDebut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(182, 29);
            this.lblDebut.TabIndex = 2;
            this.lblDebut.Text = "Date de début : ";
            // 
            // txtEvent
            // 
            this.txtEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvent.Location = new System.Drawing.Point(446, 63);
            this.txtEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(547, 34);
            this.txtEvent.TabIndex = 3;
            this.txtEvent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEvent_KeyPress);
            // 
            // dtpDebut
            // 
            this.dtpDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDebut.Location = new System.Drawing.Point(50, 232);
            this.dtpDebut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(334, 34);
            this.dtpDebut.TabIndex = 4;
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Location = new System.Drawing.Point(660, 232);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(385, 34);
            this.dtpFin.TabIndex = 5;
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFin.Location = new System.Drawing.Point(659, 199);
            this.lblDateFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(146, 29);
            this.lblDateFin.TabIndex = 6;
            this.lblDateFin.Text = "Date de fin : ";
            // 
            // lblDescriptioon
            // 
            this.lblDescriptioon.AutoSize = true;
            this.lblDescriptioon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptioon.Location = new System.Drawing.Point(45, 314);
            this.lblDescriptioon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriptioon.Name = "lblDescriptioon";
            this.lblDescriptioon.Size = new System.Drawing.Size(322, 29);
            this.lblDescriptioon.TabIndex = 7;
            this.lblDescriptioon.Text = "Description de l\'évènement  :";
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(50, 347);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(1068, 216);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEvent_KeyPress);
            // 
            // btnValider
            // 
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnValider.Location = new System.Drawing.Point(277, 583);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(557, 31);
            this.btnValider.TabIndex = 9;
            this.btnValider.Text = "Suivant";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblCreateur
            // 
            this.lblCreateur.AutoSize = true;
            this.lblCreateur.Location = new System.Drawing.Point(205, 135);
            this.lblCreateur.Name = "lblCreateur";
            this.lblCreateur.Size = new System.Drawing.Size(258, 29);
            this.lblCreateur.TabIndex = 11;
            this.lblCreateur.Text = "Qui crée l\'événement ?";
            // 
            // cboCreateur
            // 
            this.cboCreateur.DataSource = null;
            this.cboCreateur.DisplayMember = "";
            this.cboCreateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboCreateur.Location = new System.Drawing.Point(487, 134);
            this.cboCreateur.Name = "cboCreateur";
            this.cboCreateur.SelectedIndex = -1;
            this.cboCreateur.SelectedItem = null;
            this.cboCreateur.SelectedValue = null;
            this.cboCreateur.Size = new System.Drawing.Size(206, 30);
            this.cboCreateur.TabIndex = 10;
            this.cboCreateur.ValueMember = "";
            // 
            // UCNewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCreateur);
            this.Controls.Add(this.cboCreateur);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescriptioon);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.lblDebut);
            this.Controls.Add(this.lblTitreEvent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCNewEvent";
            this.Size = new System.Drawing.Size(1180, 650);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitreEvent;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDescriptioon;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnValider;
        private UCComboBox cboCreateur;
        private System.Windows.Forms.Label lblCreateur;
    }
}
