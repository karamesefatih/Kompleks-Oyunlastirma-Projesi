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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        DataTable tablo = new DataTable();
        int n, m, l;
        void listele()
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            richTextBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = ""; 
          
            baglan.Close();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Kullanıcılar", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            baglan.Close();

        }


        void sayac()
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand komut = new SqlCommand("select count(*) from Kullanıcılar", baglan);
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
   
            else
            {
                SqlConnection baglan = new SqlConnection(bgl.Adres);
                baglan.Open();
                SqlCommand komut1 = new SqlCommand();
                komut1.Connection = baglan;
                komut1.CommandText = "INSERT INTO Kullanıcılar(Ad_Soyad,Şifre,Rütbe)VALUES('" + richTextBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')";
                komut1.ExecuteNonQuery();
                komut1.Connection = baglan;

    
                SqlCommand kom42 = new SqlCommand("SELECT MONTH(getdate()) AS Month;");
                kom42.Connection = baglan;
                SqlDataReader dr42 = kom42.ExecuteReader();
                while (dr42.Read())
                {
                    n = dr42[0].GetHashCode() - 1;
                   

                }
                dr42.Close();
               
                SqlCommand komut14 = new SqlCommand();
                komut14.Connection = baglan;
                komut14.CommandText = "Insert Into ay3(ay2,Ad_Soyad)Values(" + n + ",'" + richTextBox1.Text + "' )";
                komut14.ExecuteNonQuery();
                SqlCommand komut14y = new SqlCommand();
                komut14y.Connection = baglan;
                komut14y.CommandText = "Insert Into ay2(ay2,Ad_Soyad)Values(" + n + ",'" + richTextBox1.Text + "' )";
                komut14y.ExecuteNonQuery();
                SqlCommand komut14z = new SqlCommand();
                komut14z.Connection = baglan;
                komut14z.CommandText = "Insert Into ay(ay2,Ad_Soyad)Values(" + n + ",'" + richTextBox1.Text + "' )";
                komut14z.ExecuteNonQuery();
                SqlCommand komut14q = new SqlCommand();
                komut14q.Connection = baglan;
                komut14q.CommandText = "Insert Into ay4(ay2,Ad_Soyad)Values(" + n + ",'" + richTextBox1.Text + "' )";
                komut14q.ExecuteNonQuery();
                SqlCommand komut141q = new SqlCommand();
                komut141q.Connection = baglan;
                komut141q.CommandText = "Insert Into ay4(ay2,Ad_Soyad)Values(" + n + ",'" + richTextBox1.Text + "' )";
                komut141q.ExecuteNonQuery();
                SqlCommand komut141 = new SqlCommand();
                komut141.Connection = baglan;
                komut141.CommandText = "insert into puanlar(Ad_soyad,Kategori,puan,tarih)values('"+richTextBox1.Text+"','HOŞGELDİN SATICI ROZETİ',100,getdate())";
                komut141.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Veri kayıt altına alındı", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sayac();
                listele();
            
            }
        }

        private void Form24_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
         
            SqlDataAdapter adtr = new SqlDataAdapter("select kimlik,Ad_soyad,Rütbe from kullanıcılar", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();

            baglan.Close();
            sayac();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Lütfen Listeden Bir Kayıt Seçin", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection baglan = new SqlConnection(bgl.Adres);
                baglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglan;
                cmd.CommandText = "UPDATE Kullanıcılar Set Ad_Soyad ='" + richTextBox1.Text + "',Şifre ='" + textBox1.Text + "',Rütbe ='" + textBox2.Text + "' where  Kimlik=@NUMARA";
                cmd.Parameters.AddWithValue("@NUMARA", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Soru Güncelleme İşlemi Tamamlandı", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                if(MessageBox.Show("Kullanıcı silinsin mi?", "SİSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)==DialogResult.Yes)
                    {
                    SqlConnection baglan = new SqlConnection(bgl.Adres);
                    baglan.Open();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = baglan;
                    cmd2.CommandText = "DELETE FROM Kullanıcılar WHERE Kimlik = @NUMARA";
                    cmd2.Parameters.AddWithValue("@NUMARA", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd2.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Veri Silme İşlemi Tamamlandı", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);



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
         
      
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form31 f6 = new Form31();
            f6.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglan;
            cmd.CommandText = "UPDATE Kullanıcılar Set Şifre = '' where Kimlik=@NUMARA";
            cmd.Parameters.AddWithValue("@NUMARA", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Şifre Reset İşlemi Tamamladı", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button7_Click(object sender, EventArgs e)
        {


            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = baglan;
            cmd2.CommandText = "DELETE FROM Kullanıcılar ";
         
            cmd2.ExecuteNonQuery();
            baglan.Close();
            

            MessageBox.Show("Tüm Veriler Silndi", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
