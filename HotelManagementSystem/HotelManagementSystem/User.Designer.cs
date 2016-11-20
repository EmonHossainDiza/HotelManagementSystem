namespace HotelManagementSystem
{
    partial class User
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
            this.registerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_Management_SystemDataSet1 = new HotelManagementSystem.Hotel_Management_SystemDataSet1();
            this.hotel_Management_SystemDataSet = new HotelManagementSystem.Hotel_Management_SystemDataSet();
            this.hotelManagementSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerTableAdapter = new HotelManagementSystem.Hotel_Management_SystemDataSet1TableAdapters.registerTableAdapter();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new HotelManagementSystem.Hotel_Management_SystemDataSet1TableAdapters.loginTableAdapter();
            this.metroLabelPhoneNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabelName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDOB = new MetroFramework.Controls.MetroLabel();
            this.metroLabelGender = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAddress = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEmail = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPassport = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPassword = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDue = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAdvancePayment = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCost = new MetroFramework.Controls.MetroLabel();
            this.metroLabelRoomAvailable = new MetroFramework.Controls.MetroLabel();
            this.metroLabelTypeOfRoom = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1entrydate = new MetroFramework.Controls.MetroLabel();
            this.metroLabelentrydate = new MetroFramework.Controls.MetroLabel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTileLogout = new MetroFramework.Controls.MetroTile();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_Management_SystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // registerBindingSource
            // 
            this.registerBindingSource.DataMember = "register";
            this.registerBindingSource.DataSource = this.hotel_Management_SystemDataSet1;
            // 
            // hotel_Management_SystemDataSet1
            // 
            this.hotel_Management_SystemDataSet1.DataSetName = "Hotel_Management_SystemDataSet1";
            this.hotel_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotel_Management_SystemDataSet
            // 
            this.hotel_Management_SystemDataSet.DataSetName = "Hotel_Management_SystemDataSet";
            this.hotel_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelManagementSystemDataSetBindingSource
            // 
            this.hotelManagementSystemDataSetBindingSource.DataSource = this.hotel_Management_SystemDataSet;
            this.hotelManagementSystemDataSetBindingSource.Position = 0;
            // 
            // registerTableAdapter
            // 
            this.registerTableAdapter.ClearBeforeFill = true;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.hotel_Management_SystemDataSet1;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabelPhoneNo
            // 
            this.metroLabelPhoneNo.AutoSize = true;
            this.metroLabelPhoneNo.Location = new System.Drawing.Point(148, 338);
            this.metroLabelPhoneNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelPhoneNo.Name = "metroLabelPhoneNo";
            this.metroLabelPhoneNo.Size = new System.Drawing.Size(68, 19);
            this.metroLabelPhoneNo.TabIndex = 30;
            this.metroLabelPhoneNo.Text = "Phone No";
            // 
            // metroLabelName
            // 
            this.metroLabelName.AutoSize = true;
            this.metroLabelName.Location = new System.Drawing.Point(148, 118);
            this.metroLabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelName.Name = "metroLabelName";
            this.metroLabelName.Size = new System.Drawing.Size(45, 19);
            this.metroLabelName.TabIndex = 26;
            this.metroLabelName.Text = "Name";
            // 
            // metroLabelDOB
            // 
            this.metroLabelDOB.AutoSize = true;
            this.metroLabelDOB.Location = new System.Drawing.Point(148, 173);
            this.metroLabelDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelDOB.Name = "metroLabelDOB";
            this.metroLabelDOB.Size = new System.Drawing.Size(37, 19);
            this.metroLabelDOB.TabIndex = 27;
            this.metroLabelDOB.Text = "DOB";
            // 
            // metroLabelGender
            // 
            this.metroLabelGender.AutoSize = true;
            this.metroLabelGender.Location = new System.Drawing.Point(148, 228);
            this.metroLabelGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelGender.Name = "metroLabelGender";
            this.metroLabelGender.Size = new System.Drawing.Size(52, 19);
            this.metroLabelGender.TabIndex = 28;
            this.metroLabelGender.Text = "Gender";
            // 
            // metroLabelAddress
            // 
            this.metroLabelAddress.AutoSize = true;
            this.metroLabelAddress.Location = new System.Drawing.Point(148, 283);
            this.metroLabelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelAddress.Name = "metroLabelAddress";
            this.metroLabelAddress.Size = new System.Drawing.Size(56, 19);
            this.metroLabelAddress.TabIndex = 29;
            this.metroLabelAddress.Text = "Address";
            // 
            // metroLabelEmail
            // 
            this.metroLabelEmail.AutoSize = true;
            this.metroLabelEmail.Location = new System.Drawing.Point(148, 393);
            this.metroLabelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelEmail.Name = "metroLabelEmail";
            this.metroLabelEmail.Size = new System.Drawing.Size(41, 19);
            this.metroLabelEmail.TabIndex = 31;
            this.metroLabelEmail.Text = "Email";
            // 
            // metroLabelPassport
            // 
            this.metroLabelPassport.AutoSize = true;
            this.metroLabelPassport.Location = new System.Drawing.Point(148, 448);
            this.metroLabelPassport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelPassport.Name = "metroLabelPassport";
            this.metroLabelPassport.Size = new System.Drawing.Size(59, 19);
            this.metroLabelPassport.TabIndex = 32;
            this.metroLabelPassport.Text = "Passport";
            // 
            // metroLabelPassword
            // 
            this.metroLabelPassword.AutoSize = true;
            this.metroLabelPassword.Location = new System.Drawing.Point(647, 448);
            this.metroLabelPassword.Name = "metroLabelPassword";
            this.metroLabelPassword.Size = new System.Drawing.Size(63, 19);
            this.metroLabelPassword.TabIndex = 52;
            this.metroLabelPassword.Text = "Password";
            // 
            // metroLabelDue
            // 
            this.metroLabelDue.AutoSize = true;
            this.metroLabelDue.Location = new System.Drawing.Point(647, 393);
            this.metroLabelDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelDue.Name = "metroLabelDue";
            this.metroLabelDue.Size = new System.Drawing.Size(32, 19);
            this.metroLabelDue.TabIndex = 45;
            this.metroLabelDue.Text = "Due";
            // 
            // metroLabelAdvancePayment
            // 
            this.metroLabelAdvancePayment.AutoSize = true;
            this.metroLabelAdvancePayment.Location = new System.Drawing.Point(647, 338);
            this.metroLabelAdvancePayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelAdvancePayment.Name = "metroLabelAdvancePayment";
            this.metroLabelAdvancePayment.Size = new System.Drawing.Size(113, 19);
            this.metroLabelAdvancePayment.TabIndex = 44;
            this.metroLabelAdvancePayment.Text = "Advance Payment";
            // 
            // metroLabelCost
            // 
            this.metroLabelCost.AutoSize = true;
            this.metroLabelCost.Location = new System.Drawing.Point(647, 283);
            this.metroLabelCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelCost.Name = "metroLabelCost";
            this.metroLabelCost.Size = new System.Drawing.Size(35, 19);
            this.metroLabelCost.TabIndex = 43;
            this.metroLabelCost.Text = "Cost";
            // 
            // metroLabelRoomAvailable
            // 
            this.metroLabelRoomAvailable.AutoSize = true;
            this.metroLabelRoomAvailable.Location = new System.Drawing.Point(647, 228);
            this.metroLabelRoomAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelRoomAvailable.Name = "metroLabelRoomAvailable";
            this.metroLabelRoomAvailable.Size = new System.Drawing.Size(102, 19);
            this.metroLabelRoomAvailable.TabIndex = 41;
            this.metroLabelRoomAvailable.Text = "Room Available";
            // 
            // metroLabelTypeOfRoom
            // 
            this.metroLabelTypeOfRoom.AutoSize = true;
            this.metroLabelTypeOfRoom.Location = new System.Drawing.Point(647, 173);
            this.metroLabelTypeOfRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelTypeOfRoom.Name = "metroLabelTypeOfRoom";
            this.metroLabelTypeOfRoom.Size = new System.Drawing.Size(95, 19);
            this.metroLabelTypeOfRoom.TabIndex = 40;
            this.metroLabelTypeOfRoom.Text = "Type Of Room";
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.Silver;
            this.metroLabel1.Location = new System.Drawing.Point(289, 118);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(177, 28);
            this.metroLabel1.TabIndex = 54;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.Silver;
            this.metroLabel2.Location = new System.Drawing.Point(289, 173);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(177, 28);
            this.metroLabel2.TabIndex = 55;
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.BackColor = System.Drawing.Color.Silver;
            this.metroLabel3.Location = new System.Drawing.Point(289, 228);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(177, 28);
            this.metroLabel3.TabIndex = 56;
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.BackColor = System.Drawing.Color.Silver;
            this.metroLabel4.Location = new System.Drawing.Point(289, 283);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(177, 28);
            this.metroLabel4.TabIndex = 57;
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.BackColor = System.Drawing.Color.Silver;
            this.metroLabel5.Location = new System.Drawing.Point(289, 338);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(177, 28);
            this.metroLabel5.TabIndex = 58;
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.BackColor = System.Drawing.Color.Silver;
            this.metroLabel6.Location = new System.Drawing.Point(289, 393);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(177, 28);
            this.metroLabel6.TabIndex = 59;
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.BackColor = System.Drawing.Color.Silver;
            this.metroLabel7.Location = new System.Drawing.Point(289, 448);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(177, 28);
            this.metroLabel7.TabIndex = 60;
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.BackColor = System.Drawing.Color.Silver;
            this.metroLabel8.Location = new System.Drawing.Point(842, 173);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(177, 28);
            this.metroLabel8.TabIndex = 61;
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.BackColor = System.Drawing.Color.Silver;
            this.metroLabel9.Location = new System.Drawing.Point(842, 228);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(177, 28);
            this.metroLabel9.TabIndex = 62;
            this.metroLabel9.UseCustomBackColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.BackColor = System.Drawing.Color.Silver;
            this.metroLabel11.Location = new System.Drawing.Point(842, 283);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(177, 28);
            this.metroLabel11.TabIndex = 64;
            this.metroLabel11.UseCustomBackColor = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.BackColor = System.Drawing.Color.Silver;
            this.metroLabel12.Location = new System.Drawing.Point(842, 338);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(177, 28);
            this.metroLabel12.TabIndex = 65;
            this.metroLabel12.UseCustomBackColor = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.BackColor = System.Drawing.Color.Silver;
            this.metroLabel13.Location = new System.Drawing.Point(842, 393);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(177, 28);
            this.metroLabel13.TabIndex = 66;
            this.metroLabel13.UseCustomBackColor = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.BackColor = System.Drawing.Color.Silver;
            this.metroLabel14.Location = new System.Drawing.Point(840, 448);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(177, 28);
            this.metroLabel14.TabIndex = 67;
            this.metroLabel14.UseCustomBackColor = true;
            // 
            // metroLabel1entrydate
            // 
            this.metroLabel1entrydate.AutoSize = true;
            this.metroLabel1entrydate.Location = new System.Drawing.Point(647, 118);
            this.metroLabel1entrydate.Name = "metroLabel1entrydate";
            this.metroLabel1entrydate.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1entrydate.TabIndex = 68;
            this.metroLabel1entrydate.Text = "Entry Date";
            // 
            // metroLabelentrydate
            // 
            this.metroLabelentrydate.BackColor = System.Drawing.Color.Silver;
            this.metroLabelentrydate.Location = new System.Drawing.Point(842, 118);
            this.metroLabelentrydate.Name = "metroLabelentrydate";
            this.metroLabelentrydate.Size = new System.Drawing.Size(177, 28);
            this.metroLabelentrydate.TabIndex = 69;
            this.metroLabelentrydate.UseCustomBackColor = true;
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
            this.buttonExit.Location = new System.Drawing.Point(1122, 15);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(71, 71);
            this.buttonExit.TabIndex = 70;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroTile2.Location = new System.Drawing.Point(339, 540);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(190, 128);
            this.metroTile2.TabIndex = 2;
            this.metroTile2.Text = "Update";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = global::HotelManagementSystem.Properties.Resources.icon1;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTileLogout
            // 
            this.metroTileLogout.ActiveControl = null;
            this.metroTileLogout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroTileLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroTileLogout.Location = new System.Drawing.Point(646, 540);
            this.metroTileLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroTileLogout.Name = "metroTileLogout";
            this.metroTileLogout.Size = new System.Drawing.Size(190, 128);
            this.metroTileLogout.TabIndex = 1;
            this.metroTileLogout.Text = "Logout";
            this.metroTileLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileLogout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTileLogout.TileImage = global::HotelManagementSystem.Properties.Resources.power_button__1_;
            this.metroTileLogout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileLogout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTileLogout.UseCustomBackColor = true;
            this.metroTileLogout.UseCustomForeColor = true;
            this.metroTileLogout.UseSelectable = true;
            this.metroTileLogout.UseTileImage = true;
            this.metroTileLogout.Click += new System.EventHandler(this.metroTileLogout_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = global::HotelManagementSystem.Properties.Resources._003346_glossy_black_icon_media_a_media31_back;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(8, 13);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 75);
            this.buttonBack.TabIndex = 71;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.ControlBox = false;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.metroLabelentrydate);
            this.Controls.Add(this.metroLabel1entrydate);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabelPassword);
            this.Controls.Add(this.metroLabelDue);
            this.Controls.Add(this.metroLabelAdvancePayment);
            this.Controls.Add(this.metroLabelCost);
            this.Controls.Add(this.metroLabelRoomAvailable);
            this.Controls.Add(this.metroLabelTypeOfRoom);
            this.Controls.Add(this.metroLabelPhoneNo);
            this.Controls.Add(this.metroLabelName);
            this.Controls.Add(this.metroLabelDOB);
            this.Controls.Add(this.metroLabelGender);
            this.Controls.Add(this.metroLabelAddress);
            this.Controls.Add(this.metroLabelEmail);
            this.Controls.Add(this.metroLabelPassport);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTileLogout);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "User";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Resizable = false;
            this.Text = "Registered User";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_Management_SystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile metroTileLogout;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.BindingSource hotelManagementSystemDataSetBindingSource;
        private Hotel_Management_SystemDataSet hotel_Management_SystemDataSet;
        private Hotel_Management_SystemDataSet1 hotel_Management_SystemDataSet1;
        private System.Windows.Forms.BindingSource registerBindingSource;
        private Hotel_Management_SystemDataSet1TableAdapters.registerTableAdapter registerTableAdapter;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private Hotel_Management_SystemDataSet1TableAdapters.loginTableAdapter loginTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabelPhoneNo;
        private MetroFramework.Controls.MetroLabel metroLabelName;
        private MetroFramework.Controls.MetroLabel metroLabelDOB;
        private MetroFramework.Controls.MetroLabel metroLabelGender;
        private MetroFramework.Controls.MetroLabel metroLabelAddress;
        private MetroFramework.Controls.MetroLabel metroLabelEmail;
        private MetroFramework.Controls.MetroLabel metroLabelPassport;
        private MetroFramework.Controls.MetroLabel metroLabelPassword;
        private MetroFramework.Controls.MetroLabel metroLabelDue;
        private MetroFramework.Controls.MetroLabel metroLabelAdvancePayment;
        private MetroFramework.Controls.MetroLabel metroLabelCost;
        private MetroFramework.Controls.MetroLabel metroLabelRoomAvailable;
        private MetroFramework.Controls.MetroLabel metroLabelTypeOfRoom;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel1entrydate;
        private MetroFramework.Controls.MetroLabel metroLabelentrydate;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonBack;
    }
}