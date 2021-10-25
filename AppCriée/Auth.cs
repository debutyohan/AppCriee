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
        string chaineConnexion = ConnectionChain.chaineConnexion();
        public AppCriee()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String passwdhash = new HashData(tbx_auth_passwd.Text).HashCalculate();
            CURS cs = new CURS(chaineConnexion);
            if (!cs.isConnectionOK())
            {
                return;
            }
            cs.ReqSelectPrepare("SELECT count(utilisateur.id) as nbUser, utilisateur.id as iduser, login, nomuser, prenomuser, idtypeuser, libelle FROM utilisateur INNER JOIN typeutilisateur ON utilisateur.idtypeuser = typeutilisateur.id WHERE login=?unlogin AND pwd=?unpassword",new List<string> {"unlogin","unpassword"}, new List<object> { tbx_auth_id.Text.ToString(), passwdhash });
            string nbUser = cs.champ("nbUser").ToString();
            
            if (nbUser == "1")
            {
                User UserConnecte = new User(Int32.Parse(cs.champ("iduser").ToString()), cs.champ("login").ToString(), cs.champ("nomuser").ToString(), cs.champ("prenomuser").ToString(), Int32.Parse(cs.champ("idtypeuser").ToString()), cs.champ("libelle").ToString());
                switch (UserConnecte.Type)
                {
                    case 3:
                        AppCriee_Receptionniste f = new AppCriee_Receptionniste(UserConnecte);
                        f.Show();
                        this.Hide();
                        break;
                    case 2:
                        AppCriee_Veterinaire g = new AppCriee_Veterinaire(UserConnecte);
                        g.Show();
                        this.Hide();
                        break;
                    case 1:
                        AppCriee_Peseur p = new AppCriee_Peseur(UserConnecte);
                        p.Show();
                        this.Hide();
                        break;
                }
            }
            else
            {
                lbl_auth_falseidpasswd.Visible = true;
                tbx_auth_id.Text = "";
                tbx_auth_passwd.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chx_auth_showchar.Checked)
                tbx_auth_passwd.UseSystemPasswordChar = false;
            else
                tbx_auth_passwd.UseSystemPasswordChar = true;
        }

        private void AppCriee_KeyUp(object sender, KeyEventArgs e)
        {
            int keyvalue = e.KeyValue;
            keyvalue = keyvalue;
        }

        private void AppCriee_Enter(object sender, EventArgs e)
        {
            string test = "e";
        }
    }
}
