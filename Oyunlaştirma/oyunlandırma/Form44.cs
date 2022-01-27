using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyunlandırma
{
    public partial class Form44 : Form
    {
        public Form44()
        {
            InitializeComponent();
        }
        Timer t = new Timer();
        Random Rast = new Random();
        BaglantiSinif bgl = new BaglantiSinif();

        DataTable dt = new DataTable();
        private void Form44_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'oyunlaştırmaDataSet.Kullanıcılar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanıcılarTableAdapter.Fill(this.oyunlaştırmaDataSet.Kullanıcılar);

        }

        private void OnTimerTicked(object sender, EventArgs e)
        {
         
         

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select Ad_Soyad from SatıcıBilgi", baglan);
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                dataGridView1.DataSource = dt;


             
                for (int i = 0; i < 6; i++)
                {
                    string a = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    comboBox1.Items.Add("a");
                    
            }
                
            }
            okuyucu.Close();
            baglan.Close();
            baglan.Close();

        }
    }
}
