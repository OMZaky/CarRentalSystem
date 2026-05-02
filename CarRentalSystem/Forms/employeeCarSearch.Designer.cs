namespace CarRentalSystem.Forms
{
    partial class employeeCarSearch
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
            panelMain = new Panel();
            btnManage = new Button();
            panelFilters = new Panel();
            dtpToDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            lblToDate = new Label();
            lblFromDate = new Label();
            dash = new Label();
            txtMaxPrice = new TextBox();
            txtMinPrice = new TextBox();
            lblPriceRange = new Label();
            rbRented = new RadioButton();
            rbAvailable = new RadioButton();
            rbAll = new RadioButton();
            lblAvailability = new Label();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            cmbBranch = new ComboBox();
            lblBranch = new Label();
            pictureBox1 = new PictureBox();
            lblAvailableCars = new Label();
            btnReset = new Button();
            btnSearch = new Button();
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelMain.SuspendLayout();
            panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(btnManage);
            panelMain.Controls.Add(panelFilters);
            panelMain.Controls.Add(pictureBox1);
            panelMain.Controls.Add(lblAvailableCars);
            panelMain.Controls.Add(btnReset);
            panelMain.Controls.Add(btnSearch);
            panelMain.Controls.Add(lblSubtitle);
            panelMain.Controls.Add(lblTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(40, 30, 40, 30);
            panelMain.Size = new Size(982, 603);
            panelMain.TabIndex = 0;
            // 
            // btnManage
            // 
            btnManage.BackColor = Color.White;
            btnManage.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManage.ForeColor = Color.Black;
            btnManage.Location = new Point(675, 285);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(251, 46);
            btnManage.TabIndex = 10;
            btnManage.Text = "Manage";
            btnManage.UseVisualStyleBackColor = false;
            btnManage.Click += btnManage_Click;
            // 
            // panelFilters
            // 
            panelFilters.Controls.Add(dtpToDate);
            panelFilters.Controls.Add(dtpFromDate);
            panelFilters.Controls.Add(lblToDate);
            panelFilters.Controls.Add(lblFromDate);
            panelFilters.Controls.Add(dash);
            panelFilters.Controls.Add(txtMaxPrice);
            panelFilters.Controls.Add(txtMinPrice);
            panelFilters.Controls.Add(lblPriceRange);
            panelFilters.Controls.Add(rbRented);
            panelFilters.Controls.Add(rbAvailable);
            panelFilters.Controls.Add(rbAll);
            panelFilters.Controls.Add(lblAvailability);
            panelFilters.Controls.Add(cmbCategory);
            panelFilters.Controls.Add(lblCategory);
            panelFilters.Controls.Add(cmbBranch);
            panelFilters.Controls.Add(lblBranch);
            panelFilters.Location = new Point(26, 69);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(900, 210);
            panelFilters.TabIndex = 2;
            panelFilters.Paint += panelFilters_Paint;
            // 
            // dtpToDate
            // 
            dtpToDate.Font = new Font("Segoe UI", 10F);
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(597, 173);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(123, 30);
            dtpToDate.TabIndex = 19;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Font = new Font("Segoe UI", 10F);
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(450, 170);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(123, 30);
            dtpFromDate.TabIndex = 18;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToDate.ForeColor = Color.Black;
            lblToDate.Location = new Point(597, 144);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(71, 23);
            lblToDate.TabIndex = 17;
            lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFromDate.ForeColor = Color.Black;
            lblFromDate.Location = new Point(450, 144);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(95, 23);
            lblFromDate.TabIndex = 16;
            lblFromDate.Text = "From Date";
            // 
            // dash
            // 
            dash.AutoSize = true;
            dash.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dash.ForeColor = Color.Black;
            dash.Location = new Point(191, 171);
            dash.Name = "dash";
            dash.Size = new Size(20, 28);
            dash.TabIndex = 15;
            dash.Text = "-";
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaxPrice.Location = new Point(217, 173);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.PlaceholderText = "Max price";
            txtMaxPrice.Size = new Size(140, 30);
            txtMaxPrice.TabIndex = 14;
            // 
            // txtMinPrice
            // 
            txtMinPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMinPrice.Location = new Point(44, 173);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.PlaceholderText = "Min price";
            txtMinPrice.Size = new Size(140, 30);
            txtMinPrice.TabIndex = 13;
            // 
            // lblPriceRange
            // 
            lblPriceRange.AutoSize = true;
            lblPriceRange.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceRange.ForeColor = Color.Black;
            lblPriceRange.Location = new Point(70, 147);
            lblPriceRange.Name = "lblPriceRange";
            lblPriceRange.Size = new Size(199, 23);
            lblPriceRange.TabIndex = 12;
            lblPriceRange.Text = "Price Range (EGP / day)";
            lblPriceRange.Click += lblPriceRange_Click;
            // 
            // rbRented
            // 
            rbRented.AutoSize = true;
            rbRented.Checked = true;
            rbRented.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbRented.Location = new Point(226, 117);
            rbRented.Name = "rbRented";
            rbRented.Size = new Size(85, 27);
            rbRented.TabIndex = 11;
            rbRented.TabStop = true;
            rbRented.Text = "Rented";
            rbRented.UseVisualStyleBackColor = true;
            // 
            // rbAvailable
            // 
            rbAvailable.AutoSize = true;
            rbAvailable.Checked = true;
            rbAvailable.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbAvailable.Location = new Point(121, 117);
            rbAvailable.Name = "rbAvailable";
            rbAvailable.Size = new Size(99, 27);
            rbAvailable.TabIndex = 10;
            rbAvailable.TabStop = true;
            rbAvailable.Text = "Available";
            rbAvailable.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            rbAll.AutoSize = true;
            rbAll.Checked = true;
            rbAll.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbAll.Location = new Point(48, 117);
            rbAll.Name = "rbAll";
            rbAll.Size = new Size(50, 27);
            rbAll.TabIndex = 8;
            rbAll.TabStop = true;
            rbAll.Text = "All";
            rbAll.UseVisualStyleBackColor = true;
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailability.ForeColor = Color.Black;
            lblAvailability.Location = new Point(48, 91);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(101, 23);
            lblAvailability.TabIndex = 7;
            lblAvailability.Text = "Availability";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "All Categories", "Economy", "Compact", "SUV", "Luxury", "Van", "Electric" });
            cmbCategory.Location = new Point(438, 47);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(300, 31);
            cmbCategory.TabIndex = 6;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.Black;
            lblCategory.Location = new Point(438, 11);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(84, 23);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            // 
            // cmbBranch
            // 
            cmbBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBranch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBranch.FormattingEnabled = true;
            cmbBranch.Items.AddRange(new object[] { "All Branches", "", "Cairo - Nasr City", "", "Giza - Mohandessin", "", "Alexandria", "Hurghada" });
            cmbBranch.Location = new Point(46, 47);
            cmbBranch.Name = "cmbBranch";
            cmbBranch.Size = new Size(300, 31);
            cmbBranch.TabIndex = 4;
            // 
            // lblBranch
            // 
            lblBranch.AutoSize = true;
            lblBranch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBranch.ForeColor = Color.Black;
            lblBranch.Location = new Point(46, 11);
            lblBranch.Name = "lblBranch";
            lblBranch.Size = new Size(65, 23);
            lblBranch.TabIndex = 3;
            lblBranch.Text = "Branch";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_car_100;
            pictureBox1.Location = new Point(390, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblAvailableCars
            // 
            lblAvailableCars.AutoSize = true;
            lblAvailableCars.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailableCars.ForeColor = Color.Black;
            lblAvailableCars.Location = new Point(31, 335);
            lblAvailableCars.Name = "lblAvailableCars";
            lblAvailableCars.Size = new Size(163, 31);
            lblAvailableCars.TabIndex = 8;
            lblAvailableCars.Text = "Available Cars";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(363, 286);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(251, 46);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset Filters";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Black;
            btnSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(23, 286);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(264, 46);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search Cars";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(34, 29);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(350, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Use the filters below to find your perfect ride";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(31, -11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(298, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Search for a Car";
            // 
            // employeeCarSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 603);
            Controls.Add(panelMain);
            MinimizeBox = false;
            Name = "employeeCarSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "employeeCarSearch";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelFilters.ResumeLayout(false);
            panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Label lblSubtitle;
        private Label lblTitle;
        private Panel panelFilters;
        private ComboBox cmbBranch;
        private Label lblBranch;
        private RadioButton rbAll;
        private Label lblAvailability;
        private ComboBox cmbCategory;
        private Label lblCategory;
        private TextBox txtMinPrice;
        private Label lblPriceRange;
        private RadioButton rbRented;
        private RadioButton rbAvailable;
        private DateTimePicker dtpFromDate;
        private Label lblToDate;
        private Label lblFromDate;
        private Label dash;
        private TextBox txtMaxPrice;
        private Label lblAvailableCars;
        private Button btnReset;
        private Button btnSearch;
        private DateTimePicker dtpToDate;
        private PictureBox pictureBox1;
        private Button btnManage;
    }
}