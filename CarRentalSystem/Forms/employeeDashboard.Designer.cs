using CarRentalSystem.Properties;

namespace car_rental_system
{
    partial class employeeDashboard
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
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            button2 = new Button();
            label11 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            button3 = new Button();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(901, 98);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Resources.icons8_worker_100;
            pictureBox3.Location = new Point(814, 20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(76, 58);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resources.icons8_rhombus_100;
            pictureBox2.Location = new Point(644, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(232, 160, 0);
            label4.Location = new Point(669, 53);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 1;
            label4.Text = "Employee Role";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(34, 34, 34);
            label3.Location = new Point(660, 21);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 3;
            label3.Text = "Employee Name";
            label3.Click += label3_Click;
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
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.Car_Icon;
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 120);
            label5.Name = "label5";
            label5.Size = new Size(186, 27);
            label5.TabIndex = 6;
            label5.Text = "Welcome Back, ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(199, 115);
            label6.Name = "label6";
            label6.Size = new Size(200, 32);
            label6.TabIndex = 7;
            label6.Text = "Omar Ayman!";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(179, 187, 204);
            label7.Location = new Point(27, 156);
            label7.Name = "label7";
            label7.Size = new Size(199, 21);
            label7.TabIndex = 8;
            label7.Text = "Thursday, April 30 2026";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 10F);
            label8.ForeColor = Color.FromArgb(179, 187, 204);
            label8.Location = new Point(220, 153);
            label8.Name = "label8";
            label8.Size = new Size(22, 23);
            label8.TabIndex = 9;
            label8.Text = "●";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(179, 187, 204);
            label9.Location = new Point(248, 155);
            label9.Name = "label9";
            label9.Size = new Size(115, 21);
            label9.TabIndex = 10;
            label9.Text = "Cairo Branch";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(179, 187, 204);
            label10.Location = new Point(27, 211);
            label10.Name = "label10";
            label10.Size = new Size(122, 21);
            label10.TabIndex = 11;
            label10.Text = "NAVIGATION";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(179, 187, 204);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(27, 248);
            button1.Name = "button1";
            button1.Size = new Size(865, 65);
            button1.TabIndex = 12;
            button1.Text = "               Car Search";
            button1.TextAlign = ContentAlignment.TopLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 

            pictureBox4.Image = Resources.icons8_car_search2;
            pictureBox4.Location = new Point(34, 252);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 56);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Resources.icons8_calendar_48;
            pictureBox5.Location = new Point(34, 321);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(69, 61);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(179, 187, 204);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(27, 319);
            button2.Name = "button2";
            button2.Size = new Size(865, 65);
            button2.TabIndex = 14;
            button2.Text = "               Orders/Rentals";
            button2.TextAlign = ContentAlignment.TopLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(232, 160, 0);
            label11.Location = new Point(402, 399);
            label11.Name = "label11";
            label11.Size = new Size(156, 25);
            label11.TabIndex = 6;
            label11.Text = "Manager Section";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Resources.icons8_rhombus_100;
            pictureBox6.Location = new Point(377, 402);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(19, 22);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Resources.icons8_business_group_80;
            pictureBox7.Location = new Point(33, 433);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(69, 62);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.FromArgb(179, 187, 204);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(27, 430);
            button3.Name = "button3";
            button3.Size = new Size(865, 70);
            button3.TabIndex = 16;
            button3.Text = "               Employee Management";
            button3.TextAlign = ContentAlignment.TopLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(179, 187, 204);
            label13.Location = new Point(124, 283);
            label13.Name = "label13";
            label13.Size = new Size(304, 25);
            label13.TabIndex = 18;
            label13.Text = "Browse and Filter through all vehicles";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(179, 187, 204);
            label14.Location = new Point(125, 355);
            label14.Name = "label14";
            label14.Size = new Size(308, 25);
            label14.TabIndex = 19;
            label14.Text = "View and manage active rental orders";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(179, 187, 204);
            label15.Location = new Point(124, 467);
            label15.Name = "label15";
            label15.Size = new Size(282, 25);
            label15.TabIndex = 20;
            label15.Text = "View and manage Sub-Employees";
            // 
            // employeeDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(907, 565);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(pictureBox7);
            Controls.Add(button3);
            Controls.Add(pictureBox6);
            Controls.Add(label11);
            Controls.Add(pictureBox5);
            Controls.Add(button2);
            Controls.Add(pictureBox4);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "employeeDashboard";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button button2;
        private Label label11;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Button button3;
        private Label label13;
        private Label label14;
        private Label label15;
    }
}
