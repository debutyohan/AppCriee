
namespace AppCriée
{
    partial class AppCriee_DirecteurDesVentes
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
            this.tbc_directeurdesventes = new System.Windows.Forms.TabControl();
            this.tbp_directeurdesventes_accueil = new System.Windows.Forms.TabPage();
            this.lbl_directeurdesventes_accueil_role = new System.Windows.Forms.Label();
            this.lbl_directeurdesventes_accueil_bienvenue = new System.Windows.Forms.Label();
            this.tbp_directeurdesventes_lotsvente = new System.Windows.Forms.TabPage();
            this.lbl_directeurdesventes_lotsvente_islots = new System.Windows.Forms.Label();
            this.dg_directeurdesventes_lotsvente_alllot = new System.Windows.Forms.DataGridView();
            this.nomBateau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbbac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poidsTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeEtat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddubateau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_directeurdesventes_lotsvente_title = new System.Windows.Forms.Label();
            this.tbp_directeurdesventes_mesdonnees = new System.Windows.Forms.TabPage();
            this.btn_peseur_mesdonnees_supprimer = new System.Windows.Forms.Button();
            this.pbx_directeurdesventes_deconnexion = new System.Windows.Forms.PictureBox();
            this.lbl_directeurdesventes_datejour = new System.Windows.Forms.Label();
            this.lbl_directeurdesventes_mesdonnees_typeuser = new System.Windows.Forms.Label();
            this.lbl_directeurdesventes_mesdonnees_adrMail = new System.Windows.Forms.Label();
            this.lbl_directeurdesventes_mesdonnees_nom = new System.Windows.Forms.Label();
            this.lbl_directeurdesventes_mesdonnees_prenom = new System.Windows.Forms.Label();
            this.lbl_directeurdesventes_mesdonnees_login = new System.Windows.Forms.Label();
            this.lbl_directeurdesventes_mesdonnees_title = new System.Windows.Forms.Label();
            this.tbc_directeurdesventes.SuspendLayout();
            this.tbp_directeurdesventes_accueil.SuspendLayout();
            this.tbp_directeurdesventes_lotsvente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_directeurdesventes_lotsvente_alllot)).BeginInit();
            this.tbp_directeurdesventes_mesdonnees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_directeurdesventes_deconnexion)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_directeurdesventes
            // 
            this.tbc_directeurdesventes.Controls.Add(this.tbp_directeurdesventes_accueil);
            this.tbc_directeurdesventes.Controls.Add(this.tbp_directeurdesventes_lotsvente);
            this.tbc_directeurdesventes.Controls.Add(this.tbp_directeurdesventes_mesdonnees);
            this.tbc_directeurdesventes.Location = new System.Drawing.Point(0, 0);
            this.tbc_directeurdesventes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbc_directeurdesventes.Name = "tbc_directeurdesventes";
            this.tbc_directeurdesventes.SelectedIndex = 0;
            this.tbc_directeurdesventes.Size = new System.Drawing.Size(814, 552);
            this.tbc_directeurdesventes.TabIndex = 0;
            this.tbc_directeurdesventes.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbc_directeurdesventes_Selected);
            // 
            // tbp_directeurdesventes_accueil
            // 
            this.tbp_directeurdesventes_accueil.Controls.Add(this.lbl_directeurdesventes_accueil_role);
            this.tbp_directeurdesventes_accueil.Controls.Add(this.lbl_directeurdesventes_accueil_bienvenue);
            this.tbp_directeurdesventes_accueil.Location = new System.Drawing.Point(4, 22);
            this.tbp_directeurdesventes_accueil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbp_directeurdesventes_accueil.Name = "tbp_directeurdesventes_accueil";
            this.tbp_directeurdesventes_accueil.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbp_directeurdesventes_accueil.Size = new System.Drawing.Size(806, 526);
            this.tbp_directeurdesventes_accueil.TabIndex = 0;
            this.tbp_directeurdesventes_accueil.Text = "Accueil";
            this.tbp_directeurdesventes_accueil.UseVisualStyleBackColor = true;
            // 
            // lbl_directeurdesventes_accueil_role
            // 
            this.lbl_directeurdesventes_accueil_role.AutoSize = true;
            this.lbl_directeurdesventes_accueil_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_directeurdesventes_accueil_role.Location = new System.Drawing.Point(149, 197);
            this.lbl_directeurdesventes_accueil_role.Name = "lbl_directeurdesventes_accueil_role";
            this.lbl_directeurdesventes_accueil_role.Size = new System.Drawing.Size(278, 26);
            this.lbl_directeurdesventes_accueil_role.TabIndex = 19;
            this.lbl_directeurdesventes_accueil_role.Text = "Rôle : Directeur des Ventes";
            // 
            // lbl_directeurdesventes_accueil_bienvenue
            // 
            this.lbl_directeurdesventes_accueil_bienvenue.AutoSize = true;
            this.lbl_directeurdesventes_accueil_bienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_directeurdesventes_accueil_bienvenue.Location = new System.Drawing.Point(149, 131);
            this.lbl_directeurdesventes_accueil_bienvenue.Name = "lbl_directeurdesventes_accueil_bienvenue";
            this.lbl_directeurdesventes_accueil_bienvenue.Size = new System.Drawing.Size(383, 26);
            this.lbl_directeurdesventes_accueil_bienvenue.TabIndex = 2;
            this.lbl_directeurdesventes_accueil_bienvenue.Text = "Bienvenue [Nom_user] [Prenom_user]";
            // 
            // tbp_directeurdesventes_lotsvente
            // 
            this.tbp_directeurdesventes_lotsvente.Controls.Add(this.lbl_directeurdesventes_lotsvente_islots);
            this.tbp_directeurdesventes_lotsvente.Controls.Add(this.dg_directeurdesventes_lotsvente_alllot);
            this.tbp_directeurdesventes_lotsvente.Controls.Add(this.lbl_directeurdesventes_lotsvente_title);
            this.tbp_directeurdesventes_lotsvente.Location = new System.Drawing.Point(4, 22);
            this.tbp_directeurdesventes_lotsvente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbp_directeurdesventes_lotsvente.Name = "tbp_directeurdesventes_lotsvente";
            this.tbp_directeurdesventes_lotsvente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbp_directeurdesventes_lotsvente.Size = new System.Drawing.Size(806, 526);
            this.tbp_directeurdesventes_lotsvente.TabIndex = 1;
            this.tbp_directeurdesventes_lotsvente.Text = "Lots prêts pour la vente";
            this.tbp_directeurdesventes_lotsvente.UseVisualStyleBackColor = true;
            // 
            // lbl_directeurdesventes_lotsvente_islots
            // 
            this.lbl_directeurdesventes_lotsvente_islots.AutoSize = true;
            this.lbl_directeurdesventes_lotsvente_islots.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbl_directeurdesventes_lotsvente_islots.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_directeurdesventes_lotsvente_islots.Location = new System.Drawing.Point(81, 231);
            this.lbl_directeurdesventes_lotsvente_islots.Name = "lbl_directeurdesventes_lotsvente_islots";
            this.lbl_directeurdesventes_lotsvente_islots.Size = new System.Drawing.Size(526, 18);
            this.lbl_directeurdesventes_lotsvente_islots.TabIndex = 40;
            this.lbl_directeurdesventes_lotsvente_islots.Text = "Pas encore de lots prêts à la vente pour aujourd’hui, veillez contacter le peseur" +
    ".";
            // 
            // dg_directeurdesventes_lotsvente_alllot
            // 
            this.dg_directeurdesventes_lotsvente_alllot.AllowUserToAddRows = false;
            this.dg_directeurdesventes_lotsvente_alllot.AllowUserToDeleteRows = false;
            this.dg_directeurdesventes_lotsvente_alllot.AllowUserToResizeRows = false;
            this.dg_directeurdesventes_lotsvente_alllot.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_directeurdesventes_lotsvente_alllot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_directeurdesventes_lotsvente_alllot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_directeurdesventes_lotsvente_alllot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomBateau,
            this.numLot,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.nbbac,
            this.poidsTotal,
            this.codeEtat,
            this.iddubateau});
            this.dg_directeurdesventes_lotsvente_alllot.GridColor = System.Drawing.SystemColors.Control;
            this.dg_directeurdesventes_lotsvente_alllot.Location = new System.Drawing.Point(6, 87);
            this.dg_directeurdesventes_lotsvente_alllot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dg_directeurdesventes_lotsvente_alllot.MultiSelect = false;
            this.dg_directeurdesventes_lotsvente_alllot.Name = "dg_directeurdesventes_lotsvente_alllot";
            this.dg_directeurdesventes_lotsvente_alllot.ReadOnly = true;
            this.dg_directeurdesventes_lotsvente_alllot.RowHeadersWidth = 10;
            this.dg_directeurdesventes_lotsvente_alllot.RowTemplate.Height = 24;
            this.dg_directeurdesventes_lotsvente_alllot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_directeurdesventes_lotsvente_alllot.Size = new System.Drawing.Size(795, 352);
            this.dg_directeurdesventes_lotsvente_alllot.TabIndex = 39;
            this.dg_directeurdesventes_lotsvente_alllot.Visible = false;
            // 
            // nomBateau
            // 
            this.nomBateau.HeaderText = "Nom du bateau";
            this.nomBateau.MinimumWidth = 6;
            this.nomBateau.Name = "nomBateau";
            this.nomBateau.ReadOnly = true;
            this.nomBateau.Width = 125;
            // 
            // numLot
            // 
            this.numLot.HeaderText = "Numéro de lot";
            this.numLot.MinimumWidth = 6;
            this.numLot.Name = "numLot";
            this.numLot.ReadOnly = true;
            this.numLot.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Espèce";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Taille";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 65;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Qualité";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 65;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Présentation";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 75;
            // 
            // nbbac
            // 
            this.nbbac.HeaderText = "Nombre de bacs";
            this.nbbac.MinimumWidth = 6;
            this.nbbac.Name = "nbbac";
            this.nbbac.ReadOnly = true;
            this.nbbac.Width = 125;
            // 
            // poidsTotal
            // 
            this.poidsTotal.HeaderText = "Poids total (en kg)";
            this.poidsTotal.MinimumWidth = 6;
            this.poidsTotal.Name = "poidsTotal";
            this.poidsTotal.ReadOnly = true;
            this.poidsTotal.Width = 115;
            // 
            // codeEtat
            // 
            this.codeEtat.HeaderText = "Code état";
            this.codeEtat.MinimumWidth = 6;
            this.codeEtat.Name = "codeEtat";
            this.codeEtat.ReadOnly = true;
            this.codeEtat.Visible = false;
            this.codeEtat.Width = 125;
            // 
            // iddubateau
            // 
            this.iddubateau.HeaderText = "idbateau";
            this.iddubateau.MinimumWidth = 6;
            this.iddubateau.Name = "iddubateau";
            this.iddubateau.ReadOnly = true;
            this.iddubateau.Visible = false;
            this.iddubateau.Width = 125;
            // 
            // lbl_directeurdesventes_lotsvente_title
            // 
            this.lbl_directeurdesventes_lotsvente_title.AutoSize = true;
            this.lbl_directeurdesventes_lotsvente_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_directeurdesventes_lotsvente_title.Location = new System.Drawing.Point(228, 25);
            this.lbl_directeurdesventes_lotsvente_title.Name = "lbl_directeurdesventes_lotsvente_title";
            this.lbl_directeurdesventes_lotsvente_title.Size = new System.Drawing.Size(353, 29);
            this.lbl_directeurdesventes_lotsvente_title.TabIndex = 1;
            this.lbl_directeurdesventes_lotsvente_title.Text = "Liste des lots prêts à la vente";
            // 
            // tbp_directeurdesventes_mesdonnees
            // 
            this.tbp_directeurdesventes_mesdonnees.Controls.Add(this.lbl_directeurdesventes_mesdonnees_typeuser);
            this.tbp_directeurdesventes_mesdonnees.Controls.Add(this.lbl_directeurdesventes_mesdonnees_adrMail);
            this.tbp_directeurdesventes_mesdonnees.Controls.Add(this.lbl_directeurdesventes_mesdonnees_nom);
            this.tbp_directeurdesventes_mesdonnees.Controls.Add(this.lbl_directeurdesventes_mesdonnees_prenom);
            this.tbp_directeurdesventes_mesdonnees.Controls.Add(this.lbl_directeurdesventes_mesdonnees_login);
            this.tbp_directeurdesventes_mesdonnees.Controls.Add(this.lbl_directeurdesventes_mesdonnees_title);
            this.tbp_directeurdesventes_mesdonnees.Controls.Add(this.btn_peseur_mesdonnees_supprimer);
            this.tbp_directeurdesventes_mesdonnees.Location = new System.Drawing.Point(4, 22);
            this.tbp_directeurdesventes_mesdonnees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbp_directeurdesventes_mesdonnees.Name = "tbp_directeurdesventes_mesdonnees";
            this.tbp_directeurdesventes_mesdonnees.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbp_directeurdesventes_mesdonnees.Size = new System.Drawing.Size(806, 526);
            this.tbp_directeurdesventes_mesdonnees.TabIndex = 2;
            this.tbp_directeurdesventes_mesdonnees.Text = "Mes données";
            this.tbp_directeurdesventes_mesdonnees.UseVisualStyleBackColor = true;
            // 
            // btn_peseur_mesdonnees_supprimer
            // 
            this.btn_peseur_mesdonnees_supprimer.BackColor = System.Drawing.Color.Red;
            this.btn_peseur_mesdonnees_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_peseur_mesdonnees_supprimer.Location = new System.Drawing.Point(588, 84);
            this.btn_peseur_mesdonnees_supprimer.Name = "btn_peseur_mesdonnees_supprimer";
            this.btn_peseur_mesdonnees_supprimer.Size = new System.Drawing.Size(150, 42);
            this.btn_peseur_mesdonnees_supprimer.TabIndex = 24;
            this.btn_peseur_mesdonnees_supprimer.Text = "Supprimer mon compte";
            this.btn_peseur_mesdonnees_supprimer.UseVisualStyleBackColor = false;
            this.btn_peseur_mesdonnees_supprimer.Click += new System.EventHandler(this.btn_peseur_mesdonnees_supprimer_Click);
            // 
            // pbx_directeurdesventes_deconnexion
            // 
            this.pbx_directeurdesventes_deconnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_directeurdesventes_deconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_directeurdesventes_deconnexion.Image = global::AppCriée.Properties.Resources.computer_icons_login_icon_design_exit_5abfc840bf8ca4_9038982415225180807846;
            this.pbx_directeurdesventes_deconnexion.Location = new System.Drawing.Point(764, 557);
            this.pbx_directeurdesventes_deconnexion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbx_directeurdesventes_deconnexion.Name = "pbx_directeurdesventes_deconnexion";
            this.pbx_directeurdesventes_deconnexion.Size = new System.Drawing.Size(34, 37);
            this.pbx_directeurdesventes_deconnexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_directeurdesventes_deconnexion.TabIndex = 20;
            this.pbx_directeurdesventes_deconnexion.TabStop = false;
            this.pbx_directeurdesventes_deconnexion.Click += new System.EventHandler(this.pbx_directeurdesventes_deconnexion_Click);
            // 
            // lbl_directeurdesventes_datejour
            // 
            this.lbl_directeurdesventes_datejour.AutoSize = true;
            this.lbl_directeurdesventes_datejour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_directeurdesventes_datejour.Location = new System.Drawing.Point(578, 563);
            this.lbl_directeurdesventes_datejour.Name = "lbl_directeurdesventes_datejour";
            this.lbl_directeurdesventes_datejour.Size = new System.Drawing.Size(172, 18);
            this.lbl_directeurdesventes_datejour.TabIndex = 20;
            this.lbl_directeurdesventes_datejour.Text = "Date du jour : 23/10/2021";
            // 
            // lbl_directeurdesventes_mesdonnees_typeuser
            // 
            this.lbl_directeurdesventes_mesdonnees_typeuser.AutoSize = true;
            this.lbl_directeurdesventes_mesdonnees_typeuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_directeurdesventes_mesdonnees_typeuser.Location = new System.Drawing.Point(26, 251);
            this.lbl_directeurdesventes_mesdonnees_typeuser.Name = "lbl_directeurdesventes_mesdonnees_typeuser";
            this.lbl_directeurdesventes_mesdonnees_typeuser.Size = new System.Drawing.Size(329, 24);
            this.lbl_directeurdesventes_mesdonnees_typeuser.TabIndex = 51;
            this.lbl_directeurdesventes_mesdonnees_typeuser.Text = "Type utilisateur : [Votre type utilisateur]";
            // 
            // lbl_directeurdesventes_mesdonnees_adrMail
            // 
            this.lbl_directeurdesventes_mesdonnees_adrMail.AutoSize = true;
            this.lbl_directeurdesventes_mesdonnees_adrMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_directeurdesventes_mesdonnees_adrMail.Location = new System.Drawing.Point(262, 174);
            this.lbl_directeurdesventes_mesdonnees_adrMail.Name = "lbl_directeurdesventes_mesdonnees_adrMail";
            this.lbl_directeurdesventes_mesdonnees_adrMail.Size = new System.Drawing.Size(300, 24);
            this.lbl_directeurdesventes_mesdonnees_adrMail.TabIndex = 50;
            this.lbl_directeurdesventes_mesdonnees_adrMail.Text = "Adresse mail : [Votre adresse mail]";
            // 
            // lbl_directeurdesventes_mesdonnees_nom
            // 
            this.lbl_directeurdesventes_mesdonnees_nom.AutoSize = true;
            this.lbl_directeurdesventes_mesdonnees_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_directeurdesventes_mesdonnees_nom.Location = new System.Drawing.Point(26, 174);
            this.lbl_directeurdesventes_mesdonnees_nom.Name = "lbl_directeurdesventes_mesdonnees_nom";
            this.lbl_directeurdesventes_mesdonnees_nom.Size = new System.Drawing.Size(164, 24);
            this.lbl_directeurdesventes_mesdonnees_nom.TabIndex = 49;
            this.lbl_directeurdesventes_mesdonnees_nom.Text = "Nom : [Votre nom]";
            // 
            // lbl_directeurdesventes_mesdonnees_prenom
            // 
            this.lbl_directeurdesventes_mesdonnees_prenom.AutoSize = true;
            this.lbl_directeurdesventes_mesdonnees_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_directeurdesventes_mesdonnees_prenom.Location = new System.Drawing.Point(262, 101);
            this.lbl_directeurdesventes_mesdonnees_prenom.Name = "lbl_directeurdesventes_mesdonnees_prenom";
            this.lbl_directeurdesventes_mesdonnees_prenom.Size = new System.Drawing.Size(218, 24);
            this.lbl_directeurdesventes_mesdonnees_prenom.TabIndex = 48;
            this.lbl_directeurdesventes_mesdonnees_prenom.Text = "Prénom : [Votre prénom]";
            // 
            // lbl_directeurdesventes_mesdonnees_login
            // 
            this.lbl_directeurdesventes_mesdonnees_login.AutoSize = true;
            this.lbl_directeurdesventes_mesdonnees_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_directeurdesventes_mesdonnees_login.Location = new System.Drawing.Point(26, 103);
            this.lbl_directeurdesventes_mesdonnees_login.Name = "lbl_directeurdesventes_mesdonnees_login";
            this.lbl_directeurdesventes_mesdonnees_login.Size = new System.Drawing.Size(173, 24);
            this.lbl_directeurdesventes_mesdonnees_login.TabIndex = 47;
            this.lbl_directeurdesventes_mesdonnees_login.Text = "Login : [Votre login]";
            // 
            // lbl_directeurdesventes_mesdonnees_title
            // 
            this.lbl_directeurdesventes_mesdonnees_title.AutoSize = true;
            this.lbl_directeurdesventes_mesdonnees_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_directeurdesventes_mesdonnees_title.Location = new System.Drawing.Point(197, 32);
            this.lbl_directeurdesventes_mesdonnees_title.Name = "lbl_directeurdesventes_mesdonnees_title";
            this.lbl_directeurdesventes_mesdonnees_title.Size = new System.Drawing.Size(338, 26);
            this.lbl_directeurdesventes_mesdonnees_title.TabIndex = 46;
            this.lbl_directeurdesventes_mesdonnees_title.Text = "GESTION DE VOS DONNEES";
            // 
            // AppCriee_DirecteurDesVentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 596);
            this.Controls.Add(this.lbl_directeurdesventes_datejour);
            this.Controls.Add(this.pbx_directeurdesventes_deconnexion);
            this.Controls.Add(this.tbc_directeurdesventes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(833, 642);
            this.MinimumSize = new System.Drawing.Size(833, 596);
            this.Name = "AppCriee_DirecteurDesVentes";
            this.Text = "AppCriée (Directeur des Ventes)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppCriee_DirecteurDesVentes_FormClosing);
            this.tbc_directeurdesventes.ResumeLayout(false);
            this.tbp_directeurdesventes_accueil.ResumeLayout(false);
            this.tbp_directeurdesventes_accueil.PerformLayout();
            this.tbp_directeurdesventes_lotsvente.ResumeLayout(false);
            this.tbp_directeurdesventes_lotsvente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_directeurdesventes_lotsvente_alllot)).EndInit();
            this.tbp_directeurdesventes_mesdonnees.ResumeLayout(false);
            this.tbp_directeurdesventes_mesdonnees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_directeurdesventes_deconnexion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_directeurdesventes;
        private System.Windows.Forms.TabPage tbp_directeurdesventes_accueil;
        private System.Windows.Forms.TabPage tbp_directeurdesventes_lotsvente;
        private System.Windows.Forms.Label lbl_directeurdesventes_accueil_bienvenue;
        private System.Windows.Forms.Label lbl_directeurdesventes_accueil_role;
        private System.Windows.Forms.PictureBox pbx_directeurdesventes_deconnexion;
        private System.Windows.Forms.Label lbl_directeurdesventes_datejour;
        private System.Windows.Forms.TabPage tbp_directeurdesventes_mesdonnees;
        private System.Windows.Forms.Label lbl_directeurdesventes_lotsvente_islots;
        private System.Windows.Forms.DataGridView dg_directeurdesventes_lotsvente_alllot;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomBateau;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbbac;
        private System.Windows.Forms.DataGridViewTextBoxColumn poidsTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeEtat;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddubateau;
        private System.Windows.Forms.Label lbl_directeurdesventes_lotsvente_title;
        private System.Windows.Forms.Button btn_peseur_mesdonnees_supprimer;
        private System.Windows.Forms.Label lbl_directeurdesventes_mesdonnees_typeuser;
        private System.Windows.Forms.Label lbl_directeurdesventes_mesdonnees_adrMail;
        private System.Windows.Forms.Label lbl_directeurdesventes_mesdonnees_nom;
        private System.Windows.Forms.Label lbl_directeurdesventes_mesdonnees_prenom;
        private System.Windows.Forms.Label lbl_directeurdesventes_mesdonnees_login;
        private System.Windows.Forms.Label lbl_directeurdesventes_mesdonnees_title;
    }
}