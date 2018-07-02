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
    public partial class FormKiraUyeOl : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=EROLCAN\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
        public FormKiraUyeOl()
        {
            InitializeComponent();
        }

        private void FormKiraUyeOl_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index i = new index();
            i.Show();
            this.Close();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into KiraUyeOl (Ad,Soyad,DogumYeri,Meslek,Telefon,TC,Adres,EhliyetNo,EhliyetTur,Notlar) values (@adi,@soyadi,@dogum,@mes,@tel,@tc,@adr,@ehtno,@ehttur,@not)", baglanti);
            komut.Parameters.AddWithValue("@adi", tbad.Text);
            komut.Parameters.AddWithValue("@soyadi", tbsoyad.Text);
            komut.Parameters.AddWithValue("@dogum", tbdyer.Text);
            komut.Parameters.AddWithValue("@mes", tbmeslek.Text);
            komut.Parameters.AddWithValue("@tel", mbtel.Text);
            komut.Parameters.AddWithValue("@tc", mbtc.Text);
            komut.Parameters.AddWithValue("@adr", tbadres.Text);
            komut.Parameters.AddWithValue("@ehtno", tbeno.Text);
            komut.Parameters.AddWithValue("@ehttur", tbetur.Text);
            komut.Parameters.AddWithValue("@not", tbnotlar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Kaydı Başarılı.");
        }
    }
}
