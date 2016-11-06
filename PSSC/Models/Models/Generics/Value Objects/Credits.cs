using System;
using System.Diagnostics.Contracts;
using Models.Generics.Exceptions;

namespace Models.Generics
{
    //Value object for credits count
    public class Credits
    {
        private int _number;
        public int Number { get { return _number; } }

        public Credits(int number)
        {
            Contract.Requires<InvalidCreditsValue>(number >= 0, "credit must be >= 0");
            Contract.Requires<InvalidCreditsValue>(number <= 60, "credit must be <= 60");

            _number = number;
        }

        #region override object
        public override bool Equals(object obj)
        {
            var credits = (Credits)obj;
            return Number == credits.Number;
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}", Number);
        }
        #endregion
    }
}
