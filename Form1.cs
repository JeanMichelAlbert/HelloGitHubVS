﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloGitHubVS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void helloButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello GutHub.");
        }

        private void modifierButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
    }
}
