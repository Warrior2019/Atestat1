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
    public partial class F2 : Form
    {
        public F2()
        {
            InitializeComponent();
        }

        private void F2_Load(object sender, EventArgs e)
        {

        }

        private void Istoric_Click(object sender, EventArgs e)
        {
            Form F4 = new F4();
            F4.Show();
            //Istoric_text.LoadFile("Steaua Bucuresti.rtf");
        }

        private void Quiz_Click(object sender, EventArgs e)
        {
            Form F3 = new F3();
            F3.Show();
        }

        private void Sevilla86_Click(object sender, EventArgs e)
        {
            Form F5 = new F5();
            F5.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form F6 = new F6();
            F6.Show();
        }
    }
}
