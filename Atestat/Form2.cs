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
            this.Hide();
            F4.ShowDialog();
            this.Show();
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            Form F6 = new F6();
            this.Hide();
            F6.ShowDialog();
            this.Show();
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            Form F5 = new F5();
            this.Hide();
            F5.ShowDialog();
            this.Show();
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            Form F3 = new F3();
            this.Hide();
            F3.ShowDialog();
            this.Show();
        }

        private void Ieșire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
