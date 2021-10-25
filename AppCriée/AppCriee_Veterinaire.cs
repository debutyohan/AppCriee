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

namespace AppCriée
{
    public partial class AppCriee_Veterinaire : Form
    {
        #region Données privées
        string chaineConnexion = ConnectionChain.chaineConnexion();
        int idbateau;
        List<BacNotLot> listebacnotlot = new List<BacNotLot>();
        string idBacNotLotIsModifing = "";
        string idBacTabIsModifing = "";
        string idLotTabIsModifing = "";
        string Datejour = DateTime.Today.ToString("yyyy-MM-dd");
        AppCriee _authAccueil;
        #endregion

        #region Constructeur
        public AppCriee_Veterinaire(User unutilisateur, AppCriee authAccueil)
        {
            InitializeComponent();
            _authAccueil = authAccueil;
            lbl_veterinaire_accueil_bienvenue.Text = "Bienvenue " + unutilisateur.Nom + " " + unutilisateur.Prenom;
            lbl_veterinaire_datejour.Text = "Date du jour : " + DateTime.Today.ToString("dd/MM/yyyy");
            HiddenObject.Hide(new List<Control> { lbl_veterinaire_bacpoissons_choixbateau, cbx_veterinaire_bacpoissons_listebateaux, btn_veterinaire_bacpoissons_creerbacs, btn_veterinaire_bacpoissons_creerlots, btn_veterinaire_bacpoissons_modifierbacs, btn_veterinaire_bacpoissons_supprimerbacs, dg_veterinaire_bacpoissons_listebac, lbl_veterinaire_bacpoissons_isbac, lbl_veterinaire_bacpoissons_creationbac, lbl_veterinaire_bacpoissons_espece, lbl_veterinaire_bacpoissons_presentation, lbl_veterinaire_bacpoissons_taille, lbl_veterinaire_bacpoissons_qualite, lbl_veterinaire_bacpoissons_typebac, cbx_veterinaire_bacpoissons_espece, cbx_veterinaire_bacpoissons_presentation, cbx_veterinaire_bacpoissons_taille, cbx_veterinaire_bacpoissons_qualite, cbx_veterinaire_bacpoissons_typebac, btn_veterinaire_bacpoissons_valider, lbl_veterinaire_bacpoissons_validationok });
        }
        #endregion

        #region Changement d'onglets
        private void tbc_veterinaire_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPage.Name)
            {
                case "tbp_veterinaire_bacpoisson":
                    if (cbx_veterinaire_bacpoissons_listebateaux.SelectedItem is null)
                    {
                        if (CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_listebateaux, "SELECT idBateau, nom, immatriculation FROM peche INNER JOIN Bateau ON peche.idBateau=Bateau.id WHERE DatePeche='" + Datejour + "'", "nom(immatriculation)", false))
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
                        if (CompleteControl.RemplirCombobox(cbx_veterinaire_lotspeche_listebateaux, "SELECT idBateau, nom, immatriculation FROM peche INNER JOIN Bateau ON peche.idBateau=Bateau.id WHERE DatePeche='" + Datejour + "'", "nom(immatriculation)", false))
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
                    CURS cs = new CURS(chaineConnexion);
                    cs.ReqSelect("SELECT count(idBateau) as nbBateau FROM peche INNER JOIN Bateau ON peche.idBateau=Bateau.id WHERE DatePeche='" + Datejour + "'");
                    if (cs.champ("nbBateau").ToString() == "0")
                    {
                        lbl_veterinaire_touslots_ispeche.Show();
                        lbl_veterinaire_touslots_islots.Hide();
                        dg_veterinaire_touslots_alllot.Hide();
                    }
                    else
                    {
                        if (CompleteControl.RemplirDataGridViewByRequest(dg_veterinaire_touslots_alllot, "SELECT bateau.nom as nomBateau, idLot, count(idLot) as nbbac, espece.nom as nomEspece, idTaille, idPresentation, idQualite FROM bac INNER JOIN lot ON bac.idDatePeche=lot.idDatePeche AND bac.idBateau=lot.idBateau AND bac.idLot=lot.id INNER JOIN espece ON espece.id=lot.idEspece INNER JOIN bateau ON bateau.id=lot.idBateau AND bateau.id=bac.idBateau WHERE bac.idDatePeche='" + Datejour + "' GROUP BY idLot, lot.idBateau ORDER BY bateau.nom, idLot", new string[] { "nomBateau", "idLot", "nomEspece", "idTaille", "idQualite", "idPresentation", "nbbac" }))
                        {
                            dg_veterinaire_touslots_alllot.Show();
                            lbl_veterinaire_touslots_islots.Hide();
                            lbl_veterinaire_touslots_ispeche.Hide();
                        }
                        else
                        {
                            dg_veterinaire_touslots_alllot.Hide();
                            lbl_veterinaire_touslots_islots.Show();
                            lbl_veterinaire_touslots_ispeche.Hide();
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
            HiddenObject.Hide(new List<Control> { btn_veterinaire_bacpoissons_modifierbacsValider, lbl_veterinaire_bacpoissons_modifierbacs, lbl_veterinaire_bacpoissons_creationbac, lbl_veterinaire_bacpoissons_espece, lbl_veterinaire_bacpoissons_taille, lbl_veterinaire_bacpoissons_qualite, lbl_veterinaire_bacpoissons_presentation, lbl_veterinaire_bacpoissons_typebac, cbx_veterinaire_bacpoissons_espece, cbx_veterinaire_bacpoissons_taille, cbx_veterinaire_bacpoissons_qualite, cbx_veterinaire_bacpoissons_presentation, cbx_veterinaire_bacpoissons_typebac, btn_veterinaire_bacpoissons_valider, lbl_veterinaire_bacpoissons_validationok });
            String elmt_bateau = cbx_veterinaire_bacpoissons_listebateaux.SelectedItem.ToString();
            int char_bateau = elmt_bateau.IndexOf("(");
            String imma = elmt_bateau.Substring(char_bateau + 1, elmt_bateau.Length - char_bateau - 2);
            CURS cs = new CURS(chaineConnexion);
            dg_veterinaire_bacpoissons_listebac.Rows.Clear();
            cs.ReqSelect("SELECT bac.id as idBac, idLot, idTypeBac, espece.nom as nomEspece, idTaille, idQualite, idPresentation FROM bac INNER JOIN lot ON lot.id=bac.idLot AND lot.idDatePeche=bac.idDatePeche AND lot.idBateau=bac.idBateau INNER JOIN espece ON lot.idEspece=espece.id INNER JOIN bateau ON lot.idBateau=bateau.id AND bac.idBateau=bateau.id WHERE bac.idDatePeche='" + Datejour + "' AND immatriculation='" + imma + "'");
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
                    dg_veterinaire_bacpoissons_listebac.Rows.Add(cs.champ("idBac") + " (" + cs.champ("idLot") + ")", cs.champ("nomEspece"), cs.champ("idTaille"), cs.champ("idQualite"), cs.champ("idPresentation"), cs.champ("idTypeBac"));
                    cs.suivant();
                }

            }
            cs.fermer();
            cs = new CURS(chaineConnexion);
            cs.ReqSelect("SELECT id FROM bateau WHERE immatriculation ='" + imma + "'");
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
                dg_veterinaire_bacpoissons_listebac.Show();
                lbl_veterinaire_bacpoissons_isbac.Hide();
                btn_veterinaire_bacpoissons_supprimerbacs.Show();
                btn_veterinaire_bacpoissons_modifierbacs.Show();
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
            CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_espece, "SELECT nom FROM espece", "nom");
            CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_taille, "SELECT id FROM Taille", "id");
            CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_qualite, "SELECT id FROM Qualite", "id");
            CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_presentation, "SELECT id FROM Presentation", "id");
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
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ces bacs ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                foreach (DataGridViewRow item in dg_veterinaire_bacpoissons_listebac.SelectedRows)
                {
                    string numBacLot = item.Cells[0].Value.ToString();
                    string id = numBacLot.Substring(0, numBacLot.IndexOf("("));
                    string idLot = numBacLot.Substring(numBacLot.IndexOf("(") + 1, numBacLot.Length - numBacLot.IndexOf("(") - 2);

                    if (numBacLot == "(Pas de lots)")
                    {
                        listebacnotlot.Remove(listebacnotlot.Find(ai => ai.Id == item.Cells["idBac"].Value.ToString()));
                    }
                    else
                    {
                        CURS cs = new CURS(chaineConnexion);
                        string requeteDel = "DELETE FROM bac WHERE idBateau='" + idbateau + "' AND idLot ='" + idLot + "' AND idDatePeche='" + Datejour + "' AND id ='" + id + "'";
                        cs.ReqAdmin(requeteDel);
                        cs.fermer();
                    }



                }
                string requeteSup = "DELETE LOT FROM lot LEFT JOIN bac ON lot.idDatePeche=bac.idDatePeche AND lot.idBateau=bac.idBateau AND lot.id=bac.idLot WHERE lot.idDatePeche='" + Datejour + "' AND lot.idBateau='" + idbateau + "'AND bac.id is NULL";
                CURS csa = new CURS(chaineConnexion);
                csa.ReqAdmin(requeteSup);
                csa.fermer();
                cbx_veterinaire_bacpoissons_listebateaux_SelectionChangeCommitted(sender, e);
                lbl_veterinaire_bacpoissons_validationok.Text = "Les bacs ont été supprimées";
                lbl_veterinaire_bacpoissons_validationok.Show();

                //lbl_veterinaire_lotspeche_islots

            }
        }
        private void btn_veterinaire_bacpoissons_modifierbacs_Click(object sender, EventArgs e)
        {

            HiddenObject.Hide(new List<Control> { btn_veterinaire_bacpoissons_valider, lbl_veterinaire_bacpoissons_validationok, btn_veterinaire_bacpoissons_creerbacs, lbl_veterinaire_bacpoissons_creationbac, btn_veterinaire_bacpoissons_valider });
            HiddenObject.Show(new List<Control> { btn_veterinaire_bacpoissons_modifierbacsValider, lbl_veterinaire_bacpoissons_modifierbacs, btn_veterinaire_bacpoissons_creerbacs, lbl_veterinaire_bacpoissons_espece, lbl_veterinaire_bacpoissons_taille, lbl_veterinaire_bacpoissons_qualite, lbl_veterinaire_bacpoissons_presentation, lbl_veterinaire_bacpoissons_typebac, cbx_veterinaire_bacpoissons_espece, cbx_veterinaire_bacpoissons_taille, cbx_veterinaire_bacpoissons_qualite, cbx_veterinaire_bacpoissons_presentation, cbx_veterinaire_bacpoissons_typebac, btn_veterinaire_bacpoissons_modifierbacsValider });
            Int32 selectedRowsCount = dg_veterinaire_bacpoissons_listebac.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowsCount != 1)
            {
                MessageBox.Show("Il n'est possible de modifier qu'un seul bac à la fois.", "Modification impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataGridViewRow item in dg_veterinaire_bacpoissons_listebac.SelectedRows)
            {
                string numBacLot = item.Cells[0].Value.ToString();
                if (numBacLot != "(Pas de lots)")
                {
                    cbx_veterinaire_bacpoissons_espece.Enabled = false;
                    cbx_veterinaire_bacpoissons_taille.Enabled = false;
                    cbx_veterinaire_bacpoissons_qualite.Enabled = false;
                    cbx_veterinaire_bacpoissons_presentation.Enabled = false;
                    idBacTabIsModifing = numBacLot.Substring(0, numBacLot.IndexOf("("));
                    idLotTabIsModifing = numBacLot.Substring(numBacLot.IndexOf("(") + 1, numBacLot.Length - numBacLot.IndexOf("(") - 2);
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

            }


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
                }
                else
                {
                    CURS csm = new CURS(chaineConnexion);
                    string requeteModif = "UPDATE bac SET idTypeBac ='" + cbx_veterinaire_bacpoissons_typebac.SelectedItem + "' WHERE idDatePeche ='" + Datejour + "' AND idBateau='" + idbateau + "' AND id='" + idBacTabIsModifing + "' AND idLot='" + idLotTabIsModifing + "'";
                    csm.ReqAdmin(requeteModif);
                    csm.fermer();
                }
                cbx_veterinaire_bacpoissons_listebateaux_SelectionChangeCommitted(sender, e);
                lbl_veterinaire_bacpoissons_validationok.Text = "Le bac a bien été modifié";
                lbl_veterinaire_bacpoissons_validationok.Show();


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
            bool islots = CompleteControl.RemplirDataGridViewByRequest(dg_veterinaire_lotspeche_lotsbateau, "SELECT idLot, count(idLot) as nbbac, espece.nom as nomEspece, idTaille, idPresentation, idQualite FROM bac INNER JOIN lot ON bac.idDatePeche=lot.idDatePeche AND bac.idBateau=lot.idBateau AND bac.idLot=lot.id INNER JOIN espece ON espece.id=lot.idEspece INNER JOIN bateau ON bateau.id=lot.idBateau AND bateau.id=bac.idBateau WHERE bac.idDatePeche='" + Datejour + "' AND immatriculation='" + imma + "' GROUP BY idLot", new string[] { "idLot", "nomEspece", "idTaille", "idQualite", "idPresentation", "nbbac" });
            if (islots)
            {
                lbl_veterinaire_lotspeche_islots.Hide();
                HiddenObject.Show(new List<Control> { dg_veterinaire_lotspeche_lotsbateau });
            }
            CURS cs = new CURS(chaineConnexion);
            cs.ReqSelect("SELECT id FROM bateau WHERE immatriculation ='" + imma + "'");
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
                CompleteControl.RemplirCombobox(cbx_veterinaire_lotspeche_lotsbateau, "SELECT lot.id as idLot, espece.nom as nomEspece, idTaille, idPresentation, idQualite FROM lot INNER JOIN espece ON espece.id=lot.idEspece INNER JOIN bateau ON bateau.id=lot.idBateau AND bateau.id=lot.idBateau WHERE lot.idDatePeche='" + Datejour + "' AND immatriculation='" + imma + "'", "#Lot n°#idLot (nomEspece:idTaille:idQualite:idPresentation)", false);
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
            int idlotmax = -1;
            foreach (DataGridViewRow row in dg_veterinaire_lotspeche_lotsbateau.Rows)
            {
                if (idlotmax < Int32.Parse(row.Cells[0].Value.ToString()))
                {
                    idlotmax = Int32.Parse(row.Cells[0].Value.ToString());
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
                CURS cs = new CURS(chaineConnexion);
                cs.ReqAdmin("INSERT INTO lot(idDatePeche,idBateau , id, idEspece, idTaille, idPresentation, idQualite) VALUES ('" + Datejour + "',(SELECT id FROM bateau WHERE immatriculation='" + imma + "')," + (idlotmax + 1) + ",(SELECT id FROM espece WHERE nom='" + etqplot[0] + "')," + etqplot[1] + ",'" + etqplot[3] + "','" + etqplot[2] + "')");
                cs.fermer();
                string requetesel = "INSERT INTO bac(id, idDatePeche,idBateau, idLot, idTypeBac) VALUES ";
                for (int i = 0; i < dg_veterinaire_lotspeche_bacnotlot.SelectedRows.Count; i++)
                {
                    requetesel += "(" + i + ",'" + Datejour + "',(SELECT id FROM bateau WHERE immatriculation='" + imma + "')," + (idlotmax + 1) + ",'" + dg_veterinaire_lotspeche_bacnotlot.SelectedRows[i].Cells["dgtbx_bacnotlots_typebac"].Value.ToString() + "'),";
                }
                requetesel = requetesel.Substring(0, requetesel.Length - 1);
                cs = new CURS(chaineConnexion);
                cs.ReqAdmin(requetesel);
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
                MatchCollection infolot = Regex.Matches(cbx_veterinaire_lotspeche_lotsbateau.Text.Substring(6), @"[a-zA-Z0-9]+");
                string numLot = infolot[0].Value;
                string nomEspece = infolot[1].Value;
                string idTaille = infolot[2].Value;
                string idQualite = infolot[3].Value;
                string idPresentation = infolot[4].Value;
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
                CURS cs = new CURS(chaineConnexion);
                cs.ReqSelect("SELECT max(id) as maxId FROM bac WHERE idDatePeche='" + Datejour + "' AND idBateau='" + idbateau + "' AND idLot='" + numLot + "'");
                int maxId = Int32.Parse(cs.champ("maxId").ToString());
                string requeteInsert = "";
                foreach (DataGridViewRow ligne in dg_veterinaire_lotspeche_bacnotlot.SelectedRows)
                {
                    maxId++;
                    requeteInsert += ",('" + maxId + "','" + Datejour + "','" + idbateau + "','" + numLot + "','" + ligne.Cells[4].Value.ToString() + "')";
                    listebacnotlot.Remove(listebacnotlot.Find(ai => ai.Id == ligne.Cells["id"].Value.ToString()));
                }
                cs = new CURS(chaineConnexion);
                cs.ReqAdmin("INSERT INTO bac(id, idDatePeche, idBateau,idLot, idTypeBac) VALUES " + requeteInsert.Substring(1));
                cbx_veterinaire_lotspeche_listebateaux_SelectionChangeCommitted(sender, e);
                lbl_veterinaire_lotspeche_isokcreerlot.Text = "Le ou les bacs ont bien été assignées au lot : " + numLot;
                lbl_veterinaire_lotspeche_isokcreerlot.ForeColor = Color.Blue;
                lbl_veterinaire_lotspeche_isokcreerlot.Show();
            }
        }
        #endregion

        #region Fermeture du formulaire
        private void AppCriee_Veterinaire_FormClosing(object sender, FormClosingEventArgs e)
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
                _authAccueil.Show();
            }
        }
        #endregion
    }
}