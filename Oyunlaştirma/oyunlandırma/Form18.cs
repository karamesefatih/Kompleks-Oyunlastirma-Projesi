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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        DataTable tablo = new DataTable();
        SqlDataAdapter adtr;
        

        void listele()
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            richTextBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = ""; 
            textBox3.Text = "";
            textBox4.Text = "";

            baglan.Close();
            
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Geçmiş_Satışlar", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            baglan.Close();

        }

        public void arama( string search)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
          
            string q = "select * from geçmiş_satışlar where Ad_Soyad like '%"+search+"%'";
            adtr = new SqlDataAdapter(q, baglan);
            tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        
            baglan.Close();
        }

        void sayac()
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand komut = new SqlCommand("select count(*) from Geçmiş_Satışlar", baglan);
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                label10.Text = okuyucu[0].ToString();
            }
        }


        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            arama(textBox5.Text);
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
            if (textBox4.Text.Trim() == "") errorProvider1.SetError(richTextBox1, "Boş Geçilemez");
   
            else
            {
                SqlConnection baglan = new SqlConnection(bgl.Adres);
                baglan.Open();
                SqlCommand komut1 = new SqlCommand();
                komut1.Connection = baglan;
                komut1.CommandText = "INSERT INTO Geçmiş_Satışlar(Ad_Soyad,ay_yıl,Satış_Adedi,Stok_adedi,Satış_Cirosu)VALUES('" + richTextBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                komut1.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("soru kayıt altına alındı", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sayac();
                listele();
            
            }
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'oyunlaştırmaDataSet.Geçmiş_Satışlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.


            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
      
            SqlDataAdapter adtr = new SqlDataAdapter("select * from geçmiş_satışlar ", baglan);
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
                cmd.CommandText = "UPDATE Geçmiş_Satışlar Set Ad_Soyad ='" + richTextBox1.Text + "',ay_yıl ='" + textBox1.Text + "',Satış_Adedi =" + textBox2.Text + ",Stok_Adedi =" + textBox3.Text + ",Satış_Cirosu =" + textBox4.Text + " where  Kimlik=@NUMARA";
                cmd.Parameters.AddWithValue("@NUMARA", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Güncelleme İşlemi Tamamlandı", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sayac();
                listele();

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
                if(MessageBox.Show("Kayıt silinsin mi?", "SİSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)==DialogResult.Yes)
                    {
                    SqlConnection baglan = new SqlConnection(bgl.Adres);
                    baglan.Open();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = baglan;
                    cmd2.CommandText = "DELETE FROM Geçmiş_Satışlar WHERE Kimlik = @NUMARA";
                    cmd2.Parameters.AddWithValue("@NUMARA", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd2.ExecuteNonQuery();
                    baglan.Close();
                    sayac();
                    listele();

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
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

      
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form26 f6 = new Form26();
            f6.Show();
            this.Hide();
        }

       
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            arama(textBox5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = baglan;
            cmd2.CommandText = "DELETE FROM Geçmiş_Satışlar";
            cmd2.ExecuteNonQuery();
            baglan.Close();
        }
    }
}
