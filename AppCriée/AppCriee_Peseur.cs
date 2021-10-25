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
    public partial class AppCriee_Peseur : Form
    {
        #region Données privées
        string chaineConnexion = ConnectionChain.chaineConnexion();
        string Datejour = DateTime.Today.ToString("yyyy-MM-dd");
        #endregion

        #region Constructeur
        public AppCriee_Peseur(User unutilisateur)
        {
            InitializeComponent();
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
            HiddenObject.Show(new List<Control> { lbl_peseur_lotspeche_lotsbateau });
            String elmt_bateau = cbx_peseur_lotspeche_listebateaux.Text;
            int char_bateau = elmt_bateau.IndexOf("(");
            String imma = elmt_bateau.Substring(char_bateau + 1, elmt_bateau.Length - char_bateau - 2);
            lbl_peseur_lotspeche_lotsbateau.Text = "Liste de tous les lots du Bateau '" + elmt_bateau.Substring(0, char_bateau) + "' :";
            bool islots = CompleteControl.RemplirDataGridViewByRequest(dg_peseur_lotspeche_lotsbateau, "SELECT idLot, count(idLot) as nbbac, espece.nom as nomEspece, idTaille, idPresentation, idQualite FROM bac INNER JOIN lot ON bac.idDatePeche=lot.idDatePeche AND bac.idBateau=lot.idBateau AND bac.idLot=lot.id INNER JOIN espece ON espece.id=lot.idEspece INNER JOIN bateau ON bateau.id=lot.idBateau AND bateau.id=bac.idBateau WHERE bac.idDatePeche='" + Datejour + "' AND immatriculation='" + imma + "' GROUP BY idLot", new string[] { "idLot", "nomEspece", "idTaille", "idQualite", "idPresentation", "nbbac" });
            if (islots == true)
            {
                lbl_peseur_lotspeche_islots.Hide();
                HiddenObject.Show(new List<Control> { dg_peseur_lotspeche_lotsbateau });
            }
            else
            {
                HiddenObject.Hide(new List<Control> { dg_peseur_lotspeche_lotsbateau, lbl_peseur_lotspeche_lotsbateau,  });
                lbl_peseur_lotspeche_islots.Show();
            }
        }
        #endregion



        private void AppCriee_Peseur_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
