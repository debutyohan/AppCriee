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
    public partial class AppCriee_DemandeCreationCompte : Form
    {
        #region Données privées

        AppCriee _appCriee;

        #endregion

        #region Constructeur

        public AppCriee_DemandeCreationCompte(AppCriee appCriee)
        {
            InitializeComponent();
            _appCriee = appCriee;
            CompleteControl.RemplirCombobox(cbx_demandecreercompte_typeuser, "SELECT libelle FROM TypeUtilisateur WHERE id<5", "libelle");
        }

        #endregion

        #region Evènement
        private void btn_demandecreercompte_valider_Click(object sender, EventArgs e)
        {
            if (tbx_demandecreercompte_login.Text.Trim() == "" || tbx_demandecreercompte_motdepasse.Text.Trim() == "" || cbx_demandecreercompte_typeuser.Text == "")
            {
                lbl_demandecreercompte_error.Text = "Tous les champs obligatoires doivent être saisis’";
                lbl_demandecreercompte_error.Show();
                return;
            }
            CURS cs = new CURS();
            cs.ReqSelectPrepare("SELECT count(id) as nb FROM Utilisateur WHERE login=?", new List<object> { (new CryptData(tbx_demandecreercompte_login.Text.Trim())).EncryptData() });
            string nblog = cs.champ("nb").ToString();
            cs.fermer();
            if (nblog != "0")
            {
                lbl_demandecreercompte_error.Text = "Ce login existe déjà, veuillez en choisir un autre";
                lbl_demandecreercompte_error.Show();
                return;
            }
            CURS csa = new CURS();
            csa.ReqSelectPrepare("SELECT count(id) as nb FROM Utilisateur WHERE adrMail=?", new List<object> { (new CryptData(tbx_demandecreercompte_adrMail.Text.Trim())).EncryptData() });
            string nbmail = csa.champ("nb").ToString();
            cs.fermer();
            if (nbmail != "0")
            {
                lbl_demandecreercompte_error.Text = "Cette adresse mail est déjà utilisée, veuillez en choisir une autre";
                lbl_demandecreercompte_error.Show();
                return;
            }
            if (!(Regex.IsMatch(tbx_demandecreercompte_motdepasse.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")))
            {
                lbl_demandecreercompte_error.Text = "Le mot de passe doit contenir au moins 10 caractères\ncomportant majuscule, minuscules, chiffres et caractères spéciaux";
                lbl_demandecreercompte_error.Show();
                return;
            }
            if (tbx_demandecreercompte_adrMail.Text.Trim() != "" && !(Regex.IsMatch(tbx_demandecreercompte_adrMail.Text, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")))
            {
                lbl_demandecreercompte_error.Text = "L’adresse mail saisie n’est pas correcte";
                lbl_demandecreercompte_error.Show();
                return;
            }
            Exception exception;
            string contenu = "La création d'un nouveau compte sur l'application AppCriée a été demandée dont voici les informations :\n\nLogin : " + tbx_demandecreercompte_login.Text.Trim() + "\nMot de passe (provisoire) : " + tbx_demandecreercompte_motdepasse.Text + "\nNom : ";
            if (tbx_demandecreercompte_nom.Text.Trim() == "")
            {
                contenu += " (Non communiqué)";
            }
            else
            {
                contenu += tbx_demandecreercompte_nom.Text.Trim();
            }
            contenu += "\nPrénom : ";
            if (tbx_demandecreercompte_prenom.Text.Trim() == "")
            {
                contenu += " (Non communiqué)";
            }
            else
            {
                contenu += tbx_demandecreercompte_prenom.Text.Trim();
            }
            contenu += "\nAdresse mail : ";
            if (tbx_demandecreercompte_adrMail.Text.Trim() == "")
            {
                contenu += " (Non communiqué)";
            }
            else
            {
                contenu += tbx_demandecreercompte_adrMail.Text.Trim();
            }
            contenu += "\nType utilisateur : " + cbx_demandecreercompte_typeuser.Text;
            lbl_demandecreercompte_error.Hide();
            bool isresult = CompleteControl.SendMail(DataSystem.AdrMailFrom(), "AppCriée : Demande de création d'un nouveau compte", contenu, out exception);
            if (!isresult)
            {
                MessageBox.Show("Le mail n’a pu être envoyé au support technique : " + exception.Message + ", vérifier l’état de votre connexion Internet, votre pare-feu ou contacter le support informatique de l’application à l’adresse mail : " + DataSystem.AdrMailFrom(), "Echec de l'envoi du mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbx_demandecreercompte_adrMail.Text.Trim() != "")
            {
                lbl_demandecreercompte_ok.Text = "Votre demande a bien été envoyée au support\ninformatique de l'application AppCriée.\n\nLe support informatique prendra contact avec\nvous au moyen de l'adresse mail communiqué.";
            }
            else
            {
                lbl_demandecreercompte_ok.Text = "Votre demande a bien été envoyée au support\ninformatique de l'application AppCriée.\n\nEtant donnée qu'aucune adresse mail n'a été\ncommuniqué, prenez contact avec votre\nservice informatique pour connaître les suites\nde votre demande.\n\nAdresse mail du support informatique :\n" + DataSystem.AdrMailFrom();
            }
            lbl_demandecreercompte_ok.Show();
            HiddenObject.Hide(new List<Control> { lbl_demandecreercompte_login, lbl_demandecreercompte_motdepasse, lbl_demandecreercompte_nom, lbl_demandecreercompte_prenom, lbl_demandecreerompte_typeuser, lbl_demandecreercompte_adrMail, cbx_demandecreercompte_typeuser, tbx_demandecreercompte_adrMail, tbx_demandecreercompte_login, tbx_demandecreercompte_motdepasse, tbx_demandecreercompte_nom, tbx_demandecreercompte_prenom, btn_demandecreercompte_valider, lbl_demandecreercompte_champobli });
        }
        #endregion

        #region Fermeture du formulaire

        private void AppCriee_DemandeCreationCompte_FormClosing(object sender, FormClosingEventArgs e)
        {
            _appCriee.Show();
        }

        #endregion
    }
}
