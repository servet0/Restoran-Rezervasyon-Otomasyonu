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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=Restoran;Integrated Security=True");
        private void Form4_Load(object sender, EventArgs e)
        {
            // Masaların durumlarını gösteriyoruz

            // Masalar doluysa kırmızı, boşsa yeşildir

            // Masa doluysa masa üzerinde bazı müşteri bilgileri yazıyor

            // Masa durumu, bilgisini gösteren kodlar

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

            timer1.Start();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Home butonu
            Form3 anasayfa = new Form3(); // Form3'deki Anasayfaya yönlendirir
            anasayfa.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Exit butonu 

            //Application.Exit();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

