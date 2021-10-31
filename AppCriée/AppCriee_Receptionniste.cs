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
        #region Données privées
        string chaineConnexion = ConnectionChain.chaineConnexion();
        string Datejour = DateTime.Today.ToString("yyyy-MM-dd");
        AppCriee _authAccueil;
        #endregion

        #region Constructeur
        public AppCriee_Receptionniste(User unutilisateur, AppCriee authAccueil)
        {
            _authAccueil = authAccueil;
            InitializeComponent();
            lbl_accueil_bienvenue.Text = "Bienvenue " + unutilisateur.Nom + " " + unutilisateur.Prenom;
            lbl_receptionniste_datejour.Text = "Date du jour : " + DateTime.Today.ToString("dd/MM/yyyy");
            HiddenObject.Hide(new List<Control> { lbl_pechejour_allpeche, dg_pechejour, lbl_ajoutpeche_creerpeche_nombateau, cbx_ajoutpeche_creerpeche_nombateau, btn_pechejour_creerpeche_valider, lbl_pechejour_pecheok });
        }
        #endregion

        #region Changement d'onglet
        private void tbc_receptionniste_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_pechejour_pecheok.Hide();
            if (tbc_receptionniste.SelectedTab == tabPeche)
            {
                CURS cs = new CURS(chaineConnexion);
                cs.ReqSelectPrepare("SELECT count(id) as nbnotpeche FROM bateau WHERE id NOT IN(SELECT DISTINCT idBateau FROM peche WHERE datePeche=?)", new List<object> { Datejour });
                if (cs.champ("nbnotpeche").ToString() == "0")
                {
                    lbl_pechejour_allpeche.Show();
                    HiddenObject.Hide(new List<Control> { lbl_ajoutpeche_explication, lbl_ajoutpeche_explication2, btn_ajoutpeche_creerpeche });
                }
                cs.fermer();
                if (CompleteControl.RemplirDataGridViewByRequest(dg_pechejour, "SELECT idBateau, nom, immatriculation FROM peche INNER JOIN Bateau ON peche.idBateau=Bateau.id WHERE DatePeche=?", new string[] { "nom", "immatriculation" }, new List<object> { Datejour }))
                {
                    HiddenObject.Hide(new List<Control> { lbl_ajoutpeche_ispeche });
                    HiddenObject.Show(new List<Control> { dg_pechejour, btn_receptionniste_peche_supprimer });
                }else
                {
                    HiddenObject.Hide(new List<Control> { dg_pechejour, btn_receptionniste_peche_supprimer });
                }
            }
        }
        #endregion

        #region Onglet Créer une pêche
        private void btn_receptionniste_creerpeche_Click(object sender, EventArgs e)
        {
            HiddenObject.Show(new List<Control> {lbl_ajoutpeche_creerpeche_nombateau, cbx_ajoutpeche_creerpeche_nombateau, btn_pechejour_creerpeche_valider });
            btn_ajoutpeche_creerpeche.Hide();
            lbl_pechejour_pecheok.Hide();
            CompleteControl.RemplirCombobox(cbx_ajoutpeche_creerpeche_nombateau, "SELECT bateau.id, nom, immatriculation FROM peche RIGHT JOIN bateau ON peche.idBateau=Bateau.id  WHERE bateau.id NOT IN(SELECT DISTINCT idBateau FROM peche WHERE datePeche='" + Datejour + "') GROUP BY bateau.id ORDER BY count(*)*(NOT(ISNULL(peche.datePeche))) DESC", "nom(immatriculation)");
        }
        
        private void btn_receptionniste_creerpeche_valider_Click(object sender, EventArgs e)
        {
            String elmt_bateau = cbx_ajoutpeche_creerpeche_nombateau.SelectedItem.ToString();
            int char_bateau = elmt_bateau.IndexOf("(");
            string nomBateau = elmt_bateau.Substring(0, char_bateau);
            String imma = elmt_bateau.Substring(char_bateau + 1, elmt_bateau.Length - char_bateau - 2);
            CURS cs = new CURS(chaineConnexion);
            string requete = "INSERT INTO Peche(DatePeche, idBateau) VALUES ('" + Datejour + "',(SELECT id FROM Bateau WHERE immatriculation = '" + imma + "'))";
            cs.ReqAdmin(requete);
            cs.fermer();
            HiddenObject.Hide(new List<Control> { lbl_pechejour_allpeche, lbl_ajoutpeche_creerpeche_nombateau, cbx_ajoutpeche_creerpeche_nombateau, btn_pechejour_creerpeche_valider, lbl_ajoutpeche_ispeche });
            HiddenObject.Show(new List<Control> { btn_ajoutpeche_creerpeche, lbl_pechejour_pecheok, dg_pechejour, btn_receptionniste_peche_supprimer });
            dg_pechejour.Rows.Add(nomBateau, imma);
            lbl_pechejour_pecheok.Text = "La peche de ce jour du bateau " + elmt_bateau + " a bien été crée";
        }
        private void btn_receptionniste_creerpeche_supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer cette pêche ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string listImmaIsLot = "";
                string listImmaIsNoLot = "";
                foreach (DataGridViewRow item in dg_pechejour.SelectedRows)
                {
                    string requete = "SELECT COUNT(lot.id) as nbLot FROM lot INNER JOIN bateau ON lot.idBateau = bateau.id WHERE immatriculation='" + item.Cells[1].Value + "' AND idDatePeche='" + Datejour + "'";
                    CURS cs = new CURS(chaineConnexion);
                    cs.ReqSelect(requete);
                    string nbLot = cs.champ("nbLot").ToString();
                    if (cs.champ("nbLot").ToString() != "0")
                    {
                        listImmaIsLot += ", " + item.Cells[0].Value;
                    }
                    else
                    {
                        listImmaIsNoLot+=", " + item.Cells[0].Value;
                        dg_pechejour.Rows.RemoveAt(item.Index);
                        cs = new CURS(chaineConnexion);
                        string requeteDel = "DELETE peche FROM peche INNER JOIN bateau ON peche.idBateau = bateau.id WHERE peche.datePeche ='" + Datejour + "'AND immatriculation='" + item.Cells[1].Value + "'";
                        cs.ReqAdmin(requeteDel);
                    }
                    
                }
                if (listImmaIsLot != "")
                {
                    listImmaIsLot = listImmaIsLot.Substring(2, listImmaIsLot.Length - 2);
                    MessageBox.Show("Impossible de supprimer les pêches des bateaux : " + listImmaIsLot + " car elle comprend déjà des lots, veuillez contacter le vétérinaire.", "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbl_pechejour_pecheok.Hide();
                    if (listImmaIsNoLot != "")
                    {
                        listImmaIsNoLot = listImmaIsNoLot.Substring(2, listImmaIsNoLot.Length - 2);
                        lbl_pechejour_pecheok.Text = "Les pêches des bateaux : " + listImmaIsNoLot + " ont bien été supprimées";
                        lbl_pechejour_pecheok.Show();
                    }
                }
                else
                {

                    lbl_pechejour_pecheok.Text = "Toutes les pêches ont bien été supprimées";
                    lbl_pechejour_pecheok.Show();
                }
                if (dg_pechejour.Rows.Count == 0)
                {
                    dg_pechejour.Hide();
                    lbl_pechejour_allpeche.Show();
                    btn_receptionniste_peche_supprimer.Hide();
                }

            }
        }
        #endregion

        #region Fermeture du Formulaire
        private void AppCriee_Receptionniste_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirmez-vous la déconnexion ?", "Confirmation de déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                _authAccueil.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void pbx_receptionniste_deconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }

}
