﻿using System;
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
    public partial class Incepe : Form
    {
        public Incepe()
        {
            InitializeComponent();
        }
        private void Incepe_Load(object sender, EventArgs e)
        {

        }

        private void Inceput_Click(object sender, EventArgs e)
        {
            Form F2 = new F2();
            F2.Show();
        }

    }
}
