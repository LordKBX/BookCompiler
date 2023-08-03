using System.Diagnostics;
using System.Security.Policy;
using System.Text.RegularExpressions;
using BookCompiler.Epub;
using Newtonsoft.Json;
using Microsoft.Web.WebView2;
using Microsoft.Web.WebView2.Core;
using Tools;
using SharpCompress.Writers.Zip;
using File = System.IO.File;

namespace BookCompiler
{
    public partial class Form1 : Form
    {
        List<Preset> presets = new List<Preset>() {
            new Preset(){ Name="" },
            new Preset(){
                Name="systemtranslation.com",
                IndexTitle = "h1.entry-title",
                IndexParent = "div.eplisterfull ul",
                IndexObject = "li",
                IndexObjectRegex = "<a href=\"([A-Za-z0-9\\-_\\|\\&\\^\\:\\/\\.]{1,800})\">[ \n\r\t]{1,20}<div class=\"epl\\-num\">(.*)<\\/div>[ \n\r\t]{1,20}<div class=\"epl\\-title\">(.*)<\\/div>[ \n\r\t]{1,20}<div",
                IndexTemplateLink = "$1",
                IndexTemplateName = "$2 $3",
                IndexOrderDescendent = true,
                IndexImageObject = "div.bigcover img",

                PageParent = "div.entry-content",
                //PageExcluded = "p.has-text-align-center",
                PageExcluded = "p.has-text-align-center, div.entry-content div",
                PageProtected = false
            },
        };

        static readonly string defaultTheme = "clear";
        string lastTheme = "clear";
        Theme? currentTheme;

        List<ChapterReference> chaptersList = new List<ChapterReference>();
        int chapterIndex = int.MaxValue;
        string BookTitle = "";
        string coverPath = "";

        public Form1()
        {
            InitializeComponent();
            LoadTheme(lastTheme);
            if (lastTheme == defaultTheme) { clearToolStripMenuItem.Checked = true; blackToolStripMenuItem.Checked = false; }
            else { clearToolStripMenuItem.Checked = false; blackToolStripMenuItem.Checked = true; }

            IndexPresetComboBox.Items.AddRange(presets.ToArray());
            IndexPresetComboBox.SelectedIndex = 0;
            IndexPresetComboBox.SelectedIndexChanged += IndexPresetComboBox_SelectedIndexChanged;

            UrlBox.Text = "https://systemtranslation.com/series/fairy-tail-collapsing-stars/";
            SetUrl(UrlBox.Text);

            webView.NavigationCompleted += WebView_NavigationCompleted;
        }

        private void IndexPresetComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (IndexPresetComboBox.SelectedIndex >= 0)
            {
                if (IndexPresetComboBox.SelectedItem.GetType().Name == "Preset")
                {
                    Preset pr = (Preset)IndexPresetComboBox.SelectedItem;

                    SetIndexTitle(pr.IndexTitle);
                    SetIndexParent(pr.IndexParent);
                    SetIndexObject(pr.IndexObject);
                    SetIndexRegexpParsingObject(pr.IndexObjectRegex);
                    SetIndexTemplateLinkObject(pr.IndexTemplateLink);
                    SetIndexTemplateNameObject(pr.IndexTemplateName);
                    SetIndexOrder(pr.IndexOrderDescendent);
                    SetIndexImage(pr.IndexImageObject);

                    SetPageParent(pr.PageParent);
                    SetPageExcluded(pr.PageExcluded);
                    SetPageProtected(pr.PageProtected);
                }
            }
        }

        private void PaintroupBox(object sender, PaintEventArgs p)
        {
            Brush back = Brushes.White;
            Brush fore = Brushes.Black;
            Brush border = Brushes.Black;
            if (currentTheme != null)
            {
                back = new SolidBrush(currentTheme.BackgroundColor);
                fore = new SolidBrush(currentTheme.ForegroundColor);
                border = new SolidBrush(currentTheme.BorderColor);
            }


            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(SystemColors.Control);
            Pen pen = new Pen(border);
            p.Graphics.FillRectangle(back, 0, 0, box.Width, box.Height);
            p.Graphics.DrawLine(pen,
                0, 11,
                0, box.Height - 5);
            p.Graphics.DrawLine(pen,
                box.Width - 5, 11,
                box.Width - 5, box.Height - 5);
            p.Graphics.DrawLine(pen,
                0, box.Height - 5,
                box.Width - 5, box.Height - 5);

            p.Graphics.DrawLine(pen,
                0, 11,
                15, 11);

            Size proposedSize = new Size(int.MaxValue, int.MaxValue);
            Size size = TextRenderer.MeasureText(p.Graphics, box.Text, box.Font, proposedSize, TextFormatFlags.NoPadding);

            float length = size.Width + 15;
            p.Graphics.DrawLine(pen,
                (16 + length), 11, box.Width - 5, 11);

            p.Graphics.DrawString(box.Text, box.Font, fore, 20, 0);
        }

        private void LoadTheme(string themeName)
        {
            Theme? theme = Themes.getTheme(themeName);
            if (theme == null) { theme = Themes.getTheme(defaultTheme); }
            if (theme == null) { return; }

            currentTheme = theme;

            this.BackColor = theme.BackgroundColor;
            this.ForeColor = theme.ForegroundColor;
            splitContainer1.BackColor = theme.BorderColor;
            splitContainer1.Panel1.BackColor = theme.BackgroundColor;
            splitContainer1.Panel2.BackColor = theme.BackgroundColor;

            webView.BackColor = theme.BackgroundColor;
            UrlButton.BackColor = theme.ButtonBackgroundColor;
            UrlButton.ForeColor = theme.ButtonForegroundColor;
            UrlBox.BackColor = theme.InputBackgroundColor;
            UrlBox.ForeColor = theme.InputForegroundColor;

            IndexPresetLabel.ForeColor = theme.ForegroundColor;
            IndexTitleLabel.ForeColor = theme.ForegroundColor;
            IndexParentLabel.ForeColor = theme.ForegroundColor;
            IndexObjectLabel.ForeColor = theme.ForegroundColor;
            IndexParsingObjectLabel.ForeColor = theme.ForegroundColor;
            IndexTemplateLinkObjectLabel.ForeColor = theme.ForegroundColor;
            IndexTemplateNameObjectLabel.ForeColor = theme.ForegroundColor;
            IndexParsingOrderLabel.ForeColor = theme.ForegroundColor;
            IndexImageLabel.ForeColor = theme.ForegroundColor;
            PageParentLabel.ForeColor = theme.ForegroundColor;
            PageExcludedLabel.ForeColor = theme.ForegroundColor;
            PageCloudFlareProtectedLabel.ForeColor = theme.ForegroundColor;

            IndexTitleTextBox.BackColor = theme.InputBackgroundColor;
            IndexParentTextBox.BackColor = theme.InputBackgroundColor;
            IndexObjectTextBox.BackColor = theme.InputBackgroundColor;
            IndexParsingObjectTextBox.BackColor = theme.InputBackgroundColor;
            IndexTemplateLinkObjectTextBox.BackColor = theme.InputBackgroundColor;
            IndexTemplateNameObjectTextBox.BackColor = theme.InputBackgroundColor;
            IndexImageTextBox.BackColor = theme.InputBackgroundColor;
            PageParentTextBox.BackColor = theme.InputBackgroundColor;
            PageExcludedTextBox.BackColor = theme.InputBackgroundColor;
            OutputTextBox.BackColor = theme.InputBackgroundColor;

            IndexTitleTextBox.ForeColor = theme.InputForegroundColor;
            IndexParentTextBox.ForeColor = theme.InputForegroundColor;
            IndexObjectTextBox.ForeColor = theme.InputForegroundColor;
            IndexParsingObjectTextBox.ForeColor = theme.InputForegroundColor;
            IndexTemplateLinkObjectTextBox.ForeColor = theme.InputForegroundColor;
            IndexTemplateNameObjectTextBox.ForeColor = theme.InputForegroundColor;
            IndexImageTextBox.ForeColor = theme.InputForegroundColor;
            PageParentTextBox.ForeColor = theme.InputForegroundColor;
            PageExcludedTextBox.ForeColor = theme.InputForegroundColor;
            OutputTextBox.ForeColor = theme.InputForegroundColor;

            IndexParsingOrderComboBox.BackColor = theme.ButtonBackgroundColor;
            IndexPresetComboBox.BackColor = theme.ButtonBackgroundColor;
            PageCloudFlareProtectedComboBox.BackColor = theme.ButtonBackgroundColor;

            IndexParsingOrderComboBox.ForeColor = theme.ButtonForegroundColor;
            IndexPresetComboBox.ForeColor = theme.ButtonForegroundColor;
            PageCloudFlareProtectedComboBox.ForeColor = theme.ButtonForegroundColor;

            PreviewButton.BackColor = theme.ButtonBackgroundColor;
            PreviewButton.ForeColor = theme.ButtonForegroundColor;

            ProcessButton.BackColor = theme.ButtonBackgroundColor;
            ProcessButton.ForeColor = theme.ButtonForegroundColor;
        }

        #region Top menu
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastTheme = "clear";
            clearToolStripMenuItem.Checked = true;
            blackToolStripMenuItem.Checked = false;
            LoadTheme(lastTheme);
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastTheme = "black";
            clearToolStripMenuItem.Checked = false;
            blackToolStripMenuItem.Checked = true;
            LoadTheme(lastTheme);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About(this);
            ab.ShowDialog();
        }
        #endregion

        private void SetUrl(string url) { try { webView.Source = new Uri(url); } catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); } }

        #region Fonction set data
        private void SetIndexTitle(string reference)
        {
            try { IndexTitleTextBox.Text = reference; }
            catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }
        }

        private void SetIndexParent(string reference)
        {
            try { IndexParentTextBox.Text = reference; }
            catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }
        }

        private void SetIndexObject(string reference)
        {
            try { IndexObjectTextBox.Text = reference; }
            catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }
        }

        private void SetIndexRegexpParsingObject(string reference)
        {
            try { IndexParsingObjectTextBox.Text = reference; }
            catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }
        }

        private void SetIndexTemplateLinkObject(string reference)
        {
            try { IndexTemplateLinkObjectTextBox.Text = reference; }
            catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }
        }

        private void SetIndexTemplateNameObject(string reference)
        {
            try { IndexTemplateNameObjectTextBox.Text = reference; }
            catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }
        }

        private void SetIndexOrder(bool descendent)
        {
            try { IndexParsingOrderComboBox.SelectedIndex = (descendent) ? 1 : 0; }
            catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }
        }

        private void SetIndexImage(string descendent)
        {
            try { IndexImageTextBox.Text = descendent; }
            catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }
        }
        #endregion
        #region Set page parsing data
        private void SetPageParent(string reference)
        {
            try { PageParentTextBox.Text = reference; }
            catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }
        }

        private void SetPageExcluded(string reference)
        {
            try { PageExcludedTextBox.Text = reference; }
            catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }
        }

        private void SetPageProtected(bool IsProtected)
        {
            try { PageCloudFlareProtectedComboBox.SelectedIndex = (IsProtected) ? 1 : 0; }
            catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }
        }
        #endregion
        #region Events Url box
        private void UrlBox_KeyUp(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) { UrlButton_Click(null, null); } }

        private void UrlButton_Click(object? sender, EventArgs? e)
        {
            SetUrl(UrlBox.Text);
        }
        #endregion

        private string GenerateCover(string title, string author = "", string imageUrl = "")
        {
            Process fileopener = new Process();
            string exepath = Program.ExeDir.Replace("BookCompiler\\BookCompiler", "BookCompiler\\CoverGenerator") + "\\CoverGenerator.exe";
            try { exepath = File.ReadAllText(Program.ExeDir + "\\CoverGeneratorPath.txt").Replace("\r", "").Replace("\n", "").Trim(); }
            catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }

            fileopener.StartInfo.FileName = exepath;
            fileopener.StartInfo.Arguments = "\"Novel=" + title + "\"" + ((author.Trim().Length > 0) ? " \"Author=" + author.Trim() + "\"" : "") + ((imageUrl.Trim().Length > 0) ? " \"Image=" + imageUrl.Trim() + "\"" : "");
            fileopener.StartInfo.UseShellExecute = false;
            fileopener.StartInfo.RedirectStandardOutput = true;
            fileopener.Start();
            fileopener.WaitForExit();
            string output = fileopener.StandardOutput.ReadToEnd().Replace("\r", "").Replace("\n", "").Trim();
            Debug.WriteLine("Cover Path => " + output);
            fileopener = null;
            return output;
        }

        private async void PreviewButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string file in Directory.GetFiles(Program.TmpDir, "*", new EnumerationOptions() { MaxRecursionDepth = 5, RecurseSubdirectories = true, ReturnSpecialDirectories = false })) { File.Delete(file); }
                coverPath = "";
                OutputTextBox.Text = "";
                string parent = IndexParentTextBox.Text;
                string child = IndexObjectTextBox.Text;
                string title = await webView.ExecuteScriptAsync("document.querySelector(\"" + IndexTitleTextBox.Text + "\").innerHTML;");
                BookTitle = title = title.Replace("\"", "");
                Debug.WriteLine(title);
                string html = await webView.ExecuteScriptAsync("var list = []; document.querySelector(\"" + parent + "\").querySelectorAll(\"" + child + "\").forEach(a => list.push(a.innerHTML)); list;");
                OutputTextBox.Text = html;

                chaptersList.Clear();

                List<string>? strings = JsonConvert.DeserializeObject<List<string>>(html);
                if (strings != null)
                {
                    try
                    {
                        Regex regex = new Regex(IndexParsingObjectTextBox.Text);
                        foreach (string line in strings)
                        {
                            Match match = regex.Match(line);
                            if (match.Success)
                            {
                                string name = IndexTemplateNameObjectTextBox.Text;
                                string link = IndexTemplateLinkObjectTextBox.Text;
                                for (int i = 0; i < match.Groups.Count; i++)
                                {
                                    name = name.Replace("$" + i, match.Groups[i].Value);
                                    link = link.Replace("$" + i, match.Groups[i].Value);
                                }
                                if (IndexParsingOrderComboBox.SelectedIndex == 1) { chaptersList.Insert(0, new ChapterReference() { Name = name, Url = link }); }
                                else { chaptersList.Add(new ChapterReference() { Name = name, Url = link }); }
                            }
                        }
                        Debug.WriteLine(OutputTextBox.Text = JsonConvert.SerializeObject(chaptersList));
                    }
                    catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }
                }

                if (chaptersList.Count > 0)
                {
                    string ob = IndexImageTextBox.Text;
                    string pathcover = "";
                    if (ob.Trim().Length > 0)
                    {
                        pathcover = await webView.ExecuteScriptAsync("var ob = document.querySelector(\"" + ob + "\"); var rez = (ob.tagName == \"IMG\")?ob.src:(''); rez;");
                        pathcover = pathcover.Replace("\r", "").Replace("\n", "").Replace("\t", "").Trim();
                    }
                    coverPath = GenerateCover(title, "", pathcover);
                    string endfilecover = Program.TmpDir + "\\cover.png";
                    if (File.Exists(endfilecover)) { File.Delete(endfilecover); }
                    File.Copy(coverPath, endfilecover);
                    chapterIndex = 0;
                    //Application.Exit();
                    webView.CoreWebView2.Navigate(chaptersList[chapterIndex].Url);
                    this.UseWaitCursor = true;
                }
            }
            catch (Exception er)
            {
                Debug.WriteLine(er.Message); Debug.WriteLine(er.StackTrace);
            }

        }

        private async void WebView_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            try
            {
                string stl = "" + chaptersList.Count;
                uint maxnblength = uint.Parse("" + stl.Length);
                if (chapterIndex < chaptersList.Count)
                {
                    if (PageCloudFlareProtectedComboBox.SelectedIndex != 0) //Protected
                    {
                        if (Dialog.ShowDialog(this, "Please push the OK button when page finaly loaded", "Wait", DialogButton.OK, DialogIcon.Warning) == DialogReturn.OK) { }
                    }
                    await webView.ExecuteScriptAsync("document.querySelectorAll(\"" + PageExcludedTextBox.Text.Trim() + "\").forEach(a => { a.parentNode.removeChild(a); });");
                    Thread.Sleep(300);
                    string html = await webView.ExecuteScriptAsync("document.querySelector(\"" + PageParentTextBox.Text + "\").innerHTML;");
                    chaptersList[chapterIndex].PageObject = new Page(Regex.Unescape(html).Trim('"'), chaptersList[chapterIndex].Name, chapterIndex + 1, maxnblength);
                    chaptersList[chapterIndex].PageObject.Export();

                    chapterIndex += 1;
                    if (chapterIndex >= chaptersList.Count)
                    {
                        this.UseWaitCursor = false;
                        chapterIndex = int.MaxValue;
                        FinalizeBook();
                    }
                    else { webView.CoreWebView2.Navigate(chaptersList[chapterIndex].Url); }
                }
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }
        }

        private void FinalizeBook()
        {
            try
            {
                string stl = "" + chaptersList.Count;
                uint maxnblength = uint.Parse("" + stl.Length);
                chaptersList.Insert(0, new ChapterReference() { Name = "Index", Url = "", PageObject = new Page("<img src=\"cover.png\" style=\"margin: 0 auto; max-width : calc(100vw - 10px);\" />", "Index", 0, maxnblength) });
                chaptersList[0].PageObject.Export();
                Epub.Epub book = new Epub.Epub(BookTitle, "", chaptersList, coverPath);
                book.Compile();
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }
            Dialog.ShowDialog(this, "¨Scrapping ended !", "Info", DialogButton.OK, DialogIcon.Info);
        }

        private async void ProcessButton_Click(object sender, EventArgs e)
        {
            chaptersList.Clear();

            coverPath = Program.TmpDir + "\\cover.png";
            string parent = IndexParentTextBox.Text;
            string child = IndexObjectTextBox.Text;
            string title = await webView.ExecuteScriptAsync("document.querySelector(\"" + IndexTitleTextBox.Text + "\").innerHTML;");
            BookTitle = title = title.Replace("\"", "");
            Debug.WriteLine(title);
            string html = await webView.ExecuteScriptAsync("var list = []; document.querySelector(\"" + parent + "\").querySelectorAll(\"" + child + "\").forEach(a => list.push(a.innerHTML)); list;");
            OutputTextBox.Text = html;

            List<string>? strings = JsonConvert.DeserializeObject<List<string>>(html);
            if (strings != null)
            {
                try
                {
                    Regex regex = new Regex(IndexParsingObjectTextBox.Text);
                    int cpt = 1;
                    foreach (string line in strings)
                    {
                        Match match = regex.Match(line);
                        if (match.Success)
                        {
                            string name = IndexTemplateNameObjectTextBox.Text;
                            string link = IndexTemplateLinkObjectTextBox.Text;
                            for (int i = 0; i < match.Groups.Count; i++)
                            {
                                name = name.Replace("$" + i, match.Groups[i].Value);
                                link = link.Replace("$" + i, match.Groups[i].Value);
                            }

                            if (IndexParsingOrderComboBox.SelectedIndex == 1) { chaptersList.Insert(0, new ChapterReference() { Name = name, Url = link }); }
                            else { chaptersList.Add(new ChapterReference() { Name = name, Url = link }); }
                            cpt += 1;
                        }
                    }

                    string stl = "" + chaptersList.Count;
                    uint maxnblength = uint.Parse("" + stl.Length);
                    //uint maxnblength = 4;

                    cpt = 1;
                    int j = 0;
                    //, PageObject = new Page(File.ReadAllText())
                    int end = -1;
                    for (j = 0; j < chaptersList.Count; j++)
                    {
                        try
                        {
                            string filepath = Program.TmpDir + "\\Page" + Tools.Num.FormatNumber(cpt + j, maxnblength) + ".xhtml";
                            if (File.Exists(filepath))
                            {
                                string pageContent = File.ReadAllText(filepath);
                                chaptersList[j].PageObject = new Page(pageContent, chaptersList[j].Name, j + 1, maxnblength);
                            }
                            else
                            {
                                end = j;
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace);
                            end = j;
                            break;
                        }
                    }
                    if (end > -1) { chaptersList.RemoveRange(end + 1, chaptersList.Count - end - 1); }
                    Debug.WriteLine(OutputTextBox.Text = JsonConvert.SerializeObject(chaptersList));
                }
                catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }
            }

            FinalizeBook();

        }
    }

    public class ChapterReference
    {
        public string Name { get; set; } = "";
        public string Url { get; set; } = "";
        public Page PageObject { get; set; } = null;
    }
}