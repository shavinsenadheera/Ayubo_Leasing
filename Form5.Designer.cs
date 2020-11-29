namespace Ayubo_Leasing_VRMS
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerContactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weeksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleRegistrationNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.withDriverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentTravellingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ayuboLeisureDataSet1 = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet1();
            this.rent_TravellingTableAdapter = new Ayubo_Leasing_VRMS.AyuboLeisureDataSet1TableAdapters.Rent_TravellingTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentTravellingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1900, 689);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Showing Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentIDDataGridViewTextBoxColumn,
            this.customerFirstNameDataGridViewTextBoxColumn,
            this.customerLastNameDataGridViewTextBoxColumn,
            this.customerIDNoDataGridViewTextBoxColumn,
            this.customerContactNoDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.monthsDataGridViewTextBoxColumn,
            this.weeksDataGridViewTextBoxColumn,
            this.daysDataGridViewTextBoxColumn,
            this.vehicleRegistrationNoDataGridViewTextBoxColumn,
            this.withDriverDataGridViewTextBoxColumn,
            this.timeCostDataGridViewTextBoxColumn,
            this.driverCostDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rentTravellingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1888, 633);
            this.dataGridView1.TabIndex = 0;
            // 
            // rentIDDataGridViewTextBoxColumn
            // 
            this.rentIDDataGridViewTextBoxColumn.DataPropertyName = "Rent_ID";
            this.rentIDDataGridViewTextBoxColumn.HeaderText = "Rent_ID";
            this.rentIDDataGridViewTextBoxColumn.Name = "rentIDDataGridViewTextBoxColumn";
            this.rentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerFirstNameDataGridViewTextBoxColumn
            // 
            this.customerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_First_Name";
            this.customerFirstNameDataGridViewTextBoxColumn.HeaderText = "Customer_First_Name";
            this.customerFirstNameDataGridViewTextBoxColumn.Name = "customerFirstNameDataGridViewTextBoxColumn";
            // 
            // customerLastNameDataGridViewTextBoxColumn
            // 
            this.customerLastNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_Last_Name";
            this.customerLastNameDataGridViewTextBoxColumn.HeaderText = "Customer_Last_Name";
            this.customerLastNameDataGridViewTextBoxColumn.Name = "customerLastNameDataGridViewTextBoxColumn";
            // 
            // customerIDNoDataGridViewTextBoxColumn
            // 
            this.customerIDNoDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID_No";
            this.customerIDNoDataGridViewTextBoxColumn.HeaderText = "Customer_ID_No";
            this.customerIDNoDataGridViewTextBoxColumn.Name = "customerIDNoDataGridViewTextBoxColumn";
            // 
            // customerContactNoDataGridViewTextBoxColumn
            // 
            this.customerContactNoDataGridViewTextBoxColumn.DataPropertyName = "Customer_Contact_No";
            this.customerContactNoDataGridViewTextBoxColumn.HeaderText = "Customer_Contact_No";
            this.customerContactNoDataGridViewTextBoxColumn.Name = "customerContactNoDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "Start_Date";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Start_Date";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "End_Date";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "End_Date";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // monthsDataGridViewTextBoxColumn
            // 
            this.monthsDataGridViewTextBoxColumn.DataPropertyName = "Months";
            this.monthsDataGridViewTextBoxColumn.HeaderText = "Months";
            this.monthsDataGridViewTextBoxColumn.Name = "monthsDataGridViewTextBoxColumn";
            // 
            // weeksDataGridViewTextBoxColumn
            // 
            this.weeksDataGridViewTextBoxColumn.DataPropertyName = "Weeks";
            this.weeksDataGridViewTextBoxColumn.HeaderText = "Weeks";
            this.weeksDataGridViewTextBoxColumn.Name = "weeksDataGridViewTextBoxColumn";
            // 
            // daysDataGridViewTextBoxColumn
            // 
            this.daysDataGridViewTextBoxColumn.DataPropertyName = "Days";
            this.daysDataGridViewTextBoxColumn.HeaderText = "Days";
            this.daysDataGridViewTextBoxColumn.Name = "daysDataGridViewTextBoxColumn";
            // 
            // vehicleRegistrationNoDataGridViewTextBoxColumn
            // 
            this.vehicleRegistrationNoDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Registration_No";
            this.vehicleRegistrationNoDataGridViewTextBoxColumn.HeaderText = "Vehicle_Registration_No";
            this.vehicleRegistrationNoDataGridViewTextBoxColumn.Name = "vehicleRegistrationNoDataGridViewTextBoxColumn";
            // 
            // withDriverDataGridViewTextBoxColumn
            // 
            this.withDriverDataGridViewTextBoxColumn.DataPropertyName = "With_Driver";
            this.withDriverDataGridViewTextBoxColumn.HeaderText = "With_Driver";
            this.withDriverDataGridViewTextBoxColumn.Name = "withDriverDataGridViewTextBoxColumn";
            // 
            // timeCostDataGridViewTextBoxColumn
            // 
            this.timeCostDataGridViewTextBoxColumn.DataPropertyName = "Time_Cost";
            this.timeCostDataGridViewTextBoxColumn.HeaderText = "Time_Cost";
            this.timeCostDataGridViewTextBoxColumn.Name = "timeCostDataGridViewTextBoxColumn";
            // 
            // driverCostDataGridViewTextBoxColumn
            // 
            this.driverCostDataGridViewTextBoxColumn.DataPropertyName = "Driver_Cost";
            this.driverCostDataGridViewTextBoxColumn.HeaderText = "Driver_Cost";
            this.driverCostDataGridViewTextBoxColumn.Name = "driverCostDataGridViewTextBoxColumn";
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total_Amount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Total_Amount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            // 
            // rentTravellingBindingSource
            // 
            this.rentTravellingBindingSource.DataMember = "Rent_Travelling";
            this.rentTravellingBindingSource.DataSource = this.ayuboLeisureDataSet1;
            // 
            // ayuboLeisureDataSet1
            // 
            this.ayuboLeisureDataSet1.DataSetName = "AyuboLeisureDataSet1";
            this.ayuboLeisureDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rent_TravellingTableAdapter
            // 
            this.rent_TravellingTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1286, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(465, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Searching by customer name......";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1123, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Maroon;
            this.label24.Location = new System.Drawing.Point(1596, 779);
            this.label24.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(310, 32);
            this.label24.TabIndex = 22;
            this.label24.Text = "Ayubo Leisure (Pvt) Ltd";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1924, 890);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Showing and Searching";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentTravellingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboLeisureDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AyuboLeisureDataSet1 ayuboLeisureDataSet1;
        private System.Windows.Forms.BindingSource rentTravellingBindingSource;
        private AyuboLeisureDataSet1TableAdapters.Rent_TravellingTableAdapter rent_TravellingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerContactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weeksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleRegistrationNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn withDriverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label24;
    }
}