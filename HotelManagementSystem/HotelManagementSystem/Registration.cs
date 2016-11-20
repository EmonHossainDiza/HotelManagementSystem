using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace HotelManagementSystem
{
    public partial class Registration : MetroFramework.Forms.MetroForm
    {
        public Registration()
        {
            InitializeComponent();
            RoomAvailablity();
            metroTextBoxPassword.PasswordChar = '*';
            metroTextBoxConfrimPassword.PasswordChar = '*';
        }

        public void RoomAvailablity()
        {
            RegistrationDataContext dbcon = new RegistrationDataContext();
            register room = dbcon.registers.SingleOrDefault(x => x.RoomAvailable == "A -1");
            if (room != null)
                metroComboBox1.Items.Remove("A -1");
            room = dbcon.registers.SingleOrDefault(x => x.RoomAvailable == "A -2");
            if (room != null)
                metroComboBox1.Items.Remove("A -2");
            room = dbcon.registers.SingleOrDefault(x => x.RoomAvailable == "B -1");
            if (room != null)

                metroComboBox1.Items.Remove("B -1");
            room = dbcon.registers.SingleOrDefault(x => x.RoomAvailable == "B -2");
            if (room != null)
                metroComboBox1.Items.Remove("B -2");
            room = dbcon.registers.SingleOrDefault(x => x.RoomAvailable == "C -1");
            if (room != null)
                metroComboBox1.Items.Remove("C -1");
            room = dbcon.registers.SingleOrDefault(x => x.RoomAvailable == "C -2");
            if (room != null)
                metroComboBox1.Items.Remove("C -2");
            room = dbcon.registers.SingleOrDefault(x => x.RoomAvailable == "D -1");
            if (room != null)
                metroComboBox1.Items.Remove("D -1");
            room = dbcon.registers.SingleOrDefault(x => x.RoomAvailable == "D -2");
            if (room != null)
                metroComboBox1.Items.Remove("D -2");
            room = dbcon.registers.SingleOrDefault(x => x.RoomAvailable == "E -1");
            if (room != null)
                metroComboBox1.Items.Remove("E -1");
            room = dbcon.registers.SingleOrDefault(x => x.RoomAvailable == "E -2");
            if (room != null)
                metroComboBox1.Items.Remove("E -2");
            room = dbcon.registers.SingleOrDefault(x => x.RoomAvailable == "F -1");
            if (room != null)
                metroComboBox1.Items.Remove("F -1");
            room = dbcon.registers.SingleOrDefault(x => x.RoomAvailable == "F -2");
            if (room != null)
                metroComboBox1.Items.Remove("F -2");

        }



        private void metroTile3_Click(object sender, EventArgs e)
        {
            if (metroTextBoxConfrimPassword.Text == metroTextBoxPassword.Text) {  
           
                RegistrationDataContext dbcon = new RegistrationDataContext();
                register reg = new register();
                // reg = dbcon.registers.SingleOrDefault(x => x.Name == metroTextBoxName.Text && x.DOB == metroDateTime1.Text && x.Gender == metroComboBoxGender.Text && x.Address == metroTextBoxAddress.Text && x.Address == metroTextBoxAddress.Text && x.PhoneNo == metroTextBoxPhoneNo.Text && x.Email == metroTextBoxEmail.Text && x.Passport == metroTextBoxPassport.Text && x.TypeOfRoom == metroComboBoxTypeOfRoom.Text && x.RoomAvailable == metroTextBoxRoomAvailable.Text  && x.Cost == metroTextBoxCost.Text && x.AdvancePayment == metroTextBoxAdvancePayment.Text && x.Due == metroTextBoxDue.Text);

                login log = new login();

                log.Name = metroTextBoxName.Text;
                log.Password = metroTextBoxPassword.Text;
                dbcon.logins.InsertOnSubmit(log);

                reg.Name = metroTextBoxName.Text;
                reg.DOB = metroDateTime1.Text;
                reg.Gender = metroComboBoxGender.Text;
                reg.Address = metroTextBoxAddress.Text;
                reg.PhoneNo = metroTextBoxPhoneNo.Text;
                reg.Email = metroTextBoxEmail.Text;
                reg.Passport = metroTextBoxPassport.Text;
                reg.EntryDate = metroDateTime2.Text;
                reg.TypeOfRoom = metroComboBoxTypeOfRoom.Text;
                reg.RoomAvailable = metroComboBox1.Text;
              //  reg.NumberOfRoom = metroTextBoxNumberOfRoomAvailable.Text;
                reg.Cost = metroTextBoxCost.Text;
                reg.AdvancePayment = metroTextBoxAdvancePayment.Text;
                reg.Due = metroTextBoxDue.Text;
                reg.Password = metroTextBoxPassword.Text;
                reg.ConfirmPassword = metroTextBoxConfrimPassword.Text;
                reg.DayReserve = metroTextBoxDayReserve.Text;

                dbcon.registers.InsertOnSubmit(reg);
                dbcon.SubmitChanges();
                MetroMessageBox.Show(Owner, "registration complete");

                metroTextBoxName.Clear();
                //  metroDateTime1.SelectedItem = null;
                metroComboBoxGender.SelectedItem = null;
                metroTextBoxAddress.Clear();
                metroTextBoxPhoneNo.Clear();
                metroTextBoxEmail.Clear();
                metroTextBoxPassport.Clear();
                metroComboBoxTypeOfRoom.SelectedItem = null;
                metroComboBox1.SelectedItem = null;
               // metroTextBoxNumberOfRoomAvailable.Clear();
                metroTextBoxCost.Clear();
                metroTextBoxAdvancePayment.Clear();
                metroTextBoxDue.Clear();
                metroTextBoxPassword.Clear();
                metroTextBoxConfrimPassword.Clear();
                metroTextBoxDayReserve.Clear();

            }
            else { MetroMessageBox.Show(Owner, "Please enter same Password");
                metroTextBoxConfrimPassword.Clear();
            }
        }
        
    public TextBox registration
        {
            get
            {
                return registration;
            }
        }

    
        private void Registration_Load_1(object sender, EventArgs e)
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

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void metroTextBoxEmail_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(metroTextBoxPhoneNo.Text, "[^0-9]"))
            {
                MetroMessageBox.Show(Owner, "Please enter only numbers as Phone No.");
                metroTextBoxPhoneNo.Text.Remove(metroTextBoxPhoneNo.Text.Length - 1);
            }
        }

        private void metroTextBoxCost_Click(object sender, EventArgs e)
        {

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

                metroTextBoxDue.Text = Convert.ToString((Convert.ToInt32(metroTextBoxCost.Text))- Convert.ToInt32(metroTextBoxAdvancePayment.Text)).ToString();

            }
            metroTextBoxDue.Enabled = false;
            metroTextBoxAdvancePayment.Enabled = false;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Details().Show();
        }

        private void metroTextBoxCost_Click_1(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBoxAdvancePayment_Click(object sender, EventArgs e)
        {

        }
    }
}
