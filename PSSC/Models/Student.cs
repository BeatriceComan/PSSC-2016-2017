using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student: Persoana
    {
        string nrMatricol;
        string adresaS;
        int anDeStudiu;
        bool plataS;
        bool bursaS;

        public string NrMatricol
        {

            get
            {
                return nrMatricol;
            }
            set
            {
                nrMatricol = value;
            }
        }

        public string AdresaS
        {
            get
            {
                return adresaS;
            }
            set
            {
                adresaS = value;
            }
        }

        public int AnDeStudiu
        {
            get
            {
                return anDeStudiu;
            }
            set
            {
                anDeStudiu = value;
            }
        }

        public bool PlataS
        {
            get
            {
                return plataS;
            }
            set
            {
                plataS = value;
            }
        }

        public bool BursaS
        {
            get
            {
                return bursaS;
            }
            set
            {
                bursaS = value;
            }
        }

        public Student(string numeU, string paginaWebU, string numeF, string adresaF, string telefonF, string faxF, string emailF, string paginaWebF, string numeP, string prenumeP, int varstaP, string sexP, string cnpP, string telefonP, string nrMatricol, string adresaS, int anDeStudiu, bool plataS, bool bursaS)
            : base(numeU, paginaWebU, numeF, adresaF, telefonF, faxF, emailF, paginaWebF, numeP, prenumeP, varstaP, sexP, cnpP, telefonP)
        {
            this.nrMatricol = nrMatricol;
            this.adresaS = adresaS;
            this.anDeStudiu = anDeStudiu;
            this.plataS = plataS;
            this.bursaS = bursaS;
        }
    }
}
