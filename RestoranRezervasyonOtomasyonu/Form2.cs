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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection ("Data Source=.;Initial Catalog=Restoran;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Butonun üzerine tıklanıldığında masa text kısmında masa numarası yazmasını sağlar
            textBox5.Text = "01";

            // Burada yeni rezerve eklerken aynı zamanda Masalar table'ına da kaydetmiş olacağız 
            // ve bu hem Masalar formuna da etki etmiş olacak hem de Yeni Rezerve formuna da etki etmiş olacak
            // Bu sayede table'lar birbirleriyle bağlantılı olmuş olacak.

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Masa01 (Adi,Soyadi) values ('" + textBox1.Text + "', '" + textBox2.Text + "') ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Text = "02";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Masa02 (Adi,Soyadi) values ('" + textBox1.Text + "', '" + textBox2.Text + "') ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Text = "03";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Masa03 (Adi,Soyadi) values ('" + textBox1.Text + "', '" + textBox2.Text + "') ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "04";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Masa04 (Adi,Soyadi) values ('" + textBox1.Text + "', '" + textBox2.Text + "') ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Text = "05";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Masa05 (Adi,Soyadi) values ('" + textBox1.Text + "', '" + textBox2.Text + "') ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Text = "06";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Masa06 (Adi,Soyadi) values ('" + textBox1.Text + "', '" + textBox2.Text + "') ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.Text = "07";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Masa07 (Adi,Soyadi) values ('" + textBox1.Text + "', '" + textBox2.Text + "') ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox5.Text = "08";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Masa08 (Adi,Soyadi) values ('" + textBox1.Text + "', '" + textBox2.Text + "') ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox5.Text = "09";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Masa09 (Adi,Soyadi) values ('" + textBox1.Text + "', '" + textBox2.Text + "') ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox5.Text = "10";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Masa10 (Adi,Soyadi) values ('" + textBox1.Text + "', '" + textBox2.Text + "') ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox5.Text = "11";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Masa11 (Adi,Soyadi) values ('" + textBox1.Text + "', '" + textBox2.Text + "') ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox5.Text = "12";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Masa12 (Adi, Soyadi) values ('" + textBox1.Text + "', '" + textBox2.Text + "') ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mavi Renkli Masalar Rezervesiz Masalar Olduğunu Gösterir");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Masalar Rezerveli Masalar Olduğunu Gösterir");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Form de olduğu gibi masa durumlarını ve bilgilerini gösterir

            try
            {
                baglanti.Open();
                for (int i = 1; i <= 12; i++)
                {
                    string tableName = "Masa" + i.ToString("00"); // "Masa05", "Masa06", ..., "Masa12"
                    string buttonName = "button" + (i + 1).ToString(); // "button6", "button7", ..., "button13"

                    Button button = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;

                    if (button != null)
                    {
                        SqlCommand komut = new SqlCommand($"select * from {tableName}", baglanti);
                        SqlDataReader read = komut.ExecuteReader();

                        if (read.Read())
                        {
                            button.Text = read["Adi"].ToString() + " " + read["Soyadi"].ToString();
                            button.BackColor = Color.Salmon;
                            button.Enabled = false;
                        }

                        read.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Kaydet butonu 

            // Kaydet butonu ile müşterilerin bilgilerini kaydedip rezerve ekliyoruz

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Rezerveler (Adi, Soyadi, Telefon, Misafirsayisi, Masanumarasi, Tarih) values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + maskedTextBox1.Text + "', '" + textBox3.Text + "', '" + textBox5.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            //SqlCommand komut = new SqlCommand("insert into Rezerveler (Adi, Soyadi, Misafirsayisi, Masanumarasi) values('"+textBox1.Text+"', '"+textBox2.Text+"', '"+textBox3.Text+"', '"+textBox5.Text+"')", baglanti);           
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Rezerve kaydı başarıyla yapıldı");
        }

        private void button16_Click(object sender, EventArgs e)
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

