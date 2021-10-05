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
            lbl_ajoutpeche_datejour.Text = "Date du jour : " + Datejour;
            HiddenObject.Hide(new List<Control> { lbl_pechejour_allpeche, dg_pechejour, lbl_ajoutpeche_creerpeche_nombateau, cbx_ajoutpeche_creerpeche_nombateau, btn_pechejour_creerpeche_valider, lbl_pechejour_pecheok });
        }

        private void btn_ajoutpeche_creerpeche_Click(object sender, EventArgs e)
        {
            HiddenObject.Show(new List<Control> {lbl_ajoutpeche_creerpeche_nombateau, cbx_ajoutpeche_creerpeche_nombateau, btn_pechejour_creerpeche_valider });
            btn_ajoutpeche_creerpeche.Hide();
            lbl_pechejour_pecheok.Hide();
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

        private void btn_pechejour_creerpeche_valider_Click(object sender, EventArgs e)
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
            lbl_pechejour_pecheok.Text = "La peche de ce jour du bateau " + elmt_bateau + " a bien été crée";
            lbl_pechejour_pecheok.Show();
            lbl_ajoutpeche_ispeche.Hide();
            dg_pechejour.Show();
        }

        private void tbc_receptionniste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbc_receptionniste.SelectedTab == tabPeche)
            {
                CURS cs = new CURS(ChaineConnexion);
                cs.ReqSelect("SELECT count(id) as nbnotpeche FROM bateau WHERE id NOT IN(SELECT DISTINCT idBateau FROM peche WHERE datePeche='" + Datejour + "')");
                if (cs.champ("nbnotpeche").ToString() == "0")
                {
                    lbl_pechejour_allpeche.Show();
                    HiddenObject.Hide(new List<Control> {lbl_ajoutpeche_explication, lbl_ajoutpeche_explication2, btn_ajoutpeche_creerpeche});
                }
                cs.fermer();
                cs = new CURS(ChaineConnexion);
                lbl_ajoutpeche_datejour.Text = "Date du jour : " + Datejour;
                string requete = "SELECT idBateau, nom, immatriculation FROM peche INNER JOIN Bateau ON peche.idBateau=Bateau.id WHERE DatePeche='" + Datejour + "'";
                cs.ReqSelect(requete);
                if (!(cs.champ("idBateau") is null))
                {

                    lbl_ajoutpeche_ispeche.Hide();
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
            }

        private void AppCriee_Receptionniste_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
 
}
