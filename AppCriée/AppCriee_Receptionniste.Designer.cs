
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tbc_receptionniste = new System.Windows.Forms.TabControl();
            this.tabAccueil = new System.Windows.Forms.TabPage();
            this.lbl_accueil_details = new System.Windows.Forms.Label();
            this.lbl_accueil_role = new System.Windows.Forms.Label();
            this.lbl_accueil_bienvenue = new System.Windows.Forms.Label();
            this.tabPeche = new System.Windows.Forms.TabPage();
            this.btn_receptionniste_peche_supprimer = new System.Windows.Forms.Button();
            this.lbl_pechejour_allpeche = new System.Windows.Forms.Label();
            this.lbl_pechejour_pecheok = new System.Windows.Forms.Label();
            this.btn_pechejour_creerpeche_valider = new System.Windows.Forms.Button();
            this.lbl_ajoutpeche_creerpeche_nombateau = new System.Windows.Forms.Label();
            this.cbx_ajoutpeche_creerpeche_nombateau = new System.Windows.Forms.ComboBox();
            this.btn_ajoutpeche_creerpeche = new System.Windows.Forms.Button();
            this.lbl_ajoutpeche_explication2 = new System.Windows.Forms.Label();
            this.lbl_ajoutpeche_explication = new System.Windows.Forms.Label();
            this.lbl_ajoutpeche_ispeche = new System.Windows.Forms.Label();
            this.dg_pechejour = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_receptionniste_datejour = new System.Windows.Forms.Label();
            this.pbx_receptionniste_deconnexion = new System.Windows.Forms.PictureBox();
            this.tbc_receptionniste.SuspendLayout();
            this.tabAccueil.SuspendLayout();
            this.tabPeche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pechejour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_receptionniste_deconnexion)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1088, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tbc_receptionniste
            // 
            this.tbc_receptionniste.Controls.Add(this.tabAccueil);
            this.tbc_receptionniste.Controls.Add(this.tabPeche);
            this.tbc_receptionniste.Location = new System.Drawing.Point(0, 0);
            this.tbc_receptionniste.Margin = new System.Windows.Forms.Padding(4);
            this.tbc_receptionniste.Name = "tbc_receptionniste";
            this.tbc_receptionniste.SelectedIndex = 0;
            this.tbc_receptionniste.Size = new System.Drawing.Size(1099, 570);
            this.tbc_receptionniste.TabIndex = 18;
            this.tbc_receptionniste.SelectedIndexChanged += new System.EventHandler(this.tbc_receptionniste_SelectedIndexChanged);
            // 
            // tabAccueil
            // 
            this.tabAccueil.BackColor = System.Drawing.SystemColors.Control;
            this.tabAccueil.Controls.Add(this.lbl_accueil_details);
            this.tabAccueil.Controls.Add(this.lbl_accueil_role);
            this.tabAccueil.Controls.Add(this.lbl_accueil_bienvenue);
            this.tabAccueil.Location = new System.Drawing.Point(4, 25);
            this.tabAccueil.Margin = new System.Windows.Forms.Padding(4);
            this.tabAccueil.Name = "tabAccueil";
            this.tabAccueil.Padding = new System.Windows.Forms.Padding(4);
            this.tabAccueil.Size = new System.Drawing.Size(1091, 541);
            this.tabAccueil.TabIndex = 0;
            this.tabAccueil.Text = "Accueil";
            // 
            // lbl_accueil_details
            // 
            this.lbl_accueil_details.AutoSize = true;
            this.lbl_accueil_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accueil_details.Location = new System.Drawing.Point(221, 295);
            this.lbl_accueil_details.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_accueil_details.Name = "lbl_accueil_details";
            this.lbl_accueil_details.Size = new System.Drawing.Size(470, 24);
            this.lbl_accueil_details.TabIndex = 3;
            this.lbl_accueil_details.Text = "Cette application permettra de gérer les pêches du jour";
            // 
            // lbl_accueil_role
            // 
            this.lbl_accueil_role.AutoSize = true;
            this.lbl_accueil_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_accueil_role.Location = new System.Drawing.Point(201, 183);
            this.lbl_accueil_role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_accueil_role.Name = "lbl_accueil_role";
            this.lbl_accueil_role.Size = new System.Drawing.Size(273, 31);
            this.lbl_accueil_role.TabIndex = 2;
            this.lbl_accueil_role.Text = "Rôle : Réceptionniste";
            // 
            // lbl_accueil_bienvenue
            // 
            this.lbl_accueil_bienvenue.AutoSize = true;
            this.lbl_accueil_bienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_accueil_bienvenue.Location = new System.Drawing.Point(201, 111);
            this.lbl_accueil_bienvenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_accueil_bienvenue.Name = "lbl_accueil_bienvenue";
            this.lbl_accueil_bienvenue.Size = new System.Drawing.Size(475, 31);
            this.lbl_accueil_bienvenue.TabIndex = 1;
            this.lbl_accueil_bienvenue.Text = "Bienvenue [Nom_user] [Prenom_user]";
            // 
            // tabPeche
            // 
            this.tabPeche.BackColor = System.Drawing.SystemColors.Control;
            this.tabPeche.Controls.Add(this.btn_receptionniste_peche_supprimer);
            this.tabPeche.Controls.Add(this.lbl_pechejour_allpeche);
            this.tabPeche.Controls.Add(this.lbl_pechejour_pecheok);
            this.tabPeche.Controls.Add(this.btn_pechejour_creerpeche_valider);
            this.tabPeche.Controls.Add(this.lbl_ajoutpeche_creerpeche_nombateau);
            this.tabPeche.Controls.Add(this.cbx_ajoutpeche_creerpeche_nombateau);
            this.tabPeche.Controls.Add(this.btn_ajoutpeche_creerpeche);
            this.tabPeche.Controls.Add(this.lbl_ajoutpeche_explication2);
            this.tabPeche.Controls.Add(this.lbl_ajoutpeche_explication);
            this.tabPeche.Controls.Add(this.lbl_ajoutpeche_ispeche);
            this.tabPeche.Controls.Add(this.dg_pechejour);
            this.tabPeche.Controls.Add(this.lbl_title);
            this.tabPeche.Location = new System.Drawing.Point(4, 25);
            this.tabPeche.Margin = new System.Windows.Forms.Padding(4);
            this.tabPeche.Name = "tabPeche";
            this.tabPeche.Padding = new System.Windows.Forms.Padding(4);
            this.tabPeche.Size = new System.Drawing.Size(1091, 541);
            this.tabPeche.TabIndex = 1;
            this.tabPeche.Text = "Pêche du jour";
            // 
            // btn_receptionniste_peche_supprimer
            // 
            this.btn_receptionniste_peche_supprimer.BackColor = System.Drawing.Color.Red;
            this.btn_receptionniste_peche_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_receptionniste_peche_supprimer.Location = new System.Drawing.Point(803, 310);
            this.btn_receptionniste_peche_supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_receptionniste_peche_supprimer.Name = "btn_receptionniste_peche_supprimer";
            this.btn_receptionniste_peche_supprimer.Size = new System.Drawing.Size(148, 31);
            this.btn_receptionniste_peche_supprimer.TabIndex = 20;
            this.btn_receptionniste_peche_supprimer.Text = "Supprimer";
            this.btn_receptionniste_peche_supprimer.UseVisualStyleBackColor = false;
            this.btn_receptionniste_peche_supprimer.Click += new System.EventHandler(this.btn_receptionniste_creerpeche_supprimer_Click);
            // 
            // lbl_pechejour_allpeche
            // 
            this.lbl_pechejour_allpeche.AutoSize = true;
            this.lbl_pechejour_allpeche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_pechejour_allpeche.Location = new System.Drawing.Point(553, 229);
            this.lbl_pechejour_allpeche.Name = "lbl_pechejour_allpeche";
            this.lbl_pechejour_allpeche.Size = new System.Drawing.Size(418, 29);
            this.lbl_pechejour_allpeche.TabIndex = 19;
            this.lbl_pechejour_allpeche.Text = "Tous les pêches ont été réceptionnée";
            // 
            // lbl_pechejour_pecheok
            // 
            this.lbl_pechejour_pecheok.AutoSize = true;
            this.lbl_pechejour_pecheok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pechejour_pecheok.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_pechejour_pecheok.Location = new System.Drawing.Point(81, 465);
            this.lbl_pechejour_pecheok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pechejour_pecheok.Name = "lbl_pechejour_pecheok";
            this.lbl_pechejour_pecheok.Size = new System.Drawing.Size(268, 24);
            this.lbl_pechejour_pecheok.TabIndex = 18;
            this.lbl_pechejour_pecheok.Text = "La pêche de ce jour du bateau";
            // 
            // btn_pechejour_creerpeche_valider
            // 
            this.btn_pechejour_creerpeche_valider.BackColor = System.Drawing.SystemColors.Info;
            this.btn_pechejour_creerpeche_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pechejour_creerpeche_valider.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_pechejour_creerpeche_valider.Location = new System.Drawing.Point(617, 454);
            this.btn_pechejour_creerpeche_valider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pechejour_creerpeche_valider.Name = "btn_pechejour_creerpeche_valider";
            this.btn_pechejour_creerpeche_valider.Size = new System.Drawing.Size(160, 33);
            this.btn_pechejour_creerpeche_valider.TabIndex = 16;
            this.btn_pechejour_creerpeche_valider.Text = "Valider";
            this.btn_pechejour_creerpeche_valider.UseVisualStyleBackColor = false;
            this.btn_pechejour_creerpeche_valider.Click += new System.EventHandler(this.btn_receptionniste_creerpeche_valider_Click);
            // 
            // lbl_ajoutpeche_creerpeche_nombateau
            // 
            this.lbl_ajoutpeche_creerpeche_nombateau.AutoSize = true;
            this.lbl_ajoutpeche_creerpeche_nombateau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajoutpeche_creerpeche_nombateau.Location = new System.Drawing.Point(528, 404);
            this.lbl_ajoutpeche_creerpeche_nombateau.Name = "lbl_ajoutpeche_creerpeche_nombateau";
            this.lbl_ajoutpeche_creerpeche_nombateau.Size = new System.Drawing.Size(151, 24);
            this.lbl_ajoutpeche_creerpeche_nombateau.TabIndex = 15;
            this.lbl_ajoutpeche_creerpeche_nombateau.Text = "Nom du Bateau :";
            // 
            // cbx_ajoutpeche_creerpeche_nombateau
            // 
            this.cbx_ajoutpeche_creerpeche_nombateau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ajoutpeche_creerpeche_nombateau.FormattingEnabled = true;
            this.cbx_ajoutpeche_creerpeche_nombateau.Location = new System.Drawing.Point(692, 404);
            this.cbx_ajoutpeche_creerpeche_nombateau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_ajoutpeche_creerpeche_nombateau.Name = "cbx_ajoutpeche_creerpeche_nombateau";
            this.cbx_ajoutpeche_creerpeche_nombateau.Size = new System.Drawing.Size(231, 24);
            this.cbx_ajoutpeche_creerpeche_nombateau.TabIndex = 14;
            // 
            // btn_ajoutpeche_creerpeche
            // 
            this.btn_ajoutpeche_creerpeche.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_ajoutpeche_creerpeche.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutpeche_creerpeche.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ajoutpeche_creerpeche.Location = new System.Drawing.Point(559, 308);
            this.btn_ajoutpeche_creerpeche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ajoutpeche_creerpeche.Name = "btn_ajoutpeche_creerpeche";
            this.btn_ajoutpeche_creerpeche.Size = new System.Drawing.Size(160, 33);
            this.btn_ajoutpeche_creerpeche.TabIndex = 13;
            this.btn_ajoutpeche_creerpeche.Text = "Créer une pêche";
            this.btn_ajoutpeche_creerpeche.UseVisualStyleBackColor = false;
            this.btn_ajoutpeche_creerpeche.Click += new System.EventHandler(this.btn_receptionniste_creerpeche_Click);
            // 
            // lbl_ajoutpeche_explication2
            // 
            this.lbl_ajoutpeche_explication2.AutoSize = true;
            this.lbl_ajoutpeche_explication2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ajoutpeche_explication2.Location = new System.Drawing.Point(583, 185);
            this.lbl_ajoutpeche_explication2.Name = "lbl_ajoutpeche_explication2";
            this.lbl_ajoutpeche_explication2.Size = new System.Drawing.Size(276, 25);
            this.lbl_ajoutpeche_explication2.TabIndex = 12;
            this.lbl_ajoutpeche_explication2.Text = "cliquant sur \"Créer une pêche\"";
            // 
            // lbl_ajoutpeche_explication
            // 
            this.lbl_ajoutpeche_explication.AutoSize = true;
            this.lbl_ajoutpeche_explication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ajoutpeche_explication.Location = new System.Drawing.Point(583, 139);
            this.lbl_ajoutpeche_explication.Name = "lbl_ajoutpeche_explication";
            this.lbl_ajoutpeche_explication.Size = new System.Drawing.Size(274, 25);
            this.lbl_ajoutpeche_explication.TabIndex = 11;
            this.lbl_ajoutpeche_explication.Text = "Insérer une nouvelle pêche en";
            // 
            // lbl_ajoutpeche_ispeche
            // 
            this.lbl_ajoutpeche_ispeche.AutoSize = true;
            this.lbl_ajoutpeche_ispeche.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_ajoutpeche_ispeche.Location = new System.Drawing.Point(257, 229);
            this.lbl_ajoutpeche_ispeche.Name = "lbl_ajoutpeche_ispeche";
            this.lbl_ajoutpeche_ispeche.Size = new System.Drawing.Size(270, 31);
            this.lbl_ajoutpeche_ispeche.TabIndex = 10;
            this.lbl_ajoutpeche_ispeche.Text = "Pas de Pêche ce jour";
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dg_pechejour.GridColor = System.Drawing.SystemColors.Control;
            this.dg_pechejour.Location = new System.Drawing.Point(71, 166);
            this.dg_pechejour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dg_pechejour.Name = "dg_pechejour";
            this.dg_pechejour.ReadOnly = true;
            this.dg_pechejour.RowHeadersWidth = 10;
            this.dg_pechejour.RowTemplate.Height = 24;
            this.dg_pechejour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_pechejour.Size = new System.Drawing.Size(419, 292);
            this.dg_pechejour.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nom du bateau";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Immatriculation";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(279, 49);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(485, 32);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "GESTION DES PECHES DU JOUR";
            // 
            // lbl_receptionniste_datejour
            // 
            this.lbl_receptionniste_datejour.AutoSize = true;
            this.lbl_receptionniste_datejour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receptionniste_datejour.Location = new System.Drawing.Point(782, 586);
            this.lbl_receptionniste_datejour.Name = "lbl_receptionniste_datejour";
            this.lbl_receptionniste_datejour.Size = new System.Drawing.Size(217, 24);
            this.lbl_receptionniste_datejour.TabIndex = 19;
            this.lbl_receptionniste_datejour.Text = "Date du jour : 20/10/2021";
            // 
            // pbx_receptionniste_deconnexion
            // 
            this.pbx_receptionniste_deconnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_receptionniste_deconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_receptionniste_deconnexion.Image = global::AppCriée.Properties.Resources.computer_icons_login_icon_design_exit_5abfc840bf8ca4_9038982415225180807846;
            this.pbx_receptionniste_deconnexion.Location = new System.Drawing.Point(1031, 577);
            this.pbx_receptionniste_deconnexion.Name = "pbx_receptionniste_deconnexion";
            this.pbx_receptionniste_deconnexion.Size = new System.Drawing.Size(45, 45);
            this.pbx_receptionniste_deconnexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_receptionniste_deconnexion.TabIndex = 20;
            this.pbx_receptionniste_deconnexion.TabStop = false;
            this.pbx_receptionniste_deconnexion.Click += new System.EventHandler(this.pbx_receptionniste_deconnexion_Click);
            // 
            // AppCriee_Receptionniste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 630);
            this.Controls.Add(this.pbx_receptionniste_deconnexion);
            this.Controls.Add(this.lbl_receptionniste_datejour);
            this.Controls.Add(this.tbc_receptionniste);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AppCriee_Receptionniste";
            this.Text = "AppCriée (Réceptionniste)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppCriee_Receptionniste_FormClosing);
            this.tbc_receptionniste.ResumeLayout(false);
            this.tabAccueil.ResumeLayout(false);
            this.tabAccueil.PerformLayout();
            this.tabPeche.ResumeLayout(false);
            this.tabPeche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pechejour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_receptionniste_deconnexion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tbc_receptionniste;
        private System.Windows.Forms.TabPage tabAccueil;
        private System.Windows.Forms.TabPage tabPeche;
        private System.Windows.Forms.Label lbl_accueil_details;
        private System.Windows.Forms.Label lbl_accueil_role;
        private System.Windows.Forms.Label lbl_accueil_bienvenue;
        private System.Windows.Forms.Button btn_pechejour_creerpeche_valider;
        private System.Windows.Forms.Label lbl_ajoutpeche_creerpeche_nombateau;
        private System.Windows.Forms.ComboBox cbx_ajoutpeche_creerpeche_nombateau;
        private System.Windows.Forms.Button btn_ajoutpeche_creerpeche;
        private System.Windows.Forms.Label lbl_ajoutpeche_explication2;
        private System.Windows.Forms.Label lbl_ajoutpeche_explication;
        private System.Windows.Forms.Label lbl_ajoutpeche_ispeche;
        private System.Windows.Forms.DataGridView dg_pechejour;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_pechejour_pecheok;
        private System.Windows.Forms.Label lbl_pechejour_allpeche;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btn_receptionniste_peche_supprimer;
        private System.Windows.Forms.Label lbl_receptionniste_datejour;
        private System.Windows.Forms.PictureBox pbx_receptionniste_deconnexion;
    }
}