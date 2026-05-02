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
            lblEmailTitle = new Label();
            txtEmail = new TextBox();
            lblPhoneTitle = new Label();
            lblSsnTitle = new Label();
            txtSsn = new TextBox();
            lblUsernameTitle = new Label();
            btnEditDetails = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            cmbCategory = new ComboBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dtpPickup = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
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
            panel5.Location = new Point(1, 203);
            panel5.Name = "panel5";
            panel5.Size = new Size(934, 429);
            panel5.TabIndex = 31;
            // 
            // lblPersonalSection
            // 
            lblPersonalSection.AutoSize = true;
            lblPersonalSection.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPersonalSection.ForeColor = Color.FromArgb(187, 187, 187);
            lblPersonalSection.Location = new Point(14, 12);
            lblPersonalSection.Name = "lblPersonalSection";
            lblPersonalSection.Size = new Size(157, 21);
            lblPersonalSection.TabIndex = 0;
            lblPersonalSection.Text = "CAR INFORMATION";
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
            lblLastNameTitle.Size = new Size(80, 21);
            lblLastNameTitle.TabIndex = 3;
            lblLastNameTitle.Text = "Category";
            // 
            // lblEmailTitle
            // 
            lblEmailTitle.AutoSize = true;
            lblEmailTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblEmailTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblEmailTitle.Location = new Point(24, 217);
            lblEmailTitle.Name = "lblEmailTitle";
            lblEmailTitle.Size = new Size(76, 21);
            lblEmailTitle.TabIndex = 5;
            lblEmailTitle.Text = "PlateNo.";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(250, 250, 250);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.FromArgb(34, 34, 34);
            txtEmail.Location = new Point(24, 253);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(366, 34);
            txtEmail.TabIndex = 6;
            txtEmail.Text = "XXX/XXX";
            // 
            // lblPhoneTitle
            // 
            lblPhoneTitle.AutoSize = true;
            lblPhoneTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPhoneTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblPhoneTitle.Location = new Point(485, 135);
            lblPhoneTitle.Name = "lblPhoneTitle";
            lblPhoneTitle.Size = new Size(63, 21);
            lblPhoneTitle.TabIndex = 7;
            lblPhoneTitle.Text = "Branch";
            // 
            // lblSsnTitle
            // 
            lblSsnTitle.AutoSize = true;
            lblSsnTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSsnTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblSsnTitle.Location = new Point(24, 141);
            lblSsnTitle.Name = "lblSsnTitle";
            lblSsnTitle.Size = new Size(43, 21);
            lblSsnTitle.TabIndex = 9;
            lblSsnTitle.Text = "Year";
            // 
            // txtSsn
            // 
            txtSsn.BackColor = Color.FromArgb(250, 250, 250);
            txtSsn.BorderStyle = BorderStyle.FixedSingle;
            txtSsn.Font = new Font("Courier New", 10F);
            txtSsn.ForeColor = Color.FromArgb(34, 34, 34);
            txtSsn.Location = new Point(24, 171);
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
            // btnEditDetails
            // 
            btnEditDetails.BackColor = Color.FromArgb(34, 34, 34);
            btnEditDetails.FlatAppearance.BorderSize = 0;
            btnEditDetails.FlatStyle = FlatStyle.Flat;
            btnEditDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditDetails.ForeColor = Color.White;
            btnEditDetails.Location = new Point(735, 330);
            btnEditDetails.Name = "btnEditDetails";
            btnEditDetails.Size = new Size(151, 46);
            btnEditDetails.TabIndex = 13;
            btnEditDetails.Text = "Variable";
            btnEditDetails.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_home_50;
            pictureBox1.Location = new Point(875, 15);
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
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "All Categories", "Sedan", "SUV", "Luxury" });
            cmbCategory.Location = new Point(485, 79);
            cmbCategory.Margin = new Padding(4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(401, 36);
            cmbCategory.TabIndex = 32;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All Categories", "Sedan", "SUV", "Luxury" });
            comboBox1.Location = new Point(485, 171);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(401, 36);
            comboBox1.TabIndex = 33;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 10F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "All Categories", "Sedan", "SUV", "Luxury" });
            comboBox2.Location = new Point(485, 253);
            comboBox2.Margin = new Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(179, 36);
            comboBox2.TabIndex = 34;
            // 
            // dtpPickup
            // 
            dtpPickup.Location = new Point(24, 345);
            dtpPickup.Margin = new Padding(4);
            dtpPickup.Name = "dtpPickup";
            dtpPickup.Size = new Size(209, 31);
            dtpPickup.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(24, 308);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(123, 23);
            label5.TabIndex = 35;
            label5.Text = "Purchase Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(187, 187, 187);
            label3.Location = new Point(298, 312);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 37;
            label3.Text = "Color";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(250, 250, 250);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Courier New", 10F);
            textBox1.ForeColor = Color.FromArgb(34, 34, 34);
            textBox1.Location = new Point(298, 342);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(366, 30);
            textBox1.TabIndex = 38;
            textBox1.Text = "29901011234567";
            // 
            // Create_vehicle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 631);
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