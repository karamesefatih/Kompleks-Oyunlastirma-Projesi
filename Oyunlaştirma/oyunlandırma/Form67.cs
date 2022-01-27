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
    public partial class Form67 : Form
    {
        public Form67()
        {
            InitializeComponent();
        }
        int c;
        public string a,b,d,e,f;

        BaglantiSinif bgl = new BaglantiSinif();
        DataTable tablo = new DataTable();

        private void button3_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form46 f46 = new Form46();
            f46.Show();
            this.Hide();
        }

    


    

      
        private void Form67_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();

            SqlDataAdapter adtr = new SqlDataAdapter("select * from İddalı_Stok_Satış_Kontrol", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();

            baglan.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {


            sayac();
        }
        void sayac()
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand kom6 = new SqlCommand("select ürün_kodu from İddalı_Stok_Satış_Kontrol  where  Kimlik=@NUMARA");
            kom6.Parameters.AddWithValue("@NUMARA", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            kom6.Connection = baglan;
            SqlDataReader dr6 = kom6.ExecuteReader();
            while (dr6.Read())
            {
                d = dr6[0].ToString();


            }
            dr6.Close();

            SqlCommand kom61 = new SqlCommand("select kazanc from İddialı_Stok_Satış  where Ürün_kodu = '" + d + "'");

            kom61.Connection = baglan;
            SqlDataReader dr61 = kom61.ExecuteReader();
            while (dr61.Read())
            {
                c = dr61[0].GetHashCode();


            }
            dr61.Close();

            SqlCommand kom16 = new SqlCommand("select satıcı from İddalı_Stok_Satış_Kontrol  where  Kimlik=@NUMARA");
            kom16.Parameters.AddWithValue("@NUMARA", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            kom16.Connection = baglan;
            SqlDataReader dr16 = kom16.ExecuteReader();
            while (dr16.Read())
            {
                f = dr16[0].ToString();


            }
            dr16.Close();


            SqlCommand komut24 = new SqlCommand();
            komut24.Connection = baglan;
            komut24.CommandText = " delete from İddalı_Stok_Satış_Kontrol where Ürün_Kodu = '" + d + "' ";

            komut24.ExecuteNonQuery();
            baglan.Close();

            baglan.Open();
            SqlCommand komut23 = new SqlCommand();
            komut23.Connection = baglan;
            komut23.CommandText = " delete from İddialı_Stok_Satış where  Ürün_Kodu = '" + d + "'  ";

            komut23.ExecuteNonQuery();


            baglan.Close();
            baglan.Open();
            SqlCommand komut241 = new SqlCommand();
            komut241.Connection = baglan;
            komut241.CommandText = " insert into puanlar (Ad_Soyad,kategori,tarih,puan)VALUES('" + f + "','Stok İddiası',getdate()," + c + ")   ";
            komut241.ExecuteNonQuery();
            baglan.Close();



            MessageBox.Show("İşlem tamamlandı");
        }
    }
}
