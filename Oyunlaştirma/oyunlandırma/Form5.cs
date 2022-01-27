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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        BaglantiSinif bgl = new BaglantiSinif();
        public static int a, b,c,d,e,f,g,h;

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayac4();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            sayac();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayac2();
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

                a = dr2[0].GetHashCode()  ;

            }
            baglan.Close();
            baglan.Open();
            SqlCommand kom3 = new SqlCommand("   select top 1 ay2 from ay where Ad_Soyad ='" + label1.Text + "' order by kimlik desc");
            kom3.Connection = baglan;
            SqlDataReader dr3 = kom3.ExecuteReader();
            while (dr3.Read())
            {

                b = dr3[0].GetHashCode();

            }
            dr3.Close();
            baglan.Close();

            if (a == 1 && b == 12)
            {
                baglan.Open();
                SqlCommand komut14 = new SqlCommand();
                komut14.Connection = baglan;
                komut14.CommandText = "Insert Into ay(ay2,Ad_Soyad)Values(" + a + ",'" + label1.Text + "' )";
                komut14.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut24 = new SqlCommand();
                komut24.Connection = baglan;
                komut24.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay where ad_soyad ='" + label1.Text + "' if (@ali > 3) begin       DELETE FROM Ay WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay  where Ad_Soyad = '" + label1.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut24.ExecuteNonQuery();
                baglan.Close();
                Form4 f45 = new Form4();
                f45.Show();
                this.Hide();


            }



            if (b < a)
            {



                baglan.Open();
                SqlCommand komut1 = new SqlCommand();
                komut1.Connection = baglan;
                komut1.CommandText = "Insert Into ay(ay2,Ad_Soyad)Values(" + a + ",'" + label1.Text + "' )";
                komut1.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut2 = new SqlCommand();
                komut2.Connection = baglan;
                komut2.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay where ad_soyad = '" + label1.Text + "' if (@ali > 3) begin       DELETE FROM Ay WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay where ad_soyad = '" + label1.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut2.ExecuteNonQuery();
                baglan.Close();


                Form4 f44 = new Form4();
                f44.Show();
                this.Hide();

            }


            else if (b == a)
            {

                MessageBox.Show("Kolay Aylık Quiz Hakkını Doldurdunuz");

            }
            else if (b > a)
            {
                MessageBox.Show("Kolay Aylık Quiz Hakkını Doldurdunuz");
            }


        }
        void sayac4()
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand kom4 = new SqlCommand("   SELECT MONTH(getdate()) AS Month; ");
            kom4.Connection = baglan;
            SqlDataReader dr2 = kom4.ExecuteReader();
            while (dr2.Read())
            {

                g = dr2[0].GetHashCode();

            }
            baglan.Close();
            baglan.Open();
            SqlCommand kom3 = new SqlCommand("   select top 1 ay2 from ay2 where Ad_Soyad ='" + label1.Text + "' order by kimlik desc");
            kom3.Connection = baglan;
            SqlDataReader dr3 = kom3.ExecuteReader();
            while (dr3.Read())
            {

                h = dr3[0].GetHashCode();

            }
            dr3.Close();
            baglan.Close();

            if (g == 1 && h == 12)
            {
                baglan.Open();
                SqlCommand komut14 = new SqlCommand();
                komut14.Connection = baglan;
                komut14.CommandText = "Insert Into ay2(ay2,Ad_Soyad)Values(" + g + ",'" + label1.Text + "' )";
                komut14.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut24 = new SqlCommand();
                komut24.Connection = baglan;
                komut24.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay2 where ad_soyad ='" + label1.Text + "' if (@ali > 3) begin       DELETE FROM Ay2 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay2  where Ad_Soyad = '" + label1.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut24.ExecuteNonQuery();
                baglan.Close();
                Form7 f45 = new Form7();
                f45.Show();
                this.Hide();


            }



            if (h < g)
            {



                baglan.Open();
                SqlCommand komut1 = new SqlCommand();
                komut1.Connection = baglan;
                komut1.CommandText = "Insert Into ay2(ay2,Ad_Soyad)Values(" + g + ",'" + label1.Text + "' )";
                komut1.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut2 = new SqlCommand();
                komut2.Connection = baglan;
                komut2.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay2 where ad_soyad = '" + label1.Text + "' if (@ali > 3) begin       DELETE FROM Ay2 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay2 where ad_soyad = '" + label1.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut2.ExecuteNonQuery();
                baglan.Close();


                Form7 f44 = new Form7();
                f44.Show();
                this.Hide();

            }


            else if (h == g)
            {

                MessageBox.Show("Aylık Quiz Hakkını Doldurdunuz");

            }
            else if (h > g)
            {
                MessageBox.Show("Aylık Quiz Hakkını Doldurdunuz");
            }


        }
        void sayac2()
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand kom4 = new SqlCommand("   SELECT MONTH(getdate()) AS Month; ");
            kom4.Connection = baglan;
            SqlDataReader dr2 = kom4.ExecuteReader();
            while (dr2.Read())
            {

                c = dr2[0].GetHashCode() ;

            }
            baglan.Close();
            baglan.Open();
            SqlCommand kom3 = new SqlCommand("   select top 1 ay2 from ay4 where Ad_Soyad ='" + label1.Text + "' order by kimlik desc");
            kom3.Connection = baglan;
            SqlDataReader dr3 = kom3.ExecuteReader();
            while (dr3.Read())
            {

                d = dr3[0].GetHashCode();

            }
            dr3.Close();
            baglan.Close();

            if (c == 1 && d == 12)
            {
                baglan.Open();
                SqlCommand komut14 = new SqlCommand();
                komut14.Connection = baglan;
                komut14.CommandText = "Insert Into ay4(ay2,Ad_Soyad)Values(" + c + ",'" + label1.Text + "' )";
                komut14.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut24 = new SqlCommand();
                komut24.Connection = baglan;
                komut24.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay4 where ad_soyad ='" + label1.Text + "' if (@ali > 3) begin       DELETE FROM Ay4 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay4  where Ad_Soyad = '" + label1.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut24.ExecuteNonQuery();
                baglan.Close();
                Form33 f45 = new Form33();
                f45.Show();
                this.Hide();


            }



            if (d < c)
            {



                baglan.Open();
                SqlCommand komut1 = new SqlCommand();
                komut1.Connection = baglan;
                komut1.CommandText = "Insert Into ay4(ay2,Ad_Soyad)Values(" + c + ",'" + label1.Text + "' )";
                komut1.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut2 = new SqlCommand();
                komut2.Connection = baglan;
                komut2.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay4 where ad_soyad = '" + label1.Text + "' if (@ali > 3) begin       DELETE FROM Ay4 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay4 where ad_soyad = '" + label1.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut2.ExecuteNonQuery();
                baglan.Close();


                Form33 f44 = new Form33();
                f44.Show();
                this.Hide();

            }


            else if (d == c)
            {

                MessageBox.Show("Aylık Orta Eleman Quiz Hakkını Doldurdunuz");

            }
            else if (d > c )
            {
                MessageBox.Show("Aylık Orta Eleman Quiz Hakkını Doldurdunuz");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayac3();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            sayac();
        }

        void sayac3()
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand kom4 = new SqlCommand("   SELECT MONTH(getdate()) AS Month; ");
            kom4.Connection = baglan;
            SqlDataReader dr2 = kom4.ExecuteReader();
            while (dr2.Read())
            {

                e = dr2[0].GetHashCode();

            }
            baglan.Close();
            baglan.Open();
            SqlCommand kom3 = new SqlCommand("   select top 1 ay2 from ay5 where Ad_Soyad ='" + label1.Text + "' order by kimlik desc");
            kom3.Connection = baglan;
            SqlDataReader dr3 = kom3.ExecuteReader();
            while (dr3.Read())
            {

                f = dr3[0].GetHashCode();

            }
            dr3.Close();
            baglan.Close();

            if (e == 1 && f == 12)
            {
                baglan.Open();
                SqlCommand komut14 = new SqlCommand();
                komut14.Connection = baglan;
                komut14.CommandText = "Insert Into ay5(ay2,Ad_Soyad)Values(" + e + ",'" + label1.Text + "' )";
                komut14.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut24 = new SqlCommand();
                komut24.Connection = baglan;
                komut24.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay5 where ad_soyad ='" + label1.Text + "' if (@ali > 3) begin       DELETE FROM Ay5 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay5  where Ad_Soyad = '" + label1.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut24.ExecuteNonQuery();
                baglan.Close();
                Form8 f45 = new Form8();
                f45.Show();
                this.Hide();


            }



            if (f < e)
            {



                baglan.Open();
                SqlCommand komut1 = new SqlCommand();
                komut1.Connection = baglan;
                komut1.CommandText = "Insert Into ay5(ay2,Ad_Soyad)Values(" + e + ",'" + label1.Text + "' )";
                komut1.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut2 = new SqlCommand();
                komut2.Connection = baglan;
                komut2.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay5 where ad_soyad = '" + label1.Text + "' if (@ali > 3) begin       DELETE FROM Ay5 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay5 where ad_soyad = '" + label1.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut2.ExecuteNonQuery();
                baglan.Close();


                Form8 f44 = new Form8();
                f44.Show();
                this.Hide();

            }


            else if (f == e)
            {

                MessageBox.Show("Aylık Zor Quiz Hakkını Doldurdunuz");

            }
            else if (f > e)
            {
                MessageBox.Show("Aylık Zor Quiz Hakkını Doldurdunuz");
            }


        }
    }
}

