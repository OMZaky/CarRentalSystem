namespace car_rental_system
{
    partial class employeeSearch
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblSearchLabel = new Label();
            txtSearch = new TextBox();
            lblRoleLabel = new Label();
            cmbRole = new ComboBox();
            btnReset = new Button();
            dataGridView1 = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colHire = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colBranch = new DataGridViewTextBoxColumn();
            lblStatus = new Label();
            btnPrev = new Button();
            lblPage = new Label();
            btnNext = new Button();
            backbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1248, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Rounded MT Bold", 14F);
            label1.Location = new Point(166, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 48);
            label1.TabIndex = 5;
            label1.Text = "DriveEasy";
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = CarRentalSystem.Properties.Resources.Profile_Icon;
            pictureBox3.Image = CarRentalSystem.Properties.Resources.Profile_Icon;
            pictureBox3.Location = new Point(1058, 26);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(99, 74);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = CarRentalSystem.Properties.Resources.icons8_rhombus_100;
            pictureBox2.Location = new Point(837, 72);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(232, 160, 0);
            label4.Location = new Point(870, 68);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(182, 32);
            label4.TabIndex = 2;
            label4.Text = "Employee Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(34, 34, 34);
            label3.Location = new Point(858, 27);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(191, 32);
            label3.TabIndex = 3;
            label3.Text = "Employee Name";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = CarRentalSystem.Properties.Resources.Car_View_Car_Left;
            pictureBox1.Image = CarRentalSystem.Properties.Resources.Car_View_Car_Left;
            pictureBox1.Location = new Point(32, 15);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(232, 160, 0);
            label2.Location = new Point(166, 68);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 29);
            label2.TabIndex = 4;
            label2.Text = "Rent it, Ride it, Love it";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = CarRentalSystem.Properties.Resources.icons8_business_group_80;
            pictureBox4.Location = new Point(31, 143);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Rounded MT Bold", 14F);
            lblTitle.ForeColor = Color.FromArgb(34, 34, 34);
            lblTitle.Location = new Point(91, 145);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(387, 44);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Employee Directory";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(179, 187, 204);
            lblSubtitle.Location = new Point(94, 189);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(519, 32);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "Browse and filter colleagues across all branches";
            // 
            // lblSearchLabel
            // 
            lblSearchLabel.AutoSize = true;
            lblSearchLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSearchLabel.ForeColor = Color.FromArgb(60, 60, 60);
            lblSearchLabel.Location = new Point(31, 229);
            lblSearchLabel.Margin = new Padding(4, 0, 4, 0);
            lblSearchLabel.Name = "lblSearchLabel";
            lblSearchLabel.Size = new Size(89, 32);
            lblSearchLabel.TabIndex = 4;
            lblSearchLabel.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(31, 260);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(389, 43);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblRoleLabel
            // 
            lblRoleLabel.AutoSize = true;
            lblRoleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoleLabel.ForeColor = Color.FromArgb(60, 60, 60);
            lblRoleLabel.Location = new Point(545, 230);
            lblRoleLabel.Margin = new Padding(4, 0, 4, 0);
            lblRoleLabel.Name = "lblRoleLabel";
            lblRoleLabel.Size = new Size(64, 32);
            lblRoleLabel.TabIndex = 6;
            lblRoleLabel.Text = "Role";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 10F);
            cmbRole.Items.AddRange(new object[] { "All Roles", "SystemAdmin", "BranchManager", "RentalAgent" });
            cmbRole.Location = new Point(545, 259);
            cmbRole.Margin = new Padding(4);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(259, 45);
            cmbRole.TabIndex = 7;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(179, 187, 204);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReset.ForeColor = Color.FromArgb(60, 60, 60);
            btnReset.Location = new Point(1028, 257);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(117, 51);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colEmail, colHire, colRole, colBranch });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(230, 230, 230);
            dataGridView1.Location = new Point(31, 323);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 38;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1114, 448);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            // 
            // colID
            // 
            colID.MinimumWidth = 8;
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Width = 150;
            // 
            // colName
            // 
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 150;
            // 
            // colEmail
            // 
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 150;
            // 
            // colHire
            // 
            colHire.MinimumWidth = 8;
            colHire.Name = "colHire";
            colHire.ReadOnly = true;
            colHire.Width = 150;
            // 
            // colRole
            // 
            colRole.MinimumWidth = 8;
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            colRole.Width = 150;
            // 
            // colBranch
            // 
            colBranch.MinimumWidth = 8;
            colBranch.Name = "colBranch";
            colBranch.ReadOnly = true;
            colBranch.Width = 150;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 8.5F);
            lblStatus.ForeColor = Color.FromArgb(179, 187, 204);
            lblStatus.Location = new Point(31, 783);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 31);
            lblStatus.TabIndex = 10;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.White;
            btnPrev.Cursor = Cursors.Hand;
            btnPrev.FlatAppearance.BorderColor = Color.FromArgb(179, 187, 204);
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrev.ForeColor = Color.FromArgb(30, 30, 30);
            btnPrev.Location = new Point(774, 770);
            btnPrev.Margin = new Padding(4);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(104, 83);
            btnPrev.TabIndex = 11;
            btnPrev.Text = "← ";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Font = new Font("Segoe UI", 9F);
            lblPage.ForeColor = Color.FromArgb(60, 60, 60);
            lblPage.Location = new Point(890, 799);
            lblPage.Margin = new Padding(4, 0, 4, 0);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(134, 32);
            lblPage.TabIndex = 12;
            lblPage.Text = "Page 1 of 1";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(30, 30, 30);
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(1041, 771);
            btnNext.Margin = new Padding(4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(104, 83);
            btnNext.TabIndex = 13;
            btnNext.Text = " →";
            btnNext.TextAlign = ContentAlignment.TopCenter;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.White;
            backbtn.Cursor = Cursors.UpArrow;
            backbtn.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            backbtn.FlatStyle = FlatStyle.Flat;
            backbtn.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbtn.ForeColor = Color.Black;
            backbtn.Location = new Point(31, 771);
            backbtn.Margin = new Padding(4);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(130, 82);
            backbtn.TabIndex = 14;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += button1_Click;
            // 
            // employeeSearch
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1248, 909);
            Controls.Add(backbtn);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(txtSearch);
            Controls.Add(cmbRole);
            Controls.Add(btnReset);
            Controls.Add(dataGridView1);
            Controls.Add(lblStatus);
            Controls.Add(btnPrev);
            Controls.Add(lblPage);
            Controls.Add(btnNext);
            Controls.Add(lblRoleLabel);
            Controls.Add(lblSearchLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "employeeSearch";
            Text = "DriveEasy — Employee Directory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // ── Field declarations ────────────────────────────────────────────────
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblRoleLabel;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnNext;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colHire;
        private DataGridViewTextBoxColumn colRole;
        private DataGridViewTextBoxColumn colBranch;
        private Button backbtn;
    }
}