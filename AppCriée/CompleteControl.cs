using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCriée
{
    public class CompleteControl
    {
        public static bool RemplirCombobox(ComboBox unComboBox, String requete, String champs, Boolean selectdefault = true, Boolean clear = true)
        {
            bool ispeche = false;
            string chaineConnexion = ConnectionChain.chaineConnexion();
            if (clear)
            {
                unComboBox.Items.Clear();
            }
            CURS cs = new CURS(chaineConnexion);
            cs.ReqSelect(requete);
            if (champs.Contains("("))
            {
                string champ1 = champs.Substring(0, champs.IndexOf("("));
                string champ2 = champs.Substring(champs.IndexOf("(") + 1, champs.Length - champs.IndexOf("(") - 2);
                while (!cs.Fin())
                {
                    ispeche = true;
                    unComboBox.Items.Add(cs.champ(champ1) + "(" + cs.champ(champ2) + ")");
                    cs.suivant();
                }
            }
            else
            {
                while (!cs.Fin())
                {
                    ispeche = true;
                    unComboBox.Items.Add(cs.champ(champs));
                    cs.suivant();
                }
            }
            cs.fermer();
            if (selectdefault)
            {
                if (ispeche)
                {
                    unComboBox.SelectedItem = unComboBox.Items[0];
                }
                
            }
            return ispeche;
        }
        public static bool RemplirDataGridViewByRequest(DataGridView unDataGridView, String requete, String[] Params, Boolean clear = true)
        {
            string chaineConnexion = ConnectionChain.chaineConnexion();
            bool islots = false;
            unDataGridView.Rows.Clear();
            CURS cs = new CURS(chaineConnexion);
            cs.ReqSelect(requete);
            Object[] Parametres = new Object[Params.Length];
            while (!cs.Fin())
            {
                int i = 0;
                foreach (String unParams in Params)
                {
                    Parametres[i] = cs.champ(unParams);
                    i++;
                }
                islots = true;
                unDataGridView.Rows.Add(Parametres);
                cs.suivant();

            }
            cs.fermer();
            return islots;
        }
    }
}
