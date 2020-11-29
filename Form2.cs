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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxType.Text.Equals("Small Car"))
            {
                txtDrate.Text = "3000";
                txtWrate.Text = "2500";
                txtMrate.Text = "2000";
                txtDriverRate.Text = "1000";
            }
            else if(comboBoxType.Text.Equals("Sedan Car"))
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtReg.Text!= "" && comboBoxModel.Text != "" && comboBoxType.Text != "" && txtDrate.Text!="" && txtWrate.Text!="" && txtMrate.Text!="" && txtFName.Text!="" && txtLName.Text!="" && txtLicNo.Text!="" && txtConNo.Text!="" && txtDriverRate.Text!="")
                { 
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                    String querey = "insert into Registration values('" + txtReg.Text + "','" + comboBoxModel.Text + "','" + comboBoxType.Text + "','" + txtDrate.Text + "','" + txtWrate.Text + "','" + txtMrate.Text + "','" + txtFName.Text + "','" + txtLName.Text + "','" + txtLicNo.Text + "','" + txtConNo.Text + "','" + txtDriverRate.Text + "')";
                    SqlCommand cmd = new SqlCommand(querey, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data is inserted.", "Inserting...", MessageBoxButtons.OK);
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please fill the form first.","Filling ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
             
                
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid Database Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

     
    }
}
