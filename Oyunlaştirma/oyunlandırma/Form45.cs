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
    public partial class Form45 : Form
    {
        public Form45()
        {
            InitializeComponent();
        }
        int f;
        string a;
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        private void Form45_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand kom2 = new SqlCommand("select ŞİFRE from kullanıcılar WHERE Ad_Soyad = '"+textBox1.Text+"'");
            kom2.Connection = baglan;
            SqlDataReader dr2 = kom2.ExecuteReader();
            while (dr2.Read())
            {

                a = dr2[0].ToString();

            }
            dr2.Close();
            baglan.Close();
            label2.Text = a;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form43 f43 = new Form43();
            f43.Show();
            this.Hide();
        }
    }
}
