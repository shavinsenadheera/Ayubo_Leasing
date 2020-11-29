namespace Ayubo_Leasing_VRMS
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehicleRegistrationnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverLicenseNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverContactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ayuboLeisureDataSet = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.txtMrate = new System.Windows.Forms.TextBox();
            this.txtWrate = new System.Windows.Forms.TextBox();
            this.txtDrate = new System.Windows.Forms.TextBox();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDriverRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConNo = new System.Windows.Forms.TextBox();
            this.txtLicNo = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.registrationTableAdapter = new Ayubo_Leasing_VRMS.AyuboLeisureDataSetTableAdapters.RegistrationTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(67, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1580, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data View";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleRegistrationnoDataGridViewTextBoxColumn,
            this.vehicleModelDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn,
            this.dayRateDataGridViewTextBoxColumn,
            this.weekRateDataGridViewTextBoxColumn,
            this.monthRateDataGridViewTextBoxColumn,
            this.driverFirstNameDataGridViewTextBoxColumn,
            this.driverLastNameDataGridViewTextBoxColumn,
            this.driverLicenseNoDataGridViewTextBoxColumn,
            this.driverContactNoDataGridViewTextBoxColumn,
            this.driverRateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.registrationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1525, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vehicleRegistrationnoDataGridViewTextBoxColumn
            // 
            this.vehicleRegistrationnoDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Registration_no";
            this.vehicleRegistrationnoDataGridViewTextBoxColumn.HeaderText = "Vehicle_Registration_no";
            this.vehicleRegistrationnoDataGridViewTextBoxColumn.Name = "vehicleRegistrationnoDataGridViewTextBoxColumn";
            // 
            // vehicleModelDataGridViewTextBoxColumn
            // 
            this.vehicleModelDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Model";
            this.vehicleModelDataGridViewTextBoxColumn.HeaderText = "Vehicle_Model";
            this.vehicleModelDataGridViewTextBoxColumn.Name = "vehicleModelDataGridViewTextBoxColumn";
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Type";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "Vehicle_Type";
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            // 
            // dayRateDataGridViewTextBoxColumn
            // 
            this.dayRateDataGridViewTextBoxColumn.DataPropertyName = "Day_Rate";
            this.dayRateDataGridViewTextBoxColumn.HeaderText = "Day_Rate";
            this.dayRateDataGridViewTextBoxColumn.Name = "dayRateDataGridViewTextBoxColumn";
            // 
            // weekRateDataGridViewTextBoxColumn
            // 
            this.weekRateDataGridViewTextBoxColumn.DataPropertyName = "Week_Rate";
            this.weekRateDataGridViewTextBoxColumn.HeaderText = "Week_Rate";
            this.weekRateDataGridViewTextBoxColumn.Name = "weekRateDataGridViewTextBoxColumn";
            // 
            // monthRateDataGridViewTextBoxColumn
            // 
            this.monthRateDataGridViewTextBoxColumn.DataPropertyName = "Month_Rate";
            this.monthRateDataGridViewTextBoxColumn.HeaderText = "Month_Rate";
            this.monthRateDataGridViewTextBoxColumn.Name = "monthRateDataGridViewTextBoxColumn";
            // 
            // driverFirstNameDataGridViewTextBoxColumn
            // 
            this.driverFirstNameDataGridViewTextBoxColumn.DataPropertyName = "Driver_First_Name";
            this.driverFirstNameDataGridViewTextBoxColumn.HeaderText = "Driver_First_Name";
            this.driverFirstNameDataGridViewTextBoxColumn.Name = "driverFirstNameDataGridViewTextBoxColumn";
            // 
            // driverLastNameDataGridViewTextBoxColumn
            // 
            this.driverLastNameDataGridViewTextBoxColumn.DataPropertyName = "Driver_Last_Name";
            this.driverLastNameDataGridViewTextBoxColumn.HeaderText = "Driver_Last_Name";
            this.driverLastNameDataGridViewTextBoxColumn.Name = "driverLastNameDataGridViewTextBoxColumn";
            // 
            // driverLicenseNoDataGridViewTextBoxColumn
            // 
            this.driverLicenseNoDataGridViewTextBoxColumn.DataPropertyName = "Driver_License_No";
            this.driverLicenseNoDataGridViewTextBoxColumn.HeaderText = "Driver_License_No";
            this.driverLicenseNoDataGridViewTextBoxColumn.Name = "driverLicenseNoDataGridViewTextBoxColumn";
            // 
            // driverContactNoDataGridViewTextBoxColumn
            // 
            this.driverContactNoDataGridViewTextBoxColumn.DataPropertyName = "Driver_Contact_No";
            this.driverContactNoDataGridViewTextBoxColumn.HeaderText = "Driver_Contact_No";
            this.driverContactNoDataGridViewTextBoxColumn.Name = "driverContactNoDataGridViewTextBoxColumn";
            // 
            // driverRateDataGridViewTextBoxColumn
            // 
            this.driverRateDataGridViewTextBoxColumn.DataPropertyName = "Driver_Rate";
            this.driverRateDataGridViewTextBoxColumn.HeaderText = "Driver_Rate";
            this.driverRateDataGridViewTextBoxColumn.Name = "driverRateDataGridViewTextBoxColumn";
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataMember = "Registration";
            this.registrationBindingSource.DataSource = this.ayuboLeisureDataSet;
            // 
            // ayuboLeisureDataSet
            // 
            this.ayuboLeisureDataSet.DataSetName = "AyuboLeisureDataSet";
            this.ayuboLeisureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxModel);
            this.groupBox2.Controls.Add(this.comboBoxType);
            this.groupBox2.Controls.Add(this.txtMrate);
            this.groupBox2.Controls.Add(this.txtWrate);
            this.groupBox2.Controls.Add(this.txtDrate);
            this.groupBox2.Controls.Add(this.txtReg);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(50, 471);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 370);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehicle Information";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Items.AddRange(new object[] {
            "Audi",
            "Benz",
            "BMW",
            "Ford",
            "Honda",
            "Mitsubishi",
            "Nissan",
            "Tesla",
            "Toyota"});
            this.comboBoxModel.Location = new System.Drawing.Point(251, 104);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(349, 33);
            this.comboBoxModel.TabIndex = 15;
            this.comboBoxModel.Text = "Select Vehicle Model";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Small Car",
            "Sedan Car",
            "SVUs",
            "Jeep(WD)",
            "7-seater Van",
            "Commuter Van"});
            this.comboBoxType.Location = new System.Drawing.Point(251, 154);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(349, 33);
            this.comboBoxType.TabIndex = 14;
            this.comboBoxType.Text = "Select Vehicle Type";
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // txtMrate
            // 
            this.txtMrate.Location = new System.Drawing.Point(251, 320);
            this.txtMrate.Name = "txtMrate";
            this.txtMrate.ReadOnly = true;
            this.txtMrate.Size = new System.Drawing.Size(349, 30);
            this.txtMrate.TabIndex = 12;
            // 
            // txtWrate
            // 
            this.txtWrate.Location = new System.Drawing.Point(251, 267);
            this.txtWrate.Name = "txtWrate";
            this.txtWrate.ReadOnly = true;
            this.txtWrate.Size = new System.Drawing.Size(349, 30);
            this.txtWrate.TabIndex = 11;
            // 
            // txtDrate
            // 
            this.txtDrate.Location = new System.Drawing.Point(251, 208);
            this.txtDrate.Name = "txtDrate";
            this.txtDrate.ReadOnly = true;
            this.txtDrate.Size = new System.Drawing.Size(349, 30);
            this.txtDrate.TabIndex = 10;
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(251, 45);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(349, 30);
            this.txtReg.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Vehicle Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vehicle Registration No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vehicle Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Month Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Day Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Week Rate";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtLName);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtDriverRate);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtConNo);
            this.groupBox3.Controls.Add(this.txtLicNo);
            this.groupBox3.Controls.Add(this.txtFName);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(727, 471);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(729, 370);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Driver Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "Driver Last Name";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(327, 105);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(360, 30);
            this.txtLName.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Driver Contact No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Driver First Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "Driver License No";
            // 
            // txtDriverRate
            // 
            this.txtDriverRate.Location = new System.Drawing.Point(327, 279);
            this.txtDriverRate.Name = "txtDriverRate";
            this.txtDriverRate.ReadOnly = true;
            this.txtDriverRate.Size = new System.Drawing.Size(360, 30);
            this.txtDriverRate.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Driver Rate";
            // 
            // txtConNo
            // 
            this.txtConNo.Location = new System.Drawing.Point(327, 218);
            this.txtConNo.Name = "txtConNo";
            this.txtConNo.Size = new System.Drawing.Size(360, 30);
            this.txtConNo.TabIndex = 2;
            // 
            // txtLicNo
            // 
            this.txtLicNo.Location = new System.Drawing.Point(327, 156);
            this.txtLicNo.Name = "txtLicNo";
            this.txtLicNo.Size = new System.Drawing.Size(360, 30);
            this.txtLicNo.TabIndex = 1;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(327, 51);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(360, 30);
            this.txtFName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1519, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1519, 541);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 37);
            this.button2.TabIndex = 15;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(1311, 987);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ayubo Leisure (Pvt) Ltd";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearch.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Small Car",
            "Sedan Car",
            "SVUs",
            "Jeep(WD)",
            "7-seater Van",
            "Commuter Van"});
            this.comboBoxSearch.Location = new System.Drawing.Point(1266, 31);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(349, 33);
            this.comboBoxSearch.TabIndex = 20;
            this.comboBoxSearch.Text = "Search a vehicle";
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1780, 1031);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Data showing and changing";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AyuboLeisureDataSet ayuboLeisureDataSet;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private AyuboLeisureDataSetTableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox txtMrate;
        private System.Windows.Forms.TextBox txtWrate;
        private System.Windows.Forms.TextBox txtDrate;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDriverRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConNo;
        private System.Windows.Forms.TextBox txtLicNo;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleRegistrationnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverLicenseNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverContactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.ComboBox comboBoxSearch;
    }
}