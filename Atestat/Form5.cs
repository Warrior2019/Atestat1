using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuartzTypeLib;

namespace Atestat
{
    public partial class F5 : Form
    {
        public F5()
        {
            InitializeComponent();
        }

        private const int WS_CHILD = 0x40000000;
        private const int WS_CLIPCHILDREN = 0x2000000;
        private IMediaControl mc=null;
        private IVideoWindow videoWindow = null;
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Sevilla86.Visible = true;
            Sevilla86.LoadFile("Sevilla86.rtf");
            pb_Sevilla86.Visible = false;
            Video.Visible = false;
            Video.Ctlcontrols.stop();
        }
        private void Sevilla86_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            pb_Sevilla86.Visible = true;
            Image image = Image.FromFile("Steaua_Sevilla86.jpg");
            pb_Sevilla86.Image = image;
            Sevilla86.Visible = false;
            Video.Visible = false;
            Video.Ctlcontrols.stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Video.Visible = true;
            Video.URL = "Penalty-uri.mp4";
            Video.Ctlcontrols.play();
        }
    }
}
