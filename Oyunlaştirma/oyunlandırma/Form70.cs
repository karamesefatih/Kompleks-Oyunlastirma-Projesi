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
    public partial class Form70 : Form
    {
        public Form70()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        DataTable tablo = new DataTable();
        string b;
        int a, c, d, f;

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void Form70_Load(object sender, EventArgs e)
        {
            

            SqlConnection baglan = new SqlConnection(bgl.Adres);

            b = Form2.kadi;
            a = Form7.puan;

            baglan.Open();
            SqlCommand komut1 = new SqlCommand();
            komut1.Connection = baglan;
            komut1.CommandText = "INSERT INTO Puanlar(Ad_soyad,Puan,kategori,Tarih)VALUES('" + b + "'," + a + ",'QUİZ PUANI',getdate())";
            komut1.ExecuteNonQuery();
            baglan.Close();


        }
    }
}
