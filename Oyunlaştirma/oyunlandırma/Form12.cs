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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        DataTable tablo = new DataTable();
        SqlDataAdapter adtr;
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
        public void arama(string search)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();

            string q = "select * from Ürün_Bilgileri where Ürün_Kodu like '%" + search + "%'";
            adtr = new SqlDataAdapter(q, baglan);
            tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

            baglan.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
             SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();

            SqlDataAdapter adtr = new SqlDataAdapter("select * from ürün_bilgileri", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();

            baglan.Close();


        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            arama(textBox1.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
