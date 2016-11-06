using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generics.Exceptions;

namespace Models.Generics
{
    //Value object for registration number of a student
    public class RegistrationNumber
    {
        private string _number;
        public string Number { get { return _number; } }

        public RegistrationNumber(string number)
        {
            Contract.Requires<ArgumentNullException>(number != null, "registration number can't be null");
            Contract.Requires<ArgumentCannotBeEmptyStringException>(!string.IsNullOrEmpty(number), "registration number can't be null or empty");
            Contract.Requires<ArgumentException>(number.Length == 7, "Registration number has exactly 7 characters.");

            _number = number;
        }

        #region override object
        public override bool Equals(object obj)
        {
            var registration = (RegistrationNumber)obj;
            return Number.Equals(registration.Number);
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }

        public override string ToString()
        {
            return Number;
        }
        #endregion
    }
}
