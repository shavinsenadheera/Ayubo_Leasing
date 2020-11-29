namespace Ayubo_Leasing_VRMS
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longHirePackagesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ayuboLeisureDataSet6 = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet6();
            this.longHirePackagesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.longHirePackagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ayuboLeisureDataSet4 = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet4();
            this.update = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxVType = new System.Windows.Forms.ComboBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaxDays = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPacName = new System.Windows.Forms.TextBox();
            this.txtExtraKmRate = new System.Windows.Forms.TextBox();
            this.txtNparkRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOnightRate = new System.Windows.Forms.TextBox();
            this.txtMaxKmday = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.long_Hire_PackagesTableAdapter = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet4TableAdapters.Long_Hire_PackagesTableAdapter();
            this.longHirePackagesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.long_Hire_PackagesTableAdapter2 = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet6TableAdapters.Long_Hire_PackagesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longHirePackagesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longHirePackagesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longHirePackagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.longHirePackagesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1135, 463);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(548, 33);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Text = "Searching by package name... ";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(915, 463);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(198, 35);
            this.delete.TabIndex = 23;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(664, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1146, 412);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.vehicleTypeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.DataSource = this.longHirePackagesBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(19, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1108, 361);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Package_Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Package_Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Type";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "Vehicle_Type";
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Rate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Max_Km_perday";
            this.dataGridViewTextBoxColumn3.HeaderText = "Max_Km_perday";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Max_days";
            this.dataGridViewTextBoxColumn4.HeaderText = "Max_days";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Driver_over_nightRate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Driver_over_nightRate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Vahical_night_parkRate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Vahical_night_parkRate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Extra_km_rate";
            this.dataGridViewTextBoxColumn7.HeaderText = "Extra_km_rate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // longHirePackagesBindingSource3
            // 
            this.longHirePackagesBindingSource3.DataMember = "Long_Hire_Packages";
            this.longHirePackagesBindingSource3.DataSource = this.ayuboLeisureDataSet6;
            // 
            // ayuboLeisureDataSet6
            // 
            this.ayuboLeisureDataSet6.DataSetName = "AyuboLeisureDataSet6";
            this.ayuboLeisureDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // longHirePackagesBindingSource2
            // 
            this.longHirePackagesBindingSource2.DataMember = "Long_Hire_Packages";
            // 
            // longHirePackagesBindingSource
            // 
            this.longHirePackagesBindingSource.DataMember = "Long_Hire_Packages";
            this.longHirePackagesBindingSource.DataSource = this.ayuboLeisureDataSet4;
            // 
            // ayuboLeisureDataSet4
            // 
            this.ayuboLeisureDataSet4.DataSetName = "AyuboLeisureDataSet4";
            this.ayuboLeisureDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(683, 463);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(198, 35);
            this.update.TabIndex = 21;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxVType);
            this.groupBox2.Controls.Add(this.txtRate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMaxDays);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPacName);
            this.groupBox2.Controls.Add(this.txtExtraKmRate);
            this.groupBox2.Controls.Add(this.txtNparkRate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtOnightRate);
            this.groupBox2.Controls.Add(this.txtMaxKmday);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 522);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Package Information";
            // 
            // comboBoxVType
            // 
            this.comboBoxVType.FormattingEnabled = true;
            this.comboBoxVType.Location = new System.Drawing.Point(259, 103);
            this.comboBoxVType.Name = "comboBoxVType";
            this.comboBoxVType.Size = new System.Drawing.Size(313, 28);
            this.comboBoxVType.TabIndex = 23;
            this.comboBoxVType.Text = "Select Vehicle Type";
            this.comboBoxVType.SelectedIndexChanged += new System.EventHandler(this.comboBoxVType_SelectedIndexChanged);
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(259, 146);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(313, 30);
            this.txtRate.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Vehicle Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Rate of package";
            // 
            // txtMaxDays
            // 
            this.txtMaxDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxDays.Location = new System.Drawing.Point(259, 242);
            this.txtMaxDays.Name = "txtMaxDays";
            this.txtMaxDays.Size = new System.Drawing.Size(313, 30);
            this.txtMaxDays.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Max days";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name of package";
            // 
            // txtPacName
            // 
            this.txtPacName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPacName.Location = new System.Drawing.Point(259, 49);
            this.txtPacName.Name = "txtPacName";
            this.txtPacName.Size = new System.Drawing.Size(313, 30);
            this.txtPacName.TabIndex = 13;
            // 
            // txtExtraKmRate
            // 
            this.txtExtraKmRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraKmRate.Location = new System.Drawing.Point(259, 390);
            this.txtExtraKmRate.Name = "txtExtraKmRate";
            this.txtExtraKmRate.Size = new System.Drawing.Size(313, 30);
            this.txtExtraKmRate.TabIndex = 11;
            // 
            // txtNparkRate
            // 
            this.txtNparkRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNparkRate.Location = new System.Drawing.Point(259, 342);
            this.txtNparkRate.Name = "txtNparkRate";
            this.txtNparkRate.Size = new System.Drawing.Size(313, 30);
            this.txtNparkRate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Extra Km Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Driver Overnight Rate ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vehcle night park rate";
            // 
            // txtOnightRate
            // 
            this.txtOnightRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOnightRate.Location = new System.Drawing.Point(259, 289);
            this.txtOnightRate.Name = "txtOnightRate";
            this.txtOnightRate.Size = new System.Drawing.Size(313, 30);
            this.txtOnightRate.TabIndex = 7;
            // 
            // txtMaxKmday
            // 
            this.txtMaxKmday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxKmday.Location = new System.Drawing.Point(259, 192);
            this.txtMaxKmday.Name = "txtMaxKmday";
            this.txtMaxKmday.Size = new System.Drawing.Size(313, 30);
            this.txtMaxKmday.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max km/day";
            // 
            // long_Hire_PackagesTableAdapter
            // 
            this.long_Hire_PackagesTableAdapter.ClearBeforeFill = true;
            // 
            // longHirePackagesBindingSource1
            // 
            this.longHirePackagesBindingSource1.DataMember = "Long_Hire_Packages";
            // 
            // long_Hire_PackagesTableAdapter2
            // 
            this.long_Hire_PackagesTableAdapter2.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1839, 563);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form9";
            this.Text = "Long Hire Packages";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longHirePackagesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longHirePackagesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longHirePackagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.longHirePackagesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPacName;
        private System.Windows.Forms.TextBox txtExtraKmRate;
        private System.Windows.Forms.TextBox txtNparkRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOnightRate;
        private System.Windows.Forms.TextBox txtMaxKmday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxDays;
        private System.Windows.Forms.Label label7;
        private AyuboLeisureDataSet4 ayuboLeisureDataSet4;
        private System.Windows.Forms.BindingSource longHirePackagesBindingSource;
        private AyuboLeisureDataSet4TableAdapters.Long_Hire_PackagesTableAdapter long_Hire_PackagesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxKmperdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxdaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverovernightRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vahicalnightparkRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extrakmrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxVType;
        private AyuboLeisureDataSet3 ayuboLeisureDataSet3;
        private System.Windows.Forms.BindingSource longHirePackagesBindingSource1;
        private AyuboLeisureDataSet3TableAdapters.Long_Hire_PackagesTableAdapter long_Hire_PackagesTableAdapter1;

        private System.Windows.Forms.BindingSource longHirePackagesBindingSource2;
        private AyuboLeisureDataSet6 ayuboLeisureDataSet6;
        private System.Windows.Forms.BindingSource longHirePackagesBindingSource3;
        private AyuboLeisureDataSet6TableAdapters.Long_Hire_PackagesTableAdapter long_Hire_PackagesTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}