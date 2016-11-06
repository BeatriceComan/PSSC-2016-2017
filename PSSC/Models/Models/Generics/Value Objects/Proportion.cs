using System;
using System.Diagnostics.Contracts;
namespace Models.Generics
{
    public class Proportion
    {
        private int _numerator;
        private int _denominator;
        public decimal Fraction { get { return (decimal)_numerator / (decimal)_denominator; } }

        public Proportion(int numerator, int denominator)
        {
            Contract.Requires<ArgumentException>(numerator > 0, "numerator must be > 0");
            Contract.Requires<ArgumentException>(denominator > 0, "denominator must be > 0");
            Contract.Requires<ArgumentException>(denominator > numerator, "not a proper fraction");

            _numerator = numerator;
            _denominator = denominator;
        }

        #region override object
        public override bool Equals(object obj)
        {
            var proportion = (Proportion)obj;
            return proportion._numerator == _numerator && proportion._denominator == _denominator;
        }

        public override int GetHashCode()
        {
            return Fraction.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", _numerator, _denominator);
        }
        #endregion
    }
}
