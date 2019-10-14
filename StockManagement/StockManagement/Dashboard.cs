using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagement.Design;

namespace StockManagement
{
    public partial class Dashboard : Form
    {
        Category category = new Category();


        public Dashboard()
        {
            InitializeComponent();
            DashboardUserControl dashboardUserControl = new DashboardUserControl();
            ShowControl(dashboardUserControl);
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = dashboardButton.Height;
            sideBarPanel.Top = dashboardButton.Top;
            DashboardUserControl dashboardUserControl = new DashboardUserControl();
            ShowControl(dashboardUserControl);
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = categoryButton.Height;
            sideBarPanel.Top = categoryButton.Top;

            CategoryUserControl categoryUserControl = new CategoryUserControl();
            ShowControl(categoryUserControl);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you Want to Exit ?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = productButton.Height;
            sideBarPanel.Top = productButton.Top;

            ProductUserControl productUserControl = new ProductUserControl();
            ShowControl(productUserControl);
        }

        private void ShowControl(Control control)
        {
            contentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            contentPanel.Controls.Add(control);
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = customerButton.Height;
            sideBarPanel.Top = customerButton.Top;

            CustomerUserControl customerUserControl = new CustomerUserControl();
            ShowControl(customerUserControl);
        }

        private void supplierButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = supplierButton.Height;
            sideBarPanel.Top = supplierButton.Top;

            SupplierUserControl supplierUserControl = new SupplierUserControl();
            ShowControl(supplierUserControl);
        }
    }
}
