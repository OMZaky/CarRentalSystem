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
            pictureBox3 = new PictureBox();
            CustomerNameLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            CarsViewPanel = new FlowLayoutPanel();
            TopBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TopBarPanel
            // 
            TopBarPanel.BackColor = SystemColors.ButtonFace;
            TopBarPanel.Controls.Add(pictureBox3);
            TopBarPanel.Controls.Add(CustomerNameLabel);
            TopBarPanel.Controls.Add(label2);
            TopBarPanel.Controls.Add(label1);
            TopBarPanel.Controls.Add(pictureBox1);
            TopBarPanel.Dock = DockStyle.Top;
            TopBarPanel.Location = new Point(0, 0);
            TopBarPanel.Margin = new Padding(4);
            TopBarPanel.Name = "TopBarPanel";
            TopBarPanel.Size = new Size(1515, 125);
            TopBarPanel.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Profile_Icon;
            pictureBox3.Location = new Point(1378, 22);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(99, 74);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerNameLabel.ForeColor = Color.FromArgb(34, 34, 34);
            CustomerNameLabel.Location = new Point(1158, 22);
            CustomerNameLabel.Margin = new Padding(4, 0, 4, 0);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(191, 32);
            CustomerNameLabel.TabIndex = 3;
            CustomerNameLabel.Text = "Customer Name";
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Car_View_Car_Left;
            pictureBox1.Location = new Point(32, 15);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopBarPanel;
        private PictureBox pictureBox3;
        private Label CustomerNameLabel;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private FlowLayoutPanel CarsViewPanel;
    }
}