using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum EnumProportieActivitate { treime, jumatate };

    class Distribuita: Disciplina
    {
        private float notaED1;
        private float notaED2;
        private float notaED12;
        private float notaED22;
        private float[] noteActivitateParcus;
        private EnumProportieActivitate proportieActivitateParcurs;
        private string[] prezentaLaborator;

        public float NotaED12
        {
            get
            {
                return notaED12;
            }
            set
            {
                notaED12 = value;
            }
        }

        public float NotaED22
        {
            get
            {
                return notaED22;
            }
            set
            {
                notaED22 = value;
            }
        }

        public float NotaED1
        {
            get
            {
                return notaED1;
            }
            set
            {
                notaED1 = value;
            }
        }

        public float NotaED2
        {
            get
            {
                return notaED2;
            }
            set
            {
                notaED2 = value;
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

           public Distribuita(EnumAnStudiu anStudiu, string numeDisciplina, string numeProfesorTitular, int nrCredite, List<Student> listStudentiInscrisi, float notaED1, float notaED2, float notaED12, float notaED22, float[] noteActivitateParcus, EnumProportieActivitate proportieActivitateParcurs, string[] prezentaLaborator)
            : base(anStudiu, numeDisciplina, numeProfesorTitular, nrCredite, listStudentiInscrisi)
        {
            this.notaED1 = notaED1;
            this.notaED2 = notaED2;
            this.notaED12 = notaED12;
            this.notaED22 = notaED22;
            this.noteActivitateParcus = noteActivitateParcus;
            this.proportieActivitateParcurs = proportieActivitateParcurs;
            this.prezentaLaborator = prezentaLaborator;
        }
    }
}
