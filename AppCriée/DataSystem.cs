using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AppCriée
{
    public class DataSystem
    {
        public static string ConnectionChain()
        {
            return "server = " + ConfigurationManager.AppSettings["server"] + "; user id = " + ConfigurationManager.AppSettings["user id"] + "; password = " + ConfigurationManager.AppSettings["password"] + " ; database = " + ConfigurationManager.AppSettings["database"];
        }
        public static string[] ParamSMTP()
        {
            return new string[] { ConfigurationManager.AppSettings["serveurSMTP"], ConfigurationManager.AppSettings["adrMailFrom"], ConfigurationManager.AppSettings["portSMTP"], ConfigurationManager.AppSettings["passMailFrom"] };
        }
        public static string AdrMailFrom()
        {
            return ConfigurationManager.AppSettings["adrMailFrom"];
        }
    }
}
