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
    public partial class Form20 : Form
    {
        public Form20()
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
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            baglan.Close();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Satış_Bilgileri", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            baglan.Close();

        }


        void sayac()
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand komut = new SqlCommand("select count(*) from Satış_Bilgileri", baglan);
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
            if (textBox1.Text.Trim() == "") errorProvider1.SetError(textBox1, "Boş Geçilemez");
            if (textBox2.Text.Trim() == "") errorProvider1.SetError(textBox2, "Boş Geçilemez");
            if (textBox3.Text.Trim() == "") errorProvider1.SetError(textBox3, "Boş Geçilemez");
            if (textBox4.Text.Trim() == "") errorProvider1.SetError(textBox4, "Boş Geçilemez");
            if (textBox5.Text.Trim() == "") errorProvider1.SetError(textBox5, "Boş Geçilemez");
            if (textBox6.Text.Trim() == "") errorProvider1.SetError(textBox6, "Boş Geçilemez");
            if (textBox7.Text.Trim() == "") errorProvider1.SetError(textBox7, "Boş Geçilemez");
            if (textBox8.Text.Trim() == "") errorProvider1.SetError(textBox7, "Boş Geçilemez");
            else
            {
                SqlConnection baglan = new SqlConnection(bgl.Adres);
                baglan.Open();
                SqlCommand komut1 = new SqlCommand();
                komut1.Connection = baglan;
                komut1.CommandText = "insert into Satış_Bilgileri(Ad_Soyad, Ürün_kodu, ürün_tipi, satış_tipi, stoktan_mı, fiyat, adet, Tarih)values('" + richTextBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'," + textBox5.Text + "," + textBox6.Text + ",'" + textBox7.Text + "')";
                komut1.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Veri kayıt altına alındı", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sayac();
                listele();
            
            }
        }

        private void Form20_Load(object sender, EventArgs e)
        {
        
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
       
            SqlDataAdapter adtr = new SqlDataAdapter("select * from satış_bilgileri", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();

            baglan.Close();
            sayac();
            sayac();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Lütfen Listeden Bir Kayıt Seçin", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(MessageBox.Show("Veri silinsin mi?", "SİSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)==DialogResult.Yes)
                    {
                    SqlConnection baglan = new SqlConnection(bgl.Adres);
                    baglan.Open();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = baglan;
                    cmd2.CommandText = "DELETE FROM Satış_Bilgileri WHERE Kimlik = @NUMARA";
                    cmd2.Parameters.AddWithValue("@NUMARA", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd2.ExecuteNonQuery();
                    baglan.Close();
                    sayac();
                    listele();
                    MessageBox.Show("Veri Silindi");

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
            textBox2.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form27 f6 = new Form27();
            f6.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = baglan;
            cmd2.CommandText = "DELETE FROM Satış_Bilgileri ";
      
            cmd2.ExecuteNonQuery();
            baglan.Close();
            sayac();
            listele();
            MessageBox.Show("Tüm Veriler Silindi");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
