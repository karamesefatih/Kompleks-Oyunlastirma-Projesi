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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        BaglantiSinif bgl2 = new BaglantiSinif();
        DataTable tablo = new DataTable();
        int a, b, c, d, e, f, g, h, ı, j, k, l, m;
        string ç, ş, i;
        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand komut322 = new SqlCommand("select count(*) from satıcıbilgi", baglan);


            SqlDataReader okuyucu222 = komut322.ExecuteReader();
            while (okuyucu222.Read())
            {
                d = okuyucu222[0].GetHashCode();

            }
            okuyucu222.Close();
            baglan.Close();

            for (int i = 0; i < d; i++)
            {

                baglan.Open();
                SqlCommand komut3 = new SqlCommand("select Aylıkhedefyüzdesi from SatıcıBilgi where Ad_Soyad = @Numara ", baglan);

                komut3.Parameters.AddWithValue("@NUMARA", dataGridView1.Rows[i].Cells[1].Value.ToString());
                SqlDataReader okuyucu2 = komut3.ExecuteReader();
                while (okuyucu2.Read())
                {
                    a = okuyucu2[0].GetHashCode();

                }
                okuyucu2.Close();
                baglan.Close();


                if (a >= 100)
                {
                    baglan.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglan;
                    cmd.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Tarih,Kategori)Values(@Fatih," + 500 + ",getdate(),'hedefi geçme')";
                    cmd.Parameters.AddWithValue("@Fatih", dataGridView1.Rows[i].Cells[1].Value.ToString());

                    cmd.ExecuteNonQuery();

                    baglan.Close();
                    MessageBox.Show("Aylık Puan hesaplama işlemi tamamlanmıştır");
                }
             
            }
        }
     
            

            private void button1_Click(object sender, EventArgs e)
        {
            Form17 f6 = new Form17();
            f6.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form21 f2 = new Form21();
            f2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form19 f2 = new Form19();
            f2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form18 f2 = new Form18();
            f2.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form20 f2 = new Form20();
            f2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form22 f2 = new Form22();
            f2.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form23 f2 = new Form23();
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form24 f2 = new Form24();
            f2.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form34 f2 = new Form34();
            f2.Show();
            this.Hide();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'oyunlaştırmaDataSet.SatıcıBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
     
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();

            SqlDataAdapter adtr = new SqlDataAdapter("select * from satıcıBilgi", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();

            baglan.Close();

            label1.Text = Form2.kadi;
          
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form46 f1 = new Form46();
            f1.Show();
            this.Hide();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand komut32 = new SqlCommand("select count(*) from satıcıbilgi", baglan);


            SqlDataReader okuyucu22 = komut32.ExecuteReader();
            while (okuyucu22.Read())
            {
                d = okuyucu22[0].GetHashCode();

            }
            okuyucu22.Close();
            baglan.Close();

            for (int i = 0; i < d; i++)
            {

                baglan.Open();
                SqlCommand komut3 = new SqlCommand("select Aylıkhedefyüzdesi from SatıcıBilgi where Ad_Soyad = @Numara ", baglan);

                komut3.Parameters.AddWithValue("@NUMARA", dataGridView1.Rows[i].Cells[1].Value.ToString());
                SqlDataReader okuyucu2 = komut3.ExecuteReader();
                while (okuyucu2.Read())
                {
                    a = okuyucu2[0].GetHashCode();

                }
                okuyucu2.Close();
                baglan.Close();







                baglan.Open();
                SqlCommand komut4 = new SqlCommand(" Select sum(fiyat)  from Satış_Bilgileri where ad_soyad =  @NUMARA  ", baglan);
                komut4.Parameters.AddWithValue("@NUMARA", dataGridView1.Rows[i].Cells[1].Value.ToString());
                SqlDataReader okuyucu4 = komut4.ExecuteReader();


                while (okuyucu4.Read())
                {

                    c = okuyucu4[0].GetHashCode() / 10000;

                }
                okuyucu4.Close();
                baglan.Close();




                SqlConnection baglan1787 = new SqlConnection(bgl.Adres);
                baglan1787.Open();
                SqlCommand komut01 = new SqlCommand();
                komut01.Connection = baglan1787;
                komut01.CommandText = "Insert Into Puanlar(Ad_Soyad, Puan , Kategori ,Tarih)Values(@Fatih, " + c + ",'satış',GETDATE())";
                komut01.Parameters.AddWithValue("@Fatih", dataGridView1.Rows[i].Cells[1].Value.ToString());
                komut01.ExecuteNonQuery();
                baglan1787.Close();






                baglan.Open();
                SqlCommand komut414 = new SqlCommand(" select sum(Stok_Puanı) from Satış_Bilgileri where Ad_Soyad= @NUMARA  ", baglan);
                komut414.Parameters.AddWithValue("@NUMARA", dataGridView1.Rows[i].Cells[1].Value.ToString());
                SqlDataReader okuyucu414 = komut414.ExecuteReader();


                while (okuyucu414.Read())
                {

                    l = okuyucu414[0].GetHashCode();

                }
                okuyucu414.Close();
                baglan.Close();


                SqlConnection baglan787 = new SqlConnection(bgl.Adres);
                baglan1787.Open();
                SqlCommand komut1 = new SqlCommand();
                komut1.Connection = baglan1787;
                komut1.CommandText = "Insert Into Puanlar(Ad_Soyad, Puan , Kategori ,Tarih)Values(@Fatih, " + l + ",'STOK SATIŞ PUANI',GETDATE())";
                komut1.Parameters.AddWithValue("@Fatih", dataGridView1.Rows[i].Cells[1].Value.ToString());
                komut1.ExecuteNonQuery();
                baglan1787.Close();



              

              


            }



            baglan.Open();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = baglan;
            cmd2.CommandText = "DELETE FROM Satış_Bilgileri ";

            cmd2.ExecuteNonQuery();
            baglan.Close();
            baglan.Open();
        
            SqlCommand komut1ÜÜl = new SqlCommand();
            komut1ÜÜl.Connection = baglan;
            komut1ÜÜl.CommandText = "     DELETE FROM PUANLAR WHERE PUAN > 100 and kategori = 'satış'";
            komut1ÜÜl.ExecuteNonQuery();
            baglan.Close();


            MessageBox.Show("Puan hesaplama işlemi tamamlanmıştır");



        }
}
}
