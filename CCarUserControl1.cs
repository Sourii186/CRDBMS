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
    public partial class CCarUserControl1 : UserControl
    {
        private static CCarUserControl1 _instance;
        public static CCarUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new  CCarUserControl1();
                }
                return _instance;
            }
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"A:\\DBMS Project\\WindowsFormsApp1\\Properties\\CarDB.mdf\";Integrated Security=True");
        public CCarUserControl1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            textBox6.Text = "";
            refresh_DataGridView();
        }

        private void CCarUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
