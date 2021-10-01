
namespace AppCriée
{
    partial class AppCriee_Receptionniste
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
            this.lbl_accueil_bienvenue = new System.Windows.Forms.Label();
            this.lbl_accueil_role = new System.Windows.Forms.Label();
            this.lbl_accueil_details = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pecheDuJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerPechedujourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterPechedujourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerPechedujourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_ajoutpeche_datejour = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.dg_pechejour = new System.Windows.Forms.DataGridView();
            this.nameBateau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_ajoutpeche_ispeche = new System.Windows.Forms.Label();
            this.lbl_ajoutpeche_explication = new System.Windows.Forms.Label();
            this.lbl_ajoutpeche_explication2 = new System.Windows.Forms.Label();
            this.btn_ajoutpeche_creerpeche = new System.Windows.Forms.Button();
            this.lbl_ajoutpeche_creerpeche_nombateau = new System.Windows.Forms.Label();
            this.cbx_ajoutpeche_creerpeche_nombateau = new System.Windows.Forms.ComboBox();
            this.btn_pechejour_creerpeche_valider = new System.Windows.Forms.Button();
            this.lbl_error_connection = new System.Windows.Forms.Label();
            this.lbl_pechejour_creerpeche_ok = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pechejour)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_accueil_bienvenue
            // 
            this.lbl_accueil_bienvenue.AutoSize = true;
            this.lbl_accueil_bienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_accueil_bienvenue.Location = new System.Drawing.Point(263, 193);
            this.lbl_accueil_bienvenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_accueil_bienvenue.Name = "lbl_accueil_bienvenue";
            this.lbl_accueil_bienvenue.Size = new System.Drawing.Size(475, 31);
            this.lbl_accueil_bienvenue.TabIndex = 0;
            this.lbl_accueil_bienvenue.Text = "Bienvenue [Nom_user] [Prenom_user]";
            // 
            // lbl_accueil_role
            // 
            this.lbl_accueil_role.AutoSize = true;
            this.lbl_accueil_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_accueil_role.Location = new System.Drawing.Point(263, 257);
            this.lbl_accueil_role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_accueil_role.Name = "lbl_accueil_role";
            this.lbl_accueil_role.Size = new System.Drawing.Size(273, 31);
            this.lbl_accueil_role.TabIndex = 1;
            this.lbl_accueil_role.Text = "Rôle : Réceptionniste";
            // 
            // lbl_accueil_details
            // 
            this.lbl_accueil_details.AutoSize = true;
            this.lbl_accueil_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accueil_details.Location = new System.Drawing.Point(287, 368);
            this.lbl_accueil_details.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_accueil_details.Name = "lbl_accueil_details";
            this.lbl_accueil_details.Size = new System.Drawing.Size(470, 24);
            this.lbl_accueil_details.TabIndex = 2;
            this.lbl_accueil_details.Text = "Cette application permettra de gérer les pêches du jour";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pecheDuJourToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pecheDuJourToolStripMenuItem
            // 
            this.pecheDuJourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerPechedujourToolStripMenuItem,
            this.consulterPechedujourToolStripMenuItem,
            this.supprimerPechedujourToolStripMenuItem});
            this.pecheDuJourToolStripMenuItem.Name = "pecheDuJourToolStripMenuItem";
            this.pecheDuJourToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.pecheDuJourToolStripMenuItem.Text = "Pêche du jour";
            // 
            // creerPechedujourToolStripMenuItem
            // 
            this.creerPechedujourToolStripMenuItem.Name = "creerPechedujourToolStripMenuItem";
            this.creerPechedujourToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.creerPechedujourToolStripMenuItem.Text = "Créer";
            this.creerPechedujourToolStripMenuItem.Click += new System.EventHandler(this.creerPechedujourToolStripMenuItem_Click);
            // 
            // consulterPechedujourToolStripMenuItem
            // 
            this.consulterPechedujourToolStripMenuItem.Name = "consulterPechedujourToolStripMenuItem";
            this.consulterPechedujourToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.consulterPechedujourToolStripMenuItem.Text = "Consulter";
            // 
            // supprimerPechedujourToolStripMenuItem
            // 
            this.supprimerPechedujourToolStripMenuItem.Name = "supprimerPechedujourToolStripMenuItem";
            this.supprimerPechedujourToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.supprimerPechedujourToolStripMenuItem.Text = "Supprimer";
            // 
            // lbl_ajoutpeche_datejour
            // 
            this.lbl_ajoutpeche_datejour.AutoSize = true;
            this.lbl_ajoutpeche_datejour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajoutpeche_datejour.Location = new System.Drawing.Point(227, 135);
            this.lbl_ajoutpeche_datejour.Name = "lbl_ajoutpeche_datejour";
            this.lbl_ajoutpeche_datejour.Size = new System.Drawing.Size(127, 24);
            this.lbl_ajoutpeche_datejour.TabIndex = 7;
            this.lbl_ajoutpeche_datejour.Text = "Date du jour : ";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(285, 76);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(485, 32);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "GESTION DES PECHES DU JOUR";
            // 
            // dg_pechejour
            // 
            this.dg_pechejour.AllowUserToAddRows = false;
            this.dg_pechejour.AllowUserToDeleteRows = false;
            this.dg_pechejour.AllowUserToResizeRows = false;
            this.dg_pechejour.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_pechejour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_pechejour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_pechejour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameBateau});
            this.dg_pechejour.GridColor = System.Drawing.SystemColors.Control;
            this.dg_pechejour.Location = new System.Drawing.Point(76, 172);
            this.dg_pechejour.Name = "dg_pechejour";
            this.dg_pechejour.ReadOnly = true;
            this.dg_pechejour.RowHeadersWidth = 10;
            this.dg_pechejour.RowTemplate.Height = 24;
            this.dg_pechejour.Size = new System.Drawing.Size(278, 292);
            this.dg_pechejour.TabIndex = 5;
            // 
            // nameBateau
            // 
            this.nameBateau.HeaderText = "Nom du bateau";
            this.nameBateau.MinimumWidth = 6;
            this.nameBateau.Name = "nameBateau";
            this.nameBateau.ReadOnly = true;
            this.nameBateau.Width = 150;
            // 
            // lbl_ajoutpeche_ispeche
            // 
            this.lbl_ajoutpeche_ispeche.AutoSize = true;
            this.lbl_ajoutpeche_ispeche.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_ajoutpeche_ispeche.Location = new System.Drawing.Point(207, 226);
            this.lbl_ajoutpeche_ispeche.Name = "lbl_ajoutpeche_ispeche";
            this.lbl_ajoutpeche_ispeche.Size = new System.Drawing.Size(71, 31);
            this.lbl_ajoutpeche_ispeche.TabIndex = 4;
            this.lbl_ajoutpeche_ispeche.Text = "label";
            // 
            // lbl_ajoutpeche_explication
            // 
            this.lbl_ajoutpeche_explication.AutoSize = true;
            this.lbl_ajoutpeche_explication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ajoutpeche_explication.Location = new System.Drawing.Point(676, 263);
            this.lbl_ajoutpeche_explication.Name = "lbl_ajoutpeche_explication";
            this.lbl_ajoutpeche_explication.Size = new System.Drawing.Size(274, 25);
            this.lbl_ajoutpeche_explication.TabIndex = 8;
            this.lbl_ajoutpeche_explication.Text = "Insérer une nouvelle pêche en";
            // 
            // lbl_ajoutpeche_explication2
            // 
            this.lbl_ajoutpeche_explication2.AutoSize = true;
            this.lbl_ajoutpeche_explication2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ajoutpeche_explication2.Location = new System.Drawing.Point(676, 298);
            this.lbl_ajoutpeche_explication2.Name = "lbl_ajoutpeche_explication2";
            this.lbl_ajoutpeche_explication2.Size = new System.Drawing.Size(276, 25);
            this.lbl_ajoutpeche_explication2.TabIndex = 9;
            this.lbl_ajoutpeche_explication2.Text = "cliquant sur \"Créer une pêche\"";
            // 
            // btn_ajoutpeche_creerpeche
            // 
            this.btn_ajoutpeche_creerpeche.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_ajoutpeche_creerpeche.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutpeche_creerpeche.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ajoutpeche_creerpeche.Location = new System.Drawing.Point(732, 431);
            this.btn_ajoutpeche_creerpeche.Name = "btn_ajoutpeche_creerpeche";
            this.btn_ajoutpeche_creerpeche.Size = new System.Drawing.Size(160, 33);
            this.btn_ajoutpeche_creerpeche.TabIndex = 10;
            this.btn_ajoutpeche_creerpeche.Text = "Créer une pêche";
            this.btn_ajoutpeche_creerpeche.UseVisualStyleBackColor = false;
            this.btn_ajoutpeche_creerpeche.Click += new System.EventHandler(this.btn_ajoutpeche_creerpeche_Click);
            // 
            // lbl_ajoutpeche_creerpeche_nombateau
            // 
            this.lbl_ajoutpeche_creerpeche_nombateau.AutoSize = true;
            this.lbl_ajoutpeche_creerpeche_nombateau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajoutpeche_creerpeche_nombateau.Location = new System.Drawing.Point(619, 410);
            this.lbl_ajoutpeche_creerpeche_nombateau.Name = "lbl_ajoutpeche_creerpeche_nombateau";
            this.lbl_ajoutpeche_creerpeche_nombateau.Size = new System.Drawing.Size(151, 24);
            this.lbl_ajoutpeche_creerpeche_nombateau.TabIndex = 11;
            this.lbl_ajoutpeche_creerpeche_nombateau.Text = "Nom du Bateau :";
            // 
            // cbx_ajoutpeche_creerpeche_nombateau
            // 
            this.cbx_ajoutpeche_creerpeche_nombateau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ajoutpeche_creerpeche_nombateau.FormattingEnabled = true;
            this.cbx_ajoutpeche_creerpeche_nombateau.Location = new System.Drawing.Point(786, 412);
            this.cbx_ajoutpeche_creerpeche_nombateau.Name = "cbx_ajoutpeche_creerpeche_nombateau";
            this.cbx_ajoutpeche_creerpeche_nombateau.Size = new System.Drawing.Size(231, 24);
            this.cbx_ajoutpeche_creerpeche_nombateau.TabIndex = 12;
            // 
            // btn_pechejour_creerpeche_valider
            // 
            this.btn_pechejour_creerpeche_valider.BackColor = System.Drawing.SystemColors.Info;
            this.btn_pechejour_creerpeche_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pechejour_creerpeche_valider.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_pechejour_creerpeche_valider.Location = new System.Drawing.Point(722, 470);
            this.btn_pechejour_creerpeche_valider.Name = "btn_pechejour_creerpeche_valider";
            this.btn_pechejour_creerpeche_valider.Size = new System.Drawing.Size(160, 33);
            this.btn_pechejour_creerpeche_valider.TabIndex = 15;
            this.btn_pechejour_creerpeche_valider.Text = "Valider";
            this.btn_pechejour_creerpeche_valider.UseVisualStyleBackColor = false;
            this.btn_pechejour_creerpeche_valider.Click += new System.EventHandler(this.btn_pechejour_creerpeche_valider_Click);
            // 
            // lbl_error_connection
            // 
            this.lbl_error_connection.AutoSize = true;
            this.lbl_error_connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_error_connection.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_connection.Location = new System.Drawing.Point(245, 243);
            this.lbl_error_connection.Name = "lbl_error_connection";
            this.lbl_error_connection.Size = new System.Drawing.Size(539, 29);
            this.lbl_error_connection.TabIndex = 16;
            this.lbl_error_connection.Text = "Impossible de se connecter au serveur MySQL";
            // 
            // lbl_pechejour_creerpeche_ok
            // 
            this.lbl_pechejour_creerpeche_ok.AutoSize = true;
            this.lbl_pechejour_creerpeche_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pechejour_creerpeche_ok.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_pechejour_creerpeche_ok.Location = new System.Drawing.Point(115, 489);
            this.lbl_pechejour_creerpeche_ok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pechejour_creerpeche_ok.Name = "lbl_pechejour_creerpeche_ok";
            this.lbl_pechejour_creerpeche_ok.Size = new System.Drawing.Size(268, 24);
            this.lbl_pechejour_creerpeche_ok.TabIndex = 17;
            this.lbl_pechejour_creerpeche_ok.Text = "La pêche de ce jour du bateau";
            // 
            // AppCriee_Receptionniste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 562);
            this.Controls.Add(this.lbl_pechejour_creerpeche_ok);
            this.Controls.Add(this.lbl_error_connection);
            this.Controls.Add(this.btn_pechejour_creerpeche_valider);
            this.Controls.Add(this.cbx_ajoutpeche_creerpeche_nombateau);
            this.Controls.Add(this.lbl_ajoutpeche_creerpeche_nombateau);
            this.Controls.Add(this.btn_ajoutpeche_creerpeche);
            this.Controls.Add(this.lbl_ajoutpeche_explication2);
            this.Controls.Add(this.lbl_ajoutpeche_explication);
            this.Controls.Add(this.lbl_ajoutpeche_datejour);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dg_pechejour);
            this.Controls.Add(this.lbl_ajoutpeche_ispeche);
            this.Controls.Add(this.lbl_accueil_details);
            this.Controls.Add(this.lbl_accueil_role);
            this.Controls.Add(this.lbl_accueil_bienvenue);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AppCriee_Receptionniste";
            this.Text = "AppCriée (Réceptionniste)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pechejour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label lbl_accueil_bienvenue;
            private System.Windows.Forms.Label lbl_accueil_role;
            private System.Windows.Forms.Label lbl_accueil_details;
            private System.Windows.Forms.MenuStrip menuStrip1;
            private System.Windows.Forms.ToolStripMenuItem pecheDuJourToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem creerPechedujourToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem consulterPechedujourToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem supprimerPechedujourToolStripMenuItem;
            private System.Windows.Forms.Label lbl_ajoutpeche_datejour;
            private System.Windows.Forms.Label lbl_title;
            private System.Windows.Forms.DataGridView dg_pechejour;
            private System.Windows.Forms.Label lbl_ajoutpeche_ispeche;
            private System.Windows.Forms.Label lbl_ajoutpeche_explication;
            private System.Windows.Forms.Label lbl_ajoutpeche_explication2;
            private System.Windows.Forms.Button btn_ajoutpeche_creerpeche;
            private System.Windows.Forms.Label lbl_ajoutpeche_creerpeche_nombateau;
            private System.Windows.Forms.ComboBox cbx_ajoutpeche_creerpeche_nombateau;
            private System.Windows.Forms.Button btn_pechejour_creerpeche_valider;
            private System.Windows.Forms.Label lbl_error_connection;
            private System.Windows.Forms.DataGridViewTextBoxColumn nameBateau;
            private System.Windows.Forms.Label lbl_pechejour_creerpeche_ok;
    }
}