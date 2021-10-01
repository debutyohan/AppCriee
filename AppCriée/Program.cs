using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCriée
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CURS cs = new CURS("server = 127.0.0.1; user id = gestionCrie; password = 123xaro08 ; database = bddCrie2");
            if (cs.isConnectionOK())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new AppCriee());
            }
        }
    }
}
