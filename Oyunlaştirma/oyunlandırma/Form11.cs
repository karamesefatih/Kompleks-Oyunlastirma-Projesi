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
    public partial class Form11 : Form
    {
        public Form11()
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

        private void Form11_Load(object sender, EventArgs e)
        {
            
           /* SqlConnection baglan = new SqlConnection(bgl.Adres);
            DataTable tablo = new DataTable();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT top 5 ad_soyad,Aylık_Ciro FROM SatıcıBilgi order by Aylık_Ciro desc", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
         

            SqlDataAdapter adtr1 = new SqlDataAdapter("SELECT top 5 ad_soyad,stok_adedi FROM SatıcıBilgi order by stok_adedi desc", baglan);
            adtr1.Fill(tablo);
            dataGridView2.DataSource = tablo;
            adtr1.Dispose();

            SqlDataAdapter adtr2 = new SqlDataAdapter("   SELECT top 5 ad_soyad,aylıkhedefyüzdesi FROM SatıcıBilgi order by AylıkHedefYüzdesi desc", baglan);
            adtr2.Fill(tablo);
            dataGridView3.DataSource = tablo;
            adtr2.Dispose();

            baglan.Close();*/





             SqlConnection baglan = new SqlConnection(bgl.Adres);
             baglan.Open();
             SqlCommand komut = new SqlCommand("SELECT top 5 ad_soyad,Aylık_Ciro FROM SatıcıBilgi order by Aylık_Ciro desc ", baglan);
             SqlDataReader read = komut.ExecuteReader();
             while (read.Read())
             {
                 listBox1.Items.Add(read[0] +   "  \n "  + "  "   );
                listBox1.Items.Add("\n" +" --------------------------------------------------------- ");
                listBox2.Items.Add(read[1] + "  \n ");
                listBox2.Items.Add("\n" + "---------------------------------------------------------");

            }
             baglan.Close();
             baglan.Open();
             SqlCommand komut2 = new SqlCommand("SELECT top 5 ad_soyad,stok_adedi FROM SatıcıBilgi order by stok_adedi desc", baglan);
             SqlDataReader read2 = komut2.ExecuteReader();
             while (read2.Read())
             {
                 listBox3.Items.Add(read2[0] + "  \n ");
                listBox3.Items.Add("\n" + "---------------------------------------------------------");
                listBox4.Items.Add(read2[1] + "  \n ");
                listBox4.Items.Add("\n" + "---------------------------------------------------------");


            }
             baglan.Close();
             baglan.Open();
             SqlCommand komut22 = new SqlCommand("SELECT top 5 ad_soyad, aylıkhedefyüzdesi FROM SatıcıBilgi order by AylıkHedefYüzdesi desc ", baglan);
             SqlDataReader read22 = komut22.ExecuteReader();
             while (read22.Read())
             {
                 listBox5.Items.Add(read22[0] + "  \n ");
                listBox5.Items.Add("\n" +" ---------------------------------------------------------");
                listBox6.Items.Add(read22[1] + "  \n ");
                listBox6.Items.Add("\n" +" ---------------------------------------------------------");


            }
             baglan.Close();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.satıcıBilgiTableAdapter.FillBy(this.oyunlaştırmaDataSet1.SatıcıBilgi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
