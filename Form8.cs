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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ayuboLeisureDataSet5.Day_Hire_Travelling' table. You can move, or remove it, as needed.
            this.day_Hire_TravellingTableAdapter1.Fill(this.ayuboLeisureDataSet5.Day_Hire_Travelling);
            

        }

        private void Butsearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "select * from Day_Hire_Travelling where Customer_FName='" + txtSearch.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                this.day_Hire_TravellingTableAdapter1.Fill(this.ayuboLeisureDataSet5.Day_Hire_Travelling);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid Database Opertaion.");
            }
        }

        private void txtSearch_DoubleClick(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
