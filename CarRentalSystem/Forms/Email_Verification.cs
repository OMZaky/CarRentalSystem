using CarRentalSystem.DTOs; // Needed for the backpack
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Configuration; // Add this to the top

namespace CarRentalSystem.Forms
{
    public partial class Email_Verification : Form
    {
        private RegistrationDTO _userData; // The backpack
        private string _generatedCode;     // The secret 6-digit code

        public Email_Verification(RegistrationDTO userData)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;


            _userData = userData;

            btnContinue.Click += btnVerify_Click;
            ResendBtn.Click += btnResend_Click;
            BackBtn.Click += BackBtn_Click;
            txtCode.KeyDown += txtCode_KeyDown;

            // Automatically send the email as soon as this form opens!
            SendVerificationEmail();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnContinue.PerformClick();
            }
        }

        private void SendVerificationEmail()
        {
            // 1. Generate a random 6-digit number
            Random rand = new Random();
            _generatedCode = rand.Next(100000, 999999).ToString();

            try
            {
                // 2. Set up the Email message
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("your_email@gmail.com"); // YOUR Gmail
                mail.To.Add(_userData.Email);                        // The customer's email
                mail.Subject = "DriveEasy - Your Verification Code";
                mail.Body = $"Hello {_userData.FirstName},\n\nYour 6-digit verification code is: {_generatedCode}\n\nPlease enter this code in the application to continue.";

                // 3. Connect to Google's Free SMTP Server
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.EnableSsl = true; // Crucial for Gmail security

                string email = ConfigurationManager.AppSettings["GmailAddress"]!;
                string pass = ConfigurationManager.AppSettings["GmailAppPassword"]!;

                smtp.Credentials = new NetworkCredential(email, pass);

                // 4. Send it!
                smtp.Send(mail);
                MessageBox.Show($"Verification code sent to {_userData.Email}!", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. Check your internet connection or App Password.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string userInput = txtCode.Text.Trim();

            if (userInput == _generatedCode)
            {
                MessageBox.Show("Email successfully verified!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hide the verification screen
                this.Hide();

                // Open the final step, passing the "backpack" forward again!
                using (var finalStep = new Final_Registration(_userData))
                {
                    DialogResult finalResult = finalStep.ShowDialog();

                    if (finalResult == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else if (finalResult == DialogResult.Abort)
                    {
                        // They clicked Cancel on the Final screen! Pass the Abort signal backward.
                        this.DialogResult = DialogResult.Abort;
                        this.Close();
                    }
                    else
                    {
                        // Show this OTP page again ONLY if they clicked the Back Arrow
                        this.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect code. Please try again.", "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Add a button allowing them to resend if they didn't get it
        private void btnResend_Click(object sender, EventArgs e)
        {
            SendVerificationEmail();
        }

        private void Email_Verification_Load(object sender, EventArgs e)
        {

        }
    }
}