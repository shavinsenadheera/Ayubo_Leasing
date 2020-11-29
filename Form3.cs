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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ayuboLeisureDataSet1.Registration' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'ayuboLeisureDataSet.Registration' table. You can move, or remove it, as needed.
            this.ayuboLeisureDataSet.Clear();
            this.ayuboLeisureDataSet.EnforceConstraints = false;
            this.registrationTableAdapter.Fill(this.ayuboLeisureDataSet.Registration);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                txtReg.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                comboBoxModel.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBoxType.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtDrate.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtWrate.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtMrate.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtFName.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txtLName.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                txtLicNo.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                txtConNo.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                txtDriverRate.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "update Registration set Vehicle_Model='" + comboBoxModel.Text + "',Vehicle_Type='"+ comboBoxType.Text + "',Day_Rate='"+ txtDrate.Text + "',Week_Rate='"+ txtWrate.Text + "',Month_Rate='"+ txtMrate.Text + "',Driver_First_Name='"+ txtFName.Text + "',Driver_Last_Name='"+ txtLName.Text + "',Driver_License_No='"+ txtLicNo.Text + "',Driver_Contact_No='"+ txtConNo.Text + "',Driver_Rate='"+ txtDriverRate.Text + "' where Vehicle_Registration_no='"+ txtReg.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Data is updated.","Updating...",MessageBoxButtons.OK);
                con.Close();
                this.ayuboLeisureDataSet.EnforceConstraints = false;
                registrationTableAdapter.Fill(this.ayuboLeisureDataSet.Registration);

            }
            catch(Exception error)
            {
                            MessageBox.Show(error.ToString(),"Invalid Database Operation",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.Text.Equals("Small Car"))
            {
                txtDrate.Text = "3000";
                txtWrate.Text = "2500";
                txtMrate.Text = "2000";
                txtDriverRate.Text = "1000";
            }
            else if (comboBoxType.Text.Equals("Sedan Car"))
            {
                txtDrate.Text = "4000";
                txtWrate.Text = "3500";
                txtMrate.Text = "3000";
                txtDriverRate.Text = "1200";
            }
            else if (comboBoxType.Text.Equals("SVUs"))
            {
                txtDrate.Text = "5000";
                txtWrate.Text = "4500";
                txtMrate.Text = "4000";
                txtDriverRate.Text = "1500";
            }
            else if (comboBoxType.Text.Equals("Jeep(WD)"))
            {
                txtDrate.Text = "5000";
                txtWrate.Text = "4600";
                txtMrate.Text = "4200";
                txtDriverRate.Text = "1500";
            }
            else if (comboBoxType.Text.Equals("7-seater Van"))
            {
                txtDrate.Text = "4000";
                txtWrate.Text = "3500";
                txtMrate.Text = "3000";
                txtDriverRate.Text = "1600";
            }
            else if (comboBoxType.Text.Equals("Commuter Van"))
            {
                txtDrate.Text = "6000";
                txtWrate.Text = "5500";
                txtMrate.Text = "5000";
                txtDriverRate.Text = "2000";
            }
            else
            {
                MessageBox.Show("Invalid vehicle type.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "delete from Registration where Vehicle_Registration_no='"+txtReg.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete is deleted.","Deleting...",MessageBoxButtons.OK);
                this.ayuboLeisureDataSet.EnforceConstraints = false;
                registrationTableAdapter.Fill(this.ayuboLeisureDataSet.Registration);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid Database Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
           
          
        }


        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "select * from Registration where Vehicle_Type='" + comboBoxSearch.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                this.ayuboLeisureDataSet.EnforceConstraints = false;
                registrationTableAdapter.Fill(this.ayuboLeisureDataSet.Registration);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid Database Opertaion.");
            }
        }
    }
}
