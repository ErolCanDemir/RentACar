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
    public partial class FormUyeOl : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=EROLCAN\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
        public FormUyeOl()
        {
            InitializeComponent();
        }
        FormGiris fg = new FormGiris();
        private void button2_Click(object sender, EventArgs e)
        {
            fg.Show();
            this.Hide();
        }

        private void FormUyeOl_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Transparent;
            tbsifre.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Uyeler (Ad,Soyad,Il,Ilce,Mahalle,Adres,Telefon,KullaniciAdi,Sifre) values(@adi,@soyadi,@sehir,@semt,@mah,@adr,@tel,@kad,@sif)", baglanti);
            komut.Parameters.AddWithValue("@adi", tbAd.Text);
            komut.Parameters.AddWithValue("@soyadi", tbsoyad.Text);
            komut.Parameters.AddWithValue("@sehir", comboBoxil.Text);
            komut.Parameters.AddWithValue("@semt", tbilce.Text);
            komut.Parameters.AddWithValue("@mah", tbmahalle.Text);
            komut.Parameters.AddWithValue("@adr", richTextBoxgadres.Text);
            komut.Parameters.AddWithValue("@tel", maskedTextBoxtnumara.Text);
            komut.Parameters.AddWithValue("@kad", textBoxkad.Text);
            komut.Parameters.AddWithValue("@sif", tbsifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı.");
        }
    }
}
