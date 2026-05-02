namespace CarRentalSystem.Forms
{
    partial class Register_Page
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
            First_Name = new Label();
            txtFirstName = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            txtUsername = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            Email = new Label();
            txtEmail = new TextBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            Last_Name = new Label();
            txtLastName = new TextBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            Password = new Label();
            txtPassword = new TextBox();
            BackBtn = new PictureBox();
            UsernameErrorLabel = new Label();
            EmailErrorLabel = new Label();
            PasswordErrorLabel = new Label();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(First_Name);
            flowLayoutPanel1.Controls.Add(txtFirstName);
            flowLayoutPanel1.Location = new Point(44, 178);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(650, 80);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // First_Name
            // 
            First_Name.Dock = DockStyle.Top;
            First_Name.ForeColor = SystemColors.GrayText;
            First_Name.Location = new Point(3, 0);
            First_Name.Name = "First_Name";
            First_Name.Size = new Size(200, 40);
            First_Name.TabIndex = 0;
            First_Name.Text = "First Name";
            First_Name.Click += label3_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Dock = DockStyle.Top;
            txtFirstName.Location = new Point(3, 43);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(462, 41);
            txtFirstName.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(txtUsername);
            flowLayoutPanel2.Location = new Point(44, 315);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(650, 80);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 40);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Dock = DockStyle.Top;
            txtUsername.Location = new Point(3, 43);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(462, 41);
            txtUsername.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel3.Controls.Add(Email);
            flowLayoutPanel3.Controls.Add(txtEmail);
            flowLayoutPanel3.Location = new Point(773, 315);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(650, 80);
            flowLayoutPanel3.TabIndex = 7;
            // 
            // Email
            // 
            Email.Dock = DockStyle.Top;
            Email.ForeColor = SystemColors.GrayText;
            Email.Location = new Point(3, 0);
            Email.Name = "Email";
            Email.Size = new Size(200, 40);
            Email.TabIndex = 0;
            Email.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Dock = DockStyle.Top;
            txtEmail.Location = new Point(3, 43);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(462, 41);
            txtEmail.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel5.Controls.Add(Last_Name);
            flowLayoutPanel5.Controls.Add(txtLastName);
            flowLayoutPanel5.Location = new Point(773, 179);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(650, 80);
            flowLayoutPanel5.TabIndex = 7;
            // 
            // Last_Name
            // 
            Last_Name.Dock = DockStyle.Top;
            Last_Name.ForeColor = SystemColors.GrayText;
            Last_Name.Location = new Point(3, 0);
            Last_Name.Name = "Last_Name";
            Last_Name.Size = new Size(200, 40);
            Last_Name.TabIndex = 0;
            Last_Name.Text = "Last Name";
            Last_Name.Click += label5_Click;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Dock = DockStyle.Top;
            txtLastName.Location = new Point(3, 43);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(462, 41);
            txtLastName.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel6.Controls.Add(Password);
            flowLayoutPanel6.Controls.Add(txtPassword);
            flowLayoutPanel6.Location = new Point(44, 473);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(650, 80);
            flowLayoutPanel6.TabIndex = 8;
            // 
            // Password
            // 
            Password.Dock = DockStyle.Top;
            Password.ForeColor = SystemColors.GrayText;
            Password.Location = new Point(3, 0);
            Password.Name = "Password";
            Password.Size = new Size(200, 40);
            Password.TabIndex = 0;
            Password.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Dock = DockStyle.Top;
            txtPassword.Location = new Point(3, 43);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(462, 41);
            txtPassword.TabIndex = 1;
            // 
            // BackBtn
            // 
            BackBtn.Image = Properties.Resources.Back_Button;
            BackBtn.Location = new Point(44, 32);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(104, 84);
            BackBtn.SizeMode = PictureBoxSizeMode.Zoom;
            BackBtn.TabIndex = 9;
            BackBtn.TabStop = false;
            // 
            // UsernameErrorLabel
            // 
            UsernameErrorLabel.AutoSize = true;
            UsernameErrorLabel.ForeColor = Color.Red;
            UsernameErrorLabel.Location = new Point(45, 406);
            UsernameErrorLabel.Name = "UsernameErrorLabel";
            UsernameErrorLabel.Size = new Size(373, 32);
            UsernameErrorLabel.TabIndex = 15;
            UsernameErrorLabel.Text = "Username taken. Try another one.";
            UsernameErrorLabel.Click += errorLabel_Click;
            // 
            // EmailErrorLabel
            // 
            EmailErrorLabel.AutoSize = true;
            EmailErrorLabel.ForeColor = Color.Red;
            EmailErrorLabel.Location = new Point(773, 406);
            EmailErrorLabel.Name = "EmailErrorLabel";
            EmailErrorLabel.Size = new Size(222, 32);
            EmailErrorLabel.TabIndex = 16;
            EmailErrorLabel.Text = "Email is not correct.";
            // 
            // PasswordErrorLabel
            // 
            PasswordErrorLabel.AutoSize = true;
            PasswordErrorLabel.ForeColor = Color.Red;
            PasswordErrorLabel.Location = new Point(44, 575);
            PasswordErrorLabel.Name = "PasswordErrorLabel";
            PasswordErrorLabel.Size = new Size(245, 32);
            PasswordErrorLabel.TabIndex = 17;
            PasswordErrorLabel.Text = "Password is Too Weak";
            PasswordErrorLabel.Click += label3_Click_1;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Black;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(773, 473);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(650, 80);
            btnRegister.TabIndex = 18;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Car_View_Car_Left;
            pictureBox1.Location = new Point(1278, 32);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Register_Page
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1478, 725);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegister);
            Controls.Add(PasswordErrorLabel);
            Controls.Add(EmailErrorLabel);
            Controls.Add(UsernameErrorLabel);
            Controls.Add(BackBtn);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel6);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(flowLayoutPanel3);
            Name = "Register_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BackBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label First_Name;
        private TextBox txtFirstName;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private TextBox txtUsername;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label Email;
        private TextBox txtEmail;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label Last_Name;
        private TextBox txtLastName;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label Password;
        private TextBox txtPassword;
        private PictureBox BackBtn;
        private Label UsernameErrorLabel;
        private Label EmailErrorLabel;
        private Label PasswordErrorLabel;
        private Button btnRegister;
        private PictureBox pictureBox1;
    }
}