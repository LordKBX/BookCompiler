using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCompiler
{
    public partial class About : Form
    {
        public About(Form1 parent)
        {
            Owner = parent;
            InitializeComponent();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(typeof(About).Assembly.Location);
            VersionLabel.Text = "  Version: " + versionInfo.FileVersion;
            textBox1.Text = Properties.Resources.LICENSE;
        }
    }
}
