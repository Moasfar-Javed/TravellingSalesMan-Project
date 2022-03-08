
namespace dsaproject
{
    partial class DestInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DestInfoForm));
            this.backBtn = new System.Windows.Forms.Button();
            this.infoLbl = new System.Windows.Forms.Label();
            this.infotxtBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backBtn.Location = new System.Drawing.Point(472, 432);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(96, 32);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "< Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.infoLbl.Location = new System.Drawing.Point(56, 72);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(177, 40);
            this.infoLbl.TabIndex = 34;
            this.infoLbl.Text = "Burj Khalifa";
            // 
            // infotxtBox
            // 
            this.infotxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.infotxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infotxtBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.infotxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infotxtBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.infotxtBox.Location = new System.Drawing.Point(64, 136);
            this.infotxtBox.Name = "infotxtBox";
            this.infotxtBox.ReadOnly = true;
            this.infotxtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.infotxtBox.Size = new System.Drawing.Size(504, 272);
            this.infotxtBox.TabIndex = 36;
            this.infotxtBox.TabStop = false;
            this.infotxtBox.Text = resources.GetString("infotxtBox.Text");
            // 
            // DestInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(627, 507);
            this.Controls.Add(this.infotxtBox);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.backBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(643, 546);
            this.MinimumSize = new System.Drawing.Size(643, 546);
            this.Name = "DestInfoForm";
            this.Text = "Destination Info";
            this.Load += new System.EventHandler(this.DestInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.RichTextBox infotxtBox;
    }
}