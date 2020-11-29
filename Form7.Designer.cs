namespace Ayubo_Leasing_VRMS
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxVType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPacName = new System.Windows.Forms.TextBox();
            this.txtExtraKmRate = new System.Windows.Forms.TextBox();
            this.txtMaxKm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHourRate = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtMHours = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.dayPackagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ayuboLeisureDataSet2 = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.packageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraHourRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxKMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraKMRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayPackagesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ayuboLeisureDataSet9 = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet9();
            this.delete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ayuboLeisureDataSet = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet();
            this.ayuboLeisureDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.day_PackagesTableAdapter = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet2TableAdapters.Day_PackagesTableAdapter();
            this.ayuboLeisureDataSet8 = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet8();
            this.dayPackagesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.day_PackagesTableAdapter1 = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet8TableAdapters.Day_PackagesTableAdapter();
            this.day_PackagesTableAdapter2 = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet9TableAdapters.Day_PackagesTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayPackagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPackagesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPackagesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxVType);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPacName);
            this.groupBox2.Controls.Add(this.txtExtraKmRate);
            this.groupBox2.Controls.Add(this.txtMaxKm);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtHourRate);
            this.groupBox2.Controls.Add(this.txtRate);
            this.groupBox2.Controls.Add(this.txtMHours);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 469);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Package Information";
            // 
            // comboBoxVType
            // 
            this.comboBoxVType.FormattingEnabled = true;
            this.comboBoxVType.Location = new System.Drawing.Point(221, 108);
            this.comboBoxVType.Name = "comboBoxVType";
            this.comboBoxVType.Size = new System.Drawing.Size(313, 28);
            this.comboBoxVType.TabIndex = 25;
            this.comboBoxVType.Text = "Select Vehicle Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Vehicle Type";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 419);
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
            this.txtPacName.Location = new System.Drawing.Point(221, 49);
            this.txtPacName.Name = "txtPacName";
            this.txtPacName.Size = new System.Drawing.Size(313, 30);
            this.txtPacName.TabIndex = 13;
            // 
            // txtExtraKmRate
            // 
            this.txtExtraKmRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraKmRate.Location = new System.Drawing.Point(221, 357);
            this.txtExtraKmRate.Name = "txtExtraKmRate";
            this.txtExtraKmRate.Size = new System.Drawing.Size(313, 30);
            this.txtExtraKmRate.TabIndex = 11;
            // 
            // txtMaxKm
            // 
            this.txtMaxKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxKm.Location = new System.Drawing.Point(221, 307);
            this.txtMaxKm.Name = "txtMaxKm";
            this.txtMaxKm.Size = new System.Drawing.Size(313, 30);
            this.txtMaxKm.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Extra Km Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rate of package";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Max Km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Max Hours";
            // 
            // txtHourRate
            // 
            this.txtHourRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourRate.Location = new System.Drawing.Point(221, 256);
            this.txtHourRate.Name = "txtHourRate";
            this.txtHourRate.Size = new System.Drawing.Size(313, 30);
            this.txtHourRate.TabIndex = 7;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(221, 155);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(313, 30);
            this.txtRate.TabIndex = 4;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            // 
            // txtMHours
            // 
            this.txtMHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMHours.Location = new System.Drawing.Point(221, 204);
            this.txtMHours.Name = "txtMHours";
            this.txtMHours.Size = new System.Drawing.Size(313, 30);
            this.txtMHours.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Extra Hour Rate";
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(657, 457);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(198, 35);
            this.update.TabIndex = 15;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // dayPackagesBindingSource
            // 
            this.dayPackagesBindingSource.DataMember = "Day_Packages";
            this.dayPackagesBindingSource.DataSource = this.ayuboLeisureDataSet2;
            // 
            // ayuboLeisureDataSet2
            // 
            this.ayuboLeisureDataSet2.DataSetName = "AyuboLeisureDataSet2";
            this.ayuboLeisureDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(618, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1039, 412);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packageNameDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.maxHoursDataGridViewTextBoxColumn,
            this.extraHourRateDataGridViewTextBoxColumn,
            this.maxKMDataGridViewTextBoxColumn,
            this.extraKMRateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dayPackagesBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(29, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(971, 316);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // packageNameDataGridViewTextBoxColumn
            // 
            this.packageNameDataGridViewTextBoxColumn.DataPropertyName = "Package_Name";
            this.packageNameDataGridViewTextBoxColumn.HeaderText = "Package_Name";
            this.packageNameDataGridViewTextBoxColumn.Name = "packageNameDataGridViewTextBoxColumn";
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Type";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "Vehicle_Type";
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            // 
            // maxHoursDataGridViewTextBoxColumn
            // 
            this.maxHoursDataGridViewTextBoxColumn.DataPropertyName = "Max_Hours";
            this.maxHoursDataGridViewTextBoxColumn.HeaderText = "Max_Hours";
            this.maxHoursDataGridViewTextBoxColumn.Name = "maxHoursDataGridViewTextBoxColumn";
            // 
            // extraHourRateDataGridViewTextBoxColumn
            // 
            this.extraHourRateDataGridViewTextBoxColumn.DataPropertyName = "Extra_Hour_Rate";
            this.extraHourRateDataGridViewTextBoxColumn.HeaderText = "Extra_Hour_Rate";
            this.extraHourRateDataGridViewTextBoxColumn.Name = "extraHourRateDataGridViewTextBoxColumn";
            // 
            // maxKMDataGridViewTextBoxColumn
            // 
            this.maxKMDataGridViewTextBoxColumn.DataPropertyName = "Max_KM";
            this.maxKMDataGridViewTextBoxColumn.HeaderText = "Max_KM";
            this.maxKMDataGridViewTextBoxColumn.Name = "maxKMDataGridViewTextBoxColumn";
            // 
            // extraKMRateDataGridViewTextBoxColumn
            // 
            this.extraKMRateDataGridViewTextBoxColumn.DataPropertyName = "Extra_KM_Rate";
            this.extraKMRateDataGridViewTextBoxColumn.HeaderText = "Extra_KM_Rate";
            this.extraKMRateDataGridViewTextBoxColumn.Name = "extraKMRateDataGridViewTextBoxColumn";
            // 
            // dayPackagesBindingSource2
            // 
            this.dayPackagesBindingSource2.DataMember = "Day_Packages";
            this.dayPackagesBindingSource2.DataSource = this.ayuboLeisureDataSet9;
            // 
            // ayuboLeisureDataSet9
            // 
            this.ayuboLeisureDataSet9.DataSetName = "AyuboLeisureDataSet9";
            this.ayuboLeisureDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(889, 457);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(198, 35);
            this.delete.TabIndex = 18;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1109, 457);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(548, 33);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Text = "Searching by package name... ";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ayuboLeisureDataSet
            // 
            this.ayuboLeisureDataSet.DataSetName = "AyuboLeisureDataSet";
            this.ayuboLeisureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ayuboLeisureDataSetBindingSource
            // 
            this.ayuboLeisureDataSetBindingSource.DataSource = this.ayuboLeisureDataSet;
            this.ayuboLeisureDataSetBindingSource.Position = 0;
            // 
            // day_PackagesTableAdapter
            // 
            this.day_PackagesTableAdapter.ClearBeforeFill = true;
            // 
            // ayuboLeisureDataSet8
            // 
            this.ayuboLeisureDataSet8.DataSetName = "AyuboLeisureDataSet8";
            this.ayuboLeisureDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dayPackagesBindingSource1
            // 
            this.dayPackagesBindingSource1.DataMember = "Day_Packages";
            this.dayPackagesBindingSource1.DataSource = this.ayuboLeisureDataSet8;
            // 
            // day_PackagesTableAdapter1
            // 
            this.day_PackagesTableAdapter1.ClearBeforeFill = true;
            // 
            // day_PackagesTableAdapter2
            // 
            this.day_PackagesTableAdapter2.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1669, 574);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "Day Packages";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayPackagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPackagesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPackagesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPacName;
        private System.Windows.Forms.TextBox txtExtraKmRate;
        private System.Windows.Forms.TextBox txtMaxKm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHourRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtMHours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource ayuboLeisureDataSetBindingSource;
        private AyuboLeisureDataSet ayuboLeisureDataSet;
        private AyuboLeisureDataSet2 ayuboLeisureDataSet2;
        private System.Windows.Forms.BindingSource dayPackagesBindingSource;
        private AyuboLeisureDataSet2TableAdapters.Day_PackagesTableAdapter day_PackagesTableAdapter;
        private AyuboLeisureDataSet8 ayuboLeisureDataSet8;
        private System.Windows.Forms.BindingSource dayPackagesBindingSource1;
        private AyuboLeisureDataSet8TableAdapters.Day_PackagesTableAdapter day_PackagesTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AyuboLeisureDataSet9 ayuboLeisureDataSet9;
        private System.Windows.Forms.BindingSource dayPackagesBindingSource2;
        private AyuboLeisureDataSet9TableAdapters.Day_PackagesTableAdapter day_PackagesTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraHourRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxKMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraKMRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxVType;
        private System.Windows.Forms.Label label9;
    }
}