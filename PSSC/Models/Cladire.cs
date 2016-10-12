using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Cladire: Facultate
    {
        string numeC;
        string locatieC;
        string nrEtajeC;

        public string NumeC
        {

            get
            {
                return numeC;
            }
            set
            {
                numeC = value;
            }
        }

        public string LocatieC
        {
            get
            {
                return locatieC;
            }
            set
            {
                locatieC = value;
            }
        }

        public string NrEtajeC
        {
            get
            {
                return nrEtajeC;
            }
            set
            {
                nrEtajeC = value;
            }
        }

        public Cladire(string numeU, string paginaWebU, string numeF, string adresaF, string telefonF, string faxF, string emailF, string paginaWebF, string numeC, string locatieC, string nrEtajeC)
            : base(numeU, paginaWebU, numeF, adresaF, telefonF, faxF, emailF, paginaWebF)
        {
            this.numeC = numeC;
            this.locatieC = locatieC;
            this.nrEtajeC = nrEtajeC;
        }
    }
}
