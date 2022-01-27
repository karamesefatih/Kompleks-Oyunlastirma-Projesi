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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        BaglantiSinif bgl2 = new BaglantiSinif();
        DataTable tablo = new DataTable();
        public int a, b, c, d, e, f, g, h, ı, j, k, l, m;
        string ç,ş,i;

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = baglan;
            cmd2.CommandText = "DELETE FROM SatıcıBilgi";
            cmd2.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Tüm Veriler Silindi");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Lütfen Listeden Bir Kayıt Seçin", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection baglan = new SqlConnection(bgl.Adres);
                baglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglan;
                cmd.CommandText = "UPDATE SatıcıBilgi Set Ad_Soyad ='" + textBox5.Text + "',Aylık_Ciro =" + textBox1.Text + ",Yıllık_Ciro =" + textBox2.Text + ",aylıkhedefyüzdesi =" + textBox3.Text + ",yıllıkhedefyüzdesi =" + textBox4.Text + ",aylık_hedef =" + textBox9.Text + ",yıllık_hedef =" + textBox8.Text + ",stok_adedi =" + textBox7.Text + ",özelpuanlıstokadedi =" + textBox6.Text + " where  Kimlik=@NUMARA";
                cmd.Parameters.AddWithValue("@NUMARA", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Eleman Güncelleme İşlemi Tamamlandı", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        
    }

        void listele()
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            textBox5.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";

            baglan.Close();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from SatıcıBilgi", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            baglan.Close();

        }

    void sayac()
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            
            SqlCommand komut = new SqlCommand("select count(*) from SatıcıBilgi", baglan);
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                label10.Text = okuyucu[0].ToString();
            }
            okuyucu.Close();
            baglan.Close();
        }
      
        private void button6_Click(object sender, EventArgs e)
          
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


                if (a >=100)
                {
                    baglan.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglan;
                    cmd.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Tarih,Kategori)Values(@Fatih," + 500 + ",getdate(),'hedefi geçme')";
                    cmd.Parameters.AddWithValue("@Fatih", dataGridView1.Rows[i].Cells[1].Value.ToString());

                    cmd.ExecuteNonQuery();

                    baglan.Close();

                }
            }
        
            MessageBox.Show("Puan hesaplama işlemi tamamlanmıştır");

        }






        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form16 f6 = new Form16();
            f6.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox5.Text.Trim() == "") errorProvider1.SetError(textBox5, "Boş Geçilemez");
            if (textBox1.Text.Trim() == "") errorProvider1.SetError(textBox1, "Boş Geçilemez");
            if (textBox2.Text.Trim() == "") errorProvider1.SetError(textBox2, "Boş Geçilemez");
            if (textBox3.Text.Trim() == "") errorProvider1.SetError(textBox3, "Boş Geçilemez");
            if (textBox4.Text.Trim() == "") errorProvider1.SetError(textBox4, "Boş Geçilemez");
            if (textBox9.Text.Trim() == "") errorProvider1.SetError(textBox9, "Boş Geçilemez");
            if (textBox7.Text.Trim() == "") errorProvider1.SetError(textBox8, "Boş Geçilemez");
            if (textBox7.Text.Trim() == "") errorProvider1.SetError(textBox7, "Boş Geçilemez");
            if (textBox6.Text.Trim() == "") errorProvider1.SetError(textBox6, "Boş Geçilemez");

            else
            {
                SqlConnection baglan = new SqlConnection(bgl.Adres);
                baglan.Open();
                SqlCommand komut1 = new SqlCommand();
                komut1.Connection = baglan;
                komut1.CommandText = "INSERT INTO SatıcıBilgi(Ad_Soyad,Aylık_Ciro,Yıllık_Ciro,AylıkHedefYüzdesi,YıllıkHedefYüzdesi,aylık_hedef,yıllık_hedef,Stok_Adedi,ÖzelPuanlıStokAdedi)values('" + textBox5.Text + "'," + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text + "," + textBox9.Text + "," + textBox8.Text + "," + textBox7.Text + "," + textBox6.Text + ")";
                komut1.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Eleman kayıt altına alındı", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sayac();
                listele();

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Lütfen Listeden Bir Kayıt Seçin", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection baglan = new SqlConnection(bgl.Adres);
                baglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglan;
                cmd.CommandText = "UPDATE SatıcıBilgi Set Ad_Soyad ='" + textBox5 + "',Aylık_Ciro ='" + textBox1 + "',Yıllık_Ciro ='" + textBox2 + "',Stok_Satış ='" + textBox3 + "',Stok_Hakkı ='" + textBox4 + "' where  Kimlik=@NUMARA";
                cmd.Parameters.AddWithValue("@NUMARA", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Eleman Güncelleme İşlemi Tamamlandı", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Lütfen Listeden Bir Kayıt Seçin", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Eleman silinsin mi?", "SİSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    SqlConnection baglan = new SqlConnection(bgl.Adres);
                    baglan.Open();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = baglan;
                    cmd2.CommandText = "DELETE FROM SatıcıBilgi WHERE Kimlik = @NUMARA";
                    cmd2.Parameters.AddWithValue("@NUMARA", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd2.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Veri Silindi");

                }
            }
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
  
            SqlDataAdapter adtr = new SqlDataAdapter("select * from satıcıBilgi", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();

            baglan.Close();
            sayac();


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form25 f6 = new Form25();
            f6.Show();
            this.Hide();

        }

       
    }
}
