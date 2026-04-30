namespace CarRentalSystem
{
    partial class Login_Page_V1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page_V1));
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            textBox1 = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label4 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift Condensed", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(726, 253);
            label1.Name = "label1";
            label1.Size = new Size(204, 64);
            label1.TabIndex = 3;
            label1.Text = "Welcome! ";
            label1.Click += label1_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(643, 331);
            label2.Name = "label2";
            label2.Size = new Size(367, 58);
            label2.TabIndex = 4;
            label2.Text = "Sign into you account";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Location = new Point(523, 439);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(590, 80);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Century Gothic", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 40);
            label3.TabIndex = 0;
            label3.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
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
            flowLayoutPanel2.BackColor = Color.LightGray;
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(textBox2);
            flowLayoutPanel2.Location = new Point(523, 580);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(590, 86);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Century Gothic", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            textBox2.BackColor = Color.LightGray;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Top;
            textBox2.Font = new Font("Century Gothic", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(3, 43);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(462, 41);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(523, 727);
            button1.Name = "button1";
            button1.Size = new Size(590, 84);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // Login_Page_V1
            // 
            AutoScaleDimensions = new SizeF(16F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1574, 996);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Century Gothic", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Login_Page_V1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label4;
        private TextBox textBox2;
        private Button button1;
    }
}
