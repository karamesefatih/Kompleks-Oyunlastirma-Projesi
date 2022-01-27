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
    public partial class Form66 : Form
    {
        string a;
        public Form66()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        private void Form66_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand kom2 = new SqlCommand("select ŞİFRE from kullanıcılar WHERE Ad_Soyad = '" + textBox3.Text + "'");
            kom2.Connection = baglan;
            SqlDataReader dr2 = kom2.ExecuteReader();
            while (dr2.Read())
            {

                a = dr2[0].ToString();

            }
            dr2.Close();
            baglan.Close();
            label5.Text = a;


            if (textBox1.Text == "" || textBox2.Text =="")
            {
                MessageBox.Show("Lütfen Bir Şifre Seçin", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(textBox1.Text != textBox2.Text)
            {

                MessageBox.Show("Belirlediğiniz şifreler aynı değil", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (label5.Text == "")
                {
             
                    baglan.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglan;
                    cmd.CommandText = "UPDATE Kullanıcılar Set Şifre =  " + textBox2.Text + " where Ad_Soyad ='" + textBox3.Text + "'";

                    cmd.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Şifre Güncelleme İşlemi Tamamlandı", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Zaten Bir Şifreniz Bulunmakta", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
