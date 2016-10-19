using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Profesor
    {
        private string numeProfesor;
        private List<Disciplina> listaDisciplineDetinute = new List<Disciplina>();

        public string NumeProfesor
        {
            get
            {
                return numeProfesor;
            }
            set
            {
                numeProfesor = value;
            }
        }

        public List<Disciplina> ListaDisciplineDetinute
        {
            get
            {
                return listaDisciplineDetinute;
            }
            set
            {
                listaDisciplineDetinute = value;
            }
        }

        public Profesor(string numeProfesor, List<Disciplina> listaDisciplineDetinute)
        {
            this.numeProfesor = numeProfesor;
            this.listaDisciplineDetinute = listaDisciplineDetinute;
        }

        void adugareNoteExamen(Examen ex)
        {
            //
        }

        void adaugareNoteDistribuita(Distribuita di)
        {
            //
        }
    }
}
