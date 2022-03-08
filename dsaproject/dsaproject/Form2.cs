using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dsaproject
{
    public partial class viewDestinationsForm : Form
    {
        public viewDestinationsForm()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewDestinationsForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            showDestInfo(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showDestInfo(6);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            showDestInfo(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showDestInfo(9);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showDestInfo(4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showDestInfo(7);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showDestInfo(1);
        }
        private void showDestInfo(int i)
        {
            DestInfoForm form = new DestInfoForm(i);
            form.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            showDestInfo(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showDestInfo(3);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            showDestInfo(10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            showDestInfo(11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            showDestInfo(12);  
        }
    }
}
