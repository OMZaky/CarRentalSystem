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
            lblSubtitle = new Label();
            lblTitle = new Label();
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
            BackBtn = new PictureBox();
            panelMain.SuspendLayout();
            panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackBtn).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(BackBtn);
            panelMain.Controls.Add(lblSubtitle);
            panelMain.Controls.Add(lblTitle);
            panelMain.Controls.Add(btnManage);
            panelMain.Controls.Add(panelFilters);
            panelMain.Controls.Add(pictureBox1);
            panelMain.Controls.Add(lblAvailableCars);
            panelMain.Controls.Add(btnReset);
            panelMain.Controls.Add(btnSearch);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(5);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(65, 48, 65, 48);
            panelMain.Size = new Size(1596, 965);
            panelMain.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(162, 63);
            lblSubtitle.Margin = new Padding(5, 0, 5, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(574, 38);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Use the filters below to find your perfect ride";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(171, -5);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(482, 81);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Search for a Car";
            // 
            // btnManage
            // 
            btnManage.BackColor = Color.White;
            btnManage.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManage.ForeColor = Color.Black;
            btnManage.Location = new Point(1097, 456);
            btnManage.Margin = new Padding(5);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(408, 74);
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
            panelFilters.Location = new Point(42, 110);
            panelFilters.Margin = new Padding(5);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(1462, 336);
            panelFilters.TabIndex = 2;
            panelFilters.Paint += panelFilters_Paint;
            // 
            // dtpToDate
            // 
            dtpToDate.Font = new Font("Segoe UI", 10F);
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(970, 277);
            dtpToDate.Margin = new Padding(5);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(197, 43);
            dtpToDate.TabIndex = 19;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Font = new Font("Segoe UI", 10F);
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(731, 272);
            dtpFromDate.Margin = new Padding(5);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(197, 43);
            dtpFromDate.TabIndex = 18;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToDate.ForeColor = Color.Black;
            lblToDate.Location = new Point(970, 230);
            lblToDate.Margin = new Padding(5, 0, 5, 0);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(117, 38);
            lblToDate.TabIndex = 17;
            lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFromDate.ForeColor = Color.Black;
            lblFromDate.Location = new Point(731, 230);
            lblFromDate.Margin = new Padding(5, 0, 5, 0);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(156, 38);
            lblFromDate.TabIndex = 16;
            lblFromDate.Text = "From Date";
            // 
            // dash
            // 
            dash.AutoSize = true;
            dash.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dash.ForeColor = Color.Black;
            dash.Location = new Point(310, 274);
            dash.Margin = new Padding(5, 0, 5, 0);
            dash.Name = "dash";
            dash.Size = new Size(33, 45);
            dash.TabIndex = 15;
            dash.Text = "-";
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaxPrice.Location = new Point(353, 277);
            txtMaxPrice.Margin = new Padding(5);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.PlaceholderText = "Max price";
            txtMaxPrice.Size = new Size(225, 44);
            txtMaxPrice.TabIndex = 14;
            // 
            // txtMinPrice
            // 
            txtMinPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMinPrice.Location = new Point(72, 277);
            txtMinPrice.Margin = new Padding(5);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.PlaceholderText = "Min price";
            txtMinPrice.Size = new Size(225, 44);
            txtMinPrice.TabIndex = 13;
            // 
            // lblPriceRange
            // 
            lblPriceRange.AutoSize = true;
            lblPriceRange.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceRange.ForeColor = Color.Black;
            lblPriceRange.Location = new Point(114, 235);
            lblPriceRange.Margin = new Padding(5, 0, 5, 0);
            lblPriceRange.Name = "lblPriceRange";
            lblPriceRange.Size = new Size(326, 38);
            lblPriceRange.TabIndex = 12;
            lblPriceRange.Text = "Price Range (EGP / day)";
            lblPriceRange.Click += lblPriceRange_Click;
            // 
            // rbRented
            // 
            rbRented.AutoSize = true;
            rbRented.Checked = true;
            rbRented.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbRented.Location = new Point(367, 187);
            rbRented.Margin = new Padding(5);
            rbRented.Name = "rbRented";
            rbRented.Size = new Size(135, 42);
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
            rbAvailable.Location = new Point(197, 187);
            rbAvailable.Margin = new Padding(5);
            rbAvailable.Name = "rbAvailable";
            rbAvailable.Size = new Size(158, 42);
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
            rbAll.Location = new Point(78, 187);
            rbAll.Margin = new Padding(5);
            rbAll.Name = "rbAll";
            rbAll.Size = new Size(80, 42);
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
            lblAvailability.Location = new Point(78, 146);
            lblAvailability.Margin = new Padding(5, 0, 5, 0);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(164, 38);
            lblAvailability.TabIndex = 7;
            lblAvailability.Text = "Availability";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "All Categories", "Economy", "Compact", "SUV", "Luxury", "Van", "Electric" });
            cmbCategory.Location = new Point(712, 75);
            cmbCategory.Margin = new Padding(5);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(485, 45);
            cmbCategory.TabIndex = 6;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.Black;
            lblCategory.Location = new Point(712, 18);
            lblCategory.Margin = new Padding(5, 0, 5, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(136, 38);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            // 
            // cmbBranch
            // 
            cmbBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBranch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBranch.FormattingEnabled = true;
            cmbBranch.Items.AddRange(new object[] { "All Branches", "", "Cairo - Nasr City", "", "Giza - Mohandessin", "", "Alexandria", "Hurghada" });
            cmbBranch.Location = new Point(75, 75);
            cmbBranch.Margin = new Padding(5);
            cmbBranch.Name = "cmbBranch";
            cmbBranch.Size = new Size(485, 45);
            cmbBranch.TabIndex = 4;
            // 
            // lblBranch
            // 
            lblBranch.AutoSize = true;
            lblBranch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBranch.ForeColor = Color.Black;
            lblBranch.Location = new Point(75, 18);
            lblBranch.Margin = new Padding(5, 0, 5, 0);
            lblBranch.Name = "lblBranch";
            lblBranch.Size = new Size(108, 38);
            lblBranch.TabIndex = 3;
            lblBranch.Text = "Branch";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_car_100;
            pictureBox1.Location = new Point(1440, 12);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 109);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblAvailableCars
            // 
            lblAvailableCars.AutoSize = true;
            lblAvailableCars.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailableCars.ForeColor = Color.Black;
            lblAvailableCars.Location = new Point(50, 536);
            lblAvailableCars.Margin = new Padding(5, 0, 5, 0);
            lblAvailableCars.Name = "lblAvailableCars";
            lblAvailableCars.Size = new Size(266, 50);
            lblAvailableCars.TabIndex = 8;
            lblAvailableCars.Text = "Available Cars";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(590, 458);
            btnReset.Margin = new Padding(5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(408, 74);
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
            btnSearch.Location = new Point(37, 458);
            btnSearch.Margin = new Padding(5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(429, 74);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search Cars";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // BackBtn
            // 
            BackBtn.Image = Properties.Resources.Back_Button;
            BackBtn.Location = new Point(50, 12);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(104, 84);
            BackBtn.SizeMode = PictureBoxSizeMode.Zoom;
            BackBtn.TabIndex = 11;
            BackBtn.TabStop = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // employeeCarSearch
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1596, 965);
            Controls.Add(panelMain);
            Margin = new Padding(5);
            MinimizeBox = false;
            Name = "employeeCarSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "employeeCarSearch";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelFilters.ResumeLayout(false);
            panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackBtn).EndInit();
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
        private PictureBox BackBtn;
    }
}