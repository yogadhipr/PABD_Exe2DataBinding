﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Grid().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Nav().Show();
            this.Hide();
        }
    }
}
