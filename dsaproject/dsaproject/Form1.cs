using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsaproject
{

    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        public void closeMainForm()
        {
            this.Hide();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new bookaticketForm());
        }
        private void destinationButton_Click(object sender, EventArgs e)
        {
            openChildForm(new viewDestinationsForm());
        }

        private void facultyButton_Click(object sender, EventArgs e)
        {
            openChildForm(new facultyloginForm());
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
