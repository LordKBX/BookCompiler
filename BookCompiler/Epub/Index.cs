using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookCompiler.Epub
{
    public class Index
    {
        string Title;
        string FontName;
        string BookId;
        string Authors;
        string Lang;
        List<ChapterReference> chapters;

        static readonly string xml = "<?xml version=\\'1.0\\' encoding=\\'utf-8\\'?>" +
            "\r\n\t<package xmlns=\"http://www.idpf.org/2007/opf\" unique-identifier=\"uuid_id\" version=\"2.0\">" +
            "\r\n\t\t<metadata xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:opf=\"http://www.idpf.org/2007/opf\">" +
            "\r\n\t\t\t<dc:title xmlns:dc=\"http://purl.org/dc/elements/1.1/\">{NOVELNAME}</dc:title>" +
            "\r\n\t\t\t<dc:creator xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:ns0=\"http://www.idpf.org/2007/opf\" ns0:role=\"aut\" ns0:file-as=\"{AUTHORS}\">{AUTHORS}</dc:creator>" +
            "\r\n\t\t\t<dc:language xmlns:dc=\"http://purl.org/dc/elements/1.1/\">{LANG}</dc:language>" +
            "\r\n\t\t\t<dc:identifier opf:scheme=\"uuid\" id=\"uuid_id\">{BOOKID}</dc:identifier>" +
            "\r\n\t\t\t<dc:contributor opf:file-as=\"BookCompiler Ebook\" opf:role=\"bkp\">BookCompiler [https://github.com/LordKBX/]</dc:contributor>" +
            "\r\n\t\t</metadata>" +
            "\r\n\t\t<manifest>" +
            "\r\n\t\t\t{MANIFEST}" +
            "\r\n\t\t\t<item href=\"cover.png\" id=\"cover\" media-type=\"image/png\" properties=\"cover-image\"/>" +
            "\r\n\t\t\t<item href=\"common.css\" id=\"commoncss\" media-type=\"text/css\"/>" +
            "\r\n\t\t\t<item href=\"{FONTDIR}/Regular.ttf\" id=\"font1\" media-type=\"application/x-font-truetype\"/>" +
            "\r\n\t\t\t<item href=\"{FONTDIR}/Bold.ttf\" id=\"font2\" media-type=\"application/x-font-truetype\"/>" +
            "\r\n\t\t\t<item href=\"{FONTDIR}/Bold-Italic.ttf\" id=\"font3\" media-type=\"application/x-font-truetype\"/>" +
            "\r\n\t\t\t<item href=\"{FONTDIR}/Italic.ttf\" id=\"font4\" media-type=\"application/x-font-truetype\"/>" +
            "\r\n\t\t</manifest>" +
            "\r\n\t\t<spine toc=\"ncx\">" +
            "\r\n\t\t\t<itemref idref=\"{ID0}\"/>" +
            "\r\n\t\t\t{SPINE}" +
            "\r\n\t\t</spine>" +
            "\r\n\t</package>";

        public Index(string title, List<ChapterReference> chapters, string FontName, string BookId, string Authors, string Lang) {
            this.Title = title;
            this.chapters = chapters;
            this.FontName = FontName;
            this.BookId = BookId;
            this.Authors = Authors;
            this.Lang = Lang;
            string folder = Program.ExeDir + "\\Resources\\Fonts\\" + FontName;
            if (!Directory.Exists(folder)) { this.FontName = "Arial"; }
            else {
                if (!File.Exists(folder + "\\Bold.ttf")) { this.FontName = "Arial"; }
                else if (!File.Exists(folder + "\\Bold-Italic.ttf")) { this.FontName = "Arial"; }
                else if (!File.Exists(folder + "\\Italic.ttf")) { this.FontName = "Arial"; }
                else if (!File.Exists(folder + "\\Regular.ttf")) { this.FontName = "Arial"; }
            }
        }

        public void AddChapter(ChapterReference chapter) { chapters.Add(chapter); }

        public string Generate() {
            string ret = xml;
            
            string manifest = "";
            string spine = "";
            string stringnumlength = "" + chapters.Count;
            uint numlength = uint.Parse(""+stringnumlength.Length);
            string id0 = "";

            for (int i = 0; i< chapters.Count; i++)
            {
                string path = chapters[i].PageObject.ExportPath().Replace(""+Program.TmpDir, "Pages");
                string displaynum = Tools.Num.FormatNumber(i, numlength);
                if (i > 0) { manifest += "\r\n\t\t\t"; spine += "\r\n\t\t\t"; } else { id0 = "file_" + displaynum; }
                manifest += "<item id=\"file_" + displaynum + "\" href=\"" + path + "\" media-type=\"application/xhtml+xml\"/>";
                spine += "<itemref idref=\"file_" + displaynum + "\" />";
            }
            ret = ret.Replace("{NOVELNAME}", Title);
            ret = ret.Replace("{AUTHORS}", Authors);
            ret = ret.Replace("{LANG}", Lang);
            ret = ret.Replace("{BOOKID}", BookId);

            ret = ret.Replace("{MANIFEST}", manifest);
            ret = ret.Replace("{SPINE}", spine);
            ret = ret.Replace("{ID0}", id0);
            ret = ret.Replace("{FONTDIR}", "Fonts/" + FontName);


            return ret;
        }
    }
}
