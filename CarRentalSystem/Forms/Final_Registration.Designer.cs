namespace CarRentalSystem.Forms
{
    partial class Final_Registration
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            Phone_Number = new Label();
            txtPhoneNumber = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            txtSSN = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label2 = new Label();
            DateSSNExpirationDate = new DateTimePicker();
            btnCancel = new Button();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label3 = new Label();
            txtLicenseNum = new TextBox();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(Phone_Number);
            flowLayoutPanel1.Controls.Add(txtPhoneNumber);
            flowLayoutPanel1.Location = new Point(112, 101);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(650, 80);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // Phone_Number
            // 
            Phone_Number.Dock = DockStyle.Top;
            Phone_Number.ForeColor = SystemColors.GrayText;
            Phone_Number.Location = new Point(3, 0);
            Phone_Number.Name = "Phone_Number";
            Phone_Number.Size = new Size(200, 40);
            Phone_Number.TabIndex = 0;
            Phone_Number.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.White;
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Dock = DockStyle.Top;
            txtPhoneNumber.Location = new Point(3, 43);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(462, 41);
            txtPhoneNumber.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(txtSSN);
            flowLayoutPanel2.Location = new Point(112, 210);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(650, 80);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 40);
            label1.TabIndex = 0;
            label1.Text = "SSN";
            // 
            // txtSSN
            // 
            txtSSN.BackColor = Color.White;
            txtSSN.BorderStyle = BorderStyle.None;
            txtSSN.Dock = DockStyle.Top;
            txtSSN.Location = new Point(3, 43);
            txtSSN.Multiline = true;
            txtSSN.Name = "txtSSN";
            txtSSN.Size = new Size(462, 41);
            txtSSN.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(DateSSNExpirationDate);
            flowLayoutPanel3.Location = new Point(112, 438);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(650, 80);
            flowLayoutPanel3.TabIndex = 8;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 40);
            label2.TabIndex = 0;
            label2.Text = "Expiration Date";
            // 
            // DateSSNExpirationDate
            // 
            DateSSNExpirationDate.CalendarTitleBackColor = SystemColors.ControlText;
            DateSSNExpirationDate.CalendarTitleForeColor = Color.White;
            DateSSNExpirationDate.Location = new Point(3, 43);
            DateSSNExpirationDate.Name = "DateSSNExpirationDate";
            DateSSNExpirationDate.Size = new Size(650, 39);
            DateSSNExpirationDate.TabIndex = 22;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Black;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(112, 712);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(650, 80);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Black;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(112, 589);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(650, 80);
            btnRegister.TabIndex = 20;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Car_View_Car_Left;
            pictureBox1.Location = new Point(746, 2);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel4.Controls.Add(label3);
            flowLayoutPanel4.Controls.Add(txtLicenseNum);
            flowLayoutPanel4.Location = new Point(112, 327);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(650, 80);
            flowLayoutPanel4.TabIndex = 9;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 40);
            label3.TabIndex = 0;
            label3.Text = "License Number";
            // 
            // txtLicenseNum
            // 
            txtLicenseNum.BackColor = Color.White;
            txtLicenseNum.BorderStyle = BorderStyle.None;
            txtLicenseNum.Dock = DockStyle.Top;
            txtLicenseNum.Location = new Point(3, 43);
            txtLicenseNum.Multiline = true;
            txtLicenseNum.Name = "txtLicenseNum";
            txtLicenseNum.Size = new Size(462, 41);
            txtLicenseNum.TabIndex = 1;
            // 
            // Final_Registration
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(916, 875);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegister);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(btnCancel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel3);
            Name = "Final_Registration";
            Text = "Final_Registration";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label Phone_Number;
        private TextBox txtPhoneNumber;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private TextBox txtSSN;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label2;
        private Button btnCancel;
        private Button btnRegister;
        private DateTimePicker DateSSNExpirationDate;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label3;
        private TextBox txtLicenseNum;
    }
}