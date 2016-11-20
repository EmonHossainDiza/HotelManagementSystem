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
    public partial class Registered_User : MetroFramework.Forms.MetroForm
    {
        public Registered_User()
        {
            InitializeComponent();
        }

        private void Registered_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_Management_SystemDataSet2.register' table. You can move, or remove it, as needed.
            this.registerTableAdapter.Fill(this.hotel_Management_SystemDataSet2.register);
            // TODO: This line of code loads data into the 'hotel_Management_SystemDataSet2.register' table. You can move, or remove it, as needed.
            //this.registerTableAdapter1.Fill(this.hotel_Management_SystemDataSet2.register);
            // TODO: This line of code loads data into the 'hotel_Management_SystemDataSet1.register' table. You can move, or remove it, as needed.
            //this.registerTableAdapter.Fill(this.hotel_Management_SystemDataSet1.register);

        }

        private void metroTileBackAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
