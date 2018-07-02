using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace RentACar
{
    public partial class FormSifreUnuttum : Form
    {
        public FormSifreUnuttum()
        {
            InitializeComponent();
        }
        FormGiris fg = new FormGiris();
        private void button1_Click(object sender, EventArgs e)
        {
            fg.Show();
            this.Hide();
        }
        private void FormSifreUnuttum_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Transparent;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MailMessage eposta = new MailMessage();
            eposta.From = new MailAddress("dermirerol123@gmail.com");
            eposta.To.Add(textBox2.Text);
            eposta.Subject = "Şifre yenileme";
            eposta.Body = "123456";
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("dermirerol123@gmail.com", "sifre");
            smtp.Host = "dermirerol123@gmail.com";
            smtp.Send(eposta);
        }
    }
}
