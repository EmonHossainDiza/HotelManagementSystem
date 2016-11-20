namespace HotelManagementSystem
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Exit = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.metroButtonLogIn = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxUserName = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(655, 184);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "User Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(655, 302);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Password";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = global::HotelManagementSystem.Properties.Resources._018696_glossy_black_icon_symbols_shapes_power_button;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(1115, 20);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(71, 71);
            this.Exit.TabIndex = 15;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button1_Exit);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.DimGray;
            this.metroPanel1.BackgroundImage = global::HotelManagementSystem.Properties.Resources.group__1_;
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(332, 249);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(210, 220);
            this.metroPanel1.TabIndex = 13;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
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
            this.buttonBack.Location = new System.Drawing.Point(12, 18);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 75);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // metroButtonLogIn
            // 
            this.metroButtonLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroButtonLogIn.BackgroundImage = global::HotelManagementSystem.Properties.Resources.login2;
            this.metroButtonLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButtonLogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButtonLogIn.Location = new System.Drawing.Point(661, 437);
            this.metroButtonLogIn.Name = "metroButtonLogIn";
            this.metroButtonLogIn.Size = new System.Drawing.Size(190, 82);
            this.metroButtonLogIn.TabIndex = 9;
            this.metroButtonLogIn.Text = "LogIn";
            this.metroButtonLogIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroButtonLogIn.UseCustomForeColor = true;
            this.metroButtonLogIn.UseSelectable = true;
            this.metroButtonLogIn.Click += new System.EventHandler(this.metroButtonLogIn_Click);
            // 
            // metroTextBoxPassword
            // 
            // 
            // 
            // 
            this.metroTextBoxPassword.CustomButton.Image = null;
            this.metroTextBoxPassword.CustomButton.Location = new System.Drawing.Point(144, 2);
            this.metroTextBoxPassword.CustomButton.Name = "";
            this.metroTextBoxPassword.CustomButton.Size = new System.Drawing.Size(51, 51);
            this.metroTextBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxPassword.CustomButton.Visible = false;
            this.metroTextBoxPassword.DisplayIcon = true;
            this.metroTextBoxPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTextBoxPassword.Icon = ((System.Drawing.Image)(resources.GetObject("metroTextBoxPassword.Icon")));
            this.metroTextBoxPassword.IconRight = true;
            this.metroTextBoxPassword.Lines = new string[] {
        "Password"};
            this.metroTextBoxPassword.Location = new System.Drawing.Point(655, 336);
            this.metroTextBoxPassword.MaxLength = 32767;
            this.metroTextBoxPassword.Multiline = true;
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '\0';
            this.metroTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPassword.SelectedText = "";
            this.metroTextBoxPassword.SelectionLength = 0;
            this.metroTextBoxPassword.SelectionStart = 0;
            this.metroTextBoxPassword.Size = new System.Drawing.Size(198, 56);
            this.metroTextBoxPassword.TabIndex = 8;
            this.metroTextBoxPassword.Text = "Password";
            this.metroTextBoxPassword.UseCustomForeColor = true;
            this.metroTextBoxPassword.UseSelectable = true;
            this.metroTextBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxPassword.Click += new System.EventHandler(this.metroTextBoxPassword_Click);
            // 
            // metroTextBoxUserName
            // 
            // 
            // 
            // 
            this.metroTextBoxUserName.CustomButton.Image = null;
            this.metroTextBoxUserName.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.metroTextBoxUserName.CustomButton.Name = "";
            this.metroTextBoxUserName.CustomButton.Size = new System.Drawing.Size(47, 47);
            this.metroTextBoxUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxUserName.CustomButton.TabIndex = 1;
            this.metroTextBoxUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxUserName.CustomButton.UseSelectable = true;
            this.metroTextBoxUserName.CustomButton.Visible = false;
            this.metroTextBoxUserName.DisplayIcon = true;
            this.metroTextBoxUserName.Icon = ((System.Drawing.Image)(resources.GetObject("metroTextBoxUserName.Icon")));
            this.metroTextBoxUserName.IconRight = true;
            this.metroTextBoxUserName.Lines = new string[] {
        "User Name"};
            this.metroTextBoxUserName.Location = new System.Drawing.Point(655, 221);
            this.metroTextBoxUserName.MaxLength = 32767;
            this.metroTextBoxUserName.Multiline = true;
            this.metroTextBoxUserName.Name = "metroTextBoxUserName";
            this.metroTextBoxUserName.PasswordChar = '\0';
            this.metroTextBoxUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxUserName.SelectedText = "";
            this.metroTextBoxUserName.SelectionLength = 0;
            this.metroTextBoxUserName.SelectionStart = 0;
            this.metroTextBoxUserName.Size = new System.Drawing.Size(198, 49);
            this.metroTextBoxUserName.TabIndex = 7;
            this.metroTextBoxUserName.Text = "User Name";
            this.metroTextBoxUserName.UseSelectable = true;
            this.metroTextBoxUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxUserName.Click += new System.EventHandler(this.metroTextBoxUserName_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackMaxSize = 800;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.metroButtonLogIn);
            this.Controls.Add(this.metroTextBoxPassword);
            this.Controls.Add(this.metroTextBoxUserName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LogIn";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "LogIn";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox metroTextBoxUserName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
        private MetroFramework.Controls.MetroButton metroButtonLogIn;
        private System.Windows.Forms.Button buttonBack;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button Exit;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

