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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
             


        private void SlidingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cars_Click(object sender, EventArgs e)
        {

            if (!ControlPanel.Controls.Contains(CCarUserControl1.Instance))
            {
                ControlPanel.Controls.Add(CCarUserControl1.Instance);
                CCarUserControl1.Instance.Dock = DockStyle.Fill;
                CCarUserControl1.Instance.BringToFront();
            }
            else
            {
                CCarUserControl1.Instance.BringToFront();
            }
        }

        private void RTO_Click(object sender, EventArgs e)
        {
            if (!ControlPanel.Controls.Contains(RTOCUserControl.Instance))
            {
                ControlPanel.Controls.Add(RTOCUserControl.Instance);
                RTOCUserControl.Instance.Dock = DockStyle.Fill;
                RTOCUserControl.Instance.BringToFront();
            }
            else
            {
                RTOCUserControl.Instance.BringToFront();
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (!ControlPanel.Controls.Contains(RentUserControl1.Instance))
            {
                ControlPanel.Controls.Add(RentUserControl1.Instance);
                RentUserControl1.Instance.Dock = DockStyle.Fill;
                RentUserControl1.Instance.BringToFront();
            }
            else
            {
                RentUserControl1.Instance.BringToFront();
            }
        }

        private void SlidingPanelToggleButton_Click(object sender, EventArgs e)
        {
            if (!ControlPanel.Controls.Contains(QuickAccessUserControl.Instance))
            {
                ControlPanel.Controls.Add(QuickAccessUserControl.Instance);
                QuickAccessUserControl.Instance.Dock = DockStyle.Fill;
                QuickAccessUserControl.Instance.BringToFront();
            }
            else
            {
                QuickAccessUserControl.Instance.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ControlPanel.Controls.Contains(CustomerUserControl.Instance))
            {
                ControlPanel.Controls.Add(CustomerUserControl.Instance);
                CustomerUserControl.Instance.Dock = DockStyle.Fill;
                CustomerUserControl.Instance.BringToFront();
            }
            else
            {
                CustomerUserControl.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!ControlPanel.Controls.Contains(RTOCUserControl.Instance))
            {
                ControlPanel.Controls.Add(RTOCUserControl.Instance);
                RTOCUserControl.Instance.Dock = DockStyle.Fill;
                RTOCUserControl.Instance.BringToFront();
            }
            else
            {
                RTOCUserControl.Instance.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm obj1 = new LoginForm();
            this.Close();
        }
    }
}
