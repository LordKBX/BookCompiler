using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace CoverGenerator
{
    public partial class Cover : Form
    {
        string html = Properties.Resources.jacket;
        Timer timer;
        int count = 0;

        public Cover()
        {
            InitializeComponent();
            if (Program.ImageUrl.Length <= 0)
            {
                Program.ImageUrl = "file:///" + Program.ExeDir.Replace("\\", "/") + "/Resources/DefaultCover.png";
                using (var ms = new MemoryStream())
                {
                    using (var bitmap = new Bitmap(Properties.Resources.DefaultCover))
                    {
                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        Program.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(ms.GetBuffer()); //Get Base64
                    }
                }
            }
            html = html.Replace("{COVER}", Program.ImageUrl);
            html = html.Replace("{novel}", Program.Novel);
            html = html.Replace("{title}", Program.Title);
            html = html.Replace("{author}", Program.Author);

            Debug.WriteLine(html);

            webView.Source = new Uri("file:///" + Program.ExeDir.Replace("\\", "/") + "/Resources/DefaultCover.png");

            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (count == 0) { 
                timer.Stop();
                webView.NavigateToString(html);
                webView.NavigationCompleted += WebView_NavigationCompleted; ;
            }
            else
            {
                timer.Stop();
                //WebView_NavigationCompleted(null, null);
            }
            count += 1;
        }

        private async void WebView_NavigationCompleted(object? sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs? e)
        {
            string tmp = Path.GetTempPath() + Guid.NewGuid().ToString() + ".png";
            using (FileStream file = new FileStream(tmp, FileMode.Create))
            {
                await webView.CoreWebView2.CapturePreviewAsync(Microsoft.Web.WebView2.Core.CoreWebView2CapturePreviewImageFormat.Png, file);
                Console.WriteLine(tmp);
                Debug.WriteLine(tmp);
            }
            webView.Dispose();
            Close();
        }
    }
}