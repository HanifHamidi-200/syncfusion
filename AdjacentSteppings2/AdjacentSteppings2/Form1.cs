﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdjacentSteppings2
{
    public partial class Form1 : Form
    {
        private void btnOpen1_Click(object sender, EventArgs e)
        {
            fSub1 _dlg = new fSub1();
            _dlg.ShowDialog();
        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            fSub2 _dlg = new fSub2();
            _dlg.ShowDialog();

        }

        private void btnOpen3_Click(object sender, EventArgs e)
        {
            fSub3 _dlg = new fSub3();
            _dlg.ShowDialog();

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
     
    }
}
