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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=Restoran;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Admin set kullanici = '" + textBox1.Text + "', sifre = '" + textBox2.Text + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Şifreniz Güncellendi");
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
