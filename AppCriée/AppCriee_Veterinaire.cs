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
        string chaineConnexion;
        int idbateau;
        public string ChaineConnexion
        {
            get { return chaineConnexion; }
            set { chaineConnexion = value; }
        }
        public int IdBateau
        {
            get { return idbateau; }
            set { idbateau = value; }
        }
        List<BacNotLot> listebacnotlot = new List<BacNotLot>();

        string Datejour = DateTime.Today.ToString("yyyy-MM-dd");
        public AppCriee_Veterinaire(User unutilisateur)
        {
            ChaineConnexion = "server = 127.0.0.1; user id = gestionCrie; password = 123xaro08 ; database = bddCrie2";
            InitializeComponent();
            lbl_veterinaire_accueil_bienvenue.Text = "Bienvenue " + unutilisateur.Nom + " " + unutilisateur.Prenom;
            lbl_veterinaire_bacpoissons_datejour.Text = "Date du jour : " + Datejour;
            HiddenObject.Hide(new List<Control> { lbl_veterinaire_bacpoissons_choixbateau, cbx_veterinaire_bacpoissons_listebateaux,btn_veterinaire_bacpoissons_creerbacs, btn_veterinaire_bacpoissons_creerlots, btn_veterinaire_bacpoissons_modifierbacs, btn_veterinaire_bacpoissons_supprimerbacs, dg_veterinaire_bacpoissons_listebac, lbl_veterinaire_bacpoissons_isbac,lbl_veterinaire_bacpoissons_creationbac, lbl_veterinaire_bacpoissons_espece, lbl_veterinaire_bacpoissons_presentation, lbl_veterinaire_bacpoissons_taille, lbl_veterinaire_bacpoissons_qualite, lbl_veterinaire_bacpoissons_typebac, cbx_veterinaire_bacpoissons_espece, cbx_veterinaire_bacpoissons_presentation, cbx_veterinaire_bacpoissons_taille, cbx_veterinaire_bacpoissons_qualite, cbx_veterinaire_bacpoissons_typebac, btn_veterinaire_bacpoissons_valider });
        }

        private void tbc_veterinaire_Selected(object sender, TabControlEventArgs e)
        {
            Datejour = "2020-07-24";
            switch (e.TabPage.Name)
            {
                case "tbp_veterinaire_bacpoisson":
                    if (cbx_veterinaire_bacpoissons_listebateaux.SelectedItem is null)
                    {
                        CURS cs = new CURS(ChaineConnexion);
                        cs.ReqSelect("SELECT idBateau, nom, immatriculation FROM peche INNER JOIN Bateau ON peche.idBateau=Bateau.id WHERE DatePeche='" + Datejour + "'");
                        if (!(cs.champ("idBateau") is null))
                        {
                            lbl_veterinaire_bacpoissons_ispeche.Hide();
                            cbx_veterinaire_bacpoissons_listebateaux.Items.Clear();
                            while (!cs.Fin())
                            {
                                cbx_veterinaire_bacpoissons_listebateaux.Items.Add(cs.champ("nom") + "(" + cs.champ("immatriculation") + ")");
                                cs.suivant();
                            }
                            cbx_veterinaire_bacpoissons_listebateaux.Show();
                            lbl_veterinaire_bacpoissons_choixbateau.Show();
                        }
                        cs.fermer();
                    }
                    break;
            }
        }

        private void cbx_veterinaire_bacpoissons_listebateaux_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HiddenObject.Hide(new List<Control> { lbl_veterinaire_bacpoissons_creationbac, lbl_veterinaire_bacpoissons_espece, lbl_veterinaire_bacpoissons_taille, lbl_veterinaire_bacpoissons_qualite, lbl_veterinaire_bacpoissons_presentation, lbl_veterinaire_bacpoissons_typebac, cbx_veterinaire_bacpoissons_espece, cbx_veterinaire_bacpoissons_taille, cbx_veterinaire_bacpoissons_qualite, cbx_veterinaire_bacpoissons_presentation, cbx_veterinaire_bacpoissons_typebac, btn_veterinaire_bacpoissons_valider });
            Datejour = "2020-07-24";
            String elmt_bateau = cbx_veterinaire_bacpoissons_listebateaux.SelectedItem.ToString();
            int char_bateau = elmt_bateau.IndexOf("(");
            String imma = elmt_bateau.Substring(char_bateau + 1, elmt_bateau.Length - char_bateau - 2);
            CURS cs = new CURS(ChaineConnexion);
            cs.ReqSelect("SELECT bac.id as idBac, idLot, idTypeBac, espece.nom as nomEspece, idTaille, idQualite, idPresentation FROM bac INNER JOIN lot ON lot.id=bac.idLot AND lot.idDatePeche=bac.idDatePeche AND lot.idBateau=bac.idBateau INNER JOIN espece ON lot.idEspece=espece.id INNER JOIN bateau ON lot.idBateau=bateau.id AND bac.idBateau=bateau.id WHERE bac.idDatePeche='" + Datejour + "' AND immatriculation='" + imma + "'");
            if (cs.champ("idBac") is null)
            {
                lbl_veterinaire_bacpoissons_isbac.Show();
            }
            else
            {
                lbl_veterinaire_bacpoissons_isbac.Hide();
                dg_veterinaire_bacpoissons_listebac.Rows.Clear();
                while (!cs.Fin())
                {
                    dg_veterinaire_bacpoissons_listebac.Rows.Add(cs.champ("idBac") + " (" + cs.champ("idLot") + ")", cs.champ("nomEspece"), cs.champ("idTaille"), cs.champ("idQualite"), cs.champ("idPresentation"), cs.champ("idTypeBac"));
                    cs.suivant();
                }
                
            }
            cs.fermer();
            cs = new CURS(ChaineConnexion);
            cs.ReqSelect("SELECT id FROM bateau WHERE immatriculation ='" + imma + "'");
            idbateau = Int32.Parse(cs.champ("id").ToString());
            cs.fermer();

            foreach (BacNotLot unbacnotlot in listebacnotlot)
            {
                if (unbacnotlot.IdBateau == idbateau)
                {
                    dg_veterinaire_bacpoissons_listebac.Rows.Add("(Pas de lots)", unbacnotlot.NomEspece, unbacnotlot.IdTaille, unbacnotlot.IdQualite, unbacnotlot.IdPresentation, unbacnotlot.IdTypeBac);
                }
            }
            if (listebacnotlot.Count(ai=>ai.IdBateau == idbateau) != 0)
            {
                HiddenObject.Show(new List<Control> { btn_veterinaire_bacpoissons_supprimerbacs, btn_veterinaire_bacpoissons_modifierbacs, btn_veterinaire_bacpoissons_creerlots });
            }
            else
            {
                HiddenObject.Hide(new List<Control> { btn_veterinaire_bacpoissons_supprimerbacs, btn_veterinaire_bacpoissons_modifierbacs, btn_veterinaire_bacpoissons_creerlots });
            }
            dg_veterinaire_bacpoissons_listebac.Show();
            btn_veterinaire_bacpoissons_creerbacs.Show();
        }

        private void btn_veterinaire_bacpoissons_creerbacs_Click(object sender, EventArgs e)
        {
            RemplirCombobox(cbx_veterinaire_bacpoissons_espece, "SELECT nom FROM espece", "nom");
            RemplirCombobox(cbx_veterinaire_bacpoissons_taille, "SELECT id FROM Taille", "id");
            RemplirCombobox(cbx_veterinaire_bacpoissons_qualite, "SELECT id FROM Qualite", "id");
            RemplirCombobox(cbx_veterinaire_bacpoissons_presentation, "SELECT id FROM Presentation", "id");
            RemplirCombobox(cbx_veterinaire_bacpoissons_typebac, "SELECT id FROM Typebac", "id");
            btn_veterinaire_bacpoissons_creerbacs.Hide();
            HiddenObject.Show(new List<Control> { btn_veterinaire_bacpoissons_valider, lbl_veterinaire_bacpoissons_creationbac, lbl_veterinaire_bacpoissons_espece, lbl_veterinaire_bacpoissons_taille, lbl_veterinaire_bacpoissons_qualite, lbl_veterinaire_bacpoissons_presentation, lbl_veterinaire_bacpoissons_typebac, cbx_veterinaire_bacpoissons_espece, cbx_veterinaire_bacpoissons_taille, cbx_veterinaire_bacpoissons_qualite, cbx_veterinaire_bacpoissons_presentation, cbx_veterinaire_bacpoissons_typebac});
        }

        private void btn_veterinaire_bacpoissons_valider_Click(object sender, EventArgs e)
        {
            String elmt_bateau = cbx_veterinaire_bacpoissons_espece.SelectedItem.ToString();
            listebacnotlot.Add(new BacNotLot(cbx_veterinaire_bacpoissons_espece.SelectedItem.ToString(), Int32.Parse(cbx_veterinaire_bacpoissons_taille.SelectedItem.ToString()), Char.Parse(cbx_veterinaire_bacpoissons_qualite.SelectedItem.ToString()), cbx_veterinaire_bacpoissons_presentation.SelectedItem.ToString(),IdBateau, Char.Parse(cbx_veterinaire_bacpoissons_typebac.SelectedItem.ToString())));
            dg_veterinaire_bacpoissons_listebac.Rows.Add("(Pas de lots)", cbx_veterinaire_bacpoissons_espece.SelectedItem, cbx_veterinaire_bacpoissons_taille.SelectedItem, cbx_veterinaire_bacpoissons_qualite.SelectedItem, cbx_veterinaire_bacpoissons_presentation.SelectedItem, cbx_veterinaire_bacpoissons_typebac.SelectedItem);
            HiddenObject.Show(new List<Control> { btn_veterinaire_bacpoissons_supprimerbacs, btn_veterinaire_bacpoissons_modifierbacs, btn_veterinaire_bacpoissons_creerlots });
        }

        private void AppCriee_Veterinaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listebacnotlot.Count != 0)
            {
                DialogResult result = MessageBox.Show("Des bacs ont été crée sans être associer à un lot, ces bacs ne seront pas sauvegardées\nVoulez-vous vraiment quitter ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                Application.ExitThread();
            }
        }

        private void RemplirCombobox(ComboBox unComboBox, String requete, String champs, Boolean selectdefault = true, Boolean clear=true)
        {
            if (clear)
            {
                unComboBox.Items.Clear();
            }
            CURS cs = new CURS(ChaineConnexion);
            cs.ReqSelect(requete);
            while (!cs.Fin())
            {
                unComboBox.Items.Add(cs.champ(champs));
                cs.suivant();
            }
            cs.fermer();
            if (selectdefault)
            {
                unComboBox.SelectedItem = unComboBox.Items[0];
            }
        }

        private void btn_veterinaire_bacpoissons_creerlots_Click(object sender, EventArgs e)
        {
            TabControlEventArgs b = new TabControlEventArgs(tbp_veterinaire_lotspeche, 2, TabControlAction.Selected);
            TabControlEventHandler handler = tbc_veterinaire_Selected;
            handler?.Invoke(sender,b);
            //Aller dans le menu Lots de poissons
        }
    }
}
