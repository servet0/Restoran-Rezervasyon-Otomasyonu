using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranRezervasyonOtomasyonu
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=Restoran;Integrated Security=True");
        
        private void rezerveleri_goster()
        {
            // Rezerveleri Göster butonunun çalışması için gereken kodlar

            listView1.Items.Clear();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Rezerveler", baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["Rezerveid"].ToString();
                ekle.SubItems.Add(reader["Adi"].ToString());
                ekle.SubItems.Add(reader["Soyadi"].ToString());
                ekle.SubItems.Add(reader["Telefon"].ToString());
                ekle.SubItems.Add(reader["Misafirsayisi"].ToString());
                ekle.SubItems.Add(reader["Masanumarasi"].ToString());
                ekle.SubItems.Add(reader["Tarih"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Rezerveleri GÖster butonu

            rezerveleri_goster();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Güncelle butonu
            
            // Rezerve bilgilerini güncelliyoruz

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Rezerveler set Adi = '"+textBox1.Text+"', Soyadi = '"+textBox2.Text+"', Telefon = '"+maskedTextBox1.Text+"', Misafirsayisi = '"+textBox3.Text+"', Masanumarasi = '"+textBox5.Text+"', Tarih = '"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+"' where Rezerveid="+id+" ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            rezerveleri_goster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {
            // listview üzerinde bazı özelliklerle çalışma

            // Burada rezerveleri güncellemek için verilerin üzerine tıkladığımızda tablodan textboxlara
            // rezerve bilgileri iletilsin diye işlemler yapıyoruz.

            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text); // id'yi hafozada tutuyoruz
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text; // Adı yazdırmak için yaptık
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text; // Soyadı yazdırmak için yaptık
            maskedTextBox1.Text = listView1.SelectedItems[0].SubItems[3].Text; // Telefon yazdırmak için yaptık
            textBox3.Text = listView1.SelectedItems[0].SubItems[4].Text; // Adı yazdırmak için yaptık
            textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text; // Adı yazdırmak için yaptık
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[6].Text; // Adı yazdırmak için yaptık
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Sil butonu

            if (textBox5.Text == "01")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Masa01", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
            }

            if (textBox5.Text == "02")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Masa02", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
            }

            if (textBox5.Text == "03")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Masa03", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
            }

            if (textBox5.Text == "04")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Masa04", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
            }

            if (textBox5.Text == "05")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Masa05", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
            }

            if (textBox5.Text == "06")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Masa06", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
            }

            if (textBox5.Text == "07")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Masa07", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
            }

            if (textBox5.Text == "08")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Masa08", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
            }

            if (textBox5.Text == "09")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Masa09", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
            }

            if (textBox5.Text == "10")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Masa10", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
            }

            if (textBox5.Text == "11")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Masa11", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
            }

            if (textBox5.Text == "12")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Masa12", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
            }

        

            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Rezerveler where Rezerveid=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            rezerveleri_goster();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Rezerve bilgilerini girdiğimiz formu temizle işlemi
            // Formu hızlı temizleme

            // Formu temizle butonu

            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            textBox3.Clear();
            textBox5.Clear();
            dateTimePicker1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Ara butonu

            // 

            listView1.Items.Clear();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Rezerveler where Telefon like '%" + textBox4.Text+ "%' ", baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["Rezerveid"].ToString();
                ekle.SubItems.Add(reader["Adi"].ToString());
                ekle.SubItems.Add(reader["Soyadi"].ToString());
                ekle.SubItems.Add(reader["Telefon"].ToString());
                ekle.SubItems.Add(reader["Misafirsayisi"].ToString());
                ekle.SubItems.Add(reader["Masanumarasi"].ToString());
                ekle.SubItems.Add(reader["Tarih"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Home butonu
            Form3 anasayfa = new Form3(); // Form3'deki Anasayfaya yönlendirir
            anasayfa.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Exit butonu 

            //Application.Exit();
            this.Close();
        }
    }
}
