using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace oyunlandırma
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        DataTable tablo = new DataTable();

        void listele()
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            richTextBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = ""; 
            textBox3.Text = "";
 
            baglan.Close();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Stok_Hakkı", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            baglan.Close();

        }


        void sayac()
        {

            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand komut = new SqlCommand("select count(*) from Stok_Hakkı", baglan);
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                label10.Text = okuyucu[0].ToString();
            }
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
            if (richTextBox1.Text.Trim() == "") errorProvider1.SetError(richTextBox1, "Boş Geçilemez");
            if (textBox1.Text.Trim() == "") errorProvider1.SetError(richTextBox1, "Boş Geçilemez");
            if (textBox2.Text.Trim() == "") errorProvider1.SetError(richTextBox1, "Boş Geçilemez");
            if (textBox3.Text.Trim() == "") errorProvider1.SetError(richTextBox1, "Boş Geçilemez");

            else
            {

                SqlConnection baglan = new SqlConnection(bgl.Adres);
                baglan.Open();
                SqlCommand komut1 = new SqlCommand();
                komut1.Connection = baglan;
                komut1.CommandText = "INSERT INTO Stok_Hakkı(Ad_Soyad,Stok_Hakkı_Kodu,Başlama_Tarihi,Bitiş_Tarihi)VALUES('" + richTextBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                komut1.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Veri kayıt altına alındı", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sayac();
                listele();
            
            }
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'oyunlaştırmaDataSet.Stok_Hakkı' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           
            // TODO: Bu kod satırı 'oyunlaştırmaDataSet.Puanlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
       
            SqlDataAdapter adtr = new SqlDataAdapter("select * from stok_hakkı", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();

            baglan.Close();
            sayac();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text == "")
            {
                MessageBox.Show("Lütfen Listeden Bir Kayıt Seçin", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                SqlConnection baglan = new SqlConnection(bgl.Adres);
                baglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglan;
                cmd.CommandText = "UPDATE Stok_Hakkı Set Ad_Soyad ='" + richTextBox1 + "',Stok_Hakkı_Kodu ='" + textBox1 + "',Başlama_Tarihi ='" + textBox2 + "',Bitiş_Tarihi ='" + textBox3 + "' where  Kimlik=@NUMARA";
                cmd.Parameters.AddWithValue("@NUMARA", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Veri Güncelleme İşlemi Tamamlandı", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Lütfen Listeden Bir Kayıt Seçin", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(MessageBox.Show("Soru silinsin mi?", "SİSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)==DialogResult.Yes)
                    {

                    SqlConnection baglan = new SqlConnection(bgl.Adres);
                    baglan.Open();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = baglan;
                    cmd2.CommandText = "DELETE FROM Stok_Hakkı WHERE Kimlik = @NUMARA";
                    cmd2.Parameters.AddWithValue("@NUMARA", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd2.ExecuteNonQuery();
                    baglan.Close();


                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

      
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form28 f6 = new Form28();
            f6.Show();
            this.Hide();
        }
    }
}
