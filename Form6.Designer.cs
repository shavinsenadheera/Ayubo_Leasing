namespace Ayubo_Leasing_VRMS
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMHours = new System.Windows.Forms.TextBox();
            this.txtHRate = new System.Windows.Forms.TextBox();
            this.txtKmRate = new System.Windows.Forms.TextBox();
            this.txtMaxKm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimeDif = new System.Windows.Forms.TextBox();
            this.txtExtraHours = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtExtraKm = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtKmDif = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtEndKm = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtStartKm = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCNO = new System.Windows.Forms.TextBox();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rent_TravellingTableAdapter1 = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet1TableAdapters.Rent_TravellingTableAdapter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.comboBoxVRegNo = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBoxVModel = new System.Windows.Forms.ComboBox();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.comboBoxVType = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTotalCharge = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtExtraKmCharge = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtWaitingCharge = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBaseCharge = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtBillNO = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy:MM:dd HH:mm:ss ";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(59, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 30);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(560, 26);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(471, 33);
            this.comboBoxSearch.TabIndex = 1;
            this.comboBoxSearch.Text = "Select a package";
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rate of package";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max Hours";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(221, 85);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(143, 30);
            this.txtRate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Extra Hour Rate";
            // 
            // txtMHours
            // 
            this.txtMHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMHours.Location = new System.Drawing.Point(551, 85);
            this.txtMHours.Name = "txtMHours";
            this.txtMHours.Size = new System.Drawing.Size(143, 30);
            this.txtMHours.TabIndex = 6;
            // 
            // txtHRate
            // 
            this.txtHRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHRate.Location = new System.Drawing.Point(551, 129);
            this.txtHRate.Name = "txtHRate";
            this.txtHRate.Size = new System.Drawing.Size(143, 30);
            this.txtHRate.TabIndex = 7;
            // 
            // txtKmRate
            // 
            this.txtKmRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKmRate.Location = new System.Drawing.Point(888, 129);
            this.txtKmRate.Name = "txtKmRate";
            this.txtKmRate.Size = new System.Drawing.Size(143, 30);
            this.txtKmRate.TabIndex = 11;
            // 
            // txtMaxKm
            // 
            this.txtMaxKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxKm.Location = new System.Drawing.Point(888, 85);
            this.txtMaxKm.Name = "txtMaxKm";
            this.txtMaxKm.Size = new System.Drawing.Size(143, 30);
            this.txtMaxKm.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(729, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Extra Km Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(729, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Max Km";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKmRate);
            this.groupBox1.Controls.Add(this.comboBoxSearch);
            this.groupBox1.Controls.Add(this.txtMaxKm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHRate);
            this.groupBox1.Controls.Add(this.txtRate);
            this.groupBox1.Controls.Add(this.txtMHours);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1082, 184);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Start Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(347, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "End Time";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy:MM:dd HH:mm:ss ";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(352, 96);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(282, 30);
            this.dateTimePicker2.TabIndex = 15;
            this.dateTimePicker2.Value = new System.DateTime(2019, 4, 17, 0, 29, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(665, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Time Difference";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtTimeDif
            // 
            this.txtTimeDif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeDif.Location = new System.Drawing.Point(670, 96);
            this.txtTimeDif.Name = "txtTimeDif";
            this.txtTimeDif.Size = new System.Drawing.Size(139, 30);
            this.txtTimeDif.TabIndex = 18;
            this.txtTimeDif.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtExtraHours
            // 
            this.txtExtraHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraHours.Location = new System.Drawing.Point(895, 96);
            this.txtExtraHours.Name = "txtExtraHours";
            this.txtExtraHours.Size = new System.Drawing.Size(139, 30);
            this.txtExtraHours.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(890, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Extra Hours";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtExtraKm);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.txtKmDif);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.txtEndKm);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.txtStartKm);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.txtExtraHours);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txtTimeDif);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 459);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1081, 234);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Journey Summery";
            // 
            // txtExtraKm
            // 
            this.txtExtraKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraKm.Location = new System.Drawing.Point(895, 193);
            this.txtExtraKm.Name = "txtExtraKm";
            this.txtExtraKm.Size = new System.Drawing.Size(139, 30);
            this.txtExtraKm.TabIndex = 28;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(890, 153);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 25);
            this.label25.TabIndex = 27;
            this.label25.Text = "Extra Km";
            // 
            // txtKmDif
            // 
            this.txtKmDif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKmDif.Location = new System.Drawing.Point(670, 193);
            this.txtKmDif.Name = "txtKmDif";
            this.txtKmDif.Size = new System.Drawing.Size(139, 30);
            this.txtKmDif.TabIndex = 26;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(665, 153);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(135, 25);
            this.label26.TabIndex = 25;
            this.label26.Text = "Km Difference";
            // 
            // txtEndKm
            // 
            this.txtEndKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndKm.Location = new System.Drawing.Point(358, 193);
            this.txtEndKm.Name = "txtEndKm";
            this.txtEndKm.Size = new System.Drawing.Size(139, 30);
            this.txtEndKm.TabIndex = 24;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(353, 153);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 25);
            this.label23.TabIndex = 23;
            this.label23.Text = "End Km";
            // 
            // txtStartKm
            // 
            this.txtStartKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartKm.Location = new System.Drawing.Point(59, 183);
            this.txtStartKm.Name = "txtStartKm";
            this.txtStartKm.Size = new System.Drawing.Size(139, 30);
            this.txtStartKm.TabIndex = 22;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(54, 143);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 25);
            this.label24.TabIndex = 21;
            this.label24.Text = "Start Km";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCNO);
            this.groupBox3.Controls.Add(this.txtCID);
            this.groupBox3.Controls.Add(this.txtLname);
            this.groupBox3.Controls.Add(this.txtFname);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 239);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Information";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtCNO
            // 
            this.txtCNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNO.Location = new System.Drawing.Point(252, 194);
            this.txtCNO.Name = "txtCNO";
            this.txtCNO.Size = new System.Drawing.Size(268, 30);
            this.txtCNO.TabIndex = 20;
            // 
            // txtCID
            // 
            this.txtCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCID.Location = new System.Drawing.Point(252, 141);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(268, 30);
            this.txtCID.TabIndex = 19;
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(252, 94);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(268, 30);
            this.txtLname.TabIndex = 18;
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(252, 40);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(268, 30);
            this.txtFname.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Customer ID No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Customer Contact No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "Customer Last Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 25);
            this.label13.TabIndex = 13;
            this.label13.Text = "Customer First Name";
            // 
            // rent_TravellingTableAdapter1
            // 
            this.rent_TravellingTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTelNo);
            this.groupBox4.Controls.Add(this.comboBoxVRegNo);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.comboBoxVModel);
            this.groupBox4.Controls.Add(this.txtDriverName);
            this.groupBox4.Controls.Add(this.comboBoxVType);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(563, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(531, 239);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vehicle Information";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelNo.Location = new System.Drawing.Point(248, 194);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(268, 30);
            this.txtTelNo.TabIndex = 17;
            // 
            // comboBoxVRegNo
            // 
            this.comboBoxVRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVRegNo.FormattingEnabled = true;
            this.comboBoxVRegNo.Location = new System.Drawing.Point(248, 111);
            this.comboBoxVRegNo.Name = "comboBoxVRegNo";
            this.comboBoxVRegNo.Size = new System.Drawing.Size(268, 33);
            this.comboBoxVRegNo.TabIndex = 7;
            this.comboBoxVRegNo.Text = "Select a registration number";
            this.comboBoxVRegNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxVRegNo_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(28, 199);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(166, 25);
            this.label19.TabIndex = 16;
            this.label19.Text = "Driver Contact No";
            // 
            // comboBoxVModel
            // 
            this.comboBoxVModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVModel.FormattingEnabled = true;
            this.comboBoxVModel.Location = new System.Drawing.Point(248, 72);
            this.comboBoxVModel.Name = "comboBoxVModel";
            this.comboBoxVModel.Size = new System.Drawing.Size(268, 33);
            this.comboBoxVModel.TabIndex = 6;
            this.comboBoxVModel.Text = "Select a vehicle model";
            this.comboBoxVModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxVModel_SelectedIndexChanged);
            // 
            // txtDriverName
            // 
            this.txtDriverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverName.Location = new System.Drawing.Point(248, 155);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(268, 30);
            this.txtDriverName.TabIndex = 15;
            // 
            // comboBoxVType
            // 
            this.comboBoxVType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVType.FormattingEnabled = true;
            this.comboBoxVType.Location = new System.Drawing.Point(248, 32);
            this.comboBoxVType.Name = "comboBoxVType";
            this.comboBoxVType.Size = new System.Drawing.Size(268, 33);
            this.comboBoxVType.TabIndex = 5;
            this.comboBoxVType.Text = "Select a vehicle type";
            this.comboBoxVType.SelectedIndexChanged += new System.EventHandler(this.comboBoxVType_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(28, 160);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 25);
            this.label20.TabIndex = 2;
            this.label20.Text = "Driver Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(28, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(214, 25);
            this.label14.TabIndex = 4;
            this.label14.Text = "Vehicle Registration No";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(28, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 25);
            this.label15.TabIndex = 3;
            this.label15.Text = "Vehicle Model";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(28, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "Vehicle Type";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.txtTotalCharge);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.txtExtraKmCharge);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.txtWaitingCharge);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txtBaseCharge);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(11, 723);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1082, 201);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Journey Calculations";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(115, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(824, 49);
            this.button1.TabIndex = 29;
            this.button1.Text = "CALCULATIONS....";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTotalCharge
            // 
            this.txtTotalCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCharge.Location = new System.Drawing.Point(795, 145);
            this.txtTotalCharge.Name = "txtTotalCharge";
            this.txtTotalCharge.Size = new System.Drawing.Size(139, 30);
            this.txtTotalCharge.TabIndex = 28;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(790, 105);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(126, 25);
            this.label21.TabIndex = 27;
            this.label21.Text = "Total Charge";
            // 
            // txtExtraKmCharge
            // 
            this.txtExtraKmCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraKmCharge.Location = new System.Drawing.Point(570, 145);
            this.txtExtraKmCharge.Name = "txtExtraKmCharge";
            this.txtExtraKmCharge.Size = new System.Drawing.Size(139, 30);
            this.txtExtraKmCharge.TabIndex = 26;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(565, 105);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(162, 25);
            this.label22.TabIndex = 25;
            this.label22.Text = "Extra Km Charge";
            // 
            // txtWaitingCharge
            // 
            this.txtWaitingCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaitingCharge.Location = new System.Drawing.Point(340, 142);
            this.txtWaitingCharge.Name = "txtWaitingCharge";
            this.txtWaitingCharge.Size = new System.Drawing.Size(139, 30);
            this.txtWaitingCharge.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(335, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(148, 25);
            this.label17.TabIndex = 23;
            this.label17.Text = "Waiting Charge";
            // 
            // txtBaseCharge
            // 
            this.txtBaseCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseCharge.Location = new System.Drawing.Point(115, 142);
            this.txtBaseCharge.Name = "txtBaseCharge";
            this.txtBaseCharge.Size = new System.Drawing.Size(139, 30);
            this.txtBaseCharge.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(110, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 25);
            this.label18.TabIndex = 21;
            this.label18.Text = "Base Charge";
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(1118, 190);
            this.txtBill.Multiline = true;
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(454, 326);
            this.txtBill.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(1118, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(405, 39);
            this.button3.TabIndex = 29;
            this.button3.Text = "Confirm The Journey";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Coral;
            this.button4.Location = new System.Drawing.Point(1118, 546);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(405, 39);
            this.button4.TabIndex = 28;
            this.button4.Text = "Bill and Print";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtBillNO
            // 
            this.txtBillNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNO.Location = new System.Drawing.Point(1118, 90);
            this.txtBillNO.Name = "txtBillNO";
            this.txtBillNO.Size = new System.Drawing.Size(100, 30);
            this.txtBillNO.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(1118, 602);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(405, 39);
            this.button2.TabIndex = 31;
            this.button2.Text = "Showing Journey";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1584, 977);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBillNO);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Day Package Informantion";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMHours;
        private System.Windows.Forms.TextBox txtHRate;
        private System.Windows.Forms.TextBox txtKmRate;
        private System.Windows.Forms.TextBox txtMaxKm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTimeDif;
        private System.Windows.Forms.TextBox txtExtraHours;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCNO;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private AyuboLeisureDataSet1TableAdapters.Rent_TravellingTableAdapter rent_TravellingTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxVRegNo;
        private System.Windows.Forms.ComboBox comboBoxVModel;
        private System.Windows.Forms.ComboBox comboBoxVType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTotalCharge;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtExtraKmCharge;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtWaitingCharge;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBaseCharge;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtExtraKm;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtKmDif;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtEndKm;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtStartKm;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtBillNO;
        private System.Windows.Forms.Button button2;
    }
}