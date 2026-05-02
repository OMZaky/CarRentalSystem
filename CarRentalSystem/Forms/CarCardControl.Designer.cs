namespace CarRentalSystem.Forms
{
    partial class CarCardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picCar = new PictureBox();
            lblName = new Label();
            lblType = new Label();
            lblSeats = new Label();
            lblTransmission = new Label();
            lblAvailability = new Label();
            btnRentNow = new Button();
            lblBranch = new Label();
            lblPrice = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            SuspendLayout();
            // 
            // picCar
            // 
            picCar.BackColor = Color.WhiteSmoke;
            picCar.Location = new Point(32, 40);
            picCar.Margin = new Padding(5, 5, 5, 5);
            picCar.Name = "picCar";
            picCar.Size = new Size(266, 148);
            picCar.SizeMode = PictureBoxSizeMode.Zoom;
            picCar.TabIndex = 0;
            picCar.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblName.Location = new Point(309, 36);
            lblName.Margin = new Padding(5, 0, 5, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(339, 47);
            lblName.TabIndex = 1;
            lblName.Text = "Toyota Camry 2023";
            // 
            // lblType
            // 
            lblType.BackColor = Color.WhiteSmoke;
            lblType.BorderStyle = BorderStyle.FixedSingle;
            lblType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblType.Location = new Point(309, 101);
            lblType.Margin = new Padding(5, 0, 5, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(133, 47);
            lblType.TabIndex = 2;
            lblType.Text = "Sedan";
            lblType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSeats
            // 
            lblSeats.BackColor = Color.WhiteSmoke;
            lblSeats.BorderStyle = BorderStyle.FixedSingle;
            lblSeats.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeats.Location = new Point(474, 101);
            lblSeats.Margin = new Padding(5, 0, 5, 0);
            lblSeats.Name = "lblSeats";
            lblSeats.Size = new Size(125, 48);
            lblSeats.TabIndex = 3;
            lblSeats.Text = "5 seats";
            lblSeats.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTransmission
            // 
            lblTransmission.BackColor = Color.WhiteSmoke;
            lblTransmission.BorderStyle = BorderStyle.FixedSingle;
            lblTransmission.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransmission.Location = new Point(625, 100);
            lblTransmission.Margin = new Padding(5, 0, 5, 0);
            lblTransmission.Name = "lblTransmission";
            lblTransmission.Size = new Size(144, 48);
            lblTransmission.TabIndex = 4;
            lblTransmission.Text = "Automatic";
            lblTransmission.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAvailability
            // 
            lblAvailability.BackColor = Color.Honeydew;
            lblAvailability.BorderStyle = BorderStyle.FixedSingle;
            lblAvailability.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailability.ForeColor = Color.SeaGreen;
            lblAvailability.Location = new Point(790, 100);
            lblAvailability.Margin = new Padding(5, 0, 5, 0);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(150, 48);
            lblAvailability.TabIndex = 5;
            lblAvailability.Text = "● Available";
            lblAvailability.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRentNow
            // 
            btnRentNow.BackColor = Color.FromArgb(32, 32, 32);
            btnRentNow.FlatStyle = FlatStyle.Flat;
            btnRentNow.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRentNow.ForeColor = Color.White;
            btnRentNow.Location = new Point(1034, 120);
            btnRentNow.Margin = new Padding(5, 5, 5, 5);
            btnRentNow.Name = "btnRentNow";
            btnRentNow.Size = new Size(260, 56);
            btnRentNow.TabIndex = 18;
            btnRentNow.Text = "Rent Now";
            btnRentNow.UseVisualStyleBackColor = false;
            btnRentNow.Click += btnRentNow_Click;
            // 
            // lblBranch
            // 
            lblBranch.AutoSize = true;
            lblBranch.ForeColor = Color.Gray;
            lblBranch.Location = new Point(309, 156);
            lblBranch.Margin = new Padding(5, 0, 5, 0);
            lblBranch.Name = "lblBranch";
            lblBranch.Size = new Size(288, 32);
            lblBranch.TabIndex = 20;
            lblBranch.Text = "Branch: Cairo — Nasr City";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(30, 30, 30);
            lblPrice.Location = new Point(1030, 27);
            lblPrice.Margin = new Padding(5, 0, 5, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(264, 54);
            lblPrice.TabIndex = 21;
            lblPrice.Text = "650 EGP/day";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(232, 160, 0);
            lblTotal.Location = new Point(1080, 83);
            lblTotal.Margin = new Padding(5, 0, 5, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(189, 32);
            lblTotal.TabIndex = 22;
            lblTotal.Text = "3,250 EGP total";
            // 
            // CarCardControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblTotal);
            Controls.Add(lblPrice);
            Controls.Add(lblBranch);
            Controls.Add(btnRentNow);
            Controls.Add(lblAvailability);
            Controls.Add(lblTransmission);
            Controls.Add(lblSeats);
            Controls.Add(lblType);
            Controls.Add(lblName);
            Controls.Add(picCar);
            Margin = new Padding(5, 5, 5, 5);
            Name = "CarCardControl";
            Size = new Size(1459, 211);
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picCar;
        private Label lblName;
        private Label lblType;
        private Label lblSeats;
        private Label lblTransmission;
        private Label lblAvailability;
        private Button btnRentNow;
        private Label lblBranch;
        private Label lblPrice;
        private Label lblTotal;
    }
}
