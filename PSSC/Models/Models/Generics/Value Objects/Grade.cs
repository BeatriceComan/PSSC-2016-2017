using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    //Value object for grade value
    public class Grade
    {
        private decimal _value;
        public decimal Value { get { return _value; } }

        public Grade(decimal value)
        {
            Contract.Requires<ArgumentException>(value > 0, "grade must be > 0");
            Contract.Requires<ArgumentException>(value <= 10, "grade must be >= 10");

            _value = value;
        }

        #region override object
        public override bool Equals(object obj)
        {
            var grade = (Grade)obj;
            return Value == grade.Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}", Value);
        }
        #endregion
    }
}
