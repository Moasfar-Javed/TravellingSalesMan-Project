using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dsaproject
{
    public partial class facform2 : Form
    {
        Panel p;
        string[] data;
        public facform2(Panel panel, string[] data)
        {
            p = panel;
            this.data = data;
            InitializeComponent();
            SetFields();
        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(touristIDTxt.Text);
            bool[] dest = { c1.Checked, c2.Checked, c3.Checked, c4.Checked, c5.Checked, c6.Checked, c7.Checked, c8.Checked, c9.Checked, c10.Checked, c11.Checked, c12.Checked };
            bool[] addons = { mealsCheck.Checked, photoCheck.Checked, souvenirsCheck.Checked };
            string tourists = touristComboBox.SelectedItem.ToString();
            Worker wk = new Worker(dest, addons, tourists, firstNameTxt.Text.ToUpper(), lastNameTxt.Text.ToUpper(), phoneNoTxt.Text, emailTxt.Text.ToUpper());
            double total = wk.grandTotal();
            bool status;
            if (string.Equals(statusComboBox.SelectedItem.ToString(), "Completed", StringComparison.OrdinalIgnoreCase)) status = true;
            else status = false;

            if (wk.updateSql(id, firstNameTxt.Text.ToLower(), lastNameTxt.Text.ToLower(), phoneNoTxt.Text, emailTxt.Text.ToLower(), dest, addons, tourists, total, status) == true && wk.generateBill(total) == true)
            {
                MessageBox.Show("Data Update\nBill Generated");
                p.Hide();
                this.Dispose();
            }
            else MessageBox.Show("Can not update at this time\nTry again later");
        }
        private bool retBool(string x)
        {
            if (string.Equals(x, "true", StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }
        private void SetFields()
        {
            firstNameTxt.Text = data[0];
            lastNameTxt.Text = data[1];
            phoneNoTxt.Text = data[2];
            emailTxt.Text = data[3];
            c1.Checked = retBool(data[4]);
            c2.Checked = retBool(data[5]);
            c3.Checked = retBool(data[6]);
            c4.Checked = retBool(data[7]);
            c5.Checked = retBool(data[8]);
            c6.Checked = retBool(data[9]);
            c7.Checked = retBool(data[10]);
            c8.Checked = retBool(data[11]);
            c9.Checked = retBool(data[12]);
            c10.Checked = retBool(data[13]);
            c11.Checked = retBool(data[14]);
            c12.Checked = retBool(data[15]);
            mealsCheck.Checked = retBool(data[16]);
            photoCheck.Checked = retBool(data[17]);
            souvenirsCheck.Checked = retBool(data[18]);
            touristComboBox.SelectedItem = data[19];
            totalLbl.Text = data[20];
            if (retBool(data[21]) == true) statusComboBox.SelectedItem = "Completed";
            else statusComboBox.SelectedItem = "Incomplete";
            touristIDTxt.Text = data[22];
        }
        private void photoCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            p.Hide();
            this.Dispose();
        }
    }
}
