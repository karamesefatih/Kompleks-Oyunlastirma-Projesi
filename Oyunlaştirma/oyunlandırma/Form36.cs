using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace oyunlandırma
{
    public partial class Form36 : Form
    {
        public Form36()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form3 f3 = new Form3();
           
            f3.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
            this.Hide();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        DataTable tablo = new DataTable();

        private void Form36_Load(object sender, EventArgs e)
        {
          
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            label2.Text = Form2.kadi;
            SqlDataAdapter adtr = new SqlDataAdapter("select * from puanlar where Ad_Soyad ='"+label2.Text+"'", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            SqlCommand kom = new SqlCommand("select sum(puan) from Puanlar where Ad_Soyad='" + label2.Text + "'");
            kom.Connection = baglan;
            SqlDataReader dr = kom.ExecuteReader();
            while (dr.Read())
            {
                label3.Text = dr[0] + " ";
           
            }
            dr.Close();
            baglan.Close();
            baglan.Close();
        }
    }
}
