using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Angajat: Persoana
    {
        string functie;

        public string Functie
        {

            get
            {
                return functie;
            }
            set
            {
                functie = value;
            }
        }

         public Angajat(string numeU, string paginaWebU, string numeF, string adresaF, string telefonF, string faxF, string emailF, string paginaWebF, string numeP, string prenumeP, int varstaP, string sexP, string cnpP, string telefonP, string functie)
            : base(numeU, paginaWebU, numeF, adresaF, telefonF, faxF, emailF, paginaWebF, numeP, prenumeP, varstaP, sexP, cnpP, telefonP)
        {
            this.functie = functie;
        }
    }
}
