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
    public partial class Form5 : Form
    {
        
       

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ayuboLeisureDataSet1.Rent_Travelling' table. You can move, or remove it, as needed.
            this.rent_TravellingTableAdapter.Fill(this.ayuboLeisureDataSet1.Rent_Travelling);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "select * from Rent_Travelling where Customer_First_Name='" + txtSearch.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                this.rent_TravellingTableAdapter.Fill(this.ayuboLeisureDataSet1.Rent_Travelling);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid Database Opertaion.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }
    }
}
