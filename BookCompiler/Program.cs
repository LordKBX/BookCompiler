using System.Reflection;
using System.Security.Cryptography.Xml;

namespace BookCompiler
{
    internal static class Program
    {
        public static string? ExeDir = null;
        public static string? TmpDir = null;
        public static string? ExportDir = null;

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
                ExportDir = ExeDir + "\\export";
                if(!Directory.Exists(TmpDir)) { Directory.CreateDirectory(TmpDir); }
                if(!Directory.Exists(ExportDir)) { Directory.CreateDirectory(ExportDir); }
            }
            catch(Exception ex) { }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    public class ArbitraryWindow : IWin32Window
    {
        public ArbitraryWindow(IntPtr handle) { Handle = handle; }
        public ArbitraryWindow(int handle) { Handle = (IntPtr)handle; }
        public IntPtr Handle { get; private set; }
    }
}