using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCriée
{
    public class User
    {
        private int _id;
        private string _login;
        private string _nom;
        private string _prenom;
        private int _type;
        private string _libelletype;
        private string _adrMail;
        private string _datecreation;
        private string _datemodif;
        public User(int id, string login, string nom, string prenom, int type, string libelletype, string adrMail, string datecreation, string datemodif)
        {
            _id = id;
            _login = login;
            _nom = nom;
            _prenom = prenom;
            _type = type;
            _libelletype = libelletype;
            _adrMail = adrMail;
            _datecreation = datecreation;
            _datemodif = datemodif;
        }

        public int Id { get => _id; set => _id = value; }
        public string Login { get => _login; set => _login = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public int Type { get => _type; set => _type = value; }
        public string Libelletype { get => _libelletype; set => _libelletype = value; }
        public string AdrMail { get => _adrMail; set => _adrMail = value; }
		public string Datecreation { get => _datecreation; set => _datecreation = value; }
		public string Datemodif { get => _datemodif; set => _datemodif = value; }
	}
}
