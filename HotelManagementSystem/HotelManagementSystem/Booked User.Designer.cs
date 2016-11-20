namespace HotelManagementSystem
{
    partial class Booked_User
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.buttonExit = new System.Windows.Forms.Button();
            this.metroTileBackAdmin = new MetroFramework.Controls.MetroTile();
            this.hotel_Management_SystemDataSet2 = new HotelManagementSystem.Hotel_Management_SystemDataSet2();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new HotelManagementSystem.Hotel_Management_SystemDataSet2TableAdapters.bookingTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayReserveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advancePaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_Management_SystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn,
            this.arrivalDateDataGridViewTextBoxColumn,
            this.dayReserveDataGridViewTextBoxColumn,
            this.typeOfRoomDataGridViewTextBoxColumn,
            this.roomAvailableDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.advancePaymentDataGridViewTextBoxColumn,
            this.dueDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.confirmPasswordDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.bookingBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(35, 96);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 28;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(536, 317);
            this.metroGrid1.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImage = global::HotelManagementSystem.Properties.Resources._018696_glossy_black_icon_symbols_shapes_power_button;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(723, 29);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(47, 47);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // metroTileBackAdmin
            // 
            this.metroTileBackAdmin.ActiveControl = null;
            this.metroTileBackAdmin.Location = new System.Drawing.Point(635, 327);
            this.metroTileBackAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTileBackAdmin.Name = "metroTileBackAdmin";
            this.metroTileBackAdmin.Size = new System.Drawing.Size(127, 85);
            this.metroTileBackAdmin.TabIndex = 1;
            this.metroTileBackAdmin.Text = "Back Admin";
            this.metroTileBackAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileBackAdmin.TileImage = global::HotelManagementSystem.Properties.Resources.admin_with_cogwheels__1_;
            this.metroTileBackAdmin.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileBackAdmin.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTileBackAdmin.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTileBackAdmin.UseSelectable = true;
            this.metroTileBackAdmin.UseTileImage = true;
            this.metroTileBackAdmin.Click += new System.EventHandler(this.metroTileBackAdmin_Click);
            // 
            // hotel_Management_SystemDataSet2
            // 
            this.hotel_Management_SystemDataSet2.DataSetName = "Hotel_Management_SystemDataSet2";
            this.hotel_Management_SystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "booking";
            this.bookingBindingSource.DataSource = this.hotel_Management_SystemDataSet2;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneNoDataGridViewTextBoxColumn
            // 
            this.phoneNoDataGridViewTextBoxColumn.DataPropertyName = "PhoneNo";
            this.phoneNoDataGridViewTextBoxColumn.HeaderText = "PhoneNo";
            this.phoneNoDataGridViewTextBoxColumn.Name = "phoneNoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "Passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Passport";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            // 
            // arrivalDateDataGridViewTextBoxColumn
            // 
            this.arrivalDateDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.HeaderText = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.Name = "arrivalDateDataGridViewTextBoxColumn";
            // 
            // dayReserveDataGridViewTextBoxColumn
            // 
            this.dayReserveDataGridViewTextBoxColumn.DataPropertyName = "DayReserve";
            this.dayReserveDataGridViewTextBoxColumn.HeaderText = "DayReserve";
            this.dayReserveDataGridViewTextBoxColumn.Name = "dayReserveDataGridViewTextBoxColumn";
            // 
            // typeOfRoomDataGridViewTextBoxColumn
            // 
            this.typeOfRoomDataGridViewTextBoxColumn.DataPropertyName = "TypeOfRoom";
            this.typeOfRoomDataGridViewTextBoxColumn.HeaderText = "TypeOfRoom";
            this.typeOfRoomDataGridViewTextBoxColumn.Name = "typeOfRoomDataGridViewTextBoxColumn";
            // 
            // roomAvailableDataGridViewTextBoxColumn
            // 
            this.roomAvailableDataGridViewTextBoxColumn.DataPropertyName = "RoomAvailable";
            this.roomAvailableDataGridViewTextBoxColumn.HeaderText = "RoomAvailable";
            this.roomAvailableDataGridViewTextBoxColumn.Name = "roomAvailableDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // advancePaymentDataGridViewTextBoxColumn
            // 
            this.advancePaymentDataGridViewTextBoxColumn.DataPropertyName = "AdvancePayment";
            this.advancePaymentDataGridViewTextBoxColumn.HeaderText = "AdvancePayment";
            this.advancePaymentDataGridViewTextBoxColumn.Name = "advancePaymentDataGridViewTextBoxColumn";
            // 
            // dueDataGridViewTextBoxColumn
            // 
            this.dueDataGridViewTextBoxColumn.DataPropertyName = "Due";
            this.dueDataGridViewTextBoxColumn.HeaderText = "Due";
            this.dueDataGridViewTextBoxColumn.Name = "dueDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // confirmPasswordDataGridViewTextBoxColumn
            // 
            this.confirmPasswordDataGridViewTextBoxColumn.DataPropertyName = "ConfirmPassword";
            this.confirmPasswordDataGridViewTextBoxColumn.HeaderText = "ConfirmPassword";
            this.confirmPasswordDataGridViewTextBoxColumn.Name = "confirmPasswordDataGridViewTextBoxColumn";
            // 
            // Booked_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.metroTileBackAdmin);
            this.Controls.Add(this.metroGrid1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Booked_User";
            this.Padding = new System.Windows.Forms.Padding(13, 40, 13, 13);
            this.Resizable = false;
            this.Text = "Booked User";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Booked_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_Management_SystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTile metroTileBackAdmin;
        private System.Windows.Forms.Button buttonExit;
        private Hotel_Management_SystemDataSet2 hotel_Management_SystemDataSet2;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private Hotel_Management_SystemDataSet2TableAdapters.bookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayReserveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn advancePaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmPasswordDataGridViewTextBoxColumn;
    }
}