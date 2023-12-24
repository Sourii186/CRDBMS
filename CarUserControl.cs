using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class CarUserControl : UserControl
    {
        private static CarUserControl _instance;
        public static CarUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CarUserControl();
                }
                return _instance;
            }
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\5th Sem DBMS\\DBMS Project\\WindowsFormsApp1\\Properties\\CarDB.mdf\"; Integrated Security=True");

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllCarDataSP", con);
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
        public CarUserControl()
        {
            InitializeComponent();
        }

        private void CarUserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void makein_Click(object sender, EventArgs e)
        {

        }

        private void costin_Click(object sender, EventArgs e)
        {

        }

        private void IDin_Click(object sender, EventArgs e)
        {

        }

        private void namein_Click(object sender, EventArgs e)
        {

        }

        private void safetyin_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("AdminCarAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UniqueID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Make_Model", textBox3.Text);
            cmd.Parameters.AddWithValue("@SafetyRating", textBox5.Text);
            cmd.Parameters.AddWithValue("@Cost", textBox4.Text);
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
                SqlCommand cmd = new SqlCommand("DeleteSP", con);
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
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchSP", con);
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

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void Create_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("JoinSP", con);
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
