
namespace AppCriée
{
    partial class AppCriee_Administrateur
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
            this.tbc_administrateur = new System.Windows.Forms.TabControl();
            this.tbp_administrateur_accueil = new System.Windows.Forms.TabPage();
            this.tbp_administrateur_gestioncomptes = new System.Windows.Forms.TabPage();
            this.pbx_administrateur_deconnexion = new System.Windows.Forms.PictureBox();
            this.lbl_administrateur_datejour = new System.Windows.Forms.Label();
            this.lbl_administrateur_accueil_bienvenue = new System.Windows.Forms.Label();
            this.lbl_administrateur_accueil_role = new System.Windows.Forms.Label();
            this.tbc_administrateur.SuspendLayout();
            this.tbp_administrateur_accueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_administrateur_deconnexion)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_administrateur
            // 
            this.tbc_administrateur.Controls.Add(this.tbp_administrateur_accueil);
            this.tbc_administrateur.Controls.Add(this.tbp_administrateur_gestioncomptes);
            this.tbc_administrateur.Location = new System.Drawing.Point(0, 0);
            this.tbc_administrateur.Name = "tbc_administrateur";
            this.tbc_administrateur.SelectedIndex = 0;
            this.tbc_administrateur.Size = new System.Drawing.Size(1085, 680);
            this.tbc_administrateur.TabIndex = 0;
            // 
            // tbp_administrateur_accueil
            // 
            this.tbp_administrateur_accueil.Controls.Add(this.lbl_administrateur_accueil_role);
            this.tbp_administrateur_accueil.Controls.Add(this.lbl_administrateur_accueil_bienvenue);
            this.tbp_administrateur_accueil.Location = new System.Drawing.Point(4, 25);
            this.tbp_administrateur_accueil.Name = "tbp_administrateur_accueil";
            this.tbp_administrateur_accueil.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_administrateur_accueil.Size = new System.Drawing.Size(1077, 651);
            this.tbp_administrateur_accueil.TabIndex = 0;
            this.tbp_administrateur_accueil.Text = "Accueil";
            this.tbp_administrateur_accueil.UseVisualStyleBackColor = true;
            // 
            // tbp_administrateur_gestioncomptes
            // 
            this.tbp_administrateur_gestioncomptes.Location = new System.Drawing.Point(4, 25);
            this.tbp_administrateur_gestioncomptes.Name = "tbp_administrateur_gestioncomptes";
            this.tbp_administrateur_gestioncomptes.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_administrateur_gestioncomptes.Size = new System.Drawing.Size(1077, 651);
            this.tbp_administrateur_gestioncomptes.TabIndex = 1;
            this.tbp_administrateur_gestioncomptes.Text = "Gestion des comptes";
            this.tbp_administrateur_gestioncomptes.UseVisualStyleBackColor = true;
            // 
            // pbx_administrateur_deconnexion
            // 
            this.pbx_administrateur_deconnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_administrateur_deconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_administrateur_deconnexion.Image = global::AppCriée.Properties.Resources.computer_icons_login_icon_design_exit_5abfc840bf8ca4_9038982415225180807846;
            this.pbx_administrateur_deconnexion.Location = new System.Drawing.Point(1019, 685);
            this.pbx_administrateur_deconnexion.Name = "pbx_administrateur_deconnexion";
            this.pbx_administrateur_deconnexion.Size = new System.Drawing.Size(45, 45);
            this.pbx_administrateur_deconnexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_administrateur_deconnexion.TabIndex = 21;
            this.pbx_administrateur_deconnexion.TabStop = false;
            this.pbx_administrateur_deconnexion.Click += new System.EventHandler(this.pbx_administrateur_deconnexion_Click);
            // 
            // lbl_administrateur_datejour
            // 
            this.lbl_administrateur_datejour.AutoSize = true;
            this.lbl_administrateur_datejour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_administrateur_datejour.Location = new System.Drawing.Point(771, 693);
            this.lbl_administrateur_datejour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_administrateur_datejour.Name = "lbl_administrateur_datejour";
            this.lbl_administrateur_datejour.Size = new System.Drawing.Size(217, 24);
            this.lbl_administrateur_datejour.TabIndex = 21;
            this.lbl_administrateur_datejour.Text = "Date du jour : 23/10/2021";
            // 
            // lbl_administrateur_accueil_bienvenue
            // 
            this.lbl_administrateur_accueil_bienvenue.AutoSize = true;
            this.lbl_administrateur_accueil_bienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_administrateur_accueil_bienvenue.Location = new System.Drawing.Point(199, 161);
            this.lbl_administrateur_accueil_bienvenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_administrateur_accueil_bienvenue.Name = "lbl_administrateur_accueil_bienvenue";
            this.lbl_administrateur_accueil_bienvenue.Size = new System.Drawing.Size(475, 31);
            this.lbl_administrateur_accueil_bienvenue.TabIndex = 3;
            this.lbl_administrateur_accueil_bienvenue.Text = "Bienvenue [Nom_user] [Prenom_user]";
            // 
            // lbl_administrateur_accueil_role
            // 
            this.lbl_administrateur_accueil_role.AutoSize = true;
            this.lbl_administrateur_accueil_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_administrateur_accueil_role.Location = new System.Drawing.Point(199, 242);
            this.lbl_administrateur_accueil_role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_administrateur_accueil_role.Name = "lbl_administrateur_accueil_role";
            this.lbl_administrateur_accueil_role.Size = new System.Drawing.Size(267, 31);
            this.lbl_administrateur_accueil_role.TabIndex = 20;
            this.lbl_administrateur_accueil_role.Text = "Rôle : Administrateur";
            // 
            // AppCriee_Administrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 736);
            this.Controls.Add(this.lbl_administrateur_datejour);
            this.Controls.Add(this.pbx_administrateur_deconnexion);
            this.Controls.Add(this.tbc_administrateur);
            this.Name = "AppCriee_Administrateur";
            this.Text = "AppCriée (Administrateur)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppCriee_Administrateur_FormClosing);
            this.tbc_administrateur.ResumeLayout(false);
            this.tbp_administrateur_accueil.ResumeLayout(false);
            this.tbp_administrateur_accueil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_administrateur_deconnexion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_administrateur;
        private System.Windows.Forms.TabPage tbp_administrateur_accueil;
        private System.Windows.Forms.TabPage tbp_administrateur_gestioncomptes;
        private System.Windows.Forms.PictureBox pbx_administrateur_deconnexion;
        private System.Windows.Forms.Label lbl_administrateur_datejour;
        private System.Windows.Forms.Label lbl_administrateur_accueil_bienvenue;
        private System.Windows.Forms.Label lbl_administrateur_accueil_role;
    }
}