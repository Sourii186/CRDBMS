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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp1
{
    public partial class QuickAccessUserControl : UserControl
    {
        private static QuickAccessUserControl _instance;
        public static QuickAccessUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new QuickAccessUserControl();
                }
                return _instance;
            }
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"A:\\DBMS Project\\WindowsFormsApp1\\Properties\\CarDB.mdf\";Integrated Security=True");

        public QuickAccessUserControl()
        {
            InitializeComponent();
        }

        private void QuickAccessUserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }
        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ExampleSP", con);
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
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }


        private void Search_Click(object sender, EventArgs e)
        {
           
                try
                {
                    SqlCommand cmd = new SqlCommand("QuickAccessSP", con);
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

            }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR" + ex);
                }
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox6.Text = "";
            refresh_DataGridView();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("QuickAccessSP2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID", textBox1.Text);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
