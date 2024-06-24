using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranRezervasyonOtomasyonu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Admin Giriş butonu

            Form1 adminGiris = new Form1(); // Form1'deki admin girişe yönlendirir
            adminGiris.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Yeni Rezerve butonu

            Form2 rezerveEkle = new Form2(); // Form2'deki rezerve eklemeye yönlendirir
            rezerveEkle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Rezerveleri Göster butonu
            
            Form5 rezerveler = new Form5(); // Form5'deki rezerveleri gösteren sayfaya yönlendirir
            rezerveler.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Masalar butonu

            Form4 masalar = new Form4(); // Form4'deki masaların durumunu görmeye yönlendirir
            masalar.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Exit butonu 

            //Application.Exit();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 radyo = new Form6(); // Form6'daki radyoya yönlendirir
            radyo.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 sifreguncelle = new Form7(); // Form7'deki şifre güncellemeye yönlendirir
            sifreguncelle.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 mesajlar = new Form8(); // Form8'deki Mesajlara yönlendirir
            mesajlar.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Home butonu
            Form3 anasayfa = new Form3(); // Form3'deki Anasayfaya yönlendirir
            anasayfa.Show();
            this.Hide();
        }
    }
}
