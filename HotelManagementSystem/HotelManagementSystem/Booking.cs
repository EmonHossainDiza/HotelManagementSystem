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
using System.Data.SqlClient;
using MetroFramework;
using MetroFramework.Forms;

namespace HotelManagementSystem
{
    public partial class Booking : MetroFramework.Forms.MetroForm
    {
        public Booking()
        {
            InitializeComponent();
            RoomAvailablity();
            metroTextBoxPassword.PasswordChar = '*';
            metroTextBoxConfrimPassword.PasswordChar = '*';
        }
        public static string user = "";
        public void RoomAvailablity()
        {
            RegistrationDataContext dbcon = new RegistrationDataContext();
            //register room = dbcon.registers.SingleOrDefault(x => x.RoomAvailable == "A -1");
            booking room = dbcon.bookings.SingleOrDefault(x => x.RoomAvailable == "A -1");
            if (room != null)
                metroComboBox1.Items.Remove("A -1");
            room = dbcon.bookings.SingleOrDefault(x => x.RoomAvailable == "A -2");
            if (room != null)
                metroComboBox1.Items.Remove("A -2");
            room = dbcon.bookings.SingleOrDefault(x => x.RoomAvailable == "B -1");
            if (room != null)

                metroComboBox1.Items.Remove("B -1");
            room = dbcon.bookings.SingleOrDefault(x => x.RoomAvailable == "B -2");
            if (room != null)
                metroComboBox1.Items.Remove("B -2");
            room = dbcon.bookings.SingleOrDefault(x => x.RoomAvailable == "C -1");
            if (room != null)
                metroComboBox1.Items.Remove("C -1");
            room = dbcon.bookings.SingleOrDefault(x => x.RoomAvailable == "C -2");
            if (room != null)
                metroComboBox1.Items.Remove("C -2");
            room = dbcon.bookings.SingleOrDefault(x => x.RoomAvailable == "D -1");
            if (room != null)
                metroComboBox1.Items.Remove("D -1");
            room = dbcon.bookings.SingleOrDefault(x => x.RoomAvailable == "D -2");
            if (room != null)
                metroComboBox1.Items.Remove("D -2");
            room = dbcon.bookings.SingleOrDefault(x => x.RoomAvailable == "E -1");
            if (room != null)
                metroComboBox1.Items.Remove("E -1");
            room = dbcon.bookings.SingleOrDefault(x => x.RoomAvailable == "E -2");
            if (room != null)
                metroComboBox1.Items.Remove("E -2");
            room = dbcon.bookings.SingleOrDefault(x => x.RoomAvailable == "F -1");
            if (room != null)
                metroComboBox1.Items.Remove("F -1");
            room = dbcon.bookings.SingleOrDefault(x => x.RoomAvailable == "F -2");
            if (room != null)
                metroComboBox1.Items.Remove("F -2");

        }


        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void metroTile3_MouseHover(object sender, EventArgs e)
        {
            metroTile3.Image = Properties.Resources.Icon_Edit_Reservations;
        }

        private void metroTile3_MouseLeave(object sender, EventArgs e)
        {
            metroTile3.Image = Properties.Resources.register_icon_blue1;
        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

       private void metroTile3_Click(object sender, EventArgs e)
       {
           
       }

        private void metroTile3_Click_1(object sender, EventArgs e)
        {
            if (metroTextBoxConfrimPassword.Text == metroTextBoxPassword.Text)
            {
                RegistrationDataContext dbcon = new RegistrationDataContext();
                booking book = new booking();

                login log = new login();

                log.Name = metroTextBoxName.Text;
                log.Password = metroTextBoxPassword.Text;
                dbcon.logins.InsertOnSubmit(log);

                book.Name = metroTextBoxName.Text;
                book.DOB = metroDateTime1.Text;
                book.Gender = metroComboBoxGender.Text;
                book.Address = metroTextBoxAddress.Text;
                book.PhoneNo = metroTextBoxPhoneNo.Text;
                book.Email = metroTextBoxEmail.Text;
                book.Passport = metroTextBoxPassport.Text;
                book.TypeOfRoom = metroComboBoxTypeOfRoom.Text;
                book.RoomAvailable = metroComboBox1.Text;
               // book.NumberOfRoom = metroTextBoxNumberOfRoom.Text;
                book.Cost = metroTextBoxCost.Text;
                book.AdvancePayment = metroTextBoxAdvancePayment.Text;
                book.Due = metroTextBoxDue.Text;
                book.ArrivalDate = metroDateTime2.Text;
                book.DayReserve = metroTextBoxDayReserve.Text;
                book.Password = metroTextBoxPassword.Text;
                book.ConfirmPassword = metroTextBoxConfrimPassword.Text;

                dbcon.bookings.InsertOnSubmit(book);
                dbcon.SubmitChanges();
                MetroMessageBox.Show(Owner, "Booking complete");

                metroTextBoxName.Clear();
                //  metroDateTime1.SelectedItem = null;
                metroComboBoxGender.SelectedItem = null;
                metroTextBoxAddress.Clear();
                metroTextBoxPhoneNo.Clear();
                metroTextBoxEmail.Clear();
                metroTextBoxPassport.Clear();
                metroComboBoxTypeOfRoom.SelectedItem = null;
                metroComboBox1.SelectedItem = null;
                metroComboBox1.SelectedItem = null;
                metroTextBoxCost.Clear();
                metroTextBoxAdvancePayment.Clear();
                metroTextBoxDue.Clear();
                metroTextBoxPassword.Clear();
                metroTextBoxConfrimPassword.Clear();
                metroTextBoxDayReserve.Clear();
            }
            else {
                MetroMessageBox.Show(Owner, "Please enter same Password");
                metroTextBoxConfrimPassword.Clear();
            }
        }

        public TextBox booking
        {
            get
            {
                return booking;
            }
        }
        private void metroTileHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void metroComboBoxTypeOfRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (metroTextBoxDayReserve.Text != null)
                {
                    if (metroComboBoxTypeOfRoom.SelectedIndex == 0)
                    {
                        metroTextBoxCost.Clear();
                        metroTextBoxAdvancePayment.Clear();
                        metroTextBoxDue.Clear();
                        metroTextBoxCost.Text = ((Convert.ToInt32(metroTextBoxDayReserve.Text)) * 2000).ToString();
                        metroTextBoxCost.Enabled = false;
                    }
                    if (metroTextBoxDayReserve.Text != null)
                    {
                        if (metroComboBoxTypeOfRoom.SelectedIndex == 1)
                        {
                            metroTextBoxCost.Clear();
                            metroTextBoxAdvancePayment.Clear();
                            metroTextBoxDue.Clear();
                            metroTextBoxCost.Text = ((Convert.ToInt32(metroTextBoxDayReserve.Text)) * 1500).ToString();
                            metroTextBoxCost.Enabled = false;
                        }
                        //else { MessageBox.Show("dfs"); }
                    }

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(Owner, "please insert number of day reserve first ");
            }

        }

        private void metroTextBoxDue_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(metroTextBoxCost.Text) || string.IsNullOrEmpty(metroTextBoxAdvancePayment.Text))

            {

                metroTextBoxDue.Text = Convert.ToString((Convert.ToInt32(metroTextBoxCost.Text)) - Convert.ToInt32(metroTextBoxAdvancePayment.Text)).ToString();

            }
            metroTextBoxDue.Enabled = false;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Details().Show();
        }

        private void metroTextBoxEmail_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(metroTextBoxPhoneNo.Text, "[^0-9]"))
            {
                MetroMessageBox.Show(Owner, "Please enter only numbers.");
                metroTextBoxPhoneNo.Text.Remove(metroTextBoxPhoneNo.Text.Length - 1);
            }
        }

        private void metroTextBoxCost_Click(object sender, EventArgs e)
        {

        }
    }
}
