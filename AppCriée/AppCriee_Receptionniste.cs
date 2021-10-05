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
    public partial class AppCriee_Receptionniste : Form
    {
        string chaineConnexion;
        public string ChaineConnexion
        {
            get { return chaineConnexion; }
            set { chaineConnexion = value; }
        }
        string Datejour = DateTime.Today.ToString("yyyy-MM-dd");

        public AppCriee_Receptionniste(User unutilisateur)
        {
            ChaineConnexion = "server = 127.0.0.1; user id = gestionCrie; password = 123xaro08 ; database = bddCrie2";
            InitializeComponent();
            lbl_accueil_bienvenue.Text = "Bienvenue "+ unutilisateur.Nom+" "+unutilisateur.Prenom;
            lbl_accueil_role.Text = "Rôle : " + unutilisateur.Libelletype;
            HiddenObject.Hide(new List<Control> { lbl_error_connection, lbl_ajoutpeche_ispeche, lbl_ajoutpeche_datejour, lbl_title, dg_pechejour, lbl_ajoutpeche_explication, lbl_ajoutpeche_explication2 });
            lbl_ajoutpeche_creerpeche_nombateau.Hide();
            cbx_ajoutpeche_creerpeche_nombateau.Hide();
            btn_pechejour_creerpeche_valider.Hide();
            label1.Hide();
        }
        private void tabPeche_Click(object sender, EventArgs e)
        {
            
            


        }

        private void AppCriee_Receptionniste_Load(object sender, EventArgs e)
        {

        }

        private void tabAccueil_Click(object sender, EventArgs e)
        {
   
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabPeche)
            {
                btn_ajoutpeche_creerpeche.Hide();
                lbl_ajoutpeche_creerpeche_nombateau.Hide();
                cbx_ajoutpeche_creerpeche_nombateau.Hide();
                btn_pechejour_creerpeche_valider.Hide();
                label1.Hide();               
                lbl_ajoutpeche_ispeche.Hide();
                dg_pechejour.Hide();
                lbl_error_connection.Hide();
                try
                {
                    CURS cs = new CURS(ChaineConnexion);
                    lbl_ajoutpeche_datejour.Show();
                    lbl_title.Show();
                    lbl_ajoutpeche_explication.Show();
                    lbl_ajoutpeche_explication2.Show();
                    btn_ajoutpeche_creerpeche.Show();
                    lbl_ajoutpeche_datejour.Text = "Date du jour : " + Datejour;
                    string requete = "SELECT idBateau, nom, immatriculation FROM peche INNER JOIN Bateau ON peche.idBateau=Bateau.id WHERE DatePeche='" + Datejour + "'";
                    cs.ReqSelect(requete);
                    if (cs.champ("idBateau") is null)
                    {
                        lbl_ajoutpeche_ispeche.Show();
                        lbl_ajoutpeche_ispeche.Text = "Pas de Pêche ce jour";
                    }
                    else
                    {
                        lbl_ajoutpeche_ispeche.Text = "";
                        dg_pechejour.Rows.Clear();
                        while (!cs.Fin())
                        {
                            dg_pechejour.Rows.Add(cs.champ("nom"), cs.champ("immatriculation"));
                            cs.suivant();
                        }
                        dg_pechejour.Show();
                    }
                    cs.fermer();
                }
                catch
                {
                    lbl_error_connection.Show();
                    lbl_ajoutpeche_datejour.Hide();
                    lbl_title.Hide();
                    lbl_ajoutpeche_explication.Hide();
                    lbl_ajoutpeche_explication2.Hide();
                    btn_ajoutpeche_creerpeche.Hide();

                }
            }


        }

        private void btn_ajoutpeche_creerpeche_Click_1(object sender, EventArgs e)
        {
            lbl_ajoutpeche_creerpeche_nombateau.Show();
            btn_ajoutpeche_creerpeche.Hide();
            cbx_ajoutpeche_creerpeche_nombateau.Show();
            btn_pechejour_creerpeche_valider.Show();
            label1.Hide();
            cbx_ajoutpeche_creerpeche_nombateau.Items.Clear();
            CURS cs = new CURS(ChaineConnexion);
            string requete = "SELECT id, nom, immatriculation FROM bateau WHERE id NOT IN(SELECT DISTINCT idBateau FROM peche WHERE datePeche='" + Datejour + "')";
            cs.ReqSelect(requete);
            while (!cs.Fin())
            {
                cbx_ajoutpeche_creerpeche_nombateau.Items.Add(cs.champ("nom") + "(" + cs.champ("immatriculation") + ")");
                cs.suivant();
            }
            cbx_ajoutpeche_creerpeche_nombateau.SelectedItem = cbx_ajoutpeche_creerpeche_nombateau.Items[0];
            cs.fermer();
        }

        private void btn_pechejour_creerpeche_valider_Click_1(object sender, EventArgs e)
        {
            String elmt_bateau = cbx_ajoutpeche_creerpeche_nombateau.SelectedItem.ToString();
            int char_bateau = elmt_bateau.IndexOf("(");
            string nomBateau = elmt_bateau.Substring(0, char_bateau);
            String imma = elmt_bateau.Substring(char_bateau + 1, elmt_bateau.Length - char_bateau - 2);
            CURS cs = new CURS(ChaineConnexion);
            string requete = "INSERT INTO Peche(DatePeche, idBateau) VALUES ('" + Datejour + "',(SELECT id FROM Bateau WHERE immatriculation = '" + imma + "'))";
            cs.ReqAdmin(requete);
            cs.fermer();
            lbl_ajoutpeche_creerpeche_nombateau.Hide();
            cbx_ajoutpeche_creerpeche_nombateau.Hide();
            btn_pechejour_creerpeche_valider.Hide();
            dg_pechejour.Rows.Add(nomBateau, imma);
            btn_ajoutpeche_creerpeche.Show();
            label1.Text = "La peche de ce jour du bateau " + elmt_bateau + " a bien été crée";
            label1.Show();
            lbl_ajoutpeche_ispeche.Hide();
            dg_pechejour.Show();
        }
    }
}
