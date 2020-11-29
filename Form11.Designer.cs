namespace Ayubo_Leasing_VRMS
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dayPackIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTelNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleRegNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.journeyDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moreDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moreKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waitingChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraKmChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longDayHireTravellingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ayuboLeisureDataSet7 = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet7();
            this.long_Day_Hire_TravellingTableAdapter = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet7TableAdapters.Long_Day_Hire_TravellingTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Butsearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longDayHireTravellingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(79, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1292, 596);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Showing Data";
            // 
            // dataGridView1
            // 
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
            this.startDayDataGridViewTextBoxColumn,
            this.endDayDataGridViewTextBoxColumn,
            this.journeyDaysDataGridViewTextBoxColumn,
            this.moreDaysDataGridViewTextBoxColumn,
            this.startKmDataGridViewTextBoxColumn,
            this.endKmDataGridViewTextBoxColumn,
            this.totalKmDataGridViewTextBoxColumn,
            this.moreKmDataGridViewTextBoxColumn,
            this.baseChargeDataGridViewTextBoxColumn,
            this.waitingChargeDataGridViewTextBoxColumn,
            this.extraKmChargeDataGridViewTextBoxColumn,
            this.totalChargeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.longDayHireTravellingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1212, 510);
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
            // startDayDataGridViewTextBoxColumn
            // 
            this.startDayDataGridViewTextBoxColumn.DataPropertyName = "Start_Day";
            this.startDayDataGridViewTextBoxColumn.HeaderText = "Start_Day";
            this.startDayDataGridViewTextBoxColumn.Name = "startDayDataGridViewTextBoxColumn";
            // 
            // endDayDataGridViewTextBoxColumn
            // 
            this.endDayDataGridViewTextBoxColumn.DataPropertyName = "End_Day";
            this.endDayDataGridViewTextBoxColumn.HeaderText = "End_Day";
            this.endDayDataGridViewTextBoxColumn.Name = "endDayDataGridViewTextBoxColumn";
            // 
            // journeyDaysDataGridViewTextBoxColumn
            // 
            this.journeyDaysDataGridViewTextBoxColumn.DataPropertyName = "Journey_Days";
            this.journeyDaysDataGridViewTextBoxColumn.HeaderText = "Journey_Days";
            this.journeyDaysDataGridViewTextBoxColumn.Name = "journeyDaysDataGridViewTextBoxColumn";
            // 
            // moreDaysDataGridViewTextBoxColumn
            // 
            this.moreDaysDataGridViewTextBoxColumn.DataPropertyName = "More_Days";
            this.moreDaysDataGridViewTextBoxColumn.HeaderText = "More_Days";
            this.moreDaysDataGridViewTextBoxColumn.Name = "moreDaysDataGridViewTextBoxColumn";
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
            // totalKmDataGridViewTextBoxColumn
            // 
            this.totalKmDataGridViewTextBoxColumn.DataPropertyName = "Total_Km";
            this.totalKmDataGridViewTextBoxColumn.HeaderText = "Total_Km";
            this.totalKmDataGridViewTextBoxColumn.Name = "totalKmDataGridViewTextBoxColumn";
            // 
            // moreKmDataGridViewTextBoxColumn
            // 
            this.moreKmDataGridViewTextBoxColumn.DataPropertyName = "More_Km";
            this.moreKmDataGridViewTextBoxColumn.HeaderText = "More_Km";
            this.moreKmDataGridViewTextBoxColumn.Name = "moreKmDataGridViewTextBoxColumn";
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
            // longDayHireTravellingBindingSource
            // 
            this.longDayHireTravellingBindingSource.DataMember = "Long_Day_Hire_Travelling";
            this.longDayHireTravellingBindingSource.DataSource = this.ayuboLeisureDataSet7;
            // 
            // ayuboLeisureDataSet7
            // 
            this.ayuboLeisureDataSet7.DataSetName = "AyuboLeisureDataSet7";
            this.ayuboLeisureDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // long_Day_Hire_TravellingTableAdapter
            // 
            this.long_Day_Hire_TravellingTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(842, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(477, 30);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Text = "Search by customer name...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.DoubleClick += new System.EventHandler(this.txtSearch_DoubleClick);
            // 
            // Butsearch
            // 
            this.Butsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butsearch.Location = new System.Drawing.Point(686, 20);
            this.Butsearch.Name = "Butsearch";
            this.Butsearch.Size = new System.Drawing.Size(129, 40);
            this.Butsearch.TabIndex = 3;
            this.Butsearch.Text = "Search";
            this.Butsearch.UseVisualStyleBackColor = true;
            this.Butsearch.Click += new System.EventHandler(this.Butsearch_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1493, 734);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Butsearch);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form11";
            this.Text = "Showing Data";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longDayHireTravellingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AyuboLeisureDataSet7 ayuboLeisureDataSet7;
        private System.Windows.Forms.BindingSource longDayHireTravellingBindingSource;
        private AyuboLeisureDataSet7TableAdapters.Long_Day_Hire_TravellingTableAdapter long_Day_Hire_TravellingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayPackIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTelNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleRegNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn journeyDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moreDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moreKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waitingChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraKmChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button Butsearch;
    }
}