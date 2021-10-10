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
        string chaineConnexion = ConnectionChain.chaineConnexion();
        int idbateau;
        List<BacNotLot> listebacnotlot = new List<BacNotLot>();

        string Datejour = DateTime.Today.ToString("yyyy-MM-dd");
        public AppCriee_Veterinaire(User unutilisateur)
        {
            InitializeComponent();
            lbl_veterinaire_accueil_bienvenue.Text = "Bienvenue " + unutilisateur.Nom + " " + unutilisateur.Prenom;
            lbl_veterinaire_lotspeche_datejour.Text = "Date du jour : " + Datejour;
            HiddenObject.Hide(new List<Control> { lbl_veterinaire_bacpoissons_choixbateau, cbx_veterinaire_bacpoissons_listebateaux,btn_veterinaire_bacpoissons_creerbacs, btn_veterinaire_bacpoissons_creerlots, btn_veterinaire_bacpoissons_modifierbacs, btn_veterinaire_bacpoissons_supprimerbacs, dg_veterinaire_bacpoissons_listebac, lbl_veterinaire_bacpoissons_isbac,lbl_veterinaire_bacpoissons_creationbac, lbl_veterinaire_bacpoissons_espece, lbl_veterinaire_bacpoissons_presentation, lbl_veterinaire_bacpoissons_taille, lbl_veterinaire_bacpoissons_qualite, lbl_veterinaire_bacpoissons_typebac, cbx_veterinaire_bacpoissons_espece, cbx_veterinaire_bacpoissons_presentation, cbx_veterinaire_bacpoissons_taille, cbx_veterinaire_bacpoissons_qualite, cbx_veterinaire_bacpoissons_typebac, btn_veterinaire_bacpoissons_valider});
        }

        private void tbc_veterinaire_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPage.Name)
            {
                case "tbp_veterinaire_bacpoisson":
                    if (cbx_veterinaire_bacpoissons_listebateaux.SelectedItem is null)
                    {
                        if (CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_listebateaux, "SELECT idBateau, nom, immatriculation FROM peche INNER JOIN Bateau ON peche.idBateau=Bateau.id WHERE DatePeche='" + Datejour + "'", "nom(immatriculation)"))
                        {
                            HiddenObject.Hide(new List<Control> { lbl_veterinaire_bacpoissons_ispeche });
                            HiddenObject.Show(new List<Control> { cbx_veterinaire_bacpoissons_listebateaux, lbl_veterinaire_bacpoissons_choixbateau });
                        }
                    }
                    else
                    {
                        if (cbx_veterinaire_bacpoissons_listebateaux.SelectedItem.ToString() != "")
                        {
                            cbx_veterinaire_bacpoissons_listebateaux_SelectionChangeCommitted(sender, e);
                        }
                    }
                    break;
                case "tbp_veterinaire_lotspeche":
                    if (cbx_veterinaire_lotspeche_listebateaux.SelectedItem is null)
                    {
                        if (CompleteControl.RemplirCombobox(cbx_veterinaire_lotspeche_listebateaux, "SELECT idBateau, nom, immatriculation FROM peche INNER JOIN Bateau ON peche.idBateau=Bateau.id WHERE DatePeche='" + Datejour + "'", "nom(immatriculation)"))
                        {
                            HiddenObject.Hide(new List<Control> { lbl_veterinaire_lotspeche_ispeche });
                            HiddenObject.Show(new List<Control> { cbx_veterinaire_lotspeche_listebateaux, lbl_veterinaire_lotspeche_choixbateau });
                        }
                    }
                    else
                    {
                        if (cbx_veterinaire_lotspeche_listebateaux.SelectedItem.ToString() != "")
                        {
                            cbx_veterinaire_lotspeche_listebateaux_SelectionChangeCommitted(sender, e);
                        }
                    }
                    break;
            }
        }

        private void cbx_veterinaire_bacpoissons_listebateaux_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bool isbateau = false;
            HiddenObject.Hide(new List<Control> { lbl_veterinaire_bacpoissons_creationbac, lbl_veterinaire_bacpoissons_espece, lbl_veterinaire_bacpoissons_taille, lbl_veterinaire_bacpoissons_qualite, lbl_veterinaire_bacpoissons_presentation, lbl_veterinaire_bacpoissons_typebac, cbx_veterinaire_bacpoissons_espece, cbx_veterinaire_bacpoissons_taille, cbx_veterinaire_bacpoissons_qualite, cbx_veterinaire_bacpoissons_presentation, cbx_veterinaire_bacpoissons_typebac, btn_veterinaire_bacpoissons_valider });
            String elmt_bateau = cbx_veterinaire_bacpoissons_listebateaux.SelectedItem.ToString();
            int char_bateau = elmt_bateau.IndexOf("(");
            String imma = elmt_bateau.Substring(char_bateau + 1, elmt_bateau.Length - char_bateau - 2);
            CURS cs = new CURS(chaineConnexion);
            dg_veterinaire_bacpoissons_listebac.Rows.Clear();
            cs.ReqSelect("SELECT bac.id as idBac, idLot, idTypeBac, espece.nom as nomEspece, idTaille, idQualite, idPresentation FROM bac INNER JOIN lot ON lot.id=bac.idLot AND lot.idDatePeche=bac.idDatePeche AND lot.idBateau=bac.idBateau INNER JOIN espece ON lot.idEspece=espece.id INNER JOIN bateau ON lot.idBateau=bateau.id AND bac.idBateau=bateau.id WHERE bac.idDatePeche='" + Datejour + "' AND immatriculation='" + imma + "'");
            if (cs.champ("idBac") is null)
            {
                lbl_veterinaire_bacpoissons_isbac.Show();
            }
            else
            {
                isbateau = true;
                lbl_veterinaire_bacpoissons_isbac.Hide();
                while (!cs.Fin())
                {
                    dg_veterinaire_bacpoissons_listebac.Rows.Add(cs.champ("idBac") + " (" + cs.champ("idLot") + ")", cs.champ("nomEspece"), cs.champ("idTaille"), cs.champ("idQualite"), cs.champ("idPresentation"), cs.champ("idTypeBac"));
                    cs.suivant();
                }
                
            }
            cs.fermer();
            cs = new CURS(chaineConnexion);
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
                isbateau = true;
            }
            else
            {
                HiddenObject.Hide(new List<Control> { btn_veterinaire_bacpoissons_supprimerbacs, btn_veterinaire_bacpoissons_modifierbacs, btn_veterinaire_bacpoissons_creerlots });
            }
            if (isbateau)
            {
                dg_veterinaire_bacpoissons_listebac.Show();
                lbl_veterinaire_bacpoissons_isbac.Hide();
            }
            else
            {
                dg_veterinaire_bacpoissons_listebac.Hide();
                lbl_veterinaire_bacpoissons_isbac.Show();
            }
            
            btn_veterinaire_bacpoissons_creerbacs.Show();
        }

        private void btn_veterinaire_bacpoissons_creerbacs_Click(object sender, EventArgs e)
        {
            CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_espece, "SELECT nom FROM espece", "nom");
            CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_taille, "SELECT id FROM Taille", "id");
            CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_qualite, "SELECT id FROM Qualite", "id");
            CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_presentation, "SELECT id FROM Presentation", "id");
            CompleteControl.RemplirCombobox(cbx_veterinaire_bacpoissons_typebac, "SELECT id FROM Typebac", "id");
            btn_veterinaire_bacpoissons_creerbacs.Hide();
            HiddenObject.Show(new List<Control> { btn_veterinaire_bacpoissons_valider, lbl_veterinaire_bacpoissons_creationbac, lbl_veterinaire_bacpoissons_espece, lbl_veterinaire_bacpoissons_taille, lbl_veterinaire_bacpoissons_qualite, lbl_veterinaire_bacpoissons_presentation, lbl_veterinaire_bacpoissons_typebac, cbx_veterinaire_bacpoissons_espece, cbx_veterinaire_bacpoissons_taille, cbx_veterinaire_bacpoissons_qualite, cbx_veterinaire_bacpoissons_presentation, cbx_veterinaire_bacpoissons_typebac});
        }

        private void btn_veterinaire_bacpoissons_valider_Click(object sender, EventArgs e)
        {
            String elmt_bateau = cbx_veterinaire_bacpoissons_espece.SelectedItem.ToString();
            listebacnotlot.Add(new BacNotLot(cbx_veterinaire_bacpoissons_espece.SelectedItem.ToString(), Int32.Parse(cbx_veterinaire_bacpoissons_taille.SelectedItem.ToString()), Char.Parse(cbx_veterinaire_bacpoissons_qualite.SelectedItem.ToString()), cbx_veterinaire_bacpoissons_presentation.SelectedItem.ToString(),idbateau, Char.Parse(cbx_veterinaire_bacpoissons_typebac.SelectedItem.ToString())));
            dg_veterinaire_bacpoissons_listebac.Rows.Add("(Pas de lots)", cbx_veterinaire_bacpoissons_espece.SelectedItem, cbx_veterinaire_bacpoissons_taille.SelectedItem, cbx_veterinaire_bacpoissons_qualite.SelectedItem, cbx_veterinaire_bacpoissons_presentation.SelectedItem, cbx_veterinaire_bacpoissons_typebac.SelectedItem);
            HiddenObject.Show(new List<Control> { btn_veterinaire_bacpoissons_supprimerbacs, btn_veterinaire_bacpoissons_modifierbacs, btn_veterinaire_bacpoissons_creerlots });
            dg_veterinaire_bacpoissons_listebac.Show();
            lbl_veterinaire_bacpoissons_isbac.Hide();
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

        private void btn_veterinaire_bacpoissons_creerlots_Click(object sender, EventArgs e)
        {
            tbc_veterinaire.SelectedTab = tbp_veterinaire_lotspeche;
        }

        private void cbx_veterinaire_lotspeche_listebateaux_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HiddenObject.Hide(new List<Control> {lbl_veterinaire_lotspeche_isokcreerlot,cbx_veterinaire_lotspeche_lotsbateau, btn_veterinaire_lotspeche_assigneralot, btn_veterinaire_lotspeche_creerlot, dg_veterinaire_lotspeche_bacnotlot, dg_veterinaire_lotspeche_lotsbateau, lbl_veterinaire_lotspeche_isbacs });
            HiddenObject.Show(new List<Control> {lbl_veterinaire_lotspeche_isbacsnotlot, lbl_veterinaire_lotspeche_lotsbateau, lbl_veterinaire_lotspeche_bacnotlot, lbl_veterinaire_lotspeche_islots });
            String elmt_bateau = cbx_veterinaire_lotspeche_listebateaux.SelectedItem.ToString();
            int char_bateau = elmt_bateau.IndexOf("(");
            String imma = elmt_bateau.Substring(char_bateau + 1, elmt_bateau.Length - char_bateau - 2);
            bool islots = CompleteControl.RemplirDataGridViewByRequest(dg_veterinaire_lotspeche_lotsbateau, "SELECT idLot, count(idLot) as nbbac, espece.nom as nomEspece, idTaille, idPresentation, idQualite FROM bac INNER JOIN lot ON bac.idDatePeche=lot.idDatePeche AND bac.idBateau=lot.idBateau AND bac.idLot=lot.id INNER JOIN espece ON espece.id=lot.idEspece INNER JOIN bateau ON bateau.id=lot.idBateau AND bateau.id=bac.idBateau WHERE bac.idDatePeche='" + Datejour + "' AND immatriculation='" + imma + "' GROUP BY idLot",new string[] { "idLot","nomEspece", "idTaille", "idQualite", "idPresentation", "nbbac" });
            if (islots) { dg_veterinaire_lotspeche_lotsbateau.Show(); lbl_veterinaire_lotspeche_islots.Hide(); }
            CURS cs = new CURS(chaineConnexion);
            cs.ReqSelect("SELECT id FROM bateau WHERE immatriculation ='" + imma + "'");
            idbateau = Int32.Parse(cs.champ("id").ToString());
            cs.fermer();
            dg_veterinaire_lotspeche_bacnotlot.Rows.Clear();
            bool isbacnotlot = false;
            foreach (BacNotLot unbacnotlot in listebacnotlot)
            {
                if (unbacnotlot.IdBateau == idbateau)
                {
                    isbacnotlot = true;
                    dg_veterinaire_lotspeche_bacnotlot.Rows.Add(unbacnotlot.NomEspece, unbacnotlot.IdTaille, unbacnotlot.IdQualite, unbacnotlot.IdPresentation, unbacnotlot.IdTypeBac, unbacnotlot.Id);
                }
            }
            if (isbacnotlot)
            {
                HiddenObject.Show(new List<Control> { cbx_veterinaire_lotspeche_lotsbateau, btn_veterinaire_lotspeche_creerlot, dg_veterinaire_lotspeche_bacnotlot, btn_veterinaire_lotspeche_assigneralot });
                HiddenObject.Hide(new List<Control> { lbl_veterinaire_lotspeche_isbacsnotlot });
            }

            if(!isbacnotlot && !islots){
                HiddenObject.Hide(new List<Control> { lbl_veterinaire_lotspeche_lotsbateau, lbl_veterinaire_lotspeche_bacnotlot, lbl_veterinaire_bacpoissons_isbac, lbl_veterinaire_lotspeche_isbacsnotlot, lbl_veterinaire_lotspeche_islots });
                HiddenObject.Show(new List<Control> { lbl_veterinaire_lotspeche_isbacs });
            }
        }

        private void btn_veterinaire_lotspeche_creerlot_Click(object sender, EventArgs e)
        {
            String elmt_bateau = cbx_veterinaire_lotspeche_listebateaux.SelectedItem.ToString();
            int char_bateau = elmt_bateau.IndexOf("(");
            String imma = elmt_bateau.Substring(char_bateau + 1, elmt_bateau.Length - char_bateau - 2);
            int idlotmax = -1;
            foreach (DataGridViewRow row in dg_veterinaire_lotspeche_lotsbateau.Rows)
            {
                if (idlotmax < Int32.Parse(row.Cells[0].Value.ToString())){
                    idlotmax = Int32.Parse(row.Cells[0].Value.ToString());
                }
            }
            object[] etqplot = null;
            bool isok = true;
            foreach(DataGridViewRow item in dg_veterinaire_lotspeche_bacnotlot.SelectedRows)
            {
                if(!(etqplot is null))
                {
                    for(int i=0;i<4;i++)
                    {
                        if (etqplot[i].ToString() != item.Cells[i].Value.ToString())
                        {
                            isok = false;
                            break;
                        }
                    }
                }
                etqplot = new object[] { item.Cells["dgtbx_bacnotlots_espece"].Value, item.Cells["dgtbx_bacnotlots_taille"].Value, item.Cells["dgtbx_bacnotlots_qualite"].Value, item.Cells["dgtbx_bacnotlots_presentation"].Value };
            }
            if (!isok)
            {
                lbl_veterinaire_lotspeche_isokcreerlot.ForeColor = System.Drawing.Color.Red;
                lbl_veterinaire_lotspeche_isokcreerlot.Text = "Veuillez sélectionner des bacs ayant\nles mêmes caractéristiques ETQP";
                lbl_veterinaire_lotspeche_isokcreerlot.Show();
            }
            else
            {
                CURS cs = new CURS(chaineConnexion);
                cs.ReqAdmin("INSERT INTO lot(idDatePeche,idBateau , id, idEspece, idTaille, idPresentation, idQualite) VALUES ('" + Datejour + "',(SELECT id FROM bateau WHERE immatriculation='"+ imma + "'),"+(idlotmax+1)+",(SELECT id FROM espece WHERE nom='" + etqplot[0] + "')," + etqplot[1] + ",'" + etqplot[3] + "','" + etqplot[2] + "')");
                cs.fermer();
                string requetesel = "INSERT INTO bac(id, idDatePeche,idBateau, idLot, idTypeBac) VALUES ";
                for(int i=0; i < dg_veterinaire_lotspeche_bacnotlot.SelectedRows.Count; i++)
                {
                    requetesel+="("+i+",'"+Datejour+ "',(SELECT id FROM bateau WHERE immatriculation='" + imma + "')," + (idlotmax+1)+",'" + dg_veterinaire_lotspeche_bacnotlot.SelectedRows[i].Cells["dgtbx_bacnotlots_typebac"].Value.ToString()+"'),";
                }
                requetesel = requetesel.Substring(0, requetesel.Length - 1);
                cs = new CURS(chaineConnexion);
                cs.ReqAdmin(requetesel);
                cs.fermer();
                foreach(DataGridViewRow item in dg_veterinaire_lotspeche_bacnotlot.SelectedRows)
                {
                    listebacnotlot.Remove(listebacnotlot.Find(ai => ai.Id == item.Cells["id"].Value.ToString()));
                }
                cbx_veterinaire_lotspeche_listebateaux_SelectionChangeCommitted(sender, e);
                lbl_veterinaire_lotspeche_isokcreerlot.ForeColor = System.Drawing.Color.Blue;
                lbl_veterinaire_lotspeche_isokcreerlot.Text = "Le lot a bien été créée";
                lbl_veterinaire_lotspeche_isokcreerlot.Show();
            }
        }
    }
}
