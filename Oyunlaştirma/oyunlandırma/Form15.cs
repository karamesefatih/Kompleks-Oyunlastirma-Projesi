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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        DataTable tablo = new DataTable();
        private void Form15_Load(object sender, EventArgs e)
        {
     

           
            
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            label1.Text = Form2.kadi;
            SqlDataAdapter adtr = new SqlDataAdapter("select * from geçmiş_satışlar where Ad_Soyad ='" + label1.Text + "'", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();

            baglan.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {
    
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}