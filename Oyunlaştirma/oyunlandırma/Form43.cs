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
    public partial class Form43 : Form
    {
        public Form43()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        public static int a, b;
        private void button1_Click(object sender, EventArgs e)
        {


            Form44 f43 = new Form44();
            f43.Show();
            this.Hide();
        }







        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form43_Load(object sender, EventArgs e)
        {
            sayac();
        }
        void sayac()
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand kom4 = new SqlCommand("   SELECT MONTH(getdate()) AS Month; ");
            kom4.Connection = baglan;
            SqlDataReader dr2 = kom4.ExecuteReader();
            while (dr2.Read())
            {

                a = dr2[0].GetHashCode();

            }
            baglan.Close();
            baglan.Open();
            SqlCommand kom3 = new SqlCommand("   select top 1 ay2 from ay3 where Ad_Soyad ='" + label1.Text + "' order by kimlik desc");
            kom3.Connection = baglan;
            SqlDataReader dr3 = kom3.ExecuteReader();
            while (dr3.Read())
            {

                b = dr3[0].GetHashCode();

            }
            dr3.Close();
            baglan.Close();

            if (pictureBox1.Visible = true && a == 1 && b == 12)
            {
                baglan.Open();
                SqlCommand komut14 = new SqlCommand();
                komut14.Connection = baglan;
                komut14.CommandText = "Insert Into ay3(ay2,Ad_Soyad)Values(" + a + ",'" + label1.Text + "' )";
                komut14.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut24 = new SqlCommand();
                komut24.Connection = baglan;
                komut24.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay3 where ad_soyad ='" + label1.Text + "' if (@ali > 3) begin       DELETE FROM Ay3 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay3  where Ad_Soyad = '" + label1.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut24.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut25 = new SqlCommand();
                komut25.Connection = baglan;
                komut25.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('fatih',1000 ,'Y ROZET ÖDÜLÜ',GETDATE() )";
                komut25.ExecuteNonQuery();
                baglan.Close();

            }



            if (pictureBox1.Visible = true && b < a)
            {



                baglan.Open();
                SqlCommand komut1 = new SqlCommand();
                komut1.Connection = baglan;
                komut1.CommandText = "Insert Into ay3(ay2,Ad_Soyad)Values(" + a + ",'" + label1.Text + "' )";
                komut1.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut2 = new SqlCommand();
                komut2.Connection = baglan;
                komut2.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay3 where ad_soyad = '" + label1.Text + "' if (@ali > 3) begin       DELETE FROM Ay3 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay3 where ad_soyad = '" + label1.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut2.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut25 = new SqlCommand();
                komut25.Connection = baglan;
                komut25.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('fatih',1000 ,'Y ROZET ÖDÜLÜ',GETDATE() )";
                komut25.ExecuteNonQuery();
                baglan.Close();

            }


            else
            {

                
            }
        }
    }
}
