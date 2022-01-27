using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyunlandırma
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();
        DataTable tablo = new DataTable();
       public static int a;
        void sayac()
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from soru where Zorluk = 'kolay'", baglan);
            SqlDataReader okuyucu1 = cmd.ExecuteReader();
            while (okuyucu1.Read())
            {
                label9.Text = okuyucu1[0].ToString();

            }
            baglan.Close();

        }













        int sayı;
        int sayi;
        int dogru = 0;
        int yanlıs = 0;
        public static int puan = 0;
        public static string b;
        int süre1 = 15;

        private void button7_Click(object sender, EventArgs e)
        {

            label15.Text = süre1.ToString();
            timer1.Enabled = true;


            renk();
            sayı = sayı + 1;
            sayi = sayi + 1;
            label4.Text = sayı.ToString();
            label13.Text = sayi.ToString();
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT  top 1 * FROM soru where ZORLUK ='kolay' ORDER BY NEWID() ", baglan);
            SqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                textBox1.Text = (okuyucu["SORU"].ToString());
                button2.Text = (okuyucu["A"].ToString());
                button3.Text = (okuyucu["B"].ToString());
                button4.Text = (okuyucu["C"].ToString());
                button5.Text = (okuyucu["D"].ToString());
                label5.Text = (okuyucu["DOGRU"].ToString());
                label8.Text = (okuyucu["KONUSU"].ToString());
            }
            baglan.Close();
            button7.Text = "sonraki soru";

            if (label4.Text == "4")
            {
                if (label11.Text == "3")
                {
                    Form61 f10 = new Form61();
                    f10.Show();
                    this.Hide();
                    timer1.Stop();
                }
                else
                {
                    Form49 f45 = new Form49();
                    f45.label1.Text = label2.Text;
                    f45.label2.Text = label10.Text;
                    f45.label3.Text = label11.Text;
                    timer1.Stop();
                    f45.Show();
                    this.Hide();

                }
            }



        }

        void renk()
        {
            button2.BackColor = Color.Gainsboro;
            button3.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Gainsboro;



        }

        private void Form4_Load(object sender, EventArgs e)
        {
          
            sayac();
            puan = a;
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button2.Enabled = false;

            if (label5.Text == button2.Text)
            {
                dogru++;
                label2.Text = dogru.ToString();

                button2.BackColor = Color.Lime;
                puan = puan + 1;
                label11.Text = puan.ToString();
            }
            else
            {
                yanlıs++;
                label10.Text = yanlıs.ToString();
                button2.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button3.Enabled = false;
            if (label5.Text == button3.Text)
            {
                dogru++;
                label2.Text = dogru.ToString();
                button3.BackColor = Color.Lime;
                puan = puan + 1;
                label11.Text = puan.ToString();

            }
            else
            {
                yanlıs++;
                label10.Text = yanlıs.ToString();
                button3.BackColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button4.Enabled = false;
            if (label5.Text == button4.Text)
            {
                dogru++;
                label2.Text = dogru.ToString();
                button4.BackColor = Color.Lime;
                puan = puan + 1;
                label11.Text = puan.ToString();
            }
            else
            {
                yanlıs++;
                label10.Text = yanlıs.ToString();
                button4.BackColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            if (label5.Text == button5.Text)
            {
                dogru++;
                label2.Text = dogru.ToString();
                button5.BackColor = Color.Lime;
                puan = puan + 1;
                label11.Text = puan.ToString();
            }
            else
            {
                yanlıs++;
                label10.Text = yanlıs.ToString();
                button5.BackColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre1 = (int)Convert.ToInt32(label15.Text);
            süre1--;
            label15.Text = süre1.ToString();



            if (süre1 == 0)

            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button4.Enabled = false;
                timer1.Enabled = false;

                Form49 f45 = new Form49();
                f45.label1.Text = label2.Text;
                f45.label2.Text = label10.Text;
                f45.label3.Text = label11.Text;
                timer1.Stop();
                f45.Show();
                this.Hide();



                label15.Text = süre1.ToString();
                timer1.Enabled = true;


                renk();
                sayı = sayı + 1;
                sayi = sayi + 1;
                label4.Text = sayı.ToString();
                label13.Text = sayi.ToString();
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                SqlConnection baglan = new SqlConnection(bgl.Adres);
                baglan.Open();
                SqlCommand komut = new SqlCommand("SELECT  top 1 * FROM soru where ZORLUK ='kolay' ORDER BY NEWID() ", baglan);
                SqlDataReader okuyucu = komut.ExecuteReader();

                while (okuyucu.Read())
                {
                    textBox1.Text = (okuyucu["SORU"].ToString());
                    button2.Text = (okuyucu["A"].ToString());
                    button3.Text = (okuyucu["B"].ToString());
                    button4.Text = (okuyucu["C"].ToString());
                    button5.Text = (okuyucu["D"].ToString());
                    label5.Text = (okuyucu["DOGRU"].ToString());
                    label8.Text = (okuyucu["KONUSU"].ToString());
                }
                baglan.Close();
                button7.Text = "sonraki soru";

                if (label4.Text == "4")
                {
                 
                    if (label2.Text == "3")
                    {
                        Form61 f10 = new Form61();
                        f10.Show();
                        this.Hide();
                    }
                    Form49 f46 = new Form49();
                    f46.label1.Text = label2.Text;
                    f46.label2.Text = label10.Text;
                    f46.label3.Text = label11.Text;
                    timer1.Stop();
                    f46.Show();
                    this.Hide();
                    button7.Text = "Başla";
                    süre1 = 15;
                    sayı = 0;
                    timer1.Stop();



                }
                if (sayı == 4)
                {

                    
                }
                if (sayı == 1)
                {
                    

                }
                if (label13.Text == label9.Text)
                {
                    sayi = 0;

                }

               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}