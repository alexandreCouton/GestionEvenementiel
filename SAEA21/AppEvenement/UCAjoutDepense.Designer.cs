namespace AppEvenement
{
    partial class UCAjoutDepense
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
            this.lblQuoi = new System.Windows.Forms.Label();
            this.lblCombien = new System.Windows.Forms.Label();
            this.lblPayerPar = new System.Windows.Forms.Label();
            this.lblBeneficiaires = new System.Windows.Forms.Label();
            this.lblQuand = new System.Windows.Forms.Label();
            this.lblEvenement = new System.Windows.Forms.Label();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.txtQuoi = new System.Windows.Forms.TextBox();
            this.pnlQuoi = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEvenement = new System.Windows.Forms.Panel();
            this.cboEvenement = new AppEvenement.UCComboBox();
            this.lblEtoile = new System.Windows.Forms.Label();
            this.txtCombien = new System.Windows.Forms.TextBox();
            this.pnlCombien = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.pnlPayeur = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboQuiPaye = new AppEvenement.UCComboBox();
            this.chklbBeneficiaires = new System.Windows.Forms.CheckedListBox();
            this.pnlBeneficiaire = new System.Windows.Forms.Panel();
            this.chkTousBeneficiaires = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpQuandCaSePasse = new System.Windows.Forms.DateTimePicker();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.cboCategorie = new AppEvenement.UCComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.pnlCommentaire = new System.Windows.Forms.Panel();
            this.pctF6 = new System.Windows.Forms.PictureBox();
            this.lblMessageObligatoire = new System.Windows.Forms.Label();
            this.pctF4 = new System.Windows.Forms.PictureBox();
            this.pctF3 = new System.Windows.Forms.PictureBox();
            this.pctF2 = new System.Windows.Forms.PictureBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.pctF1 = new System.Windows.Forms.PictureBox();
            this.pctF5 = new System.Windows.Forms.PictureBox();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlQuoi.SuspendLayout();
            this.pnlEvenement.SuspendLayout();
            this.pnlCombien.SuspendLayout();
            this.pnlPayeur.SuspendLayout();
            this.pnlBeneficiaire.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.pnlCommentaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctF6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctF4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctF3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctF2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctF5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuoi
            // 
            this.lblQuoi.AutoSize = true;
            this.lblQuoi.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.lblQuoi.Location = new System.Drawing.Point(15, 30);
            this.lblQuoi.Name = "lblQuoi";
            this.lblQuoi.Size = new System.Drawing.Size(92, 34);
            this.lblQuoi.TabIndex = 1;
            this.lblQuoi.Text = "Quoi ?";
            // 
            // lblCombien
            // 
            this.lblCombien.AutoSize = true;
            this.lblCombien.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.lblCombien.Location = new System.Drawing.Point(14, 3);
            this.lblCombien.Name = "lblCombien";
            this.lblCombien.Size = new System.Drawing.Size(137, 34);
            this.lblCombien.TabIndex = 2;
            this.lblCombien.Text = "Combien ?";
            // 
            // lblPayerPar
            // 
            this.lblPayerPar.AutoSize = true;
            this.lblPayerPar.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.lblPayerPar.Location = new System.Drawing.Point(5, 18);
            this.lblPayerPar.Name = "lblPayerPar";
            this.lblPayerPar.Size = new System.Drawing.Size(307, 34);
            this.lblPayerPar.TabIndex = 3;
            this.lblPayerPar.Text = "Qui paye dans tout ça ?";
            // 
            // lblBeneficiaires
            // 
            this.lblBeneficiaires.AutoSize = true;
            this.lblBeneficiaires.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.lblBeneficiaires.Location = new System.Drawing.Point(119, 17);
            this.lblBeneficiaires.Name = "lblBeneficiaires";
            this.lblBeneficiaires.Size = new System.Drawing.Size(240, 34);
            this.lblBeneficiaires.TabIndex = 4;
            this.lblBeneficiaires.Text = "Qui en bénéficie ? ";
            // 
            // lblQuand
            // 
            this.lblQuand.AutoSize = true;
            this.lblQuand.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.lblQuand.Location = new System.Drawing.Point(54, 17);
            this.lblQuand.Name = "lblQuand";
            this.lblQuand.Size = new System.Drawing.Size(399, 34);
            this.lblQuand.TabIndex = 5;
            this.lblQuand.Text = "Quand est ce que ça se passe ?";
            // 
            // lblEvenement
            // 
            this.lblEvenement.AutoSize = true;
            this.lblEvenement.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.lblEvenement.Location = new System.Drawing.Point(11, 22);
            this.lblEvenement.Name = "lblEvenement";
            this.lblEvenement.Size = new System.Drawing.Size(233, 34);
            this.lblEvenement.TabIndex = 6;
            this.lblEvenement.Text = "Quel évènement ?";
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.lblCommentaire.Location = new System.Drawing.Point(100, 23);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(292, 34);
            this.lblCommentaire.TabIndex = 7;
            this.lblCommentaire.Text = "Un petit mot en plus ?";
            // 
            // txtQuoi
            // 
            this.txtQuoi.Location = new System.Drawing.Point(109, 9);
            this.txtQuoi.Multiline = true;
            this.txtQuoi.Name = "txtQuoi";
            this.txtQuoi.Size = new System.Drawing.Size(264, 82);
            this.txtQuoi.TabIndex = 8;
            this.txtQuoi.TextChanged += new System.EventHandler(this.txtQuoi_TextChanged);
            this.txtQuoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuoi_KeyPress);
            // 
            // pnlQuoi
            // 
            this.pnlQuoi.BackColor = System.Drawing.Color.Transparent;
            this.pnlQuoi.Controls.Add(this.label1);
            this.pnlQuoi.Controls.Add(this.lblQuoi);
            this.pnlQuoi.Controls.Add(this.txtQuoi);
            this.pnlQuoi.Location = new System.Drawing.Point(629, 26);
            this.pnlQuoi.Name = "pnlQuoi";
            this.pnlQuoi.Size = new System.Drawing.Size(469, 94);
            this.pnlQuoi.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(89, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "*";
            // 
            // pnlEvenement
            // 
            this.pnlEvenement.Controls.Add(this.cboEvenement);
            this.pnlEvenement.Controls.Add(this.lblEtoile);
            this.pnlEvenement.Controls.Add(this.lblEvenement);
            this.pnlEvenement.Location = new System.Drawing.Point(25, 35);
            this.pnlEvenement.Name = "pnlEvenement";
            this.pnlEvenement.Size = new System.Drawing.Size(312, 122);
            this.pnlEvenement.TabIndex = 11;
            // 
            // cboEvenement
            // 
            this.cboEvenement.DataSource = null;
            this.cboEvenement.DisplayMember = "";
            this.cboEvenement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboEvenement.Location = new System.Drawing.Point(3, 55);
            this.cboEvenement.Name = "cboEvenement";
            this.cboEvenement.SelectedIndex = -1;
            this.cboEvenement.SelectedItem = null;
            this.cboEvenement.SelectedValue = null;
            this.cboEvenement.Size = new System.Drawing.Size(271, 30);
            this.cboEvenement.TabIndex = 31;
            this.cboEvenement.ValueMember = "";
            this.cboEvenement.SelectedIndexChanged += new System.EventHandler(this.cboEvenement_SelectedIndexChanged_1);
            this.cboEvenement.SelectedValueChanged += new System.EventHandler(this.cboEvenement_SelectedValueChanged);
            this.cboEvenement.SelectionChangeCommitted += new System.EventHandler(this.cboEvenement_SelectionChangeCommitted);
            // 
            // lblEtoile
            // 
            this.lblEtoile.AutoSize = true;
            this.lblEtoile.ForeColor = System.Drawing.Color.Red;
            this.lblEtoile.Location = new System.Drawing.Point(200, 21);
            this.lblEtoile.Name = "lblEtoile";
            this.lblEtoile.Size = new System.Drawing.Size(23, 29);
            this.lblEtoile.TabIndex = 8;
            this.lblEtoile.Text = "*";
            // 
            // txtCombien
            // 
            this.txtCombien.Location = new System.Drawing.Point(15, 37);
            this.txtCombien.Name = "txtCombien";
            this.txtCombien.Size = new System.Drawing.Size(124, 34);
            this.txtCombien.TabIndex = 12;
            this.txtCombien.TextChanged += new System.EventHandler(this.txtCombien_TextChanged);
            this.txtCombien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCombien_KeyPress);
            // 
            // pnlCombien
            // 
            this.pnlCombien.Controls.Add(this.label2);
            this.pnlCombien.Controls.Add(this.txtCombien);
            this.pnlCombien.Controls.Add(this.lblCombien);
            this.pnlCombien.Controls.Add(this.lblEuro);
            this.pnlCombien.Location = new System.Drawing.Point(444, 152);
            this.pnlCombien.Name = "pnlCombien";
            this.pnlCombien.Size = new System.Drawing.Size(185, 95);
            this.pnlCombien.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(119, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "*";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(140, 40);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(26, 29);
            this.lblEuro.TabIndex = 13;
            this.lblEuro.Text = "€";
            // 
            // pnlPayeur
            // 
            this.pnlPayeur.Controls.Add(this.label3);
            this.pnlPayeur.Controls.Add(this.cboQuiPaye);
            this.pnlPayeur.Controls.Add(this.lblPayerPar);
            this.pnlPayeur.Location = new System.Drawing.Point(24, 257);
            this.pnlPayeur.Name = "pnlPayeur";
            this.pnlPayeur.Size = new System.Drawing.Size(327, 111);
            this.pnlPayeur.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(258, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "*";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cboQuiPaye
            // 
            this.cboQuiPaye.DataSource = null;
            this.cboQuiPaye.DisplayMember = "";
            this.cboQuiPaye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboQuiPaye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboQuiPaye.Location = new System.Drawing.Point(10, 67);
            this.cboQuiPaye.Name = "cboQuiPaye";
            this.cboQuiPaye.SelectedIndex = -1;
            this.cboQuiPaye.SelectedItem = null;
            this.cboQuiPaye.SelectedValue = null;
            this.cboQuiPaye.Size = new System.Drawing.Size(265, 27);
            this.cboQuiPaye.TabIndex = 11;
            this.cboQuiPaye.ValueMember = "";
            this.cboQuiPaye.SelectedIndexChanged += new System.EventHandler(this.ucComboBox2_SelectedIndexChanged);
            this.cboQuiPaye.SelectionChangeCommitted += new System.EventHandler(this.cboQuiPaye_SelectionChangeCommitted);
            // 
            // chklbBeneficiaires
            // 
            this.chklbBeneficiaires.CheckOnClick = true;
            this.chklbBeneficiaires.FormattingEnabled = true;
            this.chklbBeneficiaires.HorizontalScrollbar = true;
            this.chklbBeneficiaires.Location = new System.Drawing.Point(35, 91);
            this.chklbBeneficiaires.Name = "chklbBeneficiaires";
            this.chklbBeneficiaires.Size = new System.Drawing.Size(432, 91);
            this.chklbBeneficiaires.TabIndex = 15;
            this.chklbBeneficiaires.SelectedIndexChanged += new System.EventHandler(this.chklbBeneficiaires_SelectedIndexChanged);
            // 
            // pnlBeneficiaire
            // 
            this.pnlBeneficiaire.Controls.Add(this.chkTousBeneficiaires);
            this.pnlBeneficiaire.Controls.Add(this.chklbBeneficiaires);
            this.pnlBeneficiaire.Controls.Add(this.label4);
            this.pnlBeneficiaire.Controls.Add(this.lblBeneficiaires);
            this.pnlBeneficiaire.Location = new System.Drawing.Point(25, 411);
            this.pnlBeneficiaire.Name = "pnlBeneficiaire";
            this.pnlBeneficiaire.Size = new System.Drawing.Size(487, 236);
            this.pnlBeneficiaire.TabIndex = 16;
            // 
            // chkTousBeneficiaires
            // 
            this.chkTousBeneficiaires.AutoSize = true;
            this.chkTousBeneficiaires.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold);
            this.chkTousBeneficiaires.Location = new System.Drawing.Point(135, 57);
            this.chkTousBeneficiaires.Name = "chkTousBeneficiaires";
            this.chkTousBeneficiaires.Size = new System.Drawing.Size(190, 34);
            this.chkTousBeneficiaires.TabIndex = 16;
            this.chkTousBeneficiaires.Text = "Tout le monde";
            this.chkTousBeneficiaires.UseVisualStyleBackColor = true;
            this.chkTousBeneficiaires.CheckedChanged += new System.EventHandler(this.chkTousBeneficiaires_CheckedChanged);
            this.chkTousBeneficiaires.Click += new System.EventHandler(this.chkTousBeneficiaires_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(303, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "*";
            // 
            // dtpQuandCaSePasse
            // 
            this.dtpQuandCaSePasse.Location = new System.Drawing.Point(62, 50);
            this.dtpQuandCaSePasse.Name = "dtpQuandCaSePasse";
            this.dtpQuandCaSePasse.Size = new System.Drawing.Size(374, 34);
            this.dtpQuandCaSePasse.TabIndex = 17;
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.cboCategorie);
            this.pnlDate.Controls.Add(this.label6);
            this.pnlDate.Controls.Add(this.lblCategorie);
            this.pnlDate.Controls.Add(this.dtpQuandCaSePasse);
            this.pnlDate.Controls.Add(this.lblQuand);
            this.pnlDate.Controls.Add(this.label5);
            this.pnlDate.Location = new System.Drawing.Point(537, 442);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(622, 132);
            this.pnlDate.TabIndex = 18;
            // 
            // cboCategorie
            // 
            this.cboCategorie.DataSource = null;
            this.cboCategorie.DisplayMember = "";
            this.cboCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboCategorie.Location = new System.Drawing.Point(221, 95);
            this.cboCategorie.Name = "cboCategorie";
            this.cboCategorie.SelectedIndex = -1;
            this.cboCategorie.SelectedItem = null;
            this.cboCategorie.SelectedValue = null;
            this.cboCategorie.Size = new System.Drawing.Size(206, 30);
            this.cboCategorie.TabIndex = 21;
            this.cboCategorie.ValueMember = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(198, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "*";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.lblCategorie.Location = new System.Drawing.Point(4, 95);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(237, 34);
            this.lblCategorie.TabIndex = 19;
            this.lblCategorie.Text = "Quelle catégorie ?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(387, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "*";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(35, 64);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(411, 148);
            this.txtCommentaire.TabIndex = 19;
            // 
            // pnlCommentaire
            // 
            this.pnlCommentaire.Controls.Add(this.lblCommentaire);
            this.pnlCommentaire.Controls.Add(this.txtCommentaire);
            this.pnlCommentaire.Controls.Add(this.pctF6);
            this.pnlCommentaire.Location = new System.Drawing.Point(668, 184);
            this.pnlCommentaire.Name = "pnlCommentaire";
            this.pnlCommentaire.Size = new System.Drawing.Size(491, 240);
            this.pnlCommentaire.TabIndex = 20;
            // 
            // pctF6
            // 
            this.pctF6.Image = global::AppEvenement.Properties.Resources.f6;
            this.pctF6.Location = new System.Drawing.Point(286, 23);
            this.pctF6.Name = "pctF6";
            this.pctF6.Size = new System.Drawing.Size(223, 229);
            this.pctF6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctF6.TabIndex = 31;
            this.pctF6.TabStop = false;
            // 
            // lblMessageObligatoire
            // 
            this.lblMessageObligatoire.AutoSize = true;
            this.lblMessageObligatoire.ForeColor = System.Drawing.Color.Red;
            this.lblMessageObligatoire.Location = new System.Drawing.Point(19, 3);
            this.lblMessageObligatoire.Name = "lblMessageObligatoire";
            this.lblMessageObligatoire.Size = new System.Drawing.Size(225, 29);
            this.lblMessageObligatoire.TabIndex = 23;
            this.lblMessageObligatoire.Text = "* : saisie obligatoire";
            // 
            // pctF4
            // 
            this.pctF4.Image = global::AppEvenement.Properties.Resources.f4;
            this.pctF4.Location = new System.Drawing.Point(324, 307);
            this.pctF4.Name = "pctF4";
            this.pctF4.Size = new System.Drawing.Size(75, 117);
            this.pctF4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctF4.TabIndex = 29;
            this.pctF4.TabStop = false;
            // 
            // pctF3
            // 
            this.pctF3.Image = global::AppEvenement.Properties.Resources.f3;
            this.pctF3.Location = new System.Drawing.Point(110, 163);
            this.pctF3.Name = "pctF3";
            this.pctF3.Size = new System.Drawing.Size(328, 99);
            this.pctF3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctF3.TabIndex = 28;
            this.pctF3.TabStop = false;
            // 
            // pctF2
            // 
            this.pctF2.Image = global::AppEvenement.Properties.Resources.f2;
            this.pctF2.Location = new System.Drawing.Point(589, 82);
            this.pctF2.Name = "pctF2";
            this.pctF2.Size = new System.Drawing.Size(121, 114);
            this.pctF2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctF2.TabIndex = 27;
            this.pctF2.TabStop = false;
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
            this.btnValider.Location = new System.Drawing.Point(1047, 580);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(130, 67);
            this.btnValider.TabIndex = 24;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackgroundImage = global::AppEvenement.Properties.Resources.boutonAnnuler;
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(89)))), ((int)(((byte)(12)))));
            this.btnAnnuler.Location = new System.Drawing.Point(919, 580);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(130, 67);
            this.btnAnnuler.TabIndex = 22;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // pctF1
            // 
            this.pctF1.BackColor = System.Drawing.Color.Transparent;
            this.pctF1.Image = global::AppEvenement.Properties.Resources.f1;
            this.pctF1.Location = new System.Drawing.Point(319, 55);
            this.pctF1.Name = "pctF1";
            this.pctF1.Size = new System.Drawing.Size(324, 82);
            this.pctF1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctF1.TabIndex = 26;
            this.pctF1.TabStop = false;
            // 
            // pctF5
            // 
            this.pctF5.Image = global::AppEvenement.Properties.Resources.f5;
            this.pctF5.Location = new System.Drawing.Point(388, 350);
            this.pctF5.Name = "pctF5";
            this.pctF5.Size = new System.Drawing.Size(275, 110);
            this.pctF5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctF5.TabIndex = 30;
            this.pctF5.TabStop = false;
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // UCAjoutDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pctF1);
            this.Controls.Add(this.pnlCommentaire);
            this.Controls.Add(this.pctF5);
            this.Controls.Add(this.pctF4);
            this.Controls.Add(this.pctF3);
            this.Controls.Add(this.pctF2);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblMessageObligatoire);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.pnlDate);
            this.Controls.Add(this.pnlBeneficiaire);
            this.Controls.Add(this.pnlPayeur);
            this.Controls.Add(this.pnlCombien);
            this.Controls.Add(this.pnlQuoi);
            this.Controls.Add(this.pnlEvenement);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCAjoutDepense";
            this.Size = new System.Drawing.Size(1180, 650);
            this.Load += new System.EventHandler(this.UCAjoutDepense_Load);
            this.pnlQuoi.ResumeLayout(false);
            this.pnlQuoi.PerformLayout();
            this.pnlEvenement.ResumeLayout(false);
            this.pnlEvenement.PerformLayout();
            this.pnlCombien.ResumeLayout(false);
            this.pnlCombien.PerformLayout();
            this.pnlPayeur.ResumeLayout(false);
            this.pnlPayeur.PerformLayout();
            this.pnlBeneficiaire.ResumeLayout(false);
            this.pnlBeneficiaire.PerformLayout();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.pnlCommentaire.ResumeLayout(false);
            this.pnlCommentaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctF6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctF4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctF3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctF2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctF5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuoi;
        private System.Windows.Forms.Label lblCombien;
        private System.Windows.Forms.Label lblPayerPar;
        private System.Windows.Forms.Label lblBeneficiaires;
        private System.Windows.Forms.Label lblQuand;
        private System.Windows.Forms.Label lblEvenement;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.TextBox txtQuoi;
        private System.Windows.Forms.Panel pnlQuoi;
        private System.Windows.Forms.Panel pnlEvenement;
        private System.Windows.Forms.TextBox txtCombien;
        private System.Windows.Forms.Panel pnlCombien;
        private UCComboBox cboQuiPaye;
        private System.Windows.Forms.Panel pnlPayeur;
        private System.Windows.Forms.CheckedListBox chklbBeneficiaires;
        private System.Windows.Forms.Panel pnlBeneficiaire;
        private System.Windows.Forms.DateTimePicker dtpQuandCaSePasse;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.Panel pnlCommentaire;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblMessageObligatoire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEtoile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.PictureBox pctF1;
        private System.Windows.Forms.PictureBox pctF2;
        private System.Windows.Forms.PictureBox pctF3;
        private System.Windows.Forms.PictureBox pctF4;
        private System.Windows.Forms.PictureBox pctF6;
        private System.Windows.Forms.PictureBox pctF5;
        private UCComboBox cboEvenement;
        private System.Windows.Forms.CheckBox chkTousBeneficiaires;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCategorie;
        private UCComboBox cboCategorie;
    }
}
