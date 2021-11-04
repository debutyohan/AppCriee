using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCriée
{
    public partial class AppCriee_Administrateur : Form
    {
        #region Données privées

        AppCriee _authAccueil;
        User _useractuelle;
        TabControlEventArgs _onglet;

        #endregion

        #region Constructeur

        public AppCriee_Administrateur(User unutilisateur, AppCriee authAccueil)
        {
            InitializeComponent();
            _authAccueil = authAccueil;
            _useractuelle = unutilisateur;
            lbl_administrateur_accueil_bienvenue.Text = "Bienvenue " + unutilisateur.Nom + " " + unutilisateur.Prenom;
            lbl_administrateur_datejour.Text = "Date du jour : " + DateTime.Today.ToString("dd/MM/yyyy");
        }

        #endregion

        #region Fermture du Formulaire

        private void AppCriee_Administrateur_FormClosing(object sender, FormClosingEventArgs e)
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
        private void pbx_administrateur_deconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void tbc_administrateur_Selected(object sender, TabControlEventArgs e)
        {
            _onglet = e;
            switch (e.TabPage.Name)
            {
                case "tbp_administrateur_gestioncomptes":
                    HiddenObject.Hide(new List<Control> { lbl_administrateur_gestioncomptes_ajout, lbl_administrateur_gestioncomptes_adrMail ,lbl_administrateur_gestioncomptes_login, lbl_administrateur_gestioncomptes_motdepasse ,lbl_administrateur_gestioncomptes_nom, lbl_administrateur_gestioncomptes_prenom, lbl_administrateur_gestioncomptes_typeuser, cbx_administrateur_gestioncomptes_typeuser, tbx_administrateur_gestioncomptes_adrMail, tbx_administrateur_gestioncomptes_login, tbx_administrateur_gestioncomptes_motdepasse, tbx_administrateur_gestioncomptes_nom, tbx_administrateur_gestioncomptes_prenom, btn_administrateur_gestioncomptes_validerajout, lbl_administrateur_gestioncomptes_validationajouterror, lbl_administrateur_gestioncomptes_champsobli, lbl_administrateur_gestioncomptes_validationajoutok });
                    CompleteControl.RemplirDataGridViewByRequest(dg_administrateur_gestioncomptes_listecompte, "SELECT utilisateur.id as iduser, login, nomuser, prenomuser, adrMail, libelle FROM utilisateur INNER JOIN typeutilisateur ON typeutilisateur.id=utilisateur.idtypeuser ORDER BY utilisateur.id", new string[] { "iduser", "login", "nomuser", "prenomuser", "adrMail", "libelle" });
                    foreach (DataGridViewRow ligne in dg_administrateur_gestioncomptes_listecompte.Rows)
                    {
                        if (ligne.Cells[4].Value.ToString().Trim() == "")
                        {
                            ligne.Cells[4].Value = "(Non communiquée)";
                        }
                        if (ligne.Cells[2].Value.ToString().Trim() == "")
                        {
                            ligne.Cells[2].Value = "(Non communiqué)";
                        }
                        if (ligne.Cells[3].Value.ToString().Trim() == "")
                        {
                            ligne.Cells[3].Value = "(Non communiqué)";
                        }
                        if (ligne.Cells[0].Value.ToString() == _useractuelle.Id.ToString())
                        {
                            CompleteControl.griseligne(ligne);
                        }
                    }
                    dg_administrateur_gestioncomptes_listecompte.Show();
                    break;
            }
        }


        private void dg_administrateur_gestioncomptes_listecompte_VisibleChanged(object sender, EventArgs e)
        {
            dg_administrateur_gestioncomptes_listecompte.ClearSelection();
        }

        private void btn_administrateur_gestioncomptes_supprimer_Click(object sender, EventArgs e)
        {

        }

        private void btn_administrateur_gestioncomptes_modifier_Click(object sender, EventArgs e)
        {

        }

        private void btn_administrateur_gestioncomptes_ajout_Click(object sender, EventArgs e)
        {
            HiddenObject.Hide(new List<Control> { lbl_administrateur_gestioncomptes_validationajoutok, lbl_administrateur_gestioncomptes_validationajouterror });
            CompleteControl.RemplirCombobox(cbx_administrateur_gestioncomptes_typeuser,"SELECT libelle FROM typeutilisateur", "libelle");
            tbx_administrateur_gestioncomptes_adrMail.Text = "";
            tbx_administrateur_gestioncomptes_login.Text = "";
            tbx_administrateur_gestioncomptes_motdepasse.Text = "";
            tbx_administrateur_gestioncomptes_nom.Text = "";
            tbx_administrateur_gestioncomptes_prenom.Text = "";
            HiddenObject.Show(new List<Control> { lbl_administrateur_gestioncomptes_ajout, lbl_administrateur_gestioncomptes_adrMail, lbl_administrateur_gestioncomptes_login, lbl_administrateur_gestioncomptes_motdepasse, lbl_administrateur_gestioncomptes_nom, lbl_administrateur_gestioncomptes_prenom, lbl_administrateur_gestioncomptes_typeuser, cbx_administrateur_gestioncomptes_typeuser, tbx_administrateur_gestioncomptes_adrMail, tbx_administrateur_gestioncomptes_login, tbx_administrateur_gestioncomptes_motdepasse, tbx_administrateur_gestioncomptes_nom, tbx_administrateur_gestioncomptes_prenom, btn_administrateur_gestioncomptes_validerajout });
        }

        private void btn_administrateur_gestioncomptes_validerajout_Click(object sender, EventArgs e)
        {
            if (cbx_administrateur_gestioncomptes_typeuser.Text == "" || tbx_administrateur_gestioncomptes_login.Text == "" || tbx_administrateur_gestioncomptes_motdepasse.Text == "")
            {
                lbl_administrateur_gestioncomptes_validationajouterror.Text = "Tous les champs obligatoires doivent être remplis";
                lbl_administrateur_gestioncomptes_validationajouterror.Show();
                return;
            }
            if(!(Regex.IsMatch(tbx_administrateur_gestioncomptes_motdepasse.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$"))){
                lbl_administrateur_gestioncomptes_validationajouterror.Text = "Le mot de passe doit contenir au moins 10 caractères\ncomportant majuscule, minuscules, chiffres et caractères spéciaux";
                lbl_administrateur_gestioncomptes_validationajouterror.Show();
                return;
            }
            if(tbx_administrateur_gestioncomptes_adrMail.Text.Trim()!=""&&!(Regex.IsMatch(tbx_administrateur_gestioncomptes_adrMail.Text,@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")))
            {
                lbl_administrateur_gestioncomptes_validationajouterror.Text = "L’adresse mail saisie n’est pas correcte";
                lbl_administrateur_gestioncomptes_validationajouterror.Show();
                return;
            }
            int idusermax = -1;
            foreach (DataGridViewRow row in dg_administrateur_gestioncomptes_listecompte.Rows)
            {
                if (idusermax < Int32.Parse(row.Cells[0].Value.ToString()))
                {
                    idusermax = Int32.Parse(row.Cells[0].Value.ToString());
                }
                if (row.Cells[1].Value.ToString().Trim() == tbx_administrateur_gestioncomptes_login.Text)
                {
                    lbl_administrateur_gestioncomptes_validationajouterror.Text = "Le login existe déjà, veuillez en choisir un autre.";
                    lbl_administrateur_gestioncomptes_validationajouterror.Show();
                    return;
                }
            }
            object adresseMail = tbx_administrateur_gestioncomptes_adrMail.Text;
            if (adresseMail.ToString().Trim() == "")
            {
                adresseMail = null;
            }
            object nom = tbx_administrateur_gestioncomptes_nom.Text;
            if (nom.ToString().Trim() == "")
            {
                nom = null;
            }
            object prenom = tbx_administrateur_gestioncomptes_prenom.Text;
            if (prenom.ToString().Trim() == "")
            {
                prenom = null;
            }

            string motdepassehash = new HashData(tbx_administrateur_gestioncomptes_motdepasse.Text).HashCalculate();
            CURS cs = new CURS();
            cs.ReqAdminPrepare("INSERT INTO utilisateur VALUES (?,?,?,?,?,(SELECT id FROM typeutilisateur WHERE libelle=?),?)",new List<object> {(idusermax+1), tbx_administrateur_gestioncomptes_login.Text, motdepassehash, nom, prenom, cbx_administrateur_gestioncomptes_typeuser.Text, adresseMail });
            cs.fermer();
            lbl_administrateur_gestioncomptes_validationajoutok.Text = "L'utilisateur a bien été ajouté.\n";
            tbc_administrateur_Selected(sender, _onglet);
            lbl_administrateur_gestioncomptes_validationajoutok.Show();

            if (adresseMail != null)
            {
                string contenu = "Un compte pour se connecter à AppCriée a bien été crée :\n\nLogin : " + tbx_administrateur_gestioncomptes_login.Text + "\nMot de passe (provisoire) : " + tbx_administrateur_gestioncomptes_motdepasse.Text;
                if (nom != null)
                {
                    contenu += "\nNom : " + nom.ToString();
                }
                if (prenom != null)
                {
                    contenu += "\nPrénom : " + prenom.ToString();
                }
                contenu += "\nType utilisateur : " + cbx_administrateur_gestioncomptes_typeuser.Text + "\n\nPensez à changer votre mot de passe lors de la première connexion.\n\nSupport Informatique de l'application AppCriée\n\nPour toutes questions relatives à l'application AppCriée, veuillez nous contacter à l'adresse : " + DataSystem.AdrMailFrom();
                Exception iferreur;
                bool resultmsg = CompleteControl.SendMail(adresseMail.ToString(), "AppCriée : Création de compte", contenu, out iferreur);
                if (resultmsg)
                {
                    lbl_administrateur_gestioncomptes_validationajoutok.Text += "\nUn mail a été envoyé à l'utilisateur";
                }
                else
                {
                    lbl_administrateur_gestioncomptes_validationajoutok.Text += "\nCependant, le mail n'a pu être envoyé à l'utilisateur : \n" + iferreur.Message+"\n\nVeuillez contacter l'utilisateur pour lui indiquer que le compte a bien été crée";
                }

            }
            else
            {
                lbl_administrateur_gestioncomptes_validationajoutok.Text += "\n\nVeuillez contacter l'utilisateur pour lui indiquer que le compte a bien été crée";
            }

        }
    }
}

