using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class Num
    {
        public static string FormatNumber(int number, uint minSize = 4)
        {
            uint num = 0;
            if (number < 0) { num = uint.Parse("" + (number * -1)); }
            else { num = uint.Parse("" + number); }
            string ret = "" + num;
            while (ret.Length < minSize) { ret = "0" + ret; }
            if (number < 0) { ret = "-" + ret; }
            return ret;
        }
    }
}
