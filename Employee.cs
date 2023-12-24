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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }


        private void Service_Click(object sender, EventArgs e)
        {
            if (!ControlPanel.Controls.Contains(ServiceUserControl.Instance))
            {
                ControlPanel.Controls.Add(ServiceUserControl.Instance);
                ServiceUserControl.Instance.Dock = DockStyle.Fill;
                ServiceUserControl.Instance.BringToFront();
            }
            else
            {
                ServiceUserControl.Instance.BringToFront();
            }

        }

        private void Cars_Click(object sender, EventArgs e)
        {
            if (!ControlPanel.Controls.Contains(CarUserControl.Instance))
            {
                ControlPanel.Controls.Add(CarUserControl.Instance);
                CarUserControl.Instance.Dock = DockStyle.Fill;
                CarUserControl.Instance.BringToFront();
            }
            else
            {
                CarUserControl.Instance.BringToFront();
            }

        }

        private void CarMod_Click(object sender, EventArgs e)
        {
            if (!ControlPanel.Controls.Contains(ModUserControlcust.Instance))
            {
                ControlPanel.Controls.Add(ModUserControlcust.Instance);
                ModUserControlcust.Instance.Dock = DockStyle.Fill;
                ModUserControlcust.Instance.BringToFront();
            }
            else
            {
                ModUserControlcust.Instance.BringToFront();
            }

        }

        private void Retail_Click(object sender, EventArgs e)
        {
            if (!ControlPanel.Controls.Contains(RetailUserControl.Instance))
            {
                ControlPanel.Controls.Add(RetailUserControl.Instance);
                RetailUserControl.Instance.Dock = DockStyle.Fill;
                RetailUserControl.Instance.BringToFront();
            }
            else
            {
                RetailUserControl.Instance.BringToFront();
            }

        }

        private void SlidingPanelToggleButton_Click(object sender, EventArgs e)
        {
            if (!ControlPanel.Controls.Contains(EmployeeQAUserControl.Instance))
            {
                ControlPanel.Controls.Add(EmployeeQAUserControl.Instance);
                EmployeeQAUserControl.Instance.Dock = DockStyle.Fill;
                EmployeeQAUserControl.Instance.BringToFront();
            }
            else
            {
                EmployeeQAUserControl.Instance.BringToFront();
            }
        }
    }
}
