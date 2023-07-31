namespace CoverGenerator
{
    internal static class Program
    {
        public static string? ExeDir = null;
        public static string ImageUrl = "";
        public static string Novel = "";
        public static string Title = "";
        public static string Author = "";

        private static readonly string ArgHeadImage = "image=";
        private static readonly string ArgHeadNovel = "novel=";
        private static readonly string ArgHeadTitle = "title=";
        private static readonly string ArgHeadAuthor = "author=";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                string? reference = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
                if (reference != null) { ExeDir = reference.Replace("file:" + ((Environment.OSVersion.Platform == PlatformID.Win32NT) ? "\\" : "/"), ""); }
            }
            catch (Exception ex) { }
            foreach (string arg in args) {
                try
                {
                    string rarg = arg.Trim();
                    if (rarg.StartsWith("\"") && rarg.EndsWith("\"")) { rarg = rarg.Substring(1, rarg.Length - 1); }
                    string low = rarg.ToLower();
                    if (low.StartsWith(ArgHeadImage)) { ImageUrl = rarg.Substring(ArgHeadImage.Length).Trim(); }
                    else if (low.StartsWith(ArgHeadNovel)) { Novel = rarg.Substring(ArgHeadNovel.Length).Trim(); }
                    else if (low.StartsWith(ArgHeadTitle)) { Title = rarg.Substring(ArgHeadTitle.Length).Trim(); }
                    else if (low.StartsWith(ArgHeadAuthor)) { Author = rarg.Substring(ArgHeadAuthor.Length).Trim(); }
                }
                catch (Exception ex) { }
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Cover());
        }
    }
}