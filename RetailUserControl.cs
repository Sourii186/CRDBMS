using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RetailUserControl : UserControl
    {
        private static RetailUserControl _instance;
        public static RetailUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RetailUserControl();
                }
                return _instance;
            }
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"A:\\DBMS Project\\WindowsFormsApp1\\Properties\\CarDB.mdf\";Integrated Security=True");

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowRetailSP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" INVALID SQL OPERATION: \n" + ex);
                }
                con.Close();
                dataGridView1.DataSource = DS.Tables[0];

                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public RetailUserControl()
        {
            InitializeComponent();
        }

        private void RetailUserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("AddRetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UniqueID", textBox1.Text);
            cmd.Parameters.AddWithValue("@NameOfTheProduct", textBox2.Text);
            cmd.Parameters.AddWithValue("@ManufacturingCompany", textBox3.Text);
            cmd.Parameters.AddWithValue("@Cost", textBox4.Text);
            cmd.Parameters.AddWithValue("@YearsOfUseAllowed", textBox5.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Syntax" + ex);
            }
            con.Close();
            refresh_DataGridView();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeleteRetail", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UniqueID", textBox1.Text);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Syntax" + ex);
                }
                con.Close();
                refresh_DataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchRetail", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UniqueID", textBox6.Text);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);


                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" INVALID SQL OPERATION: \n" + ex);
                }
                con.Close();
                dataGridView1.DataSource = DS.Tables[0];

                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
