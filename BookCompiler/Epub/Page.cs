using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BookCompiler.Epub
{
    public class Page
    {
        private string html = "";
        private int number = 0;
        private uint numberMinSize = 4;

        public Page(string content, string title, int number, uint numberMinSize = 4)
        {
            this.number = number;
            this.numberMinSize = numberMinSize;
            html = "<html xmlns=\"http://www.w3.org/1999/xhtml\">" +
                "\n<head>" +
                    "\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"/>" +
                    "\n<title>" + title + "</title>" +
                    "\n<link href=\"common.css\" rel=\"stylesheet\" type=\"text/css\"/>" +
                "\n</head>" +
                "\n<body>" +
                    "\n<section>" +
                        "\n<h1>" + title + "</h1>" +
                        "\n<div>" + content + "</div>" +
                    "\n</section>" +
                "\n</body>" +
                "\n</html>";
            this.numberMinSize = numberMinSize;
        }

        public override string ToString() { return html; }

        public string ExportPath() { return Program.TmpDir + "\\" + Tools.Num.FormatNumber(number, numberMinSize) + ".xhtml"; }

        public string Export() {
            string file = ExportPath();
            File.WriteAllText(file, html);
            return file;
        }

        
    }
}
