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

namespace RentACar
{
    public partial class FormGiris : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=EROLCAN\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
        public FormGiris()
        {
            InitializeComponent();
        }
        private void FormGiris_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Transparent;
            tbsifre.PasswordChar = '*';
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSifreUnuttum fsu = new FormSifreUnuttum();
            fsu.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUyeOl fuo = new FormUyeOl();
            fuo.Show();
            this.Hide();
        }
        private void buttongiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Uyeler where KullaniciAdi=@kad and Sifre=@sifre",baglanti);
            komut.Parameters.AddWithValue("@kad", tbad.Text);
            komut.Parameters.AddWithValue("@sifre", tbsifre.Text);
            SqlDataReader dr1 = komut.ExecuteReader();
            if(dr1.Read())
            {
                index i = new index();
                i.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifreniz hatalı...");
            }
        }
    }
}
