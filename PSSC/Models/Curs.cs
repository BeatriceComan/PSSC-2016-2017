using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Curs: Facultate
    {
        string titluC;
        string titularC;
        string tipEvaluare;
        int durata; //saptamani

        public string TitluC
        {

            get
            {
                return titluC;
            }
            set
            {
                titluC = value;
            }
        }

        public string TitularC
        {
            get
            {
                return titularC;
            }
            set
            {
                titularC = value;
            }
        }

        public string TipEvaluare
        {

            get
            {
                return tipEvaluare;
            }
            set
            {
                tipEvaluare = value;
            }
        }

        public int Durata
        {
            get
            {
                return durata;
            }
            set
            {
                durata = value;
            }
        }

        public Curs(string numeU, string paginaWebU, string numeF, string adresaF, string telefonF, string faxF, string emailF, string paginaWebF, string titluC, string titularC, string tipEvaluare, int durata)
            : base(numeU, paginaWebU, numeF, adresaF, telefonF, faxF, emailF, paginaWebF)
        {
            this.titluC = titluC;
            this.titularC = titularC;
            this.tipEvaluare = tipEvaluare;
            this.durata = durata;
        }
    }
}
