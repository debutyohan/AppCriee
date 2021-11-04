using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCriée
{
    public class CompleteControl
    {

        public static bool RemplirCombobox(ComboBox unComboBox, String requete, String champs, Boolean selectdefault = true, Boolean clear = true)
        {
            List<String> valuefield = new List<String>();
            foreach (Match field in Regex.Matches(champs, @"#(?<=\#)(.*?)(?=\#)|[a-zA-Z]+"))
            {
                if (field.Value.Substring(0, 1) != "#")
                {
                    valuefield.Add(field.Value);
                }
            }
            bool ispeche = false;
            if (clear)
            {
                unComboBox.Items.Clear();
            }
            CURS cs = new CURS();
            cs.ReqSelect(requete);
            while (!cs.Fin())
            {
                String champtemp = champs;
                ispeche = true;
                champtemp = champtemp.Replace("#","");
                foreach(String unfield in valuefield)
                {
                    champtemp = champtemp.Replace(unfield, cs.champ(unfield).ToString());
                }
                String champfinale = champtemp;
                unComboBox.Items.Add(champfinale);
                cs.suivant();
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
        public static bool RemplirCombobox(ComboBox unComboBox, String requete, String champs, List<object> parameters, Boolean selectdefault = true, Boolean clear = true)
        {
            List<String> valuefield = new List<String>();
            foreach (Match field in Regex.Matches(champs, @"#(?<=\#)(.*?)(?=\#)|[a-zA-Z]+"))
            {
                if (field.Value.Substring(0, 1) != "#")
                {
                    valuefield.Add(field.Value);
                }
            }
            bool ispeche = false;
            if (clear)
            {
                unComboBox.Items.Clear();
            }
            CURS cs = new CURS();
            cs.ReqSelectPrepare(requete, parameters);
            while (!cs.Fin())
            {
                String champtemp = champs;
                ispeche = true;
                champtemp = champtemp.Replace("#", "");
                foreach (String unfield in valuefield)
                {
                    champtemp = champtemp.Replace(unfield, cs.champ(unfield).ToString());
                }
                String champfinale = champtemp;
                unComboBox.Items.Add(champfinale);
                cs.suivant();
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
        public static bool RemplirDataGridViewByRequest(DataGridView unDataGridView, string requete, String[] Params, Boolean clear = true)
        {
            bool islots = false;
            unDataGridView.Rows.Clear();
            CURS cs = new CURS();
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
        public static bool RemplirDataGridViewByRequest(DataGridView unDataGridView, String requete, String[] Params, List<object> parameters, Boolean clear = true)
        {
            bool islots = false;
            unDataGridView.Rows.Clear();
            CURS cs = new CURS();
            cs.ReqSelectPrepare(requete, parameters);
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
        public static void griseligne(DataGridViewRow line)
        {
            foreach(DataGridViewCell cellule in line.Cells)
            {
                cellule.Style.BackColor = Color.Gray;
            }
        }

        public static void degriseligne(DataGridViewRow line)
        {
            foreach (DataGridViewCell cellule in line.Cells)
            {
                cellule.Style.BackColor = Color.White;
            }
        }
        public static bool SendMail(string adrMailTo,string objet, string contenu, out Exception iferror)
        {
            bool result;
            string[] paramSMTP = DataSystem.ParamSMTP();
            string serveurSMTP = paramSMTP[0];
            string adrMailFrom = paramSMTP[1];
            int portSMTP = Int32.Parse(paramSMTP[2]);
            string passAdrMail = paramSMTP[3];
            iferror = new Exception();
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(serveurSMTP);

                mail.From = new MailAddress(adrMailFrom);
                mail.To.Add(adrMailTo);
                mail.Subject = objet;
                mail.Body = contenu;
                SmtpServer.Port = portSMTP;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(adrMailFrom, passAdrMail);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
                iferror = ex;
            }
            return result;
        }
    }
}
