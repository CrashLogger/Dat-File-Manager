using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Dat_File_Thing
{
    public partial class DebugForm : Form
    {
        public DebugForm()
        {
            InitializeComponent();

            listBox1.BeginUpdate();
            foreach (string line in VehicleDatForm.linesToWrite)
            {
                listBox1.Items.Add(line);
            }
            listBox1.EndUpdate();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
