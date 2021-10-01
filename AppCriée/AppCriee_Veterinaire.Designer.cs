
namespace AppCriée
{
    partial class AppCriee_Veterinaire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbc_veterinaire = new System.Windows.Forms.TabControl();
            this.tbp_veterinaire_accueil = new System.Windows.Forms.TabPage();
            this.lbl_veterinaire_accueil_role = new System.Windows.Forms.Label();
            this.lbl_veterinaire_accueil_bienvenue = new System.Windows.Forms.Label();
            this.tbp_veterinaire_bacpoisson = new System.Windows.Forms.TabPage();
            this.tbc_veterinaire.SuspendLayout();
            this.tbp_veterinaire_accueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_veterinaire
            // 
            this.tbc_veterinaire.Controls.Add(this.tbp_veterinaire_accueil);
            this.tbc_veterinaire.Controls.Add(this.tbp_veterinaire_bacpoisson);
            this.tbc_veterinaire.Location = new System.Drawing.Point(0, 0);
            this.tbc_veterinaire.Name = "tbc_veterinaire";
            this.tbc_veterinaire.SelectedIndex = 0;
            this.tbc_veterinaire.Size = new System.Drawing.Size(906, 486);
            this.tbc_veterinaire.TabIndex = 0;
            // 
            // tbp_veterinaire_accueil
            // 
            this.tbp_veterinaire_accueil.Controls.Add(this.lbl_veterinaire_accueil_role);
            this.tbp_veterinaire_accueil.Controls.Add(this.lbl_veterinaire_accueil_bienvenue);
            this.tbp_veterinaire_accueil.Location = new System.Drawing.Point(4, 25);
            this.tbp_veterinaire_accueil.Name = "tbp_veterinaire_accueil";
            this.tbp_veterinaire_accueil.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_veterinaire_accueil.Size = new System.Drawing.Size(898, 457);
            this.tbp_veterinaire_accueil.TabIndex = 0;
            this.tbp_veterinaire_accueil.Text = "Accueil";
            this.tbp_veterinaire_accueil.UseVisualStyleBackColor = true;
            // 
            // lbl_veterinaire_accueil_role
            // 
            this.lbl_veterinaire_accueil_role.AutoSize = true;
            this.lbl_veterinaire_accueil_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_veterinaire_accueil_role.Location = new System.Drawing.Point(199, 243);
            this.lbl_veterinaire_accueil_role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_veterinaire_accueil_role.Name = "lbl_veterinaire_accueil_role";
            this.lbl_veterinaire_accueil_role.Size = new System.Drawing.Size(223, 31);
            this.lbl_veterinaire_accueil_role.TabIndex = 18;
            this.lbl_veterinaire_accueil_role.Text = "Rôle : Vétérinaire";
            // 
            // lbl_veterinaire_accueil_bienvenue
            // 
            this.lbl_veterinaire_accueil_bienvenue.AutoSize = true;
            this.lbl_veterinaire_accueil_bienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_veterinaire_accueil_bienvenue.Location = new System.Drawing.Point(199, 161);
            this.lbl_veterinaire_accueil_bienvenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_veterinaire_accueil_bienvenue.Name = "lbl_veterinaire_accueil_bienvenue";
            this.lbl_veterinaire_accueil_bienvenue.Size = new System.Drawing.Size(475, 31);
            this.lbl_veterinaire_accueil_bienvenue.TabIndex = 1;
            this.lbl_veterinaire_accueil_bienvenue.Text = "Bienvenue [Nom_user] [Prenom_user]";
            // 
            // tbp_veterinaire_bacpoisson
            // 
            this.tbp_veterinaire_bacpoisson.Location = new System.Drawing.Point(4, 25);
            this.tbp_veterinaire_bacpoisson.Name = "tbp_veterinaire_bacpoisson";
            this.tbp_veterinaire_bacpoisson.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_veterinaire_bacpoisson.Size = new System.Drawing.Size(898, 457);
            this.tbp_veterinaire_bacpoisson.TabIndex = 1;
            this.tbp_veterinaire_bacpoisson.Text = "Bac de poissons";
            this.tbp_veterinaire_bacpoisson.UseVisualStyleBackColor = true;
            // 
            // AppCriee_Veterinaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 485);
            this.Controls.Add(this.tbc_veterinaire);
            this.Name = "AppCriee_Veterinaire";
            this.Text = "AppCriée (Vétérinaire)";
            this.tbc_veterinaire.ResumeLayout(false);
            this.tbp_veterinaire_accueil.ResumeLayout(false);
            this.tbp_veterinaire_accueil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_veterinaire;
        private System.Windows.Forms.TabPage tbp_veterinaire_accueil;
        private System.Windows.Forms.TabPage tbp_veterinaire_bacpoisson;
        private System.Windows.Forms.Label lbl_veterinaire_accueil_bienvenue;
        private System.Windows.Forms.Label lbl_veterinaire_accueil_role;
    }
}