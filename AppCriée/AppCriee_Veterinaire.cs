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
    public partial class AppCriee_Veterinaire : Form
    {
        public AppCriee_Veterinaire(User unutilisateur)
        {
            InitializeComponent();
            lbl_veterinaire_accueil_bienvenue.Text = "Bienvenue " + unutilisateur.Nom + " " + unutilisateur.Prenom;
            lbl_veterinaire_accueil_role.Text = "Rôle : " + unutilisateur.Libelletype;
        }
    }
}
