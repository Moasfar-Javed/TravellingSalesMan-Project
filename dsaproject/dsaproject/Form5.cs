using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dsaproject
{
    public partial class facultyloginForm : Form
    {

        public facultyloginForm()
        {
            InitializeComponent();
        }
        private bool signInCheck()
        {
            if (userkeyTxt.Text == "admin" && passwordTxt.Text == "admin")
                return true;
            else
                return false;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void facultyloginForm_Load(object sender, EventArgs e)
        {

        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            if(signInCheck() == true)
            {
                facform frm = new facform();
                frm.ShowDialog();
                this.Dispose();      
            }
            else
            {
                userkeyTxt.Text = ""; passwordTxt.Text = ""; 
                notelabel.Text = "                    Invalid Input";            
                Refresh();
            }
                
        }

        private void userkeyTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
