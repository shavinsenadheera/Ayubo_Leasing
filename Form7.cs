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
    public partial class Form7 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
        public Form7()
        {
            InitializeComponent();
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into Day_Packages values('"+txtPacName.Text+"','"+comboBoxVType.Text+"','"+txtRate.Text+"','"+txtMHours.Text+"','"+txtHourRate.Text+"','"+txtMaxKm.Text+"','"+txtExtraKmRate.Text+"')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data is inserted.","Inserting....",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.day_PackagesTableAdapter2.Fill(this.ayuboLeisureDataSet9.Day_Packages);
                txtPacName.Text = " ";
                comboBoxVType.Text = " ";
                txtRate.Text = " ";
                txtMHours.Text = " ";
                txtHourRate.Text = " ";
                txtMaxKm.Text = " ";
                txtExtraKmRate.Text = " ";
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString(),"Invalid database Operations.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
            this.day_PackagesTableAdapter2.Fill(this.ayuboLeisureDataSet9.Day_Packages);
          
            try
            {
                con.Open();
                string query = "select Package_Name from Day_Packages";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comboBox1.Items.Add(sdr["Package_Name"].ToString());
                }
                con.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid database Operations.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                con.Open();
                string query = "select Vehicle_Type from Registration";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comboBoxVType.Items.Add(sdr["Vehicle_Type"].ToString());
                }
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid database Operations.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                txtPacName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtRate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtMHours.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtHourRate.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtMaxKm.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtExtraKmRate.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString(); ;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "update Day_Packages set Rate='"+txtRate.Text+ "', Vehicle_Type='" + comboBoxVType.Text+"', Max_Hours='" + txtMHours.Text+ "',Extra_Hour_Rate='" + txtHourRate.Text+ "',Max_KM='" + txtMaxKm.Text+ "',Extra_KM_Rate='" + txtExtraKmRate.Text+ "' where Package_Name='"+txtPacName.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query,con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data is updated.", "Updating....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.day_PackagesTableAdapter2.Fill(this.ayuboLeisureDataSet9.Day_Packages);
                txtPacName.Text = " ";
                comboBoxVType.Text = " ";
                txtRate.Text = " ";
                txtMHours.Text = " ";
                txtHourRate.Text = " ";
                txtMaxKm.Text = " ";
                txtExtraKmRate.Text = " ";
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid database Operations.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select * from Day_Packages where Package_Name='" + comboBox1.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                this.day_PackagesTableAdapter2.Fill(this.ayuboLeisureDataSet9.Day_Packages);
                txtPacName.Text = " ";
                comboBoxVType.Text = " ";
                txtRate.Text = " ";
                txtMHours.Text = " ";
                txtHourRate.Text = " ";
                txtMaxKm.Text = " ";
                txtExtraKmRate.Text = " ";
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid database Operations.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "delete from Day_Packages where Package_Name='"+txtPacName.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                this.day_PackagesTableAdapter2.Fill(this.ayuboLeisureDataSet9.Day_Packages);
                con.Close();
                MessageBox.Show("Data is deleted.", "Deleting....", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid database Operations.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtPacName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                comboBoxVType.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtRate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtMHours.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtHourRate.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtMaxKm.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtExtraKmRate.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                
            }
        }
    }
}
