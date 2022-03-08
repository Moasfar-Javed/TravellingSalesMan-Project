using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace dsaproject
{
    
    public partial class bookaticketForm : Form
    {
        public bookaticketForm()
        {
            InitializeComponent();
            notelabel.Hide();
            bookBtn.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bookaticketForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {

        }
        private bool bookingAuth()
        {
            if (nameAuth(firstNameTxt) == true && nameAuth(lastNameTxt) == true && phoneAuth(phoneNoTxt) == true && emailTxt.Text != "" && touristComboBox.SelectedItem != null)
                return true;
            else
            {
                notelabel.Show();
                Refresh();
                return false;
            }

        }
        private bool nameAuth(TextBox t)
        {
            if (t.Text != "")
            {
                if (Regex.IsMatch(t.Text, @"^[a-zA-Z]+$"))
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        private bool phoneAuth(TextBox p)
        {

            if (p.Text != "")
            {
                if (Regex.IsMatch(p.Text, @"^[0-9]+$"))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bookingAuth() == true)
            {
                bool[] dest = { c1.Checked, c2.Checked, c3.Checked, c4.Checked, c5.Checked, c6.Checked, c7.Checked, c8.Checked, c9.Checked, c10.Checked, c11.Checked, c12.Checked };
                bool[] addons = { mealsCheck.Checked, photoCheck.Checked, souvenirsCheck.Checked };
                string tourists = touristComboBox.SelectedItem.ToString();

                Worker wk = new Worker(dest, addons, tourists, firstNameTxt.ToString(), lastNameTxt.ToString(), phoneNoTxt.ToString(), emailTxt.ToString());
                
                totalLbl.Text = wk.grandTotal().ToString();                  
                notelabel.Hide();
                bookBtn.Enabled = true;
                this.Refresh();
            }
        }
        private void clearAll()
        {
            firstNameTxt.Text = "";
            lastNameTxt.Text = "";
            emailTxt.Text = "";
            phoneNoTxt.Text = "";
            c1.Checked = false;
            c2.Checked = false;
            c3.Checked = false;
            c4.Checked = false;
            c5.Checked = false;
            c6.Checked = false;
            c7.Checked = false;
            c8.Checked = false;
            c9.Checked = false;
            c10.Checked = false;
            c11.Checked = false;
            c12.Checked = false;
            mealsCheck.Checked = false;
            photoCheck.Checked = false;
            souvenirsCheck.Checked = false;
            touristComboBox.SelectedItem = null;
            totalLbl.Text = "0.00";
            bookBtn.Enabled = false;
            this.Refresh();
        }
        private void bookBtn_Click(object sender, EventArgs e)
        {
            bool[] dest = { c1.Checked, c2.Checked, c3.Checked, c4.Checked, c5.Checked, c6.Checked, c7.Checked, c8.Checked, c9.Checked, c10.Checked, c11.Checked, c12.Checked };
            bool[] addons = { mealsCheck.Checked, photoCheck.Checked, souvenirsCheck.Checked };
            string tourists = touristComboBox.SelectedItem.ToString();
            Worker wk = new Worker(dest, addons, tourists, firstNameTxt.Text.ToUpper(), lastNameTxt.Text.ToUpper(), phoneNoTxt.Text, emailTxt.Text.ToUpper());
            double totalBill = wk.grandTotal();
            if (wk.generateBill(totalBill) == true && wk.addSql(firstNameTxt.Text.ToLower(), lastNameTxt.Text.ToLower(), phoneNoTxt.Text, emailTxt.Text.ToLower(), dest, addons, tourists, totalBill) == true)
            {                
                MessageBox.Show("TICKET BOOKED!\nBill generated and saved to desktop.\nBring a printed copy with you\nTiming: 0900\nLocation: Jumeirah Hotel Lobby");
            }     
            else
                MessageBox.Show("An error occured!\nPlease try again later");
            clearAll();
        }

        private void touristComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void phoneNoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
