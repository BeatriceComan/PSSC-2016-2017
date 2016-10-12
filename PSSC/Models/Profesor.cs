using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Profesor: Persoana
    {
        string titluP;
        string emailP;
        string paginaWebP;

        public string TitluP
        {

            get
            {
                return titluP;
            }
            set
            {
                titluP = value;
            }
        }

        public string EmailP
        {
            get
            {
                return emailP;
            }
            set
            {
                emailP = value;
            }
        }

        public string PaginaWebP
        {
            get
            {
                return paginaWebP;
            }
            set
            {
                paginaWebP = value;
            }
        }

        public Profesor(string numeU, string paginaWebU, string numeF, string adresaF, string telefonF, string faxF, string emailF, string paginaWebF, string numeP, string prenumeP, int varstaP, string sexP, string cnpP, string telefonP, string titluP, string emailP, string paginaWebP)
            : base(numeU, paginaWebU, numeF, adresaF, telefonF, faxF, emailF, paginaWebF, numeP, prenumeP, varstaP, sexP, cnpP, telefonP)
        {
            this.titluP = titluP;
            this.emailP = emailP;
            this.paginaWebP = paginaWebP;
        }
    }
}
