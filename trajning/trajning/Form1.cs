using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace trajning
{
    public SqlCommand komand;
    public SqlConnection lidhja = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Trajning;Integrated Security=True;");
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now.Date;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SendEmail();
        }


        private void SendEmail()
        {
            string senderEmail = "erio1g01@gmail.com";
            string senderPassword = "Erionig@@";
            string recipientEmail = textBox4.Text;
            string subject = "Pagesa mujore";
            string message = "Hello";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(senderEmail, senderPassword),
                EnableSsl = true
            };

            MailMessage mail = new MailMessage(senderEmail, recipientEmail, subject, message);
            
            try
            {
                smtpClient.Send(mail);
                MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mail.Dispose();
                smtpClient.Dispose();
            }

        }
    }
    }
