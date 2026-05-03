using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CarRentalSystem.Core;
using CarRentalSystem.DTOs;
using CarRentalSystem.Services;

namespace CarRentalSystem.Forms
{
    public partial class Order_View : Form
    {
        private OrderService _orderService;

        public Order_View()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;


            _orderService = new OrderService();

            // Ensures the panel scrolls if there are many orders
            CarsViewPanel.AutoScroll = true;
            CarsViewPanel.SizeChanged += CarsViewPanel_SizeChanged;

            LoadOrdersBasedOnRole();
        }

        private void LoadOrdersBasedOnRole()
        {

       


            CarsViewPanel.SuspendLayout();

            // Clear existing cards
            foreach (Control control in CarsViewPanel.Controls)
            {
                control.Dispose();
            }
            CarsViewPanel.Controls.Clear();

            if (UserSession.CurrentUser == null)
            {
                CarsViewPanel.ResumeLayout();
                return;
            }

            List<OrderDTO> ordersToDisplay;

            // Fetch data based on the logged-in user's role
            if (UserSession.CurrentUser.Role == UserRole.Customer)
            {
                label5.Text = UserSession.CurrentUser.FullName;
                label4.Text = "My Orders";
                ordersToDisplay = _orderService.GetCustomerOrders(UserSession.CurrentUser.Id);
            }
            else // Employee, BranchManager, SystemAdmin
            {
                label5.Text = UserSession.CurrentUser.FullName;
                label3.Text = UserSession.CurrentUser.Role.ToString();
                label4.Text = "Recent Global Orders";

                ordersToDisplay = _orderService.GetAllGlobalOrders();
            }

            // Display "Empty State" if no orders exist
            if (ordersToDisplay.Count == 0)
            {
                Label emptyLabel = new Label
                {
                    Text = "No orders found.",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Margin = new Padding(20)
                };
                CarsViewPanel.Controls.Add(emptyLabel);
                CarsViewPanel.ResumeLayout();
                return;
            }

            // Populate the UI with the cards
            foreach (var order in ordersToDisplay)
            {
                var card = new OrderCardControl(order);
                card.Margin = new Padding(10);

                CarsViewPanel.Controls.Add(card);
            }

            CarsViewPanel.ResumeLayout();
        }

        private void CarsViewPanel_SizeChanged(object sender, EventArgs e)
        {
            CarsViewPanel.SuspendLayout();
            foreach (Control card in CarsViewPanel.Controls)
            {
                card.Width = CarsViewPanel.ClientSize.Width - 25;
            }
            CarsViewPanel.ResumeLayout();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}