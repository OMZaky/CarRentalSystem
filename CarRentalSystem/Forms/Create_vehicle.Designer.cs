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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            label3 = new Label();
            textBox1 = new TextBox();
            dtpPickup = new DateTimePicker();
            txtSsn = new TextBox();
            lblSsnTitle = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            cmbCategory = new ComboBox();
            lblPersonalSection = new Label();
            lblFirstNameTitle = new Label();
            txtFirstName = new TextBox();
            lblLastNameTitle = new Label();
            lblEmailTitle = new Label();
            txtEmail = new TextBox();
            lblPhoneTitle = new Label();
            lblUsernameTitle = new Label();
            btnEditDetails = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-13, -4);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1304, 125);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_home_50;
            pictureBox1.Location = new Point(1138, 19);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(232, 160, 0);
            label2.Location = new Point(166, 68);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(246, 32);
            label2.TabIndex = 2;
            label2.Text = "Rent it, Ride it, Love it";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 44);
            label1.TabIndex = 1;
            label1.Text = "DriveEasy";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Car_View_Car_Left;
            pictureBox2.Location = new Point(32, 15);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(dtpPickup);
            panel5.Controls.Add(txtSsn);
            panel5.Controls.Add(lblSsnTitle);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(comboBox2);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(cmbCategory);
            panel5.Controls.Add(lblPersonalSection);
            panel5.Controls.Add(lblFirstNameTitle);
            panel5.Controls.Add(txtFirstName);
            panel5.Controls.Add(lblLastNameTitle);
            panel5.Controls.Add(lblEmailTitle);
            panel5.Controls.Add(txtEmail);
            panel5.Controls.Add(lblPhoneTitle);
            panel5.Controls.Add(lblUsernameTitle);
            panel5.Controls.Add(btnEditDetails);
            panel5.Location = new Point(1, 260);
            panel5.Margin = new Padding(4, 4, 4, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1214, 549);
            panel5.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(187, 187, 187);
            label3.Location = new Point(387, 399);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 37;
            label3.Text = "Color";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(250, 250, 250);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Courier New", 10F);
            textBox1.ForeColor = Color.FromArgb(34, 34, 34);
            textBox1.Location = new Point(387, 438);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(475, 38);
            textBox1.TabIndex = 38;
            textBox1.Text = "29901011234567";
            // 
            // dtpPickup
            // 
            dtpPickup.Location = new Point(31, 442);
            dtpPickup.Margin = new Padding(5, 5, 5, 5);
            dtpPickup.Name = "dtpPickup";
            dtpPickup.Size = new Size(270, 39);
            dtpPickup.TabIndex = 36;
            // 
            // txtSsn
            // 
            txtSsn.BackColor = Color.FromArgb(250, 250, 250);
            txtSsn.BorderStyle = BorderStyle.FixedSingle;
            txtSsn.Font = new Font("Courier New", 10F);
            txtSsn.ForeColor = Color.FromArgb(34, 34, 34);
            txtSsn.Location = new Point(31, 219);
            txtSsn.Margin = new Padding(4, 4, 4, 4);
            txtSsn.Name = "txtSsn";
            txtSsn.Size = new Size(475, 38);
            txtSsn.TabIndex = 10;
            txtSsn.Text = "29901011234567";
            // 
            // lblSsnTitle
            // 
            lblSsnTitle.AutoSize = true;
            lblSsnTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSsnTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblSsnTitle.Location = new Point(31, 180);
            lblSsnTitle.Margin = new Padding(4, 0, 4, 0);
            lblSsnTitle.Name = "lblSsnTitle";
            lblSsnTitle.Size = new Size(57, 30);
            lblSsnTitle.TabIndex = 9;
            lblSsnTitle.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(31, 394);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(166, 31);
            label5.TabIndex = 35;
            label5.Text = "Purchase Date";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 10F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "All Levels", "Economy", "Standard", "Premium", "VIP" });
            comboBox2.Location = new Point(630, 324);
            comboBox2.Margin = new Padding(5, 5, 5, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(231, 45);
            comboBox2.TabIndex = 34;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All Branches", "Cairo International Airport", "Alexandria", "New Cairo HQ" });
            comboBox1.Location = new Point(630, 219);
            comboBox1.Margin = new Padding(5, 5, 5, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(520, 45);
            comboBox1.TabIndex = 33;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "All Categories", "Sedan", "SUV", "Luxury" });
            cmbCategory.Location = new Point(630, 101);
            cmbCategory.Margin = new Padding(5, 5, 5, 5);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(520, 45);
            cmbCategory.TabIndex = 32;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // lblPersonalSection
            // 
            lblPersonalSection.AutoSize = true;
            lblPersonalSection.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPersonalSection.ForeColor = Color.FromArgb(187, 187, 187);
            lblPersonalSection.Location = new Point(18, 15);
            lblPersonalSection.Margin = new Padding(4, 0, 4, 0);
            lblPersonalSection.Name = "lblPersonalSection";
            lblPersonalSection.Size = new Size(216, 30);
            lblPersonalSection.TabIndex = 0;
            lblPersonalSection.Text = "CAR INFORMATION";
            // 
            // lblFirstNameTitle
            // 
            lblFirstNameTitle.AutoSize = true;
            lblFirstNameTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblFirstNameTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblFirstNameTitle.Location = new Point(31, 63);
            lblFirstNameTitle.Margin = new Padding(4, 0, 4, 0);
            lblFirstNameTitle.Name = "lblFirstNameTitle";
            lblFirstNameTitle.Size = new Size(79, 30);
            lblFirstNameTitle.TabIndex = 1;
            lblFirstNameTitle.Text = "Model";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(250, 250, 250);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.ForeColor = Color.FromArgb(34, 34, 34);
            txtFirstName.Location = new Point(31, 104);
            txtFirstName.Margin = new Padding(4, 4, 4, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(475, 43);
            txtFirstName.TabIndex = 2;
            txtFirstName.Text = "Omar";
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // lblLastNameTitle
            // 
            lblLastNameTitle.AutoSize = true;
            lblLastNameTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblLastNameTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblLastNameTitle.Location = new Point(630, 63);
            lblLastNameTitle.Margin = new Padding(4, 0, 4, 0);
            lblLastNameTitle.Name = "lblLastNameTitle";
            lblLastNameTitle.Size = new Size(109, 30);
            lblLastNameTitle.TabIndex = 3;
            lblLastNameTitle.Text = "Category";
            // 
            // lblEmailTitle
            // 
            lblEmailTitle.AutoSize = true;
            lblEmailTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblEmailTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblEmailTitle.Location = new Point(31, 278);
            lblEmailTitle.Margin = new Padding(4, 0, 4, 0);
            lblEmailTitle.Name = "lblEmailTitle";
            lblEmailTitle.Size = new Size(102, 30);
            lblEmailTitle.TabIndex = 5;
            lblEmailTitle.Text = "PlateNo.";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(250, 250, 250);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.FromArgb(34, 34, 34);
            txtEmail.Location = new Point(31, 324);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(475, 43);
            txtEmail.TabIndex = 6;
            txtEmail.Text = "XXX/XXX";
            // 
            // lblPhoneTitle
            // 
            lblPhoneTitle.AutoSize = true;
            lblPhoneTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPhoneTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblPhoneTitle.Location = new Point(630, 173);
            lblPhoneTitle.Margin = new Padding(4, 0, 4, 0);
            lblPhoneTitle.Name = "lblPhoneTitle";
            lblPhoneTitle.Size = new Size(85, 30);
            lblPhoneTitle.TabIndex = 7;
            lblPhoneTitle.Text = "Branch";
            // 
            // lblUsernameTitle
            // 
            lblUsernameTitle.AutoSize = true;
            lblUsernameTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblUsernameTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblUsernameTitle.Location = new Point(630, 285);
            lblUsernameTitle.Margin = new Padding(4, 0, 4, 0);
            lblUsernameTitle.Name = "lblUsernameTitle";
            lblUsernameTitle.Size = new Size(77, 30);
            lblUsernameTitle.TabIndex = 11;
            lblUsernameTitle.Text = "Status";
            // 
            // btnEditDetails
            // 
            btnEditDetails.BackColor = Color.FromArgb(34, 34, 34);
            btnEditDetails.FlatAppearance.BorderSize = 0;
            btnEditDetails.FlatStyle = FlatStyle.Flat;
            btnEditDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditDetails.ForeColor = Color.White;
            btnEditDetails.Location = new Point(955, 422);
            btnEditDetails.Margin = new Padding(4, 4, 4, 4);
            btnEditDetails.Name = "btnEditDetails";
            btnEditDetails.Size = new Size(196, 59);
            btnEditDetails.TabIndex = 13;
            btnEditDetails.Text = "Variable";
            btnEditDetails.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 147);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(409, 93);
            label4.TabIndex = 8;
            label4.Text = "Variable lbl";
            // 
            // Create_vehicle
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 808);
            Controls.Add(label4);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Create_vehicle";
            Text = "Create_vehicle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Label lblEmailTitle;
        private TextBox txtEmail;
        private Label lblPhoneTitle;
        private Label lblSsnTitle;
        private TextBox txtSsn;
        private Label lblUsernameTitle;
        private Button btnEditDetails;
        private PictureBox pictureBox1;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox cmbCategory;
        private ComboBox comboBox2;
        private DateTimePicker dtpPickup;
        private Label label5;
        private Label label3;
        private TextBox textBox1;
    }
}