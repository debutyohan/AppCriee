
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppCriee_Veterinaire));
            this.tbc_veterinaire = new System.Windows.Forms.TabControl();
            this.tbp_veterinaire_accueil = new System.Windows.Forms.TabPage();
            this.lbl_veterinaire_accueil_role = new System.Windows.Forms.Label();
            this.lbl_veterinaire_accueil_bienvenue = new System.Windows.Forms.Label();
            this.tbp_veterinaire_bacpoisson = new System.Windows.Forms.TabPage();
            this.cbx_veterinaire_bacpoissons_typebac = new System.Windows.Forms.ComboBox();
            this.cbx_veterinaire_bacpoissons_presentation = new System.Windows.Forms.ComboBox();
            this.cbx_veterinaire_bacpoissons_qualite = new System.Windows.Forms.ComboBox();
            this.cbx_veterinaire_bacpoissons_taille = new System.Windows.Forms.ComboBox();
            this.cbx_veterinaire_bacpoissons_espece = new System.Windows.Forms.ComboBox();
            this.btn_veterinaire_bacpoissons_valider = new System.Windows.Forms.Button();
            this.lbl_veterinaire_bacpoissons_typebac = new System.Windows.Forms.Label();
            this.lbl_veterinaire_bacpoissons_presentation = new System.Windows.Forms.Label();
            this.lbl_veterinaire_bacpoissons_qualite = new System.Windows.Forms.Label();
            this.lbl_veterinaire_bacpoissons_taille = new System.Windows.Forms.Label();
            this.lbl_veterinaire_bacpoissons_espece = new System.Windows.Forms.Label();
            this.lbl_veterinaire_bacpoissons_creationbac = new System.Windows.Forms.Label();
            this.lbl_veterinaire_bacpoissons_isbac = new System.Windows.Forms.Label();
            this.btn_veterinaire_bacpoissons_creerlots = new System.Windows.Forms.Button();
            this.lbl_veterinaire_bacpoissons_info = new System.Windows.Forms.Label();
            this.btn_veterinaire_bacpoissons_modifierbacs = new System.Windows.Forms.Button();
            this.btn_veterinaire_bacpoissons_supprimerbacs = new System.Windows.Forms.Button();
            this.btn_veterinaire_bacpoissons_creerbacs = new System.Windows.Forms.Button();
            this.dg_veterinaire_bacpoissons_listebac = new System.Windows.Forms.DataGridView();
            this.numBac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typebac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_veterinaire_bacpoissons_listebateaux = new System.Windows.Forms.ComboBox();
            this.lbl_veterinaire_bacpoissons_choixbateau = new System.Windows.Forms.Label();
            this.lbl_veterinaire_bacpoissons_ispeche = new System.Windows.Forms.Label();
            this.lbl_veterinaire_bacpoissons_datejour = new System.Windows.Forms.Label();
            this.lbl_veterinaire_bacpoissons_title = new System.Windows.Forms.Label();
            this.tbp_veterinaire_lotspeche = new System.Windows.Forms.TabPage();
            this.tbc_veterinaire.SuspendLayout();
            this.tbp_veterinaire_accueil.SuspendLayout();
            this.tbp_veterinaire_bacpoisson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_veterinaire_bacpoissons_listebac)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_veterinaire
            // 
            this.tbc_veterinaire.Controls.Add(this.tbp_veterinaire_accueil);
            this.tbc_veterinaire.Controls.Add(this.tbp_veterinaire_bacpoisson);
            this.tbc_veterinaire.Controls.Add(this.tbp_veterinaire_lotspeche);
            this.tbc_veterinaire.Location = new System.Drawing.Point(0, 0);
            this.tbc_veterinaire.Name = "tbc_veterinaire";
            this.tbc_veterinaire.SelectedIndex = 0;
            this.tbc_veterinaire.Size = new System.Drawing.Size(1063, 593);
            this.tbc_veterinaire.TabIndex = 0;
            this.tbc_veterinaire.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbc_veterinaire_Selected);
            // 
            // tbp_veterinaire_accueil
            // 
            this.tbp_veterinaire_accueil.Controls.Add(this.lbl_veterinaire_accueil_role);
            this.tbp_veterinaire_accueil.Controls.Add(this.lbl_veterinaire_accueil_bienvenue);
            this.tbp_veterinaire_accueil.Location = new System.Drawing.Point(4, 25);
            this.tbp_veterinaire_accueil.Name = "tbp_veterinaire_accueil";
            this.tbp_veterinaire_accueil.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_veterinaire_accueil.Size = new System.Drawing.Size(1055, 564);
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
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.cbx_veterinaire_bacpoissons_typebac);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.cbx_veterinaire_bacpoissons_presentation);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.cbx_veterinaire_bacpoissons_qualite);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.cbx_veterinaire_bacpoissons_taille);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.cbx_veterinaire_bacpoissons_espece);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.btn_veterinaire_bacpoissons_valider);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.lbl_veterinaire_bacpoissons_typebac);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.lbl_veterinaire_bacpoissons_presentation);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.lbl_veterinaire_bacpoissons_qualite);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.lbl_veterinaire_bacpoissons_taille);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.lbl_veterinaire_bacpoissons_espece);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.lbl_veterinaire_bacpoissons_creationbac);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.lbl_veterinaire_bacpoissons_isbac);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.btn_veterinaire_bacpoissons_creerlots);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.lbl_veterinaire_bacpoissons_info);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.btn_veterinaire_bacpoissons_modifierbacs);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.btn_veterinaire_bacpoissons_supprimerbacs);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.btn_veterinaire_bacpoissons_creerbacs);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.dg_veterinaire_bacpoissons_listebac);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.cbx_veterinaire_bacpoissons_listebateaux);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.lbl_veterinaire_bacpoissons_choixbateau);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.lbl_veterinaire_bacpoissons_ispeche);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.lbl_veterinaire_bacpoissons_datejour);
            this.tbp_veterinaire_bacpoisson.Controls.Add(this.lbl_veterinaire_bacpoissons_title);
            this.tbp_veterinaire_bacpoisson.Location = new System.Drawing.Point(4, 25);
            this.tbp_veterinaire_bacpoisson.Name = "tbp_veterinaire_bacpoisson";
            this.tbp_veterinaire_bacpoisson.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_veterinaire_bacpoisson.Size = new System.Drawing.Size(1055, 564);
            this.tbp_veterinaire_bacpoisson.TabIndex = 1;
            this.tbp_veterinaire_bacpoisson.Text = "Bac de poissons";
            this.tbp_veterinaire_bacpoisson.UseVisualStyleBackColor = true;
            // 
            // cbx_veterinaire_bacpoissons_typebac
            // 
            this.cbx_veterinaire_bacpoissons_typebac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_veterinaire_bacpoissons_typebac.FormattingEnabled = true;
            this.cbx_veterinaire_bacpoissons_typebac.Location = new System.Drawing.Point(773, 393);
            this.cbx_veterinaire_bacpoissons_typebac.Name = "cbx_veterinaire_bacpoissons_typebac";
            this.cbx_veterinaire_bacpoissons_typebac.Size = new System.Drawing.Size(129, 24);
            this.cbx_veterinaire_bacpoissons_typebac.TabIndex = 31;
            // 
            // cbx_veterinaire_bacpoissons_presentation
            // 
            this.cbx_veterinaire_bacpoissons_presentation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_veterinaire_bacpoissons_presentation.FormattingEnabled = true;
            this.cbx_veterinaire_bacpoissons_presentation.Location = new System.Drawing.Point(495, 435);
            this.cbx_veterinaire_bacpoissons_presentation.Name = "cbx_veterinaire_bacpoissons_presentation";
            this.cbx_veterinaire_bacpoissons_presentation.Size = new System.Drawing.Size(129, 24);
            this.cbx_veterinaire_bacpoissons_presentation.TabIndex = 30;
            // 
            // cbx_veterinaire_bacpoissons_qualite
            // 
            this.cbx_veterinaire_bacpoissons_qualite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_veterinaire_bacpoissons_qualite.FormattingEnabled = true;
            this.cbx_veterinaire_bacpoissons_qualite.Location = new System.Drawing.Point(444, 393);
            this.cbx_veterinaire_bacpoissons_qualite.Name = "cbx_veterinaire_bacpoissons_qualite";
            this.cbx_veterinaire_bacpoissons_qualite.Size = new System.Drawing.Size(113, 24);
            this.cbx_veterinaire_bacpoissons_qualite.TabIndex = 29;
            // 
            // cbx_veterinaire_bacpoissons_taille
            // 
            this.cbx_veterinaire_bacpoissons_taille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_veterinaire_bacpoissons_taille.FormattingEnabled = true;
            this.cbx_veterinaire_bacpoissons_taille.Location = new System.Drawing.Point(144, 435);
            this.cbx_veterinaire_bacpoissons_taille.Name = "cbx_veterinaire_bacpoissons_taille";
            this.cbx_veterinaire_bacpoissons_taille.Size = new System.Drawing.Size(122, 24);
            this.cbx_veterinaire_bacpoissons_taille.TabIndex = 28;
            // 
            // cbx_veterinaire_bacpoissons_espece
            // 
            this.cbx_veterinaire_bacpoissons_espece.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_veterinaire_bacpoissons_espece.FormattingEnabled = true;
            this.cbx_veterinaire_bacpoissons_espece.Location = new System.Drawing.Point(144, 395);
            this.cbx_veterinaire_bacpoissons_espece.Name = "cbx_veterinaire_bacpoissons_espece";
            this.cbx_veterinaire_bacpoissons_espece.Size = new System.Drawing.Size(167, 24);
            this.cbx_veterinaire_bacpoissons_espece.TabIndex = 27;
            // 
            // btn_veterinaire_bacpoissons_valider
            // 
            this.btn_veterinaire_bacpoissons_valider.BackColor = System.Drawing.SystemColors.Info;
            this.btn_veterinaire_bacpoissons_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_veterinaire_bacpoissons_valider.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_veterinaire_bacpoissons_valider.Location = new System.Drawing.Point(847, 435);
            this.btn_veterinaire_bacpoissons_valider.Name = "btn_veterinaire_bacpoissons_valider";
            this.btn_veterinaire_bacpoissons_valider.Size = new System.Drawing.Size(132, 33);
            this.btn_veterinaire_bacpoissons_valider.TabIndex = 26;
            this.btn_veterinaire_bacpoissons_valider.Text = "Valider";
            this.btn_veterinaire_bacpoissons_valider.UseVisualStyleBackColor = false;
            this.btn_veterinaire_bacpoissons_valider.Click += new System.EventHandler(this.btn_veterinaire_bacpoissons_valider_Click);
            // 
            // lbl_veterinaire_bacpoissons_typebac
            // 
            this.lbl_veterinaire_bacpoissons_typebac.AutoSize = true;
            this.lbl_veterinaire_bacpoissons_typebac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_veterinaire_bacpoissons_typebac.Location = new System.Drawing.Point(626, 391);
            this.lbl_veterinaire_bacpoissons_typebac.Name = "lbl_veterinaire_bacpoissons_typebac";
            this.lbl_veterinaire_bacpoissons_typebac.Size = new System.Drawing.Size(127, 24);
            this.lbl_veterinaire_bacpoissons_typebac.TabIndex = 25;
            this.lbl_veterinaire_bacpoissons_typebac.Text = "Type de Bac :";
            // 
            // lbl_veterinaire_bacpoissons_presentation
            // 
            this.lbl_veterinaire_bacpoissons_presentation.AutoSize = true;
            this.lbl_veterinaire_bacpoissons_presentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_veterinaire_bacpoissons_presentation.Location = new System.Drawing.Point(348, 435);
            this.lbl_veterinaire_bacpoissons_presentation.Name = "lbl_veterinaire_bacpoissons_presentation";
            this.lbl_veterinaire_bacpoissons_presentation.Size = new System.Drawing.Size(124, 24);
            this.lbl_veterinaire_bacpoissons_presentation.TabIndex = 24;
            this.lbl_veterinaire_bacpoissons_presentation.Text = "Présentation :";
            // 
            // lbl_veterinaire_bacpoissons_qualite
            // 
            this.lbl_veterinaire_bacpoissons_qualite.AutoSize = true;
            this.lbl_veterinaire_bacpoissons_qualite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_veterinaire_bacpoissons_qualite.Location = new System.Drawing.Point(348, 393);
            this.lbl_veterinaire_bacpoissons_qualite.Name = "lbl_veterinaire_bacpoissons_qualite";
            this.lbl_veterinaire_bacpoissons_qualite.Size = new System.Drawing.Size(79, 24);
            this.lbl_veterinaire_bacpoissons_qualite.TabIndex = 23;
            this.lbl_veterinaire_bacpoissons_qualite.Text = "Qualité :";
            // 
            // lbl_veterinaire_bacpoissons_taille
            // 
            this.lbl_veterinaire_bacpoissons_taille.AutoSize = true;
            this.lbl_veterinaire_bacpoissons_taille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_veterinaire_bacpoissons_taille.Location = new System.Drawing.Point(35, 435);
            this.lbl_veterinaire_bacpoissons_taille.Name = "lbl_veterinaire_bacpoissons_taille";
            this.lbl_veterinaire_bacpoissons_taille.Size = new System.Drawing.Size(65, 24);
            this.lbl_veterinaire_bacpoissons_taille.TabIndex = 22;
            this.lbl_veterinaire_bacpoissons_taille.Text = "Taille :";
            // 
            // lbl_veterinaire_bacpoissons_espece
            // 
            this.lbl_veterinaire_bacpoissons_espece.AutoSize = true;
            this.lbl_veterinaire_bacpoissons_espece.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_veterinaire_bacpoissons_espece.Location = new System.Drawing.Point(36, 393);
            this.lbl_veterinaire_bacpoissons_espece.Name = "lbl_veterinaire_bacpoissons_espece";
            this.lbl_veterinaire_bacpoissons_espece.Size = new System.Drawing.Size(85, 24);
            this.lbl_veterinaire_bacpoissons_espece.TabIndex = 21;
            this.lbl_veterinaire_bacpoissons_espece.Text = "Espèce :";
            // 
            // lbl_veterinaire_bacpoissons_creationbac
            // 
            this.lbl_veterinaire_bacpoissons_creationbac.AutoSize = true;
            this.lbl_veterinaire_bacpoissons_creationbac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_veterinaire_bacpoissons_creationbac.Location = new System.Drawing.Point(35, 350);
            this.lbl_veterinaire_bacpoissons_creationbac.Name = "lbl_veterinaire_bacpoissons_creationbac";
            this.lbl_veterinaire_bacpoissons_creationbac.Size = new System.Drawing.Size(193, 26);
            this.lbl_veterinaire_bacpoissons_creationbac.TabIndex = 20;
            this.lbl_veterinaire_bacpoissons_creationbac.Text = "Création d\'un bac :";
            // 
            // lbl_veterinaire_bacpoissons_isbac
            // 
            this.lbl_veterinaire_bacpoissons_isbac.AutoSize = true;
            this.lbl_veterinaire_bacpoissons_isbac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbl_veterinaire_bacpoissons_isbac.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_veterinaire_bacpoissons_isbac.Location = new System.Drawing.Point(74, 201);
            this.lbl_veterinaire_bacpoissons_isbac.Name = "lbl_veterinaire_bacpoissons_isbac";
            this.lbl_veterinaire_bacpoissons_isbac.Size = new System.Drawing.Size(359, 24);
            this.lbl_veterinaire_bacpoissons_isbac.TabIndex = 19;
            this.lbl_veterinaire_bacpoissons_isbac.Text = "Pas de bacs enregistrés pour cette pêche";
            // 
            // btn_veterinaire_bacpoissons_creerlots
            // 
            this.btn_veterinaire_bacpoissons_creerlots.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_veterinaire_bacpoissons_creerlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_veterinaire_bacpoissons_creerlots.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_veterinaire_bacpoissons_creerlots.Location = new System.Drawing.Point(829, 513);
            this.btn_veterinaire_bacpoissons_creerlots.Name = "btn_veterinaire_bacpoissons_creerlots";
            this.btn_veterinaire_bacpoissons_creerlots.Size = new System.Drawing.Size(188, 33);
            this.btn_veterinaire_bacpoissons_creerlots.TabIndex = 18;
            this.btn_veterinaire_bacpoissons_creerlots.Text = "CREER DES LOTS";
            this.btn_veterinaire_bacpoissons_creerlots.UseVisualStyleBackColor = false;
            this.btn_veterinaire_bacpoissons_creerlots.Click += new System.EventHandler(this.btn_veterinaire_bacpoissons_creerlots_Click);
            // 
            // lbl_veterinaire_bacpoissons_info
            // 
            this.lbl_veterinaire_bacpoissons_info.AutoSize = true;
            this.lbl_veterinaire_bacpoissons_info.Location = new System.Drawing.Point(17, 495);
            this.lbl_veterinaire_bacpoissons_info.Name = "lbl_veterinaire_bacpoissons_info";
            this.lbl_veterinaire_bacpoissons_info.Size = new System.Drawing.Size(771, 51);
            this.lbl_veterinaire_bacpoissons_info.TabIndex = 17;
            this.lbl_veterinaire_bacpoissons_info.Text = resources.GetString("lbl_veterinaire_bacpoissons_info.Text");
            // 
            // btn_veterinaire_bacpoissons_modifierbacs
            // 
            this.btn_veterinaire_bacpoissons_modifierbacs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_veterinaire_bacpoissons_modifierbacs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_veterinaire_bacpoissons_modifierbacs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_veterinaire_bacpoissons_modifierbacs.Location = new System.Drawing.Point(707, 250);
            this.btn_veterinaire_bacpoissons_modifierbacs.Name = "btn_veterinaire_bacpoissons_modifierbacs";
            this.btn_veterinaire_bacpoissons_modifierbacs.Size = new System.Drawing.Size(272, 47);
            this.btn_veterinaire_bacpoissons_modifierbacs.TabIndex = 16;
            this.btn_veterinaire_bacpoissons_modifierbacs.Text = "Modifier des bacs non associées à un lot";
            this.btn_veterinaire_bacpoissons_modifierbacs.UseVisualStyleBackColor = false;
            // 
            // btn_veterinaire_bacpoissons_supprimerbacs
            // 
            this.btn_veterinaire_bacpoissons_supprimerbacs.BackColor = System.Drawing.Color.Red;
            this.btn_veterinaire_bacpoissons_supprimerbacs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_veterinaire_bacpoissons_supprimerbacs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_veterinaire_bacpoissons_supprimerbacs.Location = new System.Drawing.Point(707, 178);
            this.btn_veterinaire_bacpoissons_supprimerbacs.Name = "btn_veterinaire_bacpoissons_supprimerbacs";
            this.btn_veterinaire_bacpoissons_supprimerbacs.Size = new System.Drawing.Size(272, 47);
            this.btn_veterinaire_bacpoissons_supprimerbacs.TabIndex = 15;
            this.btn_veterinaire_bacpoissons_supprimerbacs.Text = "Supprimer des bacs non associées à un lot";
            this.btn_veterinaire_bacpoissons_supprimerbacs.UseVisualStyleBackColor = false;
            // 
            // btn_veterinaire_bacpoissons_creerbacs
            // 
            this.btn_veterinaire_bacpoissons_creerbacs.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_veterinaire_bacpoissons_creerbacs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_veterinaire_bacpoissons_creerbacs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_veterinaire_bacpoissons_creerbacs.Location = new System.Drawing.Point(39, 393);
            this.btn_veterinaire_bacpoissons_creerbacs.Name = "btn_veterinaire_bacpoissons_creerbacs";
            this.btn_veterinaire_bacpoissons_creerbacs.Size = new System.Drawing.Size(160, 33);
            this.btn_veterinaire_bacpoissons_creerbacs.TabIndex = 14;
            this.btn_veterinaire_bacpoissons_creerbacs.Text = "Créer des bacs";
            this.btn_veterinaire_bacpoissons_creerbacs.UseVisualStyleBackColor = false;
            this.btn_veterinaire_bacpoissons_creerbacs.Click += new System.EventHandler(this.btn_veterinaire_bacpoissons_creerbacs_Click);
            // 
            // dg_veterinaire_bacpoissons_listebac
            // 
            this.dg_veterinaire_bacpoissons_listebac.AllowUserToAddRows = false;
            this.dg_veterinaire_bacpoissons_listebac.AllowUserToDeleteRows = false;
            this.dg_veterinaire_bacpoissons_listebac.AllowUserToResizeRows = false;
            this.dg_veterinaire_bacpoissons_listebac.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_veterinaire_bacpoissons_listebac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_veterinaire_bacpoissons_listebac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_veterinaire_bacpoissons_listebac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numBac,
            this.espece,
            this.taille,
            this.qualite,
            this.presentation,
            this.typebac});
            this.dg_veterinaire_bacpoissons_listebac.GridColor = System.Drawing.SystemColors.Control;
            this.dg_veterinaire_bacpoissons_listebac.Location = new System.Drawing.Point(29, 142);
            this.dg_veterinaire_bacpoissons_listebac.Name = "dg_veterinaire_bacpoissons_listebac";
            this.dg_veterinaire_bacpoissons_listebac.ReadOnly = true;
            this.dg_veterinaire_bacpoissons_listebac.RowHeadersWidth = 10;
            this.dg_veterinaire_bacpoissons_listebac.RowTemplate.Height = 24;
            this.dg_veterinaire_bacpoissons_listebac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_veterinaire_bacpoissons_listebac.Size = new System.Drawing.Size(595, 190);
            this.dg_veterinaire_bacpoissons_listebac.TabIndex = 12;
            // 
            // numBac
            // 
            this.numBac.HeaderText = "Numéro de Bac (Numéro de Lot)";
            this.numBac.MinimumWidth = 6;
            this.numBac.Name = "numBac";
            this.numBac.ReadOnly = true;
            this.numBac.Width = 70;
            // 
            // espece
            // 
            this.espece.HeaderText = "Espèce";
            this.espece.MinimumWidth = 6;
            this.espece.Name = "espece";
            this.espece.ReadOnly = true;
            this.espece.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.espece.Width = 65;
            // 
            // taille
            // 
            this.taille.HeaderText = "Taille";
            this.taille.MinimumWidth = 6;
            this.taille.Name = "taille";
            this.taille.ReadOnly = true;
            this.taille.Width = 65;
            // 
            // qualite
            // 
            this.qualite.HeaderText = "Qualité";
            this.qualite.MinimumWidth = 6;
            this.qualite.Name = "qualite";
            this.qualite.ReadOnly = true;
            this.qualite.Width = 65;
            // 
            // presentation
            // 
            this.presentation.HeaderText = "Présentation";
            this.presentation.MinimumWidth = 6;
            this.presentation.Name = "presentation";
            this.presentation.ReadOnly = true;
            this.presentation.Width = 75;
            // 
            // typebac
            // 
            this.typebac.HeaderText = "Type Bac";
            this.typebac.MinimumWidth = 6;
            this.typebac.Name = "typebac";
            this.typebac.ReadOnly = true;
            this.typebac.Width = 75;
            // 
            // cbx_veterinaire_bacpoissons_listebateaux
            // 
            this.cbx_veterinaire_bacpoissons_listebateaux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_veterinaire_bacpoissons_listebateaux.FormattingEnabled = true;
            this.cbx_veterinaire_bacpoissons_listebateaux.Location = new System.Drawing.Point(589, 87);
            this.cbx_veterinaire_bacpoissons_listebateaux.Name = "cbx_veterinaire_bacpoissons_listebateaux";
            this.cbx_veterinaire_bacpoissons_listebateaux.Size = new System.Drawing.Size(199, 24);
            this.cbx_veterinaire_bacpoissons_listebateaux.TabIndex = 11;
            this.cbx_veterinaire_bacpoissons_listebateaux.SelectionChangeCommitted += new System.EventHandler(this.cbx_veterinaire_bacpoissons_listebateaux_SelectionChangeCommitted);
            // 
            // lbl_veterinaire_bacpoissons_choixbateau
            // 
            this.lbl_veterinaire_bacpoissons_choixbateau.AutoSize = true;
            this.lbl_veterinaire_bacpoissons_choixbateau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_veterinaire_bacpoissons_choixbateau.Location = new System.Drawing.Point(400, 85);
            this.lbl_veterinaire_bacpoissons_choixbateau.Name = "lbl_veterinaire_bacpoissons_choixbateau";
            this.lbl_veterinaire_bacpoissons_choixbateau.Size = new System.Drawing.Size(167, 24);
            this.lbl_veterinaire_bacpoissons_choixbateau.TabIndex = 10;
            this.lbl_veterinaire_bacpoissons_choixbateau.Text = "Choisir un bateau :";
            // 
            // lbl_veterinaire_bacpoissons_ispeche
            // 
            this.lbl_veterinaire_bacpoissons_ispeche.AutoSize = true;
            this.lbl_veterinaire_bacpoissons_ispeche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbl_veterinaire_bacpoissons_ispeche.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_veterinaire_bacpoissons_ispeche.Location = new System.Drawing.Point(74, 201);
            this.lbl_veterinaire_bacpoissons_ispeche.Name = "lbl_veterinaire_bacpoissons_ispeche";
            this.lbl_veterinaire_bacpoissons_ispeche.Size = new System.Drawing.Size(700, 24);
            this.lbl_veterinaire_bacpoissons_ispeche.TabIndex = 9;
            this.lbl_veterinaire_bacpoissons_ispeche.Text = "Il n\'y a aucune pêche enregistrée pour ce jour, veuillez contacter le réceptionni" +
    "ste.";
            // 
            // lbl_veterinaire_bacpoissons_datejour
            // 
            this.lbl_veterinaire_bacpoissons_datejour.AutoSize = true;
            this.lbl_veterinaire_bacpoissons_datejour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_veterinaire_bacpoissons_datejour.Location = new System.Drawing.Point(104, 85);
            this.lbl_veterinaire_bacpoissons_datejour.Name = "lbl_veterinaire_bacpoissons_datejour";
            this.lbl_veterinaire_bacpoissons_datejour.Size = new System.Drawing.Size(127, 24);
            this.lbl_veterinaire_bacpoissons_datejour.TabIndex = 8;
            this.lbl_veterinaire_bacpoissons_datejour.Text = "Date du jour : ";
            // 
            // lbl_veterinaire_bacpoissons_title
            // 
            this.lbl_veterinaire_bacpoissons_title.AutoSize = true;
            this.lbl_veterinaire_bacpoissons_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_veterinaire_bacpoissons_title.Location = new System.Drawing.Point(355, 31);
            this.lbl_veterinaire_bacpoissons_title.Name = "lbl_veterinaire_bacpoissons_title";
            this.lbl_veterinaire_bacpoissons_title.Size = new System.Drawing.Size(306, 32);
            this.lbl_veterinaire_bacpoissons_title.TabIndex = 7;
            this.lbl_veterinaire_bacpoissons_title.Text = "GESTION DES BACS";
            // 
            // tbp_veterinaire_lotspeche
            // 
            this.tbp_veterinaire_lotspeche.Location = new System.Drawing.Point(4, 25);
            this.tbp_veterinaire_lotspeche.Name = "tbp_veterinaire_lotspeche";
            this.tbp_veterinaire_lotspeche.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_veterinaire_lotspeche.Size = new System.Drawing.Size(1055, 564);
            this.tbp_veterinaire_lotspeche.TabIndex = 2;
            this.tbp_veterinaire_lotspeche.Text = "Lots de pêche";
            this.tbp_veterinaire_lotspeche.UseVisualStyleBackColor = true;
            // 
            // AppCriee_Veterinaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 595);
            this.Controls.Add(this.tbc_veterinaire);
            this.Name = "AppCriee_Veterinaire";
            this.Text = "AppCriée (Vétérinaire)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppCriee_Veterinaire_FormClosing);
            this.tbc_veterinaire.ResumeLayout(false);
            this.tbp_veterinaire_accueil.ResumeLayout(false);
            this.tbp_veterinaire_accueil.PerformLayout();
            this.tbp_veterinaire_bacpoisson.ResumeLayout(false);
            this.tbp_veterinaire_bacpoisson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_veterinaire_bacpoissons_listebac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_veterinaire;
        private System.Windows.Forms.TabPage tbp_veterinaire_accueil;
        private System.Windows.Forms.TabPage tbp_veterinaire_bacpoisson;
        private System.Windows.Forms.Label lbl_veterinaire_accueil_bienvenue;
        private System.Windows.Forms.Label lbl_veterinaire_accueil_role;
        private System.Windows.Forms.TabPage tbp_veterinaire_lotspeche;
        private System.Windows.Forms.Label lbl_veterinaire_bacpoissons_title;
        private System.Windows.Forms.Label lbl_veterinaire_bacpoissons_datejour;
        private System.Windows.Forms.Label lbl_veterinaire_bacpoissons_ispeche;
        private System.Windows.Forms.Label lbl_veterinaire_bacpoissons_choixbateau;
        private System.Windows.Forms.ComboBox cbx_veterinaire_bacpoissons_listebateaux;
        private System.Windows.Forms.DataGridView dg_veterinaire_bacpoissons_listebac;
        private System.Windows.Forms.Button btn_veterinaire_bacpoissons_creerlots;
        private System.Windows.Forms.Label lbl_veterinaire_bacpoissons_info;
        private System.Windows.Forms.Button btn_veterinaire_bacpoissons_modifierbacs;
        private System.Windows.Forms.Button btn_veterinaire_bacpoissons_supprimerbacs;
        private System.Windows.Forms.Button btn_veterinaire_bacpoissons_creerbacs;
        private System.Windows.Forms.Label lbl_veterinaire_bacpoissons_isbac;
        private System.Windows.Forms.Label lbl_veterinaire_bacpoissons_typebac;
        private System.Windows.Forms.Label lbl_veterinaire_bacpoissons_presentation;
        private System.Windows.Forms.Label lbl_veterinaire_bacpoissons_qualite;
        private System.Windows.Forms.Label lbl_veterinaire_bacpoissons_taille;
        private System.Windows.Forms.Label lbl_veterinaire_bacpoissons_espece;
        private System.Windows.Forms.Label lbl_veterinaire_bacpoissons_creationbac;
        private System.Windows.Forms.ComboBox cbx_veterinaire_bacpoissons_typebac;
        private System.Windows.Forms.ComboBox cbx_veterinaire_bacpoissons_presentation;
        private System.Windows.Forms.ComboBox cbx_veterinaire_bacpoissons_qualite;
        private System.Windows.Forms.ComboBox cbx_veterinaire_bacpoissons_taille;
        private System.Windows.Forms.ComboBox cbx_veterinaire_bacpoissons_espece;
        private System.Windows.Forms.Button btn_veterinaire_bacpoissons_valider;
        private System.Windows.Forms.DataGridViewTextBoxColumn numBac;
        private System.Windows.Forms.DataGridViewTextBoxColumn espece;
        private System.Windows.Forms.DataGridViewTextBoxColumn taille;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualite;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentation;
        private System.Windows.Forms.DataGridViewTextBoxColumn typebac;
    }
}