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
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);


        }

        private void metroTileLogIn_Click(object sender, EventArgs e)
        {
            this.Hide(); this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }

        private void metroTileRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();
        }

        private void metroTileBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking booking = new Booking();
            booking.Show();
        }

        private void metroTileDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Details details = new Details();
            details.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
