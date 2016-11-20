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

namespace HotelManagementSystem
{
    public partial class User :MetroFramework.Forms.MetroForm
    {
        public User()
        {
            InitializeComponent();

            metroLabel1.Text = LogIn.user;
            RegistrationDataContext dbcon = new RegistrationDataContext();
            register r = dbcon.registers.SingleOrDefault(x => x.Name == LogIn.user);

            if (r != null)
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
            //    metroLabel10.Text = r.NumberOfRoom;
                metroLabel11.Text = r.Cost;
                metroLabel12.Text = r.AdvancePayment;
                metroLabel13.Text = r.Due;
                metroLabel14.Text = r.Password;

            }
           
        }



        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_Management_SystemDataSet1.login' table. You can move, or remove it, as needed.
          //  this.loginTableAdapter.Fill(this.hotel_Management_SystemDataSet1.login);
            // TODO: This line of code loads data into the 'hotel_Management_SystemDataSet1.register' table. You can move, or remove it, as needed.
           // this.registerTableAdapter.Fill(this.hotel_Management_SystemDataSet1.register)


        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
            
            
           
        //}

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Update up = new User_Update();
            up.Show();

           // new test().Show();
            //RegistrationDataContext dbcon = new RegistrationDataContext();
            //String Email = metr.Text;
            //Student s = dbcon.Students.SingleOrDefault(x => x.id == id);
            //if (s != null)
            //{
            //    s.name = textBox1.Text;
            //    s.email = textBox2.Text;
            //    dbcon.SubmitChanges();
            //    MessageBox.Show("data updated");
            //}
            //else
            //{
            //    MessageBox.Show("data not found");
            //}

        






    }

        private void metroTileLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogIn().Show();
        }
    }
    }

