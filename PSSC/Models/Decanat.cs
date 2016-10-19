using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Decanat: An
    {
        private List<Disciplina> listaDisciplineActivate = new List<Disciplina>();

        public List<Disciplina> ListaDisciplineActivate
        {

            get
            {
                return listaDisciplineActivate;
            }
            set
            {
                listaDisciplineActivate = value;
            }
        }

        public Decanat(EnumAnStudiu anStudiu, List<Disciplina> listaDisciplineActivate)
            :base(anStudiu)
        {
            this.listaDisciplineActivate = listaDisciplineActivate;
        }

        public void stabilireProfesor(Disciplina d)
        {
            //setare numeProfesorTitular
        }

        public void stabilireStudentiLaDisciplina(Student s, Disciplina d)
        {
            //adaugare in lista listStudentiInscrisi
        }
    }
}
