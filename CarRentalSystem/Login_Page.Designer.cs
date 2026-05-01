namespace CarRentalSystem
{
    partial class Login_Page
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            txtUsername = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label4 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            RegisterLabel = new LinkLabel();
            label8 = new Label();
            errorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Login_Logo;
            pictureBox1.Location = new Point(85, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(550, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Login_Line_Divider;
            pictureBox2.Location = new Point(596, -110);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(195, 966);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(802, 92);
            label1.Name = "label1";
            label1.Size = new Size(190, 45);
            label1.TabIndex = 3;
            label1.Text = "Welcome! ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(804, 137);
            label2.Name = "label2";
            label2.Size = new Size(390, 45);
            label2.TabIndex = 4;
            label2.Text = "Sign into your account";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(txtUsername);
            flowLayoutPanel1.Location = new Point(809, 213);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(650, 80);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 40);
            label3.TabIndex = 0;
            label3.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Dock = DockStyle.Top;
            txtUsername.Location = new Point(3, 43);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(462, 41);
            txtUsername.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(txtPassword);
            flowLayoutPanel2.Location = new Point(809, 331);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(650, 80);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(200, 40);
            label4.TabIndex = 0;
            label4.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Dock = DockStyle.Top;
            txtPassword.Location = new Point(3, 43);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(462, 41);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(809, 492);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(650, 80);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 142, 2);
            label5.Location = new Point(275, 411);
            label5.Name = "label5";
            label5.Size = new Size(178, 71);
            label5.TabIndex = 8;
            label5.Text = "No Car?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 142, 2);
            label6.Location = new Point(137, 553);
            label6.Name = "label6";
            label6.Size = new Size(453, 71);
            label6.TabIndex = 9;
            label6.Text = "Rent it, Ride it, Love it";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 142, 2);
            label7.Location = new Point(236, 482);
            label7.Name = "label7";
            label7.Size = new Size(252, 71);
            label7.TabIndex = 10;
            label7.Text = "No Problem";
            // 
            // RegisterLabel
            // 
            RegisterLabel.ActiveLinkColor = Color.Black;
            RegisterLabel.AutoSize = true;
            RegisterLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            RegisterLabel.LinkColor = Color.FromArgb(255, 142, 2);
            RegisterLabel.Location = new Point(966, 618);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(149, 33);
            RegisterLabel.TabIndex = 12;
            RegisterLabel.TabStop = true;
            RegisterLabel.Text = "Click Here";
            RegisterLabel.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(825, 618);
            label8.Name = "label8";
            label8.Size = new Size(135, 33);
            label8.TabIndex = 13;
            label8.Text = "Register?";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(809, 433);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(463, 33);
            errorLabel.TabIndex = 14;
            errorLabel.Text = "Username or Password not correct";
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(16F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1574, 829);
            Controls.Add(errorLabel);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(RegisterLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnLogin);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            Font = new Font("Century Gothic", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Login_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private TextBox txtUsername;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label4;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label5;
        private Label label6;
        private Label label7;
        private LinkLabel RegisterLabel;
        private Label label8;
        private Label errorLabel;
    }
}
