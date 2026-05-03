namespace CarRentalSystem.Forms
{
    partial class OrderCardControl
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
            CarNameLabel = new Label();
            picCar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            StartDate = new Label();
            EndDate = new Label();
            RentalOrReservationStatus = new Label();
            TierLabel = new Label();
            panel1 = new Panel();
            BranchLabel = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            TotalCostLabel = new Label();
            ExtraFeesLabel = new Label();
            BaseCostLabel = new Label();
            PaymentStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // CarNameLabel
            // 
            CarNameLabel.AutoSize = true;
            CarNameLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            CarNameLabel.Location = new Point(-1, 16);
            CarNameLabel.Margin = new Padding(5, 0, 5, 0);
            CarNameLabel.Name = "CarNameLabel";
            CarNameLabel.Size = new Size(339, 47);
            CarNameLabel.TabIndex = 3;
            CarNameLabel.Text = "Toyota Camry 2023";
            // 
            // picCar
            // 
            picCar.BackColor = Color.WhiteSmoke;
            picCar.Location = new Point(21, 36);
            picCar.Margin = new Padding(5);
            picCar.Name = "picCar";
            picCar.Size = new Size(266, 148);
            picCar.SizeMode = PictureBoxSizeMode.Zoom;
            picCar.TabIndex = 2;
            picCar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 13);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 40);
            label1.TabIndex = 4;
            label1.Text = "Start Date:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 60);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 40);
            label2.TabIndex = 5;
            label2.Text = "Return Date:";
            // 
            // StartDate
            // 
            StartDate.AutoSize = true;
            StartDate.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartDate.Location = new Point(206, 13);
            StartDate.Margin = new Padding(5, 0, 5, 0);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(179, 40);
            StartDate.TabIndex = 6;
            StartDate.Text = "dd/mm/yyyy";
            // 
            // EndDate
            // 
            EndDate.AutoSize = true;
            EndDate.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EndDate.Location = new Point(206, 60);
            EndDate.Margin = new Padding(5, 0, 5, 0);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(179, 40);
            EndDate.TabIndex = 7;
            EndDate.Text = "dd/mm/yyyy";
            EndDate.Click += label4_Click;
            // 
            // RentalOrReservationStatus
            // 
            RentalOrReservationStatus.BackColor = Color.Gainsboro;
            RentalOrReservationStatus.ForeColor = Color.White;
            RentalOrReservationStatus.Location = new Point(1170, 139);
            RentalOrReservationStatus.Name = "RentalOrReservationStatus";
            RentalOrReservationStatus.Size = new Size(210, 76);
            RentalOrReservationStatus.TabIndex = 8;
            RentalOrReservationStatus.Text = "Rental Status";
            RentalOrReservationStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TierLabel
            // 
            TierLabel.AutoSize = true;
            TierLabel.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TierLabel.Location = new Point(5, 76);
            TierLabel.Margin = new Padding(5, 0, 5, 0);
            TierLabel.Name = "TierLabel";
            TierLabel.Size = new Size(192, 40);
            TierLabel.TabIndex = 9;
            TierLabel.Text = "Tier: Standard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BranchLabel);
            panel1.Controls.Add(CarNameLabel);
            panel1.Controls.Add(TierLabel);
            panel1.Location = new Point(297, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 200);
            panel1.TabIndex = 10;
            // 
            // BranchLabel
            // 
            BranchLabel.AutoSize = true;
            BranchLabel.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BranchLabel.Location = new Point(5, 124);
            BranchLabel.Margin = new Padding(5, 0, 5, 0);
            BranchLabel.Name = "BranchLabel";
            BranchLabel.Size = new Size(185, 40);
            BranchLabel.TabIndex = 10;
            BranchLabel.Text = "Branch: Cairo";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(StartDate);
            panel2.Controls.Add(EndDate);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(952, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 116);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(TotalCostLabel);
            panel3.Controls.Add(ExtraFeesLabel);
            panel3.Controls.Add(BaseCostLabel);
            panel3.Location = new Point(660, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 200);
            panel3.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(19, 109);
            panel4.Name = "panel4";
            panel4.Size = new Size(219, 10);
            panel4.TabIndex = 14;
            panel4.Paint += panel4_Paint;
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalCostLabel.Location = new Point(22, 125);
            TotalCostLabel.Margin = new Padding(5, 0, 5, 0);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(205, 40);
            TotalCostLabel.TabIndex = 13;
            TotalCostLabel.Text = "Total Cost: 300";
            // 
            // ExtraFeesLabel
            // 
            ExtraFeesLabel.AutoSize = true;
            ExtraFeesLabel.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExtraFeesLabel.ForeColor = Color.Red;
            ExtraFeesLabel.Location = new Point(22, 61);
            ExtraFeesLabel.Margin = new Padding(5, 0, 5, 0);
            ExtraFeesLabel.Name = "ExtraFeesLabel";
            ExtraFeesLabel.Size = new Size(206, 40);
            ExtraFeesLabel.TabIndex = 12;
            ExtraFeesLabel.Text = "Extra Fees: 100";
            // 
            // BaseCostLabel
            // 
            BaseCostLabel.AutoSize = true;
            BaseCostLabel.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BaseCostLabel.Location = new Point(22, 21);
            BaseCostLabel.Margin = new Padding(5, 0, 5, 0);
            BaseCostLabel.Name = "BaseCostLabel";
            BaseCostLabel.Size = new Size(203, 40);
            BaseCostLabel.TabIndex = 11;
            BaseCostLabel.Text = "Base Cost: 200";
            BaseCostLabel.Click += label8_Click;
            // 
            // PaymentStatus
            // 
            PaymentStatus.BackColor = Color.FromArgb(224, 224, 224);
            PaymentStatus.ForeColor = Color.White;
            PaymentStatus.Location = new Point(952, 139);
            PaymentStatus.Name = "PaymentStatus";
            PaymentStatus.Size = new Size(210, 76);
            PaymentStatus.TabIndex = 13;
            PaymentStatus.Text = "Payment Status";
            PaymentStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderCardControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(PaymentStatus);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(RentalOrReservationStatus);
            Controls.Add(picCar);
            Name = "OrderCardControl";
            Size = new Size(1471, 235);
            Load += OrderCardControl_Load;
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label CarNameLabel;
        private PictureBox picCar;
        private Label label1;
        private Label label2;
        private Label StartDate;
        private Label EndDate;
        private Label RentalOrReservationStatus;
        private Label TierLabel;
        private Panel panel1;
        private Label BranchLabel;
        private Panel panel2;
        private Panel panel3;
        private Label TotalCostLabel;
        private Label ExtraFeesLabel;
        private Label BaseCostLabel;
        private Panel panel4;
        private Label PaymentStatus;
    }
}