namespace WindowsFormsApplication1
{
    partial class AddTicket
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.seatTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данных2DataSet = new WindowsFormsApplication1.База_данных2DataSet();
            this.seatsTicketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDownClientID = new System.Windows.Forms.NumericUpDown();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDownSeatID = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.seatsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.seatsTableAdapter = new WindowsFormsApplication1.База_данных2DataSetTableAdapters.SeatsTableAdapter();
            this.clientsTableAdapter = new WindowsFormsApplication1.База_данных2DataSetTableAdapters.ClientsTableAdapter();
            this.ticketsTableAdapter = new WindowsFormsApplication1.База_данных2DataSetTableAdapters.TicketsTableAdapter();
            this.numericUpDownRaceID = new System.Windows.Forms.NumericUpDown();
            this.RaceDataGroupBox = new System.Windows.Forms.GroupBox();
            this.labelTra = new System.Windows.Forms.Label();
            this.labelDat = new System.Windows.Forms.Label();
            this.labelDes = new System.Windows.Forms.Label();
            this.labelDep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsTicketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClientID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeatID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRaceID)).BeginInit();
            this.RaceDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Race ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Seat";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seatIDDataGridViewTextBoxColumn,
            this.reservedDataGridViewCheckBoxColumn,
            this.seatTypeDataGridViewTextBoxColumn,
            this.raceIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.seatsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(181, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 209);
            this.dataGridView1.TabIndex = 14;
            // 
            // seatIDDataGridViewTextBoxColumn
            // 
            this.seatIDDataGridViewTextBoxColumn.DataPropertyName = "SeatID";
            this.seatIDDataGridViewTextBoxColumn.HeaderText = "SeatID";
            this.seatIDDataGridViewTextBoxColumn.Name = "seatIDDataGridViewTextBoxColumn";
            // 
            // reservedDataGridViewCheckBoxColumn
            // 
            this.reservedDataGridViewCheckBoxColumn.DataPropertyName = "Reserved";
            this.reservedDataGridViewCheckBoxColumn.HeaderText = "Reserved";
            this.reservedDataGridViewCheckBoxColumn.Name = "reservedDataGridViewCheckBoxColumn";
            // 
            // seatTypeDataGridViewTextBoxColumn
            // 
            this.seatTypeDataGridViewTextBoxColumn.DataPropertyName = "SeatType";
            this.seatTypeDataGridViewTextBoxColumn.HeaderText = "SeatType";
            this.seatTypeDataGridViewTextBoxColumn.Name = "seatTypeDataGridViewTextBoxColumn";
            // 
            // raceIDDataGridViewTextBoxColumn
            // 
            this.raceIDDataGridViewTextBoxColumn.DataPropertyName = "RaceID";
            this.raceIDDataGridViewTextBoxColumn.HeaderText = "RaceID";
            this.raceIDDataGridViewTextBoxColumn.Name = "raceIDDataGridViewTextBoxColumn";
            // 
            // seatsBindingSource
            // 
            this.seatsBindingSource.DataMember = "Seats";
            this.seatsBindingSource.DataSource = this.база_данных2DataSet;
            // 
            // база_данных2DataSet
            // 
            this.база_данных2DataSet.DataSetName = "База_данных2DataSet";
            this.база_данных2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seatsTicketsBindingSource
            // 
            this.seatsTicketsBindingSource.DataMember = "SeatsTickets";
            this.seatsTicketsBindingSource.DataSource = this.seatsBindingSource;
            // 
            // numericUpDownClientID
            // 
            this.numericUpDownClientID.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientsBindingSource, "ClientID", true));
            this.numericUpDownClientID.Location = new System.Drawing.Point(55, 9);
            this.numericUpDownClientID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownClientID.Name = "numericUpDownClientID";
            this.numericUpDownClientID.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownClientID.TabIndex = 15;
            this.numericUpDownClientID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.база_данных2DataSet;
            // 
            // numericUpDownSeatID
            // 
            this.numericUpDownSeatID.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.seatsBindingSource, "SeatID", true));
            this.numericUpDownSeatID.Location = new System.Drawing.Point(55, 60);
            this.numericUpDownSeatID.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDownSeatID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSeatID.Name = "numericUpDownSeatID";
            this.numericUpDownSeatID.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSeatID.TabIndex = 16;
            this.numericUpDownSeatID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Location = new System.Drawing.Point(55, 86);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPrice.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Price";
            // 
            // seatsBindingSource1
            // 
            this.seatsBindingSource1.DataMember = "Seats";
            this.seatsBindingSource1.DataSource = this.база_данных2DataSet;
            // 
            // seatsTableAdapter
            // 
            this.seatsTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // numericUpDownRaceID
            // 
            this.numericUpDownRaceID.Location = new System.Drawing.Point(55, 35);
            this.numericUpDownRaceID.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDownRaceID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRaceID.Name = "numericUpDownRaceID";
            this.numericUpDownRaceID.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRaceID.TabIndex = 19;
            this.numericUpDownRaceID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRaceID.ValueChanged += new System.EventHandler(this.numericUpDownRaceID_ValueChanged);
            // 
            // RaceDataGroupBox
            // 
            this.RaceDataGroupBox.Controls.Add(this.labelTra);
            this.RaceDataGroupBox.Controls.Add(this.labelDat);
            this.RaceDataGroupBox.Controls.Add(this.labelDes);
            this.RaceDataGroupBox.Controls.Add(this.labelDep);
            this.RaceDataGroupBox.Location = new System.Drawing.Point(12, 112);
            this.RaceDataGroupBox.Name = "RaceDataGroupBox";
            this.RaceDataGroupBox.Size = new System.Drawing.Size(163, 77);
            this.RaceDataGroupBox.TabIndex = 20;
            this.RaceDataGroupBox.TabStop = false;
            this.RaceDataGroupBox.Text = "Race Data";
            // 
            // labelTra
            // 
            this.labelTra.AutoSize = true;
            this.labelTra.Location = new System.Drawing.Point(6, 55);
            this.labelTra.Name = "labelTra";
            this.labelTra.Size = new System.Drawing.Size(58, 13);
            this.labelTra.TabIndex = 3;
            this.labelTra.Text = "Transport: ";
            // 
            // labelDat
            // 
            this.labelDat.AutoSize = true;
            this.labelDat.Location = new System.Drawing.Point(5, 42);
            this.labelDat.Name = "labelDat";
            this.labelDat.Size = new System.Drawing.Size(36, 13);
            this.labelDat.TabIndex = 2;
            this.labelDat.Text = "Date: ";
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.Location = new System.Drawing.Point(5, 29);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(66, 13);
            this.labelDes.TabIndex = 1;
            this.labelDes.Text = "Destination: ";
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Location = new System.Drawing.Point(5, 16);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(60, 13);
            this.labelDep.TabIndex = 0;
            this.labelDep.Text = "Departure: ";
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 227);
            this.Controls.Add(this.RaceDataGroupBox);
            this.Controls.Add(this.numericUpDownRaceID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.numericUpDownSeatID);
            this.Controls.Add(this.numericUpDownClientID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AddTicket";
            this.Text = "Reserve Seat";
            this.Load += new System.EventHandler(this.AddTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsTicketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClientID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeatID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRaceID)).EndInit();
            this.RaceDataGroupBox.ResumeLayout(false);
            this.RaceDataGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private База_данных2DataSet база_данных2DataSet;
        private System.Windows.Forms.BindingSource seatsBindingSource;
        private База_данных2DataSetTableAdapters.SeatsTableAdapter seatsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private База_данных2DataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource seatsTicketsBindingSource;
        private База_данных2DataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.BindingSource seatsBindingSource1;
        private System.Windows.Forms.NumericUpDown numericUpDownClientID;
        private System.Windows.Forms.NumericUpDown numericUpDownSeatID;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn reservedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown numericUpDownRaceID;
        private System.Windows.Forms.GroupBox RaceDataGroupBox;
        private System.Windows.Forms.Label labelTra;
        private System.Windows.Forms.Label labelDat;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.Label labelDep;
    }
}