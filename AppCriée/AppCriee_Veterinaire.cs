using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace AppCriée
{
    public partial class AppCriee_Veterinaire : Form
    {
        #region Données privées

        int idbateau;
        List<BacNotLot> listebacnotlot = new List<BacNotLot>();
        string idBacNotLotIsModifing = "";
        string idBacTabIsModifing = "";
        string idLotTabIsModifing = "";
        string Datejour = DateTime.Today.ToString("yyyy-MM-dd");
        AppCriee _authAccueil;
        User _useractuelle;

        #endregion

        #region Constructeur

        public AppCriee_Veterinaire(User unutilisateur, AppCriee authAccueil)
        {
            InitializeComponent();
            _authAccueil = authAccueil;
            _useractuelle = unutilisateur;
            lbl_veterinaire_accueil_bienvenue.Text = "Bienvenue " + unutilisateur.Nom + " " + unutilisateur.Prenom;
            lbl_veterinaire_datejour.Text = "Date du jour : " + DateTime.Today.ToString("dd/MM/yyyy");
            HiddenObject.Hide(new List<Control> { lbl_veterinaire_bacpoissons_choixbateau, cbx_veterinaire_bacpoissons_listebateaux, btn_veterinaire_bacpoissons_creerbacs, btn_veterinaire_bacpoissons_creerlots, btn_veterinaire_bacpoissons_modifierbacs, btn_veterinaire_bacpoissons_supprimerbacs, dg_veterinaire_bacpoissons_listebac, lbl_veterinaire_bacpoissons_isbac, lbl_veterinaire_bacpoissons_creationbac, lbl_veterinaire_bacpoissons_espece, lbl_veterinaire_bacpoissons_presentation, lbl_veterinaire_bacpoissons_taille, lbl_veterinaire_bacpoissons_qualite, lbl_veterinaire_bacpoissons_typebac, cbx_veterinaire_bacpoissons_espece, cbx_veterinaire_bacpoissons_presentation, cbx_veterinaire_bacpoissons_taille, cbx_veterinaire_bacpoissons_qualite, cbx_veterinaire_bacpoissons_typebac, btn_veterinaire_bacpoissons_valider, lbl_veterinaire_bacpoissons_validationok });
            tbp_veterinaire_lotspeche.Enabled = false;
            if (CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_listebateaux, "SELECT idBateau, nom, immatriculation FROM peche INNER JOIN Bateau ON peche.idBateau=Bateau.id WHERE DatePeche=?", "nom(immatriculation)",new List<object> { Datejour }, false))
            {
                HiddenObject.Hide(new List<Control> { lbl_veterinaire_lotspeche_ispeche });
                tbp_veterinaire_lotspeche.Enabled = true;
                lbl_veterinaire_ispeche.Hide();
            }
            tbc_veterinaire.Appearance = 0;
        }

        #endregion

        #region Changement d'onglets

        private void tbc_veterinaire_Selected(object sender, TabControlEventArgs e)
        {
            if (!(tbp_veterinaire_lotspeche.Enabled)&&(e.TabPage.Name!= "tbp_veterinaire_mesdonnees") && (e.TabPage.Name != "tbp_veterinaire_accueil"))
            {
                tbc_veterinaire.SelectedTab = tbp_veterinaire_accueil;
            }
            switch (e.TabPage.Name)
            {
                case "tbp_veterinaire_bacpoisson":
                    if (cbx_veterinaire_bacpoissons_listebateaux.SelectedItem is null)
                    {
                        if (CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_listebateaux, "SELECT idBateau, nom, immatriculation FROM peche INNER JOIN Bateau ON peche.idBateau=Bateau.id WHERE DatePeche=?", "nom(immatriculation)", new List<object> { Datejour }, false))
                        {
                            HiddenObject.Hide(new List<Control> { lbl_veterinaire_bacpoissons_ispeche, btn_veterinaire_bacpoissons_modifierbacsValider });
                            HiddenObject.Show(new List<Control> { cbx_veterinaire_bacpoissons_listebateaux, lbl_veterinaire_bacpoissons_choixbateau });
                        }
                    }
                    else
                    {
                        if (cbx_veterinaire_bacpoissons_listebateaux.SelectedItem.ToString() != "")
                        {
                            cbx_veterinaire_bacpoissons_listebateaux_SelectionChangeCommitted(sender, e);
                        }
                    }
                    break;
                case "tbp_veterinaire_lotspeche":
                    if (cbx_veterinaire_lotspeche_listebateaux.SelectedItem is null)
                    {
                        if (CompleteControl.RemplirCombobox(cbx_veterinaire_lotspeche_listebateaux, "SELECT idBateau, nom, immatriculation FROM peche INNER JOIN Bateau ON peche.idBateau=Bateau.id WHERE DatePeche=?", "nom(immatriculation)", new List<object> { Datejour }, false))
                        {
                            HiddenObject.Hide(new List<Control> { lbl_veterinaire_lotspeche_ispeche });
                            HiddenObject.Show(new List<Control> { cbx_veterinaire_lotspeche_listebateaux, lbl_veterinaire_lotspeche_choixbateau });
                        }
                    }
                    else
                    {
                        if (cbx_veterinaire_lotspeche_listebateaux.SelectedItem.ToString() != "")
                        {
                            cbx_veterinaire_lotspeche_listebateaux_SelectionChangeCommitted(sender, e);
                        }
                    }
                    break;
                case "tbp_veterinaire_touslots":
                    CURS cs = new CURS();
                    cs.ReqSelectPrepare("SELECT count(idBateau) as nbBateau FROM peche INNER JOIN Bateau ON peche.idBateau=Bateau.id WHERE DatePeche=?", new List<object> { Datejour });
                    if (cs.champ("nbBateau").ToString() == "0")
                    {
                        lbl_veterinaire_touslots_ispeche.Show();
                        lbl_veterinaire_touslots_islots.Hide();
                        dg_veterinaire_touslots_alllot.Hide();
                    }
                    else
                    {
                        HiddenObject.Hide(new List<Control> {lbl_veterinaire_touslots_error, lbl_veterinaire_touslots_ok });
                        if (CompleteControl.RemplirDataGridViewByRequest(dg_veterinaire_touslots_alllot, "SELECT bateau.id as idBateau, bateau.nom as nomBateau, idLot, count(idLot) as nbbac, espece.nom as nomEspece, idTaille, idPresentation, idQualite, codeEtat FROM bac INNER JOIN lot ON bac.idDatePeche=lot.idDatePeche AND bac.idBateau=lot.idBateau AND bac.idLot=lot.id INNER JOIN espece ON espece.id=lot.idEspece INNER JOIN bateau ON bateau.id=lot.idBateau AND bateau.id=bac.idBateau WHERE bac.idDatePeche=? GROUP BY idLot, lot.idBateau ORDER BY bateau.nom, idLot", new string[] { "nomBateau", "idLot", "nomEspece", "idTaille", "idQualite", "idPresentation", "nbbac", "idBateau", "codeEtat" }, new List<object> { Datejour }))
                        {
                            foreach (DataGridViewRow ligne in dg_veterinaire_touslots_alllot.Rows)
                            {
                                string numLotLot = ligne.Cells[1].Value.ToString();
                                string numLotBateau = ligne.Cells[7].Value.ToString();
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
                                ligne.Cells[1].Value = numLotBateau + numLotLot;
                                if (ligne.Cells[8].Value.ToString() != "")
                                {
                                    CompleteControl.griseligne(ligne);
                                }
                            }
                            HiddenObject.Show(new List<Control> { dg_veterinaire_touslots_alllot, btn_veterinaire_touslots_imprimer });
                            HiddenObject.Hide(new List<Control> { lbl_veterinaire_touslots_islots, lbl_veterinaire_touslots_ispeche });
                        }
                        else
                        {
                            HiddenObject.Show(new List<Control> { lbl_veterinaire_touslots_islots });
                            HiddenObject.Hide(new List<Control> { dg_veterinaire_touslots_alllot, lbl_veterinaire_touslots_ispeche, btn_veterinaire_touslots_imprimer });
                        }
                    }
                    break;
            }
        }

        #endregion

        #region Onglet Bac de poissons

        private void cbx_veterinaire_bacpoissons_listebateaux_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bool isbateau = false;
            HiddenObject.Hide(new List<Control> { btn_veterinaire_bacpoissons_modifierbacsValider, lbl_veterinaire_bacpoissons_modifierbacs, lbl_veterinaire_bacpoissons_creationbac, lbl_veterinaire_bacpoissons_espece, lbl_veterinaire_bacpoissons_taille, lbl_veterinaire_bacpoissons_qualite, lbl_veterinaire_bacpoissons_presentation, lbl_veterinaire_bacpoissons_typebac, cbx_veterinaire_bacpoissons_espece, cbx_veterinaire_bacpoissons_taille, cbx_veterinaire_bacpoissons_qualite, cbx_veterinaire_bacpoissons_presentation, cbx_veterinaire_bacpoissons_typebac, btn_veterinaire_bacpoissons_valider, lbl_veterinaire_bacpoissons_validationok, rbtn_veterinaire_bacpoissons_bacparlots, rbtn_veterinaire_bacpoissons_touslesbacs, lbl_veterinaire_bacpoissons_choixlot, cbx_veterinaire_bacpoissons_choixlot, lbl_veterinaire_bacpoissons_plusbacs });
            String elmt_bateau = cbx_veterinaire_bacpoissons_listebateaux.SelectedItem.ToString();
            int char_bateau = elmt_bateau.IndexOf("(");
            String imma = elmt_bateau.Substring(char_bateau + 1, elmt_bateau.Length - char_bateau - 2);
            CURS cs = new CURS();
            cs.ReqSelectPrepare("SELECT id FROM bateau WHERE immatriculation=?", new List<object> { imma });
            idbateau = Int32.Parse(cs.champ("id").ToString());
            cs.fermer();
            cs = new CURS();
            dg_veterinaire_bacpoissons_listebac.Rows.Clear();
            cs.ReqSelectPrepare("SELECT bac.id as idBac, idLot, idTypeBac, espece.nom as nomEspece, idTaille, idQualite, idPresentation, codeEtat FROM bac INNER JOIN lot ON lot.id=bac.idLot AND lot.idDatePeche=bac.idDatePeche AND lot.idBateau=bac.idBateau INNER JOIN espece ON lot.idEspece=espece.id INNER JOIN bateau ON lot.idBateau=bateau.id AND bac.idBateau=bateau.id WHERE bac.idDatePeche=? AND immatriculation=?", new List<object> {Datejour, imma });
            if (cs.champ("idBac") is null)
            {
                lbl_veterinaire_bacpoissons_isbac.Show();
            }
            else
            {
                isbateau = true;
                lbl_veterinaire_bacpoissons_isbac.Hide();
                while (!cs.Fin())
                {
                    string numLotLot = cs.champ("idLot").ToString();
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
                    dg_veterinaire_bacpoissons_listebac.Rows.Add(cs.champ("idBac") + " (" + numLotBateau + "" + numLotLot + ")", cs.champ("nomEspece"), cs.champ("idTaille"), cs.champ("idQualite"), cs.champ("idPresentation"), cs.champ("idTypeBac"));
                    DataGridViewRow lastline = dg_veterinaire_bacpoissons_listebac.Rows[dg_veterinaire_bacpoissons_listebac.Rows.Count - 1];
                    lastline.Cells[7].Value = cs.champ("codeEtat").ToString();
                    if (cs.champ("codeEtat").ToString().Trim() != "")
                    {
                        CompleteControl.griseligne(dg_veterinaire_bacpoissons_listebac.Rows[dg_veterinaire_bacpoissons_listebac.Rows.Count -1]);
                        
                    }
                    cs.suivant();
                }

            }
            cs.fermer();
            cs = new CURS();
            cs.ReqSelectPrepare("SELECT id FROM bateau WHERE immatriculation=?", new List<object> { imma });
            idbateau = Int32.Parse(cs.champ("id").ToString());
            cs.fermer();

            foreach (BacNotLot unbacnotlot in listebacnotlot)
            {
                if (unbacnotlot.IdBateau == idbateau)
                {
                    dg_veterinaire_bacpoissons_listebac.Rows.Add("(Pas de lots)", unbacnotlot.NomEspece, unbacnotlot.IdTaille, unbacnotlot.IdQualite, unbacnotlot.IdPresentation, unbacnotlot.IdTypeBac, unbacnotlot.Id);
                }
            }
            if (listebacnotlot.Count(ai => ai.IdBateau == idbateau) != 0)
            {
                HiddenObject.Show(new List<Control> { btn_veterinaire_bacpoissons_modifierbacs, btn_veterinaire_bacpoissons_creerlots });
                isbateau = true;
            }
            else
            {
                HiddenObject.Hide(new List<Control> { btn_veterinaire_bacpoissons_modifierbacs, btn_veterinaire_bacpoissons_creerlots });
            }
            if (isbateau)
            {
                HiddenObject.Show(new List<Control> {rbtn_veterinaire_bacpoissons_touslesbacs, rbtn_veterinaire_bacpoissons_bacparlots, dg_veterinaire_bacpoissons_listebac, btn_veterinaire_bacpoissons_supprimerbacs, btn_veterinaire_bacpoissons_modifierbacs });
                dg_veterinaire_bacpoissons_listebac.ClearSelection();
                lbl_veterinaire_bacpoissons_isbac.Hide();
                rbtn_veterinaire_bacpoissons_touslesbacs.Checked = true;
            }
            else
            {
                dg_veterinaire_bacpoissons_listebac.Hide();
                lbl_veterinaire_bacpoissons_isbac.Show();
                btn_veterinaire_bacpoissons_supprimerbacs.Hide();
                btn_veterinaire_bacpoissons_modifierbacs.Hide();
            }

            btn_veterinaire_bacpoissons_creerbacs.Show();
        }
        private void btn_veterinaire_bacpoissons_creerbacs_Click(object sender, EventArgs e)
        {
            cbx_veterinaire_bacpoissons_espece.Enabled = true;
            cbx_veterinaire_bacpoissons_taille.Enabled = true;
            cbx_veterinaire_bacpoissons_qualite.Enabled = true;
            cbx_veterinaire_bacpoissons_presentation.Enabled = true;
            CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_espece, "SELECT nom FROM lot INNER JOIN bac ON lot.idDatePeche=bac.idDatePeche AND lot.idBateau=bac.idBateau AND lot.id=bac.idLot RIGHT JOIN espece ON espece.id=lot.idEspece GROUP BY nom ORDER BY count(*)*(NOT(ISNULL(lot.id))) DESC", "nom");
            CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_taille, "SELECT id FROM Taille", "id");
            CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_qualite, "SELECT qualite.id as idQualite FROM lot INNER JOIN bac ON lot.idDatePeche=bac.idDatePeche AND lot.idBateau=bac.idBateau AND lot.id=bac.idLot RIGHT JOIN qualite ON qualite.id=lot.idQualite GROUP BY qualite.id ORDER BY count(*)*(NOT(ISNULL(lot.id))) DESC", "idQualite");
            CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_presentation, "SELECT presentation.id as idPresentation FROM lot INNER JOIN bac ON lot.idDatePeche=bac.idDatePeche AND lot.idBateau=bac.idBateau AND lot.id=bac.idLot RIGHT JOIN presentation ON presentation.id=lot.idPresentation GROUP BY presentation.id ORDER BY count(*)*(NOT(ISNULL(lot.id))) DESC", "idPresentation");
            CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_typebac, "SELECT id FROM Typebac", "id");
            btn_veterinaire_bacpoissons_creerbacs.Hide();
            lbl_veterinaire_bacpoissons_modifierbacs.Hide();
            btn_veterinaire_bacpoissons_modifierbacsValider.Hide();
            HiddenObject.Show(new List<Control> { btn_veterinaire_bacpoissons_valider, lbl_veterinaire_bacpoissons_creationbac, lbl_veterinaire_bacpoissons_espece, lbl_veterinaire_bacpoissons_taille, lbl_veterinaire_bacpoissons_qualite, lbl_veterinaire_bacpoissons_presentation, lbl_veterinaire_bacpoissons_typebac, cbx_veterinaire_bacpoissons_espece, cbx_veterinaire_bacpoissons_taille, cbx_veterinaire_bacpoissons_qualite, cbx_veterinaire_bacpoissons_presentation, cbx_veterinaire_bacpoissons_typebac });
        }
        private void btn_veterinaire_bacpoissons_valider_Click(object sender, EventArgs e)
        {
            String elmt_bateau = cbx_veterinaire_bacpoissons_espece.SelectedItem.ToString();
            BacNotLot nouveauBacNotLot = new BacNotLot(cbx_veterinaire_bacpoissons_espece.SelectedItem.ToString(), Int32.Parse(cbx_veterinaire_bacpoissons_taille.SelectedItem.ToString()), Char.Parse(cbx_veterinaire_bacpoissons_qualite.SelectedItem.ToString()), cbx_veterinaire_bacpoissons_presentation.SelectedItem.ToString(), idbateau, Char.Parse(cbx_veterinaire_bacpoissons_typebac.SelectedItem.ToString()));
            listebacnotlot.Add(nouveauBacNotLot);
            dg_veterinaire_bacpoissons_listebac.Rows.Add("(Pas de lots)", cbx_veterinaire_bacpoissons_espece.SelectedItem, cbx_veterinaire_bacpoissons_taille.SelectedItem, cbx_veterinaire_bacpoissons_qualite.SelectedItem, cbx_veterinaire_bacpoissons_presentation.SelectedItem, cbx_veterinaire_bacpoissons_typebac.SelectedItem, nouveauBacNotLot.Id);
            HiddenObject.Show(new List<Control> { btn_veterinaire_bacpoissons_supprimerbacs, btn_veterinaire_bacpoissons_modifierbacs, btn_veterinaire_bacpoissons_creerlots });
            dg_veterinaire_bacpoissons_listebac.Show();
            lbl_veterinaire_bacpoissons_isbac.Hide();
        }
        private void btn_veterinaire_bacpoissons_creerlots_Click(object sender, EventArgs e)
        {
            tbc_veterinaire.SelectedTab = tbp_veterinaire_lotspeche;
        }
        private void btn_veterinaire_bacpoissons_supprimerbacs_Click(object sender, EventArgs e)
        {
            lbl_veterinaire_bacpoissons_validationok.Hide();
            if (dg_veterinaire_bacpoissons_listebac.SelectedRows.Count == 0)
            {
                lbl_veterinaire_bacpoissons_validationok.Text = "Veuillez sélectionner au moins un bac";
                lbl_veterinaire_bacpoissons_validationok.ForeColor = Color.Red;
                lbl_veterinaire_bacpoissons_validationok.Show();
                return;
            }
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ces bacs ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow line in dg_veterinaire_bacpoissons_listebac.SelectedRows)
                {
                    if (line.Cells[0].Value.ToString().Trim() != "(Pas de lots)")
                    {
                        if (line.Cells[7].Value.ToString().Trim() != "")
                        {
                            lbl_veterinaire_bacpoissons_validationok.Text = "La suppression est impossible car un des bacs sélectionnés est associé à un lot bloqué.";
                            lbl_veterinaire_bacpoissons_validationok.ForeColor = Color.Red;
                            lbl_veterinaire_bacpoissons_validationok.Show();
                            return;
                        }
                    }
                }
                foreach (DataGridViewRow item in dg_veterinaire_bacpoissons_listebac.SelectedRows)
                {
                    string numBacLot = item.Cells[0].Value.ToString();

                    if (numBacLot == "(Pas de lots)")
                    {
                        listebacnotlot.Remove(listebacnotlot.Find(ai => ai.Id == item.Cells["idBac"].Value.ToString()));
                    }
                    else
                    {
                        string id = numBacLot.Substring(0, numBacLot.IndexOf("("));
                        string idLot = Int32.Parse(numBacLot.Substring(numBacLot.IndexOf("(") + 1, numBacLot.Length - numBacLot.IndexOf("(") - 2).Substring(2, 3)).ToString();
                        CURS cs = new CURS();
                        cs.ReqAdminPrepare("DELETE FROM bac WHERE idBateau=? AND idLot=? AND idDatePeche=? AND id=?", new List<object> { idbateau, idLot, Datejour, id });
                        cs.fermer();
                    }



                }
                CURS csa = new CURS();
                csa.ReqAdminPrepare("DELETE LOT FROM lot LEFT JOIN bac ON lot.idDatePeche=bac.idDatePeche AND lot.idBateau=bac.idBateau AND lot.id=bac.idLot WHERE lot.idDatePeche='" + Datejour + "' AND lot.idBateau='" + idbateau + "'AND bac.id is NULL", new List<object> { Datejour, idbateau });
                csa.fermer();
                if (rbtn_veterinaire_bacpoissons_touslesbacs.Checked)
                {
                    cbx_veterinaire_bacpoissons_listebateaux_SelectionChangeCommitted(sender, e);
                }
                else
                {
                    foreach(DataGridViewRow uneligne in dg_veterinaire_bacpoissons_listebac.SelectedRows)
                    {
                        dg_veterinaire_bacpoissons_listebac.Rows.Remove(uneligne);
                    }
                    if (dg_veterinaire_bacpoissons_listebac.SelectedRows.Count == 0)
                    {
                        dg_veterinaire_bacpoissons_listebac.Hide();
                        lbl_veterinaire_bacpoissons_plusbacs.Show();
                        cbx_veterinaire_bacpoissons_choixlot.Items.RemoveAt(cbx_veterinaire_bacpoissons_choixlot.Items.IndexOf(cbx_veterinaire_bacpoissons_choixlot.Text));
                    }
                }
                lbl_veterinaire_bacpoissons_validationok.Text = "Les bacs ont été supprimées";
                lbl_veterinaire_bacpoissons_validationok.ForeColor = Color.Blue;
                lbl_veterinaire_bacpoissons_validationok.Show();


            }
        }
        private void btn_veterinaire_bacpoissons_modifierbacs_Click(object sender, EventArgs e)
        {
            btn_veterinaire_bacpoissons_creerbacs.Show();
            HiddenObject.Hide(new List<Control> { btn_veterinaire_bacpoissons_modifierbacsValider, lbl_veterinaire_bacpoissons_modifierbacs, btn_veterinaire_bacpoissons_valider, lbl_veterinaire_bacpoissons_validationok, lbl_veterinaire_bacpoissons_creationbac, btn_veterinaire_bacpoissons_valider, lbl_veterinaire_bacpoissons_plusbacs, cbx_veterinaire_bacpoissons_espece, cbx_veterinaire_bacpoissons_qualite, cbx_veterinaire_bacpoissons_taille, cbx_veterinaire_bacpoissons_presentation, cbx_veterinaire_bacpoissons_typebac, lbl_veterinaire_bacpoissons_espece, lbl_veterinaire_bacpoissons_taille, lbl_veterinaire_bacpoissons_qualite, lbl_veterinaire_bacpoissons_presentation, lbl_veterinaire_bacpoissons_typebac });          
            if (dg_veterinaire_bacpoissons_listebac.Rows.GetRowCount(DataGridViewElementStates.Selected) != 1)
            {
                MessageBox.Show("Il n'est possible de modifier qu'un seul bac à la fois.", "Modification impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow item = dg_veterinaire_bacpoissons_listebac.SelectedRows[0];
                string numBacLot = item.Cells[0].Value.ToString();
                if (numBacLot != "(Pas de lots)")
                {
                    if (item.Cells[7].Value.ToString().Trim() != "")
                {
                    MessageBox.Show("Il n'est pas possible de modifier un bac associé à un lot bloqué.", "Modification impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    cbx_veterinaire_bacpoissons_espece.Enabled = false;
                    cbx_veterinaire_bacpoissons_taille.Enabled = false;
                    cbx_veterinaire_bacpoissons_qualite.Enabled = false;
                    cbx_veterinaire_bacpoissons_presentation.Enabled = false;
                    idBacTabIsModifing = numBacLot.Substring(0, numBacLot.IndexOf("("));
                    idLotTabIsModifing = Int32.Parse(numBacLot.Substring(numBacLot.IndexOf("(") + 1, numBacLot.Length - numBacLot.IndexOf("(") - 2).Substring(2,3)).ToString();
                    idBacNotLotIsModifing = "";
                }
                else
                {
                    cbx_veterinaire_bacpoissons_espece.Enabled = true;
                    cbx_veterinaire_bacpoissons_taille.Enabled = true;
                    cbx_veterinaire_bacpoissons_qualite.Enabled = true;
                    cbx_veterinaire_bacpoissons_presentation.Enabled = true;
                    idBacNotLotIsModifing = item.Cells[6].Value.ToString();
                    idBacTabIsModifing = "";
                    idLotTabIsModifing = "";
                }
                CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_espece, "SELECT nom FROM espece", "nom");
                CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_taille, "SELECT id FROM Taille", "id");
                CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_qualite, "SELECT id FROM Qualite", "id");
                CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_presentation, "SELECT id FROM Presentation", "id");
                CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_typebac, "SELECT id FROM Typebac", "id");

                cbx_veterinaire_bacpoissons_espece.SelectedItem = cbx_veterinaire_bacpoissons_espece.Items[cbx_veterinaire_bacpoissons_espece.FindString(item.Cells[1].Value.ToString())];
                cbx_veterinaire_bacpoissons_taille.SelectedItem = cbx_veterinaire_bacpoissons_taille.Items[cbx_veterinaire_bacpoissons_taille.FindString(item.Cells[2].Value.ToString())];
                cbx_veterinaire_bacpoissons_qualite.SelectedItem = cbx_veterinaire_bacpoissons_qualite.Items[cbx_veterinaire_bacpoissons_qualite.FindString(item.Cells[3].Value.ToString())];
                cbx_veterinaire_bacpoissons_presentation.SelectedItem = cbx_veterinaire_bacpoissons_presentation.Items[cbx_veterinaire_bacpoissons_presentation.FindString(item.Cells[4].Value.ToString())];
                cbx_veterinaire_bacpoissons_typebac.SelectedItem = cbx_veterinaire_bacpoissons_typebac.Items[cbx_veterinaire_bacpoissons_typebac.FindString(item.Cells[5].Value.ToString())];

            HiddenObject.Show(new List<Control> { btn_veterinaire_bacpoissons_modifierbacsValider, lbl_veterinaire_bacpoissons_modifierbacs, btn_veterinaire_bacpoissons_creerbacs, lbl_veterinaire_bacpoissons_espece, lbl_veterinaire_bacpoissons_taille, lbl_veterinaire_bacpoissons_qualite, lbl_veterinaire_bacpoissons_presentation, lbl_veterinaire_bacpoissons_typebac, cbx_veterinaire_bacpoissons_espece, cbx_veterinaire_bacpoissons_taille, cbx_veterinaire_bacpoissons_qualite, cbx_veterinaire_bacpoissons_presentation, cbx_veterinaire_bacpoissons_typebac, btn_veterinaire_bacpoissons_modifierbacsValider });
            btn_veterinaire_bacpoissons_creerbacs.Hide();

        }
        private void btn_veterinaire_bacpoissons_modifierbacsValider_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir modifier ce bac ?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (idBacNotLotIsModifing != "")
                {
                    BacNotLot bacAmodifie = listebacnotlot.Find(ai => ai.Id == idBacNotLotIsModifing);

                    bacAmodifie.NomEspece = cbx_veterinaire_bacpoissons_espece.SelectedItem.ToString();
                    bacAmodifie.IdTaille = Int32.Parse(cbx_veterinaire_bacpoissons_taille.SelectedItem.ToString());
                    bacAmodifie.IdQualite = Char.Parse(cbx_veterinaire_bacpoissons_qualite.SelectedItem.ToString());
                    bacAmodifie.IdPresentation = cbx_veterinaire_bacpoissons_presentation.SelectedItem.ToString();
                    bacAmodifie.IdTypeBac = Char.Parse(cbx_veterinaire_bacpoissons_typebac.SelectedItem.ToString());
                    if (rbtn_veterinaire_bacpoissons_bacparlots.Checked)
                    {
                        foreach (DataGridViewRow uneligne in dg_veterinaire_bacpoissons_listebac.Rows)
                        {
                            if (uneligne.Cells[6].Value.ToString() == idBacNotLotIsModifing)
                            {
                                uneligne.Cells[1].Value = bacAmodifie.NomEspece;
                                uneligne.Cells[2].Value = bacAmodifie.IdTaille;
                                uneligne.Cells[3].Value = bacAmodifie.IdQualite;
                                uneligne.Cells[4].Value = bacAmodifie.IdPresentation;
                                uneligne.Cells[5].Value = bacAmodifie.IdTypeBac;
                            }
                        }
                    }
                }
                else
                {
                    CURS csm = new CURS();
                    csm.ReqAdminPrepare("UPDATE bac SET idTypeBac=? WHERE idDatePeche=? AND idBateau=? AND id=? AND idLot=?", new List<object> { cbx_veterinaire_bacpoissons_typebac.SelectedItem, Datejour, idbateau, idBacTabIsModifing, idLotTabIsModifing });
                    csm.fermer();
                    if (rbtn_veterinaire_bacpoissons_bacparlots.Checked)
                    {
                        string idCurrentnumBac;
                        string idCurrentnumLot;
                        string numBacLot;
                        foreach (DataGridViewRow uneligne in dg_veterinaire_bacpoissons_listebac.Rows)
                        {
                            numBacLot = uneligne.Cells[0].Value.ToString();
                            idCurrentnumBac = numBacLot.Substring(0, numBacLot.IndexOf("("));
                            idCurrentnumLot = Int32.Parse(numBacLot.Substring(numBacLot.IndexOf("(") + 1, numBacLot.Length - numBacLot.IndexOf("(") - 2).Substring(2, 3)).ToString();

                            if (idCurrentnumBac == idBacTabIsModifing && idCurrentnumLot == idLotTabIsModifing)
                            {
                                uneligne.Cells[5].Value = cbx_veterinaire_bacpoissons_typebac.SelectedItem;
                            }
                        }
                    }
                }
                if (rbtn_veterinaire_bacpoissons_touslesbacs.Checked)
                {
                    cbx_veterinaire_bacpoissons_listebateaux_SelectionChangeCommitted(sender, e);
                }
                lbl_veterinaire_bacpoissons_validationok.Text = "Le bac a bien été modifié";
                lbl_veterinaire_bacpoissons_validationok.Show();


            }
        }
        private void rbtn_veterinaire_bacpoissons_CheckedChanged(object sender, EventArgs e)
        {
            HiddenObject.Show(new List<Control> { btn_veterinaire_bacpoissons_modifierbacs, btn_veterinaire_bacpoissons_supprimerbacs });
            if (rbtn_veterinaire_bacpoissons_touslesbacs.Checked)
            {
                cbx_veterinaire_bacpoissons_listebateaux_SelectionChangeCommitted(sender, e);

            }
            else
            {
                CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_choixlot, "SELECT lot.id as idLot, espece.nom as nomEspece, idTaille, idPresentation, idQualite, codeEtat FROM lot INNER JOIN espece ON espece.id=lot.idEspece INNER JOIN bateau ON bateau.id=lot.idBateau AND bateau.id=lot.idBateau WHERE lot.idDatePeche=? AND bateau.id=?", "#Lot n°#idLot (nomEspece:idTaille:idQualite:idPresentation)", new List<object> { Datejour , idbateau}, false);
                if (listebacnotlot.Count(ai => ai.IdBateau == idbateau) != 0)
                {
                    cbx_veterinaire_bacpoissons_choixlot.Items.Add("Pas de lots");
                }
                HiddenObject.Show(new List<Control> { lbl_veterinaire_bacpoissons_choixlot, cbx_veterinaire_bacpoissons_choixlot });
                HiddenObject.Hide(new List<Control> { lbl_veterinaire_bacpoissons_creationbac, lbl_veterinaire_bacpoissons_modifierbacs, lbl_veterinaire_bacpoissons_presentation, lbl_veterinaire_bacpoissons_espece, lbl_veterinaire_bacpoissons_qualite, lbl_veterinaire_bacpoissons_taille, lbl_veterinaire_bacpoissons_typebac, lbl_veterinaire_bacpoissons_validationok, cbx_veterinaire_bacpoissons_espece, cbx_veterinaire_bacpoissons_taille, cbx_veterinaire_bacpoissons_qualite, cbx_veterinaire_bacpoissons_presentation, cbx_veterinaire_bacpoissons_typebac, btn_veterinaire_bacpoissons_creerbacs, btn_veterinaire_bacpoissons_valider, btn_veterinaire_bacpoissons_modifierbacsValider });
              
          
            }

        }
        private void cbx_veterinaire_bacpoissons_choixlot_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HiddenObject.Show(new List<Control> { btn_veterinaire_bacpoissons_modifierbacs, btn_veterinaire_bacpoissons_supprimerbacs });
            if (cbx_veterinaire_bacpoissons_choixlot.Text != "")
            {
                dg_veterinaire_bacpoissons_listebac.Rows.Clear();
                MatchCollection infolot = Regex.Matches(cbx_veterinaire_bacpoissons_choixlot.Text, @"[0-9]+");
                if (infolot.Count != 0)
                {
                    string numlot = infolot[0].Value;
                    CURS cs = new CURS();
                    cs.ReqSelectPrepare("SELECT bac.id as idBac, idLot, idTypeBac, espece.nom as nomEspece, idTaille, idQualite, idPresentation, codeEtat FROM bac INNER JOIN lot ON lot.id=bac.idLot AND lot.idDatePeche=bac.idDatePeche AND lot.idBateau=bac.idBateau INNER JOIN espece ON lot.idEspece=espece.id INNER JOIN bateau ON lot.idBateau=bateau.id AND bac.idBateau=bateau.id WHERE bac.idDatePeche=? AND bateau.id=? AND bac.idlot=?", new List<object> { Datejour , idbateau, numlot});
                    if (!(cs.champ("idBac") is null))
                    {
                        while (!cs.Fin())
                        {
                            string numLotLot = cs.champ("idLot").ToString();
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
                            dg_veterinaire_bacpoissons_listebac.Rows.Add(cs.champ("idBac") + " (" + numLotBateau + "" + numLotLot + ")", cs.champ("nomEspece"), cs.champ("idTaille"), cs.champ("idQualite"), cs.champ("idPresentation"), cs.champ("idTypeBac"));
                            DataGridViewRow lastline = dg_veterinaire_bacpoissons_listebac.Rows[dg_veterinaire_bacpoissons_listebac.Rows.Count - 1];
                            lastline.Cells[7].Value = cs.champ("codeEtat").ToString();
                            if (cs.champ("codeEtat").ToString().Trim() != "")
                            {
                                CompleteControl.griseligne(dg_veterinaire_bacpoissons_listebac.Rows[dg_veterinaire_bacpoissons_listebac.Rows.Count - 1]);
                                HiddenObject.Hide(new List<Control> { btn_veterinaire_bacpoissons_modifierbacs, btn_veterinaire_bacpoissons_supprimerbacs });
                                
                            }
                            cs.suivant();
                        }

                    }
                    cs.fermer();
                }
                else
                {
                    foreach (BacNotLot unbacnotlot in listebacnotlot)
                    {
                        if (unbacnotlot.IdBateau == idbateau)
                        {
                            dg_veterinaire_bacpoissons_listebac.Rows.Add("(Pas de lots)", unbacnotlot.NomEspece, unbacnotlot.IdTaille, unbacnotlot.IdQualite, unbacnotlot.IdPresentation, unbacnotlot.IdTypeBac, unbacnotlot.Id);
                        }
                    }
                }
                dg_veterinaire_bacpoissons_listebac.Show();
                dg_veterinaire_bacpoissons_listebac.ClearSelection();
            }
        }
        
        #endregion

        #region Onglet Lots de peche

        private void cbx_veterinaire_lotspeche_listebateaux_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HiddenObject.Hide(new List<Control> { btn_veterinaire_bacpoissons_modifierbacsValider, lbl_veterinaire_lotspeche_assignerlot, cbx_veterinaire_lotspeche_lotsbateau, lbl_veterinaire_lotspeche_isokcreerlot, cbx_veterinaire_lotspeche_lotsbateau, btn_veterinaire_lotspeche_assigneralot, btn_veterinaire_lotspeche_creerlot, dg_veterinaire_lotspeche_bacnotlot, dg_veterinaire_lotspeche_lotsbateau, lbl_veterinaire_lotspeche_isbacs, lbl_veterinaire_lotspeche_assignerlot, btn_veterinaire_lotspeche_assigneralot });
            HiddenObject.Show(new List<Control> { lbl_veterinaire_lotspeche_isbacsnotlot, lbl_veterinaire_lotspeche_lotsbateau, lbl_veterinaire_lotspeche_bacnotlot, lbl_veterinaire_lotspeche_islots });
            String elmt_bateau = cbx_veterinaire_lotspeche_listebateaux.Text;
            int char_bateau = elmt_bateau.IndexOf("(");
            String imma = elmt_bateau.Substring(char_bateau + 1, elmt_bateau.Length - char_bateau - 2);
            lbl_veterinaire_lotspeche_bacnotlot.Text = "Liste des Bacs non assignées à un lot du Bateau '" + elmt_bateau.Substring(0, char_bateau) + "' :";
            lbl_veterinaire_lotspeche_lotsbateau.Text = "Liste de tous les lots du Bateau '" + elmt_bateau.Substring(0, char_bateau) + "' :";
            bool islots = CompleteControl.RemplirDataGridViewByRequest(dg_veterinaire_lotspeche_lotsbateau, "SELECT idLot, count(idLot) as nbbac, espece.nom as nomEspece, idTaille, idPresentation, idQualite FROM bac INNER JOIN lot ON bac.idDatePeche=lot.idDatePeche AND bac.idBateau=lot.idBateau AND bac.idLot=lot.id INNER JOIN espece ON espece.id=lot.idEspece INNER JOIN bateau ON bateau.id=lot.idBateau AND bateau.id=bac.idBateau WHERE bac.idDatePeche=? AND immatriculation=? GROUP BY idLot", new string[] { "idLot", "nomEspece", "idTaille", "idQualite", "idPresentation", "nbbac", "idlot" }, new List<object> {Datejour, imma });
            if (islots)
            {
                foreach (DataGridViewRow ligne in dg_veterinaire_lotspeche_lotsbateau.Rows)
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
                }
                lbl_veterinaire_lotspeche_islots.Hide();
                HiddenObject.Show(new List<Control> { dg_veterinaire_lotspeche_lotsbateau });
            }
            CURS cs = new CURS();
            cs.ReqSelectPrepare("SELECT id FROM bateau WHERE immatriculation=?", new List<object> {imma });
            idbateau = Int32.Parse(cs.champ("id").ToString());
            cs.fermer();
            dg_veterinaire_lotspeche_bacnotlot.Rows.Clear();
            bool isbacnotlot = false;
            foreach (BacNotLot unbacnotlot in listebacnotlot)
            {
                if (unbacnotlot.IdBateau == idbateau)
                {
                    isbacnotlot = true;
                    dg_veterinaire_lotspeche_bacnotlot.Rows.Add(unbacnotlot.NomEspece, unbacnotlot.IdTaille, unbacnotlot.IdQualite, unbacnotlot.IdPresentation, unbacnotlot.IdTypeBac, unbacnotlot.Id);
                }
            }
            if (isbacnotlot)
            {
                CompleteControl.RemplirCombobox(cbx_veterinaire_lotspeche_lotsbateau, "SELECT lot.id as idLot, espece.nom as nomEspece, idTaille, idPresentation, idQualite FROM lot INNER JOIN espece ON espece.id=lot.idEspece INNER JOIN bateau ON bateau.id=lot.idBateau AND bateau.id=lot.idBateau WHERE lot.idDatePeche=? AND immatriculation=? AND codeEtat is NULL", "#Lot n°#idLot (nomEspece:idTaille:idQualite:idPresentation)", new List<object> {Datejour, imma }, false);
                HiddenObject.Show(new List<Control> { btn_veterinaire_lotspeche_creerlot, dg_veterinaire_lotspeche_bacnotlot });
                if (islots)
                {
                    HiddenObject.Show(new List<Control> { cbx_veterinaire_lotspeche_lotsbateau, lbl_veterinaire_lotspeche_assignerlot });

                }
                HiddenObject.Hide(new List<Control> { lbl_veterinaire_lotspeche_isbacsnotlot });
            }
            

            if (!isbacnotlot && !islots)
            {
                HiddenObject.Hide(new List<Control> { lbl_veterinaire_lotspeche_islots, lbl_veterinaire_lotspeche_lotsbateau, lbl_veterinaire_lotspeche_bacnotlot, lbl_veterinaire_bacpoissons_isbac, lbl_veterinaire_lotspeche_isbacsnotlot });
                HiddenObject.Show(new List<Control> { lbl_veterinaire_lotspeche_isbacs });
            }
        }
        private void btn_veterinaire_lotspeche_creerlot_Click(object sender, EventArgs e)
        {
            String elmt_bateau = cbx_veterinaire_lotspeche_listebateaux.Text;
            int char_bateau = elmt_bateau.IndexOf("(");
            String imma = elmt_bateau.Substring(char_bateau + 1, elmt_bateau.Length - char_bateau - 2);
            int idlotmax = 0;
            foreach (DataGridViewRow row in dg_veterinaire_lotspeche_lotsbateau.Rows)
            {
                if (idlotmax < Int32.Parse(row.Cells[6].Value.ToString()))
                {
                    idlotmax = Int32.Parse(row.Cells[6].Value.ToString());
                }
            }
            object[] etqplot = null;
            bool isok = true;
            if (dg_veterinaire_lotspeche_bacnotlot.SelectedRows.Count == 0)
            {
                lbl_veterinaire_lotspeche_isokcreerlot.ForeColor = System.Drawing.Color.Red;
                lbl_veterinaire_lotspeche_isokcreerlot.Text = "Veuillez sélectionner au moins un bac.";
                lbl_veterinaire_lotspeche_isokcreerlot.Show();
                return;
            }
            foreach (DataGridViewRow item in dg_veterinaire_lotspeche_bacnotlot.SelectedRows)
            {
                if (!(etqplot is null))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (etqplot[i].ToString() != item.Cells[i].Value.ToString())
                        {
                            isok = false;
                            break;
                        }
                    }
                }
                etqplot = new object[] { item.Cells["dgtbx_bacnotlots_espece"].Value, item.Cells["dgtbx_bacnotlots_taille"].Value, item.Cells["dgtbx_bacnotlots_qualite"].Value, item.Cells["dgtbx_bacnotlots_presentation"].Value };
            }
            if (!isok)
            {
                lbl_veterinaire_lotspeche_isokcreerlot.ForeColor = Color.Red;
                lbl_veterinaire_lotspeche_isokcreerlot.Text = "Veuillez sélectionner des bacs ayant\nles mêmes caractéristiques ETQP";
                lbl_veterinaire_lotspeche_isokcreerlot.Show();
            }
            else
            {
                CURS cs = new CURS();
                cs.ReqAdminPrepare("INSERT INTO lot(idDatePeche,idBateau , id, idEspece, idTaille, idPresentation, idQualite) VALUES (?,(SELECT id FROM bateau WHERE immatriculation=?),?,(SELECT id FROM espece WHERE nom=?),?,?,?)", new List<object> {Datejour, imma, (idlotmax+1), etqplot[0], etqplot[1], etqplot[3], etqplot[2] });
                cs.fermer();
                string requetesel = "INSERT INTO bac(id, idDatePeche,idBateau, idLot, idTypeBac) VALUES ";
                List<object> paramrequetesel = new List<object>();
                for (int i = 1; i <= dg_veterinaire_lotspeche_bacnotlot.SelectedRows.Count; i++)
                {
                    requetesel += "(?,?,(SELECT id FROM bateau WHERE immatriculation=?),?,?),";
                    paramrequetesel.Add(i);
                    paramrequetesel.Add(Datejour);
                    paramrequetesel.Add(imma);
                    paramrequetesel.Add((idlotmax + 1));
                    paramrequetesel.Add(dg_veterinaire_lotspeche_bacnotlot.SelectedRows[i - 1].Cells["dgtbx_bacnotlots_typebac"].Value);
                }
                requetesel = requetesel.Substring(0, requetesel.Length - 1);
                cs = new CURS();
                cs.ReqAdminPrepare(requetesel, paramrequetesel);
                cs.fermer();
                foreach (DataGridViewRow item in dg_veterinaire_lotspeche_bacnotlot.SelectedRows)
                {
                    listebacnotlot.Remove(listebacnotlot.Find(ai => ai.Id == item.Cells["id"].Value.ToString()));
                }
                cbx_veterinaire_lotspeche_listebateaux_SelectionChangeCommitted(sender, e);
                lbl_veterinaire_lotspeche_isokcreerlot.ForeColor = Color.Blue;
                lbl_veterinaire_lotspeche_isokcreerlot.Text = "Le lot a bien été créée";
                lbl_veterinaire_lotspeche_isokcreerlot.Show();
            }
        }
        private void cbx_veterinaire_lotspeche_lotsbateau_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btn_veterinaire_lotspeche_assigneralot.Show();
        }
        private void btn_veterinaire_lotspeche_assigneralot_Click(object sender, EventArgs e)
        {
            if (dg_veterinaire_lotspeche_bacnotlot.SelectedRows.Count < 1)
            {
                lbl_veterinaire_lotspeche_isokcreerlot.Text = "Veuillez sélectionner un ou plusieurs bacs";
                lbl_veterinaire_lotspeche_isokcreerlot.ForeColor = Color.Red;
                lbl_veterinaire_lotspeche_isokcreerlot.Show();
            }
            else
            {
                MatchCollection infolot = Regex.Matches(cbx_veterinaire_lotspeche_lotsbateau.Text.Substring(6), @"[a-zA-Z0-9À-ú]+");
                int count = infolot.Count;
                string numLot = infolot[0].Value;
                string nomEspece = infolot[1].Value;
                for (int i = 5; i < count; i++)
                {
                    nomEspece += " "+ infolot[i-3].Value;
                }
                string idTaille = infolot[count-3].Value;
                string idQualite = infolot[count-2].Value;
                string idPresentation = infolot[count-1].Value;
                foreach (DataGridViewRow ligne in dg_veterinaire_lotspeche_bacnotlot.SelectedRows)
                {
                    if (nomEspece != ligne.Cells[0].Value.ToString() || idTaille != ligne.Cells[1].Value.ToString() || idQualite != ligne.Cells[2].Value.ToString() || idPresentation != ligne.Cells[3].Value.ToString())
                    {
                        lbl_veterinaire_lotspeche_isokcreerlot.Text = "Veuillez sélectionner des bacs dont les\ncaractéristiques ETQP sont les mêmes que le\nlot sélectionné";
                        lbl_veterinaire_lotspeche_isokcreerlot.ForeColor = Color.Red;
                        lbl_veterinaire_lotspeche_isokcreerlot.Show();
                        return;
                    }
                }
                CURS cs = new CURS();
                cs.ReqSelectPrepare("SELECT max(id) as maxId FROM bac WHERE idDatePeche=? AND idBateau=? AND idLot=?", new List<object> { Datejour, idbateau, numLot });
                int maxId = Int32.Parse(cs.champ("maxId").ToString());
                string requeteInsert = "";
                List<object> paramrequeteInsert = new List<object>();
                foreach (DataGridViewRow ligne in dg_veterinaire_lotspeche_bacnotlot.SelectedRows)
                {
                    maxId++;
                    requeteInsert += ",(?,?,?,?,?)";
                    paramrequeteInsert.Add(maxId);
                    paramrequeteInsert.Add(Datejour);
                    paramrequeteInsert.Add(idbateau);
                    paramrequeteInsert.Add(numLot);
                    paramrequeteInsert.Add(ligne.Cells[4].Value);

                    listebacnotlot.Remove(listebacnotlot.Find(ai => ai.Id == ligne.Cells["id"].Value.ToString()));
                }
                cs = new CURS();
                cs.ReqAdminPrepare("INSERT INTO bac(id, idDatePeche, idBateau,idLot, idTypeBac) VALUES " + requeteInsert.Substring(1), paramrequeteInsert);
                cbx_veterinaire_lotspeche_listebateaux_SelectionChangeCommitted(sender, e);
                lbl_veterinaire_lotspeche_isokcreerlot.Text = "Le ou les bacs ont bien été assignées au lot : " + numLot;
                lbl_veterinaire_lotspeche_isokcreerlot.ForeColor = Color.Blue;
                lbl_veterinaire_lotspeche_isokcreerlot.Show();
            }
        }

        #endregion

        #region Onglet Tous les lots de vente

        private void btn_veterinaire_touslots_imprimer_Click(object sender, EventArgs e)
        {
            if (dg_veterinaire_touslots_alllot.SelectedRows.Count != 1)
            {
                lbl_veterinaire_touslots_error.Show();
                return;
            }

            DataGridViewRow ligneselect = dg_veterinaire_touslots_alllot.SelectedRows[0];
            string nomBateau = ligneselect.Cells[0].Value.ToString();
            string numLot = ligneselect.Cells[1].Value.ToString();
            string idLot = Int32.Parse(ligneselect.Cells[1].Value.ToString().Substring(2, 3)).ToString();
            string espece = ligneselect.Cells[2].Value.ToString();
            string taille = ligneselect.Cells[3].Value.ToString();
            string qualite = ligneselect.Cells[4].Value.ToString();
            string presentation = ligneselect.Cells[5].Value.ToString();
            int nbbac = Int32.Parse(ligneselect.Cells[6].Value.ToString());
            string numBateau = ligneselect.Cells[7].Value.ToString();
 

            CURS cs = new CURS();
            cs.ReqSelectPrepare("SELECT immatriculation FROM bateau WHERE id=?", new List<Object> { numBateau });
            string immatriculation = cs.champ("immatriculation").ToString();
            cs.fermer();

            cs = new CURS();
            cs.ReqSelectPrepare("SELECT bac.id as idBac, idTypeBac FROM bac INNER JOIN typebac ON typebac.id=bac.idTypeBac WHERE idDatePeche=? AND idBateau=? AND idLot=? ORDER BY bac.id", new List<Object> { Datejour, numBateau, idLot });

            List<string> listebac = new List<string>();
            List<string> listetypebac = new List<string>();

            while (!cs.Fin())
            {
                listebac.Add(cs.champ("idBac").ToString());
                listetypebac.Add(cs.champ("idTypeBac").ToString());
                cs.suivant();
            }
            cs.fermer();

            iTextSharp.text.Font font10b = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES_BOLD, 9);
            iTextSharp.text.Font font24b = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES_BOLD, 24);
            iTextSharp.text.Font font18 = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES, 18);
            iTextSharp.text.Font font18b = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES_BOLD, 18);
            iTextSharp.text.Font font14 = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES, 14);
            iTextSharp.text.Font font14b = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES_BOLD, 14);
            iTextSharp.text.Font font12 = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES, 12);
            iTextSharp.text.Font font11 = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES, 11);
            iTextSharp.text.Font font10 = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES, 10);
            iTextSharp.text.Font font8 = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES, 8);
            iTextSharp.text.Font font7 = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES, 7);
            iTextSharp.text.Font font9 = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES, 9);
            iTextSharp.text.Font font10i = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES_ITALIC, 10);

            Document nouveauDocument = new Document();
            nouveauDocument.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
            nouveauDocument.SetMargins(-15,-15,30,30);
            iTextSharp.text.pdf.PdfPTable ligne = new iTextSharp.text.pdf.PdfPTable(5);
            ligne.SetTotalWidth(new float[] { 60, 2, 60, 2, 60 });

            FileStream filePDF = new FileStream("Etiquettes ETQP Lot n°" + numLot + " du bateau " + nomBateau + " " + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".pdf", FileMode.Create);
            PdfWriter.GetInstance(nouveauDocument, filePDF);
            nouveauDocument.Open();
            for (int grp3 = 0; grp3 <= (int)((nbbac-1) / 3); grp3++)
            {
                if ((grp3 != 0) && (grp3 % 3 == 0))
                {
                    nouveauDocument.NewPage();
                }

                ligne = new iTextSharp.text.pdf.PdfPTable(5);
                ligne.SetTotalWidth(new float[] { 60, 2, 60, 2, 60 });
                for (int bac = 3 * grp3; bac < 3 * (grp3 + 1); bac++)
                {
                    if (bac+1 > nbbac)
                    {
                        PdfPCell vide = new PdfPCell();
                        vide.Border = 0;
                        vide.Padding = 0;
                        ligne.AddCell(vide);
                    }
                    else
                    {
                        PdfPCell etiquette = new PdfPCell();
                        etiquette.Padding = 0;
                        etiquette.PaddingLeft = -25;
                        etiquette.PaddingRight = -25;

                        iTextSharp.text.pdf.PdfPTable etiquetteligne1 = new iTextSharp.text.pdf.PdfPTable(1);
                        etiquetteligne1.PaddingTop = 0;
                        PdfPCell etiquetteligne1cellule1 = new PdfPCell();
                        etiquetteligne1cellule1.PaddingTop = 0;
                        etiquetteligne1cellule1.PaddingLeft = 35;
                        etiquetteligne1cellule1.Border = 0;

                        iTextSharp.text.Chunk titre = new iTextSharp.text.Chunk("Criée de la Poulgoazec", font14b);
                        etiquetteligne1cellule1.AddElement(titre);

                        etiquetteligne1.AddCell(etiquetteligne1cellule1);
                        etiquette.AddElement(etiquetteligne1);

                        iTextSharp.text.pdf.PdfPTable etiquetteligne2 = new iTextSharp.text.pdf.PdfPTable(2);
                        etiquetteligne2.SetTotalWidth(new float[] { 90, 70 });
                        etiquetteligne2.PaddingTop = 0;

                        PdfPCell etiquetteligne2cellule1 = new PdfPCell();
                        etiquetteligne2cellule1.PaddingTop = 0;
                        iTextSharp.text.Chunk itembateau = new iTextSharp.text.Chunk("Bateau : " + nomBateau + ", " + immatriculation, font11);
                        iTextSharp.text.Chunk itemdate = new iTextSharp.text.Chunk("Date : " + DateTime.Today.ToString("dd/MM/yyyy"), font11);
                        iTextSharp.text.Chunk itemnumlot = new iTextSharp.text.Chunk("N° Lot : " + numLot, font11);
                        etiquetteligne2cellule1.AddElement(itembateau);
                        etiquetteligne2cellule1.AddElement(itemdate);
                        etiquetteligne2cellule1.AddElement(itemnumlot);
                        etiquetteligne2cellule1.Border = 0;

                        PdfPCell etiquetteligne2cellule2 = new PdfPCell();
                        etiquetteligne2cellule2.PaddingTop = 0;
                        iTextSharp.text.Chunk itemespece = new iTextSharp.text.Chunk("Espèce : " + espece, font9);
                        iTextSharp.text.Chunk itemtaille = new iTextSharp.text.Chunk("Taille : " + taille, font9);
                        iTextSharp.text.Chunk itemqualite = new iTextSharp.text.Chunk("Qualité : " + qualite, font9);
                        iTextSharp.text.Chunk itempresentation = new iTextSharp.text.Chunk("Présentation : " + presentation, font9);
                        etiquetteligne2cellule2.AddElement(itemespece);
                        etiquetteligne2cellule2.AddElement(itemtaille);
                        etiquetteligne2cellule2.AddElement(itemqualite);
                        etiquetteligne2cellule2.AddElement(itempresentation);
                        etiquetteligne2cellule2.Border = 0;

                        etiquetteligne2.AddCell(etiquetteligne2cellule1);
                        etiquetteligne2.AddCell(etiquetteligne2cellule2);
                        etiquette.AddElement(etiquetteligne2);

                        iTextSharp.text.pdf.PdfPTable etiquetteligne3 = new iTextSharp.text.pdf.PdfPTable(1);
                        etiquetteligne3.PaddingTop = 0;
                        PdfPCell etiquetteligne3cellule1 = new PdfPCell();
                        etiquetteligne3cellule1.PaddingTop = 0;
                        etiquetteligne3cellule1.PaddingLeft = 15;
                        etiquetteligne3cellule1.Border = 0;

                        font12.Color = iTextSharp.text.BaseColor.BLUE;
                        iTextSharp.text.Chunk itemnumbac = new iTextSharp.text.Chunk("Numéro de bac : " + listebac[bac], font12);
                        iTextSharp.text.Chunk itemtypebac = new iTextSharp.text.Chunk("Type de bac : " + listetypebac[bac], font12);
                        
                        etiquetteligne3cellule1.AddElement(itemnumbac);
                        etiquetteligne3cellule1.AddElement(itemtypebac);

                        etiquetteligne3.AddCell(etiquetteligne3cellule1);
                        etiquette.AddElement(etiquetteligne3);


                        iTextSharp.text.pdf.PdfPTable etiquetteligne4 = new iTextSharp.text.pdf.PdfPTable(2);
                        etiquetteligne4.SetTotalWidth(new float[] { 50, 20 });
                        etiquetteligne4.PaddingTop = 0;

                        PdfPCell etiquetteligne4cellule1 = new PdfPCell();
                        etiquetteligne4cellule1.PaddingTop = 0;
                        etiquetteligne4cellule1.Border = 0;

                        PdfPCell etiquetteligne4cellule2 = new PdfPCell();
                        etiquetteligne2cellule2.PaddingTop = 0;
                        iTextSharp.text.Chunk itemdatenow = new iTextSharp.text.Chunk(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), font7);
                        etiquetteligne4cellule2.AddElement(itemdatenow);
                        etiquetteligne4cellule2.Border = 0;

                        etiquetteligne4.AddCell(etiquetteligne4cellule1);
                        etiquetteligne4.AddCell(etiquetteligne4cellule2);
                        etiquette.AddElement(etiquetteligne4);

                        ligne.AddCell(etiquette);
                    }
                    if (bac % 3 != 2)
                    {
                        PdfPCell vide = new PdfPCell();
                        vide.Border = 0;
                        ligne.AddCell(vide);

                    }
                }
                nouveauDocument.Add(ligne);
                nouveauDocument.Add(new Paragraph("\n"));
            }
            /*
            for (int grp9 = 0; grp9 <= (int)(nbbac / 9); grp9++)
            {
                if (grp9 != 0)
                {
                    nouveauDocument.NewPage();
                }
                for(int bac = 9 * grp9; bac < 9 * (grp9 + 1) && bac<=nbbac; bac++)
                {
                    if (bac % 3 == 0)
                    {
                        if (bac % 9 != 0)
                        {
                            nouveauDocument.Add(ligne);
                        }
                        ligne = new iTextSharp.text.pdf.PdfPTable(5);
                        ligne.SetTotalWidth(new float[] { 60, 10, 60, 10, 60 }) ;
                    }

                    PdfPCell ligne2sous2cell1 = new PdfPCell();
                    ligne2sous2cell1.AddElement(new iTextSharp.text.Chunk(" OP :", font14));
                    ligne.AddCell(ligne2sous2cell1);
                    if (bac % 3 != 0)
                    {
                        PdfPCell vide = new PdfPCell();
                        vide.AddElement(new iTextSharp.text.Chunk("VIDE", font14));
                        ligne.AddCell(vide);

                    }
                }
                    nouveauDocument.Add(ligne);
            }
            */
            nouveauDocument.Close();
            lbl_veterinaire_touslots_ok.Text = "Un document PDF contenant les étiquettes du lot a bien été généré :\n";
            for(int line = 0; line <= filePDF.Name.Length / 90; line++)
            {
                int nbchar = 90;
                if (line == filePDF.Name.Length / 90)
                {
                    nbchar = filePDF.Name.Length - 90 * line;
                }
                lbl_veterinaire_touslots_ok.Text += "\n" + filePDF.Name.Substring(90 * line, nbchar);
            }
            lbl_veterinaire_touslots_ok.Show();
            try
            {
                System.Diagnostics.Process.Start(filePDF.Name);
            }
            catch
            {
                MessageBox.Show("Impossible d'ouvrir le fichier pdf\nVous pouvez néanmoins ouvrir le fichier manuellement au chemin indiqué dans l'application","Echec ouverture fichier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        #endregion

        #region Onglet Mes Données

        private void btn_veterinaire_mesdonnees_supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer votre propre compte ?\nAttention, cette action est irréversible.", "Supprimer votre compte", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CURS cs = new CURS();
                cs.ReqAdminPrepare("DELETE FROM utilisateur WHERE id=?", new List<object> { _useractuelle.Id });
                cs.fermer();
                string adrMail = _useractuelle.AdrMail.Trim();
                string login = _useractuelle.Login;
                _useractuelle = null;
                _authAccueil.Show();
                this.Close();
                if (adrMail != "")
                {
                    Exception exception;
                    bool isresult = CompleteControl.SendMail(adrMail, "AppCriée : Confirmation de la suppression de votre compte", "Votre compte '" + login + "' a été correctement supprimée\n\nSupport Informatique de l'application AppCriée\n\nPour toutes questions relatives à l'application AppCriée, veuillez nous contacter à l'adresse : " + DataSystem.AdrMailFrom(), out exception);
                    if (!isresult)
                    {
                        MessageBox.Show("Votre compte a bien été supprimée\nL'envoi du mail de confirmation n'a toutefois pas pu être envoyé : \n" + exception.Message, "Compte supprimée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Votre compte a bien été supprimé\nUn mail vous a été envoyé", "Compte supprimé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Votre compte a bien été supprimé", "Compte supprimé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #endregion

        #region Fermeture du formulaire

        private void AppCriee_Veterinaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_useractuelle != null)
            {
                if (listebacnotlot.Count != 0)
                {
                    DialogResult result = MessageBox.Show("Des bacs ont été crée sans être associer à un lot, ces bacs ne seront pas sauvegardées\nVoulez-vous vraiment quitter ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        _authAccueil.Show();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
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
            }
        }
        private void pbx_veterinaire_deconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
        
        private Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();
        private void SetTabHeader(TabPage page, Color color)
        {
            TabColors[page] = color;
            tbc_veterinaire.Invalidate();
        }
        private void tbc_veterinaire_DrawItem(object sender, DrawItemEventArgs e)
        {
            using (Brush br = new SolidBrush(Color.White))
            {
                //e.Graphics.FillRectangle(br, e.Bounds);
                SizeF sz = e.Graphics.MeasureString(tbc_veterinaire.TabPages[e.Index].Text, e.Font);
                e.Graphics.DrawString(tbc_veterinaire.TabPages[e.Index].Text, e.Font, Brushes.Gray, e.Bounds.Left + (e.Bounds.Width - sz.Width) / 2, e.Bounds.Top + (e.Bounds.Height - sz.Height) / 2 + 1);
                /*
                Rectangle rect = e.Bounds;
                rect.Offset(0, 1);
                rect.Inflate(0, -1);
                e.DrawFocusRectangle();
                */
            }
            tbc_veterinaire.Appearance = 0;
        }

    }
}