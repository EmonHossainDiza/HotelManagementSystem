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
    public partial class User_Update : MetroFramework.Forms.MetroForm

    {
        public User_Update()
        {
            InitializeComponent();
        }

        private void User_Update_Load(object sender, EventArgs e)
        {

        }

        //private void metroTile1_Click(object sender, EventArgs e)
        //{
        //    //RegistrationDataContext dbcon = new RegistrationDataContext();
        //    //String Email = metr.Text;
        //    //Student s = dbcon.Students.SingleOrDefault(x => x.id == id);
        //    //if (s != null)
        //    //{
        //    //    s.name = textBox1.Text;
        //    //    s.email = textBox2.Text;
        //    //    dbcon.SubmitChanges();
        //    //    MessageBox.Show("data updated");
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("data not found");
        //    //}

        //    RegistrationDataContext dbcon = new RegistrationDataContext();

        //    if (dbcon.registers.Any(x => x.Name == LogIn.user && x.Password == metroTextBoxPassword.Text == true))
        //    {
        //        login l = new login();

        //        l = dbcon.logins.SingleOrDefault(x => x.Name == LogIn.user);

        //        l.Name = metroTextBoxName.Text;
        //        l.Password = metroTextBoxPassword.Text;
        //        dbcon.SubmitChanges();

        //        MessageBox.Show("password updated succesfully");

        //        new LogIn().Show();


        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationDataContext dbcon = new RegistrationDataContext();

            if (dbcon.registers.Any(x => x.Name == LogIn.user == true))
            {
                login l = new login();
                register r = new register();
                l = dbcon.logins.SingleOrDefault(x => x.Name == LogIn.user);
                r = dbcon.registers.SingleOrDefault(x => x.Name == LogIn.user);
                // if(r != null)
                // {
                // l.Name = textBox2.Text;
                if (textBox2.Text == LogIn.user)
                {
                    if (textBoxConfirmPassword.Text == textBox6.Text)
                    {
                        l.Password = textBox6.Text;
                        //r.Name = textBox2.Text;
                        r.Password = textBox6.Text;
                        r.Address = textBox3.Text;
                        r.PhoneNo = textBox4.Text;
                        r.Email = textBox5.Text;
                        r.ConfirmPassword = textBoxConfirmPassword.Text;

                        dbcon.SubmitChanges();

                        MetroMessageBox.Show(Owner, "password updated succesfully");

                        //new LogIn().Show();
                        this.Hide();
                        new LogIn().Show();
                    }
                    else {
                        MetroMessageBox.Show(Owner, "Please enter same Password");
                        textBoxConfirmPassword.Clear();
                    }
                }
                else {
                    MetroMessageBox.Show(Owner, "Incorrect user name");
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void metroLabelAddress_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User().Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MetroMessageBox.Show(Owner, "Please enter only numbers as Phone No.");
                textBox4.Text.Remove(textBox4.Text.Length - 1);
            }
        }
    }
}
