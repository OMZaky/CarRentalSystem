namespace CarRentalSystem.Forms
{
    partial class change_password
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelDivider = new Panel();
            lblCurrentTitle = new Label();
            txtCurrentPassword = new TextBox();
            lblNewTitle = new Label();
            txtNewPassword = new TextBox();
            lblConfirmTitle = new Label();
            txtConfirmPassword = new TextBox();
            lblError = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(34, 34, 34);
            lblTitle.Location = new Point(24, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(228, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Change Password";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblSubtitle.Location = new Point(24, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(334, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Enter your current password to continue.";
            // 
            // panelDivider
            // 
            panelDivider.BackColor = Color.FromArgb(235, 235, 235);
            panelDivider.Location = new Point(24, 82);
            panelDivider.Name = "panelDivider";
            panelDivider.Size = new Size(352, 1);
            panelDivider.TabIndex = 2;
            // 
            // lblCurrentTitle
            // 
            lblCurrentTitle.AutoSize = true;
            lblCurrentTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCurrentTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblCurrentTitle.Location = new Point(24, 86);
            lblCurrentTitle.Name = "lblCurrentTitle";
            lblCurrentTitle.Size = new Size(175, 21);
            lblCurrentTitle.TabIndex = 3;
            lblCurrentTitle.Text = "CURRENT PASSWORD";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.BackColor = Color.FromArgb(250, 250, 250);
            txtCurrentPassword.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentPassword.Font = new Font("Segoe UI", 10F);
            txtCurrentPassword.ForeColor = Color.FromArgb(34, 34, 34);
            txtCurrentPassword.Location = new Point(24, 110);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '●';
            txtCurrentPassword.Size = new Size(352, 34);
            txtCurrentPassword.TabIndex = 1;
            // 
            // lblNewTitle
            // 
            lblNewTitle.AutoSize = true;
            lblNewTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblNewTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblNewTitle.Location = new Point(24, 147);
            lblNewTitle.Name = "lblNewTitle";
            lblNewTitle.Size = new Size(140, 21);
            lblNewTitle.TabIndex = 4;
            lblNewTitle.Text = "NEW PASSWORD";
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.FromArgb(250, 250, 250);
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Font = new Font("Segoe UI", 10F);
            txtNewPassword.ForeColor = Color.FromArgb(34, 34, 34);
            txtNewPassword.Location = new Point(24, 171);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '●';
            txtNewPassword.Size = new Size(352, 34);
            txtNewPassword.TabIndex = 2;
            // 
            // lblConfirmTitle
            // 
            lblConfirmTitle.AutoSize = true;
            lblConfirmTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblConfirmTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblConfirmTitle.Location = new Point(24, 217);
            lblConfirmTitle.Name = "lblConfirmTitle";
            lblConfirmTitle.Size = new Size(217, 21);
            lblConfirmTitle.TabIndex = 5;
            lblConfirmTitle.Text = "CONFIRM NEW PASSWORD";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(250, 250, 250);
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.ForeColor = Color.FromArgb(34, 34, 34);
            txtConfirmPassword.Location = new Point(24, 241);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.Size = new Size(352, 34);
            txtConfirmPassword.TabIndex = 3;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 8F);
            lblError.ForeColor = Color.FromArgb(180, 40, 40);
            lblError.Location = new Point(24, 320);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 21);
            lblError.TabIndex = 6;
            lblError.Visible = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(34, 34, 34);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(24, 320);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(554, 51);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.ForeColor = Color.FromArgb(150, 150, 150);
            btnCancel.Location = new Point(24, 377);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(554, 45);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // change_password
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(590, 444);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(panelDivider);
            Controls.Add(lblCurrentTitle);
            Controls.Add(txtCurrentPassword);
            Controls.Add(lblNewTitle);
            Controls.Add(txtNewPassword);
            Controls.Add(lblConfirmTitle);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblError);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Name = "change_password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelDivider;
        private Label lblCurrentTitle;
        private TextBox txtCurrentPassword;
        private Label lblNewTitle;
        private TextBox txtNewPassword;
        private Label lblConfirmTitle;
        private TextBox txtConfirmPassword;
        private Label lblError;
        private Button btnConfirm;
        private Button btnCancel;
    }
}