using CarRentalSystem;
using CarRentalSystem.Core;
using CarRentalSystem.DTOs;
using CarRentalSystem.Forms;
using CarRentalSystem.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace car_rental_system
{
    public partial class employeeSearch : Form
    {
        // Pagination state 
        private const int PageSize = 10;
        private int _currentPage = 1;
        private List<employeeDTO> _filtered = new List<employeeDTO>();

        // Skeleton timer 
        private Timer _skeletonTimer = null!;
        private int _skeletonFrame = 0;
        private bool _loading = false;


        private List<employeeDTO> _allEmployees;
        public employeeSearch()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;


            SetupSkeletonTimer();
            this.Load += (s, e) => ShowSkeletonThenLoad();
            var EmpSession = new EmpSearchService();
            _allEmployees = EmpSession.SearchEmployees();

        }

        //  SKELETON
        private void SetupSkeletonTimer()
        {

            var user = UserSession.CurrentUser;

            if (user != null)
            {
                label3.Text = user.FullName;
                label4.Text = user.Role.ToString();
            }
            else
            {
                label3.Text = "Guest User";
                label4.Text = "Unknown Role";
            }

            _skeletonTimer = new Timer { Interval = 350 };
            _skeletonTimer.Tick += (s, e) =>
            {
                _skeletonFrame = (_skeletonFrame + 1) % 3;
                dataGridView1.Invalidate();
            };
        }

        private void ShowSkeletonThenLoad()
        {
            _loading = true;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < PageSize; i++)
                dataGridView1.Rows.Add("", "", "", "", "", "");
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
            lblStatus.Text = "Loading…";
            _skeletonTimer.Start();

            // Short delay so the skeleton is actually visible on open
            var delay = new Timer { Interval = 750 };
            delay.Tick += (s, e) =>
            {
                delay.Stop();
                _loading = false;
                _skeletonTimer.Stop();
                ApplyFilter();
            };
            delay.Start();
        }

        //  FILTER + BIND
        private void ApplyFilter()
        {
            string search = txtSearch.Text.Trim().ToLower();
            string role = cmbRole.SelectedIndex > 0 ? cmbRole.SelectedItem.ToString() : null;

            _filtered = _allEmployees
                .Where(e =>
                    (string.IsNullOrEmpty(search) ||
                     e.FullName.ToLower().Contains(search) ||
                     e.Email.ToLower().Contains(search) ||
                     e.Id.ToString().ToLower().Contains(search))
                    &&
                    (role == null || e.Role.ToString() == role.ToString()))
                .ToList();

            BindPage();
        }

        private void BindPage()
        {
            if (_currentPage > TotalPages) _currentPage = Math.Max(1, TotalPages);

            var page = _filtered
                .Skip((_currentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            dataGridView1.Rows.Clear();
            foreach (var emp in page)
                dataGridView1.Rows.Add(emp.Id, emp.FullName, emp.Email, emp.HireDate, emp.Role, emp.Branch);

            int total = _filtered.Count;
            int showing = page.Count;
            int start = (_currentPage - 1) * PageSize + (showing > 0 ? 1 : 0);
            int end = (_currentPage - 1) * PageSize + showing;

            lblStatus.Text = total == 0 ? "No employees found." : $"    Showing {start}–{end} of {total} employees";
            lblPage.Text = $"Page {_currentPage} of {Math.Max(1, TotalPages)}";
            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < TotalPages;
        }

        private int TotalPages => Math.Max(1, (int)Math.Ceiling((double)_filtered.Count / PageSize));

        //  EVENT HANDLERS
        private void txtSearch_TextChanged(object sender, EventArgs e) { _currentPage = 1; ApplyFilter(); }
        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e) { _currentPage = 1; ApplyFilter(); }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cmbRole.SelectedIndex = 0;
            _currentPage = 1;
            ApplyFilter();
        }

        private void btnPrev_Click(object sender, EventArgs e) { if (_currentPage > 1) { _currentPage--; BindPage(); } }
        private void btnNext_Click(object sender, EventArgs e) { if (_currentPage < TotalPages) { _currentPage++; BindPage(); } }

        //  CUSTOM CELL PAINTING — skeleton shimmer + role badge
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // ── Skeleton shimmer ─────────────────────────────────────────────
            if (_loading)
            {
                e.PaintBackground(e.ClipBounds, true);
                int[] alphas = { 38, 68, 38 };
                int alpha = alphas[(_skeletonFrame + e.RowIndex) % 3];
                int margin = 12, barH = 14;
                int barY = e.CellBounds.Y + (e.CellBounds.Height - barH) / 2;
                int barW = e.CellBounds.Width - margin * 2 - (e.ColumnIndex % 3) * 12;
                if (barW > 0)
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    using var brush = new SolidBrush(Color.FromArgb(alpha, 180, 180, 180));
                    using var gp = new GraphicsPath();
                    AddRoundedRect(gp, e.CellBounds.X + margin, barY, barW, barH, 4);
                    e.Graphics.FillPath(brush, gp);
                }
                e.Handled = true;
                return;
            }

            // ── Role badge (column index 4) ──────────────────────────────────
            if (e.ColumnIndex == 4)
            {
                e.PaintBackground(e.ClipBounds, true);
                string role = e.Value?.ToString() ?? "";
                Color bg, fg;
                switch (role)
                {
                    case "Manager": bg = Color.FromArgb(219, 234, 254); fg = Color.FromArgb(30, 64, 175); break;
                    case "Employee": bg = Color.FromArgb(220, 252, 231); fg = Color.FromArgb(22, 101, 52); break;

                    default: bg = Color.FromArgb(229, 231, 235); fg = Color.FromArgb(55, 65, 81); break;
                }

                using var font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
                SizeF sz = e.Graphics.MeasureString(role, font);
                int px = 10, py = 3;
                int bw = (int)sz.Width + px * 2;
                int bh = (int)sz.Height + py * 2;
                int bx = e.CellBounds.X + (e.CellBounds.Width - bw) / 2;
                int by = e.CellBounds.Y + (e.CellBounds.Height - bh) / 2;

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var gp = new GraphicsPath())
                {
                    AddRoundedRect(gp, bx, by, bw, bh, 8);
                    e.Graphics.FillPath(new SolidBrush(bg), gp);
                }
                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                e.Graphics.DrawString(role, font, new SolidBrush(fg), new RectangleF(bx, by, bw, bh), sf);
                e.Handled = true;
            }
        }

        private static void AddRoundedRect(GraphicsPath gp, int x, int y, int w, int h, int r)
        {
            gp.AddArc(x, y, r, r, 180, 90);
            gp.AddArc(x + w - r, y, r, r, 270, 90);
            gp.AddArc(x + w - r, y + h - r, r, r, 0, 90);
            gp.AddArc(x, y + h - r, r, r, 90, 90);
            gp.CloseAllFigures();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if the user actually selected a row
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var idValue = selectedRow.Cells["colID"].Value;

                // Skip if it's an empty skeleton row or header
                if (idValue == null || string.IsNullOrWhiteSpace(idValue.ToString())) return;

                int empId = Convert.ToInt32(idValue);
                string empName = selectedRow.Cells["colName"].Value.ToString() ?? "this employee";

                // Confirmation Dialog
                var result = MessageBox.Show($"Are you sure you want to delete {empName}?",
                                             "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    var service = new EmpSearchService();
                    service.DeleteEmployee(empId);

                    // Remove from the master list
                    var employee = _allEmployees.FirstOrDefault(x => x.Id == empId);
                    if (employee != null)
                    {
                        _allEmployees.Remove(employee);

                        // Update the UI
                        ApplyFilter();
                        MessageBox.Show("Employee removed successfully.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a full row from the list first.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1. Open the data collection form
            using (var addForm = new AddEmployee()) // Assuming you named it this
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // 2. Retrieve the new object created by the sub-form
                    var newEmp = addForm.NewEmployeeData;

                    // 3. Add to our master list
                    _allEmployees.Add(newEmp);

                    // 4. Refresh the grid to show the new person
                    ApplyFilter();
                }
            }
        }
    }



    // ── Data class ───────────────────────────────────────────────────────────
    public class EmployeeRow
    {
        public string? EmployeeID { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? HireDate { get; set; }
        public string? Role { get; set; }
        public string? BranchID { get; set; }
    }
}