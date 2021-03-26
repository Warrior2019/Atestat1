using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat
{
    public partial class F6 : Form
    {
        public F6()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rtb.LoadFile("Ion Voinescu.rtf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           rtb.LoadFile("Anghel Iordanescu.rtf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtb.LoadFile("Marius Lacatus.rtf");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rtb.LoadFile("Gica Hagi.rtf");
        }
    }
}
