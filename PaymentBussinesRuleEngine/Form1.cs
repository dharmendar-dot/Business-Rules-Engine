using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace PaymentBussinesRuleEngine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (txtProductId.Text != "" && txtProductName.Text!="" && txtCustomerName.Text!="" && txtAmount.Text!="")
            {
                DvPrintPreviewDialog.Document = DvPrintDocument;
                DvPrintPreviewDialog.Show();
               
            }
            else
            {
                MessageBox.Show("Fill all data first");
            }
            

        }

        private void DvPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.Company_logo;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width,newImage.Height);
            e.Graphics.DrawString("Product ID : " + txtProductId.Text, new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new Point(25, 180));
            e.Graphics.DrawString("Product Name : "  + txtProductName.Text , new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString("Customer Name : " + txtCustomerName.Text, new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new Point(25, 220));
            e.Graphics.DrawString("Quantity Unit : " + txtQuantityUnit.Text, new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new Point(25, 240));
            e.Graphics.DrawString("Amount : " + txtAmount.Text, new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new Point(25, 260));
            e.Graphics.DrawString("Agent Commision : " + txtCommision.Text, new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new Point(25, 280));

            
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text != "")
            {
                decimal agentCommision = Convert.ToInt32(txtAmount.Text) / 6;
                txtCommision.Text = agentCommision.ToString();
            }
            else
            {
                txtCommision.Text = "0";
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            DvPrintPreviewDialog.Document = DvPrintDocument;
            DvPrintPreviewDialog.Show();
            DvPrintDocument.Dispose();
            

        }

        private void btnMambership_Click(object sender, EventArgs e)
        {
            MailMessage message;
            SmtpClient smtp;

            int row = 0;
            dataGridViewMembership.Rows.Add();
            row = dataGridViewMembership.Rows.Count - 2;
            dataGridViewMembership["customerId", row].Value = txtCustomerId.Text;
            dataGridViewMembership["customerAdd", row].Value = txtCustomerAdd.Text;
            dataGridViewMembership["customerNo", row].Value = txtCustomerNo.Text;
            dataGridViewMembership["customerEmail", row].Value = txtEmail.Text;

            
            // set smtp details

            smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 25;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("abc.xyz@gmail.com", "********");
            //smtp.SendAsync(message, message.Subject);
            //smtp.SendCompleted += new SendCompletedEventHandler(smtp_SendCompleted);
            MessageBox.Show("Membership Activated  and msg send to Email");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MailMessage message;
            SmtpClient smtp;

            smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 25;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("abc.xyz@gmail.com", "********");
            //smtp.SendAsync(message, message.Subject);
            //smtp.SendCompleted += new SendCompletedEventHandler(smtp_SendCompleted);
            MessageBox.Show("Membership Updates completed and msg send to Email");
        }
             
    }
}
