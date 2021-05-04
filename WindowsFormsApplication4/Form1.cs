using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Uye kullanici = new Uye();
        DbCrud uye = new DbCrud();
        private void button1_Click(object sender, EventArgs e)
        {
            bool cevap;
            if (textBox2.Text==textBox3.Text)
            {
            kullanici.kullaniciadi = textBox1.Text;
             kullanici.sifre=textBox2.Text;
             kullanici.ad=textBox4.Text;
             kullanici.soyad=textBox5.Text;
             kullanici.eposta=textBox6.Text;
             kullanici.cinsiyet = Convert.ToInt16(comboBox1.SelectedIndex);
             kullanici.dogumtarihi=dateTimePicker1.Value;
             kullanici.resim = openFileDialog1.FileName;
            cevap =uye.kayit(kullanici);
           
                if (cevap==true)
                {
                    MessageBox.Show("Kayıt Yapıldı");
                }
                else
                {
                    MessageBox.Show("Kayıt Yapılamadı");
                }
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();            pictureBox1.Load(openFileDialog1.FileName);
        }
    }
}
