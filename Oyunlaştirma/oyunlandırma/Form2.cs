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

namespace oyunlandırma
{
    public partial class Form2 : Form
    {

        public static string kadi;
        public Form2()
        {
            InitializeComponent();
      
        }
        BaglantiSinif bgl = new BaglantiSinif();

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection baglan = new SqlConnection(bgl.Adres);

            string ksifre, ktipi;
            kadi = textBox1.Text;
            ksifre = textBox2.Text;

            baglan.Open();
            SqlCommand sorgu = new SqlCommand("SELECT [c].[Rütbe]FROM[Kullanıcılar] AS[c]WHERE[c].[Ad_Soyad] COLLATE SQL_Latin1_General_CP1_CS_AS = N'" + kadi + "' and[c].[Şifre] COLLATE SQL_Latin1_General_CP1_CS_AS = N'" + ksifre + "' ", baglan);
            SqlDataReader oku = sorgu.ExecuteReader();
            if (oku.Read() == true)
            {

                ktipi = oku[0].ToString();
                if (ktipi == "Satıcı" || ktipi == "satıcı"  )
                {
                    Form3 kullanici = new Form3();
                    kullanici.Show();
                    kullanici.label1.Text = kadi;

                    kullanici.labelmal.Text = kadi;
                    this.Hide();
                }
                else if (ktipi == "Yönetici"  || ktipi == "yönetici")
                {
                    Form16 f = new Form16();
                    f.Show();
                    f.label1.Text = kadi;
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }


            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            baglan.Close();
            if (textBox1.Text.Trim() == "") errorProvider1.SetError(textBox1, "Boş Geçilemez");
            if (textBox2.Text.Trim() == "") errorProvider1.SetError(textBox2, "Boş Geçilemez");




        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand komut1 = new SqlCommand();
            komut1.Connection = baglan;
            komut1.CommandText = "DELETE FROM PUANLAR WHERE PUAN > 20000";
            komut1.ExecuteNonQuery();
            baglan.Close();

            baglan.Open();
            SqlCommand komut1ÜÜl = new SqlCommand();
            komut1ÜÜl.Connection = baglan;
            komut1ÜÜl.CommandText = "     DELETE FROM PUANLAR WHERE PUAN > 100 and kategori = 'satış'";
            komut1ÜÜl.ExecuteNonQuery();
            baglan.Close();
        }
  

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
         
               

                }
            }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
               


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form66 f66 = new Form66();
            f66.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
         


            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
              


            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else if(checkBox1.CheckState == CheckState.Unchecked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }
    }
    }
    

