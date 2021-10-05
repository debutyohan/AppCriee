
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAccueil = new System.Windows.Forms.TabPage();
            this.lbl_accueil_details = new System.Windows.Forms.Label();
            this.lbl_accueil_role = new System.Windows.Forms.Label();
            this.lbl_accueil_bienvenue = new System.Windows.Forms.Label();
            this.tabPeche = new System.Windows.Forms.TabPage();
            this.lbl_error_connection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lbl_ajoutpeche_datejour = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabAccueil.SuspendLayout();
            this.tabPeche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pechejour)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAccueil);
            this.tabControl1.Controls.Add(this.tabPeche);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(824, 463);
            this.tabControl1.TabIndex = 18;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabAccueil
            // 
            this.tabAccueil.BackColor = System.Drawing.SystemColors.Control;
            this.tabAccueil.Controls.Add(this.lbl_accueil_details);
            this.tabAccueil.Controls.Add(this.lbl_accueil_role);
            this.tabAccueil.Controls.Add(this.lbl_accueil_bienvenue);
            this.tabAccueil.Location = new System.Drawing.Point(4, 22);
            this.tabAccueil.Name = "tabAccueil";
            this.tabAccueil.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccueil.Size = new System.Drawing.Size(816, 437);
            this.tabAccueil.TabIndex = 0;
            this.tabAccueil.Text = "Accueil";
            this.tabAccueil.Click += new System.EventHandler(this.tabAccueil_Click);
            // 
            // lbl_accueil_details
            // 
            this.lbl_accueil_details.AutoSize = true;
            this.lbl_accueil_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accueil_details.Location = new System.Drawing.Point(166, 240);
            this.lbl_accueil_details.Name = "lbl_accueil_details";
            this.lbl_accueil_details.Size = new System.Drawing.Size(366, 18);
            this.lbl_accueil_details.TabIndex = 3;
            this.lbl_accueil_details.Text = "Cette application permettra de gérer les pêches du jour";
            // 
            // lbl_accueil_role
            // 
            this.lbl_accueil_role.AutoSize = true;
            this.lbl_accueil_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_accueil_role.Location = new System.Drawing.Point(151, 149);
            this.lbl_accueil_role.Name = "lbl_accueil_role";
            this.lbl_accueil_role.Size = new System.Drawing.Size(219, 26);
            this.lbl_accueil_role.TabIndex = 2;
            this.lbl_accueil_role.Text = "Rôle : Réceptionniste";
            // 
            // lbl_accueil_bienvenue
            // 
            this.lbl_accueil_bienvenue.AutoSize = true;
            this.lbl_accueil_bienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_accueil_bienvenue.Location = new System.Drawing.Point(151, 90);
            this.lbl_accueil_bienvenue.Name = "lbl_accueil_bienvenue";
            this.lbl_accueil_bienvenue.Size = new System.Drawing.Size(383, 26);
            this.lbl_accueil_bienvenue.TabIndex = 1;
            this.lbl_accueil_bienvenue.Text = "Bienvenue [Nom_user] [Prenom_user]";
            // 
            // tabPeche
            // 
            this.tabPeche.BackColor = System.Drawing.SystemColors.Control;
            this.tabPeche.Controls.Add(this.lbl_error_connection);
            this.tabPeche.Controls.Add(this.label1);
            this.tabPeche.Controls.Add(this.btn_pechejour_creerpeche_valider);
            this.tabPeche.Controls.Add(this.lbl_ajoutpeche_creerpeche_nombateau);
            this.tabPeche.Controls.Add(this.cbx_ajoutpeche_creerpeche_nombateau);
            this.tabPeche.Controls.Add(this.btn_ajoutpeche_creerpeche);
            this.tabPeche.Controls.Add(this.lbl_ajoutpeche_explication2);
            this.tabPeche.Controls.Add(this.lbl_ajoutpeche_explication);
            this.tabPeche.Controls.Add(this.lbl_ajoutpeche_ispeche);
            this.tabPeche.Controls.Add(this.dg_pechejour);
            this.tabPeche.Controls.Add(this.lbl_ajoutpeche_datejour);
            this.tabPeche.Controls.Add(this.lbl_title);
            this.tabPeche.Location = new System.Drawing.Point(4, 22);
            this.tabPeche.Name = "tabPeche";
            this.tabPeche.Padding = new System.Windows.Forms.Padding(3);
            this.tabPeche.Size = new System.Drawing.Size(816, 437);
            this.tabPeche.TabIndex = 1;
            this.tabPeche.Text = "Pêche du jour";
            this.tabPeche.Click += new System.EventHandler(this.tabPeche_Click);
            // 
            // lbl_error_connection
            // 
            this.lbl_error_connection.AutoSize = true;
            this.lbl_error_connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_error_connection.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_connection.Location = new System.Drawing.Point(180, 212);
            this.lbl_error_connection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_error_connection.Name = "lbl_error_connection";
            this.lbl_error_connection.Size = new System.Drawing.Size(419, 25);
            this.lbl_error_connection.TabIndex = 19;
            this.lbl_error_connection.Text = "Impossible de se connecter au serveur MySQL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(61, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "La pêche de ce jour du bateau";
            // 
            // btn_pechejour_creerpeche_valider
            // 
            this.btn_pechejour_creerpeche_valider.BackColor = System.Drawing.SystemColors.Info;
            this.btn_pechejour_creerpeche_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pechejour_creerpeche_valider.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_pechejour_creerpeche_valider.Location = new System.Drawing.Point(463, 369);
            this.btn_pechejour_creerpeche_valider.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pechejour_creerpeche_valider.Name = "btn_pechejour_creerpeche_valider";
            this.btn_pechejour_creerpeche_valider.Size = new System.Drawing.Size(120, 27);
            this.btn_pechejour_creerpeche_valider.TabIndex = 16;
            this.btn_pechejour_creerpeche_valider.Text = "Valider";
            this.btn_pechejour_creerpeche_valider.UseVisualStyleBackColor = false;
            this.btn_pechejour_creerpeche_valider.Click += new System.EventHandler(this.btn_pechejour_creerpeche_valider_Click_1);
            // 
            // lbl_ajoutpeche_creerpeche_nombateau
            // 
            this.lbl_ajoutpeche_creerpeche_nombateau.AutoSize = true;
            this.lbl_ajoutpeche_creerpeche_nombateau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajoutpeche_creerpeche_nombateau.Location = new System.Drawing.Point(396, 328);
            this.lbl_ajoutpeche_creerpeche_nombateau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ajoutpeche_creerpeche_nombateau.Name = "lbl_ajoutpeche_creerpeche_nombateau";
            this.lbl_ajoutpeche_creerpeche_nombateau.Size = new System.Drawing.Size(119, 18);
            this.lbl_ajoutpeche_creerpeche_nombateau.TabIndex = 15;
            this.lbl_ajoutpeche_creerpeche_nombateau.Text = "Nom du Bateau :";
            // 
            // cbx_ajoutpeche_creerpeche_nombateau
            // 
            this.cbx_ajoutpeche_creerpeche_nombateau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ajoutpeche_creerpeche_nombateau.FormattingEnabled = true;
            this.cbx_ajoutpeche_creerpeche_nombateau.Location = new System.Drawing.Point(519, 328);
            this.cbx_ajoutpeche_creerpeche_nombateau.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_ajoutpeche_creerpeche_nombateau.Name = "cbx_ajoutpeche_creerpeche_nombateau";
            this.cbx_ajoutpeche_creerpeche_nombateau.Size = new System.Drawing.Size(174, 21);
            this.cbx_ajoutpeche_creerpeche_nombateau.TabIndex = 14;
            // 
            // btn_ajoutpeche_creerpeche
            // 
            this.btn_ajoutpeche_creerpeche.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_ajoutpeche_creerpeche.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutpeche_creerpeche.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ajoutpeche_creerpeche.Location = new System.Drawing.Point(480, 338);
            this.btn_ajoutpeche_creerpeche.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ajoutpeche_creerpeche.Name = "btn_ajoutpeche_creerpeche";
            this.btn_ajoutpeche_creerpeche.Size = new System.Drawing.Size(120, 27);
            this.btn_ajoutpeche_creerpeche.TabIndex = 13;
            this.btn_ajoutpeche_creerpeche.Text = "Créer une pêche";
            this.btn_ajoutpeche_creerpeche.UseVisualStyleBackColor = false;
            this.btn_ajoutpeche_creerpeche.Click += new System.EventHandler(this.btn_ajoutpeche_creerpeche_Click_1);
            // 
            // lbl_ajoutpeche_explication2
            // 
            this.lbl_ajoutpeche_explication2.AutoSize = true;
            this.lbl_ajoutpeche_explication2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ajoutpeche_explication2.Location = new System.Drawing.Point(443, 257);
            this.lbl_ajoutpeche_explication2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ajoutpeche_explication2.Name = "lbl_ajoutpeche_explication2";
            this.lbl_ajoutpeche_explication2.Size = new System.Drawing.Size(224, 20);
            this.lbl_ajoutpeche_explication2.TabIndex = 12;
            this.lbl_ajoutpeche_explication2.Text = "cliquant sur \"Créer une pêche\"";
            // 
            // lbl_ajoutpeche_explication
            // 
            this.lbl_ajoutpeche_explication.AutoSize = true;
            this.lbl_ajoutpeche_explication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ajoutpeche_explication.Location = new System.Drawing.Point(443, 220);
            this.lbl_ajoutpeche_explication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ajoutpeche_explication.Name = "lbl_ajoutpeche_explication";
            this.lbl_ajoutpeche_explication.Size = new System.Drawing.Size(222, 20);
            this.lbl_ajoutpeche_explication.TabIndex = 11;
            this.lbl_ajoutpeche_explication.Text = "Insérer une nouvelle pêche en";
            // 
            // lbl_ajoutpeche_ispeche
            // 
            this.lbl_ajoutpeche_ispeche.AutoSize = true;
            this.lbl_ajoutpeche_ispeche.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_ajoutpeche_ispeche.Location = new System.Drawing.Point(193, 186);
            this.lbl_ajoutpeche_ispeche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ajoutpeche_ispeche.Name = "lbl_ajoutpeche_ispeche";
            this.lbl_ajoutpeche_ispeche.Size = new System.Drawing.Size(58, 26);
            this.lbl_ajoutpeche_ispeche.TabIndex = 10;
            this.lbl_ajoutpeche_ispeche.Text = "label";
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
            this.dg_pechejour.Location = new System.Drawing.Point(53, 135);
            this.dg_pechejour.Margin = new System.Windows.Forms.Padding(2);
            this.dg_pechejour.Name = "dg_pechejour";
            this.dg_pechejour.ReadOnly = true;
            this.dg_pechejour.RowHeadersWidth = 10;
            this.dg_pechejour.RowTemplate.Height = 24;
            this.dg_pechejour.Size = new System.Drawing.Size(314, 237);
            this.dg_pechejour.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nom du bateau";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // lbl_ajoutpeche_datejour
            // 
            this.lbl_ajoutpeche_datejour.AutoSize = true;
            this.lbl_ajoutpeche_datejour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajoutpeche_datejour.Location = new System.Drawing.Point(161, 88);
            this.lbl_ajoutpeche_datejour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ajoutpeche_datejour.Name = "lbl_ajoutpeche_datejour";
            this.lbl_ajoutpeche_datejour.Size = new System.Drawing.Size(100, 18);
            this.lbl_ajoutpeche_datejour.TabIndex = 8;
            this.lbl_ajoutpeche_datejour.Text = "Date du jour : ";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(209, 40);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(390, 26);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "GESTION DES PECHES DU JOUR";
            // 
            // AppCriee_Receptionniste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 456);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AppCriee_Receptionniste";
            this.Text = "AppCriée (Réceptionniste)";
            this.Load += new System.EventHandler(this.AppCriee_Receptionniste_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAccueil.ResumeLayout(false);
            this.tabAccueil.PerformLayout();
            this.tabPeche.ResumeLayout(false);
            this.tabPeche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pechejour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
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
        private System.Windows.Forms.Label lbl_ajoutpeche_datejour;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_error_connection;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}