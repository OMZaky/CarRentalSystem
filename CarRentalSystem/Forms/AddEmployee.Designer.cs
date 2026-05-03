namespace CarRentalSystem.Forms
{
    partial class AddEmployee
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
            panel5 = new Panel();
            txtPassword = new TextBox();
            comboBoxRole = new ComboBox();
            lblUsernameTitle = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSSN = new TextBox();
            SSNlbl = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            txtSalary = new TextBox();
            Emaillbl = new Label();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            lblSsnTitle = new Label();
            comboBoxBranch = new ComboBox();
            lblPersonalSection = new Label();
            lblFirstNameTitle = new Label();
            txtFirstName = new TextBox();
            lblPhoneTitle = new Label();
            btnAdd = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtPassword);
            panel5.Controls.Add(comboBoxRole);
            panel5.Controls.Add(lblUsernameTitle);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(txtSSN);
            panel5.Controls.Add(SSNlbl);
            panel5.Controls.Add(txtUsername);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(txtSalary);
            panel5.Controls.Add(Emaillbl);
            panel5.Controls.Add(txtEmail);
            panel5.Controls.Add(txtLastName);
            panel5.Controls.Add(lblSsnTitle);
            panel5.Controls.Add(comboBoxBranch);
            panel5.Controls.Add(lblPersonalSection);
            panel5.Controls.Add(lblFirstNameTitle);
            panel5.Controls.Add(txtFirstName);
            panel5.Controls.Add(lblPhoneTitle);
            panel5.Controls.Add(btnAdd);
            panel5.Location = new Point(32, 222);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1170, 627);
            panel5.TabIndex = 32;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Courier New", 10F);
            txtPassword.ForeColor = Color.FromArgb(34, 34, 34);
            txtPassword.Location = new Point(630, 220);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(475, 38);
            txtPassword.TabIndex = 46;
            // 
            // comboBoxRole
            // 
            comboBoxRole.BackColor = Color.White;
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Font = new Font("Segoe UI", 10F);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "All Levels", "Economy", "Standard", "Premium", "VIP" });
            comboBoxRole.Location = new Point(31, 532);
            comboBoxRole.Margin = new Padding(5);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(475, 45);
            comboBoxRole.TabIndex = 34;
            // 
            // lblUsernameTitle
            // 
            lblUsernameTitle.AutoSize = true;
            lblUsernameTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblUsernameTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblUsernameTitle.Location = new Point(31, 493);
            lblUsernameTitle.Margin = new Padding(4, 0, 4, 0);
            lblUsernameTitle.Name = "lblUsernameTitle";
            lblUsernameTitle.Size = new Size(57, 30);
            lblUsernameTitle.TabIndex = 11;
            lblUsernameTitle.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(187, 187, 187);
            label3.Location = new Point(630, 181);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 30);
            label3.TabIndex = 45;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(187, 187, 187);
            label2.Location = new Point(31, 174);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 30);
            label2.TabIndex = 43;
            label2.Text = "Username";
            // 
            // txtSSN
            // 
            txtSSN.BackColor = Color.White;
            txtSSN.BorderStyle = BorderStyle.FixedSingle;
            txtSSN.Font = new Font("Segoe UI", 10F);
            txtSSN.ForeColor = Color.FromArgb(34, 34, 34);
            txtSSN.Location = new Point(31, 432);
            txtSSN.Margin = new Padding(4);
            txtSSN.Name = "txtSSN";
            txtSSN.Size = new Size(475, 43);
            txtSSN.TabIndex = 6;
            // 
            // SSNlbl
            // 
            SSNlbl.AutoSize = true;
            SSNlbl.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            SSNlbl.ForeColor = Color.FromArgb(187, 187, 187);
            SSNlbl.Location = new Point(31, 386);
            SSNlbl.Margin = new Padding(4, 0, 4, 0);
            SSNlbl.Name = "SSNlbl";
            SSNlbl.Size = new Size(54, 30);
            SSNlbl.TabIndex = 5;
            SSNlbl.Text = "SSN";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.FromArgb(34, 34, 34);
            txtUsername.Location = new Point(31, 220);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(475, 43);
            txtUsername.TabIndex = 44;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(187, 187, 187);
            label1.Location = new Point(630, 278);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 30);
            label1.TabIndex = 41;
            label1.Text = "Salary";
            // 
            // txtSalary
            // 
            txtSalary.BackColor = Color.FromArgb(250, 250, 250);
            txtSalary.BorderStyle = BorderStyle.FixedSingle;
            txtSalary.Font = new Font("Segoe UI", 10F);
            txtSalary.ForeColor = Color.FromArgb(34, 34, 34);
            txtSalary.Location = new Point(630, 324);
            txtSalary.Margin = new Padding(4);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(475, 43);
            txtSalary.TabIndex = 42;
            txtSalary.TextChanged += txtSalary_TextChanged;
            // 
            // Emaillbl
            // 
            Emaillbl.AutoSize = true;
            Emaillbl.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            Emaillbl.ForeColor = Color.FromArgb(187, 187, 187);
            Emaillbl.Location = new Point(31, 278);
            Emaillbl.Margin = new Padding(4, 0, 4, 0);
            Emaillbl.Name = "Emaillbl";
            Emaillbl.Size = new Size(69, 30);
            Emaillbl.TabIndex = 39;
            Emaillbl.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.FromArgb(34, 34, 34);
            txtEmail.Location = new Point(31, 324);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(475, 43);
            txtEmail.TabIndex = 40;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.ForeColor = Color.FromArgb(34, 34, 34);
            txtLastName.Location = new Point(630, 104);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(475, 43);
            txtLastName.TabIndex = 10;
            // 
            // lblSsnTitle
            // 
            lblSsnTitle.AutoSize = true;
            lblSsnTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSsnTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblSsnTitle.Location = new Point(630, 65);
            lblSsnTitle.Margin = new Padding(4, 0, 4, 0);
            lblSsnTitle.Name = "lblSsnTitle";
            lblSsnTitle.Size = new Size(122, 30);
            lblSsnTitle.TabIndex = 9;
            lblSsnTitle.Text = "Last Name";
            // 
            // comboBoxBranch
            // 
            comboBoxBranch.BackColor = Color.White;
            comboBoxBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBranch.Font = new Font("Segoe UI", 10F);
            comboBoxBranch.FormattingEnabled = true;
            comboBoxBranch.Items.AddRange(new object[] { "All Branches", "Cairo International Airport", "Alexandria", "New Cairo HQ" });
            comboBoxBranch.Location = new Point(630, 432);
            comboBoxBranch.Margin = new Padding(5);
            comboBoxBranch.Name = "comboBoxBranch";
            comboBoxBranch.Size = new Size(475, 45);
            comboBoxBranch.TabIndex = 33;
            // 
            // lblPersonalSection
            // 
            lblPersonalSection.AutoSize = true;
            lblPersonalSection.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPersonalSection.ForeColor = Color.FromArgb(187, 187, 187);
            lblPersonalSection.Location = new Point(18, 15);
            lblPersonalSection.Margin = new Padding(4, 0, 4, 0);
            lblPersonalSection.Name = "lblPersonalSection";
            lblPersonalSection.Size = new Size(243, 30);
            lblPersonalSection.TabIndex = 0;
            lblPersonalSection.Text = "Employee Information";
            // 
            // lblFirstNameTitle
            // 
            lblFirstNameTitle.AutoSize = true;
            lblFirstNameTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblFirstNameTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblFirstNameTitle.Location = new Point(31, 63);
            lblFirstNameTitle.Margin = new Padding(4, 0, 4, 0);
            lblFirstNameTitle.Name = "lblFirstNameTitle";
            lblFirstNameTitle.Size = new Size(125, 30);
            lblFirstNameTitle.TabIndex = 1;
            lblFirstNameTitle.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.ForeColor = Color.FromArgb(34, 34, 34);
            txtFirstName.Location = new Point(31, 104);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(475, 43);
            txtFirstName.TabIndex = 2;
            // 
            // lblPhoneTitle
            // 
            lblPhoneTitle.AutoSize = true;
            lblPhoneTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPhoneTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblPhoneTitle.Location = new Point(630, 397);
            lblPhoneTitle.Margin = new Padding(4, 0, 4, 0);
            lblPhoneTitle.Name = "lblPhoneTitle";
            lblPhoneTitle.Size = new Size(85, 30);
            lblPhoneTitle.TabIndex = 7;
            lblPhoneTitle.Text = "Branch";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(630, 518);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(475, 59);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add Employee";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1228, 125);
            panel1.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(232, 160, 0);
            label4.Location = new Point(166, 68);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(246, 32);
            label4.TabIndex = 2;
            label4.Text = "Rent it, Ride it, Love it";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(166, 27);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(208, 44);
            label5.TabIndex = 1;
            label5.Text = "DriveEasy";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Car_View_Car_Left;
            pictureBox2.Location = new Point(32, 15);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 144);
            label6.Name = "label6";
            label6.Size = new Size(269, 64);
            label6.TabIndex = 34;
            label6.Text = "Add Employee";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1228, 882);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Name = "AddEmployee";
            Text = "AddEmployee";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel5;
        private TextBox txtLastName;
        private Label lblSsnTitle;
        private ComboBox comboBoxRole;
        private ComboBox comboBoxBranch;
        private ComboBox cmbCategory;
        private Label lblPersonalSection;
        private Label lblFirstNameTitle;
        private TextBox txtFirstName;
        private Label lblLastNameTitle;
        private Label SSNlbl;
        private TextBox txtSSN;
        private Label lblPhoneTitle;
        private Label lblUsernameTitle;
        private Button btnAdd;
        private Label Emaillbl;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtSalary;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label6;
    }
}