
using System.Windows.Forms;

namespace Tools
{
    public static class Program
    {
        public static string? ExeDir = null;
        public static string? TmpDir = null;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                string? codebase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                if (codebase != null)
                {
                    string? reference = System.IO.Path.GetDirectoryName(codebase);
                    if (reference != null) { ExeDir = reference.Replace("file:" + ((Environment.OSVersion.Platform == PlatformID.Win32NT) ? "\\" : "/"), ""); }
                }
                TmpDir = ExeDir + "\\tmp";
                if (!Directory.Exists(TmpDir)) { Directory.CreateDirectory(TmpDir); }
            }
            catch (Exception ex) { }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form());
        }
    }
}