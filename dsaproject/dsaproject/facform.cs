using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace dsaproject
{
    public partial class facform : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-T6CFC8HU\SQLEXPRESS01;Initial Catalog=SMHTravelData;User ID=admin;Password=admin;");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        public facform()
        {
            InitializeComponent();
            DisplayValue();
            panel.Hide();
        }
        public void DisplayValue()
        {
            try
            {
                sqlCon.Open();
                adpt = new SqlDataAdapter("SELECT FirstName, LastName, Phone, Email FROM TableRecords",sqlCon);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlCon.Close();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Could not connect to database\nPlease try again later");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void facform_Load(object sender, EventArgs e)
        {
           
        }

        private void userkeyTxt_TextChanged(object sender, EventArgs e)
        {
            SearchData(searchTxt.Text);
        }
        public void SearchData(string search)
        {
            try
            {
                sqlCon.Open();
                string query = "SELECT FirstName, LastName, Phone, Email FROM TableRecords WHERE FirstName like '%" + search + "%' OR LastName like '%" + search + "%' OR Phone like '%" + search + "%' OR Email like '%" + search + "%'";
                adpt = new SqlDataAdapter(query, sqlCon);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlCon.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not connect to database\nPlease try again later");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int colindex = 2;
            string phone = dataGridView1.Rows[rowindex].Cells[colindex].Value.ToString();
            string[] data = new string[23];
            try
            {
                sqlCon.Open();
                cmd = new SqlCommand("SELECT ID, FirstName, LastName, Phone, Email, Khalifa, Garden, Frame, Skydive, Jbr, Alarab, Aquarium, Legoland, Aquaventure, Coffee, Bollywood, Ski, Meals, Photos, Souvenirs, Tourists, Total, Status FROM TableRecords WHERE Phone = @Phone", sqlCon);
                cmd.Parameters.AddWithValue("Phone", phone);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    data[22] = reader1["ID"].ToString();
                    data[0] = reader1["FirstName"].ToString();
                    data[1] = reader1["LastName"].ToString();
                    data[2] = reader1["Phone"].ToString();
                    data[3] = reader1["Email"].ToString();
                    data[4] = reader1["Khalifa"].ToString();
                    data[5] = reader1["Garden"].ToString();
                    data[6] = reader1["Frame"].ToString();
                    data[7] = reader1["Skydive"].ToString();
                    data[8] = reader1["Jbr"].ToString();
                    data[9] = reader1["Alarab"].ToString();
                    data[10] = reader1["Aquarium"].ToString();
                    data[11] = reader1["Legoland"].ToString();
                    data[12] = reader1["Aquaventure"].ToString();
                    data[13] = reader1["Coffee"].ToString();
                    data[14] = reader1["Bollywood"].ToString();
                    data[15] = reader1["Ski"].ToString();
                    data[16] = reader1["Meals"].ToString();
                    data[17] = reader1["Photos"].ToString();
                    data[18] = reader1["Souvenirs"].ToString();
                    data[19] = reader1["Tourists"].ToString();
                    data[20] = reader1["Total"].ToString();
                    data[21] = reader1["Status"].ToString();                   
                }
                sqlCon.Close();
                facform2 childForm = new facform2(panel, data);
                panel.Show();
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panel.Controls.Add(childForm);
                panel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not retrieve any data\nPlease try again later");
            }          
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            DisplayValue();
        }
    }
}
