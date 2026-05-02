namespace CarRentalSystem.Forms
{
    partial class Email_Verification
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
            label2 = new Label();
            txtCode = new TextBox();
            btnContinue = new Button();
            OTPErrorLabel = new Label();
            ResendBtn = new Button();
            BackBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BackBtn).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 85);
            label1.Name = "label1";
            label1.Size = new Size(565, 39);
            label1.TabIndex = 1;
            label1.Text = "A verification code (OTP) has been sent to you email.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(372, 145);
            label2.Name = "label2";
            label2.Size = new Size(417, 39);
            label2.TabIndex = 2;
            label2.Text = "Check it to complete your Registration";
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.White;
            txtCode.BorderStyle = BorderStyle.FixedSingle;
            txtCode.Location = new Point(362, 216);
            txtCode.Multiline = true;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(427, 71);
            txtCode.TabIndex = 4;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.Black;
            btnContinue.FlatAppearance.BorderSize = 0;
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContinue.ForeColor = Color.White;
            btnContinue.Location = new Point(614, 375);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(427, 80);
            btnContinue.TabIndex = 19;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = false;
            // 
            // OTPErrorLabel
            // 
            OTPErrorLabel.AutoSize = true;
            OTPErrorLabel.ForeColor = Color.Red;
            OTPErrorLabel.Location = new Point(362, 302);
            OTPErrorLabel.Name = "OTPErrorLabel";
            OTPErrorLabel.Size = new Size(203, 32);
            OTPErrorLabel.TabIndex = 20;
            OTPErrorLabel.Text = "OTP is not correct";
            // 
            // ResendBtn
            // 
            ResendBtn.BackColor = Color.Black;
            ResendBtn.FlatAppearance.BorderSize = 0;
            ResendBtn.FlatStyle = FlatStyle.Flat;
            ResendBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResendBtn.ForeColor = Color.White;
            ResendBtn.Location = new Point(95, 375);
            ResendBtn.Name = "ResendBtn";
            ResendBtn.Size = new Size(427, 80);
            ResendBtn.TabIndex = 21;
            ResendBtn.Text = "Resend";
            ResendBtn.UseVisualStyleBackColor = false;
            // 
            // BackBtn
            // 
            BackBtn.Image = Properties.Resources.Back_Button;
            BackBtn.Location = new Point(23, 12);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(104, 84);
            BackBtn.SizeMode = PictureBoxSizeMode.Zoom;
            BackBtn.TabIndex = 22;
            BackBtn.TabStop = false;
            // 
            // Email_Verification
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 535);
            Controls.Add(BackBtn);
            Controls.Add(ResendBtn);
            Controls.Add(OTPErrorLabel);
            Controls.Add(btnContinue);
            Controls.Add(txtCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Email_Verification";
            Text = "Email_Verification";
            Load += Email_Verification_Load;
            ((System.ComponentModel.ISupportInitialize)BackBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCode;
        private Button btnContinue;
        private Label OTPErrorLabel;
        private Button ResendBtn;
        private PictureBox BackBtn;
    }
}