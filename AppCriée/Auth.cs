using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCriée
{
    public partial class AppCriee : Form
    {
        #region Constructeur
        public AppCriee()
        {
            InitializeComponent();
        }
        #endregion

        #region Procédure évènement

        private void btn_auth_connexion_Click(object sender, EventArgs e)
        {
            String passwdhash = new HashData(tbx_auth_passwd.Text).HashCalculate();
            CURS cs = new CURS();

            if (!cs.isConnectionOK())
            {
                return;
            }

            cs.ReqSelectPrepare("CALL Auth(?,?)", new List<object> { tbx_auth_id.Text.ToString(), passwdhash });
            
            tbx_auth_id.Text = "";
            tbx_auth_passwd.Text = "";

            if (cs.champ("nbUser").ToString() == "1")
            {
                lbl_auth_falseidpasswd.Hide();
                User UserConnecte = new User(Int32.Parse(cs.champ("iduser").ToString()), cs.champ("login").ToString(), cs.champ("nomuser").ToString(), cs.champ("prenomuser").ToString(), Int32.Parse(cs.champ("idtypeuser").ToString()), cs.champ("libelle").ToString(), cs.champ("adrMail").ToString()); ;
                
                switch (UserConnecte.Type)
                {
                    case 0:
                        AppCriee_Administrateur form_administrateur = new AppCriee_Administrateur(UserConnecte, this);
                        form_administrateur.Show();
                        this.Hide();
                        break;
                    case 1:
                        AppCriee_Peseur form_peseur = new AppCriee_Peseur(UserConnecte, this);
                        form_peseur.Show();
                        this.Hide();
                        break;
                    case 2:
                        AppCriee_Veterinaire form_veterinaire = new AppCriee_Veterinaire(UserConnecte, this);
                        form_veterinaire.Show();
                        this.Hide();
                        break;
                    case 3:
                        AppCriee_Receptionniste form_receptionniste = new AppCriee_Receptionniste(UserConnecte, this);
                        form_receptionniste.Show();
                        this.Hide();
                        break;
                    case 4:
                        AppCriee_DirecteurDesVentes form_directeurdesventes = new AppCriee_DirecteurDesVentes(UserConnecte, this);
                        form_directeurdesventes.Show();
                        this.Hide();
                        break;
                }
            }
            else
            {
                lbl_auth_falseidpasswd.Show();
            }

            cs.fermer();

        }
        private void btn_auth_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void chx_auth_showchar_CheckedChanged(object sender, EventArgs e)
        {
            if (chx_auth_showchar.Checked)
                tbx_auth_passwd.UseSystemPasswordChar = false;
            else
                tbx_auth_passwd.UseSystemPasswordChar = true;
        }

        #endregion


        private void lbl_auth_oublimotdepasse_Click(object sender, EventArgs e)
        {
            AppCriee_RecupMotdePasse form_recupmotdepasse = new AppCriee_RecupMotdePasse(this);
            form_recupmotdepasse.Show();
            this.Hide();
        }
    }
}
