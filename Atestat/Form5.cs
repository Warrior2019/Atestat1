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
    public partial class F5 : Form
    {
        public F5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sevilla86.LoadFile("Sevilla86.rtf");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sevilla86.LoadFile("Echipa_de_start.rtf");
        }

        private void Sevilla86_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
