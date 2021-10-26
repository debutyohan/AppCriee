﻿using System;
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
        string chaineConnexion = ConnectionChain.chaineConnexion();
        string Datejour = DateTime.Today.ToString("yyyy-MM-dd");
        string idLotisWeightModifing = "";
        string idBacisWeightModifing = "";
        DataGridViewCellMouseEventArgs dernierclic;
        int idbateau;
        AppCriee _authAccueil;
        #endregion

        #region Constructeur
        public AppCriee_Peseur(User unutilisateur, AppCriee authAccueil)
        {
            InitializeComponent();
            _authAccueil = authAccueil;
            lbl_peseur_accueil_bienvenue.Text = "Bienvenue " + unutilisateur.Nom + " " + unutilisateur.Prenom;
            lbl_peseur_lotspeche_datejour.Text = "Date du jour : " + DateTime.Today.ToString("dd/MM/yyyy");
            HiddenObject.Hide(new List<Control> { lbl_peseur_lotspeche_choixbateau });
        }

        #endregion

        #region Changement d'onglet
        private void tbc_peseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_peseur_lotspeche_listebateaux.SelectedItem is null)
            {
                if (CompleteControl.RemplirCombobox(cbx_peseur_lotspeche_listebateaux, "SELECT idBateau, nom, immatriculation FROM peche INNER JOIN Bateau ON peche.idBateau=Bateau.id WHERE DatePeche='" + Datejour + "'", "nom(immatriculation)", false))
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
            idLotisWeightModifing = "";
            idBacisWeightModifing = "";
            HiddenObject.Show(new List<Control> { lbl_peseur_lotspeche_lotsbateau });
            HiddenObject.Hide(new List<Control> { lbl_peseur_lotspeche_saisirpoids, tbx_peseur_lotspeche_saisirpoids, lbl_peseur_lotspeche_validationok, btn_peseur_lotspeche_validersaisiepoids, dg_peseur_lotspeche_bacs, btn_peseur_lotspeche_saisirpoids, lbl_peseur_lotspeche_bacdulot });
            String elmt_bateau = cbx_peseur_lotspeche_listebateaux.Text;
            int char_bateau = elmt_bateau.IndexOf("(");
            String imma = elmt_bateau.Substring(char_bateau + 1, elmt_bateau.Length - char_bateau - 2);
            CURS cs = new CURS(chaineConnexion);
            cs.ReqSelect("SELECT id FROM bateau WHERE immatriculation ='" + imma + "'");
            idbateau = Int32.Parse(cs.champ("id").ToString());
            lbl_peseur_lotspeche_lotsbateau.Text = "Liste de tous les lots du Bateau '" + elmt_bateau.Substring(0, char_bateau) + "' :";
            bool islots = CompleteControl.RemplirDataGridViewByRequest(dg_peseur_lotspeche_lotsbateau, "SELECT idLot, count(idLot) as nbbac, espece.nom as nomEspece, idTaille, idPresentation, idQualite FROM bac INNER JOIN lot ON bac.idDatePeche=lot.idDatePeche AND bac.idBateau=lot.idBateau AND bac.idLot=lot.id INNER JOIN espece ON espece.id=lot.idEspece INNER JOIN bateau ON bateau.id=lot.idBateau AND bateau.id=bac.idBateau WHERE bac.idDatePeche='" + Datejour + "' AND immatriculation='" + imma + "' GROUP BY idLot", new string[] { "idLot", "nomEspece", "idTaille", "idQualite", "idPresentation", "nbbac" });
            if (islots == true)
            {
                lbl_peseur_lotspeche_islots.Hide();
                HiddenObject.Show(new List<Control> { dg_peseur_lotspeche_lotsbateau });
                dg_peseur_lotspeche_lotsbateau.SelectedRows[0].Selected = false;
            }
            else
            {
                HiddenObject.Hide(new List<Control> { dg_peseur_lotspeche_lotsbateau, lbl_peseur_lotspeche_lotsbateau,  });
                lbl_peseur_lotspeche_islots.Show();
            }
        }
        #endregion

        #region Fermeture du formulaire
        private void AppCriee_Peseur_FormClosing(object sender, FormClosingEventArgs e)
        {
            _authAccueil.Show();
        }
        #endregion



        private void dg_peseur_lotspeche_lotsbateau_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dernierclic = e;
            HiddenObject.Hide(new List<Control> { lbl_peseur_lotspeche_saisirpoids, tbx_peseur_lotspeche_saisirpoids, lbl_peseur_lotspeche_validationok, btn_peseur_lotspeche_validersaisiepoids });
            DataGridViewRow ligneselectionne = dg_peseur_lotspeche_lotsbateau.SelectedRows[0];
            idLotisWeightModifing = ligneselectionne.Cells[0].Value.ToString();
            CompleteControl.RemplirDataGridViewByRequest(dg_peseur_lotspeche_bacs, "SELECT bac.id as idBac, idTypeBac, tare, IF(ISNULL(poidsbrutBac)OR poidsbrutBac='0.00', 'Non saisie', poidsbrutBac) as poidsbrut FROM bac INNER JOIN typebac ON typebac.id=bac.idTypeBac WHERE idDatePeche='" + Datejour + "' AND idBateau='" + idbateau + "' AND idLot='" + idLotisWeightModifing + "' ORDER BY bac.id",new string[] { "idBac", "idTypeBac", "tare", "poidsbrut" });
            HiddenObject.Show(new List<Control> { dg_peseur_lotspeche_bacs, btn_peseur_lotspeche_saisirpoids, lbl_peseur_lotspeche_bacdulot });
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
            if(poids != "Non saisie")
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
            string nouvpoids = "'" + tbx_peseur_lotspeche_saisirpoids.Text + "'";
            if (nouvpoids == "''")
            {
                nouvpoids = "null";
            }
            HiddenObject.Hide(new List<Control> { tbx_peseur_lotspeche_saisirpoids, lbl_peseur_lotspeche_saisirpoids, btn_peseur_lotspeche_validersaisiepoids });
            CURS cs = new CURS(chaineConnexion);
            cs.ReqAdmin("UPDATE bac SET poidsbrutbac=" + nouvpoids + " WHERE idDatePeche='" + Datejour + "' AND idBateau='" + idbateau + "' AND idLot='" + idLotisWeightModifing + "' AND id='" + idBacisWeightModifing + "'");
            cs.fermer();
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
            if (tbx_peseur_lotspeche_saisirpoids.Text.Contains('.')&& e.KeyChar == '.')
            {
                result = true;
            }

            e.Handled = result;

        }

    }
}
