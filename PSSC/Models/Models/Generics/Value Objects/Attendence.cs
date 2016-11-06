using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    public class Attendance
    {
        private int _count;
        public int Count { get; internal set; }

        public Attendance(int count)
        {
            Contract.Requires<ArgumentException>(count >= 0, "attendance can't be negative");

            _count = count;
        }

        #region override object
        public override bool Equals(object obj)
        {
            var attendance = (Attendance)obj;
            return Count == attendance.Count;
        }

        public override int GetHashCode()
        {
            return Count.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}", Count);
        }
        #endregion
    }
}
