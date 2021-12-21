using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCriée
{
    public partial class AppCriee_Peseur : Form
    {
        #region Données privées

        string Datejour = DateTime.Today.ToString("yyyy-MM-dd");
        int idLotisWeightModifing = -1;
        string idBacisWeightModifing = "";
        DataGridViewCellEventArgs dernierclic;
        DataGridViewRow ligneselect;
        int idbateau;
        AppCriee _authAccueil;
        User _useractuelle;
        TabControlEventArgs _onglet;
        string idUserModified;

        #endregion

        #region Constructeur
        public AppCriee_Peseur(User unutilisateur, AppCriee authAccueil)
        {
            InitializeComponent();
            _authAccueil = authAccueil;
            _useractuelle = unutilisateur;
            lbl_peseur_accueil_bienvenue.Text = "Bienvenue " + unutilisateur.Nom + " " + unutilisateur.Prenom;
            lbl_peseur_datejour.Text = "Date du jour : " + DateTime.Today.ToString("dd/MM/yyyy");
            HiddenObject.Hide(new List<Control> { lbl_peseur_lotspeche_choixbateau });
           
        }

        #endregion

        #region Changement d'onglet

        private void tbc_peseur_Selected(object sender, TabControlEventArgs e)
        {
            if (cbx_peseur_lotspeche_listebateaux.SelectedItem is null)
            {
                if (CompleteControl.RemplirCombobox(cbx_peseur_lotspeche_listebateaux, "SELECT idBateau, nom, immatriculation FROM peche INNER JOIN Bateau ON peche.idBateau=Bateau.id WHERE DatePeche=?", "nom(immatriculation)", new List<object> { Datejour }, false))
                {
                    HiddenObject.Hide(new List<Control> { lbl_peseur_lotspeche_ispeche });
                    HiddenObject.Show(new List<Control> { cbx_peseur_lotspeche_listebateaux, lbl_peseur_lotspeche_choixbateau });
                }
            }
            else
            {
                if (cbx_peseur_lotspeche_listebateaux.SelectedItem.ToString() != "")
                {
                    cbx_peseur_lotspeche_listebateaux_SelectionChangeCommitted(sender, e);
                }
            }
            _onglet = e;
            switch (e.TabPage.Name)
            {
                case "tbp_peseur_accueil":
                    lbl_peseur_accueil_bienvenue.Text = "Bienvenue " + _useractuelle.Nom + " " + _useractuelle.Prenom;
                    break;
                case "tbp_peseur_mesdonnees":
                    HiddenObject.Hide(new List<Control> { lbl_peseur_mesdonnees_modificationmdp, lbl_peseur_mesdonnees_validationmodif, lbl_peseur_mesdonnees_mdpactuel, tbx_peseur_mesdonnees_mdpactuel, lbl_peseur_mesdonnees_newmdp, tbx_peseur_mesdonnees_newmdp, lbl_peseur_mesdonnees_confirmationnewmdp, tbx_peseur_mesdonnees_confirmationnewmdp, btn_peseur_mesdonnees_validermodifmdp, lbl_peseur_mesdonnees_validationmodiferreur, lbl_peseur_mesdonnees_modification, lbl_peseur_mesdonnees_modifieradrMail, lbl_peseur_mesdonnees_modifierlogin, lbl_peseur_mesdonnees_modifiernom, lbl_peseur_mesdonnees_modifierprenom, tbx_peseur_mesdonnees_login, tbx_peseur_mesdonnees_nom, tbx_peseur_mesdonnees_adrMail, tbx_peseur_mesdonnees_prenom, btn_peseur_mesdonnees_validermodif, lbl_peseur_mesdonnees_champsobli, lbl_peseur_mesdonnees_validationmodif, lbl_peseur_mesdonnees_validationmodiferreur, });
                    lbl_peseur_mesdonnees_login.Text = "Login : " + _useractuelle.Login;
                    lbl_peseur_mesdonnees_prenom.Text = "Prénom : " + _useractuelle.Prenom;
                    lbl_peseur_mesdonnees_nom.Text = "Nom : " + _useractuelle.Nom;
                    lbl_peseur_mesdonnees_adrMail.Text = "Adresse Mail : " + _useractuelle.AdrMail;
                    lbl_peseur_mesdonnees_typeuser.Text = "Type utilisateur : " + _useractuelle.Libelletype;
                    if (_useractuelle.AdrMail == "")
                    {
                        lbl_peseur_mesdonnees_adrMail.Text = "Adresse Mail : (Non communiquée)";
                    }
                    if (_useractuelle.Nom == "")
                    {
                        lbl_peseur_mesdonnees_nom.Text = "Nom : (Non communiquée)";
                    }
                    if (_useractuelle.Prenom == "")
                    {
                        lbl_peseur_mesdonnees_prenom.Text = "Prénom : (Non communiquée)";
                    }
                    break;
            }
            
                
        }

        #endregion

        #region Onglet Lots de pêche

        private void cbx_peseur_lotspeche_listebateaux_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idLotisWeightModifing = -1;
            idBacisWeightModifing = "";
            String elmt_bateau = cbx_peseur_lotspeche_listebateaux.Text;
            if (elmt_bateau.Trim() == "")
            {
                return;
            }
            HiddenObject.Hide(new List<Control> { btn_peseur_lotspeche_imprimerticketlot, lbl_peseur_lotspeche_info, lbl_peseur_lotspeche_info2, rbtn_peseur_lotspeche_lotnonbloque, rbtn_peseur_lotspeche_lotbloque, lbl_peseur_lotspeche_validation, lbl_peseur_lotspeche_saisirpoids, tbx_peseur_lotspeche_saisirpoids, lbl_peseur_lotspeche_validationok, btn_peseur_lotspeche_validersaisiepoids, dg_peseur_lotspeche_bacs, btn_peseur_lotspeche_saisirpoids, lbl_peseur_lotspeche_bacdulot });
            HiddenObject.Show(new List<Control> { lbl_peseur_lotspeche_lotsbateau });
            int char_bateau = elmt_bateau.IndexOf("(");
            String imma = elmt_bateau.Substring(char_bateau + 1, elmt_bateau.Length - char_bateau - 2);
            CURS cs = new CURS();
            cs.ReqSelectPrepare("SELECT id FROM bateau WHERE immatriculation ='" + imma + "'", new List<object> { imma });
            idbateau = Int32.Parse(cs.champ("id").ToString());
            lbl_peseur_lotspeche_lotsbateau.Text = "Liste de tous les lots du Bateau '" + elmt_bateau.Substring(0, char_bateau) + "' :";
            bool islots = CompleteControl.RemplirDataGridViewByRequest(dg_peseur_lotspeche_lotsbateau, "SELECT bac.idLot as idLot, count(bac.idLot) as nbbac, espece.nom as nomEspece, idTaille, idPresentation, idQualite, SUM(poidsbrutBac) as poidstotal, codeEtat FROM bac INNER JOIN lot ON bac.idDatePeche=lot.idDatePeche AND bac.idBateau=lot.idBateau AND bac.idLot=lot.idLot INNER JOIN espece ON espece.id=lot.idEspece INNER JOIN bateau ON bateau.id=lot.idBateau AND bateau.id=bac.idBateau WHERE bac.idDatePeche=? AND immatriculation=? AND (codeEtat IS NULL OR codeEtat='' OR codeEtat='C') GROUP BY bac.idLot", new string[] { "idLot", "nomEspece", "idTaille", "idQualite", "idPresentation", "nbbac", "poidstotal", "codeEtat" }, new List<object> { Datejour, imma });
            if (islots == true)
            {
                foreach (DataGridViewRow ligne in dg_peseur_lotspeche_lotsbateau.Rows)
                {
                    string numLotLot = ligne.Cells[0].Value.ToString();
                    string numLotBateau = idbateau.ToString();
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
                    ligne.Cells[0].Value = numLotBateau + numLotLot;
                    if (ligne.Cells[7].Value.ToString().Trim() != "")
                    {
                        CompleteControl.griseligne(ligne);
                    }
                }
                lbl_peseur_lotspeche_islots.Hide();
                HiddenObject.Show(new List<Control> { dg_peseur_lotspeche_lotsbateau, lbl_peseur_lotspeche_info2 });
                dg_peseur_lotspeche_lotsbateau.SelectedRows[0].Selected = false;
            }
            else
            {
                HiddenObject.Hide(new List<Control> { dg_peseur_lotspeche_lotsbateau, lbl_peseur_lotspeche_lotsbateau, });
                lbl_peseur_lotspeche_islots.Show();
            }
        }
        private void dg_peseur_lotspeche_lotsbateau_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btn_peseur_lotspeche_imprimerticketlot.Hide();
            dernierclic = e;
            HiddenObject.Hide(new List<Control> { rbtn_peseur_lotspeche_lotnonbloque, rbtn_peseur_lotspeche_lotbloque, lbl_peseur_lotspeche_validation, lbl_peseur_lotspeche_saisirpoids, tbx_peseur_lotspeche_saisirpoids, lbl_peseur_lotspeche_validationok, btn_peseur_lotspeche_validersaisiepoids });
            if (dg_peseur_lotspeche_lotsbateau.SelectedRows.Count == 1)
            {
                DataGridViewRow ligneselectionne = dg_peseur_lotspeche_lotsbateau.SelectedRows[0];
                ligneselect = ligneselectionne;
                idLotisWeightModifing = Int32.Parse(ligneselectionne.Cells[0].Value.ToString().Substring(2, 3));
                CompleteControl.RemplirDataGridViewByRequest(dg_peseur_lotspeche_bacs, "SELECT numBac as idBac, idTypeBac, tare, IF(ISNULL(poidsbrutBac)OR poidsbrutBac='0.00', 'Non saisie', poidsbrutBac) as poidsbrut FROM bac INNER JOIN typebac ON typebac.id=bac.idTypeBac WHERE idDatePeche=? AND idBateau=? AND idLot=? ORDER BY numBac", new string[] { "idBac", "idTypeBac", "tare", "poidsbrut" }, new List<object> { Datejour, idbateau, idLotisWeightModifing });
                HiddenObject.Show(new List<Control> { dg_peseur_lotspeche_bacs, btn_peseur_lotspeche_saisirpoids, lbl_peseur_lotspeche_bacdulot, lbl_peseur_lotspeche_info });
                foreach (DataGridViewRow ligne in dg_peseur_lotspeche_bacs.Rows)
                {
                    string poidsBac = ligne.Cells[3].Value.ToString().ToLower();
                    if (poidsBac == "non saisie" || (int)Double.Parse(poidsBac.Replace('.', ',')) == 0)
                    {
                        return;
                    }
                }
                if (ligneselectionne.Cells[7].Value.ToString().Trim() == "")
                {
                    rbtn_peseur_lotspeche_lotnonbloque.Checked = true;
                }
                else
                {
                    rbtn_peseur_lotspeche_lotbloque.Checked = true;
                    btn_peseur_lotspeche_imprimerticketlot.Show();
                }

                HiddenObject.Show(new List<Control> { rbtn_peseur_lotspeche_lotnonbloque, rbtn_peseur_lotspeche_lotbloque });

            }
        }
        private void btn_peseur_lotspeche_saisirpoids_Click(object sender, EventArgs e)
        {
            lbl_peseur_lotspeche_validationok.Hide();
            if (dg_peseur_lotspeche_bacs.SelectedRows.Count != 1)
            {
                lbl_peseur_lotspeche_validationok.Text = "Veuillez sélectionner un et un seul bac";
                lbl_peseur_lotspeche_validationok.ForeColor = Color.Red;
                lbl_peseur_lotspeche_validationok.Show();
                return;
            }
            string poids = dg_peseur_lotspeche_bacs.SelectedRows[0].Cells[3].Value.ToString();
            if (poids != "Non saisie")
            {
                tbx_peseur_lotspeche_saisirpoids.Text = poids;
            }
            else
            {
                tbx_peseur_lotspeche_saisirpoids.Text = "";
            }
            HiddenObject.Show(new List<Control> { tbx_peseur_lotspeche_saisirpoids, lbl_peseur_lotspeche_saisirpoids, btn_peseur_lotspeche_validersaisiepoids });
            idBacisWeightModifing = dg_peseur_lotspeche_bacs.SelectedRows[0].Cells[0].Value.ToString();
        }
        private void btn_peseur_lotspeche_validersaisiepoids_Click(object sender, EventArgs e)
        {
            CURS cs = new CURS();

            string nouvpoids = "'" + tbx_peseur_lotspeche_saisirpoids.Text + "'";
            if (nouvpoids == "''")
            {
                cs.ReqAdminPrepare("UPDATE bac SET poidsbrutbac=NULL WHERE idDatePeche=? AND idBateau=? AND idLot=? AND numBac=?", new List<object> { Datejour, idbateau, idLotisWeightModifing, idBacisWeightModifing });

            }
            else
            {
                cs.ReqAdminPrepare("UPDATE bac SET poidsbrutbac=? WHERE idDatePeche=? AND idBateau=? AND idLot=? AND numBac=?", new List<object> { tbx_peseur_lotspeche_saisirpoids.Text, Datejour, idbateau, idLotisWeightModifing, idBacisWeightModifing });

            }
            HiddenObject.Hide(new List<Control> { tbx_peseur_lotspeche_saisirpoids, lbl_peseur_lotspeche_saisirpoids, btn_peseur_lotspeche_validersaisiepoids });

            cs.fermer();
            cs = new CURS();
            cs.ReqAdminPrepare("UPDATE lot SET idusermodif=? , datemodif=? WHERE idDatePeche=? AND idLot=? AND idBateau=?", new List<object> { _useractuelle.Id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), Datejour, idLotisWeightModifing, idbateau });
            cs.fermer();
            int index = dg_peseur_lotspeche_lotsbateau.Rows.IndexOf(ligneselect);
            cbx_peseur_lotspeche_listebateaux_SelectionChangeCommitted(sender, e);
            dg_peseur_lotspeche_lotsbateau.Rows[index].Selected = true;
            dg_peseur_lotspeche_lotsbateau_CellEnter(sender, dernierclic);
            lbl_peseur_lotspeche_validationok.Text = "Le bac a bien été modifié";
            lbl_peseur_lotspeche_validationok.ForeColor = Color.Blue;
            lbl_peseur_lotspeche_validationok.Show();
        }
        private void tbx_peseur_lotspeche_saisirpoids_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool result = false;
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back
            & e.KeyChar != '.')
            {
                result = true;
            }
            bool test = tbx_peseur_lotspeche_saisirpoids.Text.Contains('.');
            if (tbx_peseur_lotspeche_saisirpoids.Text.Contains('.') && e.KeyChar == '.')
            {
                result = true;
            }

            e.Handled = result;

        }
        private void rbtn_peseur_lotspeche_ChangedBloqueLot_CheckedChanged(object sender, EventArgs e)
        {
            DataGridViewRow ligneselectionne = dg_peseur_lotspeche_lotsbateau.SelectedRows[0];
            string idbateau = Int32.Parse(ligneselectionne.Cells[0].Value.ToString().Substring(0, 2)).ToString();
            string idlot = Int32.Parse(ligneselectionne.Cells[0].Value.ToString().Substring(2, 3)).ToString();
            CURS cs = new CURS();
            if (rbtn_peseur_lotspeche_lotbloque.Checked)
            {
                cs.ReqAdminPrepare("UPDATE lot SET codeEtat ='C' WHERE idDatePeche =? AND idBateau =? AND idLot =?", new List<object> { Datejour, idbateau, idlot });
                CompleteControl.griseligne(ligneselectionne);
                lbl_peseur_lotspeche_validation.Text = "Le lot sélectionné a bien été bloqué";
                ligneselectionne.Cells[7].Value = "C";
                btn_peseur_lotspeche_imprimerticketlot.Show();
            }
            if (rbtn_peseur_lotspeche_lotnonbloque.Checked)
            {
                cs.ReqAdminPrepare("UPDATE lot SET codeEtat =NULL WHERE idDatePeche =? AND idBateau =? AND idLot =?", new List<object> { Datejour, idbateau, idlot });
                CompleteControl.degriseligne(ligneselectionne);
                lbl_peseur_lotspeche_validation.Text = "Le lot sélectionné a bien été débloqué";
                ligneselectionne.Cells[7].Value = "";
                btn_peseur_lotspeche_imprimerticketlot.Hide();

            }
            cs.fermer();
            cs = new CURS();
            cs.ReqAdminPrepare("UPDATE lot SET idusermodif=? , datemodif=? WHERE idDatePeche=? AND idLot=? AND idBateau=?", new List<object> { _useractuelle.Id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), Datejour, idlot, idbateau });
            cs.fermer();
            lbl_peseur_lotspeche_validation.Show();
        }
        private void btn_peseur_lotspeche_imprimerticketlot_Click(object sender, EventArgs e)
        {
            DataGridViewRow ligneselectionne = dg_peseur_lotspeche_lotsbateau.SelectedRows[0];
            string numeroLot = ligneselectionne.Cells[0].Value.ToString();
            string idbateau = Int32.Parse(ligneselectionne.Cells[0].Value.ToString().Substring(0, 2)).ToString();
            string idlot = Int32.Parse(ligneselectionne.Cells[0].Value.ToString().Substring(2, 3)).ToString();
            CURS cs = new CURS();
            cs.ReqSelectPrepare("SELECT nomScientifique, nomCourt, espece.nom as NomEspece, bateau.nom as NomBateau, idTaille, idPresentation, idQualite FROM lot INNER JOIN espece ON espece.id=lot.idEspece INNER JOIN bateau ON bateau.id=lot.idBateau WHERE idDatePeche=? AND idBateau=? AND lot.idLot=?", new List<object> { Datejour, idbateau, idlot });
            string nomScientifique = cs.champ("nomScientifique").ToString();
            string nomCourt = cs.champ("nomCourt").ToString();
            string nomBateau = cs.champ("NomBateau").ToString();
            string nomEspece = cs.champ("NomEspece").ToString();
            string idTaille = cs.champ("idTaille").ToString();
            string idPresentation = cs.champ("idPresentation").ToString();
            string idQualite = cs.champ("idQualite").ToString();
            int nbbac = Int32.Parse(ligneselectionne.Cells[5].Value.ToString());
            double poidstotalsanstare = Double.Parse(ligneselectionne.Cells[6].Value.ToString());

            cs.fermer();
            cs = new CURS();
            cs.ReqSelect("SELECT id, tare FROM typebac");
            Dictionary<string, string> typebac = new Dictionary<string, string>();
            Dictionary<string, int> typebacnb = new Dictionary<string, int>();
            while (!cs.Fin())
            {
                typebac.Add(cs.champ("id").ToString(), cs.champ("tare").ToString());
                typebacnb.Add(cs.champ("id").ToString(), 0);
                cs.suivant();

            }
            Double taretotal = 0;
            string descriptiftype = "";
            foreach (DataGridViewRow ligne in dg_peseur_lotspeche_bacs.Rows)
            {
                typebacnb[ligne.Cells[1].Value.ToString()]++;
            }
            foreach (string typedebac in typebac.Keys)
            {
                taretotal += Double.Parse(typebac[typedebac]) * ((double)typebacnb[typedebac]);
                descriptiftype += typebacnb[typedebac] + " " + typedebac + ", ";
            }
            descriptiftype = descriptiftype.Substring(0, descriptiftype.Length - 2);
            string Dateticket = DateTime.Now.ToString("dd/MM/yy");
            string Heureticket = DateTime.Now.ToString("HH:mm:ss");

            double poidstotal = poidstotalsanstare + taretotal;

            iTextSharp.text.Font font10b = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES_BOLD, 9);
            iTextSharp.text.Font font50 = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES_BOLD, 50);
            iTextSharp.text.Font font42 = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES_BOLD, 42);
            iTextSharp.text.Font font24 = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES_BOLD, 24);
            iTextSharp.text.Font font18 = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES, 18);
            iTextSharp.text.Font font14 = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES, 14);
            iTextSharp.text.Font font12 = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES, 12);
            iTextSharp.text.Font font10 = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES, 10);
            iTextSharp.text.Font font10i = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES_ITALIC, 10);

            Document nouveauDocument = new Document();
            nouveauDocument.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
            nouveauDocument.SetMargins(0f, 0f, 0f, 0f);
            try
            {
                FileStream filePDF = new FileStream("Ticket Avant-Vente du lot n°" + numeroLot + " du bateau " + nomBateau + " " + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".pdf", FileMode.Create);
                PdfWriter.GetInstance(nouveauDocument, filePDF);
                nouveauDocument.Open();
                nouveauDocument.Add(new Paragraph("\n\n\n\n"));
                iTextSharp.text.pdf.PdfPTable ligne1 = new iTextSharp.text.pdf.PdfPTable(4);
                ligne1.SetTotalWidth(new float[] { 50, 20, 70, 50 });
                PdfPCell cell = new PdfPCell();
                cell.AddElement(new iTextSharp.text.Chunk(" F-29.197.500-CE", font12));
                cell.AddElement(new iTextSharp.text.Chunk(" Audierne", font12));
                cell.BorderWidthRight = 0;
                ligne1.AddCell(cell);
                PdfPCell cell2 = new PdfPCell();
                cell2.AddElement(new iTextSharp.text.Chunk(Dateticket, font12));
                cell2.AddElement(new iTextSharp.text.Chunk(Heureticket, font12));
                cell2.BorderWidthLeft = 0;
                ligne1.AddCell(cell2);
                PdfPCell cell3 = new PdfPCell();
                cell3.AddElement(new iTextSharp.text.Chunk(nomBateau.ToUpper(), font24));
                cell3.BorderWidthRight = 0;
                cell3.PaddingBottom = 15;
                ligne1.AddCell(cell3);
                PdfPCell cell4 = new PdfPCell();
                cell4.AddElement(new iTextSharp.text.Chunk(" PECHE ATLANTIQUE", font12));
                cell4.AddElement(new iTextSharp.text.Chunk(" NORD EST", font12));
                cell4.BorderWidthLeft = 0;
                ligne1.AddCell(cell4);
                nouveauDocument.Add(ligne1);
                iTextSharp.text.pdf.PdfPTable ligne2 = new iTextSharp.text.pdf.PdfPTable(2);
                ligne2.SetTotalWidth(new float[] { 70, 120 });

                iTextSharp.text.pdf.PdfPTable ligne2sous1 = new iTextSharp.text.pdf.PdfPTable(2);
                ligne2sous1.SetTotalWidth(new float[] { 50, 50 });
                PdfPCell ligne2sous1cell1 = new PdfPCell();
                ligne2sous1cell1.Border = 0;
                ligne2sous1cell1.AddElement(new iTextSharp.text.Chunk(" OP : O.P.O.B", font14));
                ligne2sous1cell1.AddElement(new iTextSharp.text.Chunk(" Qu : " + idQualite, font14));
                ligne2sous1cell1.AddElement(new iTextSharp.text.Chunk(" Bacs : " + descriptiftype, font14));
                iTextSharp.text.pdf.PdfPTable ligne2sous1cell1sous1 = new iTextSharp.text.pdf.PdfPTable(2);
                ligne2sous1cell1sous1.SetTotalWidth(new float[] { 50, 50 });
                PdfPCell ligne2sous1cell1sous1cell1 = new PdfPCell();
                ligne2sous1cell1sous1cell1.PaddingLeft = -12;
                ligne2sous1cell1sous1cell1.Border = 0;
                ligne2sous1cell1sous1cell1.PaddingTop = 20;
                ligne2sous1cell1sous1cell1.AddElement(new iTextSharp.text.Chunk(" Nbre : ", font14).setLineHeight(24));
                ligne2sous1cell1sous1.AddCell(ligne2sous1cell1sous1cell1);
                PdfPCell ligne2sous1cell1sous1cell2 = new PdfPCell();
                ligne2sous1cell1sous1cell2.Border = 0;
                ligne2sous1cell1sous1cell2.PaddingTop = 20;
                ligne2sous1cell1sous1cell2.AddElement(new iTextSharp.text.Chunk(" " + nbbac, font24).setLineHeight(24));
                ligne2sous1cell1sous1.AddCell(ligne2sous1cell1sous1cell2);
                ligne2sous1cell1.AddElement(ligne2sous1cell1sous1);
                ligne2sous1cell1.AddElement(new iTextSharp.text.Chunk(" Pal. :", font14));
                ligne2sous1cell1.AddElement(new iTextSharp.text.Chunk(" Brut :", font14));
                ligne2sous1cell1.AddElement(new iTextSharp.text.Chunk(" Tare :", font14));
                ligne2sous1.AddCell(ligne2sous1cell1);
                PdfPCell ligne2sous1cell2 = new PdfPCell();
                ligne2sous1cell2.Border = 0;
                ligne2sous1cell2.AddElement(new iTextSharp.text.Chunk("\n", font14));
                ligne2sous1cell2.AddElement(new iTextSharp.text.Chunk("Pr : " + idPresentation, font14));
                ligne2sous1cell2.AddElement(new iTextSharp.text.Chunk("\n\n", font14));
                iTextSharp.text.pdf.PdfPTable ligne2sous1cell2sous1 = new iTextSharp.text.pdf.PdfPTable(1);
                PdfPCell ligne2sous1cell2sous1cell1 = new PdfPCell();
                ligne2sous1cell2sous1cell1.PaddingLeft = -12;
                ligne2sous1cell2sous1cell1.Border = 0;
                ligne2sous1cell2sous1cell1.PaddingTop = 23;
                ligne2sous1cell2sous1cell1.AddElement(new iTextSharp.text.Chunk("\n", font14));
                ligne2sous1cell2sous1.AddCell(ligne2sous1cell2sous1cell1);
                ligne2sous1cell2.AddElement(ligne2sous1cell2sous1);
                ligne2sous1cell2.AddElement(new iTextSharp.text.Chunk(poidstotal.ToString("F2") + "kg", font14));
                ligne2sous1cell2.AddElement(new iTextSharp.text.Chunk(taretotal.ToString("F2") + "kg", font14));
                ligne2sous1.AddCell(ligne2sous1cell2);

                iTextSharp.text.pdf.PdfPTable ligne2sous2 = new iTextSharp.text.pdf.PdfPTable(2);
                ligne2sous2.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                ligne2sous2.SetTotalWidth(new float[] { 30, 70 });
                PdfPCell ligne2sous2cell1 = new PdfPCell();
                ligne2sous2cell1.Border = 0;
                ligne2sous1cell1.PaddingTop = -150;
                ligne2sous2cell1.AddElement(new iTextSharp.text.Chunk(" Lot :", font14));
                ligne2sous2cell1.AddElement(new iTextSharp.text.Chunk(" " + nomCourt, font24).setLineHeight(50));
                ligne2sous2cell1.AddElement(new iTextSharp.text.Chunk(" " + nomScientifique, font12));
                ligne2sous2cell1.AddElement(new iTextSharp.text.Chunk(" " + nomEspece, font12));
                ligne2sous2.AddCell(ligne2sous2cell1);
                PdfPCell ligne2sous2cell2 = new PdfPCell();
                ligne2sous2cell2.Padding = 0;
                ligne2sous2cell2.Border = 0;
                ligne2sous2cell2.AddElement(new iTextSharp.text.Chunk(numeroLot, font50).setLineHeight(40));
                ligne2sous2cell2.AddElement(new iTextSharp.text.Chunk("   " + idTaille, font24).setLineHeight(32));
                ligne2sous2cell2.AddElement(new iTextSharp.text.Chunk("\n", font24));
                ligne2sous2cell2.AddElement(new iTextSharp.text.Chunk("   " + poidstotalsanstare.ToString("F2") + "kg", font42));
                ligne2sous2.AddCell(ligne2sous2cell2);
                ligne2.AddCell(ligne2sous1);
                ligne2.AddCell(ligne2sous2);
                nouveauDocument.Add(ligne2);
                nouveauDocument.Close();
                MessageBox.Show("Un document PDF contenant les étiquettes du lot a bien été généré : " + filePDF.Name, "Ticket généré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    System.Diagnostics.Process.Start(filePDF.Name);
                }
                catch
                {
                    MessageBox.Show("Impossible d'ouvrir le fichier pdf\nVous pouvez néanmoins ouvrir le fichier manuellement au chemin indiqué dans l'application", "Echec ouverture fichier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (DocumentException de)
            {
                MessageBox.Show("Une erreur a été recontrée lors de la génération du PDF :\n" + de.Message, "Echec génération fichier PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.IO.IOException ioe)
            {
                MessageBox.Show("Une erreur a été recontrée lors de la génération du PDF :\n" + ioe.Message, "Echec génération fichier PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Onglet Mes Données

        private void btn_peseur_mesdonnees_supprimer_Click(object sender, EventArgs e)
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

        private void btn_peseur_mesdonnees_modifier_Click(object sender, EventArgs e)
        {
            HiddenObject.Show(new List<Control> { lbl_peseur_mesdonnees_modification, lbl_peseur_mesdonnees_modifieradrMail, lbl_peseur_mesdonnees_modifierlogin, lbl_peseur_mesdonnees_modifiernom, lbl_peseur_mesdonnees_modifierprenom, tbx_peseur_mesdonnees_login, tbx_peseur_mesdonnees_nom, tbx_peseur_mesdonnees_adrMail, tbx_peseur_mesdonnees_prenom, btn_peseur_mesdonnees_validermodif, lbl_peseur_mesdonnees_champsobli });
            HiddenObject.Hide(new List<Control> { btn_peseur_mesdonnees_validermodifmdp, lbl_peseur_mesdonnees_mdpactuel, tbx_peseur_mesdonnees_mdpactuel, lbl_peseur_mesdonnees_newmdp, tbx_peseur_mesdonnees_newmdp, lbl_peseur_mesdonnees_confirmationnewmdp, tbx_peseur_mesdonnees_confirmationnewmdp, lbl_peseur_mesdonnees_modificationmdp });

            tbx_peseur_mesdonnees_login.Text = _useractuelle.Login;
            if (_useractuelle.Nom.ToString().Trim() == "(Non communiqué)")
            {
                tbx_peseur_mesdonnees_nom.Text = "";
            }
            else
            {
                tbx_peseur_mesdonnees_nom.Text = _useractuelle.Nom.ToString().Trim();
            }
            if (_useractuelle.Prenom.ToString().Trim() == "(Non communiqué)")
            {
                tbx_peseur_mesdonnees_prenom.Text = "";
            }
            else
            {
                tbx_peseur_mesdonnees_prenom.Text = _useractuelle.Prenom.ToString();
            }
            if (_useractuelle.AdrMail.ToString().Trim() == "(Non communiquée)")
            {
                tbx_peseur_mesdonnees_adrMail.Text = "";
            }
            else
            {
                tbx_peseur_mesdonnees_adrMail.Text = _useractuelle.AdrMail.ToString();
            }
            lbl_peseur_mesdonnees_validationmodif.Hide();
        }

        private void btn_peseur_mesdonnees_validermodif_Click(object sender, EventArgs e)
        {
            idUserModified = _useractuelle.Id.ToString();
            if (tbx_peseur_mesdonnees_login.Text == "")
            {
                lbl_peseur_mesdonnees_validationmodiferreur.Text = "Tous les champs obligatoires doivent être remplis";
                lbl_peseur_mesdonnees_validationmodiferreur.Show();
                return;
            }
            if (tbx_peseur_mesdonnees_adrMail.Text.Trim() != "" && !(Regex.IsMatch(tbx_peseur_mesdonnees_adrMail.Text, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")))
            {
                lbl_peseur_mesdonnees_validationmodiferreur.Text = "L’adresse mail saisie n’est pas correcte";
                lbl_peseur_mesdonnees_validationmodiferreur.Show();
                return;
            }

            object adrMail = tbx_peseur_mesdonnees_adrMail.Text;
            if (adrMail.ToString().Trim() == "")
            {
                adrMail = null;
            }
            object nomModif = tbx_peseur_mesdonnees_nom.Text;
            if (nomModif.ToString().Trim() == "")
            {
                nomModif = null;
            }
            object prenomModif = tbx_peseur_mesdonnees_prenom.Text;
            if (prenomModif.ToString().Trim() == "")
            {
                prenomModif = null;
            }

            CURS cs = new CURS();
            cs.ReqAdminPrepare("UPDATE utilisateur SET login=?, nomuser=?, prenomuser=?, adrMail=? WHERE id=?", new List<object> { tbx_peseur_mesdonnees_login.Text, nomModif, prenomModif, adrMail, idUserModified });
            cs.fermer();
            lbl_peseur_mesdonnees_validationmodif.Text = "Vos données ont bien été modifiées.\n";
            HiddenObject.Hide(new List<Control> { lbl_peseur_mesdonnees_modificationmdp, lbl_peseur_mesdonnees_validationmodiferreur, lbl_peseur_mesdonnees_modification, lbl_peseur_mesdonnees_modifieradrMail, lbl_peseur_mesdonnees_modifierlogin, lbl_peseur_mesdonnees_modifiernom, lbl_peseur_mesdonnees_modifierprenom, tbx_peseur_mesdonnees_login, tbx_peseur_mesdonnees_nom, tbx_peseur_mesdonnees_adrMail, tbx_peseur_mesdonnees_prenom, btn_peseur_mesdonnees_validermodif, lbl_peseur_mesdonnees_champsobli });

            _useractuelle.Login = tbx_peseur_mesdonnees_login.Text;
            _useractuelle.Nom = tbx_peseur_mesdonnees_nom.Text.Trim();
            _useractuelle.Prenom = tbx_peseur_mesdonnees_prenom.Text.Trim();
            _useractuelle.AdrMail = tbx_peseur_mesdonnees_adrMail.Text.Trim();

            lbl_peseur_mesdonnees_login.Text = "Login : " + _useractuelle.Login.ToString();
            lbl_peseur_mesdonnees_nom.Text = "Nom : " + _useractuelle.Nom.ToString();
            lbl_peseur_mesdonnees_prenom.Text = "Prénom : " + _useractuelle.Prenom.ToString();
            lbl_peseur_mesdonnees_adrMail.Text = "Adresse Mail : " + _useractuelle.AdrMail.ToString();

            tbc_peseur_Selected(sender, _onglet);
            lbl_peseur_mesdonnees_validationmodif.Show();
        }

        private void btn_peseur_mesdonnees_modifiermdp_Click(object sender, EventArgs e)
        {
            HiddenObject.Hide(new List<Control> { lbl_peseur_mesdonnees_modifieradrMail, lbl_peseur_mesdonnees_modifierlogin, lbl_peseur_mesdonnees_modifiernom, lbl_peseur_mesdonnees_modifierprenom, tbx_peseur_mesdonnees_login, tbx_peseur_mesdonnees_nom, tbx_peseur_mesdonnees_prenom, tbx_peseur_mesdonnees_adrMail, lbl_peseur_mesdonnees_modification, btn_peseur_mesdonnees_validermodif, lbl_peseur_mesdonnees_champsobli, lbl_peseur_mesdonnees_validationmodif, lbl_peseur_mesdonnees_validationmodiferreur });
            HiddenObject.Show(new List<Control> { lbl_peseur_mesdonnees_modificationmdp, lbl_peseur_mesdonnees_mdpactuel, tbx_peseur_mesdonnees_mdpactuel, lbl_peseur_mesdonnees_newmdp, tbx_peseur_mesdonnees_newmdp, lbl_peseur_mesdonnees_confirmationnewmdp, tbx_peseur_mesdonnees_confirmationnewmdp, btn_peseur_mesdonnees_validermodifmdp });
            tbx_peseur_mesdonnees_mdpactuel.Text = "";
            tbx_peseur_mesdonnees_newmdp.Text = "";
            tbx_peseur_mesdonnees_confirmationnewmdp.Text = "";
        }

        private void btn_peseur_mesdonnees_validermodifmdp_Click(object sender, EventArgs e)
        {
            idUserModified = _useractuelle.Id.ToString();
            String passwdhash = new HashData(tbx_peseur_mesdonnees_mdpactuel.Text).HashCalculate();
            if (tbx_peseur_mesdonnees_mdpactuel.Text == "")
            {
                lbl_peseur_mesdonnees_validationmodiferreur.Text = "Tous les champs obligatoires doivent être remplis";
                lbl_peseur_mesdonnees_validationmodiferreur.Show();
                return;
            }
            if (tbx_peseur_mesdonnees_newmdp.Text == "")
            {
                lbl_peseur_mesdonnees_validationmodiferreur.Text = "Tous les champs obligatoires doivent être remplis";
                lbl_peseur_mesdonnees_validationmodiferreur.Show();
                return;
            }
            if (tbx_peseur_mesdonnees_confirmationnewmdp.Text == "")
            {
                lbl_peseur_mesdonnees_validationmodiferreur.Text = "Tous les champs obligatoires doivent être remplis";
                lbl_peseur_mesdonnees_validationmodiferreur.Show();
                return;
            }

            CURS cs = new CURS();
            cs.ReqSelectPrepare("CALL Auth(?,?)", new List<object> { _useractuelle.Login, passwdhash });
            if (cs.champ("nbUser").ToString() == "0")
            {
                lbl_peseur_mesdonnees_validationmodiferreur.Text = "Votre mot de passe actuel est incorrect.";
                lbl_peseur_mesdonnees_validationmodiferreur.Show();
                return;
            }
            cs.fermer();

            if (!(Regex.IsMatch(tbx_peseur_mesdonnees_newmdp.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")))
            {
                lbl_peseur_mesdonnees_validationmodiferreur.Text = "Le mot de passe doit contenir au moins 10 caractères\ncomportant majuscule, minuscules, chiffres et caractères spéciaux";
                lbl_peseur_mesdonnees_validationmodiferreur.Show();
                return;
            }

            if (tbx_peseur_mesdonnees_newmdp.Text != tbx_peseur_mesdonnees_confirmationnewmdp.Text)
            {
                lbl_peseur_mesdonnees_validationmodiferreur.Text = "Les mots de passes ne correspondent pas, veuillez réessayer.";
                lbl_peseur_mesdonnees_validationmodiferreur.Show();
                return;
            }

            string motdepassehash = new HashData(tbx_peseur_mesdonnees_newmdp.Text).HashCalculate();
            CURS csm = new CURS();
            csm.ReqAdminPrepare("UPDATE utilisateur SET pwd=? WHERE id=? ", new List<object> { motdepassehash, idUserModified });
            csm.fermer();
            lbl_peseur_mesdonnees_validationmodif.Text = "Votre mot de passe a bien été modifié.";
            lbl_peseur_mesdonnees_validationmodif.Show();
            HiddenObject.Hide(new List<Control> { lbl_peseur_mesdonnees_modificationmdp, lbl_peseur_mesdonnees_validationmodiferreur, lbl_peseur_mesdonnees_mdpactuel, tbx_peseur_mesdonnees_mdpactuel, lbl_peseur_mesdonnees_newmdp, tbx_peseur_mesdonnees_newmdp, lbl_peseur_mesdonnees_confirmationnewmdp, tbx_peseur_mesdonnees_confirmationnewmdp, btn_peseur_mesdonnees_validermodifmdp });

        }

        #endregion

        #region Fermeture du formulaire

        private void pbx_peseur_deconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AppCriee_Peseur_FormClosing(object sender, FormClosingEventArgs e)
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









        #endregion


    }
}
