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
using System.Drawing.Printing;

namespace Ayubo_Leasing_VRMS
{
    public partial class Form6 : Form
    {
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();


        DateTime startTime;
        DateTime endTime;
        TimeSpan time;
        double totHours,Maxhours;
        public Form6()
        {
            InitializeComponent();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtBill.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 20, 20);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "select * from Day_Packages";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comboBoxSearch.Items.Add(sdr["Package_Name"].ToString());

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid Database Operation.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "select Vehicle_Type from Registration ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comboBoxVType.Items.Add(sdr["Vehicle_Type"].ToString());
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid Database Operation.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxVModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxVRegNo.Items.Clear();
            comboBoxVRegNo.Text = "Select a registration number";
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "select Vehicle_Registration_no from Registration where Vehicle_Type='" + comboBoxVType.Text + "' and Vehicle_Model='" + comboBoxVModel.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comboBoxVRegNo.Items.Add(sdr["Vehicle_Registration_no"].ToString());

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid Database Operation.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxVRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "select * from Registration where Vehicle_Type='" + comboBoxVType.Text + "' and Vehicle_Model='" + comboBoxVModel.Text + "' and Vehicle_Registration_no='" + comboBoxVRegNo.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txtDriverName.Text = sdr["Driver_First_Name"].ToString() + " " + sdr["Driver_Last_Name"].ToString();
                    txtTelNo.Text = sdr["Driver_Contact_No"].ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid Database Operation.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxVType.Items.Clear();
            comboBoxVType.Text = "Select a vehicle type";
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "select Vehicle_Type from Day_Packages where Package_Name='" + comboBoxSearch.Text + "'";
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
                MessageBox.Show(error.ToString(), "Invalid Database Operation.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBaseCharge.Text = txtRate.Text;

            startTime = dateTimePicker1.Value;
            endTime = dateTimePicker2.Value;
            time = endTime - startTime;
            totHours = time.Days * 24 + time.Hours;
            txtTimeDif.Text = Convert.ToString(totHours);
            Maxhours = Convert.ToDouble(txtMHours.Text);
            double maxhourRate = Convert.ToDouble(txtHRate.Text);

            if (totHours > Maxhours)
            {
                double hoursDif = totHours - Maxhours;
                txtExtraHours.Text = Convert.ToString(hoursDif);
                double hour_calculation = hoursDif * maxhourRate;
                txtWaitingCharge.Text = Convert.ToString(hour_calculation);
            }
            else
            {
                txtExtraHours.Text = "0";
                txtWaitingCharge.Text = "0";
            }

            double startkm = Convert.ToDouble(txtStartKm.Text);
            double endkm = Convert.ToDouble(txtEndKm.Text);
            double kmdif = endkm - startkm;
            txtKmDif.Text = Convert.ToString(kmdif);
            double MaxKm = Convert.ToDouble(txtMaxKm.Text);
            double KmRate = Convert.ToDouble(txtKmRate.Text);
            if (kmdif > MaxKm)
            {
                double totKm = kmdif - MaxKm;
                txtExtraKm.Text = Convert.ToString(totKm);
                double km_calculation = totKm * KmRate;
                txtExtraKmCharge.Text = Convert.ToString(km_calculation);
            }
            else
            {
                txtExtraKm.Text = "0";
                txtExtraKmCharge.Text = "0";
            }

            double TotAmount = Convert.ToDouble(txtBaseCharge.Text) + Convert.ToDouble(txtWaitingCharge.Text) + Convert.ToDouble(txtExtraKmCharge.Text);
            txtTotalCharge.Text = TotAmount.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "insert into Day_Hire_Travelling(Customer_ID,Customer_FName,Customer_LName,Customer_Tel_NO,Package_Name,Vehicle_Reg_NO,Start_Time,End_Time,Time_Difference_hours,Extra_Hours,Start_Km,End_Km,Km_Difference,Extra_Km,Base_Charge,Waiting_Charge,Extra_Km_Charge,Total_Charge) values('" + txtCID.Text + "','" + txtFname.Text + "','" + txtLname.Text + "','" + txtCNO.Text + "','" + comboBoxSearch.Text + "','" + comboBoxVRegNo.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + txtTimeDif.Text + "','" + txtExtraHours.Text + "','" + txtStartKm.Text + "','" + txtEndKm.Text + "','" + txtKmDif.Text + "','" + txtExtraKm.Text + "','" + txtBaseCharge.Text + "','" + txtWaitingCharge.Text + "','" + txtExtraKmCharge.Text + "','" + txtTotalCharge.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Confirmed the journey");
                string query1 = "select Day_Pack_ID from Day_Hire_Travelling";
                SqlCommand cmd = new SqlCommand(query1, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txtBillNO.Text = sdr["Day_Pack_ID"].ToString();
                }
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid Database Operation.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                txtBill.AppendText("************************************************************************************\n");
                txtBill.AppendText("\t\tAyubo Leisure(Pvt) Ltd  \n");
                txtBill.AppendText("************************************************************************************\n");
                txtBill.AppendText("\tDAY HIRE TRAVELLING\n");
                txtBill.AppendText("\t\tBill NO\t" + txtBillNO.Text + "\n");
                txtBill.AppendText("************************************************************************************\n");
                txtBill.AppendText("BILL TIME\t\t\t" + DateTime.Now.ToString() + "\n");
                txtBill.AppendText("************************************************************************************\n");
                txtBill.AppendText("Trip Time :" + dateTimePicker1.Text + " to " + dateTimePicker2.Text + "\n");
                txtBill.AppendText("Total Hours :\t\t\t\t\t" + txtTimeDif.Text + "\n");
                txtBill.AppendText("Extra Hours :\t\t\t\t\t" + txtExtraHours.Text + "\n");
                txtBill.AppendText("Total Km :\t\t\t\t\t" + txtKmDif.Text + "\n");
                txtBill.AppendText("Extra Km:\t\t\t\t\t" + txtExtraKm.Text + "\n");
                txtBill.AppendText("Vehicle :\t\t\t\t\t" + comboBoxVModel.Text + " " + comboBoxVType.Text + "\n");
                txtBill.AppendText("Base Charge :\t\t\tLKR***********" + txtBaseCharge.Text + "\n");
                txtBill.AppendText("Waiting Charge :\t\t\tLKR***********" + txtWaitingCharge.Text + "\n");
                txtBill.AppendText("Extra Km Charge :\t\t\tLKR***********" + txtExtraKmCharge.Text + "\n");
                txtBill.AppendText("************************************************************************************\n");
                txtBill.AppendText("Total Amount :\t\t\tLKR***********" + txtTotalCharge.Text + "\n");
                txtBill.AppendText("************************************************************************************\n");
                txtBill.AppendText("\t\tTHANK YOU " + txtFname.Text + " " + txtLname.Text + "\n");
                txtBill.AppendText("************************************************************************************");

                dialog.Document = document;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    document.Print();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Something going wrong..", "Error with Printer", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxVType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxVModel.Items.Clear();
            comboBoxVModel.Text = "Select vehicle model";
            
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "select * from Day_Packages where Vehicle_Type='" + comboBoxVType.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txtRate.Text = sdr["Rate"].ToString();
                    txtMHours.Text = sdr["Max_Hours"].ToString();
                    txtHRate.Text = sdr["Extra_Hour_Rate"].ToString();
                    txtMaxKm.Text = sdr["Max_KM"].ToString();
                    txtKmRate.Text = sdr["Extra_KM_Rate"].ToString();
                    
                }
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid Database Operation.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "select * from Registration where Vehicle_Type='" + comboBoxVType.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comboBoxVModel.Items.Add(sdr["Vehicle_Model"].ToString());
                    comboBoxVRegNo.Items.Add(sdr["Vehicle_Registration_no"].ToString());
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid Database Operation.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        }


    }

