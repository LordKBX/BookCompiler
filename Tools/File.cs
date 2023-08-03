using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tools
{
    public static class File
    {
        private static List<char> ForbidensChars = new List<char>() { '<', '>', ':', '"', '/', '\\', '|', '?', '*' };

        public static string FormatFileName(string name) {
            string ret = name;
            ret = Regex.Replace(ret, @"[^\u0020-\u007E]+", "-");
            ret = ret.Replace(" ", "_");
            foreach (char c in ForbidensChars) { 
                ret = ret.Replace(c, '-');
            }
            return ret;
        }
    }
}
