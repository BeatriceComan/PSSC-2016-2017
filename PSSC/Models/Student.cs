using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student: An
    {
        private string numeStudent;
        private int nrTotalCredite;
        private bool promovat;
        private List<Disciplina> disciplineFrecventate = new List<Disciplina>();

        public string NumeStudent
        {
            get
            {
                return numeStudent;
            }
            set
            {
                numeStudent = value;
            }
        }

        public int NrTotalCredite
        {
            get
            {
                return nrTotalCredite;
            }
            set
            {
                nrTotalCredite = value;
            }
        }

        public bool Promovat
        {
            get
            {
                return promovat;
            }
            set
            {
                promovat = value;
            }
        }

        public List<Disciplina> DisciplineFrecventate
        {
            get
            {
                return disciplineFrecventate;
            }
            set
            {
                disciplineFrecventate = value;
            }
        }

        public Student(EnumAnStudiu anStudiu, string numeStudent, int nrTotalCredite, bool promovat, List<Disciplina> disciplineFrecventate)
            : base(anStudiu)
        {
            this.numeStudent = numeStudent;
            this.nrTotalCredite = nrTotalCredite;
            this.promovat = promovat;
            this.disciplineFrecventate = disciplineFrecventate;
        }
    }
}
