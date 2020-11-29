namespace Ayubo_Leasing_VRMS
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dayPackIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTelNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleRegNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDifferencehoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmDifferenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waitingChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraKmChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayHireTravellingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ayuboLeisureDataSet5 = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet5();
            this.dayHireTravellingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Butsearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.day_Hire_TravellingTableAdapter1 = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet5TableAdapters.Day_Hire_TravellingTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayHireTravellingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayHireTravellingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1846, 713);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Journey Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayPackIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.customerFNameDataGridViewTextBoxColumn,
            this.customerLNameDataGridViewTextBoxColumn,
            this.customerTelNODataGridViewTextBoxColumn,
            this.packageNameDataGridViewTextBoxColumn,
            this.vehicleRegNODataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.timeDifferencehoursDataGridViewTextBoxColumn,
            this.extraHoursDataGridViewTextBoxColumn,
            this.startKmDataGridViewTextBoxColumn,
            this.endKmDataGridViewTextBoxColumn,
            this.kmDifferenceDataGridViewTextBoxColumn,
            this.extraKmDataGridViewTextBoxColumn,
            this.baseChargeDataGridViewTextBoxColumn,
            this.waitingChargeDataGridViewTextBoxColumn,
            this.extraKmChargeDataGridViewTextBoxColumn,
            this.totalChargeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dayHireTravellingBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(20, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1800, 637);
            this.dataGridView1.TabIndex = 0;
            // 
            // dayPackIDDataGridViewTextBoxColumn
            // 
            this.dayPackIDDataGridViewTextBoxColumn.DataPropertyName = "Day_Pack_ID";
            this.dayPackIDDataGridViewTextBoxColumn.HeaderText = "Day_Pack_ID";
            this.dayPackIDDataGridViewTextBoxColumn.Name = "dayPackIDDataGridViewTextBoxColumn";
            this.dayPackIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // customerFNameDataGridViewTextBoxColumn
            // 
            this.customerFNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_FName";
            this.customerFNameDataGridViewTextBoxColumn.HeaderText = "Customer_FName";
            this.customerFNameDataGridViewTextBoxColumn.Name = "customerFNameDataGridViewTextBoxColumn";
            // 
            // customerLNameDataGridViewTextBoxColumn
            // 
            this.customerLNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_LName";
            this.customerLNameDataGridViewTextBoxColumn.HeaderText = "Customer_LName";
            this.customerLNameDataGridViewTextBoxColumn.Name = "customerLNameDataGridViewTextBoxColumn";
            // 
            // customerTelNODataGridViewTextBoxColumn
            // 
            this.customerTelNODataGridViewTextBoxColumn.DataPropertyName = "Customer_Tel_NO";
            this.customerTelNODataGridViewTextBoxColumn.HeaderText = "Customer_Tel_NO";
            this.customerTelNODataGridViewTextBoxColumn.Name = "customerTelNODataGridViewTextBoxColumn";
            // 
            // packageNameDataGridViewTextBoxColumn
            // 
            this.packageNameDataGridViewTextBoxColumn.DataPropertyName = "Package_Name";
            this.packageNameDataGridViewTextBoxColumn.HeaderText = "Package_Name";
            this.packageNameDataGridViewTextBoxColumn.Name = "packageNameDataGridViewTextBoxColumn";
            // 
            // vehicleRegNODataGridViewTextBoxColumn
            // 
            this.vehicleRegNODataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Reg_NO";
            this.vehicleRegNODataGridViewTextBoxColumn.HeaderText = "Vehicle_Reg_NO";
            this.vehicleRegNODataGridViewTextBoxColumn.Name = "vehicleRegNODataGridViewTextBoxColumn";
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "Start_Time";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Start_Time";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "End_Time";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "End_Time";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            // 
            // timeDifferencehoursDataGridViewTextBoxColumn
            // 
            this.timeDifferencehoursDataGridViewTextBoxColumn.DataPropertyName = "Time_Difference_hours";
            this.timeDifferencehoursDataGridViewTextBoxColumn.HeaderText = "Time_Difference_hours";
            this.timeDifferencehoursDataGridViewTextBoxColumn.Name = "timeDifferencehoursDataGridViewTextBoxColumn";
            // 
            // extraHoursDataGridViewTextBoxColumn
            // 
            this.extraHoursDataGridViewTextBoxColumn.DataPropertyName = "Extra_Hours";
            this.extraHoursDataGridViewTextBoxColumn.HeaderText = "Extra_Hours";
            this.extraHoursDataGridViewTextBoxColumn.Name = "extraHoursDataGridViewTextBoxColumn";
            // 
            // startKmDataGridViewTextBoxColumn
            // 
            this.startKmDataGridViewTextBoxColumn.DataPropertyName = "Start_Km";
            this.startKmDataGridViewTextBoxColumn.HeaderText = "Start_Km";
            this.startKmDataGridViewTextBoxColumn.Name = "startKmDataGridViewTextBoxColumn";
            // 
            // endKmDataGridViewTextBoxColumn
            // 
            this.endKmDataGridViewTextBoxColumn.DataPropertyName = "End_Km";
            this.endKmDataGridViewTextBoxColumn.HeaderText = "End_Km";
            this.endKmDataGridViewTextBoxColumn.Name = "endKmDataGridViewTextBoxColumn";
            // 
            // kmDifferenceDataGridViewTextBoxColumn
            // 
            this.kmDifferenceDataGridViewTextBoxColumn.DataPropertyName = "Km_Difference";
            this.kmDifferenceDataGridViewTextBoxColumn.HeaderText = "Km_Difference";
            this.kmDifferenceDataGridViewTextBoxColumn.Name = "kmDifferenceDataGridViewTextBoxColumn";
            // 
            // extraKmDataGridViewTextBoxColumn
            // 
            this.extraKmDataGridViewTextBoxColumn.DataPropertyName = "Extra_Km";
            this.extraKmDataGridViewTextBoxColumn.HeaderText = "Extra_Km";
            this.extraKmDataGridViewTextBoxColumn.Name = "extraKmDataGridViewTextBoxColumn";
            // 
            // baseChargeDataGridViewTextBoxColumn
            // 
            this.baseChargeDataGridViewTextBoxColumn.DataPropertyName = "Base_Charge";
            this.baseChargeDataGridViewTextBoxColumn.HeaderText = "Base_Charge";
            this.baseChargeDataGridViewTextBoxColumn.Name = "baseChargeDataGridViewTextBoxColumn";
            // 
            // waitingChargeDataGridViewTextBoxColumn
            // 
            this.waitingChargeDataGridViewTextBoxColumn.DataPropertyName = "Waiting_Charge";
            this.waitingChargeDataGridViewTextBoxColumn.HeaderText = "Waiting_Charge";
            this.waitingChargeDataGridViewTextBoxColumn.Name = "waitingChargeDataGridViewTextBoxColumn";
            // 
            // extraKmChargeDataGridViewTextBoxColumn
            // 
            this.extraKmChargeDataGridViewTextBoxColumn.DataPropertyName = "Extra_Km_Charge";
            this.extraKmChargeDataGridViewTextBoxColumn.HeaderText = "Extra_Km_Charge";
            this.extraKmChargeDataGridViewTextBoxColumn.Name = "extraKmChargeDataGridViewTextBoxColumn";
            // 
            // totalChargeDataGridViewTextBoxColumn
            // 
            this.totalChargeDataGridViewTextBoxColumn.DataPropertyName = "Total_Charge";
            this.totalChargeDataGridViewTextBoxColumn.HeaderText = "Total_Charge";
            this.totalChargeDataGridViewTextBoxColumn.Name = "totalChargeDataGridViewTextBoxColumn";
            // 
            // dayHireTravellingBindingSource1
            // 
            this.dayHireTravellingBindingSource1.DataMember = "Day_Hire_Travelling";
            this.dayHireTravellingBindingSource1.DataSource = this.ayuboLeisureDataSet5;
            // 
            // ayuboLeisureDataSet5
            // 
            this.ayuboLeisureDataSet5.DataSetName = "AyuboLeisureDataSet5";
            this.ayuboLeisureDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dayHireTravellingBindingSource
            // 
            this.dayHireTravellingBindingSource.DataMember = "Day_Hire_Travelling";
            // 
            // Butsearch
            // 
            this.Butsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butsearch.Location = new System.Drawing.Point(1234, 50);
            this.Butsearch.Name = "Butsearch";
            this.Butsearch.Size = new System.Drawing.Size(129, 40);
            this.Butsearch.TabIndex = 1;
            this.Butsearch.Text = "Search";
            this.Butsearch.UseVisualStyleBackColor = true;
            this.Butsearch.Click += new System.EventHandler(this.Butsearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1390, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(477, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search by customer name...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.DoubleClick += new System.EventHandler(this.txtSearch_DoubleClick);
            // 
            // day_Hire_TravellingTableAdapter1
            // 
            this.day_Hire_TravellingTableAdapter1.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1924, 852);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Butsearch);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.Text = "Showing data";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayHireTravellingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayHireTravellingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        
        private System.Windows.Forms.BindingSource dayHireTravellingBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn dayPackIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTelNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleRegNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDifferencehoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmDifferenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waitingChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraKmChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Butsearch;
        private System.Windows.Forms.TextBox txtSearch;
        private AyuboLeisureDataSet5 ayuboLeisureDataSet5;
        private System.Windows.Forms.BindingSource dayHireTravellingBindingSource1;
        private AyuboLeisureDataSet5TableAdapters.Day_Hire_TravellingTableAdapter day_Hire_TravellingTableAdapter1;
    }
}