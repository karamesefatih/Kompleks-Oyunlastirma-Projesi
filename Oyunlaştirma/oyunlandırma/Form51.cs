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
    public partial class Form51 : Form
    {
        public Form51()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void Form51_Load(object sender, EventArgs e)
        {
            label1.Text = Form2.kadi;

            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand komut1 = new SqlCommand();
            komut1.Connection = baglan;
            komut1.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('" + label1.Text + "',100 ,'QUİZ MİKSER',GETDATE() )";
            komut1.ExecuteNonQuery();
            baglan.Close();

        }
    }
}
