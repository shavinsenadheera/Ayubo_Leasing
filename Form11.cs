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


namespace Ayubo_Leasing_VRMS
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
         
            this.long_Day_Hire_TravellingTableAdapter.Fill(this.ayuboLeisureDataSet7.Long_Day_Hire_Travelling);

        }

        private void Butsearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "select * from Long_Day_Hire_Travelling where Customer_FName='" + txtSearch.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                this.long_Day_Hire_TravellingTableAdapter.Fill(this.ayuboLeisureDataSet7.Long_Day_Hire_Travelling);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid Database Opertaion.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_DoubleClick(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
    }
}
