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
            this.dg_peseur_lotspeche_lotsbateau = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_peseur_lotspeche_lotsbateau = new System.Windows.Forms.Label();
            this.cbx_peseur_lotspeche_listebateaux = new System.Windows.Forms.ComboBox();
            this.lbl_peseur_lotspeche_choixbateau = new System.Windows.Forms.Label();
            this.lbl_peseur_lotspeche_datejour = new System.Windows.Forms.Label();
            this.lbl_peseur_lotspeche_title = new System.Windows.Forms.Label();
            this.lbl_peseur_lotspeche_ispeche = new System.Windows.Forms.Label();
            this.lbl_peseur_lotspeche_islots = new System.Windows.Forms.Label();
            this.tbc_peseur.SuspendLayout();
            this.tbp_peseur_accueil.SuspendLayout();
            this.tbp_peseur_lotspeche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_peseur_lotspeche_lotsbateau)).BeginInit();
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
            this.tbc_peseur.Size = new System.Drawing.Size(812, 559);
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
            this.tbp_peseur_accueil.Size = new System.Drawing.Size(804, 533);
            this.tbp_peseur_accueil.TabIndex = 0;
            this.tbp_peseur_accueil.Text = "Accueil";
            this.tbp_peseur_accueil.UseVisualStyleBackColor = true;
            // 
            // tbp_peseur_lotspeche
            // 
            this.tbp_peseur_lotspeche.Controls.Add(this.lbl_peseur_lotspeche_islots);
            this.tbp_peseur_lotspeche.Controls.Add(this.dg_peseur_lotspeche_lotsbateau);
            this.tbp_peseur_lotspeche.Controls.Add(this.lbl_peseur_lotspeche_lotsbateau);
            this.tbp_peseur_lotspeche.Controls.Add(this.cbx_peseur_lotspeche_listebateaux);
            this.tbp_peseur_lotspeche.Controls.Add(this.lbl_peseur_lotspeche_choixbateau);
            this.tbp_peseur_lotspeche.Controls.Add(this.lbl_peseur_lotspeche_datejour);
            this.tbp_peseur_lotspeche.Controls.Add(this.lbl_peseur_lotspeche_title);
            this.tbp_peseur_lotspeche.Controls.Add(this.lbl_peseur_lotspeche_ispeche);
            this.tbp_peseur_lotspeche.Location = new System.Drawing.Point(4, 22);
            this.tbp_peseur_lotspeche.Name = "tbp_peseur_lotspeche";
            this.tbp_peseur_lotspeche.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_peseur_lotspeche.Size = new System.Drawing.Size(804, 533);
            this.tbp_peseur_lotspeche.TabIndex = 1;
            this.tbp_peseur_lotspeche.Text = "Lots de pêche";
            this.tbp_peseur_lotspeche.UseVisualStyleBackColor = true;
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
            this.dataGridViewTextBoxColumn6});
            this.dg_peseur_lotspeche_lotsbateau.GridColor = System.Drawing.SystemColors.Control;
            this.dg_peseur_lotspeche_lotsbateau.Location = new System.Drawing.Point(27, 144);
            this.dg_peseur_lotspeche_lotsbateau.Margin = new System.Windows.Forms.Padding(2);
            this.dg_peseur_lotspeche_lotsbateau.Name = "dg_peseur_lotspeche_lotsbateau";
            this.dg_peseur_lotspeche_lotsbateau.ReadOnly = true;
            this.dg_peseur_lotspeche_lotsbateau.RowHeadersWidth = 10;
            this.dg_peseur_lotspeche_lotsbateau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_peseur_lotspeche_lotsbateau.Size = new System.Drawing.Size(494, 125);
            this.dg_peseur_lotspeche_lotsbateau.TabIndex = 22;
            this.dg_peseur_lotspeche_lotsbateau.Visible = false;
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
            // lbl_peseur_lotspeche_lotsbateau
            // 
            this.lbl_peseur_lotspeche_lotsbateau.AutoSize = true;
            this.lbl_peseur_lotspeche_lotsbateau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peseur_lotspeche_lotsbateau.Location = new System.Drawing.Point(23, 110);
            this.lbl_peseur_lotspeche_lotsbateau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_peseur_lotspeche_lotsbateau.Name = "lbl_peseur_lotspeche_lotsbateau";
            this.lbl_peseur_lotspeche_lotsbateau.Size = new System.Drawing.Size(276, 24);
            this.lbl_peseur_lotspeche_lotsbateau.TabIndex = 13;
            this.lbl_peseur_lotspeche_lotsbateau.Text = "Liste de tous les lots du bateau :";
            this.lbl_peseur_lotspeche_lotsbateau.Visible = false;
            // 
            // cbx_peseur_lotspeche_listebateaux
            // 
            this.cbx_peseur_lotspeche_listebateaux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_peseur_lotspeche_listebateaux.DropDownWidth = 150;
            this.cbx_peseur_lotspeche_listebateaux.FormattingEnabled = true;
            this.cbx_peseur_lotspeche_listebateaux.Location = new System.Drawing.Point(442, 71);
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
            this.lbl_peseur_lotspeche_choixbateau.Location = new System.Drawing.Point(300, 69);
            this.lbl_peseur_lotspeche_choixbateau.Name = "lbl_peseur_lotspeche_choixbateau";
            this.lbl_peseur_lotspeche_choixbateau.Size = new System.Drawing.Size(131, 18);
            this.lbl_peseur_lotspeche_choixbateau.TabIndex = 2;
            this.lbl_peseur_lotspeche_choixbateau.Text = "Choisir un bateau :";
            // 
            // lbl_peseur_lotspeche_datejour
            // 
            this.lbl_peseur_lotspeche_datejour.AutoSize = true;
            this.lbl_peseur_lotspeche_datejour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peseur_lotspeche_datejour.Location = new System.Drawing.Point(78, 69);
            this.lbl_peseur_lotspeche_datejour.Name = "lbl_peseur_lotspeche_datejour";
            this.lbl_peseur_lotspeche_datejour.Size = new System.Drawing.Size(172, 18);
            this.lbl_peseur_lotspeche_datejour.TabIndex = 1;
            this.lbl_peseur_lotspeche_datejour.Text = "Date du jour : 23/10/2021";
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
            // lbl_peseur_lotspeche_islots
            // 
            this.lbl_peseur_lotspeche_islots.AutoSize = true;
            this.lbl_peseur_lotspeche_islots.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peseur_lotspeche_islots.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_peseur_lotspeche_islots.Location = new System.Drawing.Point(44, 179);
            this.lbl_peseur_lotspeche_islots.Name = "lbl_peseur_lotspeche_islots";
            this.lbl_peseur_lotspeche_islots.Size = new System.Drawing.Size(275, 18);
            this.lbl_peseur_lotspeche_islots.TabIndex = 24;
            this.lbl_peseur_lotspeche_islots.Text = "Pas encore de lots créés pour ce bateau";
            this.lbl_peseur_lotspeche_islots.Visible = false;
            // 
            // AppCriee_Peseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 563);
            this.Controls.Add(this.tbc_peseur);
            this.Name = "AppCriee_Peseur";
            this.Text = "AppCriée (Peseur)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppCriee_Peseur_FormClosing);
            this.tbc_peseur.ResumeLayout(false);
            this.tbp_peseur_accueil.ResumeLayout(false);
            this.tbp_peseur_accueil.PerformLayout();
            this.tbp_peseur_lotspeche.ResumeLayout(false);
            this.tbp_peseur_lotspeche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_peseur_lotspeche_lotsbateau)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lbl_peseur_lotspeche_datejour;
        private System.Windows.Forms.Label lbl_peseur_lotspeche_choixbateau;
        private System.Windows.Forms.ComboBox cbx_peseur_lotspeche_listebateaux;
        private System.Windows.Forms.Label lbl_peseur_lotspeche_lotsbateau;
        private System.Windows.Forms.DataGridView dg_peseur_lotspeche_lotsbateau;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lbl_peseur_lotspeche_ispeche;
        private System.Windows.Forms.Label lbl_peseur_lotspeche_islots;
    }
}