using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace AppCriée
{
    public class CURS
    {
        Boolean fin;
        MySqlConnection maconnexion;
        MySqlCommand macommand;
        MySqlDataReader monreader;
        Boolean _ConnectionOK = true;

        public CURS()
        {
            try
            {
                maconnexion = new MySqlConnection(ConnectionChain.chaineConnexion());
                maconnexion.Open();
                monreader = null;
            }
            catch (Exception exception)
            {
                DialogResult dialogResult = MessageBox.Show("Impossible de se connecter au serveur MySQL \nDescription de l'erreur :" + exception.Message, "Erreur Connexion MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ConnectionOK = false;
                Application.ExitThread();
            }
        }
        public CURS(string connec)
        {
            try
            {
                maconnexion = new MySqlConnection(connec);
                maconnexion.Open();
                monreader = null;
            }
            catch(Exception exception)
            {
                DialogResult dialogResult = MessageBox.Show("Impossible de se connecter au serveur MySQL \nDescription de l'erreur :"+exception.Message, "Erreur Connexion MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ConnectionOK = false;
                Application.ExitThread();
            }

        }
        public MySqlConnection getMaconnexion()
        {
            return maconnexion;
        }
        public void ReqSelect(string req)
        {
                macommand = new MySqlCommand(req, maconnexion);
                monreader = macommand.ExecuteReader();
                fin = false;
                suivant();
        }
        public void ReqSelectPrepare(string req, List<object> parameters)
        {
            macommand = new MySqlCommand(req, maconnexion);
            int rang = 0;
            foreach (object param in parameters)
            {
                macommand.Parameters.Add(new MySqlParameter("value"+rang, param));
                rang++;
            }
            monreader = macommand.ExecuteReader();
            suivant();
        }
        public void fermer()
        {
            if (monreader != null)
                monreader.Close();
            maconnexion.Close();
        }
        public void suivant()
        {
            Boolean flag;

            if (!fin)
            {
                flag = monreader.Read();
                if (flag == true)
                    fin = false;
                else
                    fin = true;

            }



        }
        public void ReqAdmin(string req)
        {

            macommand = new MySqlCommand(req, maconnexion);
            macommand.ExecuteNonQuery();

        }
        public void ReqAdminPrepare(string req, List<object> parameters)
        {

            macommand = new MySqlCommand(req, maconnexion);
            int rang = 0;
            foreach (object param in parameters)
            {
                macommand.Parameters.Add(new MySqlParameter("value" + rang, param));
                rang++;
            }
            macommand.ExecuteNonQuery();

        }
        public object champ(string nomChamp)
        {
             if (!fin)
            return monreader[nomChamp];
              else
            return null;
        }
        public Boolean Fin()
        {
            return fin;
        }
        public string Compter(string req)
        {
            macommand = new MySqlCommand(req, maconnexion);
            return macommand.ExecuteScalar().ToString();
        }
        public bool isConnectionOK()
        {
            return _ConnectionOK;
        }
    }
}
