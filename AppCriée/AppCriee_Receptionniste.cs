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
    public partial class AppCriee_Receptionniste : Form
    {
        #region Données privées

        string Datejour = DateTime.Today.ToString("yyyy-MM-dd");
        AppCriee _authAccueil;
        User _useractuelle;
        TabControlEventArgs _onglet;
        string idUserModified;

        #endregion

        #region Constructeur

        public AppCriee_Receptionniste(User unutilisateur, AppCriee authAccueil)
        {
            _authAccueil = authAccueil;
            _useractuelle = unutilisateur;
            InitializeComponent();
            lbl_accueil_bienvenue.Text = "Bienvenue " + unutilisateur.Nom + " " + unutilisateur.Prenom;
            lbl_receptionniste_datejour.Text = "Date du jour : " + DateTime.Today.ToString("dd/MM/yyyy");
            HiddenObject.Hide(new List<Control> { lbl_pechejour_allpeche, dg_pechejour, lbl_ajoutpeche_creerpeche_nombateau, cbx_ajoutpeche_creerpeche_nombateau, btn_pechejour_creerpeche_valider, lbl_pechejour_pecheok });
           
        }

        #endregion

        #region Changement d'onglet
        private void tbc_receptionniste_Selected(object sender, TabControlEventArgs e)
        {
            lbl_pechejour_pecheok.Hide();
            _onglet = e;
            switch (e.TabPage.Name)
            {
                case "tabAccueil":
                    lbl_accueil_bienvenue.Text = "Bienvenue " + _useractuelle.Nom + " " + _useractuelle.Prenom;
                    break;
                case "tabPeche":
                CURS cs = new CURS();
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
                }
                else
                {
                    HiddenObject.Hide(new List<Control> { dg_pechejour, btn_receptionniste_peche_supprimer });
                }
                    break;                     
                case "tbp_receptionniste_mesdonnees":
                    HiddenObject.Hide(new List<Control> { lbl_receptionniste_mesdonnees_modificationmdp, lbl_receptionniste_mesdonnees_validationmodif, lbl_receptionniste_mesdonnees_mdpactuel, tbx_receptionniste_mesdonnees_mdpactuel, lbl_receptionniste_mesdonnees_newmdp, tbx_receptionniste_mesdonnees_newmdp, lbl_receptionniste_mesdonnees_confirmationnewmdp, tbx_receptionniste_mesdonnees_confirmationnewmdp, btn_receptionniste_mesdonnees_validermodifmdp, lbl_receptionniste_mesdonnees_validationmodiferreur, lbl_receptionniste_mesdonnees_modification, lbl_receptionniste_mesdonnees_modifieradrMail, lbl_receptionniste_mesdonnees_modifierlogin, lbl_receptionniste_mesdonnees_modifiernom, lbl_receptionniste_mesdonnees_modifierprenom, tbx_receptionniste_mesdonnees_login, tbx_receptionniste_mesdonnees_nom, tbx_receptionniste_mesdonnees_adrMail, tbx_receptionniste_mesdonnees_prenom, btn_receptionniste_mesdonnees_validermodif, lbl_receptionniste_mesdonnees_champsobli, lbl_receptionniste_mesdonnees_validationmodif, lbl_receptionniste_mesdonnees_validationmodiferreur, });
                    lbl_receptionniste_mesdonnees_login.Text = "Login : " + _useractuelle.Login;
                    lbl_receptionniste_mesdonnees_prenom.Text = "Prénom : " + _useractuelle.Prenom;
                    lbl_receptionniste_mesdonnees_nom.Text = "Nom : " + _useractuelle.Nom;
                    lbl_receptionniste_mesdonnees_adrMail.Text = "Adresse Mail : " + _useractuelle.AdrMail;
                    lbl_receptionniste_mesdonnees_typeuser.Text = "Type utilisateur : " + _useractuelle.Libelletype;
                    if (_useractuelle.AdrMail == "")
                    {
                        lbl_receptionniste_mesdonnees_adrMail.Text = "Adresse Mail : (Non communiquée)";
                    }
                    if (_useractuelle.Nom == "")
                    {
                        lbl_receptionniste_mesdonnees_nom.Text = "Nom : (Non communiquée)";
                    }
                    if (_useractuelle.Prenom == "")
                    {
                        lbl_receptionniste_mesdonnees_prenom.Text = "Prénom : (Non communiquée)";
                    }
                        break;
            }
             
        }

        #endregion

        #region Onglet Créer une pêche

        private void btn_receptionniste_creerpeche_Click(object sender, EventArgs e)
        {
            HiddenObject.Show(new List<Control> { lbl_ajoutpeche_creerpeche_nombateau, cbx_ajoutpeche_creerpeche_nombateau, btn_pechejour_creerpeche_valider });
            btn_ajoutpeche_creerpeche.Hide();
            lbl_pechejour_pecheok.Hide();
            CompleteControl.RemplirCombobox(cbx_ajoutpeche_creerpeche_nombateau, "SELECT bateau.id, nom, immatriculation FROM peche RIGHT JOIN bateau ON peche.idBateau=Bateau.id  WHERE bateau.id NOT IN(SELECT DISTINCT idBateau FROM peche WHERE datePeche=?) GROUP BY bateau.id ORDER BY count(*)*(NOT(ISNULL(peche.datePeche))) DESC", "nom(immatriculation)", new List<object> { Datejour });
        }
        private void btn_receptionniste_creerpeche_valider_Click(object sender, EventArgs e)
        {
            String elmt_bateau = cbx_ajoutpeche_creerpeche_nombateau.SelectedItem.ToString();
            int char_bateau = elmt_bateau.IndexOf("(");
            string nomBateau = elmt_bateau.Substring(0, char_bateau);
            String imma = elmt_bateau.Substring(char_bateau + 1, elmt_bateau.Length - char_bateau - 2);
            CURS cs = new CURS();
            cs.ReqAdminPrepare("INSERT INTO Peche(DatePeche, idBateau) VALUES (?,(SELECT id FROM Bateau WHERE immatriculation = ?))", new List<object> { Datejour, imma });
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
                    CURS cs = new CURS();
                    cs.ReqSelectPrepare("SELECT COUNT(lot.id) as nbLot FROM lot INNER JOIN bateau ON lot.idBateau = bateau.id WHERE immatriculation=? AND idDatePeche=?", new List<object> { item.Cells[1].Value, Datejour });
                    string nbLot = cs.champ("nbLot").ToString();
                    if (cs.champ("nbLot").ToString() != "0")
                    {
                        listImmaIsLot += ", " + item.Cells[0].Value;
                    }
                    else
                    {
                        listImmaIsNoLot += ", " + item.Cells[0].Value;
                        dg_pechejour.Rows.RemoveAt(item.Index);
                        cs = new CURS();
                        cs.ReqAdminPrepare("DELETE peche FROM peche INNER JOIN bateau ON peche.idBateau = bateau.id WHERE peche.datePeche =? AND immatriculation=?", new List<object> { Datejour, item.Cells[1].Value });
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

        #region Onglet Mes Données

        private void btn_receptionniste_mesdonnees_supprimer_Click(object sender, EventArgs e)
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
        private void btn_receptionniste_mesdonnees_modifier_Click(object sender, EventArgs e)
        {
            HiddenObject.Show(new List<Control> { lbl_receptionniste_mesdonnees_modification, lbl_receptionniste_mesdonnees_modifieradrMail, lbl_receptionniste_mesdonnees_modifierlogin, lbl_receptionniste_mesdonnees_modifiernom, lbl_receptionniste_mesdonnees_modifierprenom, tbx_receptionniste_mesdonnees_login, tbx_receptionniste_mesdonnees_nom, tbx_receptionniste_mesdonnees_adrMail, tbx_receptionniste_mesdonnees_prenom, btn_receptionniste_mesdonnees_validermodif, lbl_receptionniste_mesdonnees_champsobli });
            HiddenObject.Hide(new List<Control> { btn_receptionniste_mesdonnees_validermodifmdp, lbl_receptionniste_mesdonnees_mdpactuel, tbx_receptionniste_mesdonnees_mdpactuel, lbl_receptionniste_mesdonnees_newmdp, tbx_receptionniste_mesdonnees_newmdp, lbl_receptionniste_mesdonnees_confirmationnewmdp, tbx_receptionniste_mesdonnees_confirmationnewmdp, lbl_receptionniste_mesdonnees_modificationmdp });
            tbx_receptionniste_mesdonnees_login.Text = _useractuelle.Login;
            if (_useractuelle.Nom.ToString().Trim() == "(Non communiqué)")
            {
                tbx_receptionniste_mesdonnees_nom.Text = "";
            }
            else
            {
                tbx_receptionniste_mesdonnees_nom.Text = _useractuelle.Nom.ToString().Trim();
            }
            if (_useractuelle.Prenom.ToString().Trim() == "(Non communiqué)")
            {
                tbx_receptionniste_mesdonnees_prenom.Text = "";
            }
            else
            {
                tbx_receptionniste_mesdonnees_prenom.Text = _useractuelle.Prenom.ToString();
            }
            if (_useractuelle.AdrMail.ToString().Trim() == "(Non communiquée)")
            {
                tbx_receptionniste_mesdonnees_adrMail.Text = "";
            }
            else
            {
                tbx_receptionniste_mesdonnees_adrMail.Text = _useractuelle.AdrMail.ToString();
            }
            lbl_receptionniste_mesdonnees_validationmodif.Hide();
        }

        private void btn_receptionniste_mesdonnees_validermodif_Click(object sender, EventArgs e)
        {
            idUserModified = _useractuelle.Id.ToString();
            if (tbx_receptionniste_mesdonnees_login.Text == "")
            {
                lbl_receptionniste_mesdonnees_validationmodiferreur.Text = "Tous les champs obligatoires doivent être remplis";
                lbl_receptionniste_mesdonnees_validationmodiferreur.Show();
                return;
            }
            if (tbx_receptionniste_mesdonnees_adrMail.Text.Trim() != "" && !(Regex.IsMatch(tbx_receptionniste_mesdonnees_adrMail.Text, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")))
            {
                lbl_receptionniste_mesdonnees_validationmodiferreur.Text = "L’adresse mail saisie n’est pas correcte";
                lbl_receptionniste_mesdonnees_validationmodiferreur.Show();
                return;
            }

            object adrMail = tbx_receptionniste_mesdonnees_adrMail.Text;
            if (adrMail.ToString().Trim() == "")
            {
                adrMail = null;
            }
            object nomModif = tbx_receptionniste_mesdonnees_nom.Text;
            if (nomModif.ToString().Trim() == "")
            {
                nomModif = null;
            }
            object prenomModif = tbx_receptionniste_mesdonnees_prenom.Text;
            if (prenomModif.ToString().Trim() == "")
            {
                prenomModif = null;
            }

            CURS cs = new CURS();
            cs.ReqAdminPrepare("UPDATE utilisateur SET login=?, nomuser=?, prenomuser=?, adrMail=? WHERE id=?", new List<object> { tbx_receptionniste_mesdonnees_login.Text, nomModif, prenomModif, adrMail, idUserModified });
            cs.fermer();
            lbl_receptionniste_mesdonnees_validationmodif.Text = "Vos données ont bien été modifiées.\n";
            HiddenObject.Hide(new List<Control> { lbl_receptionniste_mesdonnees_validationmodiferreur, lbl_receptionniste_mesdonnees_modification, lbl_receptionniste_mesdonnees_modifieradrMail, lbl_receptionniste_mesdonnees_modifierlogin, lbl_receptionniste_mesdonnees_modifiernom, lbl_receptionniste_mesdonnees_modifierprenom, tbx_receptionniste_mesdonnees_login, tbx_receptionniste_mesdonnees_nom, tbx_receptionniste_mesdonnees_adrMail, tbx_receptionniste_mesdonnees_prenom, btn_receptionniste_mesdonnees_validermodif, lbl_receptionniste_mesdonnees_champsobli });

            _useractuelle.Login = tbx_receptionniste_mesdonnees_login.Text;
            _useractuelle.Nom = tbx_receptionniste_mesdonnees_nom.Text.Trim();
            _useractuelle.Prenom = tbx_receptionniste_mesdonnees_prenom.Text.Trim();
            _useractuelle.AdrMail = tbx_receptionniste_mesdonnees_adrMail.Text.Trim();

            lbl_receptionniste_mesdonnees_login.Text = "Login : " + _useractuelle.Login.ToString();
            lbl_receptionniste_mesdonnees_nom.Text = "Nom : " + _useractuelle.Nom.ToString();
            lbl_receptionniste_mesdonnees_prenom.Text = "Prénom : " + _useractuelle.Prenom.ToString();
            lbl_receptionniste_mesdonnees_adrMail.Text = "Adresse Mail : " + _useractuelle.AdrMail.ToString();

            tbc_receptionniste_Selected(sender, _onglet);
            lbl_receptionniste_mesdonnees_validationmodif.Show();
        }

        private void btn_receptionniste_mesdonnees_modifiermdp_Click(object sender, EventArgs e)
        {
            HiddenObject.Hide(new List<Control> { lbl_receptionniste_mesdonnees_modifieradrMail, lbl_receptionniste_mesdonnees_modifierlogin, lbl_receptionniste_mesdonnees_modifiernom, lbl_receptionniste_mesdonnees_modifierprenom, tbx_receptionniste_mesdonnees_login, tbx_receptionniste_mesdonnees_nom, tbx_receptionniste_mesdonnees_prenom, tbx_receptionniste_mesdonnees_adrMail, lbl_receptionniste_mesdonnees_modification, btn_receptionniste_mesdonnees_validermodif, lbl_receptionniste_mesdonnees_champsobli, lbl_receptionniste_mesdonnees_validationmodif, lbl_receptionniste_mesdonnees_validationmodiferreur });
            HiddenObject.Show(new List<Control> { lbl_receptionniste_mesdonnees_modificationmdp, lbl_receptionniste_mesdonnees_mdpactuel, tbx_receptionniste_mesdonnees_mdpactuel, lbl_receptionniste_mesdonnees_newmdp, tbx_receptionniste_mesdonnees_newmdp, lbl_receptionniste_mesdonnees_confirmationnewmdp, tbx_receptionniste_mesdonnees_confirmationnewmdp, btn_receptionniste_mesdonnees_validermodifmdp });
            tbx_receptionniste_mesdonnees_mdpactuel.Text = "";
            tbx_receptionniste_mesdonnees_newmdp.Text = "";
            tbx_receptionniste_mesdonnees_confirmationnewmdp.Text = "";
        }

        private void btn_receptionniste_mesdonnees_validermodifmdp_Click(object sender, EventArgs e)
        {
            idUserModified = _useractuelle.Id.ToString();
            String passwdhash = new HashData(tbx_receptionniste_mesdonnees_mdpactuel.Text).HashCalculate();
            if (tbx_receptionniste_mesdonnees_mdpactuel.Text == "")
            {
                lbl_receptionniste_mesdonnees_validationmodiferreur.Text = "Tous les champs obligatoires doivent être remplis";
                lbl_receptionniste_mesdonnees_validationmodiferreur.Show();
                return;
            }
            if (tbx_receptionniste_mesdonnees_newmdp.Text == "")
            {
                lbl_receptionniste_mesdonnees_validationmodiferreur.Text = "Tous les champs obligatoires doivent être remplis";
                lbl_receptionniste_mesdonnees_validationmodiferreur.Show();
                return;
            }
            if (tbx_receptionniste_mesdonnees_confirmationnewmdp.Text == "")
            {
                lbl_receptionniste_mesdonnees_validationmodiferreur.Text = "Tous les champs obligatoires doivent être remplis";
                lbl_receptionniste_mesdonnees_validationmodiferreur.Show();
                return;
            }

            CURS cs = new CURS();
            cs.ReqSelectPrepare("CALL Auth(?,?)", new List<object> { _useractuelle.Login, passwdhash });
            if (cs.champ("nbUser").ToString() == "0")
            {
                lbl_receptionniste_mesdonnees_validationmodiferreur.Text = "Votre mot de passe actuel est incorrect.";
                lbl_receptionniste_mesdonnees_validationmodiferreur.Show();
                return;
            }
            cs.fermer();

            if (!(Regex.IsMatch(tbx_receptionniste_mesdonnees_newmdp.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")))
            {
                lbl_receptionniste_mesdonnees_validationmodiferreur.Text = "Le mot de passe doit contenir au moins 10 caractères\ncomportant majuscule, minuscules, chiffres et caractères spéciaux";
                lbl_receptionniste_mesdonnees_validationmodiferreur.Show();
                return;
            }

            if (tbx_receptionniste_mesdonnees_newmdp.Text != tbx_receptionniste_mesdonnees_confirmationnewmdp.Text)
            {
                lbl_receptionniste_mesdonnees_validationmodiferreur.Text = "Les mots de passes ne correspondent pas, veuillez réessayer.";
                lbl_receptionniste_mesdonnees_validationmodiferreur.Show();
                return;
            }

            string motdepassehash = new HashData(tbx_receptionniste_mesdonnees_newmdp.Text).HashCalculate();
            CURS csm = new CURS();
            csm.ReqAdminPrepare("UPDATE utilisateur SET pwd=? WHERE id=? ", new List<object> { motdepassehash, idUserModified });
            csm.fermer();
            lbl_receptionniste_mesdonnees_validationmodif.Text = "Votre mot de passe a bien été modifié.";
            lbl_receptionniste_mesdonnees_validationmodif.Show();
            HiddenObject.Hide(new List<Control> { lbl_receptionniste_mesdonnees_modificationmdp, lbl_receptionniste_mesdonnees_validationmodiferreur, lbl_receptionniste_mesdonnees_mdpactuel, tbx_receptionniste_mesdonnees_mdpactuel, lbl_receptionniste_mesdonnees_newmdp, tbx_receptionniste_mesdonnees_newmdp, lbl_receptionniste_mesdonnees_confirmationnewmdp, tbx_receptionniste_mesdonnees_confirmationnewmdp, btn_receptionniste_mesdonnees_validermodifmdp });

        }

        #endregion

        #region Fermeture du Formulaire
        private void AppCriee_Receptionniste_FormClosing(object sender, FormClosingEventArgs e)
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
        private void pbx_receptionniste_deconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }









        #endregion

    }

}
