using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CarRentalSystem.Forms
{
    partial class Change_Password
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
            lblTitle.Location = new Point(31, 12);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(309, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Change Password";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblSubtitle.Location = new Point(31, 69);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(448, 32);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Enter your current password to continue.";
            // 
            // panelDivider
            // 
            panelDivider.BackColor = Color.FromArgb(235, 235, 235);
            panelDivider.Location = new Point(31, 105);
            panelDivider.Margin = new Padding(4, 4, 4, 4);
            panelDivider.Name = "panelDivider";
            panelDivider.Size = new Size(458, 1);
            panelDivider.TabIndex = 2;
            // 
            // lblCurrentTitle
            // 
            lblCurrentTitle.AutoSize = true;
            lblCurrentTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCurrentTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblCurrentTitle.Location = new Point(31, 110);
            lblCurrentTitle.Margin = new Padding(4, 0, 4, 0);
            lblCurrentTitle.Name = "lblCurrentTitle";
            lblCurrentTitle.Size = new Size(240, 30);
            lblCurrentTitle.TabIndex = 3;
            lblCurrentTitle.Text = "CURRENT PASSWORD";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.BackColor = Color.FromArgb(250, 250, 250);
            txtCurrentPassword.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentPassword.Font = new Font("Segoe UI", 10F);
            txtCurrentPassword.ForeColor = Color.FromArgb(34, 34, 34);
            txtCurrentPassword.Location = new Point(31, 141);
            txtCurrentPassword.Margin = new Padding(4, 4, 4, 4);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '●';
            txtCurrentPassword.Size = new Size(457, 43);
            txtCurrentPassword.TabIndex = 1;
            // 
            // lblNewTitle
            // 
            lblNewTitle.AutoSize = true;
            lblNewTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblNewTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblNewTitle.Location = new Point(31, 188);
            lblNewTitle.Margin = new Padding(4, 0, 4, 0);
            lblNewTitle.Name = "lblNewTitle";
            lblNewTitle.Size = new Size(191, 30);
            lblNewTitle.TabIndex = 4;
            lblNewTitle.Text = "NEW PASSWORD";
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.FromArgb(250, 250, 250);
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Font = new Font("Segoe UI", 10F);
            txtNewPassword.ForeColor = Color.FromArgb(34, 34, 34);
            txtNewPassword.Location = new Point(31, 219);
            txtNewPassword.Margin = new Padding(4, 4, 4, 4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '●';
            txtNewPassword.Size = new Size(457, 43);
            txtNewPassword.TabIndex = 2;
            // 
            // lblConfirmTitle
            // 
            lblConfirmTitle.AutoSize = true;
            lblConfirmTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblConfirmTitle.ForeColor = Color.FromArgb(187, 187, 187);
            lblConfirmTitle.Location = new Point(31, 278);
            lblConfirmTitle.Margin = new Padding(4, 0, 4, 0);
            lblConfirmTitle.Name = "lblConfirmTitle";
            lblConfirmTitle.Size = new Size(298, 30);
            lblConfirmTitle.TabIndex = 5;
            lblConfirmTitle.Text = "CONFIRM NEW PASSWORD";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(250, 250, 250);
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.ForeColor = Color.FromArgb(34, 34, 34);
            txtConfirmPassword.Location = new Point(31, 308);
            txtConfirmPassword.Margin = new Padding(4, 4, 4, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.Size = new Size(457, 43);
            txtConfirmPassword.TabIndex = 3;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 8F);
            lblError.ForeColor = Color.FromArgb(180, 40, 40);
            lblError.Location = new Point(31, 410);
            lblError.Margin = new Padding(4, 0, 4, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 30);
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
            btnConfirm.Location = new Point(31, 410);
            btnConfirm.Margin = new Padding(4, 4, 4, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(720, 65);
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
            btnCancel.Location = new Point(31, 483);
            btnCancel.Margin = new Padding(4, 4, 4, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(720, 58);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Change_Password
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(767, 568);
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
            Margin = new Padding(4, 4, 4, 4);
            Name = "Change_Password";
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