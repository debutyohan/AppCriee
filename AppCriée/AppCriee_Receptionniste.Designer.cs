
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
            this.tbp_receptionniste_mesdonnees = new System.Windows.Forms.TabPage();
            this.lbl_receptionniste_mesdonnees_typeuser = new System.Windows.Forms.Label();
            this.lbl_receptionniste_mesdonnees_adrMail = new System.Windows.Forms.Label();
            this.lbl_receptionniste_mesdonnees_nom = new System.Windows.Forms.Label();
            this.lbl_receptionniste_mesdonnees_prenom = new System.Windows.Forms.Label();
            this.lbl_receptionniste_mesdonnees_login = new System.Windows.Forms.Label();
            this.lbl_receptionniste_mesdonnees_title = new System.Windows.Forms.Label();
            this.btn_receptionniste_mesdonnees_supprimer = new System.Windows.Forms.Button();
            this.lbl_receptionniste_datejour = new System.Windows.Forms.Label();
            this.pbx_receptionniste_deconnexion = new System.Windows.Forms.PictureBox();
            this.tbc_receptionniste.SuspendLayout();
            this.tabAccueil.SuspendLayout();
            this.tabPeche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pechejour)).BeginInit();
            this.tbp_receptionniste_mesdonnees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_receptionniste_deconnexion)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tbc_receptionniste
            // 
            this.tbc_receptionniste.Controls.Add(this.tabAccueil);
            this.tbc_receptionniste.Controls.Add(this.tabPeche);
            this.tbc_receptionniste.Controls.Add(this.tbp_receptionniste_mesdonnees);
            this.tbc_receptionniste.Location = new System.Drawing.Point(0, 0);
            this.tbc_receptionniste.Name = "tbc_receptionniste";
            this.tbc_receptionniste.SelectedIndex = 0;
            this.tbc_receptionniste.Size = new System.Drawing.Size(814, 552);
            this.tbc_receptionniste.TabIndex = 18;
            this.tbc_receptionniste.SelectedIndexChanged += new System.EventHandler(this.tbc_receptionniste_SelectedIndexChanged);
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
            this.tabAccueil.Size = new System.Drawing.Size(806, 526);
            this.tabAccueil.TabIndex = 0;
            this.tabAccueil.Text = "Accueil";
            // 
            // lbl_accueil_details
            // 
            this.lbl_accueil_details.AutoSize = true;
            this.lbl_accueil_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accueil_details.Location = new System.Drawing.Point(183, 277);
            this.lbl_accueil_details.Name = "lbl_accueil_details";
            this.lbl_accueil_details.Size = new System.Drawing.Size(366, 18);
            this.lbl_accueil_details.TabIndex = 3;
            this.lbl_accueil_details.Text = "Cette application permettra de gérer les pêches du jour";
            // 
            // lbl_accueil_role
            // 
            this.lbl_accueil_role.AutoSize = true;
            this.lbl_accueil_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_accueil_role.Location = new System.Drawing.Point(149, 197);
            this.lbl_accueil_role.Name = "lbl_accueil_role";
            this.lbl_accueil_role.Size = new System.Drawing.Size(219, 26);
            this.lbl_accueil_role.TabIndex = 2;
            this.lbl_accueil_role.Text = "Rôle : Réceptionniste";
            // 
            // lbl_accueil_bienvenue
            // 
            this.lbl_accueil_bienvenue.AutoSize = true;
            this.lbl_accueil_bienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_accueil_bienvenue.Location = new System.Drawing.Point(149, 131);
            this.lbl_accueil_bienvenue.Name = "lbl_accueil_bienvenue";
            this.lbl_accueil_bienvenue.Size = new System.Drawing.Size(383, 26);
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
            this.tabPeche.Location = new System.Drawing.Point(4, 22);
            this.tabPeche.Name = "tabPeche";
            this.tabPeche.Padding = new System.Windows.Forms.Padding(3);
            this.tabPeche.Size = new System.Drawing.Size(806, 526);
            this.tabPeche.TabIndex = 1;
            this.tabPeche.Text = "Pêche du jour";
            // 
            // btn_receptionniste_peche_supprimer
            // 
            this.btn_receptionniste_peche_supprimer.BackColor = System.Drawing.Color.Red;
            this.btn_receptionniste_peche_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_receptionniste_peche_supprimer.Location = new System.Drawing.Point(602, 306);
            this.btn_receptionniste_peche_supprimer.Name = "btn_receptionniste_peche_supprimer";
            this.btn_receptionniste_peche_supprimer.Size = new System.Drawing.Size(111, 25);
            this.btn_receptionniste_peche_supprimer.TabIndex = 20;
            this.btn_receptionniste_peche_supprimer.Text = "Supprimer";
            this.btn_receptionniste_peche_supprimer.UseVisualStyleBackColor = false;
            this.btn_receptionniste_peche_supprimer.Click += new System.EventHandler(this.btn_receptionniste_creerpeche_supprimer_Click);
            // 
            // lbl_pechejour_allpeche
            // 
            this.lbl_pechejour_allpeche.AutoSize = true;
            this.lbl_pechejour_allpeche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_pechejour_allpeche.Location = new System.Drawing.Point(415, 186);
            this.lbl_pechejour_allpeche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pechejour_allpeche.Name = "lbl_pechejour_allpeche";
            this.lbl_pechejour_allpeche.Size = new System.Drawing.Size(329, 24);
            this.lbl_pechejour_allpeche.TabIndex = 19;
            this.lbl_pechejour_allpeche.Text = "Tous les pêches ont été réceptionnée";
            // 
            // lbl_pechejour_pecheok
            // 
            this.lbl_pechejour_pecheok.AutoSize = true;
            this.lbl_pechejour_pecheok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pechejour_pecheok.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_pechejour_pecheok.Location = new System.Drawing.Point(78, 425);
            this.lbl_pechejour_pecheok.Name = "lbl_pechejour_pecheok";
            this.lbl_pechejour_pecheok.Size = new System.Drawing.Size(205, 18);
            this.lbl_pechejour_pecheok.TabIndex = 18;
            this.lbl_pechejour_pecheok.Text = "La pêche de ce jour du bateau";
            // 
            // btn_pechejour_creerpeche_valider
            // 
            this.btn_pechejour_creerpeche_valider.BackColor = System.Drawing.SystemColors.Info;
            this.btn_pechejour_creerpeche_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pechejour_creerpeche_valider.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_pechejour_creerpeche_valider.Location = new System.Drawing.Point(498, 425);
            this.btn_pechejour_creerpeche_valider.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pechejour_creerpeche_valider.Name = "btn_pechejour_creerpeche_valider";
            this.btn_pechejour_creerpeche_valider.Size = new System.Drawing.Size(120, 27);
            this.btn_pechejour_creerpeche_valider.TabIndex = 16;
            this.btn_pechejour_creerpeche_valider.Text = "Valider";
            this.btn_pechejour_creerpeche_valider.UseVisualStyleBackColor = false;
            this.btn_pechejour_creerpeche_valider.Click += new System.EventHandler(this.btn_receptionniste_creerpeche_valider_Click);
            // 
            // lbl_ajoutpeche_creerpeche_nombateau
            // 
            this.lbl_ajoutpeche_creerpeche_nombateau.AutoSize = true;
            this.lbl_ajoutpeche_creerpeche_nombateau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajoutpeche_creerpeche_nombateau.Location = new System.Drawing.Point(397, 378);
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
            this.cbx_ajoutpeche_creerpeche_nombateau.Location = new System.Drawing.Point(540, 380);
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
            this.btn_ajoutpeche_creerpeche.Location = new System.Drawing.Point(418, 306);
            this.btn_ajoutpeche_creerpeche.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ajoutpeche_creerpeche.Name = "btn_ajoutpeche_creerpeche";
            this.btn_ajoutpeche_creerpeche.Size = new System.Drawing.Size(120, 27);
            this.btn_ajoutpeche_creerpeche.TabIndex = 13;
            this.btn_ajoutpeche_creerpeche.Text = "Créer une pêche";
            this.btn_ajoutpeche_creerpeche.UseVisualStyleBackColor = false;
            this.btn_ajoutpeche_creerpeche.Click += new System.EventHandler(this.btn_receptionniste_creerpeche_Click);
            // 
            // lbl_ajoutpeche_explication2
            // 
            this.lbl_ajoutpeche_explication2.AutoSize = true;
            this.lbl_ajoutpeche_explication2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ajoutpeche_explication2.Location = new System.Drawing.Point(437, 150);
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
            this.lbl_ajoutpeche_explication.Location = new System.Drawing.Point(437, 113);
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
            this.lbl_ajoutpeche_ispeche.Size = new System.Drawing.Size(219, 26);
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
            this.dg_pechejour.Location = new System.Drawing.Point(53, 135);
            this.dg_pechejour.Margin = new System.Windows.Forms.Padding(2);
            this.dg_pechejour.Name = "dg_pechejour";
            this.dg_pechejour.ReadOnly = true;
            this.dg_pechejour.RowHeadersWidth = 10;
            this.dg_pechejour.RowTemplate.Height = 24;
            this.dg_pechejour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_pechejour.Size = new System.Drawing.Size(314, 237);
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
            this.lbl_title.Location = new System.Drawing.Point(209, 40);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(390, 26);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "GESTION DES PECHES DU JOUR";
            // 
            // tbp_receptionniste_mesdonnees
            // 
            this.tbp_receptionniste_mesdonnees.Controls.Add(this.lbl_receptionniste_mesdonnees_typeuser);
            this.tbp_receptionniste_mesdonnees.Controls.Add(this.lbl_receptionniste_mesdonnees_adrMail);
            this.tbp_receptionniste_mesdonnees.Controls.Add(this.lbl_receptionniste_mesdonnees_nom);
            this.tbp_receptionniste_mesdonnees.Controls.Add(this.lbl_receptionniste_mesdonnees_prenom);
            this.tbp_receptionniste_mesdonnees.Controls.Add(this.lbl_receptionniste_mesdonnees_login);
            this.tbp_receptionniste_mesdonnees.Controls.Add(this.lbl_receptionniste_mesdonnees_title);
            this.tbp_receptionniste_mesdonnees.Controls.Add(this.btn_receptionniste_mesdonnees_supprimer);
            this.tbp_receptionniste_mesdonnees.Location = new System.Drawing.Point(4, 22);
            this.tbp_receptionniste_mesdonnees.Margin = new System.Windows.Forms.Padding(2);
            this.tbp_receptionniste_mesdonnees.Name = "tbp_receptionniste_mesdonnees";
            this.tbp_receptionniste_mesdonnees.Padding = new System.Windows.Forms.Padding(2);
            this.tbp_receptionniste_mesdonnees.Size = new System.Drawing.Size(806, 526);
            this.tbp_receptionniste_mesdonnees.TabIndex = 2;
            this.tbp_receptionniste_mesdonnees.Text = "Mes données";
            this.tbp_receptionniste_mesdonnees.UseVisualStyleBackColor = true;
            // 
            // lbl_receptionniste_mesdonnees_typeuser
            // 
            this.lbl_receptionniste_mesdonnees_typeuser.AutoSize = true;
            this.lbl_receptionniste_mesdonnees_typeuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receptionniste_mesdonnees_typeuser.Location = new System.Drawing.Point(41, 245);
            this.lbl_receptionniste_mesdonnees_typeuser.Name = "lbl_receptionniste_mesdonnees_typeuser";
            this.lbl_receptionniste_mesdonnees_typeuser.Size = new System.Drawing.Size(329, 24);
            this.lbl_receptionniste_mesdonnees_typeuser.TabIndex = 45;
            this.lbl_receptionniste_mesdonnees_typeuser.Text = "Type utilisateur : [Votre type utilisateur]";
            // 
            // lbl_receptionniste_mesdonnees_adrMail
            // 
            this.lbl_receptionniste_mesdonnees_adrMail.AutoSize = true;
            this.lbl_receptionniste_mesdonnees_adrMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receptionniste_mesdonnees_adrMail.Location = new System.Drawing.Point(277, 168);
            this.lbl_receptionniste_mesdonnees_adrMail.Name = "lbl_receptionniste_mesdonnees_adrMail";
            this.lbl_receptionniste_mesdonnees_adrMail.Size = new System.Drawing.Size(300, 24);
            this.lbl_receptionniste_mesdonnees_adrMail.TabIndex = 44;
            this.lbl_receptionniste_mesdonnees_adrMail.Text = "Adresse mail : [Votre adresse mail]";
            // 
            // lbl_receptionniste_mesdonnees_nom
            // 
            this.lbl_receptionniste_mesdonnees_nom.AutoSize = true;
            this.lbl_receptionniste_mesdonnees_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receptionniste_mesdonnees_nom.Location = new System.Drawing.Point(41, 168);
            this.lbl_receptionniste_mesdonnees_nom.Name = "lbl_receptionniste_mesdonnees_nom";
            this.lbl_receptionniste_mesdonnees_nom.Size = new System.Drawing.Size(164, 24);
            this.lbl_receptionniste_mesdonnees_nom.TabIndex = 43;
            this.lbl_receptionniste_mesdonnees_nom.Text = "Nom : [Votre nom]";
            // 
            // lbl_receptionniste_mesdonnees_prenom
            // 
            this.lbl_receptionniste_mesdonnees_prenom.AutoSize = true;
            this.lbl_receptionniste_mesdonnees_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receptionniste_mesdonnees_prenom.Location = new System.Drawing.Point(277, 95);
            this.lbl_receptionniste_mesdonnees_prenom.Name = "lbl_receptionniste_mesdonnees_prenom";
            this.lbl_receptionniste_mesdonnees_prenom.Size = new System.Drawing.Size(218, 24);
            this.lbl_receptionniste_mesdonnees_prenom.TabIndex = 42;
            this.lbl_receptionniste_mesdonnees_prenom.Text = "Prénom : [Votre prénom]";
            // 
            // lbl_receptionniste_mesdonnees_login
            // 
            this.lbl_receptionniste_mesdonnees_login.AutoSize = true;
            this.lbl_receptionniste_mesdonnees_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receptionniste_mesdonnees_login.Location = new System.Drawing.Point(41, 95);
            this.lbl_receptionniste_mesdonnees_login.Name = "lbl_receptionniste_mesdonnees_login";
            this.lbl_receptionniste_mesdonnees_login.Size = new System.Drawing.Size(173, 24);
            this.lbl_receptionniste_mesdonnees_login.TabIndex = 41;
            this.lbl_receptionniste_mesdonnees_login.Text = "Login : [Votre login]";
            // 
            // lbl_receptionniste_mesdonnees_title
            // 
            this.lbl_receptionniste_mesdonnees_title.AutoSize = true;
            this.lbl_receptionniste_mesdonnees_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_receptionniste_mesdonnees_title.Location = new System.Drawing.Point(216, 22);
            this.lbl_receptionniste_mesdonnees_title.Name = "lbl_receptionniste_mesdonnees_title";
            this.lbl_receptionniste_mesdonnees_title.Size = new System.Drawing.Size(338, 26);
            this.lbl_receptionniste_mesdonnees_title.TabIndex = 40;
            this.lbl_receptionniste_mesdonnees_title.Text = "GESTION DE VOS DONNEES";
            // 
            // btn_receptionniste_mesdonnees_supprimer
            // 
            this.btn_receptionniste_mesdonnees_supprimer.BackColor = System.Drawing.Color.Red;
            this.btn_receptionniste_mesdonnees_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_receptionniste_mesdonnees_supprimer.Location = new System.Drawing.Point(588, 84);
            this.btn_receptionniste_mesdonnees_supprimer.Name = "btn_receptionniste_mesdonnees_supprimer";
            this.btn_receptionniste_mesdonnees_supprimer.Size = new System.Drawing.Size(150, 42);
            this.btn_receptionniste_mesdonnees_supprimer.TabIndex = 21;
            this.btn_receptionniste_mesdonnees_supprimer.Text = "Supprimer mon compte";
            this.btn_receptionniste_mesdonnees_supprimer.UseVisualStyleBackColor = false;
            this.btn_receptionniste_mesdonnees_supprimer.Click += new System.EventHandler(this.btn_receptionniste_mesdonnees_supprimer_Click);
            // 
            // lbl_receptionniste_datejour
            // 
            this.lbl_receptionniste_datejour.AutoSize = true;
            this.lbl_receptionniste_datejour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receptionniste_datejour.Location = new System.Drawing.Point(578, 563);
            this.lbl_receptionniste_datejour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_receptionniste_datejour.Name = "lbl_receptionniste_datejour";
            this.lbl_receptionniste_datejour.Size = new System.Drawing.Size(172, 18);
            this.lbl_receptionniste_datejour.TabIndex = 19;
            this.lbl_receptionniste_datejour.Text = "Date du jour : 20/10/2021";
            // 
            // pbx_receptionniste_deconnexion
            // 
            this.pbx_receptionniste_deconnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_receptionniste_deconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_receptionniste_deconnexion.Image = global::AppCriée.Properties.Resources.computer_icons_login_icon_design_exit_5abfc840bf8ca4_9038982415225180807846;
            this.pbx_receptionniste_deconnexion.Location = new System.Drawing.Point(764, 557);
            this.pbx_receptionniste_deconnexion.Margin = new System.Windows.Forms.Padding(2);
            this.pbx_receptionniste_deconnexion.Name = "pbx_receptionniste_deconnexion";
            this.pbx_receptionniste_deconnexion.Size = new System.Drawing.Size(34, 37);
            this.pbx_receptionniste_deconnexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_receptionniste_deconnexion.TabIndex = 20;
            this.pbx_receptionniste_deconnexion.TabStop = false;
            this.pbx_receptionniste_deconnexion.Click += new System.EventHandler(this.pbx_receptionniste_deconnexion_Click);
            // 
            // AppCriee_Receptionniste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 598);
            this.Controls.Add(this.pbx_receptionniste_deconnexion);
            this.Controls.Add(this.lbl_receptionniste_datejour);
            this.Controls.Add(this.tbc_receptionniste);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(833, 643);
            this.MinimumSize = new System.Drawing.Size(833, 597);
            this.Name = "AppCriee_Receptionniste";
            this.Text = "AppCriée (Réceptionniste)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppCriee_Receptionniste_FormClosing);
            this.tbc_receptionniste.ResumeLayout(false);
            this.tabAccueil.ResumeLayout(false);
            this.tabAccueil.PerformLayout();
            this.tabPeche.ResumeLayout(false);
            this.tabPeche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pechejour)).EndInit();
            this.tbp_receptionniste_mesdonnees.ResumeLayout(false);
            this.tbp_receptionniste_mesdonnees.PerformLayout();
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
        private System.Windows.Forms.TabPage tbp_receptionniste_mesdonnees;
        private System.Windows.Forms.Button btn_receptionniste_mesdonnees_supprimer;
        private System.Windows.Forms.Label lbl_receptionniste_mesdonnees_typeuser;
        private System.Windows.Forms.Label lbl_receptionniste_mesdonnees_adrMail;
        private System.Windows.Forms.Label lbl_receptionniste_mesdonnees_nom;
        private System.Windows.Forms.Label lbl_receptionniste_mesdonnees_prenom;
        private System.Windows.Forms.Label lbl_receptionniste_mesdonnees_login;
        private System.Windows.Forms.Label lbl_receptionniste_mesdonnees_title;
    }
}