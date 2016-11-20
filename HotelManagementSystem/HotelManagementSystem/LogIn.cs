using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace HotelManagementSystem
{
    public partial class LogIn : MetroFramework.Forms.MetroForm
  
    {
        public LogIn()
        {
            InitializeComponent();
            metroTextBoxPassword.PasswordChar = '*';
        }

        public static string user = "";

        private void metroButtonLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                RegistrationDataContext dbcon = new RegistrationDataContext();
                register reg = new register();
                booking book = new booking();

                login log = new login();
                log = dbcon.logins.SingleOrDefault(x => x.Name == metroTextBoxUserName.Text && x.Password == metroTextBoxPassword.Text);
                reg = dbcon.registers.SingleOrDefault(x => x.Name == metroTextBoxUserName.Text && x.Password == metroTextBoxPassword.Text);
                book = dbcon.bookings.SingleOrDefault(x => x.Name == metroTextBoxUserName.Text && x.Password == metroTextBoxPassword.Text);
                //log.Name = metroTextBoxUserName.Text;
                //log.Password = metroTextBoxPassword.Text;
                //dbcon.logins.InsertOnSubmit(log);


                if (log.Name == "admin" && metroTextBoxUserName.Text == log.Name && metroTextBoxPassword.Text == log.Password)
                {
                    this.Hide();
                    new Admin().Show();

                }


                //    if (log.Name != "admin" && metroTextBoxUserName.Text == log.Name && metroTextBoxPassword.Text == log.Password && reg.Name == metroTextBoxUserName.Text)
                //    {
                //        user = metroTextBoxUserName.Text;
                //        this.Hide();
                //        new User().Show();


                //    }
                //    if (log.Name != "admin" && metroTextBoxUserName.Text == log.Name && metroTextBoxPassword.Text == log.Password && book.Name == metroTextBoxUserName.Text)
                //    {
                //        user = metroTextBoxUserName.Text;
                //        this.Hide();
                //        new user_booking().Show();


                //    }
                //}
                if (log.Name != "admin")
                {
                    if (reg != null)
                    {
                        if (metroTextBoxUserName.Text == reg.Name && metroTextBoxPassword.Text == reg.Password)
                        {
                            user = metroTextBoxUserName.Text;
                            this.Hide();
                            new User().Show();
                        }
                    }
                    if (book != null)
                    {
                        if (metroTextBoxUserName.Text == book.Name && metroTextBoxPassword.Text == book.Password)
                        {
                            user = metroTextBoxUserName.Text;
                            this.Hide();
                            new user_booking().Show();
                        }
                    }
                }

        }
             

           catch (Exception ex)
            {
                MetroMessageBox.Show(Owner, "Invalid Username or Password");
            }
        }


        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void button1_Exit(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void metroTextBoxUserName_Click(object sender, EventArgs e)
        {
            metroTextBoxUserName.Text = string.Empty;  
        }

        private void metroTextBoxPassword_Click(object sender, EventArgs e)
        {
            metroTextBoxPassword.Text = string.Empty;
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
