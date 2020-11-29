using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo_Leasing_VRMS
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form12_FormClosed);
        }

        private void Form12_FormClosed(object sender, FormClosedEventArgs e)
        {
            (new Form1()).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
           if(txtUsername.Text=="admin" && txtPWD.Text=="admin")
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else
            {
                if(txtUsername.Text!="admin")
                    MessageBox.Show("Invalid username","Not authorized",MessageBoxButtons.OK,MessageBoxIcon.Error);
                else if(txtPWD.Text != "admin")
                    MessageBox.Show("Invalid password", "Not authorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if(txtUsername.Text==" " || txtPWD.Text==" ")
                    MessageBox.Show("Fill username and password", "Not authorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Not authorized", "Not authorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
