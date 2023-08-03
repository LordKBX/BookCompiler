using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SharpCompress.IO;
using SharpCompress.Crypto;
using SharpCompress.Compressors;
using SharpCompress.Common;
using SharpCompress.Common.Zip;
using SharpCompress.Common.Zip.Headers;
using SharpCompress.Writers;
using SharpCompress.Writers.Zip;
using SharpCompress.Archives;
using SharpCompress.Archives.Zip;
using SharpCompress.Writers.GZip;

namespace BookCompiler.Epub
{
    public class Epub
    {
        private string BookId;
        private string NovelName;
        private string CoverPath;
        private string FontName;
        private string Authors;
        private string Lang;
        private List<ChapterReference> Chapters;
        private Index index;

        private static string MetaInfoContent = "<?xml version=\"1.0\"?><container version=\"1.0\" xmlns=\"urn:oasis:names:tc:opendocument:xmlns:container\">" +
            "<rootfiles>" +
            "<rootfile full-path=\"{FILEPATH}\" media-type=\"application/oebps-package+xml\"/>" +
            "</rootfiles>" +
            "</container>";

        public Epub(string name, string authors, List<ChapterReference> chapters, string coverPath) {
            BookId = Guid.NewGuid().ToString();
            NovelName = name;
            Chapters = chapters;
            CoverPath = coverPath;
            Authors = authors;
            FontName = "Arial";
            Lang = "en";

            try
            {
                this.index = new Index(NovelName, chapters, FontName, BookId, authors, Lang);
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }
        }

        public void SetBookId(string bookId) { this.BookId = bookId; }

        public bool Compile() {
            try
            {
                string indexFile = index.Save();
                string filePath = Program.ExportDir + "\\" + Tools.File.FormatFileName(NovelName) + ".epub";

                using (var zip = File.OpenWrite(filePath))
                {
                    WriterOptions opt = new WriterOptions(CompressionType.Deflate);
                    using (var zipWriter = WriterFactory.Open(zip, ArchiveType.Zip, CompressionType.Deflate))
                    {
                        string metainfopath = Program.TmpDir + "\\META-INF";
                        File.WriteAllText(metainfopath, MetaInfoContent.Replace("{FILEPATH}", indexFile.Replace(Program.TmpDir+"\\", "")));
                        zipWriter.Write("cover.png", CoverPath);
                        zipWriter.Write("META-INF/container.xml", metainfopath);
                        zipWriter.Write(indexFile.Replace(Program.TmpDir + "\\", ""), indexFile);
                        zipWriter.Write("Fonts/" + FontName + "/Bold.ttf", Program.ExeDir + "\\Resources\\Fonts\\" + FontName + "\\Bold.ttf");
                        zipWriter.Write("Fonts/" + FontName + "/Bold-Italic.ttf", Program.ExeDir + "\\Resources\\Fonts\\" + FontName + "\\Bold-Italic.ttf");
                        zipWriter.Write("Fonts/" + FontName + "/Italic.ttf", Program.ExeDir + "\\Resources\\Fonts\\" + FontName + "\\Italic.ttf");
                        zipWriter.Write("Fonts/" + FontName + "/Regular.ttf", Program.ExeDir + "\\Resources\\Fonts\\" + FontName + "\\Regular.ttf");
                        File.WriteAllText(Program.TmpDir + "\\common.css", File.ReadAllText(Program.ExeDir + "\\Resources\\common.css").Replace("<FONT>", FontName) );
                        zipWriter.Write("common.css", Program.TmpDir + "\\common.css");

                        foreach (ChapterReference file in Chapters)
                        {
                            zipWriter.Write(Path.GetFileName(file.PageObject.ExportPath()), file.PageObject.ExportPath());
                        }
                    }
                }

                return true;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }
            return false;
        }
    }
}
