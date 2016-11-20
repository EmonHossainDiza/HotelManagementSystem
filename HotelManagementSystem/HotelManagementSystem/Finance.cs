using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//using System.IO;
//using iTextSharp.text;
//using iTextSharp.text.pdf;

namespace HotelManagementSystem
{
    public partial class Finance : MetroFramework.Forms.MetroForm

    {
        public Finance()
        {
            InitializeComponent();
            //metroLabel9.Text=Admin.
            //metroLabel1.Text = LogIn.user;
            RegistrationDataContext dbcon = new RegistrationDataContext();
            register r = dbcon.registers.SingleOrDefault(x => x.RoomAvailable == metroLabel9.Text);

            if (r != null)
            {
                metroLabel1.Text = r.Name;
                metroLabel5.Text = r.PhoneNo;
                
                metroLabel8.Text = r.TypeOfRoom;
                metroLabel9.Text = r.RoomAvailable;
                
                metroLabel11.Text = r.Cost;
                metroLabel12.Text = r.AdvancePayment;
                metroLabel13.Text = r.Due;
                

            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        

        private void metroButtonCreatPdf_Click(object sender, EventArgs e)
        {
            //Document doc = new Document(iTextSharp.text.PageSize.LETTER,10,10,42,35);
            //PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("fuck.pdf", FileMode.Create));
            //doc.Open();
            //Paragraph para =new Paragraph("kadfldkf.\n");
            //doc.Add(para);
            //doc.Close();

            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog()==DialogResult.OK )
            {
                printDocument1.Print();

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(metroLabel1.Text,new Font("Arial",40,FontStyle.Bold),Brushes.Black,150,125);
        }
    }
}
