using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCriée
{
    public partial class AppCriee_Peseur : Form
    {
        #region Données privées

        string Datejour = DateTime.Today.ToString("yyyy-MM-dd");
        int idLotisWeightModifing = -1;
        string idBacisWeightModifing = "";
        DataGridViewCellMouseEventArgs dernierclic;
        DataGridViewRow ligneselect;
        int idbateau;
        AppCriee _authAccueil;

        #endregion

        #region Constructeur
        public AppCriee_Peseur(User unutilisateur, AppCriee authAccueil)
        {
            InitializeComponent();
            _authAccueil = authAccueil;
            lbl_peseur_accueil_bienvenue.Text = "Bienvenue " + unutilisateur.Nom + " " + unutilisateur.Prenom;
            lbl_peseur_datejour.Text = "Date du jour : " + DateTime.Today.ToString("dd/MM/yyyy");
            HiddenObject.Hide(new List<Control> { lbl_peseur_lotspeche_choixbateau });
        }

        #endregion

        #region Changement d'onglet

        private void tbc_peseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_peseur_lotspeche_listebateaux.SelectedItem is null)
            {
                if (CompleteControl.RemplirCombobox(cbx_peseur_lotspeche_listebateaux, "SELECT idBateau, nom, immatriculation FROM peche INNER JOIN Bateau ON peche.idBateau=Bateau.id WHERE DatePeche=?", "nom(immatriculation)", new List<object> { Datejour }, false))
                {
                    HiddenObject.Hide(new List<Control> { lbl_peseur_lotspeche_ispeche });
                    HiddenObject.Show(new List<Control> { cbx_peseur_lotspeche_listebateaux, lbl_peseur_lotspeche_choixbateau });
                }
            }
            else
            {
                if (cbx_peseur_lotspeche_listebateaux.SelectedItem.ToString() != "")
                {
                    cbx_peseur_lotspeche_listebateaux_SelectionChangeCommitted(sender, e);
                }
            }
        }

        #endregion

        #region Onglet Lots de pêche

        private void cbx_peseur_lotspeche_listebateaux_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idLotisWeightModifing = -1;
            idBacisWeightModifing = "";
            HiddenObject.Show(new List<Control> { lbl_peseur_lotspeche_lotsbateau });
            HiddenObject.Hide(new List<Control> {lbl_peseur_lotspeche_info, lbl_peseur_lotspeche_info2 ,rbtn_peseur_lotspeche_lotnonbloque, rbtn_peseur_lotspeche_lotbloque, lbl_peseur_lotspeche_validation, lbl_peseur_lotspeche_saisirpoids, tbx_peseur_lotspeche_saisirpoids, lbl_peseur_lotspeche_validationok, btn_peseur_lotspeche_validersaisiepoids, dg_peseur_lotspeche_bacs, btn_peseur_lotspeche_saisirpoids, lbl_peseur_lotspeche_bacdulot });
            String elmt_bateau = cbx_peseur_lotspeche_listebateaux.Text;
            int char_bateau = elmt_bateau.IndexOf("(");
            String imma = elmt_bateau.Substring(char_bateau + 1, elmt_bateau.Length - char_bateau - 2);
            CURS cs = new CURS();
            cs.ReqSelectPrepare("SELECT id FROM bateau WHERE immatriculation ='" + imma + "'", new List<object> { imma });
            idbateau = Int32.Parse(cs.champ("id").ToString());
            lbl_peseur_lotspeche_lotsbateau.Text = "Liste de tous les lots du Bateau '" + elmt_bateau.Substring(0, char_bateau) + "' :";
            bool islots = CompleteControl.RemplirDataGridViewByRequest(dg_peseur_lotspeche_lotsbateau, "SELECT idLot, count(idLot) as nbbac, espece.nom as nomEspece, idTaille, idPresentation, idQualite, SUM(poidsbrutBac) as poidstotal, codeEtat FROM bac INNER JOIN lot ON bac.idDatePeche=lot.idDatePeche AND bac.idBateau=lot.idBateau AND bac.idLot=lot.id INNER JOIN espece ON espece.id=lot.idEspece INNER JOIN bateau ON bateau.id=lot.idBateau AND bateau.id=bac.idBateau WHERE bac.idDatePeche=? AND immatriculation=? GROUP BY idLot", new string[] { "idLot", "nomEspece", "idTaille", "idQualite", "idPresentation", "nbbac"  ,"poidstotal", "codeEtat"}, new List<object> {Datejour, imma });
            if (islots == true)
            {
                foreach(DataGridViewRow ligne in dg_peseur_lotspeche_lotsbateau.Rows)
                {
                    string numLotLot = ligne.Cells[0].Value.ToString();
                    string numLotBateau = idbateau.ToString();
                    if (Int32.Parse(numLotLot) < 100)
                    {
                        numLotLot = "0" + numLotLot;
                    }
                    if (Int32.Parse(numLotLot) < 10)
                    {
                        numLotLot = "0" + numLotLot;
                    }
                    if (Int32.Parse(numLotBateau) < 10)
                    {
                        numLotBateau = "0" + numLotBateau;
                    }
                    ligne.Cells[0].Value = numLotBateau + numLotLot;
                    if (ligne.Cells[7].Value.ToString().Trim() != "")
                    {
                        CompleteControl.griseligne(ligne);
                    }
                }
                lbl_peseur_lotspeche_islots.Hide();
                HiddenObject.Show(new List<Control> { dg_peseur_lotspeche_lotsbateau, lbl_peseur_lotspeche_info2 });
                dg_peseur_lotspeche_lotsbateau.SelectedRows[0].Selected = false;
            }
            else
            {
                HiddenObject.Hide(new List<Control> { dg_peseur_lotspeche_lotsbateau, lbl_peseur_lotspeche_lotsbateau,  });
                lbl_peseur_lotspeche_islots.Show();
            }
        }
        private void dg_peseur_lotspeche_lotsbateau_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dernierclic = e;
            HiddenObject.Hide(new List<Control> { rbtn_peseur_lotspeche_lotnonbloque, rbtn_peseur_lotspeche_lotbloque, lbl_peseur_lotspeche_validation ,lbl_peseur_lotspeche_saisirpoids, tbx_peseur_lotspeche_saisirpoids, lbl_peseur_lotspeche_validationok, btn_peseur_lotspeche_validersaisiepoids });
            if (dg_peseur_lotspeche_lotsbateau.SelectedRows.Count == 1)
            {
                DataGridViewRow ligneselectionne = dg_peseur_lotspeche_lotsbateau.SelectedRows[0];
                ligneselect = ligneselectionne;
                idLotisWeightModifing = Int32.Parse(ligneselectionne.Cells[0].Value.ToString().Substring(2, 3));
                CompleteControl.RemplirDataGridViewByRequest(dg_peseur_lotspeche_bacs, "SELECT bac.id as idBac, idTypeBac, tare, IF(ISNULL(poidsbrutBac)OR poidsbrutBac='0.00', 'Non saisie', poidsbrutBac) as poidsbrut FROM bac INNER JOIN typebac ON typebac.id=bac.idTypeBac WHERE idDatePeche=? AND idBateau=? AND idLot=? ORDER BY bac.id", new string[] { "idBac", "idTypeBac", "tare", "poidsbrut" }, new List<object> { Datejour, idbateau, idLotisWeightModifing });
                HiddenObject.Show(new List<Control> { dg_peseur_lotspeche_bacs, btn_peseur_lotspeche_saisirpoids, lbl_peseur_lotspeche_bacdulot, lbl_peseur_lotspeche_info });
                foreach (DataGridViewRow ligne in dg_peseur_lotspeche_bacs.Rows)
                {
                    string poidsBac = ligne.Cells[3].Value.ToString().ToLower();
                    if (poidsBac == "non saisie" || (int) Double.Parse(poidsBac.Replace('.', ',')) == 0)
                    {
                        return;
                    }
                }
                if (ligneselectionne.Cells[7].Value.ToString().Trim() == "")
                {
                    rbtn_peseur_lotspeche_lotnonbloque.Checked = true;
                }
                else
                {
                    rbtn_peseur_lotspeche_lotbloque.Checked = true;
                }

                HiddenObject.Show(new List<Control> { rbtn_peseur_lotspeche_lotnonbloque, rbtn_peseur_lotspeche_lotbloque });
                
                }
           

        }
        private void btn_peseur_lotspeche_saisirpoids_Click(object sender, EventArgs e)
        {
            lbl_peseur_lotspeche_validationok.Hide();
            if (dg_peseur_lotspeche_bacs.SelectedRows.Count != 1)
            {
                lbl_peseur_lotspeche_validationok.Text = "Veuillez sélectionner un et un seul bac";
                lbl_peseur_lotspeche_validationok.ForeColor = Color.Red;
                lbl_peseur_lotspeche_validationok.Show();
                return;
            }
            string poids = dg_peseur_lotspeche_bacs.SelectedRows[0].Cells[3].Value.ToString();
            if (poids != "Non saisie")
            {
                tbx_peseur_lotspeche_saisirpoids.Text = poids;
            }
            else
            {
                tbx_peseur_lotspeche_saisirpoids.Text = "";
            }
            HiddenObject.Show(new List<Control> { tbx_peseur_lotspeche_saisirpoids, lbl_peseur_lotspeche_saisirpoids, btn_peseur_lotspeche_validersaisiepoids });
            idBacisWeightModifing = dg_peseur_lotspeche_bacs.SelectedRows[0].Cells[0].Value.ToString();
        }
        private void btn_peseur_lotspeche_validersaisiepoids_Click(object sender, EventArgs e)
        {
            CURS cs = new CURS();
            
            string nouvpoids = "'" + tbx_peseur_lotspeche_saisirpoids.Text + "'";
            if (nouvpoids == "''")
            {              
                cs.ReqAdminPrepare("UPDATE bac SET poidsbrutbac=NULL WHERE idDatePeche=? AND idBateau=? AND idLot=? AND id=?", new List<object> { Datejour, idbateau, idLotisWeightModifing, idBacisWeightModifing });

            }
            else
            {
                cs.ReqAdminPrepare("UPDATE bac SET poidsbrutbac=? WHERE idDatePeche=? AND idBateau=? AND idLot=? AND id=?", new List<object> { tbx_peseur_lotspeche_saisirpoids.Text, Datejour, idbateau, idLotisWeightModifing, idBacisWeightModifing });

            }
            HiddenObject.Hide(new List<Control> { tbx_peseur_lotspeche_saisirpoids, lbl_peseur_lotspeche_saisirpoids, btn_peseur_lotspeche_validersaisiepoids });
           
            cs.fermer();
            int index = dg_peseur_lotspeche_lotsbateau.Rows.IndexOf(ligneselect);
            cbx_peseur_lotspeche_listebateaux_SelectionChangeCommitted(sender, e);
            dg_peseur_lotspeche_lotsbateau.Rows[index].Selected = true;
            dg_peseur_lotspeche_lotsbateau_CellMouseClick(sender, dernierclic);
            lbl_peseur_lotspeche_validationok.Text = "Le bac a bien été modifié";
            lbl_peseur_lotspeche_validationok.ForeColor = Color.Blue;
            lbl_peseur_lotspeche_validationok.Show();
        }
        private void tbx_peseur_lotspeche_saisirpoids_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool result = false;
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back
            & e.KeyChar != '.')
            {
                result = true;
            }
            bool test = tbx_peseur_lotspeche_saisirpoids.Text.Contains('.');
            if (tbx_peseur_lotspeche_saisirpoids.Text.Contains('.') && e.KeyChar == '.')
            {
                result = true;
            }

            e.Handled = result;

        }

        private void rbtn_peseur_lotspeche_ChangedBloqueLot_CheckedChanged(object sender, EventArgs e)
        {
            DataGridViewRow ligneselectionne = dg_peseur_lotspeche_lotsbateau.SelectedRows[0];
            string idbateau = Int32.Parse(ligneselectionne.Cells[0].Value.ToString().Substring(0, 2)).ToString();
            string idlot = Int32.Parse(ligneselectionne.Cells[0].Value.ToString().Substring(2, 3)).ToString();
            CURS cs = new CURS();
            if (rbtn_peseur_lotspeche_lotbloque.Checked)
            {
                cs.ReqAdminPrepare("UPDATE lot SET codeEtat ='C' WHERE idDatePeche =? AND idBateau =? AND id =?", new List<object> { Datejour, idbateau, idlot });
                CompleteControl.griseligne(ligneselectionne);
                lbl_peseur_lotspeche_validation.Text = "Le lot sélectionné a bien été bloqué";
                ligneselectionne.Cells[7].Value = "C";
            }
            if (rbtn_peseur_lotspeche_lotnonbloque.Checked)
            {
                cs.ReqAdminPrepare("UPDATE lot SET codeEtat =NULL WHERE idDatePeche =? AND idBateau =? AND id =?", new List<object> { Datejour, idbateau, idlot });
                CompleteControl.degriseligne(ligneselectionne);
                lbl_peseur_lotspeche_validation.Text = "Le lot sélectionné a bien été débloqué";
                ligneselectionne.Cells[7].Value = "";

            }
            cs.fermer();
            lbl_peseur_lotspeche_validation.Show();
        }
        #endregion

        #region Fermeture du formulaire

        private void pbx_peseur_deconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AppCriee_Peseur_FormClosing(object sender, FormClosingEventArgs e)
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

        #endregion

    }
}
