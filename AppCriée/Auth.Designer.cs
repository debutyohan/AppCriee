
namespace AppCriée
{
    partial class AppCriee
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
            this.btn_auth_connexion = new System.Windows.Forms.Button();
            this.tbx_auth_id = new System.Windows.Forms.TextBox();
            this.lbl_auth_title = new System.Windows.Forms.Label();
            this.lbl_auth_id = new System.Windows.Forms.Label();
            this.lbl_auth_passwd = new System.Windows.Forms.Label();
            this.tbx_auth_passwd = new System.Windows.Forms.TextBox();
            this.btn_auth_quitter = new System.Windows.Forms.Button();
            this.chx_auth_showchar = new System.Windows.Forms.CheckBox();
            this.lbl_auth_falseidpasswd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_auth_oublimotdepasse = new System.Windows.Forms.Label();
            this.lbl_auth_demandecreercompte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_auth_connexion
            // 
            this.btn_auth_connexion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_auth_connexion.Location = new System.Drawing.Point(360, 218);
            this.btn_auth_connexion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_auth_connexion.Name = "btn_auth_connexion";
            this.btn_auth_connexion.Size = new System.Drawing.Size(89, 39);
            this.btn_auth_connexion.TabIndex = 4;
            this.btn_auth_connexion.Text = "Connexion";
            this.btn_auth_connexion.UseVisualStyleBackColor = false;
            this.btn_auth_connexion.Click += new System.EventHandler(this.btn_auth_connexion_Click);
            // 
            // tbx_auth_id
            // 
            this.tbx_auth_id.Location = new System.Drawing.Point(448, 85);
            this.tbx_auth_id.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_auth_id.Name = "tbx_auth_id";
            this.tbx_auth_id.Size = new System.Drawing.Size(132, 22);
            this.tbx_auth_id.TabIndex = 0;
            // 
            // lbl_auth_title
            // 
            this.lbl_auth_title.AutoSize = true;
            this.lbl_auth_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_auth_title.Location = new System.Drawing.Point(347, 32);
            this.lbl_auth_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_auth_title.Name = "lbl_auth_title";
            this.lbl_auth_title.Size = new System.Drawing.Size(391, 25);
            this.lbl_auth_title.TabIndex = 2;
            this.lbl_auth_title.Text = "Veuillez entrer vos identifiants de connexion";
            // 
            // lbl_auth_id
            // 
            this.lbl_auth_id.AutoSize = true;
            this.lbl_auth_id.Location = new System.Drawing.Point(371, 89);
            this.lbl_auth_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_auth_id.Name = "lbl_auth_id";
            this.lbl_auth_id.Size = new System.Drawing.Size(77, 17);
            this.lbl_auth_id.TabIndex = 3;
            this.lbl_auth_id.Text = "Identifiant :";
            // 
            // lbl_auth_passwd
            // 
            this.lbl_auth_passwd.AutoSize = true;
            this.lbl_auth_passwd.Location = new System.Drawing.Point(347, 134);
            this.lbl_auth_passwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_auth_passwd.Name = "lbl_auth_passwd";
            this.lbl_auth_passwd.Size = new System.Drawing.Size(101, 17);
            this.lbl_auth_passwd.TabIndex = 5;
            this.lbl_auth_passwd.Text = "Mot de passe :";
            // 
            // tbx_auth_passwd
            // 
            this.tbx_auth_passwd.Location = new System.Drawing.Point(448, 130);
            this.tbx_auth_passwd.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_auth_passwd.Name = "tbx_auth_passwd";
            this.tbx_auth_passwd.Size = new System.Drawing.Size(132, 22);
            this.tbx_auth_passwd.TabIndex = 1;
            this.tbx_auth_passwd.UseSystemPasswordChar = true;
            // 
            // btn_auth_quitter
            // 
            this.btn_auth_quitter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_auth_quitter.Location = new System.Drawing.Point(525, 218);
            this.btn_auth_quitter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_auth_quitter.Name = "btn_auth_quitter";
            this.btn_auth_quitter.Size = new System.Drawing.Size(96, 39);
            this.btn_auth_quitter.TabIndex = 6;
            this.btn_auth_quitter.Text = "Quitter";
            this.btn_auth_quitter.UseVisualStyleBackColor = false;
            this.btn_auth_quitter.Click += new System.EventHandler(this.btn_auth_quitter_Click);
            // 
            // chx_auth_showchar
            // 
            this.chx_auth_showchar.AutoSize = true;
            this.chx_auth_showchar.Location = new System.Drawing.Point(407, 190);
            this.chx_auth_showchar.Margin = new System.Windows.Forms.Padding(4);
            this.chx_auth_showchar.Name = "chx_auth_showchar";
            this.chx_auth_showchar.Size = new System.Drawing.Size(171, 21);
            this.chx_auth_showchar.TabIndex = 4;
            this.chx_auth_showchar.Text = "Afficher les caractères";
            this.chx_auth_showchar.UseVisualStyleBackColor = true;
            this.chx_auth_showchar.CheckedChanged += new System.EventHandler(this.chx_auth_showchar_CheckedChanged);
            // 
            // lbl_auth_falseidpasswd
            // 
            this.lbl_auth_falseidpasswd.AutoSize = true;
            this.lbl_auth_falseidpasswd.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_auth_falseidpasswd.Location = new System.Drawing.Point(444, 170);
            this.lbl_auth_falseidpasswd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_auth_falseidpasswd.Name = "lbl_auth_falseidpasswd";
            this.lbl_auth_falseidpasswd.Size = new System.Drawing.Size(213, 17);
            this.lbl_auth_falseidpasswd.TabIndex = 9;
            this.lbl_auth_falseidpasswd.Text = "login ou mot de passe incorrect !";
            this.lbl_auth_falseidpasswd.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppCriée.Properties.Resources.autocollant_cadenas_muraux;
            this.pictureBox1.Location = new System.Drawing.Point(128, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_auth_oublimotdepasse
            // 
            this.lbl_auth_oublimotdepasse.AutoSize = true;
            this.lbl_auth_oublimotdepasse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_auth_oublimotdepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_auth_oublimotdepasse.Location = new System.Drawing.Point(665, 316);
            this.lbl_auth_oublimotdepasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_auth_oublimotdepasse.Name = "lbl_auth_oublimotdepasse";
            this.lbl_auth_oublimotdepasse.Size = new System.Drawing.Size(154, 17);
            this.lbl_auth_oublimotdepasse.TabIndex = 10;
            this.lbl_auth_oublimotdepasse.Text = "Mot de passe oublié";
            this.lbl_auth_oublimotdepasse.Click += new System.EventHandler(this.lbl_auth_oublimotdepasse_Click);
            // 
            // lbl_auth_demandecreercompte
            // 
            this.lbl_auth_demandecreercompte.AutoSize = true;
            this.lbl_auth_demandecreercompte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_auth_demandecreercompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_auth_demandecreercompte.Location = new System.Drawing.Point(65, 316);
            this.lbl_auth_demandecreercompte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_auth_demandecreercompte.Name = "lbl_auth_demandecreercompte";
            this.lbl_auth_demandecreercompte.Size = new System.Drawing.Size(257, 17);
            this.lbl_auth_demandecreercompte.TabIndex = 11;
            this.lbl_auth_demandecreercompte.Text = "Demander la création d\'un compte";
            this.lbl_auth_demandecreercompte.Click += new System.EventHandler(this.lbl_auth_demandecreercompte_Click);
            // 
            // AppCriee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 411);
            this.Controls.Add(this.lbl_auth_demandecreercompte);
            this.Controls.Add(this.lbl_auth_oublimotdepasse);
            this.Controls.Add(this.lbl_auth_falseidpasswd);
            this.Controls.Add(this.chx_auth_showchar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_auth_quitter);
            this.Controls.Add(this.lbl_auth_passwd);
            this.Controls.Add(this.tbx_auth_passwd);
            this.Controls.Add(this.lbl_auth_id);
            this.Controls.Add(this.lbl_auth_title);
            this.Controls.Add(this.tbx_auth_id);
            this.Controls.Add(this.btn_auth_connexion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(878, 458);
            this.MinimumSize = new System.Drawing.Size(878, 458);
            this.Name = "AppCriee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppCriée";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_auth_connexion;
        private System.Windows.Forms.TextBox tbx_auth_id;
        private System.Windows.Forms.Label lbl_auth_title;
        private System.Windows.Forms.Label lbl_auth_id;
        private System.Windows.Forms.Label lbl_auth_passwd;
        private System.Windows.Forms.TextBox tbx_auth_passwd;
        private System.Windows.Forms.Button btn_auth_quitter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chx_auth_showchar;
        private System.Windows.Forms.Label lbl_auth_falseidpasswd;
        private System.Windows.Forms.Label lbl_auth_oublimotdepasse;
        private System.Windows.Forms.Label lbl_auth_demandecreercompte;
    }
}

