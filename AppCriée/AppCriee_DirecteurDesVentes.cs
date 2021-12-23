using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppCriée
{
    public partial class AppCriee_DirecteurDesVentes : Form
    {
        #region Données privées

        AppCriee _authAccueil;
        string Datejour = DateTime.Today.ToString("yyyy-MM-dd");
        User _useractuelle;
        TabControlEventArgs _onglet;
        string idUserModified;

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
            _onglet = e;
            switch (e.TabPage.Name)
            {
                case "tbp_directeurdesventes_accueil":
                    lbl_directeurdesventes_accueil_bienvenue.Text = "Bienvenue " + _useractuelle.Nom + " " + _useractuelle.Prenom;
                    break;
                case "tbp_directeurdesventes_lotsvente":
                    CURS cs = new CURS();
                    cs.ReqSelectPrepare("SELECT count(idLot) as nblot FROM Lot WHERE codeEtat='M'", new List<object> { Datejour });
                    if (cs.champ("nblot").ToString() == "0")
                    {
                        lbl_directeurdesventes_lotsvente_islots.Show();
                        dg_directeurdesventes_lotsvente_alllot.Hide();
                    }
                    else
                    {
                        if (CompleteControl.RemplirDataGridViewByRequest(dg_directeurdesventes_lotsvente_alllot, "SELECT Bateau.nom as nomBateau, Bac.idLot as idLot, count(Bac.idLot) as nbbac, Espece.nom as nomEspece, idTaille, idPresentation, idQualite, SUM(poidsbrutBac) as poidstotal, codeEtat, Bateau.id as idBateau FROM Bac INNER JOIN Lot ON Bac.idDatePeche=Lot.idDatePeche AND Bac.idBateau=Lot.idBateau AND Bac.idLot=Lot.idLot INNER JOIN Espece ON Espece.id=Lot.idEspece INNER JOIN Bateau ON Bateau.id=Lot.idBateau AND Bateau.id=Bac.idBateau INNER JOIN Peche ON Peche.datePeche=Lot.idDatePeche AND Peche.idBateau=Lot.idBateau AND Peche.idBateau=Bateau.id AND Peche.DatePeche=Bac.idDatePeche AND Peche.idBateau=Bac.idBateau WHERE Bac.idDatePeche=? AND codeEtat='M' GROUP BY Bac.idLot, Lot.idBateau ORDER BY heureArrivee, Bac.idLot", new string[] { "nomBateau", "idLot", "nomEspece", "idTaille", "idQualite", "idPresentation", "nbbac", "poidstotal", "codeEtat", "idBateau" }, new List<object> { Datejour }))
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
                case "tbp_directeurdesventes_mesdonnees":
                    HiddenObject.Hide(new List<Control> { lbl_directeurdesventes_mesdonnees_modificationmdp, lbl_directeurdesventes_mesdonnees_validationmodif, lbl_directeurdesventes_mesdonnees_mdpactuel, tbx_directeurdesventes_mesdonnees_mdpactuel, lbl_directeurdesventes_mesdonnees_newmdp, tbx_directeurdesventes_mesdonnees_newmdp, lbl_directeurdesventes_mesdonnees_confirmationnewmdp, tbx_directeurdesventes_mesdonnees_confirmationnewmdp, btn_directeurdesventes_mesdonnees_validermodifmdp, lbl_directeurdesventes_mesdonnees_validationmodiferreur, lbl_directeurdesventes_mesdonnees_modification, lbl_directeurdesventes_mesdonnees_modifieradrMail, lbl_directeurdesventes_mesdonnees_modifierlogin, lbl_directeurdesventes_mesdonnees_modifiernom, lbl_directeurdesventes_mesdonnees_modifierprenom, tbx_directeurdesventes_mesdonnees_login, tbx_directeurdesventes_mesdonnees_nom, tbx_directeurdesventes_mesdonnees_adrMail, tbx_directeurdesventes_mesdonnees_prenom, btn_directeurdesventes_mesdonnees_validermodif, lbl_directeurdesventes_mesdonnees_champsobli, lbl_directeurdesventes_mesdonnees_validationmodif, lbl_directeurdesventes_mesdonnees_validationmodiferreur, });
                    lbl_directeurdesventes_mesdonnees_login.Text = "Login : " + _useractuelle.Login;
                    lbl_directeurdesventes_mesdonnees_prenom.Text = "Prénom : " + _useractuelle.Prenom;
                    lbl_directeurdesventes_mesdonnees_nom.Text = "Nom : " + _useractuelle.Nom;
                    lbl_directeurdesventes_mesdonnees_adrMail.Text = "Adresse Mail : " + _useractuelle.AdrMail;
                    lbl_directeurdesventes_mesdonnees_typeuser.Text = "Type utilisateur : " + _useractuelle.Libelletype;
                    if (_useractuelle.AdrMail == "")
                    {
                        lbl_directeurdesventes_mesdonnees_adrMail.Text = "Adresse Mail : (Non communiquée)";
                    }
                    if (_useractuelle.Nom == "")
                    {
                        lbl_directeurdesventes_mesdonnees_nom.Text = "Nom : (Non communiquée)";
                    }
                    if (_useractuelle.Prenom == "")
                    {
                        lbl_directeurdesventes_mesdonnees_prenom.Text = "Prénom : (Non communiquée)";
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
                cs.ReqAdminPrepare("DELETE FROM Utilisateur WHERE id=?", new List<object> { _useractuelle.Id });
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

        private void btn_directeurdesventes_mesdonnees_modifier_Click(object sender, EventArgs e)
        {
            HiddenObject.Show(new List<Control> { lbl_directeurdesventes_mesdonnees_modification, lbl_directeurdesventes_mesdonnees_modifieradrMail, lbl_directeurdesventes_mesdonnees_modifierlogin, lbl_directeurdesventes_mesdonnees_modifiernom, lbl_directeurdesventes_mesdonnees_modifierprenom, tbx_directeurdesventes_mesdonnees_login, tbx_directeurdesventes_mesdonnees_nom, tbx_directeurdesventes_mesdonnees_adrMail, tbx_directeurdesventes_mesdonnees_prenom, btn_directeurdesventes_mesdonnees_validermodif, lbl_directeurdesventes_mesdonnees_champsobli });
            HiddenObject.Hide(new List<Control> { btn_directeurdesventes_mesdonnees_validermodifmdp, lbl_directeurdesventes_mesdonnees_mdpactuel, tbx_directeurdesventes_mesdonnees_mdpactuel, lbl_directeurdesventes_mesdonnees_newmdp, tbx_directeurdesventes_mesdonnees_newmdp, lbl_directeurdesventes_mesdonnees_confirmationnewmdp, tbx_directeurdesventes_mesdonnees_confirmationnewmdp, lbl_directeurdesventes_mesdonnees_modificationmdp });
            tbx_directeurdesventes_mesdonnees_login.Text = _useractuelle.Login;
            if (_useractuelle.Nom.ToString().Trim() == "(Non communiqué)")
            {
                tbx_directeurdesventes_mesdonnees_nom.Text = "";
            }
            else
            {
                tbx_directeurdesventes_mesdonnees_nom.Text = _useractuelle.Nom.ToString().Trim();
            }
            if (_useractuelle.Prenom.ToString().Trim() == "(Non communiqué)")
            {
                tbx_directeurdesventes_mesdonnees_prenom.Text = "";
            }
            else
            {
                tbx_directeurdesventes_mesdonnees_prenom.Text = _useractuelle.Prenom.ToString();
            }
            if (_useractuelle.AdrMail.ToString().Trim() == "(Non communiquée)")
            {
                tbx_directeurdesventes_mesdonnees_adrMail.Text = "";
            }
            else
            {
                tbx_directeurdesventes_mesdonnees_adrMail.Text = _useractuelle.AdrMail.ToString();
            }
            lbl_directeurdesventes_mesdonnees_validationmodif.Hide();
        }

        private void btn_directeurdesventes_mesdonnees_validermodif_Click(object sender, EventArgs e)
        {
            idUserModified = _useractuelle.Id.ToString();
            if (tbx_directeurdesventes_mesdonnees_login.Text == "")
            {
                lbl_directeurdesventes_mesdonnees_validationmodiferreur.Text = "Tous les champs obligatoires doivent être remplis";
                lbl_directeurdesventes_mesdonnees_validationmodiferreur.Show();
                return;
            }
            if (tbx_directeurdesventes_mesdonnees_adrMail.Text.Trim() != "" && !(Regex.IsMatch(tbx_directeurdesventes_mesdonnees_adrMail.Text, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")))
            {
                lbl_directeurdesventes_mesdonnees_validationmodiferreur.Text = "L’adresse mail saisie n’est pas correcte";
                lbl_directeurdesventes_mesdonnees_validationmodiferreur.Show();
                return;
            }

            object adrMail = tbx_directeurdesventes_mesdonnees_adrMail.Text;
            if (adrMail.ToString().Trim() == "")
            {
                adrMail = null;
            }
            object nomModif = tbx_directeurdesventes_mesdonnees_nom.Text;
            if (nomModif.ToString().Trim() == "")
            {
                nomModif = null;
            }
            object prenomModif = tbx_directeurdesventes_mesdonnees_prenom.Text;
            if (prenomModif.ToString().Trim() == "")
            {
                prenomModif = null;
            }

            CURS cs = new CURS();
            cs.ReqAdminPrepare("UPDATE Utilisateur SET login=?, nomuser=?, prenomuser=?, adrMail=? WHERE id=?", new List<object> { tbx_directeurdesventes_mesdonnees_login.Text, nomModif, prenomModif, adrMail, idUserModified });
            cs.fermer();
            lbl_directeurdesventes_mesdonnees_validationmodif.Text = "Vos données ont bien été modifiées.\n";
            HiddenObject.Hide(new List<Control> { lbl_directeurdesventes_mesdonnees_modificationmdp, lbl_directeurdesventes_mesdonnees_validationmodiferreur, lbl_directeurdesventes_mesdonnees_modification, lbl_directeurdesventes_mesdonnees_modifieradrMail, lbl_directeurdesventes_mesdonnees_modifierlogin, lbl_directeurdesventes_mesdonnees_modifiernom, lbl_directeurdesventes_mesdonnees_modifierprenom, tbx_directeurdesventes_mesdonnees_login, tbx_directeurdesventes_mesdonnees_nom, tbx_directeurdesventes_mesdonnees_adrMail, tbx_directeurdesventes_mesdonnees_prenom, btn_directeurdesventes_mesdonnees_validermodif, lbl_directeurdesventes_mesdonnees_champsobli });

            _useractuelle.Login = tbx_directeurdesventes_mesdonnees_login.Text;
            _useractuelle.Nom = tbx_directeurdesventes_mesdonnees_nom.Text.Trim();
            _useractuelle.Prenom = tbx_directeurdesventes_mesdonnees_prenom.Text.Trim();
            _useractuelle.AdrMail = tbx_directeurdesventes_mesdonnees_adrMail.Text.Trim();

            lbl_directeurdesventes_mesdonnees_login.Text = "Login : " + _useractuelle.Login.ToString();
            lbl_directeurdesventes_mesdonnees_nom.Text = "Nom : " + _useractuelle.Nom.ToString();
            lbl_directeurdesventes_mesdonnees_prenom.Text = "Prénom : " + _useractuelle.Prenom.ToString();
            lbl_directeurdesventes_mesdonnees_adrMail.Text = "Adresse Mail : " + _useractuelle.AdrMail.ToString();

            tbc_directeurdesventes_Selected(sender, _onglet);
            lbl_directeurdesventes_mesdonnees_validationmodif.Show();
        }

        private void btn_directeurdesventes_mesdonnees_modifiermdp_Click(object sender, EventArgs e)
        {
            HiddenObject.Hide(new List<Control> { lbl_directeurdesventes_mesdonnees_modifieradrMail, lbl_directeurdesventes_mesdonnees_modifierlogin, lbl_directeurdesventes_mesdonnees_modifiernom, lbl_directeurdesventes_mesdonnees_modifierprenom, tbx_directeurdesventes_mesdonnees_login, tbx_directeurdesventes_mesdonnees_nom, tbx_directeurdesventes_mesdonnees_prenom, tbx_directeurdesventes_mesdonnees_adrMail, lbl_directeurdesventes_mesdonnees_modification, btn_directeurdesventes_mesdonnees_validermodif, lbl_directeurdesventes_mesdonnees_champsobli, lbl_directeurdesventes_mesdonnees_validationmodif, lbl_directeurdesventes_mesdonnees_validationmodiferreur });
            HiddenObject.Show(new List<Control> { lbl_directeurdesventes_mesdonnees_modificationmdp, lbl_directeurdesventes_mesdonnees_mdpactuel, tbx_directeurdesventes_mesdonnees_mdpactuel, lbl_directeurdesventes_mesdonnees_newmdp, tbx_directeurdesventes_mesdonnees_newmdp, lbl_directeurdesventes_mesdonnees_confirmationnewmdp, tbx_directeurdesventes_mesdonnees_confirmationnewmdp, btn_directeurdesventes_mesdonnees_validermodifmdp });
            tbx_directeurdesventes_mesdonnees_mdpactuel.Text = "";
            tbx_directeurdesventes_mesdonnees_newmdp.Text = "";
            tbx_directeurdesventes_mesdonnees_confirmationnewmdp.Text = "";
        }

        private void btn_directeurdesventes_mesdonnees_validermodifmdp_Click(object sender, EventArgs e)
        {
            idUserModified = _useractuelle.Id.ToString();
            String passwdhash = new HashData(tbx_directeurdesventes_mesdonnees_mdpactuel.Text).HashCalculate();
            if (tbx_directeurdesventes_mesdonnees_mdpactuel.Text == "")
            {
                lbl_directeurdesventes_mesdonnees_validationmodiferreur.Text = "Tous les champs obligatoires doivent être remplis";
                lbl_directeurdesventes_mesdonnees_validationmodiferreur.Show();
                return;
            }
            if (tbx_directeurdesventes_mesdonnees_newmdp.Text == "")
            {
                lbl_directeurdesventes_mesdonnees_validationmodiferreur.Text = "Tous les champs obligatoires doivent être remplis";
                lbl_directeurdesventes_mesdonnees_validationmodiferreur.Show();
                return;
            }
            if (tbx_directeurdesventes_mesdonnees_confirmationnewmdp.Text == "")
            {
                lbl_directeurdesventes_mesdonnees_validationmodiferreur.Text = "Tous les champs obligatoires doivent être remplis";
                lbl_directeurdesventes_mesdonnees_validationmodiferreur.Show();
                return;
            }

            CURS cs = new CURS();
            cs.ReqSelectPrepare("CALL Auth(?,?)", new List<object> { _useractuelle.Login, passwdhash });
            if (cs.champ("nbUser").ToString() == "0")
            {
                lbl_directeurdesventes_mesdonnees_validationmodiferreur.Text = "Votre mot de passe actuel est incorrect.";
                lbl_directeurdesventes_mesdonnees_validationmodiferreur.Show();
                return;
            }
            cs.fermer();

            if (!(Regex.IsMatch(tbx_directeurdesventes_mesdonnees_newmdp.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")))
            {
                lbl_directeurdesventes_mesdonnees_validationmodiferreur.Text = "Le mot de passe doit contenir au moins 10 caractères\ncomportant majuscule, minuscules, chiffres et caractères spéciaux";
                lbl_directeurdesventes_mesdonnees_validationmodiferreur.Show();
                return;
            }

            if (tbx_directeurdesventes_mesdonnees_newmdp.Text != tbx_directeurdesventes_mesdonnees_confirmationnewmdp.Text)
            {
                lbl_directeurdesventes_mesdonnees_validationmodiferreur.Text = "Les mots de passes ne correspondent pas, veuillez réessayer.";
                lbl_directeurdesventes_mesdonnees_validationmodiferreur.Show();
                return;
            }

            string motdepassehash = new HashData(tbx_directeurdesventes_mesdonnees_newmdp.Text).HashCalculate();
            CURS csm = new CURS();
            csm.ReqAdminPrepare("UPDATE Utilisateur SET pwd=? WHERE id=? ", new List<object> { motdepassehash, idUserModified });
            csm.fermer();
            lbl_directeurdesventes_mesdonnees_validationmodif.Text = "Votre mot de passe a bien été modifié.";
            lbl_directeurdesventes_mesdonnees_validationmodif.Show();
            HiddenObject.Hide(new List<Control> { lbl_directeurdesventes_mesdonnees_modificationmdp, lbl_directeurdesventes_mesdonnees_validationmodiferreur, lbl_directeurdesventes_mesdonnees_mdpactuel, tbx_directeurdesventes_mesdonnees_mdpactuel, lbl_directeurdesventes_mesdonnees_newmdp, tbx_directeurdesventes_mesdonnees_newmdp, lbl_directeurdesventes_mesdonnees_confirmationnewmdp, tbx_directeurdesventes_mesdonnees_confirmationnewmdp, btn_directeurdesventes_mesdonnees_validermodifmdp });

        }
        #endregion

        #region Fermeture du Formulaire

        private void AppCriee_DirecteurDesVentes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_useractuelle != null)
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
