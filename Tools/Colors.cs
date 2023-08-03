using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    [ComVisible(true)]
    public static class Colors
    {
        public static Font GlobalFont { get; } = new Font("Yu Gothic", 14, FontStyle.Regular, GraphicsUnit.Point);
        public static Color White { get; } = Color.White;
        public static Color Black { get; } = Color.Black;
    }
}
