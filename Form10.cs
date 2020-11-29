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
    public partial class Form10 : Form
    {
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();

        DateTime startDate;
        DateTime endDate;
        TimeSpan different;
        double NightPark;
        double OverNight;
        double ExtraKmcharge;
        double waiting;

        public Form10()
        {
            InitializeComponent();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtBill.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 20, 20);
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "select Package_Name from Long_Hire_Packages";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comboBoxSearch.Items.Add(sdr["Package_Name"].ToString());
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


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Rate = Convert.ToDouble(txtRate.Text);
                txtBaseCharge.Text = Rate.ToString();
                startDate = DateTime.Parse(dateTimePicker1.Text);
                endDate = DateTime.Parse(dateTimePicker2.Text);
                different = endDate - startDate;
                int totDays = different.Days;
                txtTimeDif.Text = totDays.ToString();
                int maxDays = Convert.ToInt32(txtMDays.Text);
                int moreDats = totDays - 1;

                if (maxDays <= totDays)
                {
                    txtMoreDays.Text = moreDats.ToString();
                    OverNight = Convert.ToDouble(txtOverNightRate.Text);
                    NightPark = Convert.ToDouble(txtNParkRate.Text);
                    waiting = OverNight * moreDats + NightPark * moreDats;
                    txtWaitingCharge.Text = (waiting).ToString();
                }
                else
                {
                    txtWaitingCharge.Text = " ";
                }

                double startKm = Convert.ToDouble(txtStartKm.Text);
                double endKm = Convert.ToDouble(txtEndKm.Text);
                double totKM = endKm - startKm;
                txtKmDif.Text = totKM.ToString();
                double MaxKm = Convert.ToDouble(txtMaxKmDay.Text);

                double MAXRate = MaxKm * totDays;



                if (totKM >= MAXRate)
                {
                    double differenceKm = totKM - MAXRate;
                    txtMoreKm.Text = differenceKm.ToString();
                    ExtraKmcharge = Convert.ToDouble(txtKmRate.Text);
                    txtExtraKmCharge.Text = (ExtraKmcharge * differenceKm).ToString();
                }
                else
                {
                    txtExtraKmCharge.Text = " ";
                }

                txtTotalCharge.Text = (Rate + Convert.ToDouble(txtExtraKmCharge.Text) + waiting).ToString();
            }
            catch(Exception error)
            {
                MessageBox.Show("Error with form please check the form.","Issue!",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBoxVType.Items.Clear();
            comboBoxVType.Text = "Slect a vehicle type";
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "select Vehicle_Type from Long_Hire_Packages where Package_Name='" + comboBoxSearch.Text+"'";
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

        private void comboBoxVType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxVModel.Items.Clear();
            comboBoxVModel.Text = "Select vehicle model";
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "select * from Registration where Vehicle_Type='"+comboBoxVType.Text+"'";
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
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "select * from Long_Hire_Packages where Vehicle_Type='" + comboBoxVType.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txtRate.Text = sdr["Rate"].ToString();
                    txtMDays.Text = sdr["Max_days"].ToString();
                    txtMaxKmDay.Text = sdr["Max_Km_perday"].ToString();
                    txtOverNightRate.Text = sdr["Driver_over_nightRate"].ToString();
                    txtNParkRate.Text = sdr["Vahical_night_parkRate"].ToString();
                    txtKmRate.Text = sdr["Extra_km_rate"].ToString();
                }
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid Database Operation.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void comboBoxVModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxVRegNo.Items.Clear();
            comboBoxVRegNo.Text = "Select vehicle RegNo";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.ShowDialog();
        }

        private void txtBillNO_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "insert into Long_Day_Hire_Travelling(Customer_ID,Customer_FName,Customer_LName,Customer_Tel_NO,Package_Name,Vehicle_Reg_NO,Start_Day,End_Day,Journey_Days,More_Days,Start_Km,End_Km,Total_Km,More_Km,Base_Charge,Waiting_Charge,Extra_Km_Charge,Total_Charge) values('" + txtCID.Text + "','" + txtFname.Text + "','" + txtLname.Text + "','" + txtCNO.Text + "','" + comboBoxSearch.Text + "','" + comboBoxVRegNo.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + txtTimeDif.Text + "','" + txtMoreDays.Text + "','" + txtStartKm.Text + "','" + txtEndKm.Text + "','" + txtKmDif.Text + "','" + txtMoreKm.Text + "','" + txtBaseCharge.Text + "','" + txtWaitingCharge.Text + "','" + txtExtraKmCharge.Text + "','" + txtTotalCharge.Text + "')";
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
                txtBill.AppendText("\tLong HIRE TRAVELLING\n");
                txtBill.AppendText("\t\tBill NO\t" + txtBillNO.Text + "\n");
                txtBill.AppendText("************************************************************************************\n");
                txtBill.AppendText("BILL TIME\t\t\t" + DateTime.Now.ToString() + "\n");
                txtBill.AppendText("************************************************************************************\n");
                txtBill.AppendText("Trip Time :" + dateTimePicker1.Text + " to " + dateTimePicker2.Text + "\n");
                txtBill.AppendText("Total Days :\t\t\t\t\t" + txtTimeDif.Text + "\n");
                txtBill.AppendText("More Days :\t\t\t\t\t" + txtMoreDays.Text + "\n");
                txtBill.AppendText("Total Km :\t\t\t\t\t" + txtKmDif.Text + "\n");
                txtBill.AppendText("More Km:\t\t\t\t\t" + txtMoreKm.Text + "\n");
                txtBill.AppendText("Vehicle :\t\t\t\t\t" + comboBoxVModel.Text + " " + comboBoxVType.Text + "\n");
                txtBill.AppendText("Base Charge :\t\t\tLKR***********" + txtBaseCharge.Text + "\n");
                txtBill.AppendText("OverNight Charge(with Parking) :\t\t\tLKR***********" + txtWaitingCharge.Text + "\n");
                txtBill.AppendText("Night Charge :\t\t\tLKR***********" + txtExtraKmCharge.Text + "\n");
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
    }
}
