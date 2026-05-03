namespace CarRentalSystem.Forms
{
    partial class Order_View
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
            TopBarPanel = new Panel();
            BackBtn = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            CarsViewPanel = new FlowLayoutPanel();
            TopBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TopBarPanel
            // 
            TopBarPanel.BackColor = SystemColors.ButtonFace;
            TopBarPanel.Controls.Add(BackBtn);
            TopBarPanel.Controls.Add(pictureBox3);
            TopBarPanel.Controls.Add(pictureBox2);
            TopBarPanel.Controls.Add(label2);
            TopBarPanel.Controls.Add(label3);
            TopBarPanel.Controls.Add(label1);
            TopBarPanel.Controls.Add(label5);
            TopBarPanel.Controls.Add(pictureBox1);
            TopBarPanel.Dock = DockStyle.Top;
            TopBarPanel.Location = new Point(0, 0);
            TopBarPanel.Margin = new Padding(4);
            TopBarPanel.Name = "TopBarPanel";
            TopBarPanel.Size = new Size(1515, 125);
            TopBarPanel.TabIndex = 1;
            // 
            // BackBtn
            // 
            BackBtn.Image = Properties.Resources.Back_Button;
            BackBtn.Location = new Point(24, 17);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(104, 84);
            BackBtn.SizeMode = PictureBoxSizeMode.Zoom;
            BackBtn.TabIndex = 10;
            BackBtn.TabStop = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = Properties.Resources.Profile_Icon;
            pictureBox3.Image = Properties.Resources.Profile_Icon;
            pictureBox3.Location = new Point(1388, 27);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(99, 74);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_rhombus_100;
            pictureBox2.Location = new Point(1167, 73);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(232, 160, 0);
            label2.Location = new Point(279, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(246, 32);
            label2.TabIndex = 2;
            label2.Text = "Rent it, Ride it, Love it";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(232, 160, 0);
            label3.Location = new Point(1200, 69);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 44);
            label1.TabIndex = 1;
            label1.Text = "DriveEasy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(34, 34, 34);
            label5.Location = new Point(1188, 28);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(191, 32);
            label5.TabIndex = 7;
            label5.Text = "Employee Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Car_View_Car_Left;
            pictureBox1.Location = new Point(145, 20);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 129);
            label4.Name = "label4";
            label4.Size = new Size(178, 45);
            label4.TabIndex = 2;
            label4.Text = "My Orders";
            // 
            // CarsViewPanel
            // 
            CarsViewPanel.Location = new Point(12, 191);
            CarsViewPanel.Name = "CarsViewPanel";
            CarsViewPanel.Size = new Size(1475, 777);
            CarsViewPanel.TabIndex = 3;
            // 
            // Order_View
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1515, 1008);
            Controls.Add(CarsViewPanel);
            Controls.Add(label4);
            Controls.Add(TopBarPanel);
            Name = "Order_View";
            Text = "Order_View";
            TopBarPanel.ResumeLayout(false);
            TopBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BackBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopBarPanel;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private FlowLayoutPanel CarsViewPanel;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label5;
        private PictureBox BackBtn;
    }
}