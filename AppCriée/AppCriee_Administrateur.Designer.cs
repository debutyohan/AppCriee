
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
            this.lbl_administrateur_accueil_role = new System.Windows.Forms.Label();
            this.lbl_administrateur_accueil_bienvenue = new System.Windows.Forms.Label();
            this.tbp_administrateur_gestioncomptes = new System.Windows.Forms.TabPage();
            this.lbl_administrateur_gestioncomptes_validationok = new System.Windows.Forms.Label();
            this.btn_administrateur_gestioncomptes_validermodif = new System.Windows.Forms.Button();
            this.lbl_administrateur_gestioncomptes_validationajoutok = new System.Windows.Forms.Label();
            this.lbl_administrateur_gestioncomptes_champsobli = new System.Windows.Forms.Label();
            this.lbl_administrateur_gestioncomptes_validationajouterror = new System.Windows.Forms.Label();
            this.btn_administrateur_gestioncomptes_validerajout = new System.Windows.Forms.Button();
            this.cbx_administrateur_gestioncomptes_typeuser = new System.Windows.Forms.ComboBox();
            this.tbx_administrateur_gestioncomptes_adrMail = new System.Windows.Forms.TextBox();
            this.tbx_administrateur_gestioncomptes_prenom = new System.Windows.Forms.TextBox();
            this.tbx_administrateur_gestioncomptes_nom = new System.Windows.Forms.TextBox();
            this.tbx_administrateur_gestioncomptes_motdepasse = new System.Windows.Forms.TextBox();
            this.tbx_administrateur_gestioncomptes_login = new System.Windows.Forms.TextBox();
            this.lbl_administrateur_gestioncomptes_typeuser = new System.Windows.Forms.Label();
            this.lbl_administrateur_gestioncomptes_adrMail = new System.Windows.Forms.Label();
            this.lbl_administrateur_gestioncomptes_prenom = new System.Windows.Forms.Label();
            this.lbl_administrateur_gestioncomptes_nom = new System.Windows.Forms.Label();
            this.lbl_administrateur_gestioncomptes_motdepasse = new System.Windows.Forms.Label();
            this.lbl_administrateur_gestioncomptes_login = new System.Windows.Forms.Label();
            this.lbl_administrateur_gestioncomptes_ajout = new System.Windows.Forms.Label();
            this.btn_administrateur_gestioncomptes_ajout = new System.Windows.Forms.Button();
            this.btn_administrateur_gestioncomptes_modifier = new System.Windows.Forms.Button();
            this.btn_administrateur_gestioncomptes_supprimer = new System.Windows.Forms.Button();
            this.lbl_administrateur_gestioncomptes_info = new System.Windows.Forms.Label();
            this.dg_administrateur_gestioncomptes_listecompte = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_administrateur_gestioncomptes_title = new System.Windows.Forms.Label();
            this.lbl_administrateur_gestioncomptes_modification = new System.Windows.Forms.Label();
            this.tbp_administrateur_mesdonnees = new System.Windows.Forms.TabPage();
            this.pbx_administrateur_deconnexion = new System.Windows.Forms.PictureBox();
            this.lbl_administrateur_datejour = new System.Windows.Forms.Label();
            this.tbc_administrateur.SuspendLayout();
            this.tbp_administrateur_accueil.SuspendLayout();
            this.tbp_administrateur_gestioncomptes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_administrateur_gestioncomptes_listecompte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_administrateur_deconnexion)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_administrateur
            // 
            this.tbc_administrateur.Controls.Add(this.tbp_administrateur_accueil);
            this.tbc_administrateur.Controls.Add(this.tbp_administrateur_gestioncomptes);
            this.tbc_administrateur.Controls.Add(this.tbp_administrateur_mesdonnees);
            this.tbc_administrateur.Location = new System.Drawing.Point(0, 0);
            this.tbc_administrateur.Margin = new System.Windows.Forms.Padding(2);
            this.tbc_administrateur.Name = "tbc_administrateur";
            this.tbc_administrateur.SelectedIndex = 0;
            this.tbc_administrateur.Size = new System.Drawing.Size(814, 552);
            this.tbc_administrateur.TabIndex = 0;
            this.tbc_administrateur.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbc_administrateur_Selected);
            // 
            // tbp_administrateur_accueil
            // 
            this.tbp_administrateur_accueil.Controls.Add(this.lbl_administrateur_accueil_role);
            this.tbp_administrateur_accueil.Controls.Add(this.lbl_administrateur_accueil_bienvenue);
            this.tbp_administrateur_accueil.Location = new System.Drawing.Point(4, 22);
            this.tbp_administrateur_accueil.Margin = new System.Windows.Forms.Padding(2);
            this.tbp_administrateur_accueil.Name = "tbp_administrateur_accueil";
            this.tbp_administrateur_accueil.Padding = new System.Windows.Forms.Padding(2);
            this.tbp_administrateur_accueil.Size = new System.Drawing.Size(806, 526);
            this.tbp_administrateur_accueil.TabIndex = 0;
            this.tbp_administrateur_accueil.Text = "Accueil";
            this.tbp_administrateur_accueil.UseVisualStyleBackColor = true;
            // 
            // lbl_administrateur_accueil_role
            // 
            this.lbl_administrateur_accueil_role.AutoSize = true;
            this.lbl_administrateur_accueil_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_administrateur_accueil_role.Location = new System.Drawing.Point(149, 197);
            this.lbl_administrateur_accueil_role.Name = "lbl_administrateur_accueil_role";
            this.lbl_administrateur_accueil_role.Size = new System.Drawing.Size(216, 26);
            this.lbl_administrateur_accueil_role.TabIndex = 20;
            this.lbl_administrateur_accueil_role.Text = "Rôle : Administrateur";
            // 
            // lbl_administrateur_accueil_bienvenue
            // 
            this.lbl_administrateur_accueil_bienvenue.AutoSize = true;
            this.lbl_administrateur_accueil_bienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_administrateur_accueil_bienvenue.Location = new System.Drawing.Point(149, 131);
            this.lbl_administrateur_accueil_bienvenue.Name = "lbl_administrateur_accueil_bienvenue";
            this.lbl_administrateur_accueil_bienvenue.Size = new System.Drawing.Size(383, 26);
            this.lbl_administrateur_accueil_bienvenue.TabIndex = 3;
            this.lbl_administrateur_accueil_bienvenue.Text = "Bienvenue [Nom_user] [Prenom_user]";
            // 
            // tbp_administrateur_gestioncomptes
            // 
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.lbl_administrateur_gestioncomptes_validationok);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.btn_administrateur_gestioncomptes_validermodif);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.lbl_administrateur_gestioncomptes_validationajoutok);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.lbl_administrateur_gestioncomptes_champsobli);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.lbl_administrateur_gestioncomptes_validationajouterror);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.btn_administrateur_gestioncomptes_validerajout);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.cbx_administrateur_gestioncomptes_typeuser);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.tbx_administrateur_gestioncomptes_adrMail);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.tbx_administrateur_gestioncomptes_prenom);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.tbx_administrateur_gestioncomptes_nom);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.tbx_administrateur_gestioncomptes_motdepasse);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.tbx_administrateur_gestioncomptes_login);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.lbl_administrateur_gestioncomptes_typeuser);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.lbl_administrateur_gestioncomptes_adrMail);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.lbl_administrateur_gestioncomptes_prenom);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.lbl_administrateur_gestioncomptes_nom);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.lbl_administrateur_gestioncomptes_motdepasse);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.lbl_administrateur_gestioncomptes_login);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.lbl_administrateur_gestioncomptes_ajout);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.btn_administrateur_gestioncomptes_ajout);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.btn_administrateur_gestioncomptes_modifier);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.btn_administrateur_gestioncomptes_supprimer);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.lbl_administrateur_gestioncomptes_info);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.dg_administrateur_gestioncomptes_listecompte);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.lbl_administrateur_gestioncomptes_title);
            this.tbp_administrateur_gestioncomptes.Controls.Add(this.lbl_administrateur_gestioncomptes_modification);
            this.tbp_administrateur_gestioncomptes.Location = new System.Drawing.Point(4, 22);
            this.tbp_administrateur_gestioncomptes.Margin = new System.Windows.Forms.Padding(2);
            this.tbp_administrateur_gestioncomptes.Name = "tbp_administrateur_gestioncomptes";
            this.tbp_administrateur_gestioncomptes.Padding = new System.Windows.Forms.Padding(2);
            this.tbp_administrateur_gestioncomptes.Size = new System.Drawing.Size(806, 526);
            this.tbp_administrateur_gestioncomptes.TabIndex = 1;
            this.tbp_administrateur_gestioncomptes.Text = "Gestion des comptes";
            this.tbp_administrateur_gestioncomptes.UseVisualStyleBackColor = true;
            // 
            // lbl_administrateur_gestioncomptes_validationok
            // 
            this.lbl_administrateur_gestioncomptes_validationok.AutoSize = true;
            this.lbl_administrateur_gestioncomptes_validationok.BackColor = System.Drawing.Color.White;
            this.lbl_administrateur_gestioncomptes_validationok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_administrateur_gestioncomptes_validationok.ForeColor = System.Drawing.Color.Red;
            this.lbl_administrateur_gestioncomptes_validationok.Location = new System.Drawing.Point(82, 423);
            this.lbl_administrateur_gestioncomptes_validationok.Name = "lbl_administrateur_gestioncomptes_validationok";
            this.lbl_administrateur_gestioncomptes_validationok.Size = new System.Drawing.Size(46, 18);
            this.lbl_administrateur_gestioncomptes_validationok.TabIndex = 41;
            this.lbl_administrateur_gestioncomptes_validationok.Text = "label1";
            this.lbl_administrateur_gestioncomptes_validationok.Visible = false;
            // 
            // btn_administrateur_gestioncomptes_validermodif
            // 
            this.btn_administrateur_gestioncomptes_validermodif.BackColor = System.Drawing.SystemColors.Info;
            this.btn_administrateur_gestioncomptes_validermodif.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_administrateur_gestioncomptes_validermodif.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_administrateur_gestioncomptes_validermodif.Location = new System.Drawing.Point(538, 422);
            this.btn_administrateur_gestioncomptes_validermodif.Margin = new System.Windows.Forms.Padding(2);
            this.btn_administrateur_gestioncomptes_validermodif.Name = "btn_administrateur_gestioncomptes_validermodif";
            this.btn_administrateur_gestioncomptes_validermodif.Size = new System.Drawing.Size(99, 27);
            this.btn_administrateur_gestioncomptes_validermodif.TabIndex = 40;
            this.btn_administrateur_gestioncomptes_validermodif.Text = "Valider";
            this.btn_administrateur_gestioncomptes_validermodif.UseVisualStyleBackColor = false;
            this.btn_administrateur_gestioncomptes_validermodif.Visible = false;
            this.btn_administrateur_gestioncomptes_validermodif.Click += new System.EventHandler(this.btn_administrateur_gestioncomptes_validermodif_Click);
            // 
            // lbl_administrateur_gestioncomptes_validationajoutok
            // 
            this.lbl_administrateur_gestioncomptes_validationajoutok.AutoSize = true;
            this.lbl_administrateur_gestioncomptes_validationajoutok.BackColor = System.Drawing.Color.White;
            this.lbl_administrateur_gestioncomptes_validationajoutok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_administrateur_gestioncomptes_validationajoutok.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_administrateur_gestioncomptes_validationajoutok.Location = new System.Drawing.Point(77, 314);
            this.lbl_administrateur_gestioncomptes_validationajoutok.Name = "lbl_administrateur_gestioncomptes_validationajoutok";
            this.lbl_administrateur_gestioncomptes_validationajoutok.Size = new System.Drawing.Size(198, 20);
            this.lbl_administrateur_gestioncomptes_validationajoutok.TabIndex = 38;
            this.lbl_administrateur_gestioncomptes_validationajoutok.Text = "L\'utilisateur a bien été crée";
            this.lbl_administrateur_gestioncomptes_validationajoutok.Visible = false;
            // 
            // lbl_administrateur_gestioncomptes_champsobli
            // 
            this.lbl_administrateur_gestioncomptes_champsobli.AutoSize = true;
            this.lbl_administrateur_gestioncomptes_champsobli.Location = new System.Drawing.Point(678, 429);
            this.lbl_administrateur_gestioncomptes_champsobli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_administrateur_gestioncomptes_champsobli.Name = "lbl_administrateur_gestioncomptes_champsobli";
            this.lbl_administrateur_gestioncomptes_champsobli.Size = new System.Drawing.Size(108, 13);
            this.lbl_administrateur_gestioncomptes_champsobli.TabIndex = 37;
            this.lbl_administrateur_gestioncomptes_champsobli.Text = "* Champs obligatoires";
            this.lbl_administrateur_gestioncomptes_champsobli.Visible = false;
            // 
            // lbl_administrateur_gestioncomptes_validationajouterror
            // 
            this.lbl_administrateur_gestioncomptes_validationajouterror.AutoSize = true;
            this.lbl_administrateur_gestioncomptes_validationajouterror.BackColor = System.Drawing.Color.White;
            this.lbl_administrateur_gestioncomptes_validationajouterror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_administrateur_gestioncomptes_validationajouterror.ForeColor = System.Drawing.Color.Red;
            this.lbl_administrateur_gestioncomptes_validationajouterror.Location = new System.Drawing.Point(25, 423);
            this.lbl_administrateur_gestioncomptes_validationajouterror.Name = "lbl_administrateur_gestioncomptes_validationajouterror";
            this.lbl_administrateur_gestioncomptes_validationajouterror.Size = new System.Drawing.Size(51, 20);
            this.lbl_administrateur_gestioncomptes_validationajouterror.TabIndex = 36;
            this.lbl_administrateur_gestioncomptes_validationajouterror.Text = "label1";
            this.lbl_administrateur_gestioncomptes_validationajouterror.Visible = false;
            // 
            // btn_administrateur_gestioncomptes_validerajout
            // 
            this.btn_administrateur_gestioncomptes_validerajout.BackColor = System.Drawing.SystemColors.Info;
            this.btn_administrateur_gestioncomptes_validerajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_administrateur_gestioncomptes_validerajout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_administrateur_gestioncomptes_validerajout.Location = new System.Drawing.Point(544, 422);
            this.btn_administrateur_gestioncomptes_validerajout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_administrateur_gestioncomptes_validerajout.Name = "btn_administrateur_gestioncomptes_validerajout";
            this.btn_administrateur_gestioncomptes_validerajout.Size = new System.Drawing.Size(99, 27);
            this.btn_administrateur_gestioncomptes_validerajout.TabIndex = 35;
            this.btn_administrateur_gestioncomptes_validerajout.Text = "Valider";
            this.btn_administrateur_gestioncomptes_validerajout.UseVisualStyleBackColor = false;
            this.btn_administrateur_gestioncomptes_validerajout.Visible = false;
            this.btn_administrateur_gestioncomptes_validerajout.Click += new System.EventHandler(this.btn_administrateur_gestioncomptes_validerajout_Click);
            // 
            // cbx_administrateur_gestioncomptes_typeuser
            // 
            this.cbx_administrateur_gestioncomptes_typeuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_administrateur_gestioncomptes_typeuser.FormattingEnabled = true;
            this.cbx_administrateur_gestioncomptes_typeuser.Location = new System.Drawing.Point(659, 380);
            this.cbx_administrateur_gestioncomptes_typeuser.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_administrateur_gestioncomptes_typeuser.Name = "cbx_administrateur_gestioncomptes_typeuser";
            this.cbx_administrateur_gestioncomptes_typeuser.Size = new System.Drawing.Size(128, 21);
            this.cbx_administrateur_gestioncomptes_typeuser.TabIndex = 33;
            this.cbx_administrateur_gestioncomptes_typeuser.Visible = false;
            // 
            // tbx_administrateur_gestioncomptes_adrMail
            // 
            this.tbx_administrateur_gestioncomptes_adrMail.Location = new System.Drawing.Point(637, 341);
            this.tbx_administrateur_gestioncomptes_adrMail.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_administrateur_gestioncomptes_adrMail.Name = "tbx_administrateur_gestioncomptes_adrMail";
            this.tbx_administrateur_gestioncomptes_adrMail.Size = new System.Drawing.Size(159, 20);
            this.tbx_administrateur_gestioncomptes_adrMail.TabIndex = 32;
            this.tbx_administrateur_gestioncomptes_adrMail.Visible = false;
            // 
            // tbx_administrateur_gestioncomptes_prenom
            // 
            this.tbx_administrateur_gestioncomptes_prenom.Location = new System.Drawing.Point(406, 380);
            this.tbx_administrateur_gestioncomptes_prenom.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_administrateur_gestioncomptes_prenom.Name = "tbx_administrateur_gestioncomptes_prenom";
            this.tbx_administrateur_gestioncomptes_prenom.Size = new System.Drawing.Size(114, 20);
            this.tbx_administrateur_gestioncomptes_prenom.TabIndex = 31;
            // 
            // tbx_administrateur_gestioncomptes_nom
            // 
            this.tbx_administrateur_gestioncomptes_nom.Location = new System.Drawing.Point(406, 340);
            this.tbx_administrateur_gestioncomptes_nom.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_administrateur_gestioncomptes_nom.Name = "tbx_administrateur_gestioncomptes_nom";
            this.tbx_administrateur_gestioncomptes_nom.Size = new System.Drawing.Size(114, 20);
            this.tbx_administrateur_gestioncomptes_nom.TabIndex = 30;
            this.tbx_administrateur_gestioncomptes_nom.WordWrap = false;
            // 
            // tbx_administrateur_gestioncomptes_motdepasse
            // 
            this.tbx_administrateur_gestioncomptes_motdepasse.Location = new System.Drawing.Point(210, 380);
            this.tbx_administrateur_gestioncomptes_motdepasse.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_administrateur_gestioncomptes_motdepasse.Name = "tbx_administrateur_gestioncomptes_motdepasse";
            this.tbx_administrateur_gestioncomptes_motdepasse.Size = new System.Drawing.Size(111, 20);
            this.tbx_administrateur_gestioncomptes_motdepasse.TabIndex = 29;
            this.tbx_administrateur_gestioncomptes_motdepasse.Visible = false;
            // 
            // tbx_administrateur_gestioncomptes_login
            // 
            this.tbx_administrateur_gestioncomptes_login.Location = new System.Drawing.Point(134, 341);
            this.tbx_administrateur_gestioncomptes_login.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_administrateur_gestioncomptes_login.Name = "tbx_administrateur_gestioncomptes_login";
            this.tbx_administrateur_gestioncomptes_login.Size = new System.Drawing.Size(126, 20);
            this.tbx_administrateur_gestioncomptes_login.TabIndex = 28;
            this.tbx_administrateur_gestioncomptes_login.Visible = false;
            // 
            // lbl_administrateur_gestioncomptes_typeuser
            // 
            this.lbl_administrateur_gestioncomptes_typeuser.AutoSize = true;
            this.lbl_administrateur_gestioncomptes_typeuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_administrateur_gestioncomptes_typeuser.Location = new System.Drawing.Point(536, 382);
            this.lbl_administrateur_gestioncomptes_typeuser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_administrateur_gestioncomptes_typeuser.Name = "lbl_administrateur_gestioncomptes_typeuser";
            this.lbl_administrateur_gestioncomptes_typeuser.Size = new System.Drawing.Size(122, 17);
            this.lbl_administrateur_gestioncomptes_typeuser.TabIndex = 27;
            this.lbl_administrateur_gestioncomptes_typeuser.Text = "Type utilisateur * :";
            this.lbl_administrateur_gestioncomptes_typeuser.Visible = false;
            // 
            // lbl_administrateur_gestioncomptes_adrMail
            // 
            this.lbl_administrateur_gestioncomptes_adrMail.AutoSize = true;
            this.lbl_administrateur_gestioncomptes_adrMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_administrateur_gestioncomptes_adrMail.Location = new System.Drawing.Point(536, 341);
            this.lbl_administrateur_gestioncomptes_adrMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_administrateur_gestioncomptes_adrMail.Name = "lbl_administrateur_gestioncomptes_adrMail";
            this.lbl_administrateur_gestioncomptes_adrMail.Size = new System.Drawing.Size(97, 17);
            this.lbl_administrateur_gestioncomptes_adrMail.TabIndex = 26;
            this.lbl_administrateur_gestioncomptes_adrMail.Text = "Adresse mail :";
            this.lbl_administrateur_gestioncomptes_adrMail.Visible = false;
            // 
            // lbl_administrateur_gestioncomptes_prenom
            // 
            this.lbl_administrateur_gestioncomptes_prenom.AutoSize = true;
            this.lbl_administrateur_gestioncomptes_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_administrateur_gestioncomptes_prenom.Location = new System.Drawing.Point(336, 382);
            this.lbl_administrateur_gestioncomptes_prenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_administrateur_gestioncomptes_prenom.Name = "lbl_administrateur_gestioncomptes_prenom";
            this.lbl_administrateur_gestioncomptes_prenom.Size = new System.Drawing.Size(65, 17);
            this.lbl_administrateur_gestioncomptes_prenom.TabIndex = 25;
            this.lbl_administrateur_gestioncomptes_prenom.Text = "Prénom :";
            this.lbl_administrateur_gestioncomptes_prenom.Visible = false;
            // 
            // lbl_administrateur_gestioncomptes_nom
            // 
            this.lbl_administrateur_gestioncomptes_nom.AutoSize = true;
            this.lbl_administrateur_gestioncomptes_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_administrateur_gestioncomptes_nom.Location = new System.Drawing.Point(336, 341);
            this.lbl_administrateur_gestioncomptes_nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_administrateur_gestioncomptes_nom.Name = "lbl_administrateur_gestioncomptes_nom";
            this.lbl_administrateur_gestioncomptes_nom.Size = new System.Drawing.Size(45, 17);
            this.lbl_administrateur_gestioncomptes_nom.TabIndex = 24;
            this.lbl_administrateur_gestioncomptes_nom.Text = "Nom :";
            this.lbl_administrateur_gestioncomptes_nom.Visible = false;
            // 
            // lbl_administrateur_gestioncomptes_motdepasse
            // 
            this.lbl_administrateur_gestioncomptes_motdepasse.AutoSize = true;
            this.lbl_administrateur_gestioncomptes_motdepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_administrateur_gestioncomptes_motdepasse.Location = new System.Drawing.Point(26, 382);
            this.lbl_administrateur_gestioncomptes_motdepasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_administrateur_gestioncomptes_motdepasse.Name = "lbl_administrateur_gestioncomptes_motdepasse";
            this.lbl_administrateur_gestioncomptes_motdepasse.Size = new System.Drawing.Size(182, 17);
            this.lbl_administrateur_gestioncomptes_motdepasse.TabIndex = 23;
            this.lbl_administrateur_gestioncomptes_motdepasse.Text = "Mot de passe (provisoire)* :";
            this.lbl_administrateur_gestioncomptes_motdepasse.Visible = false;
            // 
            // lbl_administrateur_gestioncomptes_login
            // 
            this.lbl_administrateur_gestioncomptes_login.AutoSize = true;
            this.lbl_administrateur_gestioncomptes_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_administrateur_gestioncomptes_login.Location = new System.Drawing.Point(26, 341);
            this.lbl_administrateur_gestioncomptes_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_administrateur_gestioncomptes_login.Name = "lbl_administrateur_gestioncomptes_login";
            this.lbl_administrateur_gestioncomptes_login.Size = new System.Drawing.Size(60, 17);
            this.lbl_administrateur_gestioncomptes_login.TabIndex = 22;
            this.lbl_administrateur_gestioncomptes_login.Text = "Login * :";
            this.lbl_administrateur_gestioncomptes_login.Visible = false;
            // 
            // lbl_administrateur_gestioncomptes_ajout
            // 
            this.lbl_administrateur_gestioncomptes_ajout.AutoSize = true;
            this.lbl_administrateur_gestioncomptes_ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_administrateur_gestioncomptes_ajout.Location = new System.Drawing.Point(25, 291);
            this.lbl_administrateur_gestioncomptes_ajout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_administrateur_gestioncomptes_ajout.Name = "lbl_administrateur_gestioncomptes_ajout";
            this.lbl_administrateur_gestioncomptes_ajout.Size = new System.Drawing.Size(252, 24);
            this.lbl_administrateur_gestioncomptes_ajout.TabIndex = 19;
            this.lbl_administrateur_gestioncomptes_ajout.Text = "Ajout d\'un nouveau compte :";
            this.lbl_administrateur_gestioncomptes_ajout.Visible = false;
            // 
            // btn_administrateur_gestioncomptes_ajout
            // 
            this.btn_administrateur_gestioncomptes_ajout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_administrateur_gestioncomptes_ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_administrateur_gestioncomptes_ajout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_administrateur_gestioncomptes_ajout.Location = new System.Drawing.Point(591, 230);
            this.btn_administrateur_gestioncomptes_ajout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_administrateur_gestioncomptes_ajout.Name = "btn_administrateur_gestioncomptes_ajout";
            this.btn_administrateur_gestioncomptes_ajout.Size = new System.Drawing.Size(204, 34);
            this.btn_administrateur_gestioncomptes_ajout.TabIndex = 18;
            this.btn_administrateur_gestioncomptes_ajout.Text = "Ajouter un nouveau compte";
            this.btn_administrateur_gestioncomptes_ajout.UseVisualStyleBackColor = false;
            this.btn_administrateur_gestioncomptes_ajout.Click += new System.EventHandler(this.btn_administrateur_gestioncomptes_ajout_Click);
            // 
            // btn_administrateur_gestioncomptes_modifier
            // 
            this.btn_administrateur_gestioncomptes_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_administrateur_gestioncomptes_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_administrateur_gestioncomptes_modifier.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_administrateur_gestioncomptes_modifier.Location = new System.Drawing.Point(591, 159);
            this.btn_administrateur_gestioncomptes_modifier.Margin = new System.Windows.Forms.Padding(2);
            this.btn_administrateur_gestioncomptes_modifier.Name = "btn_administrateur_gestioncomptes_modifier";
            this.btn_administrateur_gestioncomptes_modifier.Size = new System.Drawing.Size(204, 38);
            this.btn_administrateur_gestioncomptes_modifier.TabIndex = 17;
            this.btn_administrateur_gestioncomptes_modifier.Text = "Modifier un compte";
            this.btn_administrateur_gestioncomptes_modifier.UseVisualStyleBackColor = false;
            this.btn_administrateur_gestioncomptes_modifier.Click += new System.EventHandler(this.btn_administrateur_gestioncomptes_modifier_Click);
            // 
            // btn_administrateur_gestioncomptes_supprimer
            // 
            this.btn_administrateur_gestioncomptes_supprimer.BackColor = System.Drawing.Color.Red;
            this.btn_administrateur_gestioncomptes_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_administrateur_gestioncomptes_supprimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_administrateur_gestioncomptes_supprimer.Location = new System.Drawing.Point(591, 93);
            this.btn_administrateur_gestioncomptes_supprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_administrateur_gestioncomptes_supprimer.Name = "btn_administrateur_gestioncomptes_supprimer";
            this.btn_administrateur_gestioncomptes_supprimer.Size = new System.Drawing.Size(204, 38);
            this.btn_administrateur_gestioncomptes_supprimer.TabIndex = 16;
            this.btn_administrateur_gestioncomptes_supprimer.Text = "Supprimer un compte";
            this.btn_administrateur_gestioncomptes_supprimer.UseVisualStyleBackColor = false;
            this.btn_administrateur_gestioncomptes_supprimer.Click += new System.EventHandler(this.btn_administrateur_gestioncomptes_supprimer_Click);
            // 
            // lbl_administrateur_gestioncomptes_info
            // 
            this.lbl_administrateur_gestioncomptes_info.AutoSize = true;
            this.lbl_administrateur_gestioncomptes_info.Location = new System.Drawing.Point(36, 484);
            this.lbl_administrateur_gestioncomptes_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_administrateur_gestioncomptes_info.Name = "lbl_administrateur_gestioncomptes_info";
            this.lbl_administrateur_gestioncomptes_info.Size = new System.Drawing.Size(304, 26);
            this.lbl_administrateur_gestioncomptes_info.TabIndex = 14;
            this.lbl_administrateur_gestioncomptes_info.Text = "La ligne grisée correspond à l’utilisateur connecté.\nVous ne pouvez modifier/supp" +
    "rimer qu\'un seul compte à la fois.";
            // 
            // dg_administrateur_gestioncomptes_listecompte
            // 
            this.dg_administrateur_gestioncomptes_listecompte.AllowUserToAddRows = false;
            this.dg_administrateur_gestioncomptes_listecompte.AllowUserToDeleteRows = false;
            this.dg_administrateur_gestioncomptes_listecompte.AllowUserToResizeRows = false;
            this.dg_administrateur_gestioncomptes_listecompte.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_administrateur_gestioncomptes_listecompte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_administrateur_gestioncomptes_listecompte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_administrateur_gestioncomptes_listecompte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.login,
            this.nom,
            this.prenom,
            this.adrmail,
            this.typeuser});
            this.dg_administrateur_gestioncomptes_listecompte.GridColor = System.Drawing.SystemColors.Control;
            this.dg_administrateur_gestioncomptes_listecompte.Location = new System.Drawing.Point(22, 76);
            this.dg_administrateur_gestioncomptes_listecompte.Margin = new System.Windows.Forms.Padding(2);
            this.dg_administrateur_gestioncomptes_listecompte.MultiSelect = false;
            this.dg_administrateur_gestioncomptes_listecompte.Name = "dg_administrateur_gestioncomptes_listecompte";
            this.dg_administrateur_gestioncomptes_listecompte.ReadOnly = true;
            this.dg_administrateur_gestioncomptes_listecompte.RowHeadersWidth = 10;
            this.dg_administrateur_gestioncomptes_listecompte.RowTemplate.Height = 24;
            this.dg_administrateur_gestioncomptes_listecompte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_administrateur_gestioncomptes_listecompte.Size = new System.Drawing.Size(542, 199);
            this.dg_administrateur_gestioncomptes_listecompte.TabIndex = 13;
            this.dg_administrateur_gestioncomptes_listecompte.Visible = false;
            this.dg_administrateur_gestioncomptes_listecompte.VisibleChanged += new System.EventHandler(this.dg_administrateur_gestioncomptes_listecompte_VisibleChanged);
            // 
            // id
            // 
            this.id.HeaderText = "Identifiant";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // login
            // 
            this.login.HeaderText = "Login";
            this.login.MinimumWidth = 6;
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Width = 80;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Width = 80;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.MinimumWidth = 6;
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            this.prenom.Width = 80;
            // 
            // adrmail
            // 
            this.adrmail.HeaderText = "Adresse mail";
            this.adrmail.MinimumWidth = 6;
            this.adrmail.Name = "adrmail";
            this.adrmail.ReadOnly = true;
            this.adrmail.Width = 110;
            // 
            // typeuser
            // 
            this.typeuser.HeaderText = "Type utilisateur";
            this.typeuser.MinimumWidth = 6;
            this.typeuser.Name = "typeuser";
            this.typeuser.ReadOnly = true;
            this.typeuser.Width = 120;
            // 
            // lbl_administrateur_gestioncomptes_title
            // 
            this.lbl_administrateur_gestioncomptes_title.AutoSize = true;
            this.lbl_administrateur_gestioncomptes_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_administrateur_gestioncomptes_title.Location = new System.Drawing.Point(260, 32);
            this.lbl_administrateur_gestioncomptes_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_administrateur_gestioncomptes_title.Name = "lbl_administrateur_gestioncomptes_title";
            this.lbl_administrateur_gestioncomptes_title.Size = new System.Drawing.Size(295, 26);
            this.lbl_administrateur_gestioncomptes_title.TabIndex = 8;
            this.lbl_administrateur_gestioncomptes_title.Text = "GESTION DES COMPTES";
            // 
            // lbl_administrateur_gestioncomptes_modification
            // 
            this.lbl_administrateur_gestioncomptes_modification.AutoSize = true;
            this.lbl_administrateur_gestioncomptes_modification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_administrateur_gestioncomptes_modification.Location = new System.Drawing.Point(25, 291);
            this.lbl_administrateur_gestioncomptes_modification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_administrateur_gestioncomptes_modification.Name = "lbl_administrateur_gestioncomptes_modification";
            this.lbl_administrateur_gestioncomptes_modification.Size = new System.Drawing.Size(298, 24);
            this.lbl_administrateur_gestioncomptes_modification.TabIndex = 39;
            this.lbl_administrateur_gestioncomptes_modification.Text = "Modification d\'un compte existant :";
            this.lbl_administrateur_gestioncomptes_modification.Visible = false;
            // 
            // tbp_administrateur_mesdonnees
            // 
            this.tbp_administrateur_mesdonnees.Location = new System.Drawing.Point(4, 22);
            this.tbp_administrateur_mesdonnees.Margin = new System.Windows.Forms.Padding(2);
            this.tbp_administrateur_mesdonnees.Name = "tbp_administrateur_mesdonnees";
            this.tbp_administrateur_mesdonnees.Padding = new System.Windows.Forms.Padding(2);
            this.tbp_administrateur_mesdonnees.Size = new System.Drawing.Size(806, 526);
            this.tbp_administrateur_mesdonnees.TabIndex = 2;
            this.tbp_administrateur_mesdonnees.Text = "Mes données";
            this.tbp_administrateur_mesdonnees.UseVisualStyleBackColor = true;
            // 
            // pbx_administrateur_deconnexion
            // 
            this.pbx_administrateur_deconnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_administrateur_deconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_administrateur_deconnexion.Image = global::AppCriée.Properties.Resources.computer_icons_login_icon_design_exit_5abfc840bf8ca4_9038982415225180807846;
            this.pbx_administrateur_deconnexion.Location = new System.Drawing.Point(764, 557);
            this.pbx_administrateur_deconnexion.Margin = new System.Windows.Forms.Padding(2);
            this.pbx_administrateur_deconnexion.Name = "pbx_administrateur_deconnexion";
            this.pbx_administrateur_deconnexion.Size = new System.Drawing.Size(34, 37);
            this.pbx_administrateur_deconnexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_administrateur_deconnexion.TabIndex = 21;
            this.pbx_administrateur_deconnexion.TabStop = false;
            this.pbx_administrateur_deconnexion.Click += new System.EventHandler(this.pbx_administrateur_deconnexion_Click);
            // 
            // lbl_administrateur_datejour
            // 
            this.lbl_administrateur_datejour.AutoSize = true;
            this.lbl_administrateur_datejour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_administrateur_datejour.Location = new System.Drawing.Point(578, 563);
            this.lbl_administrateur_datejour.Name = "lbl_administrateur_datejour";
            this.lbl_administrateur_datejour.Size = new System.Drawing.Size(172, 18);
            this.lbl_administrateur_datejour.TabIndex = 21;
            this.lbl_administrateur_datejour.Text = "Date du jour : 23/10/2021";
            // 
            // AppCriee_Administrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 598);
            this.Controls.Add(this.lbl_administrateur_datejour);
            this.Controls.Add(this.pbx_administrateur_deconnexion);
            this.Controls.Add(this.tbc_administrateur);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(833, 643);
            this.MinimumSize = new System.Drawing.Size(833, 597);
            this.Name = "AppCriee_Administrateur";
            this.Text = "AppCriée (Administrateur)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppCriee_Administrateur_FormClosing);
            this.tbc_administrateur.ResumeLayout(false);
            this.tbp_administrateur_accueil.ResumeLayout(false);
            this.tbp_administrateur_accueil.PerformLayout();
            this.tbp_administrateur_gestioncomptes.ResumeLayout(false);
            this.tbp_administrateur_gestioncomptes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_administrateur_gestioncomptes_listecompte)).EndInit();
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
        private System.Windows.Forms.Label lbl_administrateur_gestioncomptes_title;
        private System.Windows.Forms.Label lbl_administrateur_gestioncomptes_info;
        private System.Windows.Forms.DataGridView dg_administrateur_gestioncomptes_listecompte;
        private System.Windows.Forms.Button btn_administrateur_gestioncomptes_supprimer;
        private System.Windows.Forms.Button btn_administrateur_gestioncomptes_modifier;
        private System.Windows.Forms.Button btn_administrateur_gestioncomptes_ajout;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeuser;
        private System.Windows.Forms.Label lbl_administrateur_gestioncomptes_ajout;
        private System.Windows.Forms.TextBox tbx_administrateur_gestioncomptes_adrMail;
        private System.Windows.Forms.TextBox tbx_administrateur_gestioncomptes_prenom;
        private System.Windows.Forms.TextBox tbx_administrateur_gestioncomptes_nom;
        private System.Windows.Forms.TextBox tbx_administrateur_gestioncomptes_motdepasse;
        private System.Windows.Forms.TextBox tbx_administrateur_gestioncomptes_login;
        private System.Windows.Forms.Label lbl_administrateur_gestioncomptes_typeuser;
        private System.Windows.Forms.Label lbl_administrateur_gestioncomptes_adrMail;
        private System.Windows.Forms.Label lbl_administrateur_gestioncomptes_prenom;
        private System.Windows.Forms.Label lbl_administrateur_gestioncomptes_nom;
        private System.Windows.Forms.Label lbl_administrateur_gestioncomptes_motdepasse;
        private System.Windows.Forms.Label lbl_administrateur_gestioncomptes_login;
        private System.Windows.Forms.ComboBox cbx_administrateur_gestioncomptes_typeuser;
        private System.Windows.Forms.Button btn_administrateur_gestioncomptes_validerajout;
        private System.Windows.Forms.Label lbl_administrateur_gestioncomptes_validationajouterror;
        private System.Windows.Forms.Label lbl_administrateur_gestioncomptes_champsobli;
        private System.Windows.Forms.Label lbl_administrateur_gestioncomptes_validationajoutok;
        private System.Windows.Forms.TabPage tbp_administrateur_mesdonnees;
        private System.Windows.Forms.Label lbl_administrateur_gestioncomptes_modification;
        private System.Windows.Forms.Button btn_administrateur_gestioncomptes_validermodif;
        private System.Windows.Forms.Label lbl_administrateur_gestioncomptes_validationok;
    }
}