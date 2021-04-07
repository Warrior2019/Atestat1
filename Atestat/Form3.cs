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
    public partial class F3 : Form
    {
        int cate = 0;
        public F3()
        {
            InitializeComponent();
        }

        private void F3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if ((cb1.Checked && cb3.Checked)) cate++;
            if (rb2.Checked) cate++;
            if (rb7.Checked) cate++;
            if (rb11.Checked) cate++;
            MessageBox.Show("Ai răsapun corect la " + cate.ToString() + " întrebări");
            if (cate == 4) this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            gb1.Visible = true;
            gb2.Visible = true;
            gb3.Visible = true;
            gb4.Visible = true;
            label2.Visible = true;
            label1.Visible = true;
        }
    }
}