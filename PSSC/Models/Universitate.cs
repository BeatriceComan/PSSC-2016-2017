using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Universitate
    {
        private string numeU;
        private string paginaWebU;

         public string NumeU
         {
         
             get
             {
                 return numeU;
             }
             set
             {
                 numeU = value;
             }
         }

        public string PaginaWebU
        {
            get
            {
                return paginaWebU;
            }
            set
            {
                paginaWebU = value;
            }
        }

        public Universitate(string numeU, string paginaWebU)
        {
            this.numeU = numeU;
            this.paginaWebU = paginaWebU;
        }
    }
}
