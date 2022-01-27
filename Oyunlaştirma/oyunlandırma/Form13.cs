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
    public partial class Form13 : Form
    {
        int d,a,q;
        string v;
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        private void Form13_Load(object sender, EventArgs e)
            
        {
            comboBox2.Items.Add("Hepsi");
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            DataTable tablo = new DataTable();
            baglan.Open();
         
            SqlDataAdapter adtr = new SqlDataAdapter("select * from ödül_bilgileri order by puan", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();

            baglan.Close();
  
            baglan.Open();

            SqlCommand komut6 = new SqlCommand(" select sum(puan) from puanlar where ad_soyad = '" + label2.Text + "' ", baglan);

            SqlDataReader okuyucu6 = komut6.ExecuteReader();

            while (okuyucu6.Read())
            {
                label5.Text = okuyucu6[0].ToString();



            }
            okuyucu6.Close();
            baglan.Close();
            SqlConnection baglan3 = new SqlConnection(bgl.Adres);
            baglan3.Open();
            SqlCommand komut5 = new SqlCommand("SELECT Kategori FROM ödül_bilgileri GROUP BY Kategori ", baglan3);

            SqlDataReader okuyucu5 = komut5.ExecuteReader();

            while (okuyucu5.Read())
            {
                comboBox2.Items.Add(okuyucu5["kategori"]);



            }
            okuyucu5.Close();
            baglan3.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglan4 = new SqlConnection(bgl.Adres);
            baglan4.Open();
            SqlCommand komut6 = new SqlCommand(" select sum(puan) from puanlar where ad_soyad = '" + label2.Text + "' ", baglan4);

            SqlDataReader okuyucu6 = komut6.ExecuteReader();

            while (okuyucu6.Read())
            {
                q = okuyucu6[0].GetHashCode();



            }
            okuyucu6.Close();
            baglan4.Close();
            SqlConnection baglan3 = new SqlConnection(bgl.Adres);
            baglan3.Open();
            SqlCommand komut5 = new SqlCommand(" select Puan from Ödül_Bilgileri WHERE Ödül = '" + textBox1.Text + "' ", baglan3);

            SqlDataReader okuyucu5 = komut5.ExecuteReader();

            while (okuyucu5.Read())
            {
                d = okuyucu5[0].GetHashCode();
                a = -d;
                label3.Text = okuyucu5[0].ToString();


            }
            okuyucu5.Close();
            baglan3.Close();
            if (q > d)
            {


                SqlConnection baglan = new SqlConnection(bgl.Adres);
                baglan.Open();
                SqlCommand komut1 = new SqlCommand();
                komut1.Connection = baglan;
                komut1.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('" + label2.Text + "'," + a + ",'Ödül " + textBox1.Text + "',GETDATE() )";
                komut1.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("hattınıza yükleme yapılmıştır");


        
                baglan.Open();
                SqlCommand komut1e = new SqlCommand();
                komut1e.Connection = baglan;
                komut1e.CommandText = "Insert Into Ödül(Ad_Soyad,ödül)Values('" + label2.Text + "',1 )";
                komut1e.ExecuteNonQuery();
                baglan.Close();
            
            }
          
            else 
            {
                MessageBox.Show("YETERLİ PUANINIZ YOKTUR");
            }


            if(q == 0)
            {
                MessageBox.Show("YETERLİ PUANINIZ YOKTUR");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
     

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {

                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {

                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            DataTable tablo = new DataTable();
            baglan.Open();
            if (comboBox2.Text == "Hepsi")
            {
                SqlDataAdapter adtr = new SqlDataAdapter("select * from ödül_bilgileri ", baglan);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                adtr.Dispose();

                baglan.Close();
            }
            else
            {
                SqlDataAdapter adtr = new SqlDataAdapter("select * from ödül_bilgileri where kategori = '" + comboBox2.Text + "' ", baglan);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                adtr.Dispose();

                baglan.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
      
        }

        private void button4_Click(object sender, EventArgs e)
        {
    

        }

        
    }
}
