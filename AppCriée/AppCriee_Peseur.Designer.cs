namespace AppCriée
{
    partial class AppCriee_Peseur
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
            this.lbl_peseur_accueil_bienvenue = new System.Windows.Forms.Label();
            this.lbl_peseur_accueil_role = new System.Windows.Forms.Label();
            this.tbc_peseur = new System.Windows.Forms.TabControl();
            this.tbp_peseur_accueil = new System.Windows.Forms.TabPage();
            this.tbp_peseur_lotspeche = new System.Windows.Forms.TabPage();
            this.lbl_peseur_lotspeche_validation = new System.Windows.Forms.Label();
            this.rbtn_peseur_lotspeche_lotbloque = new System.Windows.Forms.RadioButton();
            this.rbtn_peseur_lotspeche_lotnonbloque = new System.Windows.Forms.RadioButton();
            this.lbl_peseur_lotspeche_validationok = new System.Windows.Forms.Label();
            this.btn_peseur_lotspeche_validersaisiepoids = new System.Windows.Forms.Button();
            this.tbx_peseur_lotspeche_saisirpoids = new System.Windows.Forms.TextBox();
            this.lbl_peseur_lotspeche_saisirpoids = new System.Windows.Forms.Label();
            this.btn_peseur_lotspeche_saisirpoids = new System.Windows.Forms.Button();
            this.lbl_peseur_lotspeche_info = new System.Windows.Forms.Label();
            this.dg_peseur_lotspeche_bacs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_peseur_lotspeche_bacdulot = new System.Windows.Forms.Label();
            this.lbl_peseur_lotspeche_islots = new System.Windows.Forms.Label();
            this.dg_peseur_lotspeche_lotsbateau = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poidstotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeEtat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_peseur_lotspeche_lotsbateau = new System.Windows.Forms.Label();
            this.cbx_peseur_lotspeche_listebateaux = new System.Windows.Forms.ComboBox();
            this.lbl_peseur_lotspeche_choixbateau = new System.Windows.Forms.Label();
            this.lbl_peseur_lotspeche_title = new System.Windows.Forms.Label();
            this.lbl_peseur_lotspeche_ispeche = new System.Windows.Forms.Label();
            this.lbl_peseur_datejour = new System.Windows.Forms.Label();
            this.pbx_peseur_deconnexion = new System.Windows.Forms.PictureBox();
            this.tbc_peseur.SuspendLayout();
            this.tbp_peseur_accueil.SuspendLayout();
            this.tbp_peseur_lotspeche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_peseur_lotspeche_bacs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_peseur_lotspeche_lotsbateau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_peseur_deconnexion)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_peseur_accueil_bienvenue
            // 
            this.lbl_peseur_accueil_bienvenue.AutoSize = true;
            this.lbl_peseur_accueil_bienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peseur_accueil_bienvenue.Location = new System.Drawing.Point(149, 131);
            this.lbl_peseur_accueil_bienvenue.Name = "lbl_peseur_accueil_bienvenue";
            this.lbl_peseur_accueil_bienvenue.Size = new System.Drawing.Size(376, 25);
            this.lbl_peseur_accueil_bienvenue.TabIndex = 0;
            this.lbl_peseur_accueil_bienvenue.Text = "Bienvenue [Nom_user] [Prenom_user]";
            // 
            // lbl_peseur_accueil_role
            // 
            this.lbl_peseur_accueil_role.AutoSize = true;
            this.lbl_peseur_accueil_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peseur_accueil_role.Location = new System.Drawing.Point(149, 197);
            this.lbl_peseur_accueil_role.Name = "lbl_peseur_accueil_role";
            this.lbl_peseur_accueil_role.Size = new System.Drawing.Size(142, 25);
            this.lbl_peseur_accueil_role.TabIndex = 1;
            this.lbl_peseur_accueil_role.Text = "Rôle : Peseur";
            // 
            // tbc_peseur
            // 
            this.tbc_peseur.Controls.Add(this.tbp_peseur_accueil);
            this.tbc_peseur.Controls.Add(this.tbp_peseur_lotspeche);
            this.tbc_peseur.ItemSize = new System.Drawing.Size(47, 18);
            this.tbc_peseur.Location = new System.Drawing.Point(0, 0);
            this.tbc_peseur.Margin = new System.Windows.Forms.Padding(2);
            this.tbc_peseur.Name = "tbc_peseur";
            this.tbc_peseur.SelectedIndex = 0;
            this.tbc_peseur.Size = new System.Drawing.Size(814, 552);
            this.tbc_peseur.TabIndex = 2;
            this.tbc_peseur.SelectedIndexChanged += new System.EventHandler(this.tbc_peseur_SelectedIndexChanged);
            // 
            // tbp_peseur_accueil
            // 
            this.tbp_peseur_accueil.Controls.Add(this.lbl_peseur_accueil_bienvenue);
            this.tbp_peseur_accueil.Controls.Add(this.lbl_peseur_accueil_role);
            this.tbp_peseur_accueil.Location = new System.Drawing.Point(4, 22);
            this.tbp_peseur_accueil.Name = "tbp_peseur_accueil";
            this.tbp_peseur_accueil.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_peseur_accueil.Size = new System.Drawing.Size(806, 526);
            this.tbp_peseur_accueil.TabIndex = 0;
            this.tbp_peseur_accueil.Text = "Accueil";
            this.tbp_peseur_accueil.UseVisualStyleBackColor = true;
            // 
            // tbp_peseur_lotspeche
            // 
            this.tbp_peseur_lotspeche.Controls.Add(this.lbl_peseur_lotspeche_validation);
            this.tbp_peseur_lotspeche.Controls.Add(this.rbtn_peseur_lotspeche_lotbloque);
            this.tbp_peseur_lotspeche.Controls.Add(this.rbtn_peseur_lotspeche_lotnonbloque);
            this.tbp_peseur_lotspeche.Controls.Add(this.lbl_peseur_lotspeche_validationok);
            this.tbp_peseur_lotspeche.Controls.Add(this.btn_peseur_lotspeche_validersaisiepoids);
            this.tbp_peseur_lotspeche.Controls.Add(this.tbx_peseur_lotspeche_saisirpoids);
            this.tbp_peseur_lotspeche.Controls.Add(this.lbl_peseur_lotspeche_saisirpoids);
            this.tbp_peseur_lotspeche.Controls.Add(this.btn_peseur_lotspeche_saisirpoids);
            this.tbp_peseur_lotspeche.Controls.Add(this.lbl_peseur_lotspeche_info);
            this.tbp_peseur_lotspeche.Controls.Add(this.dg_peseur_lotspeche_bacs);
            this.tbp_peseur_lotspeche.Controls.Add(this.lbl_peseur_lotspeche_bacdulot);
            this.tbp_peseur_lotspeche.Controls.Add(this.lbl_peseur_lotspeche_islots);
            this.tbp_peseur_lotspeche.Controls.Add(this.dg_peseur_lotspeche_lotsbateau);
            this.tbp_peseur_lotspeche.Controls.Add(this.lbl_peseur_lotspeche_lotsbateau);
            this.tbp_peseur_lotspeche.Controls.Add(this.cbx_peseur_lotspeche_listebateaux);
            this.tbp_peseur_lotspeche.Controls.Add(this.lbl_peseur_lotspeche_choixbateau);
            this.tbp_peseur_lotspeche.Controls.Add(this.lbl_peseur_lotspeche_title);
            this.tbp_peseur_lotspeche.Controls.Add(this.lbl_peseur_lotspeche_ispeche);
            this.tbp_peseur_lotspeche.Location = new System.Drawing.Point(4, 22);
            this.tbp_peseur_lotspeche.Name = "tbp_peseur_lotspeche";
            this.tbp_peseur_lotspeche.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_peseur_lotspeche.Size = new System.Drawing.Size(806, 526);
            this.tbp_peseur_lotspeche.TabIndex = 1;
            this.tbp_peseur_lotspeche.Text = "Lots de pêche";
            this.tbp_peseur_lotspeche.UseVisualStyleBackColor = true;
            // 
            // lbl_peseur_lotspeche_validation
            // 
            this.lbl_peseur_lotspeche_validation.AutoSize = true;
            this.lbl_peseur_lotspeche_validation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_peseur_lotspeche_validation.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_peseur_lotspeche_validation.Location = new System.Drawing.Point(373, 294);
            this.lbl_peseur_lotspeche_validation.Name = "lbl_peseur_lotspeche_validation";
            this.lbl_peseur_lotspeche_validation.Size = new System.Drawing.Size(195, 18);
            this.lbl_peseur_lotspeche_validation.TabIndex = 35;
            this.lbl_peseur_lotspeche_validation.Text = "Le lot sélectionné est bloqué";
            this.lbl_peseur_lotspeche_validation.Visible = false;
            // 
            // rbtn_peseur_lotspeche_lotbloque
            // 
            this.rbtn_peseur_lotspeche_lotbloque.AutoSize = true;
            this.rbtn_peseur_lotspeche_lotbloque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_peseur_lotspeche_lotbloque.Location = new System.Drawing.Point(661, 188);
            this.rbtn_peseur_lotspeche_lotbloque.Name = "rbtn_peseur_lotspeche_lotbloque";
            this.rbtn_peseur_lotspeche_lotbloque.Size = new System.Drawing.Size(85, 17);
            this.rbtn_peseur_lotspeche_lotbloque.TabIndex = 34;
            this.rbtn_peseur_lotspeche_lotbloque.TabStop = true;
            this.rbtn_peseur_lotspeche_lotbloque.Text = "Lot bloqué";
            this.rbtn_peseur_lotspeche_lotbloque.UseVisualStyleBackColor = true;
            this.rbtn_peseur_lotspeche_lotbloque.Visible = false;
            this.rbtn_peseur_lotspeche_lotbloque.CheckedChanged += new System.EventHandler(this.rbtn_peseur_lotspeche_ChangedBloqueLot_CheckedChanged);
            // 
            // rbtn_peseur_lotspeche_lotnonbloque
            // 
            this.rbtn_peseur_lotspeche_lotnonbloque.AutoSize = true;
            this.rbtn_peseur_lotspeche_lotnonbloque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_peseur_lotspeche_lotnonbloque.Location = new System.Drawing.Point(661, 165);
            this.rbtn_peseur_lotspeche_lotnonbloque.Name = "rbtn_peseur_lotspeche_lotnonbloque";
            this.rbtn_peseur_lotspeche_lotnonbloque.Size = new System.Drawing.Size(110, 17);
            this.rbtn_peseur_lotspeche_lotnonbloque.TabIndex = 33;
            this.rbtn_peseur_lotspeche_lotnonbloque.TabStop = true;
            this.rbtn_peseur_lotspeche_lotnonbloque.Text = "Lot non-bloqué";
            this.rbtn_peseur_lotspeche_lotnonbloque.UseVisualStyleBackColor = true;
            this.rbtn_peseur_lotspeche_lotnonbloque.Visible = false;
            this.rbtn_peseur_lotspeche_lotnonbloque.CheckedChanged += new System.EventHandler(this.rbtn_peseur_lotspeche_ChangedBloqueLot_CheckedChanged);
            // 
            // lbl_peseur_lotspeche_validationok
            // 
            this.lbl_peseur_lotspeche_validationok.AutoSize = true;
            this.lbl_peseur_lotspeche_validationok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peseur_lotspeche_validationok.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_peseur_lotspeche_validationok.Location = new System.Drawing.Point(439, 435);
            this.lbl_peseur_lotspeche_validationok.Name = "lbl_peseur_lotspeche_validationok";
            this.lbl_peseur_lotspeche_validationok.Size = new System.Drawing.Size(43, 18);
            this.lbl_peseur_lotspeche_validationok.TabIndex = 32;
            this.lbl_peseur_lotspeche_validationok.Text = "Label";
            this.lbl_peseur_lotspeche_validationok.Visible = false;
            // 
            // btn_peseur_lotspeche_validersaisiepoids
            // 
            this.btn_peseur_lotspeche_validersaisiepoids.BackColor = System.Drawing.SystemColors.Info;
            this.btn_peseur_lotspeche_validersaisiepoids.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_peseur_lotspeche_validersaisiepoids.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_peseur_lotspeche_validersaisiepoids.Location = new System.Drawing.Point(504, 435);
            this.btn_peseur_lotspeche_validersaisiepoids.Margin = new System.Windows.Forms.Padding(2);
            this.btn_peseur_lotspeche_validersaisiepoids.Name = "btn_peseur_lotspeche_validersaisiepoids";
            this.btn_peseur_lotspeche_validersaisiepoids.Size = new System.Drawing.Size(120, 27);
            this.btn_peseur_lotspeche_validersaisiepoids.TabIndex = 31;
            this.btn_peseur_lotspeche_validersaisiepoids.Text = "Valider";
            this.btn_peseur_lotspeche_validersaisiepoids.UseVisualStyleBackColor = false;
            this.btn_peseur_lotspeche_validersaisiepoids.Visible = false;
            this.btn_peseur_lotspeche_validersaisiepoids.Click += new System.EventHandler(this.btn_peseur_lotspeche_validersaisiepoids_Click);
            // 
            // tbx_peseur_lotspeche_saisirpoids
            // 
            this.tbx_peseur_lotspeche_saisirpoids.Location = new System.Drawing.Point(590, 399);
            this.tbx_peseur_lotspeche_saisirpoids.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_peseur_lotspeche_saisirpoids.Name = "tbx_peseur_lotspeche_saisirpoids";
            this.tbx_peseur_lotspeche_saisirpoids.Size = new System.Drawing.Size(116, 20);
            this.tbx_peseur_lotspeche_saisirpoids.TabIndex = 30;
            this.tbx_peseur_lotspeche_saisirpoids.Visible = false;
            this.tbx_peseur_lotspeche_saisirpoids.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_peseur_lotspeche_saisirpoids_KeyPress);
            // 
            // lbl_peseur_lotspeche_saisirpoids
            // 
            this.lbl_peseur_lotspeche_saisirpoids.AutoSize = true;
            this.lbl_peseur_lotspeche_saisirpoids.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peseur_lotspeche_saisirpoids.Location = new System.Drawing.Point(373, 396);
            this.lbl_peseur_lotspeche_saisirpoids.Name = "lbl_peseur_lotspeche_saisirpoids";
            this.lbl_peseur_lotspeche_saisirpoids.Size = new System.Drawing.Size(200, 18);
            this.lbl_peseur_lotspeche_saisirpoids.TabIndex = 29;
            this.lbl_peseur_lotspeche_saisirpoids.Text = "Modification/Saisie du poids :";
            this.lbl_peseur_lotspeche_saisirpoids.Visible = false;
            // 
            // btn_peseur_lotspeche_saisirpoids
            // 
            this.btn_peseur_lotspeche_saisirpoids.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_peseur_lotspeche_saisirpoids.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_peseur_lotspeche_saisirpoids.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_peseur_lotspeche_saisirpoids.Location = new System.Drawing.Point(488, 321);
            this.btn_peseur_lotspeche_saisirpoids.Margin = new System.Windows.Forms.Padding(2);
            this.btn_peseur_lotspeche_saisirpoids.Name = "btn_peseur_lotspeche_saisirpoids";
            this.btn_peseur_lotspeche_saisirpoids.Size = new System.Drawing.Size(148, 46);
            this.btn_peseur_lotspeche_saisirpoids.TabIndex = 28;
            this.btn_peseur_lotspeche_saisirpoids.Text = "Modifier/Saisir le poids d\'un bac";
            this.btn_peseur_lotspeche_saisirpoids.UseVisualStyleBackColor = false;
            this.btn_peseur_lotspeche_saisirpoids.Visible = false;
            this.btn_peseur_lotspeche_saisirpoids.Click += new System.EventHandler(this.btn_peseur_lotspeche_saisirpoids_Click);
            // 
            // lbl_peseur_lotspeche_info
            // 
            this.lbl_peseur_lotspeche_info.AutoSize = true;
            this.lbl_peseur_lotspeche_info.Location = new System.Drawing.Point(45, 492);
            this.lbl_peseur_lotspeche_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_peseur_lotspeche_info.Name = "lbl_peseur_lotspeche_info";
            this.lbl_peseur_lotspeche_info.Size = new System.Drawing.Size(404, 13);
            this.lbl_peseur_lotspeche_info.TabIndex = 27;
            this.lbl_peseur_lotspeche_info.Text = "Pour modifier/saisir les poids des bacs, sélectionner une ligne correspondant à u" +
    "n lot";
            this.lbl_peseur_lotspeche_info.Visible = false;
            // 
            // dg_peseur_lotspeche_bacs
            // 
            this.dg_peseur_lotspeche_bacs.AllowUserToAddRows = false;
            this.dg_peseur_lotspeche_bacs.AllowUserToDeleteRows = false;
            this.dg_peseur_lotspeche_bacs.AllowUserToResizeRows = false;
            this.dg_peseur_lotspeche_bacs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_peseur_lotspeche_bacs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_peseur_lotspeche_bacs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_peseur_lotspeche_bacs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dg_peseur_lotspeche_bacs.GridColor = System.Drawing.SystemColors.Control;
            this.dg_peseur_lotspeche_bacs.Location = new System.Drawing.Point(27, 336);
            this.dg_peseur_lotspeche_bacs.Margin = new System.Windows.Forms.Padding(2);
            this.dg_peseur_lotspeche_bacs.MultiSelect = false;
            this.dg_peseur_lotspeche_bacs.Name = "dg_peseur_lotspeche_bacs";
            this.dg_peseur_lotspeche_bacs.ReadOnly = true;
            this.dg_peseur_lotspeche_bacs.RowHeadersWidth = 10;
            this.dg_peseur_lotspeche_bacs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_peseur_lotspeche_bacs.Size = new System.Drawing.Size(298, 125);
            this.dg_peseur_lotspeche_bacs.TabIndex = 26;
            this.dg_peseur_lotspeche_bacs.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Numéro de Bac";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Type de Bac";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 65;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Tare (en kg)";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 75;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Poids (en kg)";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 75;
            // 
            // lbl_peseur_lotspeche_bacdulot
            // 
            this.lbl_peseur_lotspeche_bacdulot.AutoSize = true;
            this.lbl_peseur_lotspeche_bacdulot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peseur_lotspeche_bacdulot.Location = new System.Drawing.Point(23, 294);
            this.lbl_peseur_lotspeche_bacdulot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_peseur_lotspeche_bacdulot.Name = "lbl_peseur_lotspeche_bacdulot";
            this.lbl_peseur_lotspeche_bacdulot.Size = new System.Drawing.Size(118, 24);
            this.lbl_peseur_lotspeche_bacdulot.TabIndex = 25;
            this.lbl_peseur_lotspeche_bacdulot.Text = "Bacs du Lot :";
            this.lbl_peseur_lotspeche_bacdulot.Visible = false;
            // 
            // lbl_peseur_lotspeche_islots
            // 
            this.lbl_peseur_lotspeche_islots.AutoSize = true;
            this.lbl_peseur_lotspeche_islots.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peseur_lotspeche_islots.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_peseur_lotspeche_islots.Location = new System.Drawing.Point(44, 179);
            this.lbl_peseur_lotspeche_islots.Name = "lbl_peseur_lotspeche_islots";
            this.lbl_peseur_lotspeche_islots.Size = new System.Drawing.Size(617, 24);
            this.lbl_peseur_lotspeche_islots.TabIndex = 24;
            this.lbl_peseur_lotspeche_islots.Text = "Pas encore de lots créés pour ce bateau, veuillez contacter le vétérinaire";
            this.lbl_peseur_lotspeche_islots.Visible = false;
            // 
            // dg_peseur_lotspeche_lotsbateau
            // 
            this.dg_peseur_lotspeche_lotsbateau.AllowUserToAddRows = false;
            this.dg_peseur_lotspeche_lotsbateau.AllowUserToDeleteRows = false;
            this.dg_peseur_lotspeche_lotsbateau.AllowUserToResizeRows = false;
            this.dg_peseur_lotspeche_lotsbateau.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_peseur_lotspeche_lotsbateau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_peseur_lotspeche_lotsbateau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_peseur_lotspeche_lotsbateau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.poidstotal,
            this.codeEtat});
            this.dg_peseur_lotspeche_lotsbateau.GridColor = System.Drawing.SystemColors.Control;
            this.dg_peseur_lotspeche_lotsbateau.Location = new System.Drawing.Point(27, 144);
            this.dg_peseur_lotspeche_lotsbateau.Margin = new System.Windows.Forms.Padding(2);
            this.dg_peseur_lotspeche_lotsbateau.MultiSelect = false;
            this.dg_peseur_lotspeche_lotsbateau.Name = "dg_peseur_lotspeche_lotsbateau";
            this.dg_peseur_lotspeche_lotsbateau.ReadOnly = true;
            this.dg_peseur_lotspeche_lotsbateau.RowHeadersWidth = 10;
            this.dg_peseur_lotspeche_lotsbateau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_peseur_lotspeche_lotsbateau.Size = new System.Drawing.Size(597, 125);
            this.dg_peseur_lotspeche_lotsbateau.TabIndex = 22;
            this.dg_peseur_lotspeche_lotsbateau.Visible = false;
            this.dg_peseur_lotspeche_lotsbateau.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_peseur_lotspeche_lotsbateau_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Numéro de Lot";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Espèce";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Taille";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 65;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Qualité";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 65;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Présentation";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre de bacs";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 75;
            // 
            // poidstotal
            // 
            this.poidstotal.HeaderText = "Poids total (en kg)";
            this.poidstotal.MinimumWidth = 6;
            this.poidstotal.Name = "poidstotal";
            this.poidstotal.ReadOnly = true;
            this.poidstotal.Width = 125;
            // 
            // codeEtat
            // 
            this.codeEtat.HeaderText = "Code état";
            this.codeEtat.Name = "codeEtat";
            this.codeEtat.ReadOnly = true;
            this.codeEtat.Visible = false;
            // 
            // lbl_peseur_lotspeche_lotsbateau
            // 
            this.lbl_peseur_lotspeche_lotsbateau.AutoSize = true;
            this.lbl_peseur_lotspeche_lotsbateau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peseur_lotspeche_lotsbateau.Location = new System.Drawing.Point(23, 110);
            this.lbl_peseur_lotspeche_lotsbateau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_peseur_lotspeche_lotsbateau.Name = "lbl_peseur_lotspeche_lotsbateau";
            this.lbl_peseur_lotspeche_lotsbateau.Size = new System.Drawing.Size(159, 24);
            this.lbl_peseur_lotspeche_lotsbateau.TabIndex = 13;
            this.lbl_peseur_lotspeche_lotsbateau.Text = "Lots de la pêche :";
            this.lbl_peseur_lotspeche_lotsbateau.Visible = false;
            // 
            // cbx_peseur_lotspeche_listebateaux
            // 
            this.cbx_peseur_lotspeche_listebateaux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_peseur_lotspeche_listebateaux.DropDownWidth = 150;
            this.cbx_peseur_lotspeche_listebateaux.FormattingEnabled = true;
            this.cbx_peseur_lotspeche_listebateaux.Location = new System.Drawing.Point(202, 71);
            this.cbx_peseur_lotspeche_listebateaux.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_peseur_lotspeche_listebateaux.Name = "cbx_peseur_lotspeche_listebateaux";
            this.cbx_peseur_lotspeche_listebateaux.Size = new System.Drawing.Size(150, 21);
            this.cbx_peseur_lotspeche_listebateaux.TabIndex = 12;
            this.cbx_peseur_lotspeche_listebateaux.Visible = false;
            this.cbx_peseur_lotspeche_listebateaux.SelectionChangeCommitted += new System.EventHandler(this.cbx_peseur_lotspeche_listebateaux_SelectionChangeCommitted);
            // 
            // lbl_peseur_lotspeche_choixbateau
            // 
            this.lbl_peseur_lotspeche_choixbateau.AutoSize = true;
            this.lbl_peseur_lotspeche_choixbateau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peseur_lotspeche_choixbateau.Location = new System.Drawing.Point(37, 71);
            this.lbl_peseur_lotspeche_choixbateau.Name = "lbl_peseur_lotspeche_choixbateau";
            this.lbl_peseur_lotspeche_choixbateau.Size = new System.Drawing.Size(131, 18);
            this.lbl_peseur_lotspeche_choixbateau.TabIndex = 2;
            this.lbl_peseur_lotspeche_choixbateau.Text = "Choisir un bateau :";
            // 
            // lbl_peseur_lotspeche_title
            // 
            this.lbl_peseur_lotspeche_title.AutoSize = true;
            this.lbl_peseur_lotspeche_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peseur_lotspeche_title.Location = new System.Drawing.Point(276, 23);
            this.lbl_peseur_lotspeche_title.Name = "lbl_peseur_lotspeche_title";
            this.lbl_peseur_lotspeche_title.Size = new System.Drawing.Size(168, 29);
            this.lbl_peseur_lotspeche_title.TabIndex = 0;
            this.lbl_peseur_lotspeche_title.Text = "Liste des lots";
            // 
            // lbl_peseur_lotspeche_ispeche
            // 
            this.lbl_peseur_lotspeche_ispeche.AutoSize = true;
            this.lbl_peseur_lotspeche_ispeche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peseur_lotspeche_ispeche.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_peseur_lotspeche_ispeche.Location = new System.Drawing.Point(56, 163);
            this.lbl_peseur_lotspeche_ispeche.Name = "lbl_peseur_lotspeche_ispeche";
            this.lbl_peseur_lotspeche_ispeche.Size = new System.Drawing.Size(541, 18);
            this.lbl_peseur_lotspeche_ispeche.TabIndex = 23;
            this.lbl_peseur_lotspeche_ispeche.Text = "Il n\'y a aucune pêche enregistrée pour ce jour, veuillez contacter le réceptionni" +
    "ste.";
            // 
            // lbl_peseur_datejour
            // 
            this.lbl_peseur_datejour.AutoSize = true;
            this.lbl_peseur_datejour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peseur_datejour.Location = new System.Drawing.Point(578, 563);
            this.lbl_peseur_datejour.Name = "lbl_peseur_datejour";
            this.lbl_peseur_datejour.Size = new System.Drawing.Size(172, 18);
            this.lbl_peseur_datejour.TabIndex = 1;
            this.lbl_peseur_datejour.Text = "Date du jour : 23/10/2021";
            // 
            // pbx_peseur_deconnexion
            // 
            this.pbx_peseur_deconnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_peseur_deconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_peseur_deconnexion.Image = global::AppCriée.Properties.Resources.computer_icons_login_icon_design_exit_5abfc840bf8ca4_9038982415225180807846;
            this.pbx_peseur_deconnexion.Location = new System.Drawing.Point(764, 557);
            this.pbx_peseur_deconnexion.Margin = new System.Windows.Forms.Padding(2);
            this.pbx_peseur_deconnexion.Name = "pbx_peseur_deconnexion";
            this.pbx_peseur_deconnexion.Size = new System.Drawing.Size(34, 37);
            this.pbx_peseur_deconnexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_peseur_deconnexion.TabIndex = 2;
            this.pbx_peseur_deconnexion.TabStop = false;
            this.pbx_peseur_deconnexion.Click += new System.EventHandler(this.pbx_peseur_deconnexion_Click);
            // 
            // AppCriee_Peseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 598);
            this.Controls.Add(this.pbx_peseur_deconnexion);
            this.Controls.Add(this.tbc_peseur);
            this.Controls.Add(this.lbl_peseur_datejour);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1105, 783);
            this.MinimumSize = new System.Drawing.Size(1105, 783);
            this.Name = "AppCriee_Peseur";
            this.Text = "AppCriée (Peseur)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppCriee_Peseur_FormClosing);
            this.tbc_peseur.ResumeLayout(false);
            this.tbp_peseur_accueil.ResumeLayout(false);
            this.tbp_peseur_accueil.PerformLayout();
            this.tbp_peseur_lotspeche.ResumeLayout(false);
            this.tbp_peseur_lotspeche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_peseur_lotspeche_bacs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_peseur_lotspeche_lotsbateau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_peseur_deconnexion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_peseur_accueil_bienvenue;
        private System.Windows.Forms.Label lbl_peseur_accueil_role;
        private System.Windows.Forms.TabControl tbc_peseur;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tbp_peseur_accueil;
        private System.Windows.Forms.TabPage tbp_peseur_lotspeche;
        private System.Windows.Forms.Label lbl_peseur_lotspeche_title;
        private System.Windows.Forms.Label lbl_peseur_datejour;
        private System.Windows.Forms.Label lbl_peseur_lotspeche_choixbateau;
        private System.Windows.Forms.ComboBox cbx_peseur_lotspeche_listebateaux;
        private System.Windows.Forms.Label lbl_peseur_lotspeche_lotsbateau;
        private System.Windows.Forms.DataGridView dg_peseur_lotspeche_lotsbateau;
        private System.Windows.Forms.Label lbl_peseur_lotspeche_ispeche;
        private System.Windows.Forms.Label lbl_peseur_lotspeche_islots;
        private System.Windows.Forms.Label lbl_peseur_lotspeche_info;
        private System.Windows.Forms.DataGridView dg_peseur_lotspeche_bacs;
        private System.Windows.Forms.Label lbl_peseur_lotspeche_bacdulot;
        private System.Windows.Forms.TextBox tbx_peseur_lotspeche_saisirpoids;
        private System.Windows.Forms.Label lbl_peseur_lotspeche_saisirpoids;
        private System.Windows.Forms.Button btn_peseur_lotspeche_saisirpoids;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label lbl_peseur_lotspeche_validationok;
        private System.Windows.Forms.Button btn_peseur_lotspeche_validersaisiepoids;
        private System.Windows.Forms.PictureBox pbx_peseur_deconnexion;
        private System.Windows.Forms.Label lbl_peseur_lotspeche_validation;
        private System.Windows.Forms.RadioButton rbtn_peseur_lotspeche_lotbloque;
        private System.Windows.Forms.RadioButton rbtn_peseur_lotspeche_lotnonbloque;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn poidstotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeEtat;
    }
}