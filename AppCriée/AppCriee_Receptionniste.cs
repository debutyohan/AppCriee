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
        string chaineConnexion = ConnectionChain.chaineConnexion();
        string Datejour = DateTime.Today.ToString("yyyy-MM-dd");

        public AppCriee_Receptionniste(User unutilisateur)
        {
            InitializeComponent();
            lbl_accueil_bienvenue.Text = "Bienvenue " + unutilisateur.Nom + " " + unutilisateur.Prenom;
            HiddenObject.Hide(new List<Control> { lbl_pechejour_allpeche, dg_pechejour, lbl_ajoutpeche_creerpeche_nombateau, cbx_ajoutpeche_creerpeche_nombateau, btn_pechejour_creerpeche_valider, lbl_pechejour_pecheok });
        }

        private void btn_ajoutpeche_creerpeche_Click(object sender, EventArgs e)
        {
            HiddenObject.Show(new List<Control> {lbl_ajoutpeche_creerpeche_nombateau, cbx_ajoutpeche_creerpeche_nombateau, btn_pechejour_creerpeche_valider });
            btn_ajoutpeche_creerpeche.Hide();
            lbl_pechejour_pecheok.Hide();
            btn_receptionniste_peche_supprimer.Show();
            CompleteControl.RemplirCombobox(cbx_ajoutpeche_creerpeche_nombateau, "SELECT id, nom, immatriculation FROM bateau WHERE id NOT IN(SELECT DISTINCT idBateau FROM peche WHERE datePeche='" + Datejour + "')", "nom(immatriculation)");
        }

        private void btn_pechejour_creerpeche_valider_Click(object sender, EventArgs e)
        {
            String elmt_bateau = cbx_ajoutpeche_creerpeche_nombateau.SelectedItem.ToString();
            int char_bateau = elmt_bateau.IndexOf("(");
            string nomBateau = elmt_bateau.Substring(0, char_bateau);
            String imma = elmt_bateau.Substring(char_bateau + 1, elmt_bateau.Length - char_bateau - 2);
            CURS cs = new CURS(chaineConnexion);
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
                CURS cs = new CURS(chaineConnexion);
                cs.ReqSelect("SELECT count(id) as nbnotpeche FROM bateau WHERE id NOT IN(SELECT DISTINCT idBateau FROM peche WHERE datePeche='" + Datejour + "')");
                if (cs.champ("nbnotpeche").ToString() == "0")
                {
                    lbl_pechejour_allpeche.Show();
                    HiddenObject.Hide(new List<Control> {lbl_ajoutpeche_explication, lbl_ajoutpeche_explication2, btn_ajoutpeche_creerpeche});
                }
                cs.fermer();
                if (CompleteControl.RemplirDataGridViewByRequest(dg_pechejour, "SELECT idBateau, nom, immatriculation FROM peche INNER JOIN Bateau ON peche.idBateau=Bateau.id WHERE DatePeche='" + Datejour + "'", new string[] { "nom", "immatriculation" }))
                {
                    HiddenObject.Hide(new List<Control> { lbl_ajoutpeche_ispeche, btn_receptionniste_peche_supprimer });
                    HiddenObject.Show(new List<Control> { dg_pechejour });
                }
                }
            }

        private void AppCriee_Receptionniste_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void btn_receptionniste_peche_supprimer_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dg_pechejour.SelectedRows)
            {             
                dg_pechejour.Rows.RemoveAt(item.Index);
                CURS cs = new CURS(chaineConnexion);
                // Faire requete pour récupérer l'id du bateau en fonction de l'immatriculation du bateau selectionné par la ligne;
                string requeteDel = "DELETE peche FROM peche INNER JOIN bateau ON peche.idBateau = bateau.id WHERE peche.datePeche ='" + Datejour + "'AND immatriculation='" + item.Cells[1].Value + "'";
                cs.ReqAdmin(requeteDel);

            }
        }
    }
 
}
