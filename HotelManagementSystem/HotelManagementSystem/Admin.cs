using MetroFramework;
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
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        public Admin()
        {
            InitializeComponent();
            //metroLabel1.Text = LogIn.user;
            //RegistrationDataContext dbcon = new RegistrationDataContext();
            //register r = dbcon.registers.SingleOrDefault(x => x.Name == LogIn.user);
            //if (r != null)
            //{
            //    metroLabel1.Text = r.Name;
            //    metroLabel2.Text = r.DOB;
            //    metroLabel3.Text = r.Gender;
            //    metroLabel4.Text = r.Address;
            //    metroLabel5.Text = r.PhoneNo;
            //    metroLabel6.Text = r.Email;
            //    metroLabel7.Text = r.Passport;
            //    metroLabelentrydate.Text = r.EntryDate;
            //    metroLabel8.Text = r.TypeOfRoom;
            //    metroLabel9.Text = r.RoomAvailable;
            //    metroLabel10.Text = r.NumberOfRoom;
            //    metroLabel11.Text = r.Cost;
            //    metroLabel12.Text = r.AdvancePayment;
            //    metroLabel13.Text = r.Due;
            //    metroLabel14.Text = r.Password;

            //}
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void metroTileLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void metroTileRegisteredUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registered_User regu = new Registered_User();
            regu.Show();
        }

        private void metroTileBookedUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booked_User booku = new Booked_User();
            booku.Show();
        }

        private void metroButtonSearch_Click(object sender, EventArgs e)
        {
            RegistrationDataContext dbcon = new RegistrationDataContext();
            register r = dbcon.registers.SingleOrDefault(x => x.RoomAvailable ==metroComboBox1.Text );
            booking b = dbcon.bookings.SingleOrDefault(x => x.RoomAvailable == metroComboBox1.Text);

            if (r != null && metroRadioButton1RegisteredUser.Checked==true )
            {
                metroLabel1.Text = r.Name;
                metroLabel2.Text = r.DOB;
                metroLabel3.Text = r.Gender;
                metroLabel4.Text = r.Address;
                metroLabel5.Text = r.PhoneNo;
                metroLabel6.Text = r.Email;
                metroLabel7.Text = r.Passport;
                metroLabelentrydate.Text = r.EntryDate;
                metroLabel8.Text = r.TypeOfRoom;
                metroLabel9.Text = r.RoomAvailable;
                metroLabel10.Text = r.DayReserve;
                metroLabel11.Text = r.Cost;
                metroLabel12.Text = r.AdvancePayment;
                metroLabel13.Text = r.Due;
                metroLabel14.Text = r.Password;

            }
            else {
                metroLabel1.Text = null;
                metroLabel2.Text = null;
                metroLabel3.Text = null;
                metroLabel4.Text = null;
                metroLabel5.Text = null;
                metroLabel6.Text = null;
                metroLabel7.Text = null;
                metroLabelentrydate.Text = null;
                metroLabel8.Text = null;
                metroLabel9.Text = null;
                metroLabel10.Text = null;
                metroLabel11.Text = null;
                metroLabel12.Text = null;
                metroLabel13.Text = null;
                metroLabel14.Text = null;
            }
            if (b != null && metroRadioButton2BookedUser.Checked == true)
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
                metroLabel10.Text = b.DayReserve;
                metroLabel11.Text = b.Cost;
                metroLabel12.Text = b.AdvancePayment;
                metroLabel13.Text = b.Due;
                metroLabel14.Text = b.Password;

            }
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
            RegistrationDataContext dbcon = new RegistrationDataContext();
            register r = dbcon.registers.SingleOrDefault(x => x.RoomAvailable == metroComboBox1.Text);
            booking b = dbcon.bookings.SingleOrDefault(x => x.RoomAvailable == metroComboBox1.Text);
            login l = dbcon.logins.SingleOrDefault(x => x.Name == metroLabel1.Text);
            //login log = new login();
            //register r = new register();
            //booking book = new booking();
            if (r != null && metroRadioButton1RegisteredUser.Checked == true)

            {
                
                    dbcon.registers.DeleteOnSubmit(r);
                    dbcon.logins.DeleteOnSubmit(l);
                    dbcon.SubmitChanges();
                    MetroMessageBox.Show(Owner, "Registered client deleted");
            }
              
                
             if (b != null && metroRadioButton2BookedUser.Checked == true)
                    {
                        dbcon.bookings.DeleteOnSubmit(b);
                        dbcon.logins.DeleteOnSubmit(l);
                        dbcon.SubmitChanges();
                        MetroMessageBox.Show(Owner, "Booked client deleted");
                    }
                
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(metroLabelName.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 100, 100);
            e.Graphics.DrawString(metroLabel1.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 450, 100);
            e.Graphics.DrawString(metroLabelPhoneNo.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 100, 150);
            e.Graphics.DrawString(metroLabel5.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 450, 160);
            e.Graphics.DrawString(metroLabelTypeOfRoom.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 100, 200);
            e.Graphics.DrawString(metroLabel8.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 450, 210);
            e.Graphics.DrawString(metroLabelRoomAvailable.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 100, 250);
            e.Graphics.DrawString(metroLabel9.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 450, 260);
            e.Graphics.DrawString(metroLabelCost.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 100, 300);
            e.Graphics.DrawString(metroLabel11.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 450, 310);
            e.Graphics.DrawString(metroLabelAdvancePayment.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 100, 350);
            e.Graphics.DrawString(metroLabel12.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 450, 360);
            e.Graphics.DrawString(metroLabelDue.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 100, 400);
            e.Graphics.DrawString(metroLabel13.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 450, 410);

        }
    }
}
