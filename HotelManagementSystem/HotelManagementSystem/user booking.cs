using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class user_booking : MetroFramework.Forms.MetroForm
    {

        public static string user = "";

        public user_booking()
        {
            InitializeComponent();
       

            metroLabel1.Text = LogIn.user;
            RegistrationDataContext dbcon = new RegistrationDataContext();
            
            booking b = dbcon.bookings.SingleOrDefault(x => x.Name == LogIn.user);
            if (b != null)
            {
                metroLabel1.Text = b.Name;
                metroLabel2.Text = b.DOB;
                metroLabel3.Text = b.Gender;
                metroLabel4.Text = b.Address;
                metroLabel5.Text = b.PhoneNo;
                metroLabel6.Text = b.Email;
                metroLabel7.Text = b.Passport;
                metroLabelentrydate.Text = b.ArrivalDate;
                metroLabel8.Text = b.TypeOfRoom;
                metroLabel9.Text = b.RoomAvailable;
               // metroLabel10.Text = b.NumberOfRoom;
                metroLabel11.Text = b.Cost;
                metroLabel12.Text = b.AdvancePayment;
                metroLabel13.Text = b.Due;
                metroLabel14.Text = b.Password;

            }
        }


        private void user_booking_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void metroTileLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Booking_Update up = new User_Booking_Update();
            up.Show();
        }

        private void metroLabelName_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogIn().Show();
        }
    }
}
