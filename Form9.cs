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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "insert into Long_Hire_Packages values('" + txtPacName.Text + "','"+comboBoxVType.Text+"','" + txtRate.Text + "','" + txtMaxKmday.Text + "','" + txtMaxDays.Text + "','" + txtOnightRate.Text + "','" + txtNparkRate.Text + "','"+txtExtraKmRate.Text+"')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data is inserted.", "Inserting....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.long_Hire_PackagesTableAdapter.Fill(this.ayuboLeisureDataSet4.Long_Hire_Packages);
                txtPacName.Text = " ";
                txtRate.Text = " ";
                txtMaxKmday.Text = " ";
                txtMaxDays.Text = " ";
                txtOnightRate.Text = " ";
                txtNparkRate.Text = " ";
                txtExtraKmRate.Text = " ";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid database Operations.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            this.long_Hire_PackagesTableAdapter2.Fill(this.ayuboLeisureDataSet6.Long_Hire_Packages);
        }

        private void Form9_Load(object sender, EventArgs e)
       { 
            this.long_Hire_PackagesTableAdapter2.Fill(this.ayuboLeisureDataSet6.Long_Hire_Packages);
          
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "select Package_Name from Long_Hire_Packages";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comboBox1.Items.Add(sdr["Package_Name"].ToString());
                }
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid database Operations.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
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

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "update Long_Hire_Packages set Rate='" + txtRate.Text + "',Vehicle_Type='"+comboBoxVType.Text+"',  Max_Km_perday='" + txtMaxKmday.Text + "',Max_days='" + txtMaxDays.Text + "',Driver_over_nightRate='" + txtOnightRate.Text + "',Vahical_night_parkRate='" + txtNparkRate.Text + "',Extra_km_rate='"+txtExtraKmRate.Text+"' where Package_Name='" + txtPacName.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data is updated.", "Updating....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.long_Hire_PackagesTableAdapter2.Fill(this.ayuboLeisureDataSet6.Long_Hire_Packages);
                txtPacName.Text = " ";
                txtRate.Text = " ";
                txtMaxKmday.Text = " ";
                txtMaxDays.Text = " ";
                txtOnightRate.Text = " ";
                txtNparkRate.Text = " ";
                txtExtraKmRate.Text = " ";
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
                comboBoxVType.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtRate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtMaxKmday.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtMaxDays.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtOnightRate.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtNparkRate.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txtExtraKmRate.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "delete from Long_Hire_Packages where Package_Name='" + txtPacName.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                this.long_Hire_PackagesTableAdapter2.Fill(this.ayuboLeisureDataSet6.Long_Hire_Packages);
                con.Close();
                MessageBox.Show("Data is deleted.", "Deleting....", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid database Operations.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "select * from Long_Hire_Packages where Package_Name='" + comboBox1.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                this.long_Hire_PackagesTableAdapter2.Fill(this.ayuboLeisureDataSet6.Long_Hire_Packages);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid database Operations.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxVType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
