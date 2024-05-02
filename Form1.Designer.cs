namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTickets = new System.Windows.Forms.TabPage();
            this.Close1 = new System.Windows.Forms.Button();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfRaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данных2DataSet = new WindowsFormsApplication1.База_данных2DataSet();
            this.btnAddTickets = new System.Windows.Forms.Button();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.Close2 = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DB2DataSet = new WindowsFormsApplication1.База_данных2DataSet();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.ticketsTableAdapter = new WindowsFormsApplication1.База_данных2DataSetTableAdapters.TicketsTableAdapter();
            this.clientsTableAdapter = new WindowsFormsApplication1.База_данных2DataSetTableAdapters.ClientsTableAdapter();
            this.tabPageRaces = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.racesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racesTableAdapter = new WindowsFormsApplication1.База_данных2DataSetTableAdapters.RacesTableAdapter();
            this.raceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfRaceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных2DataSet)).BeginInit();
            this.tabPageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB2DataSet)).BeginInit();
            this.tabPageRaces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTickets);
            this.tabControl1.Controls.Add(this.tabPageClients);
            this.tabControl1.Controls.Add(this.tabPageRaces);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 506);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageTickets
            // 
            this.tabPageTickets.Controls.Add(this.Close1);
            this.tabPageTickets.Controls.Add(this.dataGridViewTickets);
            this.tabPageTickets.Controls.Add(this.btnAddTickets);
            this.tabPageTickets.Location = new System.Drawing.Point(4, 22);
            this.tabPageTickets.Name = "tabPageTickets";
            this.tabPageTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTickets.Size = new System.Drawing.Size(744, 480);
            this.tabPageTickets.TabIndex = 0;
            this.tabPageTickets.Text = "Tickets";
            this.tabPageTickets.UseVisualStyleBackColor = true;
            // 
            // Close1
            // 
            this.Close1.Location = new System.Drawing.Point(659, 454);
            this.Close1.Name = "Close1";
            this.Close1.Size = new System.Drawing.Size(75, 23);
            this.Close1.TabIndex = 5;
            this.Close1.Text = "Close";
            this.Close1.UseVisualStyleBackColor = true;
            this.Close1.Click += new System.EventHandler(this.Close1_Click);
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.AllowUserToAddRows = false;
            this.dataGridViewTickets.AutoGenerateColumns = false;
            this.dataGridViewTickets.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.departureDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.seatIDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.dateOfRaceDataGridViewTextBoxColumn});
            this.dataGridViewTickets.DataSource = this.ticketsBindingSource;
            this.dataGridViewTickets.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.Size = new System.Drawing.Size(743, 448);
            this.dataGridViewTickets.TabIndex = 4;
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // departureDataGridViewTextBoxColumn
            // 
            this.departureDataGridViewTextBoxColumn.DataPropertyName = "Departure";
            this.departureDataGridViewTextBoxColumn.HeaderText = "Departure";
            this.departureDataGridViewTextBoxColumn.Name = "departureDataGridViewTextBoxColumn";
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // seatIDDataGridViewTextBoxColumn
            // 
            this.seatIDDataGridViewTextBoxColumn.DataPropertyName = "SeatID";
            this.seatIDDataGridViewTextBoxColumn.HeaderText = "SeatID";
            this.seatIDDataGridViewTextBoxColumn.Name = "seatIDDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // dateOfRaceDataGridViewTextBoxColumn
            // 
            this.dateOfRaceDataGridViewTextBoxColumn.DataPropertyName = "DateOfRace";
            this.dateOfRaceDataGridViewTextBoxColumn.HeaderText = "DateOfRace";
            this.dateOfRaceDataGridViewTextBoxColumn.Name = "dateOfRaceDataGridViewTextBoxColumn";
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.база_данных2DataSet;
            // 
            // база_данных2DataSet
            // 
            this.база_данных2DataSet.DataSetName = "База_данных2DataSet";
            this.база_данных2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddTickets
            // 
            this.btnAddTickets.Location = new System.Drawing.Point(9, 454);
            this.btnAddTickets.Name = "btnAddTickets";
            this.btnAddTickets.Size = new System.Drawing.Size(75, 23);
            this.btnAddTickets.TabIndex = 2;
            this.btnAddTickets.Text = "Add";
            this.btnAddTickets.UseVisualStyleBackColor = true;
            this.btnAddTickets.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.Close2);
            this.tabPageClients.Controls.Add(this.dataGridViewClients);
            this.tabPageClients.Controls.Add(this.btnAddClient);
            this.tabPageClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(744, 480);
            this.tabPageClients.TabIndex = 1;
            this.tabPageClients.Text = "Clients";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // Close2
            // 
            this.Close2.Location = new System.Drawing.Point(659, 454);
            this.Close2.Name = "Close2";
            this.Close2.Size = new System.Drawing.Size(75, 23);
            this.Close2.TabIndex = 4;
            this.Close2.Text = "Close";
            this.Close2.UseVisualStyleBackColor = true;
            this.Close2.Click += new System.EventHandler(this.Close2_Click);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AutoGenerateColumns = false;
            this.dataGridViewClients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn1,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientSurnameDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dataGridViewClients.DataSource = this.clientsBindingSource;
            this.dataGridViewClients.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(744, 448);
            this.dataGridViewClients.TabIndex = 3;
            // 
            // clientIDDataGridViewTextBoxColumn1
            // 
            this.clientIDDataGridViewTextBoxColumn1.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn1.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn1.Name = "clientIDDataGridViewTextBoxColumn1";
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // clientSurnameDataGridViewTextBoxColumn
            // 
            this.clientSurnameDataGridViewTextBoxColumn.DataPropertyName = "ClientSurname";
            this.clientSurnameDataGridViewTextBoxColumn.HeaderText = "ClientSurname";
            this.clientSurnameDataGridViewTextBoxColumn.Name = "clientSurnameDataGridViewTextBoxColumn";
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.DB2DataSet;
            // 
            // DB2DataSet
            // 
            this.DB2DataSet.DataSetName = "DB2DataSet";
            this.DB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(9, 454);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 23);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tabPageRaces
            // 
            this.tabPageRaces.Controls.Add(this.dataGridView1);
            this.tabPageRaces.Location = new System.Drawing.Point(4, 22);
            this.tabPageRaces.Name = "tabPageRaces";
            this.tabPageRaces.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRaces.Size = new System.Drawing.Size(744, 480);
            this.tabPageRaces.TabIndex = 2;
            this.tabPageRaces.Text = "Races";
            this.tabPageRaces.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.raceIDDataGridViewTextBoxColumn,
            this.raceTypeDataGridViewTextBoxColumn,
            this.departureDataGridViewTextBoxColumn1,
            this.destinationDataGridViewTextBoxColumn1,
            this.dateOfRaceDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.racesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 480);
            this.dataGridView1.TabIndex = 0;
            // 
            // racesBindingSource
            // 
            this.racesBindingSource.DataMember = "Races";
            this.racesBindingSource.DataSource = this.база_данных2DataSet;
            // 
            // racesTableAdapter
            // 
            this.racesTableAdapter.ClearBeforeFill = true;
            // 
            // raceIDDataGridViewTextBoxColumn
            // 
            this.raceIDDataGridViewTextBoxColumn.DataPropertyName = "RaceID";
            this.raceIDDataGridViewTextBoxColumn.HeaderText = "RaceID";
            this.raceIDDataGridViewTextBoxColumn.Name = "raceIDDataGridViewTextBoxColumn";
            // 
            // raceTypeDataGridViewTextBoxColumn
            // 
            this.raceTypeDataGridViewTextBoxColumn.DataPropertyName = "RaceType";
            this.raceTypeDataGridViewTextBoxColumn.HeaderText = "RaceType";
            this.raceTypeDataGridViewTextBoxColumn.Name = "raceTypeDataGridViewTextBoxColumn";
            // 
            // departureDataGridViewTextBoxColumn1
            // 
            this.departureDataGridViewTextBoxColumn1.DataPropertyName = "Departure";
            this.departureDataGridViewTextBoxColumn1.HeaderText = "Departure";
            this.departureDataGridViewTextBoxColumn1.Name = "departureDataGridViewTextBoxColumn1";
            // 
            // destinationDataGridViewTextBoxColumn1
            // 
            this.destinationDataGridViewTextBoxColumn1.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn1.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn1.Name = "destinationDataGridViewTextBoxColumn1";
            // 
            // dateOfRaceDataGridViewTextBoxColumn1
            // 
            this.dateOfRaceDataGridViewTextBoxColumn1.DataPropertyName = "DateOfRace";
            this.dateOfRaceDataGridViewTextBoxColumn1.HeaderText = "DateOfRace";
            this.dateOfRaceDataGridViewTextBoxColumn1.Name = "dateOfRaceDataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 505);
            this.Controls.Add(this.tabControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных2DataSet)).EndInit();
            this.tabPageClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB2DataSet)).EndInit();
            this.tabPageRaces.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.TabPage tabPageTickets;
        private System.Windows.Forms.Button btnAddTickets;
        private System.Windows.Forms.Button btnAddClient;
        private База_данных2DataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private База_данных2DataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Button Close1;
        private System.Windows.Forms.Button Close2;
        public База_данных2DataSet DB2DataSet;
        public System.Windows.Forms.DataGridView dataGridViewClients;
        public System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        public База_данных2DataSet база_данных2DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfRaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPageRaces;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource racesBindingSource;
        private База_данных2DataSetTableAdapters.RacesTableAdapter racesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfRaceDataGridViewTextBoxColumn1;
    }
}

