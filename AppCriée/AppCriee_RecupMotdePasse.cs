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
    public partial class AppCriee_RecupMotdePasse : Form
    {
        #region Données privées

        AppCriee _appCriee;
        string codegenere;
        int tentativecode = -1;
        string loginispassmodified;

        #endregion

        #region Constructeur

        public AppCriee_RecupMotdePasse(AppCriee appCriee)
        {
            InitializeComponent();
            _appCriee = appCriee;
        }

        #endregion

        #region Fermeture du Formulaire

        private void AppCriee_RecupMotdePasse_FormClosing(object sender, FormClosingEventArgs e)
        {
            _appCriee.Show();
        }

        #endregion

        #region Evènement
        private void btn_recupmotdepasse_reinit_Click(object sender, EventArgs e)
        {
            if(tbx_recupmotdepasse_adrMail.Text.Trim()==""&& tbx_recupmotdepasse_login.Text.Trim()=="")
            {
                lbl_recupmotdepasse_error.Text = "Veuillez saisir une adresse mail ou un login";
                lbl_recupmotdepasse_error.Show();
                return;
            }
            if(tbx_recupmotdepasse_login.Text.Trim() != "")
            {

                CURS cs = new CURS();
                cs.ReqSelectPrepare("SELECT count(id) as nb, adrMail, idtypeuser FROM Utilisateur WHERE login=?", new List<object> { (new CryptData(tbx_recupmotdepasse_login.Text)).EncryptData() });
                if ((cs.champ("nb").ToString() == "0") || ((cs.champ("nb").ToString() == "1")&&(cs.champ("idtypeuser").ToString() == "5")))
                {
                    lbl_recupmotdepasse_error.Text = "Veuillez vérifier votre login, il est incorrect.\nSi vous ne vous souvenez pas de votre login, entrez votre adresse mail.\nSi vous ne vous souvenez pas non plus de votre adresse mail,\nrefaites une demande de compte auprès du support informatique dans l’option :\n« Demander la création d’un compte » lors de la page de connexion";
                    lbl_recupmotdepasse_error.Show();
                    cs.fermer();
                    return;
                }
                string adrMail = (new CryptData(cs.champ("adrMail"))).DecryptData() ?? "";
                cs.fermer();
                if (adrMail == "")
                {
                    lbl_recupmotdepasse_error.Text = "Votre login n’est pas associé à une adresse mail,\nrefaites une demande de compte auprès du support informatique dans l’option :\n« Demander la création d’un compte » lors de la page de connexion";
                    lbl_recupmotdepasse_error.Show();
                    return;
                }
                Exception resultmsg;
                codegenere = Outils.GeneratePassword(10, new char[] {'0','1','2','3','4','5','6','7','8','9' });
                loginispassmodified = tbx_recupmotdepasse_login.Text.Trim();
                string contenu = "Vous avez demandé une réinitialisation de votre mot de passe sur votre compte '"+ loginispassmodified + "'.\nVoici le code à saisir dans la fenêtre de l'application :\n"+codegenere;
                bool ismail = CompleteControl.SendMail(adrMail, "AppCriée : Réinitialisation de mot de passe", "Vous avez demandé une réinitialisation de votre mot de passe sur votre compte '" + tbx_recupmotdepasse_login.Text.Trim() + "'.\nVoici le code à saisir dans la fenêtre de l'application :\n" + codegenere+ "\n\nSupport Informatique de l'application AppCriée\n\nPour toutes questions relatives à l'application AppCriée, veuillez nous contacter à l'adresse : " + DataSystem.AdrMailFrom(), out resultmsg);
                if (!ismail)
                {
                    MessageBox.Show("Un envoi de mail a échoué : " + resultmsg.Message + "\nVeuillez réessayer plus tard, vérifier votre pare-feu ou contacter\nle support informatique de l’application");
                    return;
                }
                HiddenObject.Hide(new List<Control> { lbl_recupmotdepasse_adrMail, lbl_recupmotdepasse_login, lbl_recupmotdepasse_ou, btn_recupmotdepasse_reinit, tbx_recupmotdepasse_adrMail, tbx_recupmotdepasse_login, lbl_recupmotdepasse_error});
                lbl_recupmotdepasse_indicationdebut.Text = "Insérer le code qui vous a été transmis par\nmail sur l'adresse mail associé à votre compte";
                HiddenObject.Show(new List<Control> {lbl_recupmotdepasse_code, tbx_recupmotdepasse_code, btn_recupmotdepasse_validercode });
            }
            else
            {
                CURS cs = new CURS();
                cs.ReqSelectPrepare("SELECT count(login) AS nbadr, login, idtypeuser FROM Utilisateur WHERE adrMail=?", new List<object> { (new CryptData(tbx_recupmotdepasse_adrMail.Text)).EncryptData() });
                string nbadr = cs.champ("nbadr").ToString();
                if ((nbadr == "0") || ((nbadr == "1") && cs.champ("idtypeuser").ToString()=="5"))
                {
                    lbl_recupmotdepasse_error.Text = "Aucun compte n'est reliée à cette adresse mail.\nVeuillez vérifier l'adresse mail ou insérer votre login.\nSi vous ne vous souvenez pas ni de votre adresse mail ni de votre login,\nrefaites une demande de compte auprès du support informatique dans l’option :\n« Demander la création d’un compte » lors de la page de connexion";
                    lbl_recupmotdepasse_error.Show();
                    cs.fermer();
                    return;
                }
                loginispassmodified = (new CryptData(cs.champ("login"))).DecryptData();
                cs.fermer();
                if (nbadr != "0")
                {
                    Exception resultmsg;
                    codegenere = Outils.GeneratePassword(10, new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
                    
                    string contenu = "Vous avez demandé une réinitialisation de votre mot de passe sur votre compte '" + loginispassmodified + "'.\nVoici le code à saisir dans la fenêtre de l'application :\n" + codegenere;
                    bool ismail = CompleteControl.SendMail(tbx_recupmotdepasse_adrMail.Text, "AppCriée : Réinitialisation de mot de passe", "Vous avez demandé une réinitialisation de votre mot de passe sur votre compte '" + tbx_recupmotdepasse_login.Text.Trim() + "'.\nVoici le code à saisir dans la fenêtre de l'application :\n" + codegenere + "\n\nSupport Informatique de l'application AppCriée\n\nPour toutes questions relatives à l'application AppCriée, veuillez nous contacter à l'adresse : " + DataSystem.AdrMailFrom(), out resultmsg);
                    if (!ismail)
                    {
                    MessageBox.Show("Un envoi de mail a échoué : " + resultmsg.Message + "\nVeuillez réessayer plus tard, vérifier votre pare-feu ou contacter\nle support informatique de l’application");
                    return;
                    }
                    HiddenObject.Hide(new List<Control> { lbl_recupmotdepasse_adrMail, lbl_recupmotdepasse_login, lbl_recupmotdepasse_ou, btn_recupmotdepasse_reinit, tbx_recupmotdepasse_adrMail, tbx_recupmotdepasse_login, lbl_recupmotdepasse_error });
                    lbl_recupmotdepasse_indicationdebut.Text = "Insérer le code qui vous a été transmis par\nmail sur l'adresse mail associé à votre compte";
                    HiddenObject.Show(new List<Control> { lbl_recupmotdepasse_code, tbx_recupmotdepasse_code, btn_recupmotdepasse_validercode });
                }

            }
        }

        private void btn_recupmotdepasse_validercode_Click(object sender, EventArgs e)
        {
            tentativecode++;
            lbl_recupmotdepasse_error.Hide();
            if (codegenere == tbx_recupmotdepasse_code.Text)
            {
                HiddenObject.Hide(new List<Control> { lbl_recupmotdepasse_code, tbx_recupmotdepasse_code, btn_recupmotdepasse_validercode});
                lbl_recupmotdepasse_indicationdebut.Text = "Le code est correct, Veuillez choisir un\nnouveau mot de passe";
                lbl_recupmotdepasse_indicationdebut.ForeColor = Color.Blue;
                HiddenObject.Show(new List<Control> { lbl_recupmotdepasse_nouveaumotdepasse, lbl_recupmotdepasse_confirmermotdepasse, tbx_recupmotdepasse_confirmermotdepasse, tbx_recupmotdepasse_nouveaumotdepasse, btn_recupmotdepasse_validernouveaumotdepasse, chbx_recupmotdepasse_nouveaumotdepasse , chbx_recupmotdepasse_confirmermotdepasse});
                codegenere = null;
            }
            else
            {
                if (tentativecode >= 2)
                {
                    _appCriee.Show();
                    this.Close();
                    MessageBox.Show("Trop de tentatives pour saisir le code.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lbl_recupmotdepasse_error.Text = "Code incorrecte, il ne vous reste plus que " + (2 - tentativecode) + " tentatives";
                    lbl_recupmotdepasse_error.Show();
                }
            }
        }

        private void btn_recupmotdepasse_validernouveaumotdepasse_Click(object sender, EventArgs e)
        {
            if (tbx_recupmotdepasse_nouveaumotdepasse.Text != tbx_recupmotdepasse_confirmermotdepasse.Text)
            {
                lbl_recupmotdepasse_error.Text = "Le mot de passe entré est différent du mot de passe confirmé";
                lbl_recupmotdepasse_error.Show();
                return;
            }
            if (!(Regex.IsMatch(tbx_recupmotdepasse_nouveaumotdepasse.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")))
            {
                lbl_recupmotdepasse_error.Text = "Le mot de passe doit contenir au moins 10 caractères comportant majuscule,\nminuscules, chiffres et caractères spéciaux";
                lbl_recupmotdepasse_error.Show();
                return;
            }
            string passhash = new HashData(tbx_recupmotdepasse_nouveaumotdepasse.Text).HashCalculate();
            CURS cs = new CURS();
            cs.ReqAdminPrepare("UPDATE Utilisateur SET pwd=? WHERE login=?", new List<object> { (new CryptData(passhash)).EncryptData(), (new CryptData(loginispassmodified)).EncryptData() });
            cs.fermer();
            HiddenObject.Hide(new List<Control> { lbl_recupmotdepasse_error, lbl_recupmotdepasse_confirmermotdepasse, lbl_recupmotdepasse_nouveaumotdepasse, lbl_recupmotdepasse_indicationdebut, tbx_recupmotdepasse_confirmermotdepasse, tbx_recupmotdepasse_nouveaumotdepasse, btn_recupmotdepasse_validernouveaumotdepasse, chbx_recupmotdepasse_nouveaumotdepasse, chbx_recupmotdepasse_confirmermotdepasse });
            lbl_recupmotdepasse_ok.Show();
            loginispassmodified = null;
        }

        private void chbx_recupmotdepasse_nouveaumotdepasse_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_recupmotdepasse_nouveaumotdepasse.Checked)
                tbx_recupmotdepasse_nouveaumotdepasse.UseSystemPasswordChar = false;
            else
                tbx_recupmotdepasse_nouveaumotdepasse.UseSystemPasswordChar = true;
        }

        private void chbx_recupmotdepasse_confirmermotdepasse_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_recupmotdepasse_confirmermotdepasse.Checked)
                tbx_recupmotdepasse_confirmermotdepasse.UseSystemPasswordChar = false;
            else
                tbx_recupmotdepasse_confirmermotdepasse.UseSystemPasswordChar = true;
        }
        #endregion
    }
}
