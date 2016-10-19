using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Disciplina : An
    {
        private string numeDisciplina;
        private string numeProfesorTitular;
        private int nrCredite;
        private List<Student> listStudentiInscrisi = new List<Student>();

        public string NumeDisciplina
        {

            get
            {
                return numeDisciplina;
            }
            set
            {
                numeDisciplina = value;
            }
        }

        public string NumeProfesorTitular
        {
            get
            {
                return numeProfesorTitular;
            }
            set
            {
                numeProfesorTitular = value;
            }
        }

        public int NrCredite
        {

            get
            {
                return nrCredite;
            }
            set
            {
                nrCredite = value;
            }
        }

        public List<Student> ListStudentiInscrisi
        {
            get
            {
                return listStudentiInscrisi;
            }
            set
            {
                listStudentiInscrisi = value;
            }
        }

        public Disciplina(EnumAnStudiu anStudiu, string numeDisciplina, string numeProfesorTitular, int nrCredite, List<Student> listStudentiInscrisi)
            : base(anStudiu)
        {
            this.numeDisciplina = numeDisciplina;
            this.numeProfesorTitular = numeProfesorTitular;
            this.nrCredite = nrCredite;
            this.listStudentiInscrisi = listStudentiInscrisi;
        }
    }
}
