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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        int a,b;
        string c, d;
        public static int e, r, t, y, u, ı,o,q;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void Form14_Load(object sender, EventArgs e)
        {


            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();

            SqlCommand kom = new SqlCommand("SELECT Yıllık_Ciro,Aylık_Ciro,Stok_Adedi FROM SatıcıBilgi where Ad_Soyad = '" + label1.Text + "' ");
            kom.Connection = baglan;
            SqlDataReader dr = kom.ExecuteReader();
            while (dr.Read())
            {
                label4.Text = dr[0] + " ";
                label2.Text = dr[1] + "";
                label3.Text = dr[2] + "";
                y = dr[0].GetHashCode();
                q = dr[0].GetHashCode();
                r = dr[1].GetHashCode();
                t = dr[2].GetHashCode();
            }
            dr.Close();
            baglan.Close();


            baglan.Open();
            SqlCommand kom2 = new SqlCommand("SELECT Aylık_Hedef,Yıllık_Hedef,aylıkstok_hedefi FROM SatıcıBilgi where Ad_Soyad = '"+label1.Text+"'");
            kom2.Connection = baglan;
            SqlDataReader dr2 = kom2.ExecuteReader();
            while (dr2.Read())
            {
                label10.Text = dr2[0] + " ";
                label12.Text = dr2[1] + "";
                label13.Text = dr2[2] + "";
                u = dr2[0].GetHashCode();
                ı = dr2[1].GetHashCode();
            }
            dr2.Close();
            baglan.Close();

            /*   baglan.Open();
            SqlCommand kom42 = new SqlCommand("SELECT MONTH(getdate()) AS Month;");
            kom42.Connection = baglan;
            SqlDataReader dr42 = kom42.ExecuteReader();
            while (dr42.Read())
            {
                a = dr42[0].GetHashCode();
                b = dr42[0].GetHashCode() + 1;

            }

            dr42.Close();
            label14.Text = "2021.0" + a + ".01";
            label15.Text = "2021.0" + b + ".01";
            baglan.Close();
            baglan.Open();
            SqlCommand kom211 = new SqlCommand("select * from Geçmiş_Satışlar where  Ad_Soyad='" + label1.Text + "' and Ay_Yıl  Between '"+label14.Text+"' and  '"+label15.Text+"' ");
            kom211.Connection = baglan;
            SqlDataReader dr211 = kom211.ExecuteReader();
            while (dr211.Read())
            {
                label10.Text = dr211[4] + " ";
                o=dr211[4].GetHashCode();
                
            }
            dr211.Close();
            baglan.Close();

            */

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    } }
