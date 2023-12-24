using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

           
              

        private void SlidingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerInfo_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(CustomerUserControl.Instance))
            {
                ContentPanel.Controls.Add(CustomerUserControl.Instance);
                CustomerUserControl.Instance.Dock = DockStyle.Fill;
                CustomerUserControl.Instance.BringToFront();
            }
            else
            {
                CustomerUserControl.Instance.BringToFront();
            }
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cars_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(CarUserControl.Instance))
            {
                ContentPanel.Controls.Add(CarUserControl.Instance);
                CarUserControl.Instance.Dock= DockStyle.Fill;
                CarUserControl.Instance.BringToFront();
            }
            else
            {
                CarUserControl.Instance.BringToFront();
            }   
        }

        private void Rent_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(RentUserControl1.Instance))
            {
                ContentPanel.Controls.Add(RentUserControl1.Instance);
                RentUserControl1.Instance.Dock = DockStyle.Fill;
                RentUserControl1.Instance.BringToFront();
            }
            else
            {
                RentUserControl1.Instance.BringToFront();
            }
        }

        private void Service_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(ServiceUserControl.Instance))
            {
                ContentPanel.Controls.Add(ServiceUserControl.Instance);
                ServiceUserControl.Instance.Dock = DockStyle.Fill;
                ServiceUserControl.Instance.BringToFront();
            }
            else
            {
                ServiceUserControl.Instance.BringToFront();
            }

        }

        private void RTOReg_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(RTOUserControl.Instance))
            {
                ContentPanel.Controls.Add(RTOUserControl.Instance);
                RTOUserControl.Instance.Dock = DockStyle.Fill;
                RTOUserControl.Instance.BringToFront();
            }
            else
            {
                RTOUserControl.Instance.BringToFront();
            }

        }

        private void Retail_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(RetailUserControl.Instance))
            {
                ContentPanel.Controls.Add(RetailUserControl.Instance);
                RetailUserControl.Instance.Dock = DockStyle.Fill;
                RetailUserControl.Instance.BringToFront();
            }
            else
            {
                RetailUserControl.Instance.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(CustomerUserControl.Instance))
            {
                ContentPanel.Controls.Add(CustomerUserControl.Instance);
                CustomerUserControl.Instance.Dock = DockStyle.Fill;
                CustomerUserControl.Instance.BringToFront();
            }
            else
            {
                CustomerUserControl.Instance.BringToFront();
            }

        }

        private void QuickAccess_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(QuickAccessUserControl.Instance))
            {
                ContentPanel.Controls.Add(QuickAccessUserControl.Instance);
                QuickAccessUserControl.Instance.Dock = DockStyle.Fill;
                QuickAccessUserControl.Instance.BringToFront();
            }
            else
            {
                QuickAccessUserControl.Instance.BringToFront();
            }
        }
    }
}

