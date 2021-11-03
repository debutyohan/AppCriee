﻿using System;
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
        
        #endregion

        #region Constructeur

        public AppCriee_DirecteurDesVentes(User unutilisateur, AppCriee authAccueil)
        {
            InitializeComponent();
            _authAccueil = authAccueil;
            lbl_directeurdesventes_accueil_bienvenue.Text = "Bienvenue " + unutilisateur.Nom + " " + unutilisateur.Prenom;
            lbl_directeurdesventes_datejour.Text = "Date du jour : " + DateTime.Today.ToString("dd/MM/yyyy");
        }

        #endregion

        #region Fermeture du Formulaire

        private void AppCriee_DirecteurDesVentes_FormClosing(object sender, FormClosingEventArgs e)
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
        private void pbx_directeurdesventes_deconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
