using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCriée
{
    public class BacNotLot
    {
        private string _nomEspece;
        private int _idTaille;
        private char _idQualite;
        private string _idPresentation;
        private int _idBateau;
        private char _idTypeBac;
        public BacNotLot(string nomEspece, int idTaille, char idQualite, string idPresentation, int idBateau, char idTypeBac)
        {
            _nomEspece = nomEspece;
            _idTaille = idTaille;
            _idQualite = idQualite;
            _idPresentation = idPresentation;
            _idBateau = idBateau;
            _idTypeBac = idTypeBac;
        }

        public int IdTaille { get => _idTaille; set => _idTaille = value; }
        public char IdQualite { get => _idQualite; set => _idQualite = value; }
        public string IdPresentation { get => _idPresentation; set => _idPresentation = value; }
        public int IdBateau { get => _idBateau; set => _idBateau = value; }
        public string NomEspece { get => _nomEspece; set => _nomEspece = value; }
        public char IdTypeBac { get => _idTypeBac; set => _idTypeBac = value; }
    }
}