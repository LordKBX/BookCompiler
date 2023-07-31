using System.Diagnostics;
using System.Security.Policy;
using System.Text.RegularExpressions;
using BookCompiler.Epub;
using Newtonsoft.Json;
using Microsoft.Web.WebView2;
using Microsoft.Web.WebView2.Core;
using Tools;

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
                PageParent = "div.entry-content",
                PageExcluded = "p.has-text-align-center",
                PageProtected = false
            },
        };

        List<ChapterReference> chaptersList = new List<ChapterReference>();
        int chapterIndex = int.MaxValue;

        public Form1()
        {
            InitializeComponent();

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

                    SetPageParent(pr.PageParent);
                    SetPageExcluded(pr.PageExcluded);
                    SetPageProtected(pr.PageProtected);
                }
            }
        }

        private void PaintroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(SystemColors.Control);
            Pen pen = new Pen(Brushes.Black);
            Pen pen2 = new Pen(Brushes.White);
            p.Graphics.FillRectangle(Brushes.White, 0, 0, box.Width, box.Height);
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

            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 20, 0);
        }

        #region Top menu
        private void réglagesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void themesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private string GenerateCover(string title, string author = "")
        {
            Process fileopener = new Process();
            string exepath = Program.ExeDir.Replace("BookCompiler\\BookCompiler", "BookCompiler\\CoverGenerator") + "\\CoverGenerator.exe";
            try { exepath = File.ReadAllText(Program.ExeDir + "\\CoverGeneratorPath.txt").Replace("\r", "").Replace("\n", "").Trim(); }
            catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }

            fileopener.StartInfo.FileName = exepath;
            fileopener.StartInfo.Arguments = "\"Novel=" + title + "\"" + ((author.Trim().Length > 0) ? " \"Author=" + author.Trim() + "\"" : "");
            fileopener.StartInfo.UseShellExecute = false;
            fileopener.StartInfo.RedirectStandardOutput = true;
            fileopener.Start();
            fileopener.WaitForExit();
            string output = fileopener.StandardOutput.ReadToEnd();
            Debug.WriteLine("Cover Path => " + output);
            fileopener = null;
            return output;
        }

        private async void PreviewButton_Click(object sender, EventArgs e)
        {
            try
            {
                OutputTextBox.Text = "";
                string parent = IndexParentTextBox.Text;
                string child = IndexObjectTextBox.Text;
                string title = await webView.ExecuteScriptAsync("document.querySelector(\"" + IndexTitleTextBox.Text + "\").innerHTML;");
                title = title.Replace("\"", "");
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
                                Debug.WriteLine(JsonConvert.SerializeObject(match.Groups, Formatting.Indented, new JsonSerializerSettings
                                {
                                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                                }));
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
                    string coverPath = GenerateCover(title);
                    chapterIndex = 0;
                    webView.CoreWebView2.Navigate(chaptersList[chapterIndex].Url);
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
                if (chapterIndex < chaptersList.Count)
                {
                    if (PageCloudFlareProtectedComboBox.SelectedIndex != 0) //Protected
                    {
                        if (Dialog.ShowDialog(this, "Please push the OK button when page finaly loaded", "Wait", DialogButton.OK, DialogIcon.Warning) == DialogReturn.OK) { }
                    }
                    await webView.ExecuteScriptAsync("document.querySelectorAll(\"" + PageExcludedTextBox.Text.Trim() + "\").forEach(a => { a.parentNode.removeChild(a); });");
                    string html = await webView.ExecuteScriptAsync("document.querySelector(\"" + PageParentTextBox.Text + "\").innerHTML;");
                    chaptersList[chapterIndex].PageObject = new Page(html, chaptersList[chapterIndex].Name, chapterIndex);
                    chaptersList[chapterIndex].PageObject.Export();

                    chapterIndex += 1;
                    if (chapterIndex >= chaptersList.Count)
                    {
                        chapterIndex = int.MaxValue;
                        FinalizeBook();
                        Dialog.ShowDialog(this, "¨Scrapping ended !", "Info", DialogButton.OK, DialogIcon.Info);
                    }
                    else { webView.CoreWebView2.Navigate(chaptersList[chapterIndex].Url); }
                }
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); Debug.WriteLine(ex.StackTrace); }
        }

        private void FinalizeBook() {
            
        }
    }

    public class ChapterReference
    {
        public string Name { get; set; } = "";
        public string Url { get; set; } = "";
        public Page PageObject { get; set; } = null;
    }
}