
namespace AppCriée
{
    partial class AppCriee_DemandeCreationCompte
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
            this.lbl_recupmotdepasse_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_recupmotdepasse_title
            // 
            this.lbl_recupmotdepasse_title.AutoSize = true;
            this.lbl_recupmotdepasse_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recupmotdepasse_title.Location = new System.Drawing.Point(75, 27);
            this.lbl_recupmotdepasse_title.Name = "lbl_recupmotdepasse_title";
            this.lbl_recupmotdepasse_title.Size = new System.Drawing.Size(582, 32);
            this.lbl_recupmotdepasse_title.TabIndex = 10;
            this.lbl_recupmotdepasse_title.Text = "DEMANDE DE CREATION D\'UN COMPTE";
            // 
            // AppCriee_DemandeCreationCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 590);
            this.Controls.Add(this.lbl_recupmotdepasse_title);
            this.MaximumSize = new System.Drawing.Size(774, 637);
            this.MinimumSize = new System.Drawing.Size(774, 637);
            this.Name = "AppCriee_DemandeCreationCompte";
            this.Text = "AppCriée (Demande de Création d\'un Compte)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_recupmotdepasse_title;
    }
}