using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Examen : Disciplina
    {
        private float notaExamen;
        private float notaMarita;
        private float[] noteActivitateParcus;
        private EnumProportieActivitate proportieActivitateParcurs;
        private string[] prezentaLaborator;

        public float NotaMarita
        {
            get
            {
                return notaMarita;
            }
            set
            {
                notaMarita = value;
            }
        }

        public float NotaExamen
        {
            get
            {
                return notaExamen;
            }
            set
            {
                notaExamen = value;
            }
        }

        public float[] NoteActivitateParcus
        {
            get
            {
                return noteActivitateParcus;
            }
            set
            {
                noteActivitateParcus = value;
            }
        }

        public EnumProportieActivitate ProportieActivitateParcurs
        {

            get
            {
                return proportieActivitateParcurs;
            }
            set
            {
                proportieActivitateParcurs = value;
            }
        }

        public string[] PrezentaLaborator
        {
            get
            {
                return prezentaLaborator;
            }
            set
            {
                prezentaLaborator = value;
            }
        }

        public Examen(EnumAnStudiu anStudiu, string numeDisciplina, string numeProfesorTitular, int nrCredite, List<Student> listStudentiInscrisi, float notaExamen, float notaMarita, float[] noteActivitateParcus, EnumProportieActivitate proportieActivitateParcurs, string[] prezentaLaborator)
            : base(anStudiu, numeDisciplina, numeProfesorTitular, nrCredite, listStudentiInscrisi)
        {
            this.notaExamen = notaExamen;
            this.notaMarita = notaMarita;
            this.noteActivitateParcus = noteActivitateParcus;
            this.proportieActivitateParcurs = proportieActivitateParcurs;
            this.prezentaLaborator = prezentaLaborator;
        }
    }
}
