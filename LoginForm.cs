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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            String u1 = "Sourav", p1 = "Deadlifts", u2 = "Prajwal", p2 = "PJ94824" , u3 = "Kashyap" , p3 = "MangloreBuns" , u4 = "Dheeraj" , p4 = "Dheeru123",name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;
            if (name.Equals(u1) && pass.Equals(p1))
            {
                MessageBox.Show("Admin Login Success");
                AdminPage obj1 = new AdminPage();
         
                obj1.Show();
             }
            else if (name.Equals(u2) && pass.Equals(p2))
            {
                MessageBox.Show("Customer Login Success");
                Customer obj1 = new Customer();
               
                obj1.Show();
            }
            else if (name.Equals(u3) && pass.Equals(p3))
            {
                MessageBox.Show("Customer Login Success");
                Customer obj1 = new Customer();
                
                obj1.Show();
            }
            else if (name.Equals(u4) && pass.Equals(p4))
            {
                MessageBox.Show("Employee Login Success");
                Employee obj1 = new Employee();
               
                obj1.Show();
            }
            else 
            {
                MessageBox.Show("Wrong Credentials Please Contact Admin !!");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
