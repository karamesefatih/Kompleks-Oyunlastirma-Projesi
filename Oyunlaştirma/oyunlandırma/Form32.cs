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
    public partial class Form32 : Form
    {
        public Form32()
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
           
            baglan.Close();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from ElemanQuiz", baglan);
            adtr.Fill(tablo);
   
            adtr.Dispose();
            baglan.Close();

        }









        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f6 = new Form3();
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
            if (textBox5.Text.Trim() == "") errorProvider1.SetError(richTextBox1, "Boş Geçilemez");
        
            else
            {

                SqlConnection baglan = new SqlConnection(bgl.Adres);
                baglan.Open();
                SqlCommand komut1 = new SqlCommand();
                komut1.Connection = baglan;
                komut1.CommandText = "INSERT INTO ElemanQuiz(SORU,A,B,C,D,DOĞRUSU)VALUES('" + richTextBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                komut1.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("soru kayıt altına alındı", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                listele();
            
            }
        }

        private void Form32_Load(object sender, EventArgs e)
        {
         

        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
