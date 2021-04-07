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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form F4 = new F4();
            F4.Show();
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            Form F6 = new F6();
            F6.Show();
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            Form F5 = new F5();
            F5.Show();
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            Form F3 = new F3();
            F3.Show();
        }

        private void Ieșire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
