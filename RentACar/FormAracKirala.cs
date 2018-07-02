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
    public partial class FormAracKirala : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=EROLCAN\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
        public FormAracKirala()
        {
            InitializeComponent();
        }
        private void FormAracKirala_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index i = new index();
            i.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into AracKirala (TC,Ad,Soyad,KiraSehir,KiraSure,AracMarka,AracModel,AracYil,AracTur) values (@tc,@ad,@soyad,@sehir,@sure,@marka,@model,@yil,@tur)", baglanti);
            komut.Parameters.AddWithValue("@tc", mbtc.Text);
            komut.Parameters.AddWithValue("@ad", tbad.Text);
            komut.Parameters.AddWithValue("@soyad", tbsoyad.Text);
            komut.Parameters.AddWithValue("@sehir", tbkis.Text);
            komut.Parameters.AddWithValue("@sure", tbks.Text);
            komut.Parameters.AddWithValue("@marka", cbmarka.Text);
            komut.Parameters.AddWithValue("@model", cbmodel.Text);
            komut.Parameters.AddWithValue("@yil", cbaracyil.Text);
            komut.Parameters.AddWithValue("@tur", cbaractur.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kiralama İşlemi Başarılı.");
        }

        private void cbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmarka.SelectedItem == "Renault")
            {
                cbmodel.Items.Clear();
                cbmodel.Items.Add("Clio").ToString();
                cbmodel.Items.Add("Megane");
            }
            if (cbmarka.SelectedItem == "BMW")
            {
                cbmodel.Items.Clear();
                cbmodel.Items.Add("3.20");
                cbmodel.Items.Add("5.20");
                cbmodel.Items.Add("z4");
            }
            if (cbmarka.SelectedItem == "Mercedes")
            {
                cbmodel.Items.Clear();
                cbmodel.Items.Add("A180");
                cbmodel.Items.Add("C180");
                cbmodel.Items.Add("CLS350");
            }
            if (cbmarka.SelectedItem == "AUDI")
            {
                cbmodel.Items.Clear();
                cbmodel.Items.Add("A3");
                cbmodel.Items.Add("A4");
                cbmodel.Items.Add("A5");
            }
            if (cbmarka.SelectedItem == "Ford")
            {
                cbmodel.Items.Clear();
                cbmodel.Items.Add("Focus");
                cbmodel.Items.Add("Fiesta");
                cbmodel.Items.Add("Mondeo");
            }
            if (cbmarka.SelectedItem == "Wolswagen")
            {
                cbmodel.Items.Clear();
                cbmodel.Items.Add("Golf");
                cbmodel.Items.Add("Polo");
                cbmodel.Items.Add("Passat");
            }
            if (cbmarka.SelectedItem == "Fiat")
            {
                cbmodel.Items.Clear();
                cbmodel.Items.Add("Linea");
                cbmodel.Items.Add("Egea");
            }
        }
    }
}
