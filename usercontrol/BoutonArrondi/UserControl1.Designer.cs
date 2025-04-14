namespace BoutonArrondi
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
            this.btnBouton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBouton
            // 
            this.btnBouton.FlatAppearance.BorderSize = 0;
            this.btnBouton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBouton.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBouton.ForeColor = System.Drawing.Color.White;
            this.btnBouton.Image = ((System.Drawing.Image)(resources.GetObject("btnBouton.Image")));
            this.btnBouton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBouton.Location = new System.Drawing.Point(299, 176);
            this.btnBouton.Name = "btnBouton";
            this.btnBouton.Size = new System.Drawing.Size(111, 45);
            this.btnBouton.TabIndex = 2;
            this.btnBouton.Text = "Lorem";
            this.btnBouton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBouton.UseVisualStyleBackColor = true;
            this.btnBouton.Click += new System.EventHandler(this.btnBouton_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBouton);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBouton;
    }
}
