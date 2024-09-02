using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi_2_linq
{
    internal class customcomperer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return (x.ToLower().CompareTo(y.ToLower()));
        }
    }
}