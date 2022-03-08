
namespace dsaproject
{
    partial class facultyloginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userkeyTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signinBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.notelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userkeyTxt
            // 
            this.userkeyTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.userkeyTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userkeyTxt.ForeColor = System.Drawing.SystemColors.Info;
            this.userkeyTxt.Location = new System.Drawing.Point(424, 208);
            this.userkeyTxt.Name = "userkeyTxt";
            this.userkeyTxt.Size = new System.Drawing.Size(200, 35);
            this.userkeyTxt.TabIndex = 0;
            this.userkeyTxt.TextChanged += new System.EventHandler(this.userkeyTxt_TextChanged);
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTxt.ForeColor = System.Drawing.SystemColors.Info;
            this.passwordTxt.Location = new System.Drawing.Point(424, 304);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(200, 35);
            this.passwordTxt.TabIndex = 1;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(424, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Userkey";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(424, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // signinBtn
            // 
            this.signinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.signinBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.signinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signinBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signinBtn.Location = new System.Drawing.Point(424, 384);
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.Size = new System.Drawing.Size(200, 32);
            this.signinBtn.TabIndex = 4;
            this.signinBtn.Text = "Sign In";
            this.signinBtn.UseVisualStyleBackColor = false;
            this.signinBtn.Click += new System.EventHandler(this.signinBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(248, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(564, 86);
            this.label3.TabIndex = 34;
            this.label3.Text = "FACULTY SIGN IN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // notelabel
            // 
            this.notelabel.AutoSize = true;
            this.notelabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.notelabel.ForeColor = System.Drawing.Color.LightCoral;
            this.notelabel.Location = new System.Drawing.Point(432, 448);
            this.notelabel.Name = "notelabel";
            this.notelabel.Size = new System.Drawing.Size(191, 15);
            this.notelabel.TabIndex = 35;
            this.notelabel.Text = "Note: This page for faculty use only";
            // 
            // facultyloginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1068, 537);
            this.Controls.Add(this.notelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signinBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userkeyTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1068, 537);
            this.MinimumSize = new System.Drawing.Size(1068, 537);
            this.Name = "facultyloginForm";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.facultyloginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userkeyTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signinBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label notelabel;
    }
}