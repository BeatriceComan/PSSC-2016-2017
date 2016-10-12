using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Facultate : Universitate
    {
        private string numeF;
        private string adresaF;
        private string telefonF;
        private string faxF;
        private string emailF;
        private string paginaWebF;
        
        public string NumeF
        {

            get
            {
                return numeF;
            }
            set
            {
                numeF = value;
            }
        }

        public string AdresaF
        {
            get
            {
                return adresaF;
            }
            set
            {
                adresaF = value;
            }
        }

        public string TelefonF
        {
            get
            {
                return telefonF;
            }
            set
            {
                telefonF = value;
            }
        }

        public string FaxF
        {
            get
            {
                return faxF;
            }
            set
            {
                faxF = value;
            }
        }

        public string EmailF
        {
            get
            {
                return emailF;
            }
            set
            {
                emailF = value;
            }
        }

        public string PaginaWebF
        {
            get
            {
                return paginaWebF;
            }
            set
            {
                paginaWebF = value;
            }
        }

        public Facultate(string numeU, string paginaWebU, string numeF, string adresaF, string telefonF, string faxF, string emailF, string paginaWebF)
            : base(numeU, paginaWebU)
        {
            this.numeF = numeF;
            this.adresaF = adresaF;
            this.telefonF = telefonF;
            this.faxF = faxF;
            this.emailF = emailF;
            this.paginaWebF = paginaWebF;
        }
    }
}
