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
    public partial class Nav : Form
    {
        public Nav()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet1.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet1.Mahasiswa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Close();
        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
