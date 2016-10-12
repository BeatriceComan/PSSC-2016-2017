using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Sala: Cladire
    {
        string numeSa;
        string nrLocuriSa;

        public string NumeSa
        {

            get
            {
                return numeSa;
            }
            set
            {
                numeSa = value;
            }
        }

        public string NrLocuriSa
        {
            get
            {
                return nrLocuriSa;
            }
            set
            {
                nrLocuriSa = value;
            }
        }

        public Sala(string numeU, string paginaWebU, string numeF, string adresaF, string telefonF, string faxF, string emailF, string paginaWebF, string numeC, string locatieC, string nrEtajeC, string numeSa, string nrLocuriSa)
            : base(numeU, paginaWebU, numeF, adresaF, telefonF, faxF, emailF, paginaWebF, numeC, locatieC, nrEtajeC)
        {
            this.numeSa = numeSa;
            this.nrLocuriSa = nrLocuriSa;
        }
    }
}
