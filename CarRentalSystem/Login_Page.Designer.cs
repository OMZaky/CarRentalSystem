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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            textBox1 = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label4 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            linkLabel2 = new LinkLabel();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(550, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(596, -110);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(195, 966);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(802, 92);
            label1.Name = "label1";
            label1.Size = new Size(145, 34);
            label1.TabIndex = 3;
            label1.Text = "Welcome! ";
            label1.Click += label1_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(804, 137);
            label2.Name = "label2";
            label2.Size = new Size(297, 34);
            label2.TabIndex = 4;
            label2.Text = "Sign into your account";
            label2.Click += label2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Location = new Point(809, 213);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(650, 80);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
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
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(3, 43);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(462, 41);
            textBox1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(textBox2);
            flowLayoutPanel2.Location = new Point(809, 346);
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
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Top;
            textBox2.Location = new Point(3, 43);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(462, 41);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(809, 473);
            button1.Name = "button1";
            button1.Size = new Size(650, 80);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 142, 2);
            label5.Location = new Point(275, 411);
            label5.Name = "label5";
            label5.Size = new Size(136, 54);
            label5.TabIndex = 8;
            label5.Text = "No Car?";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 142, 2);
            label6.Location = new Point(137, 553);
            label6.Name = "label6";
            label6.Size = new Size(348, 54);
            label6.TabIndex = 9;
            label6.Text = "Rent it, Ride it, Love it";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 142, 2);
            label7.Location = new Point(236, 482);
            label7.Name = "label7";
            label7.Size = new Size(193, 54);
            label7.TabIndex = 10;
            label7.Text = "No Problem";
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Black;
            linkLabel2.AutoSize = true;
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.LinkColor = Color.FromArgb(255, 142, 2);
            linkLabel2.Location = new Point(966, 603);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(114, 24);
            linkLabel2.TabIndex = 12;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Click Here";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(825, 603);
            label8.Name = "label8";
            label8.Size = new Size(101, 24);
            label8.TabIndex = 13;
            label8.Text = "Register?";
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1574, 829);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(linkLabel2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
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
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label4;
        private TextBox textBox2;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label label7;
        private LinkLabel linkLabel2;
        private Label label8;
    }
}
