using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Professor
{
    //Entity 
    public class Professor
    {
        public PlainText Name { get; internal set; }

        public Professor(PlainText name)
        {
            Name = name;
        }

        #region override object
        public override string ToString()
        {
            return Name.ToString();
        }

        public override bool Equals(object obj)
        {
            var professor = (Professor)obj;

            if (professor != null)
            {
                return Name.Equals(professor.Name);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        #endregion
    }
}
