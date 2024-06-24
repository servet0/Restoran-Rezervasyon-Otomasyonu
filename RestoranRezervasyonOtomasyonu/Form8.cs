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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestoranRezervasyonOtomasyonu
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=Restoran;Integrated Security=True");

        private void mesajlari_goster()
        {
            // Mesajları göstermek için gereken kodlar

            listView1.Items.Clear();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Mesaj", baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["Mesajid"].ToString();
                ekle.SubItems.Add(reader["Adisoyadi"].ToString());
                ekle.SubItems.Add(reader["Mesaj"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Textbozlara girilen ad soyad ve mesajları kaydetmek için kaydet butonunun kodları
            // Kaydet butonu
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesaj(Adisoyadi, Mesaj) values('" + textBox1.Text + "', '" + richTextBox1.Text + "') ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajınız kaydedilmiştir");
            mesajlari_goster();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            mesajlari_goster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            // listview üzerinde bazı özelliklerle çalışma

            // Burada mesajları textboxlar üzerinde görmek için çift tıkladığımızda özelliğin çalışması için gereken kodlar
            

            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text); // id'yi hafızada tutuyoruz
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text; // Adı soyadı yazdırmak için yaptık
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text; // Mesajı yazdırmak için yaptık
             
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
