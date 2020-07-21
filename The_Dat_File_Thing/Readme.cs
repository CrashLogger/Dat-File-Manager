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

namespace The_Dat_File_Thing
{
    public partial class Readme_Form : Form
    {
        public Readme_Form()
        {
            InitializeComponent();
        }

        private void InstallationPathLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
