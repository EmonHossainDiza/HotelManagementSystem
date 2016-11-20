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
    public partial class Details : MetroFramework.Forms.MetroForm
    {
        public Details()
        {
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
