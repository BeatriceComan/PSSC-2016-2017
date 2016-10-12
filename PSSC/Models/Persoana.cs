using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Persoana : Facultate
    {
        string numeP;
        string prenumeP;
        int varstaP;
        string sexP;
        string cnpP;
        string telefonP;

        public string NumeP
        {

            get
            {
                return numeP;
            }
            set
            {
                numeP = value;
            }
        }

        public string PrenumeP
        {
            get
            {
                return prenumeP;
            }
            set
            {
                prenumeP = value;
            }
        }

        public int VarstaP
        {
            get
            {
                return varstaP;
            }
            set
            {
                varstaP = value;
            }
        }

        public string SexP
        {
            get
            {
                return sexP;
            }
            set
            {
                sexP = value;
            }
        }

        public string CnpP
        {
            get
            {
                return cnpP;
            }
            set
            {
                cnpP = value;
            }
        }

        public string TelefonP
        {
            get
            {
                return telefonP;
            }
            set
            {
                telefonP = value;
            }

        }

        public Persoana(string numeU, string paginaWebU, string numeF, string adresaF, string telefonF, string faxF, string emailF, string paginaWebF, string numeP, string prenumeP, int varstaP, string sexP, string cnpP,  string telefonP)
            : base(numeU, paginaWebU, numeF, adresaF, telefonF, faxF, emailF, paginaWebF)
        {
            this.numeP = numeP;
            this.prenumeP = prenumeP;
            this.varstaP = varstaP;
            this.sexP = sexP;
            this.cnpP = cnpP;
            this.telefonP = telefonP;
        }
    }
}


         
