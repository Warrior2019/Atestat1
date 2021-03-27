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
            Sevilla86.Visible = true;
            Sevilla86.LoadFile("Sevilla86.rtf");
            pb_Sevilla86.Visible = false;
        }


        private void Sevilla86_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pb_Sevilla86.Visible = true;
            Image image = Image.FromFile("Echipa_Sevilla86.jpg");
            pb_Sevilla86.Image = image;
            Sevilla86.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
