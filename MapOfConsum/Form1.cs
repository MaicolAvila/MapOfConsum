﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapOfConsum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Map imgC = new Map();
            imgC.mapaBox1.Image = System.Drawing.Image.FromFile(@"..\..\Resources\engativa.png");
            imgC.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Map imgC = new Map();
            imgC.mapaBox1.Image = System.Drawing.Image.FromFile(@"..\..\Resources\chapinero.png");
            imgC.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Map imgC = new Map();
            imgC.mapaBox1.Image = System.Drawing.Image.FromFile(@"..\..\Resources\bosa.png");
            imgC.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Map imgC = new Map();
            imgC.mapaBox1.Image = System.Drawing.Image.FromFile(@"..\..\Resources\usme.png");
            imgC.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Map imgC = new Map();
            imgC.mapaBox1.Image = System.Drawing.Image.FromFile(@"..\..\Resources\usaquen.png");
            imgC.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
