namespace CarRentalSystem.Forms
{
    partial class Create_vehicle
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            lblPersonalSection = new Label();
            lblFirstNameTitle = new Label();
            txtFirstName = new TextBox();
            lblLastNameTitle = new Label();
            txtLastName = new TextBox();
            lblEmailTitle = new Label();
            txtEmail = new TextBox();
            lblPhoneTitle = new Label();
            txtPhone = new TextBox();
            lblSsnTitle = new Label();
            txtSsn = new TextBox();
            lblUsernameTitle = new Label();
            txtUsername = new TextBox();
            btnEditDetails = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-10, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 98);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(232, 160, 0);
            label2.Location = new Point(128, 53);
            label2.Name = "label2";
            label2.Size = new Size(182, 25);
            label2.TabIndex = 2;
            label2.Text = "Rent it, Ride it, Love it";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 21);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 1;
            label1.Text = "DriveEasy";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Car_View_Car_Left;
            pictureBox2.Location = new Point(25, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(97, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblPersonalSection);
            panel5.Controls.Add(lblFirstNameTitle);
            panel5.Controls.Add(txtFirstName);
            panel5.Controls.Add(lblLastNameTitle);
            panel5.Controls.Add(txtLastName);
            panel5.Controls.Add(lblEmailTitle);
            panel5.Controls.Add(txtEmail);
            panel5.Controls.Add(lblPhoneTitle);
            panel5.Controls.Add(txtPhone);
            panel5.Controls.Add(lblSsnTitle);
            panel5.Controls.Add(txtSsn);
            panel5.Controls.Add(lblUsernameTitle);
            panel5.Controls.Add(txtUsername);
            panel5.Controls.Add(btnEditDetails);
            panel5.Location = new Point(1, 203);
            panel5.Name = "panel5";
            panel5.Size = new Size(992, 305);
            panel5.TabIndex = 31;
            // 
            // lblPersonalSection
            // 
            lblPersonalSection.AutoSize = true;
            lblPersonalSection.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPersonalSection.ForeColor = Color.FromArgb(187, 187, 187);
            lblPersonalSection.Location = new Point(14, 12);
            lblPersonalSection.Name = "lblPersonalSection";
            lblPersonalSection.Size = new Size(208, 21);
            lblPersonalSection.TabIndex = 0;
            lblPersonalSection.Text = "PERSONAL INFORMATION";
            // 
            // lblFirstNameTitle
            // 
            lblFirstNameTitle.AutoSize = true;
            lblFirstNameTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblFirstNameTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblFirstNameTitle.Location = new Point(24, 49);
            lblFirstNameTitle.Name = "lblFirstNameTitle";
            lblFirstNameTitle.Size = new Size(59, 21);
            lblFirstNameTitle.TabIndex = 1;
            lblFirstNameTitle.Text = "Model";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(250, 250, 250);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.ForeColor = Color.FromArgb(34, 34, 34);
            txtFirstName.Location = new Point(24, 81);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(366, 34);
            txtFirstName.TabIndex = 2;
            txtFirstName.Text = "Omar";
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // lblLastNameTitle
            // 
            lblLastNameTitle.AutoSize = true;
            lblLastNameTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblLastNameTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblLastNameTitle.Location = new Point(485, 49);
            lblLastNameTitle.Name = "lblLastNameTitle";
            lblLastNameTitle.Size = new Size(99, 21);
            lblLastNameTitle.TabIndex = 3;
            lblLastNameTitle.Text = "LAST NAME";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(250, 250, 250);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.ForeColor = Color.FromArgb(34, 34, 34);
            txtLastName.Location = new Point(485, 81);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(401, 34);
            txtLastName.TabIndex = 4;
            txtLastName.Text = "Ayman";
            // 
            // lblEmailTitle
            // 
            lblEmailTitle.AutoSize = true;
            lblEmailTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblEmailTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblEmailTitle.Location = new Point(24, 135);
            lblEmailTitle.Name = "lblEmailTitle";
            lblEmailTitle.Size = new Size(58, 21);
            lblEmailTitle.TabIndex = 5;
            lblEmailTitle.Text = "EMAIL";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(250, 250, 250);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.FromArgb(34, 34, 34);
            txtEmail.Location = new Point(24, 171);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(366, 34);
            txtEmail.TabIndex = 6;
            txtEmail.Text = "omar.ayman@gmail.com";
            // 
            // lblPhoneTitle
            // 
            lblPhoneTitle.AutoSize = true;
            lblPhoneTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPhoneTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblPhoneTitle.Location = new Point(485, 135);
            lblPhoneTitle.Name = "lblPhoneTitle";
            lblPhoneTitle.Size = new Size(66, 21);
            lblPhoneTitle.TabIndex = 7;
            lblPhoneTitle.Text = "PHONE";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(250, 250, 250);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.ForeColor = Color.FromArgb(34, 34, 34);
            txtPhone.Location = new Point(485, 171);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(401, 34);
            txtPhone.TabIndex = 8;
            txtPhone.Text = "+20 101 234 5678";
            // 
            // lblSsnTitle
            // 
            lblSsnTitle.AutoSize = true;
            lblSsnTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSsnTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblSsnTitle.Location = new Point(24, 223);
            lblSsnTitle.Name = "lblSsnTitle";
            lblSsnTitle.Size = new Size(51, 21);
            lblSsnTitle.TabIndex = 9;
            lblSsnTitle.Text = "Color";
            // 
            // txtSsn
            // 
            txtSsn.BackColor = Color.FromArgb(250, 250, 250);
            txtSsn.BorderStyle = BorderStyle.FixedSingle;
            txtSsn.Font = new Font("Courier New", 10F);
            txtSsn.ForeColor = Color.FromArgb(34, 34, 34);
            txtSsn.Location = new Point(24, 258);
            txtSsn.Name = "txtSsn";
            txtSsn.ReadOnly = true;
            txtSsn.Size = new Size(366, 30);
            txtSsn.TabIndex = 10;
            txtSsn.Text = "29901011234567";
            // 
            // lblUsernameTitle
            // 
            lblUsernameTitle.AutoSize = true;
            lblUsernameTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblUsernameTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblUsernameTitle.Location = new Point(485, 223);
            lblUsernameTitle.Name = "lblUsernameTitle";
            lblUsernameTitle.Size = new Size(57, 21);
            lblUsernameTitle.TabIndex = 11;
            lblUsernameTitle.Text = "Status";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(250, 250, 250);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Courier New", 10F);
            txtUsername.ForeColor = Color.FromArgb(34, 34, 34);
            txtUsername.Location = new Point(485, 258);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(260, 30);
            txtUsername.TabIndex = 12;
            txtUsername.Text = "omar.ayman";
            // 
            // btnEditDetails
            // 
            btnEditDetails.BackColor = Color.FromArgb(34, 34, 34);
            btnEditDetails.FlatAppearance.BorderSize = 0;
            btnEditDetails.FlatStyle = FlatStyle.Flat;
            btnEditDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditDetails.ForeColor = Color.White;
            btnEditDetails.Location = new Point(811, 246);
            btnEditDetails.Name = "btnEditDetails";
            btnEditDetails.Size = new Size(151, 46);
            btnEditDetails.TabIndex = 13;
            btnEditDetails.Text = "Edit Details";
            btnEditDetails.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_home_50;
            pictureBox1.Location = new Point(943, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 115);
            label4.Name = "label4";
            label4.Size = new Size(304, 70);
            label4.TabIndex = 8;
            label4.Text = "Variable lbl";
            // 
            // Create_vehicle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 499);
            Controls.Add(label4);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "Create_vehicle";
            Text = "Create_vehicle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Label lblPersonalSection;
        private Label lblFirstNameTitle;
        private TextBox txtFirstName;
        private Label lblLastNameTitle;
        private TextBox txtLastName;
        private Label lblEmailTitle;
        private TextBox txtEmail;
        private Label lblPhoneTitle;
        private TextBox txtPhone;
        private Label lblSsnTitle;
        private TextBox txtSsn;
        private Label lblUsernameTitle;
        private TextBox txtUsername;
        private Button btnEditDetails;
        private PictureBox pictureBox1;
        private Label label4;
    }
}