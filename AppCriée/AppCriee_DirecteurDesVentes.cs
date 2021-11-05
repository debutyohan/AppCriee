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
    public partial class AppCriee_DirecteurDesVentes : Form
    {
        #region Données privées

        AppCriee _authAccueil;
        string Datejour = DateTime.Today.ToString("yyyy-MM-dd");
        User _useractuelle;

        #endregion

        #region Constructeur

        public AppCriee_DirecteurDesVentes(User unutilisateur, AppCriee authAccueil)
        {
            InitializeComponent();
            _authAccueil = authAccueil;
            _useractuelle = unutilisateur;
            lbl_directeurdesventes_accueil_bienvenue.Text = "Bienvenue " + unutilisateur.Nom + " " + unutilisateur.Prenom;
            lbl_directeurdesventes_datejour.Text = "Date du jour : " + DateTime.Today.ToString("dd/MM/yyyy");
        }

        #endregion

        #region Changement d'onglets


        private void tbc_directeurdesventes_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPage.Name)
            {
                case "tbp_directeurdesventes_lotsvente":
                    CURS cs = new CURS();
                    cs.ReqSelectPrepare("SELECT count(id) as nblot FROM lot WHERE codeEtat is not null", new List<object> { Datejour });
                    if (cs.champ("nblot").ToString() == "0")
                    {
                        lbl_directeurdesventes_lotsvente_islots.Show();
                        dg_directeurdesventes_lotsvente_alllot.Hide();
                    }
                    else
                    {
                        if (CompleteControl.RemplirDataGridViewByRequest(dg_directeurdesventes_lotsvente_alllot, "SELECT bateau.nom as nomBateau, idLot, count(idLot) as nbbac, espece.nom as nomEspece, idTaille, idPresentation, idQualite, SUM(poidsbrutBac) as poidstotal, codeEtat, bateau.id as idBateau FROM bac INNER JOIN lot ON bac.idDatePeche=lot.idDatePeche AND bac.idBateau=lot.idBateau AND bac.idLot=lot.id INNER JOIN espece ON espece.id=lot.idEspece INNER JOIN bateau ON bateau.id=lot.idBateau AND bateau.id=bac.idBateau WHERE bac.idDatePeche=? AND codeEtat IS NOT NULL GROUP BY idLot, lot.idBateau ORDER BY bateau.nom, idLot", new string[] { "nomBateau", "idLot", "nomEspece", "idTaille", "idQualite", "idPresentation", "nbbac", "poidstotal", "codeEtat", "idBateau" }, new List<object> { Datejour }))
                        {
                            foreach (DataGridViewRow ligne in dg_directeurdesventes_lotsvente_alllot.Rows)
                            {
                                string numLotLot = ligne.Cells[1].Value.ToString();
                                string numLotBateau = ligne.Cells[9].Value.ToString();
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
                            }
                            dg_directeurdesventes_lotsvente_alllot.Show();
                            lbl_directeurdesventes_lotsvente_islots.Hide();
                        }
                    }
                    break;

            }

        }
        #endregion

        #region Onglet Mes Données

        private void btn_peseur_mesdonnees_supprimer_Click(object sender, EventArgs e)
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
                        MessageBox.Show("L'envoi du mail de confirmation n'a pas pu être envoyé\n" + exception.Message, "Echec envoi mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #region Fermeture du Formulaire

        private void AppCriee_DirecteurDesVentes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_useractuelle != null)
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
        private void pbx_directeurdesventes_deconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

    }
}
