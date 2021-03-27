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
            Image image = Image.FromFile("Ion_Voinescu.jpg");
            pb.Image = image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           rtb.LoadFile("Anghel Iordanescu.rtf");
            Image image = Image.FromFile("Anghel_Iordanescu.jpg");
            pb.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtb.LoadFile("Marius Lacatus.rtf");
            Image image = Image.FromFile("Marius_Lacatus.jpg");
            pb.Image = image;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rtb.LoadFile("Gica Hagi.rtf");
            Image image = Image.FromFile("Gica_Hagi.jpg");
            pb.Image = image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
