namespace HotelManagementSystem
{
    partial class Home
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
            this.metroTileBooking = new MetroFramework.Controls.MetroTile();
            this.metroTileDetails = new MetroFramework.Controls.MetroTile();
            this.metroTileRegister = new MetroFramework.Controls.MetroTile();
            this.metroTileLogIn = new MetroFramework.Controls.MetroTile();
            this.buttonExit = new System.Windows.Forms.Button();
            this.metroLabelWellCome = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroTileBooking
            // 
            this.metroTileBooking.ActiveControl = null;
            this.metroTileBooking.BackColor = System.Drawing.Color.Transparent;
            this.metroTileBooking.Location = new System.Drawing.Point(155, 274);
            this.metroTileBooking.Name = "metroTileBooking";
            this.metroTileBooking.Size = new System.Drawing.Size(240, 160);
            this.metroTileBooking.TabIndex = 5;
            this.metroTileBooking.TileImage = global::HotelManagementSystem.Properties.Resources.details3;
            this.metroTileBooking.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileBooking.UseCustomBackColor = true;
            this.metroTileBooking.UseSelectable = true;
            this.metroTileBooking.UseTileImage = true;
            this.metroTileBooking.Click += new System.EventHandler(this.metroTileBooking_Click);
            // 
            // metroTileDetails
            // 
            this.metroTileDetails.ActiveControl = null;
            this.metroTileDetails.Location = new System.Drawing.Point(401, 274);
            this.metroTileDetails.Name = "metroTileDetails";
            this.metroTileDetails.Size = new System.Drawing.Size(240, 160);
            this.metroTileDetails.TabIndex = 4;
            this.metroTileDetails.TileImage = global::HotelManagementSystem.Properties.Resources.details4;
            this.metroTileDetails.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileDetails.UseCustomBackColor = true;
            this.metroTileDetails.UseSelectable = true;
            this.metroTileDetails.UseTileImage = true;
            this.metroTileDetails.Click += new System.EventHandler(this.metroTileDetails_Click);
            // 
            // metroTileRegister
            // 
            this.metroTileRegister.ActiveControl = null;
            this.metroTileRegister.BackColor = System.Drawing.Color.Transparent;
            this.metroTileRegister.ForeColor = System.Drawing.Color.DarkViolet;
            this.metroTileRegister.Location = new System.Drawing.Point(401, 109);
            this.metroTileRegister.Name = "metroTileRegister";
            this.metroTileRegister.Size = new System.Drawing.Size(240, 160);
            this.metroTileRegister.TabIndex = 2;
            this.metroTileRegister.TileImage = global::HotelManagementSystem.Properties.Resources.register1;
            this.metroTileRegister.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileRegister.UseCustomBackColor = true;
            this.metroTileRegister.UseSelectable = true;
            this.metroTileRegister.UseTileImage = true;
            this.metroTileRegister.Click += new System.EventHandler(this.metroTileRegister_Click);
            // 
            // metroTileLogIn
            // 
            this.metroTileLogIn.ActiveControl = null;
            this.metroTileLogIn.BackColor = System.Drawing.Color.Transparent;
            this.metroTileLogIn.ForeColor = System.Drawing.Color.Chartreuse;
            this.metroTileLogIn.Location = new System.Drawing.Point(155, 109);
            this.metroTileLogIn.Name = "metroTileLogIn";
            this.metroTileLogIn.Size = new System.Drawing.Size(240, 160);
            this.metroTileLogIn.TabIndex = 2;
            this.metroTileLogIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileLogIn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTileLogIn.TileImage = global::HotelManagementSystem.Properties.Resources.login1;
            this.metroTileLogIn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileLogIn.UseCustomBackColor = true;
            this.metroTileLogIn.UseCustomForeColor = true;
            this.metroTileLogIn.UseSelectable = true;
            this.metroTileLogIn.UseTileImage = true;
            this.metroTileLogIn.Click += new System.EventHandler(this.metroTileLogIn_Click);
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
            this.buttonExit.Location = new System.Drawing.Point(710, 27);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(47, 47);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // metroLabelWellCome
            // 
            this.metroLabelWellCome.AutoSize = true;
            this.metroLabelWellCome.BackColor = System.Drawing.Color.White;
            this.metroLabelWellCome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelWellCome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelWellCome.ForeColor = System.Drawing.Color.LimeGreen;
            this.metroLabelWellCome.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.metroLabelWellCome.Location = new System.Drawing.Point(294, 57);
            this.metroLabelWellCome.Name = "metroLabelWellCome";
            this.metroLabelWellCome.Size = new System.Drawing.Size(210, 25);
            this.metroLabelWellCome.TabIndex = 2;
            this.metroLabelWellCome.Text = "Wellcome To Our Hotel";
            this.metroLabelWellCome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.metroLabelWellCome);
            this.Controls.Add(this.metroTileBooking);
            this.Controls.Add(this.metroTileDetails);
            this.Controls.Add(this.metroTileRegister);
            this.Controls.Add(this.metroTileLogIn);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Home";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile metroTileBooking;
        private MetroFramework.Controls.MetroTile metroTileDetails;
        private MetroFramework.Controls.MetroTile metroTileRegister;
        private MetroFramework.Controls.MetroTile metroTileLogIn;
        private MetroFramework.Controls.MetroLabel metroLabelWellCome;
        private System.Windows.Forms.Button buttonExit;
    }
}