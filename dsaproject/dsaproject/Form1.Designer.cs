
namespace dsaproject
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuBar = new System.Windows.Forms.Panel();
            this.facultyButton = new System.Windows.Forms.Button();
            this.bookaticketButton = new System.Windows.Forms.Button();
            this.destinationButton = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuBar.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.menuBar.Controls.Add(this.facultyButton);
            this.menuBar.Controls.Add(this.bookaticketButton);
            this.menuBar.Controls.Add(this.destinationButton);
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1068, 114);
            this.menuBar.TabIndex = 0;
            this.menuBar.Paint += new System.Windows.Forms.PaintEventHandler(this.menuBar_Paint);
            // 
            // facultyButton
            // 
            this.facultyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(85)))), ((int)(((byte)(120)))));
            this.facultyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(85)))), ((int)(((byte)(120)))));
            this.facultyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(168)))));
            this.facultyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facultyButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.facultyButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.facultyButton.Location = new System.Drawing.Point(720, 40);
            this.facultyButton.Name = "facultyButton";
            this.facultyButton.Size = new System.Drawing.Size(245, 48);
            this.facultyButton.TabIndex = 2;
            this.facultyButton.Text = "Faculty";
            this.facultyButton.UseVisualStyleBackColor = false;
            this.facultyButton.Click += new System.EventHandler(this.facultyButton_Click);
            // 
            // bookaticketButton
            // 
            this.bookaticketButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(85)))), ((int)(((byte)(120)))));
            this.bookaticketButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(85)))), ((int)(((byte)(120)))));
            this.bookaticketButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(168)))));
            this.bookaticketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookaticketButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookaticketButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bookaticketButton.Location = new System.Drawing.Point(416, 40);
            this.bookaticketButton.Name = "bookaticketButton";
            this.bookaticketButton.Size = new System.Drawing.Size(247, 50);
            this.bookaticketButton.TabIndex = 1;
            this.bookaticketButton.Text = "Book a Ticket";
            this.bookaticketButton.UseVisualStyleBackColor = false;
            this.bookaticketButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // destinationButton
            // 
            this.destinationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(85)))), ((int)(((byte)(120)))));
            this.destinationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(85)))), ((int)(((byte)(120)))));
            this.destinationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(168)))));
            this.destinationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.destinationButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.destinationButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.destinationButton.Location = new System.Drawing.Point(112, 40);
            this.destinationButton.Name = "destinationButton";
            this.destinationButton.Size = new System.Drawing.Size(242, 48);
            this.destinationButton.TabIndex = 0;
            this.destinationButton.Text = "View Destinations";
            this.destinationButton.UseVisualStyleBackColor = false;
            this.destinationButton.Click += new System.EventHandler(this.destinationButton_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 114);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1068, 537);
            this.panelChildForm.TabIndex = 1;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(656, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 651);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1084, 690);
            this.MinimumSize = new System.Drawing.Size(1084, 690);
            this.Name = "mainForm";
            this.Text = "SMH Tour Agency";
            this.menuBar.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuBar;
        private System.Windows.Forms.Button facultyButton;
        private System.Windows.Forms.Button bookaticketButton;
        private System.Windows.Forms.Button destinationButton;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

