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
        string idUserModified;
        string loginUserModified;
        string adrMailModified;
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

        #region Changement d'onglets
        private void tbc_administrateur_Selected(object sender, TabControlEventArgs e)
        {
            _onglet = e;
            switch (e.TabPage.Name)
            {
            case "tbp_administrateur_accueil":
                lbl_administrateur_accueil_bienvenue.Text = "Bienvenue " + _useractuelle.Nom + " " + _useractuelle.Prenom;
                break;
            case "tbp_administrateur_gestioncomptes":
                HiddenObject.Hide(new List<Control> { lbl_administrateur_gestioncomptes_modification, lbl_administrateur_gestioncomptes_ajout, lbl_administrateur_gestioncomptes_adrMail, lbl_administrateur_gestioncomptes_login, lbl_administrateur_gestioncomptes_motdepasse, lbl_administrateur_gestioncomptes_nom, lbl_administrateur_gestioncomptes_prenom, lbl_administrateur_gestioncomptes_typeuser, cbx_administrateur_gestioncomptes_typeuser, tbx_administrateur_gestioncomptes_adrMail, tbx_administrateur_gestioncomptes_login, tbx_administrateur_gestioncomptes_motdepasse, tbx_administrateur_gestioncomptes_nom, tbx_administrateur_gestioncomptes_prenom, btn_administrateur_gestioncomptes_validerajout, lbl_administrateur_gestioncomptes_validationajouterror, lbl_administrateur_gestioncomptes_champsobli, lbl_administrateur_gestioncomptes_validationajoutok, btn_administrateur_gestioncomptes_validermodif, lbl_administrateur_gestioncomptes_bateau, cbx_administrateur_gestioncomptes_bateau });
                CompleteControl.RemplirDataGridViewByRequest(dg_administrateur_gestioncomptes_listecompte, "SELECT Utilisateur.id as iduser, login, nomuser, prenomuser, adrMail, libelle, idBateau FROM Utilisateur INNER JOIN TypeUtilisateur ON TypeUtilisateur.id=Utilisateur.idtypeuser LEFT JOIN Pecheur ON Pecheur.id=Utilisateur.id WHERE idtypeuser<5 OR idtypeuser=6 ORDER BY Utilisateur.id", new string[] { "iduser", "login", "nomuser", "prenomuser", "adrMail", "libelle", "idBateau" }, true, new string[] {"login", "nomuser", "prenomuser", "adrMail" });
                foreach (DataGridViewRow ligne in dg_administrateur_gestioncomptes_listecompte.Rows)
                {
                    if ((ligne.Cells[4].Value ?? "").ToString() == "")
                    {
                        ligne.Cells[4].Value = "(Non communiquée)";
                    }
                    if ((ligne.Cells[2].Value ?? "").ToString() == "")
                    {
                        ligne.Cells[2].Value = "(Non communiqué)";
                    }
                    if ((ligne.Cells[3].Value ?? "").ToString() == "")
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
             case "tbp_administrateur_mesdonnees":
                    HiddenObject.Hide(new List<Control> { lbl_administrateur_mesdonnees_modificationmdp, lbl_administrateur_mesdonnees_validationmodif, lbl_administrateur_mesdonnees_mdpactuel, tbx_administrateur_mesdonnees_mdpactuel, lbl_administrateur_mesdonnees_newmdp, tbx_administrateur_mesdonnees_newmdp, lbl_administrateur_mesdonnees_confirmationnewmdp, tbx_administrateur_mesdonnees_confirmationnewmdp, btn_administrateur_mesdonnees_validermodifmdp, lbl_administrateur_mesdonnees_validationmodiferreur, lbl_administrateur_mesdonnees_modification, lbl_administrateur_mesdonnees_modifieradrMail, lbl_administrateur_mesdonnees_modifierlogin, lbl_administrateur_mesdonnees_modifiernom, lbl_administrateur_mesdonnees_modifierprenom, tbx_administrateur_mesdonnees_login, tbx_administrateur_mesdonnees_nom, tbx_administrateur_mesdonnees_adrMail, tbx_administrateur_mesdonnees_prenom, btn_administrateur_mesdonnees_validermodif, lbl_administrateur_mesdonnees_champsobli, lbl_administrateur_mesdonnees_validationmodif, lbl_administrateur_mesdonnees_validationmodiferreur,  });
                    lbl_administrateur_mesdonnees_login.Text = "Login : " + _useractuelle.Login;
                    lbl_administrateur_mesdonnees_prenom.Text = "Prénom : " + _useractuelle.Prenom;
                    lbl_administrateur_mesdonnees_nom.Text = "Nom : " + _useractuelle.Nom;
                    lbl_administrateur_mesdonnees_adrMail.Text = "Adresse Mail : " + _useractuelle.AdrMail;
                    lbl_administrateur_mesdonnees_typeuser.Text = "Type utilisateur : " + _useractuelle.Libelletype;
                lbl_administrateur_mesdonnees_datecreation.Text = "Date de création : " + _useractuelle.Datecreation;
                if (_useractuelle.AdrMail == "")
                    {
                        lbl_administrateur_mesdonnees_adrMail.Text = "Adresse Mail : (Non communiquée)";
                    }
                    if (_useractuelle.Nom == "")
                    {
                        lbl_administrateur_mesdonnees_nom.Text = "Nom : (Non communiquée)";
                    }
                    if (_useractuelle.Prenom == "")
                    {
                        lbl_administrateur_mesdonnees_prenom.Text = "Prénom : (Non communiquée)";
                    }
                    CURS cs = new CURS();
                    cs.ReqSelect("SELECT count(id) as nb FROM Utilisateur WHERE idtypeuser=0");
                    string nb = cs.champ("nb").ToString();
                    cs.fermer();
                    if (nb == "1")
                    {
                        btn_administrateur_mesdonnees_supprimer.Hide();
                        lbl_administrateur_mesdonnees_ifonlyadmin.Show();
                    }
                    else
                    {
                        lbl_administrateur_mesdonnees_ifonlyadmin.Hide();
                        btn_administrateur_mesdonnees_supprimer.Show();
                    }
                    break;
            }
        }
        #endregion

        #region Onglet Gestion des comptes

        private void dg_administrateur_gestioncomptes_listecompte_VisibleChanged(object sender, EventArgs e)
        {
            dg_administrateur_gestioncomptes_listecompte.ClearSelection();
        }
        private void btn_administrateur_gestioncomptes_supprimer_Click(object sender, EventArgs e)
        {
            HiddenObject.Hide(new List<Control> { lbl_administrateur_gestioncomptes_champsobli, lbl_administrateur_gestioncomptes_ajout, lbl_administrateur_gestioncomptes_adrMail, lbl_administrateur_gestioncomptes_login, lbl_administrateur_gestioncomptes_motdepasse, lbl_administrateur_gestioncomptes_nom, lbl_administrateur_gestioncomptes_prenom, lbl_administrateur_gestioncomptes_typeuser, cbx_administrateur_gestioncomptes_typeuser, tbx_administrateur_gestioncomptes_adrMail, tbx_administrateur_gestioncomptes_login, tbx_administrateur_gestioncomptes_motdepasse, tbx_administrateur_gestioncomptes_nom, tbx_administrateur_gestioncomptes_prenom, btn_administrateur_gestioncomptes_validerajout, lbl_administrateur_gestioncomptes_modification, lbl_administrateur_gestioncomptes_validationajoutok, lbl_administrateur_gestioncomptes_validationajouterror, btn_administrateur_gestioncomptes_validermodif });
            lbl_administrateur_gestioncomptes_validationok.Hide();
            if (dg_administrateur_gestioncomptes_listecompte.SelectedRows.Count == 0)
            {
                lbl_administrateur_gestioncomptes_validationok.Text = "Veuillez sélectionner au moins un compte";
                lbl_administrateur_gestioncomptes_validationok.ForeColor = Color.Red;
                lbl_administrateur_gestioncomptes_validationok.Show();
                return;
            }
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce compte ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow line in dg_administrateur_gestioncomptes_listecompte.SelectedRows)
                {
                    if (_useractuelle.Id.ToString() == line.Cells[0].Value.ToString())
                    {
                        lbl_administrateur_gestioncomptes_validationok.Text = "Impossible de supprimer son propre compte dans cet onglet\n Veuillez vous rendre dans l'onglet 'Mes données' si vous souhaitez supprimer votre compte.";
                        lbl_administrateur_gestioncomptes_validationok.Show();
                    }
                    else
                    {
                        if (line.Cells[5].Value.ToString() == "Administrateur")
                        {
                            lbl_administrateur_gestioncomptes_validationok.Text = "Il est impossible de supprimer un administrateur.";
                            lbl_administrateur_gestioncomptes_validationok.Show();
                            return;
                        }

                        dg_administrateur_gestioncomptes_listecompte.Rows.RemoveAt(line.Index);

                        CURS cs = new CURS();
                        cs.ReqAdminPrepare("DELETE Directeurvente FROM Directeurvente WHERE id =?", new List<object> { line.Cells[0].Value });
                        cs.fermer();
                        cs = new CURS();
                        cs.ReqAdminPrepare("DELETE Pecheur FROM Pecheur WHERE id =?", new List<object> { line.Cells[0].Value });
                        cs.fermer();
                        cs = new CURS();
                        cs.ReqAdminPrepare("DELETE Utilisateur FROM Utilisateur WHERE id =?", new List<object> { line.Cells[0].Value });
                        cs.fermer();
                        lbl_administrateur_gestioncomptes_validationajoutok.Text = "L'utilisateur a bien été supprimée";
                        lbl_administrateur_gestioncomptes_validationajoutok.Show();
                    }

                }
            }

        }
        private void btn_administrateur_gestioncomptes_modifier_Click(object sender, EventArgs e)
        {
            HiddenObject.Hide(new List<Control> { lbl_administrateur_gestioncomptes_validationok, lbl_administrateur_gestioncomptes_champsobli, lbl_administrateur_gestioncomptes_ajout, lbl_administrateur_gestioncomptes_adrMail, lbl_administrateur_gestioncomptes_login, lbl_administrateur_gestioncomptes_motdepasse, lbl_administrateur_gestioncomptes_nom, lbl_administrateur_gestioncomptes_prenom, lbl_administrateur_gestioncomptes_typeuser, cbx_administrateur_gestioncomptes_typeuser, tbx_administrateur_gestioncomptes_adrMail, tbx_administrateur_gestioncomptes_login, tbx_administrateur_gestioncomptes_motdepasse, tbx_administrateur_gestioncomptes_nom, tbx_administrateur_gestioncomptes_prenom, btn_administrateur_gestioncomptes_validerajout, lbl_administrateur_gestioncomptes_modification, lbl_administrateur_gestioncomptes_validationajoutok, lbl_administrateur_gestioncomptes_validationajouterror, btn_administrateur_gestioncomptes_validermodif, lbl_administrateur_gestioncomptes_bateau, cbx_administrateur_gestioncomptes_bateau });
            if (dg_administrateur_gestioncomptes_listecompte.SelectedRows.Count != 1)
            {
                lbl_administrateur_gestioncomptes_validationajouterror.Text = "Veuillez sélectionner un et un seul compte";
                lbl_administrateur_gestioncomptes_validationajouterror.Show();
                return;
            }
            DataGridViewRow ligneselect = dg_administrateur_gestioncomptes_listecompte.SelectedRows[0];
            if (ligneselect.Cells[0].Value.ToString() == _useractuelle.Id.ToString())
            {
                lbl_administrateur_gestioncomptes_validationajouterror.Text = "Vous ne pouvez pas dans cet onglet modifier vos propres données, pour ce faire,\n aller dans l’onglet « Mes données »";
                lbl_administrateur_gestioncomptes_validationajouterror.Show();
                return;
            }
            CompleteControl.RemplirCombobox(cbx_administrateur_gestioncomptes_typeuser, "SELECT libelle FROM TypeUtilisateur WHERE id<5 OR id=6", "libelle");
            CompleteControl.RemplirCombobox(cbx_administrateur_gestioncomptes_bateau, "SELECT nom, immatriculation FROM Bateau", "nom (immatriculation)");
            tbx_administrateur_gestioncomptes_login.Text = ligneselect.Cells[1].Value.ToString();
            if (ligneselect.Cells[2].Value.ToString().Trim() == "(Non communiqué)")
            {
                tbx_administrateur_gestioncomptes_nom.Text = "";
            }
            else
            {
                tbx_administrateur_gestioncomptes_nom.Text = ligneselect.Cells[2].Value.ToString();
            }
            if (ligneselect.Cells[3].Value.ToString().Trim() == "(Non communiqué)")
            {
                tbx_administrateur_gestioncomptes_prenom.Text = "";
            }
            else
            {
                tbx_administrateur_gestioncomptes_prenom.Text = ligneselect.Cells[3].Value.ToString();
            }
            if (ligneselect.Cells[4].Value.ToString().Trim() == "(Non communiquée)")
            {
                tbx_administrateur_gestioncomptes_adrMail.Text = "";
            }
            else
            {
                tbx_administrateur_gestioncomptes_adrMail.Text = ligneselect.Cells[4].Value.ToString();
            }
            cbx_administrateur_gestioncomptes_typeuser.SelectedItem = cbx_administrateur_gestioncomptes_typeuser.Items[cbx_administrateur_gestioncomptes_typeuser.FindString(ligneselect.Cells[5].Value.ToString())];
            if (cbx_administrateur_gestioncomptes_typeuser.Text == "Pêcheur")
            {
                CURS csa = new CURS();
                csa.ReqSelectPrepare("SELECT nom, immatriculation FROM Bateau WHERE id=?", new List<object> { ligneselect.Cells[6].Value.ToString() });
                string chainebateau = csa.champ("nom").ToString()+" ("+ csa.champ("immatriculation").ToString()+")";
                csa.fermer();
                cbx_administrateur_gestioncomptes_bateau.SelectedItem = cbx_administrateur_gestioncomptes_bateau.Items[cbx_administrateur_gestioncomptes_bateau.FindString(chainebateau)];
                HiddenObject.Show(new List<Control> { lbl_administrateur_gestioncomptes_bateau, cbx_administrateur_gestioncomptes_bateau });
            }
            HiddenObject.Show(new List<Control> { lbl_administrateur_gestioncomptes_modification, lbl_administrateur_gestioncomptes_adrMail, lbl_administrateur_gestioncomptes_login, lbl_administrateur_gestioncomptes_nom, lbl_administrateur_gestioncomptes_prenom, lbl_administrateur_gestioncomptes_typeuser, cbx_administrateur_gestioncomptes_typeuser, tbx_administrateur_gestioncomptes_adrMail, tbx_administrateur_gestioncomptes_login, tbx_administrateur_gestioncomptes_nom, tbx_administrateur_gestioncomptes_prenom, btn_administrateur_gestioncomptes_validermodif, lbl_administrateur_gestioncomptes_champsobli });
            DataGridViewRow ligneselected = dg_administrateur_gestioncomptes_listecompte.SelectedRows[0];
            idUserModified = ligneselected.Cells[0].Value.ToString();
            loginUserModified = ligneselected.Cells[1].Value.ToString();
            adrMailModified = ligneselected.Cells[4].Value.ToString();
        }
        private void btn_administrateur_gestioncomptes_ajout_Click(object sender, EventArgs e)
        {
            HiddenObject.Hide(new List<Control> { lbl_administrateur_gestioncomptes_validationok, lbl_administrateur_gestioncomptes_modification, lbl_administrateur_gestioncomptes_validationajoutok, lbl_administrateur_gestioncomptes_validationajouterror, btn_administrateur_gestioncomptes_validermodif, lbl_administrateur_gestioncomptes_bateau, cbx_administrateur_gestioncomptes_bateau });
            CompleteControl.RemplirCombobox(cbx_administrateur_gestioncomptes_typeuser, "SELECT libelle FROM TypeUtilisateur WHERE id<5 OR id=6", "libelle");
            CompleteControl.RemplirCombobox(cbx_administrateur_gestioncomptes_bateau, "SELECT nom, immatriculation FROM Bateau", "nom (immatriculation)");
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
            if (!(Regex.IsMatch(tbx_administrateur_gestioncomptes_motdepasse.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")))
            {
                lbl_administrateur_gestioncomptes_validationajouterror.Text = "Le mot de passe doit contenir au moins 10 caractères\ncomportant majuscule, minuscules, chiffres et caractères spéciaux";
                lbl_administrateur_gestioncomptes_validationajouterror.Show();
                return;
            }
            if (tbx_administrateur_gestioncomptes_adrMail.Text.Trim() != "" && !(Regex.IsMatch(tbx_administrateur_gestioncomptes_adrMail.Text, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")))
            {
                lbl_administrateur_gestioncomptes_validationajouterror.Text = "L’adresse mail saisie n’est pas correcte";
                lbl_administrateur_gestioncomptes_validationajouterror.Show();
                return;
            }

            CURS csb = new CURS();
            csb.ReqSelectPrepare("SELECT COUNT(login) as nblogin FROM Utilisateur WHERE login=?", new List<object> { (new CryptData(tbx_administrateur_gestioncomptes_login.Text)).EncryptData() });
            string nblogin = csb.champ("nblogin").ToString();
            csb.suivant();
            csb.fermer();
            if (nblogin == "1")
            {
                lbl_administrateur_gestioncomptes_validationajouterror.Text = "Le login est déjà utilisé pour un utilisateur";
                lbl_administrateur_gestioncomptes_validationajouterror.Show();
                return;
            }
            CURS csc = new CURS();
            csc.ReqSelectPrepare("SELECT COUNT(adrMail) as nbadrMail FROM Utilisateur WHERE adrMail=?", new List<object> { (new CryptData(tbx_administrateur_gestioncomptes_adrMail.Text)).EncryptData() });
            string nbadrMail = csc.champ("nbadrMail").ToString();
            csc.suivant();
            csc.fermer();
            if (nbadrMail == "1")
            {
                lbl_administrateur_gestioncomptes_validationajouterror.Text = "L’adresse mail est déjà utilisé pour un utilisateur";
                lbl_administrateur_gestioncomptes_validationajouterror.Show();
                return;
            }
            csc.suivant();
            csc.fermer();
            CURS csa = new CURS();
            csa.ReqSelect("SELECT max(id) as maxid FROM Utilisateur");
            int idusermax = Int32.Parse(csa.champ("maxid").ToString());
            csa.fermer();
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
            cs.ReqAdminPrepare("INSERT INTO Utilisateur(id,login,pwd, nomuser, prenomuser, idtypeuser, adrMail) VALUES (?,?,?,?,?,(SELECT id FROM TypeUtilisateur WHERE libelle=?),?)", new List<object> { (idusermax + 1), (new CryptData(tbx_administrateur_gestioncomptes_login.Text)).EncryptData(), (new CryptData(motdepassehash)).EncryptData(), (new CryptData(nom)).EncryptData(), (new CryptData(prenom)).EncryptData(), cbx_administrateur_gestioncomptes_typeuser.Text, (new CryptData(adresseMail)).EncryptData() });
            cs.fermer();
            if (cbx_administrateur_gestioncomptes_typeuser.Text == "Directeur des ventes")
            {
                cs = new CURS();
                cs.ReqAdminPrepare("INSERT INTO Directeurvente(id) VALUES (?)", new List<object> { (idusermax + 1)});
                cs.fermer();
            }
            if (cbx_administrateur_gestioncomptes_typeuser.Text == "Pêcheur")
            {
                int char_bateau = cbx_administrateur_gestioncomptes_bateau.Text.IndexOf("(");
                String imma = cbx_administrateur_gestioncomptes_bateau.Text.Substring(char_bateau + 1, cbx_administrateur_gestioncomptes_bateau.Text.Length - char_bateau - 2);
                cs = new CURS();
                cs.ReqAdminPrepare("INSERT INTO Pecheur(id, idBateau) VALUES (?, (SELECT id FROM Bateau WHERE immatriculation=?))", new List<object> { (idusermax + 1), imma });
                cs.fermer();
            }
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
                    lbl_administrateur_gestioncomptes_validationajoutok.Text += "\nCependant, le mail n'a pu être envoyé à l'utilisateur : \n" + iferreur.Message + "\n\nVeuillez contacter l'utilisateur pour lui indiquer que le compte a bien été crée";
                }

            }
            else
            {
                lbl_administrateur_gestioncomptes_validationajoutok.Text += "\n\nVeuillez contacter l'utilisateur pour lui indiquer que le compte a bien été crée";
            }

        }
        private void btn_administrateur_gestioncomptes_validermodif_Click(object sender, EventArgs e)
        {
            if (cbx_administrateur_gestioncomptes_typeuser.Text == "" || tbx_administrateur_gestioncomptes_login.Text == "")
            {
                lbl_administrateur_gestioncomptes_validationajouterror.Text = "Tous les champs obligatoires doivent être remplis";
                lbl_administrateur_gestioncomptes_validationajouterror.Show();
                return;
            }
            if (tbx_administrateur_gestioncomptes_adrMail.Text.Trim() != "" && !(Regex.IsMatch(tbx_administrateur_gestioncomptes_adrMail.Text, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")))
            {
                lbl_administrateur_gestioncomptes_validationajouterror.Text = "L’adresse mail saisie n’est pas correcte";
                lbl_administrateur_gestioncomptes_validationajouterror.Show();
                return;
            }
            CURS csb = new CURS();
            csb.ReqSelectPrepare("SELECT COUNT(login) as nblogin FROM Utilisateur WHERE login=? AND login!=?", new List<object> { (new CryptData(tbx_administrateur_gestioncomptes_login.Text)).EncryptData(), (new CryptData(loginUserModified)).EncryptData() });
            string nblogin = csb.champ("nblogin").ToString();
            csb.suivant();
            csb.fermer();
            if (nblogin == "1")
            {
                lbl_administrateur_gestioncomptes_validationajouterror.Text = "Le login est déjà utilisé pour un utilisateur";
                lbl_administrateur_gestioncomptes_validationajouterror.Show();
                return;
            }
            CURS csa = new CURS();
            csa.ReqSelectPrepare("SELECT COUNT(adrMail) as nbadrMail FROM Utilisateur WHERE adrMail=? AND adrMail!=?", new List<object> { (new CryptData(tbx_administrateur_gestioncomptes_adrMail.Text)).EncryptData(), adrMailModified });
            string nbadrMail = csa.champ("nbadrMail").ToString();
            csa.suivant();
            csa.fermer();
            if (nbadrMail == "1")
            {
                lbl_administrateur_gestioncomptes_validationajouterror.Text = "L’adresse mail est déjà utilisé pour un utilisateur";
                lbl_administrateur_gestioncomptes_validationajouterror.Show();
                return;
            }
            csa.suivant();
            csa.fermer();
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
            int idbateaupecheur = -1;
            if (cbx_administrateur_gestioncomptes_typeuser.Text == "Pêcheur")
            {
                int char_bateau = cbx_administrateur_gestioncomptes_bateau.Text.IndexOf("(");
                String imma = cbx_administrateur_gestioncomptes_bateau.Text.Substring(char_bateau + 1, cbx_administrateur_gestioncomptes_bateau.Text.Length - char_bateau - 2);
                cs.ReqSelectPrepare("SELECT id FROM Bateau WHERE immatriculation=?", new List<object> { imma });
                idbateaupecheur = Int32.Parse(cs.champ("id").ToString());
                cs.fermer();
            }
            cs = new CURS();
            cs.ReqAdminPrepare("CALL UPDATE_USER (?, ?, ?, ?, ?, ?, ?)", new List<object> { idUserModified, (new CryptData(tbx_administrateur_gestioncomptes_login.Text)).EncryptData(), (new CryptData(nom)).EncryptData(), (new CryptData(prenom)).EncryptData(), cbx_administrateur_gestioncomptes_typeuser.Text, (new CryptData(adresseMail)).EncryptData(), idbateaupecheur });
            cs.fermer();
            lbl_administrateur_gestioncomptes_validationajoutok.Text = "Les données de l'utilisateur ont bien été modifiées.\n";
            tbc_administrateur_Selected(sender, _onglet);
            lbl_administrateur_gestioncomptes_validationajoutok.Show();


            if (adresseMail != null)
            {
                string contenu = "Votre compte de l'application AppCriée a été modifié.\n\nVoici vos données mises à jour :\n\nLogin : " + tbx_administrateur_gestioncomptes_login.Text;
                if (nom != null)
                {
                    contenu += "\nNom : " + nom.ToString();
                }
                else
                {
                    contenu += "\nNom : (Non communiqué)";
                }
                if (prenom != null)
                {
                    contenu += "\nPrénom : " + prenom.ToString();
                }
                else
                {
                    contenu += "\nPrénom : (Non communiqué)";
                }
				if (cbx_administrateur_gestioncomptes_typeuser.Text== "Pêcheur")
				{
                    contenu += "\nBateau : " + cbx_administrateur_gestioncomptes_bateau.Text;
                }
                contenu += "\nType utilisateur : " + cbx_administrateur_gestioncomptes_typeuser.Text + "\n\nSupport Informatique de l'application AppCriée\n\nPour toutes questions relatives à l'application AppCriée, veuillez nous contacter à l'adresse : " + DataSystem.AdrMailFrom();
                Exception iferreur;
                bool resultmsg = CompleteControl.SendMail(adresseMail.ToString(), "AppCriée : Modification des données de votre compte", contenu, out iferreur);
                if (resultmsg)
                {
                    lbl_administrateur_gestioncomptes_validationajoutok.Text += "\nUn mail a été envoyé à l'utilisateur";
                }
                else
                {
                    lbl_administrateur_gestioncomptes_validationajoutok.Text += "\nCependant, le mail n'a pu être envoyé à l'utilisateur : \n" + iferreur.Message + "\n\nVeuillez contacter l'utilisateur pour lui indiquer que ses données ont été modifiées";
                }

            }
            else
            {
                lbl_administrateur_gestioncomptes_validationajoutok.Text += "\n\nVeuillez contacter l'utilisateur pour lui indiquer que ses données ont été modifiées";
            }
            idUserModified = null;
            loginUserModified = null;
            adrMailModified = null;
        }

        private void cbx_administrateur_gestioncomptes_typeuser_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HiddenObject.Hide(new List<Control> { lbl_administrateur_gestioncomptes_bateau, cbx_administrateur_gestioncomptes_bateau });
            if (cbx_administrateur_gestioncomptes_typeuser.Text == "Pêcheur")
            {
                HiddenObject.Show(new List<Control> { lbl_administrateur_gestioncomptes_bateau, cbx_administrateur_gestioncomptes_bateau });
            }

        }

        #endregion

        #region Onglet Mes Données

        private void btn_administrateur_mesdonnees_supprimer_Click(object sender, EventArgs e)
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

        private void btn_administrateur_mesdonnees_modifier_Click(object sender, EventArgs e)
        {
            HiddenObject.Show(new List<Control> { lbl_administrateur_mesdonnees_modification, lbl_administrateur_mesdonnees_modifieradrMail, lbl_administrateur_mesdonnees_modifierlogin, lbl_administrateur_mesdonnees_modifiernom, lbl_administrateur_mesdonnees_modifierprenom, tbx_administrateur_mesdonnees_login, tbx_administrateur_mesdonnees_nom, tbx_administrateur_mesdonnees_adrMail, tbx_administrateur_mesdonnees_prenom, btn_administrateur_mesdonnees_validermodif, lbl_administrateur_mesdonnees_champsobli });
            HiddenObject.Hide(new List<Control> { btn_administrateur_mesdonnees_validermodifmdp, lbl_administrateur_mesdonnees_mdpactuel, tbx_administrateur_mesdonnees_mdpactuel, lbl_administrateur_mesdonnees_newmdp, tbx_administrateur_mesdonnees_newmdp, lbl_administrateur_mesdonnees_confirmationnewmdp, tbx_administrateur_mesdonnees_confirmationnewmdp, lbl_administrateur_mesdonnees_modificationmdp });
            tbx_administrateur_mesdonnees_login.Text = _useractuelle.Login; 
            if (_useractuelle.Nom.ToString().Trim() == "(Non communiqué)")
            {
                tbx_administrateur_mesdonnees_nom.Text = "";
            }
            else
            {
                tbx_administrateur_mesdonnees_nom.Text = _useractuelle.Nom.ToString().Trim();
            }
            if (_useractuelle.Prenom.ToString().Trim() == "(Non communiqué)")
            {
                tbx_administrateur_mesdonnees_prenom.Text = "";
            }
            else
            {
                tbx_administrateur_mesdonnees_prenom.Text = _useractuelle.Prenom.ToString();
            }
            if (_useractuelle.AdrMail.ToString().Trim() == "(Non communiquée)")
            {
                tbx_administrateur_mesdonnees_adrMail.Text = "";
            }
            else
            {
                tbx_administrateur_mesdonnees_adrMail.Text = _useractuelle.AdrMail.ToString();
            }
            lbl_administrateur_mesdonnees_validationmodif.Hide();
        }

        private void btn_administrateur_mesdonnees_validermodif_Click(object sender, EventArgs e)
        {
            idUserModified = _useractuelle.Id.ToString();
            if (tbx_administrateur_mesdonnees_login.Text == "")
            {
                lbl_administrateur_mesdonnees_validationmodiferreur.Text = "Tous les champs obligatoires doivent être remplis";
                lbl_administrateur_mesdonnees_validationmodiferreur.Show();
                return;
            }
            if (tbx_administrateur_mesdonnees_adrMail.Text.Trim() != "" && !(Regex.IsMatch(tbx_administrateur_mesdonnees_adrMail.Text, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")))
            {
                lbl_administrateur_mesdonnees_validationmodiferreur.Text = "L’adresse mail saisie n’est pas correcte";
                lbl_administrateur_mesdonnees_validationmodiferreur.Show();
                return;
            }
            CURS csb = new CURS();
            csb.ReqSelectPrepare("SELECT COUNT(login) as nblogin FROM Utilisateur WHERE login=? AND id!=?", new List<object> { (new CryptData(tbx_administrateur_mesdonnees_login.Text)).EncryptData(), idUserModified });
            string nblogin = csb.champ("nblogin").ToString();
            csb.suivant();
            csb.fermer();
            if (nblogin == "1")
            {
                lbl_administrateur_mesdonnees_validationmodiferreur.Text = "Le login est déjà utilisé pour un utilisateur";
                lbl_administrateur_mesdonnees_validationmodiferreur.Show();
                return;
            }
            CURS csa = new CURS();
            csa.ReqSelectPrepare("SELECT COUNT(adrMail) as nbadrMail FROM Utilisateur WHERE adrMail=? AND id!=?", new List<object> { (new CryptData(tbx_administrateur_mesdonnees_adrMail.Text)).EncryptData(), idUserModified });
            string nbadrMail = csa.champ("nbadrMail").ToString();
            csa.suivant();
            csa.fermer();
            if (nbadrMail == "1")
            {
                lbl_administrateur_mesdonnees_validationmodiferreur.Text = "L’adresse mail est déjà utilisé pour un utilisateur";
                lbl_administrateur_mesdonnees_validationmodiferreur.Show();
                return;
            }
            csa.suivant();
            csa.fermer();
            object adrMail = tbx_administrateur_mesdonnees_adrMail.Text;
            if (adrMail.ToString().Trim() == "")
            {
                adrMail = null;
            }
            object nomModif = tbx_administrateur_mesdonnees_nom.Text;
            if (nomModif.ToString().Trim() == "")
            {
                nomModif = null;
            }
            object prenomModif = tbx_administrateur_mesdonnees_prenom.Text;
            if (prenomModif.ToString().Trim() == "")
            {
                prenomModif = null;
            }

            CURS cs = new CURS();
            cs.ReqAdminPrepare("UPDATE Utilisateur SET login=?, nomuser=?, prenomuser=?, adrMail=?, datemodif=NOW() WHERE id=?", new List<object> { (new CryptData(tbx_administrateur_mesdonnees_login.Text)).EncryptData(), (new CryptData(nomModif)).EncryptData(), (new CryptData(prenomModif)).EncryptData(), (new CryptData(adrMail)).EncryptData(), idUserModified });
            cs.fermer();
            lbl_administrateur_mesdonnees_validationmodif.Text = "Vos données ont bien été modifiées.\n";
            HiddenObject.Hide(new List<Control> { lbl_administrateur_mesdonnees_validationmodiferreur, lbl_administrateur_mesdonnees_modification, lbl_administrateur_mesdonnees_modifieradrMail, lbl_administrateur_mesdonnees_modifierlogin, lbl_administrateur_mesdonnees_modifiernom, lbl_administrateur_mesdonnees_modifierprenom, tbx_administrateur_mesdonnees_login, tbx_administrateur_mesdonnees_nom, tbx_administrateur_mesdonnees_adrMail, tbx_administrateur_mesdonnees_prenom, btn_administrateur_mesdonnees_validermodif, lbl_administrateur_mesdonnees_champsobli });

            _useractuelle.Login = tbx_administrateur_mesdonnees_login.Text;
            _useractuelle.Nom = tbx_administrateur_mesdonnees_nom.Text.Trim();
            _useractuelle.Prenom = tbx_administrateur_mesdonnees_prenom.Text.Trim();
            _useractuelle.AdrMail = tbx_administrateur_mesdonnees_adrMail.Text.Trim();

            lbl_administrateur_mesdonnees_login.Text = "Login : " + _useractuelle.Login.ToString();
            lbl_administrateur_mesdonnees_nom.Text = "Nom : " + _useractuelle.Nom.ToString();
            lbl_administrateur_mesdonnees_prenom.Text = "Prénom : " + _useractuelle.Prenom.ToString();
            lbl_administrateur_mesdonnees_adrMail.Text = "Adresse Mail : " + _useractuelle.AdrMail.ToString();

            tbc_administrateur_Selected(sender, _onglet);
            lbl_administrateur_mesdonnees_validationmodif.Show();

        }

        private void btn_administrateur_mesdonnees_modifiermdp_Click(object sender, EventArgs e)
        {
            HiddenObject.Hide(new List<Control> { lbl_administrateur_mesdonnees_modifieradrMail, lbl_administrateur_mesdonnees_modifierlogin, lbl_administrateur_mesdonnees_modifiernom, lbl_administrateur_mesdonnees_modifierprenom, tbx_administrateur_mesdonnees_login, tbx_administrateur_mesdonnees_nom, tbx_administrateur_mesdonnees_prenom, tbx_administrateur_mesdonnees_adrMail, lbl_administrateur_mesdonnees_modification, btn_administrateur_mesdonnees_validermodif, lbl_administrateur_mesdonnees_champsobli, lbl_administrateur_mesdonnees_validationmodif, lbl_administrateur_mesdonnees_validationmodiferreur });
            HiddenObject.Show(new List<Control> { lbl_administrateur_mesdonnees_modificationmdp, lbl_administrateur_mesdonnees_mdpactuel, tbx_administrateur_mesdonnees_mdpactuel, lbl_administrateur_mesdonnees_newmdp, tbx_administrateur_mesdonnees_newmdp, lbl_administrateur_mesdonnees_confirmationnewmdp, tbx_administrateur_mesdonnees_confirmationnewmdp, btn_administrateur_mesdonnees_validermodifmdp });
            tbx_administrateur_mesdonnees_mdpactuel.Text = "";
            tbx_administrateur_mesdonnees_newmdp.Text = "";
            tbx_administrateur_mesdonnees_confirmationnewmdp.Text = "";
        }

        private void btn_administrateur_mesdonnees_validermodifmdp_Click(object sender, EventArgs e)
        {
            idUserModified = _useractuelle.Id.ToString();
            String passwdhash = new HashData(tbx_administrateur_mesdonnees_mdpactuel.Text).HashCalculate();
            if (tbx_administrateur_mesdonnees_mdpactuel.Text == ""|| tbx_administrateur_mesdonnees_newmdp.Text == ""|| tbx_administrateur_mesdonnees_confirmationnewmdp.Text == "")
            {
                lbl_administrateur_mesdonnees_validationmodiferreur.Text = "Tous les champs obligatoires doivent être remplis";
                lbl_administrateur_mesdonnees_validationmodiferreur.Show();
                return;
            }

            CURS cs = new CURS();
            cs.ReqSelectPrepare("CALL Auth(?,?)", new List<object> { (new CryptData(_useractuelle.Login)).EncryptData(), (new CryptData(passwdhash)).EncryptData() });
            if (cs.champ("nbUser").ToString() == "0")
            {
                lbl_administrateur_mesdonnees_validationmodiferreur.Text = "Votre mot de passe actuel est incorrect.";
                lbl_administrateur_mesdonnees_validationmodiferreur.Show();
                return;
            }
            cs.fermer();

            if (!(Regex.IsMatch(tbx_administrateur_mesdonnees_newmdp.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")))
            {
                lbl_administrateur_mesdonnees_validationmodiferreur.Text = "Le mot de passe doit contenir au moins 10 caractères\ncomportant majuscule, minuscules, chiffres et caractères spéciaux";
                lbl_administrateur_mesdonnees_validationmodiferreur.Show();
                return;
            }

            if (tbx_administrateur_mesdonnees_newmdp.Text != tbx_administrateur_mesdonnees_confirmationnewmdp.Text)
            {
                lbl_administrateur_mesdonnees_validationmodiferreur.Text = "Les mots de passes ne correspondent pas, veuillez réessayer.";
                lbl_administrateur_mesdonnees_validationmodiferreur.Show();
                return;
            }

            string motdepassehash = new HashData(tbx_administrateur_mesdonnees_newmdp.Text).HashCalculate();
            CURS csm = new CURS();
            csm.ReqAdminPrepare("UPDATE Utilisateur SET pwd=?, datemodif=NOW() WHERE id=? ", new List<object> { (new CryptData(motdepassehash)).EncryptData(), idUserModified });
            csm.fermer();
            lbl_administrateur_mesdonnees_validationmodif.Text = "Votre mot de passe a bien été modifié.";
            lbl_administrateur_mesdonnees_validationmodif.Show();
            HiddenObject.Hide(new List<Control> { lbl_administrateur_mesdonnees_modificationmdp, lbl_administrateur_mesdonnees_validationmodiferreur, lbl_administrateur_mesdonnees_mdpactuel, tbx_administrateur_mesdonnees_mdpactuel, lbl_administrateur_mesdonnees_newmdp, tbx_administrateur_mesdonnees_newmdp, lbl_administrateur_mesdonnees_confirmationnewmdp, tbx_administrateur_mesdonnees_confirmationnewmdp, btn_administrateur_mesdonnees_validermodifmdp });

        }


        #endregion

        #region Fermture du Formulaire

        private void AppCriee_Administrateur_FormClosing(object sender, FormClosingEventArgs e)
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
        private void pbx_administrateur_deconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		#endregion
	}
}

