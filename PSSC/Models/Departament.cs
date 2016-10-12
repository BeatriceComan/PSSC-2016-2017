using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Departament : Facultate
    {
        string numeD;

        public string NumeD
        {

            get
            {
                return numeD;
            }
            set
            {
                numeD = value;
            }
        }

        public Departament(string numeU, string paginaWebU, string numeF, string adresaF, string telefonF, string faxF, string emailF, string paginaWebF, string numeD)
            : base(numeU, paginaWebU, numeF, adresaF, telefonF, faxF, emailF, paginaWebF)
        {
            this.numeD = numeD;
        }
    }
}