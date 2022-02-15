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
            return "server = " + (new CryptData(ConfigurationManager.AppSettings["server"])).DecryptData() + "; user id = " + (new CryptData(ConfigurationManager.AppSettings["user id"])).DecryptData() + "; password = " + (new CryptData(ConfigurationManager.AppSettings["password"])).DecryptData() + " ; database = " + (new CryptData(ConfigurationManager.AppSettings["database"])).DecryptData();
        }
        public static string[] ParamSMTP()
        {
            return new string[] { (new CryptData(ConfigurationManager.AppSettings["serveurSMTP"])).DecryptData(), (new CryptData(ConfigurationManager.AppSettings["adrMailFrom"])).DecryptData(), ConfigurationManager.AppSettings["portSMTP"], (new CryptData(ConfigurationManager.AppSettings["passMailFrom"])).DecryptData() };
        }
        public static string AdrMailFrom()
        {
            return (new CryptData(ConfigurationManager.AppSettings["adrMailFrom"])).DecryptData();
        }
    }
}
