﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIAODIEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label2_Click_1(object sender, EventArgs e)
        {

        }

       
        

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.ShowDialog();
            this.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.ShowDialog();
            this.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FormQLTuyenXe frm4 = new FormQLTuyenXe();
            this.Hide();
            frm4.ShowDialog();
            this.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            FormChuyenXecs frmcx = new FormChuyenXecs();
            this.Hide();
            frmcx.ShowDialog();
            this.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            FormQLNHAXE frm = new FormQLNHAXE();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}

