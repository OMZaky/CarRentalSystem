namespace CarRentalSystem.Forms
{
    partial class Reservation_Payment
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
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            txtUsername = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            textBox1 = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label4 = new Label();
            textBox2 = new TextBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label5 = new Label();
            textBox3 = new TextBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label6 = new Label();
            textBox4 = new TextBox();
            btnPay = new Button();
            btnCancel = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(230, 45);
            label1.TabIndex = 0;
            label1.Text = "Card Information:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(txtUsername);
            flowLayoutPanel1.Location = new Point(25, 111);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(650, 80);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 40);
            label3.TabIndex = 0;
            label3.Text = "Card Number";
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
            txtUsername.Text = "5410   6837   1273   425";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(textBox1);
            flowLayoutPanel2.Location = new Point(25, 233);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(650, 80);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(300, 40);
            label2.TabIndex = 0;
            label2.Text = "CardHolder Name";
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
            textBox1.Text = "Sam Altman";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Controls.Add(textBox2);
            flowLayoutPanel3.Location = new Point(25, 371);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(150, 80);
            flowLayoutPanel3.TabIndex = 8;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 40);
            label4.TabIndex = 0;
            label4.Text = "Month";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Top;
            textBox2.Location = new Point(3, 43);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 41);
            textBox2.TabIndex = 1;
            textBox2.Text = "05";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel4.Controls.Add(label5);
            flowLayoutPanel4.Controls.Add(textBox3);
            flowLayoutPanel4.Location = new Point(198, 371);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(150, 80);
            flowLayoutPanel4.TabIndex = 9;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 40);
            label5.TabIndex = 0;
            label5.Text = "Year";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Dock = DockStyle.Top;
            textBox3.Location = new Point(3, 43);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 41);
            textBox3.TabIndex = 1;
            textBox3.Text = "30";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel5.Controls.Add(label6);
            flowLayoutPanel5.Controls.Add(textBox4);
            flowLayoutPanel5.Location = new Point(495, 371);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(180, 80);
            flowLayoutPanel5.TabIndex = 10;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.ForeColor = SystemColors.GrayText;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(150, 40);
            label6.TabIndex = 0;
            label6.Text = "CVV";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Dock = DockStyle.Top;
            textBox4.Location = new Point(3, 43);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 41);
            textBox4.TabIndex = 1;
            textBox4.Text = "797";
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.Black;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(25, 500);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(300, 80);
            btnPay.TabIndex = 8;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnConfirmPayment_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Black;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(375, 500);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(300, 80);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Reservation_Payment
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(710, 673);
            Controls.Add(btnCancel);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnPay);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel2);
            Name = "Reservation_Payment";
            Text = "Reservation_Payment";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private TextBox txtUsername;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label4;
        private TextBox textBox2;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label5;
        private TextBox textBox3;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label6;
        private TextBox textBox4;
        private Button btnPay;
        private Button btnCancel;
    }
}