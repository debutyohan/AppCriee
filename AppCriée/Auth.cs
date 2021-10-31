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
        #region Données privées
        string chaineConnexion = ConnectionChain.chaineConnexion();
        #endregion

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
            CURS cs = new CURS(chaineConnexion);

            if (!cs.isConnectionOK())
            {
                return;
            }

            cs.ReqSelectPrepare("SELECT count(utilisateur.id) as nbUser, utilisateur.id as iduser, login, nomuser, prenomuser, idtypeuser, libelle FROM utilisateur INNER JOIN typeutilisateur ON utilisateur.idtypeuser = typeutilisateur.id WHERE login=? AND pwd=?", new List<object> { tbx_auth_id.Text.ToString(), passwdhash });
            
            tbx_auth_id.Text = "";
            tbx_auth_passwd.Text = "";

            if (cs.champ("nbUser").ToString() == "1")
            {
                lbl_auth_falseidpasswd.Hide();
                User UserConnecte = new User(Int32.Parse(cs.champ("iduser").ToString()), cs.champ("login").ToString(), cs.champ("nomuser").ToString(), cs.champ("prenomuser").ToString(), Int32.Parse(cs.champ("idtypeuser").ToString()), cs.champ("libelle").ToString());
                
                switch (UserConnecte.Type)
                {
                    case 3:
                        AppCriee_Receptionniste f = new AppCriee_Receptionniste(UserConnecte, this);
                        f.Show();
                        this.Hide();
                        break;
                    case 2:
                        AppCriee_Veterinaire g = new AppCriee_Veterinaire(UserConnecte, this);
                        g.Show();
                        this.Hide();
                        break;
                    case 1:
                        AppCriee_Peseur p = new AppCriee_Peseur(UserConnecte, this);
                        p.Show();
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

    }
}
