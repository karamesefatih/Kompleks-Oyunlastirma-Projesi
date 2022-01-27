using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyunlandırma
{
    public partial class Form48 : Form
    {
        int a,c,f,g,q;
        string b, d;
        public Form48()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        DataTable tablo = new DataTable();
        private void Form48_Load(object sender, EventArgs e)
        {
           

            SqlConnection baglan = new SqlConnection(bgl.Adres);


            baglan.Open();
            SqlCommand kom2 = new SqlCommand("print cast (getdate() as date)");
            kom2.Connection = baglan;
            SqlDataReader dr2 = kom2.ExecuteReader();
            while (dr2.Read())
            {
                a = dr2[0].GetHashCode();


            }
            dr2.Close();
            baglan.Close();
            


            baglan.Open();
            string Select = "SELECT * FROM İddialı_Stok_Satış where Satıcı = '" + label2.Text + "' or Satıcı ='Herkes' ";
            SqlDataAdapter da = new SqlDataAdapter(Select, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();

            baglan.Open();
            SqlCommand komut24 = new SqlCommand();
            komut24.Connection = baglan;
            komut24.CommandText = " delete from İddialı_Stok_Satış where İddia_Süreci < "+a+"     ";
            komut24.ExecuteNonQuery();
            baglan.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand kom6 = new SqlCommand("select kimlik,ürün_kodu from İddialı_Stok_Satış  where  Kimlik=@NUMARA");
            kom6.Parameters.AddWithValue("@NUMARA", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            kom6.Connection = baglan;
            SqlDataReader dr6 = kom6.ExecuteReader();
            while (dr6.Read())
            {
                b = dr6[1].ToString();


            }
            dr6.Close();
        
            
            SqlCommand kom9 = new SqlCommand("select kimlik,kazanc from İddialı_Stok_Satış  where  Kimlik=@NUMARA");
            kom9.Parameters.AddWithValue("@NUMARA", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            kom9.Connection = baglan;
            SqlDataReader dr9 = kom9.ExecuteReader();
            while (dr9.Read())
            {
                f = dr9[1].GetHashCode();


            }
            dr9.Close();

            baglan.Close();

            baglan.Open();
            SqlCommand komut24 = new SqlCommand();
            komut24.Connection = baglan;
            komut24.CommandText = " insert into İddalı_Stok_Satış_kontrol (Ürün_kodu,Satıcı,İddia_Süreci,Kazanc)VALUES('"+b+"','"+label2.Text+"',getdate(),"+ f +")   ";
            komut24.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Yöneticiye iletildi");
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
