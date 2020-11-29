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

    public partial class Form4 : Form
    {
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();

        DateTime startdate;
        DateTime enddate;
        TimeSpan remain;
        int TDays;
        int Month;
        int Weeks;
        int Days;

        public Form4()
        {
            InitializeComponent();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtBill.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 20, 20);
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            startdate = DateTime.Parse(dateTimePickerStart.Text).Date;
            enddate = DateTime.Parse(dateTimePickerEnd.Text).Date;
            remain = enddate - startdate;
            TDays = Convert.ToInt16(remain.TotalDays);
            Month = (TDays / 30);
            txtMonths.Text = Month.ToString();
            int TDays1 = TDays % 30;
            Weeks = TDays1 / 7;
            txtWeeks.Text = Weeks.ToString();
            Days = TDays1 % 7;
            txtDays.Text = Days.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
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
                string query = "select Vehicle_Model from Registration where Vehicle_Type='" + comboBoxVType.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comboBoxVModel.Items.Add(sdr["Vehicle_Model"].ToString());
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
                    txtDayRate.Text = sdr["Day_Rate"].ToString();
                    txtWeekRate.Text = sdr["Week_Rate"].ToString();
                    txtMonthRate.Text = sdr["Month_Rate"].ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid Database Operation.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txtMonths_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDriverName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double day = Convert.ToDouble(txtDayRate.Text);
            double week = Convert.ToDouble(txtWeekRate.Text);
            double month = Convert.ToDouble(txtMonthRate.Text);

            if (checkBoxdriver.Checked == true)
            {
                double drivecost = Convert.ToDouble(txtDriverRate.Text);
                double tot = day * Days + week * Weeks + month * Month + drivecost * TDays;
                txtDriverCost.Text = Convert.ToString(drivecost * TDays);
                txtTimeCost.Text = Convert.ToString(day * Days + week * Weeks + month * Month);
                txtTotalAmount.Text = tot.ToString();
            }
            else
            {
                double tot = day * Days + week * Weeks + month * Month;
                txtTimeCost.Text = Convert.ToString(day * Days + week * Weeks + month * Month);
                txtDriverCost.Text = "";
                txtTotalAmount.Text = tot.ToString();
            }
        }

        private void checkBoxdriver_CheckedChanged(object sender, EventArgs e)
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
                    if (checkBoxdriver.Checked == true)
                    {
                        txtDriverName.Text = sdr["Driver_First_Name"].ToString() + " " + sdr["Driver_Last_Name"].ToString();
                        txtTelNo.Text = sdr["Driver_Contact_No"].ToString();
                        txtDriverRate.Text = sdr["Driver_Rate"].ToString();

                    }
                    else
                    {
                        txtDriverName.Text = "";
                        txtTelNo.Text = "";
                        txtDriverRate.Text = "";
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid Database Operation.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                txtBill.AppendText("************************************************************************************\n");
                txtBill.AppendText("\t\tAyubo Leisure(Pvt) Ltd  \n");
                txtBill.AppendText("************************************************************************************\n");
                txtBill.AppendText("\t\tRENT TRAVELLING     \n");
                txtBill.AppendText("\t\tBill NO\t" + txtRentNO.Text + "\n");
                txtBill.AppendText("************************************************************************************\n");
                txtBill.AppendText("BILL TIME\t\t\t" + DateTime.Now.ToString() + "\n");
                txtBill.AppendText("************************************************************************************\n");
                txtBill.AppendText("Trip Days :" + dateTimePickerStart.Text + " to " + dateTimePickerEnd.Text + "\n");
                txtBill.AppendText("Total Days :\t\t\t\t\t" + TDays.ToString() + "\n");
                txtBill.AppendText("Vehicle :\t\t\t\t\t" + comboBoxVModel.Text + " " + comboBoxVType.Text + "\n");
                txtBill.AppendText("Vehicle Cost :\t\t\tLKR***********" + txtTimeCost.Text + "\n");
                if (checkBoxdriver.Checked == true)
                    txtBill.AppendText("Driver Cost :\t\t\tLKR***********" + txtDriverCost.Text + "\n");
                txtBill.AppendText("************************************************************************************\n");
                txtBill.AppendText("Total Amount :\t\t\tLKR***********" + txtTotalAmount.Text + "\n");
                txtBill.AppendText("************************************************************************************\n");
                txtBill.AppendText("\t\tTHANK YOU " + txtFname.Text + " " + txtLname.Text + "\n");
                txtBill.AppendText("************************************************************************************");

                dialog.Document = document;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    document.Print();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Something going wrong..", "Error with Printer",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=AyuboLeisure;Integrated Security=True");
                con.Open();
                string query = "insert into Rent_Travelling(Customer_First_Name,Customer_Last_Name,Customer_ID_No,Customer_Contact_No,Start_Date,End_Date,Months,Weeks,Days,Vehicle_Registration_No,With_Driver,Time_Cost,Driver_Cost,Total_Amount) values('" + txtFname.Text + "','" + txtLname.Text + "','" + txtCID.Text + "','" + txtCNO.Text + "','" + dateTimePickerStart.Text + "','" + dateTimePickerEnd.Text + "','" + txtMonths.Text + "','" + txtWeeks.Text + "','" + txtDays.Text + "','" + comboBoxVRegNo.Text + "','" + checkBoxdriver.Checked.ToString() + "','" + txtTimeCost.Text + "','" + txtDriverCost.Text + "','" + txtTotalAmount.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                string query1 = "select Rent_ID from Rent_Travelling";
                SqlCommand cmd = new SqlCommand(query1, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txtRentNO.Text = sdr["Rent_ID"].ToString();
                }
                con.Close();
                MessageBox.Show("Data is inserted.");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid Database Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
    }
}
