
namespace car_rental_system.Forms
{
    partial class Customer_Car_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Car_Search));
            pnFilters = new Panel();
            btnReset = new Button();
            btnSearch = new Button();
            dtpReturn = new DateTimePicker();
            label6 = new Label();
            dtpPickup = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            lblPrice = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            cmbCategory = new ComboBox();
            label1 = new Label();
            lblFilterTitle = new Label();
            pnlFilterRightBorder = new Panel();
            pnlResults = new Panel();
            flowCars = new FlowLayoutPanel();
            cmbSort = new ComboBox();
            lblSort = new Label();
            lblResultsCount = new Label();
            lblDateSummary = new Label();
            lblWelcome = new Label();
            lblSlogan = new Label();
            lblName = new Label();
            picLogo = new PictureBox();
            pnFilters.SuspendLayout();
            pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnFilters
            // 
            pnFilters.BackColor = Color.FromArgb(250, 250, 250);
            pnFilters.Controls.Add(btnReset);
            pnFilters.Controls.Add(btnSearch);
            pnFilters.Controls.Add(dtpReturn);
            pnFilters.Controls.Add(label6);
            pnFilters.Controls.Add(dtpPickup);
            pnFilters.Controls.Add(label5);
            pnFilters.Controls.Add(label4);
            pnFilters.Controls.Add(textBox3);
            pnFilters.Controls.Add(textBox1);
            pnFilters.Controls.Add(lblPrice);
            pnFilters.Controls.Add(comboBox2);
            pnFilters.Controls.Add(label3);
            pnFilters.Controls.Add(comboBox1);
            pnFilters.Controls.Add(label2);
            pnFilters.Controls.Add(cmbCategory);
            pnFilters.Controls.Add(label1);
            pnFilters.Controls.Add(lblFilterTitle);
            pnFilters.Controls.Add(pnlFilterRightBorder);
            pnFilters.Dock = DockStyle.Left;
            pnFilters.Location = new Point(0, 0);
            pnFilters.Name = "pnFilters";
            pnFilters.Size = new Size(210, 873);
            pnFilters.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.Gray;
            btnReset.Location = new Point(19, 784);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(170, 36);
            btnReset.TabIndex = 18;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += button2_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(32, 32, 32);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(17, 720);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(170, 42);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtpReturn
            // 
            dtpReturn.Location = new Point(19, 645);
            dtpReturn.Name = "dtpReturn";
            dtpReturn.Size = new Size(150, 27);
            dtpReturn.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(19, 622);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 15;
            label6.Text = "RETURN DATE";
            // 
            // dtpPickup
            // 
            dtpPickup.Location = new Point(18, 542);
            dtpPickup.Name = "dtpPickup";
            dtpPickup.Size = new Size(150, 27);
            dtpPickup.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(18, 519);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 13;
            label5.Text = "PICK-UP DATE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(80, 446);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 12;
            label4.Text = "—";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(118, 442);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(51, 27);
            textBox3.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 442);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(51, 27);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPrice.ForeColor = Color.DarkGray;
            lblPrice.Location = new Point(18, 391);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(139, 20);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "PRICE / DAY (EGP)";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 10F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "All Categories", "Sedan", "SUV", "Luxury" });
            comboBox2.Location = new Point(18, 291);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 31);
            comboBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(17, 268);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 6;
            label3.Text = "BRANCH";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All Categories", "Sedan", "SUV", "Luxury" });
            comboBox1.Location = new Point(18, 180);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 31);
            comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(18, 157);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 4;
            label2.Text = "TRANSMISSION";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "All Categories", "Sedan", "SUV", "Luxury" });
            cmbCategory.Location = new Point(18, 93);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 31);
            cmbCategory.TabIndex = 3;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(18, 70);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 2;
            label1.Text = "CATEGORY";
            label1.Click += label1_Click;
            // 
            // lblFilterTitle
            // 
            lblFilterTitle.AutoSize = true;
            lblFilterTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblFilterTitle.Location = new Point(18, 25);
            lblFilterTitle.Name = "lblFilterTitle";
            lblFilterTitle.Size = new Size(119, 25);
            lblFilterTitle.TabIndex = 1;
            lblFilterTitle.Text = "FILTER CARS";
            lblFilterTitle.Click += lblFilterTitle_Click;
            // 
            // pnlFilterRightBorder
            // 
            pnlFilterRightBorder.BackColor = Color.Gainsboro;
            pnlFilterRightBorder.Dock = DockStyle.Right;
            pnlFilterRightBorder.Location = new Point(209, 0);
            pnlFilterRightBorder.Name = "pnlFilterRightBorder";
            pnlFilterRightBorder.Size = new Size(1, 873);
            pnlFilterRightBorder.TabIndex = 0;
            // 
            // pnlResults
            // 
            pnlResults.BackColor = Color.White;
            pnlResults.Controls.Add(flowCars);
            pnlResults.Controls.Add(cmbSort);
            pnlResults.Controls.Add(lblSort);
            pnlResults.Controls.Add(lblResultsCount);
            pnlResults.Controls.Add(lblDateSummary);
            pnlResults.Controls.Add(lblWelcome);
            pnlResults.Controls.Add(lblSlogan);
            pnlResults.Controls.Add(lblName);
            pnlResults.Controls.Add(picLogo);
            pnlResults.Dock = DockStyle.Fill;
            pnlResults.Location = new Point(210, 0);
            pnlResults.Name = "pnlResults";
            pnlResults.Size = new Size(992, 873);
            pnlResults.TabIndex = 1;
            pnlResults.Paint += pnlResults_Paint;
            // 
            // flowCars
            // 
            flowCars.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowCars.AutoScroll = true;
            flowCars.FlowDirection = FlowDirection.TopDown;
            flowCars.Location = new Point(30, 145);
            flowCars.Name = "flowCars";
            flowCars.Size = new Size(930, 680);
            flowCars.TabIndex = 8;
            flowCars.WrapContents = false;
            flowCars.Paint += flowCars_Paint;
            // 
            // cmbSort
            // 
            cmbSort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.Font = new Font("Segoe UI", 10F);
            cmbSort.FormattingEnabled = true;
            cmbSort.Items.AddRange(new object[] { "Price: Low to High", "", "Price: High to Low", "", "Newest First" });
            cmbSort.Location = new Point(735, 100);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(210, 31);
            cmbSort.TabIndex = 7;
            // 
            // lblSort
            // 
            lblSort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSort.AutoSize = true;
            lblSort.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSort.ForeColor = Color.DarkGray;
            lblSort.Location = new Point(690, 105);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(45, 23);
            lblSort.TabIndex = 6;
            lblSort.Text = "Sort:";
            // 
            // lblResultsCount
            // 
            lblResultsCount.AutoSize = true;
            lblResultsCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultsCount.ForeColor = Color.Gray;
            lblResultsCount.Location = new Point(30, 105);
            lblResultsCount.Name = "lblResultsCount";
            lblResultsCount.Size = new Size(236, 23);
            lblResultsCount.TabIndex = 5;
            lblResultsCount.Text = "6 cars available for your dates";
            // 
            // lblDateSummary
            // 
            lblDateSummary.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateSummary.AutoSize = true;
            lblDateSummary.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateSummary.ForeColor = Color.DarkGray;
            lblDateSummary.Location = new Point(770, 53);
            lblDateSummary.Name = "lblDateSummary";
            lblDateSummary.Size = new Size(169, 20);
            lblDateSummary.TabIndex = 4;
            lblDateSummary.Text = "Apr 30 — May 5 · 5 days";
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(30, 30, 30);
            lblWelcome.Location = new Point(770, 27);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(141, 28);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Welcome, Os!";
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = true;
            lblSlogan.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSlogan.ForeColor = Color.FromArgb(232, 160, 0);
            lblSlogan.Location = new Point(87, 52);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(147, 17);
            lblSlogan.TabIndex = 2;
            lblSlogan.Text = "Rent it, Ride it, Love it";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(30, 30, 30);
            lblName.Location = new Point(89, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(117, 31);
            lblName.TabIndex = 1;
            lblName.Text = "DriveEasy";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(35, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(51, 58);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 873);
            Controls.Add(pnlResults);
            Controls.Add(pnFilters);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Car Search";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Browse Cars — Car Rental System";
            pnFilters.ResumeLayout(false);
            pnFilters.PerformLayout();
            pnlResults.ResumeLayout(false);
            pnlResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnFilters;
        private Panel pnlFilterRightBorder;
        private Label lblFilterTitle;
        private Label label1;
        private ComboBox cmbCategory;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private Label lblPrice;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private DateTimePicker dtpPickup;
        private Button btnSearch;
        private DateTimePicker dtpReturn;
        private Label label6;
        private Button btnReset;
        private Panel pnlResults;
        private PictureBox picLogo;
        private Label lblName;
        private Label lblWelcome;
        private Label lblSlogan;
        private ComboBox cmbSort;
        private Label lblSort;
        private Label lblResultsCount;
        private Label lblDateSummary;
        private FlowLayoutPanel flowCars;
    }
}
