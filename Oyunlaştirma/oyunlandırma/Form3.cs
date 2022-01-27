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

using System.Runtime.InteropServices;

namespace oyunlandırma
{
    public partial class Form3 : Form
    {
        int a, b, f, n, m,i, p, e, ç, c, g, q,z;

        public static int r, t, y, k, ü;
        string  ı, j, d,h;

        public Form3()
        {
            InitializeComponent();

        }

        BaglantiSinif bgl = new BaglantiSinif();

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.label1.Text = Form2.kadi;
            f5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form15 f9 = new Form15();
            f9.label1.Text = Form2.kadi;
            f9.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.label2.Text = Form2.kadi;
            f13.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.label1.Text = Form2.kadi;

            f14.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.label1.Text = Form2.kadi;
            f14.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void button10_Click(object sender, EventArgs e)
        {
            Form32 f = new Form32();
            f.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }









        void sayac26()
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand kome = new SqlCommand("SELECT year(getdate()) AS year");
            kome.Connection = baglan;
            SqlDataReader dre = kome.ExecuteReader();
            while (dre.Read())
            {

                ü = dre[0].GetHashCode();
            }
            dre.Close();
            baglan.Close();

            baglan.Open();
            SqlCommand kom42 = new SqlCommand("SELECT MONTH(getdate()) AS Month;");
            kom42.Connection = baglan;
            SqlDataReader dr42 = kom42.ExecuteReader();
            while (dr42.Read())
            {
                n = dr42[0].GetHashCode();


            }

            dr42.Close();
            baglan.Close();


            if (n == 6 && ü == 2021)
            {

                pictureBox19.Visible = true;

            }


        }







        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'oyunlaştırmaDataSet.SatıcıBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            SqlConnection baglan = new SqlConnection(bgl.Adres);
       
           
            baglan.Open();
            SqlCommand komer = new SqlCommand("SELECT year(getdate()) AS year");
            komer.Connection = baglan;
            SqlDataReader drer = komer.ExecuteReader();
            while (drer.Read())
            {

                ü = drer[0].GetHashCode();
            }
            drer.Close();
            baglan.Close();


            baglan.Open();
            labelmal.Text = Form2.kadi;
            label1.Text = Form2.kadi;
            SqlCommand kom = new SqlCommand("select sum(puan) from Puanlar where Ad_Soyad='" + labelmal.Text + "'");
            kom.Connection = baglan;
            SqlDataReader dr = kom.ExecuteReader();
            while (dr.Read())
            {
                label6.Text = dr[0] + " ";
                k = dr[0].GetHashCode();
            }
            dr.Close();
            baglan.Close();




            baglan.Open();
            SqlCommand kom42 = new SqlCommand("SELECT MONTH(getdate()) AS Month;");
            kom42.Connection = baglan;
            SqlDataReader dr42 = kom42.ExecuteReader();
            while (dr42.Read())
            {
                n = dr42[0].GetHashCode();
                m = dr42[0].GetHashCode() + 1;

            }

            dr42.Close();
            label21.Text = "2021.0" + n + ".01";
            label22.Text = "2021.0" + m + ".01";
            baglan.Close();
            baglan.Open();
            SqlCommand kom211 = new SqlCommand("select * from Geçmiş_Satışlar where  Ad_Soyad='" + labelmal.Text + "' and Ay_Yıl  Between '" + label21.Text + "' and  '" + label22.Text + "' ");
            kom211.Connection = baglan;
            SqlDataReader dr211 = kom211.ExecuteReader();
            while (dr211.Read())
            {
                label10.Text = dr211[4] + " ";
                q = dr211[4].GetHashCode();

            }
            dr211.Close();
            baglan.Close();
            baglan.Open();
            SqlCommand kom2112 = new SqlCommand("select AylıkHedefYüzdesi,YıllıkHedefYüzdesi,stokhedefyüzdesi from SatıcıBilgi where Ad_Soyad = '" + labelmal.Text + "' ");
            kom2112.Connection = baglan;
            SqlDataReader dr2112 = kom2112.ExecuteReader();
            while (dr2112.Read())
            {

                p = dr2112[0].GetHashCode();
                ç = dr2112[1].GetHashCode();
                f = dr2112[2].GetHashCode();
            }
            dr2112.Close();
            baglan.Close();

            if (p > 100)
            {
                progressBar1.Value = 100;
            }
            else
            {
                progressBar1.Value = p;
            }
            if (ç > 100)
            {
                progressBar2.Value = 100;
            }
            else
            {
                progressBar2.Value = ç;
            }
            if (f > 100)
            {
                progressBar3.Value = 100;
            }
            else
            {
                progressBar3.Value = f;
            }


            baglan.Open();
            SqlCommand kome = new SqlCommand("SELECT year(getdate()) AS year");
            kome.Connection = baglan;
            SqlDataReader dre = kom.ExecuteReader();
            while (dre.Read())
            {

                ü = dre[0].GetHashCode();
            }
            dre.Close();
            baglan.Close();






            baglan.Open();
            SqlCommand kom4w = new SqlCommand(" select top 1  sum(başarı) as'asdsda' FROM dbo.e_quizsonuc where Ad_Soyad ='" + labelmal.Text + "' group by Ad_Soyad order by  asdsda desc");
            kom4w.Connection = baglan;
            SqlDataReader dr4w = kom4w.ExecuteReader();
            while (dr4w.Read())
            {
                i = dr4w[0].GetHashCode();

            }

            dr4w.Close();
            baglan.Close();


            if (i > 1)
            {

                label24.Text = "1";
            }

            if (label24.Text == "1")
            {
                pictureBox16.Visible = false;
                pictureBox23.Visible = true;
            }
            else
            {
                pictureBox23.Visible = false;
                pictureBox16.Visible = true;
            }




            /*   baglan.Open();
               SqlCommand kom49 = new SqlCommand(" SELECT top 5 Ad_Soyad, aylıkhedefyüzdesi  FROM  SatıcıBilgi order by  aylıkhedefyüzdesi desc");

               kom49.Connection = baglan;
               SqlDataReader dr49 = kom49.ExecuteReader();
               while (dr49.Read())
               {
               listBox1.Items.Add(dr49[0].ToString());
           }

               if (listBox1.Items.Equals == label1.Text)
               {

                   pictureBox33.Visible = false;
               }
               else
               {
                   pictureBox2.Visible = false;
               }


           */






            baglan.Close();
            baglan.Open();
            SqlCommand kom5 = new SqlCommand(" select top 1  ad_soyad from SatıcıBilgi order by aylık_ciro desc");
            kom5.Connection = baglan;
            SqlDataReader dr5 = kom5.ExecuteReader();
            while (dr5.Read())
            {
                h = dr5[0].ToString();
            }
            if (h == labelmal.Text)
            {
                pictureBox29.Visible = true;
            }
            else
            {
                pictureBox29.Visible = false;
            }


            baglan.Close();
            baglan.Open();
            SqlCommand kom6 = new SqlCommand(" select  top 1 Ad_Soyad,count(*)as 'ada' from puanlar where Kategori ='quiz mikser' group by Ad_Soyad order by ada desc");
            kom6.Connection = baglan;
            SqlDataReader dr6 = kom6.ExecuteReader();
            while (dr6.Read())
            {
                j = dr6[0].ToString();
                label25.Text = j;
            }
            if (j == labelmal.Text)
            {
                pictureBox28.Visible = false;
            }
            else
            {
                pictureBox3.Visible = false;
            }
            baglan.Close();



            if (p >= 100)
            {

                pictureBox17.Visible = false;
                pictureBox18.Visible = true;
                pictureBox21.Visible = false;
                pictureBox22.Visible = true;
            }
            else
            {

                pictureBox17.Visible = true;
                pictureBox18.Visible = false;
                pictureBox21.Visible = true;
                pictureBox22.Visible = false;
            }

            //  ***************************************************************************************

            baglan.Open();
            SqlCommand kom7 = new SqlCommand(" select top 1 Ad_Soyad, count(*) as 'asdas' from dbo.Ödül group by Ad_Soyad order by  asdas desc");
            kom7.Connection = baglan;
            SqlDataReader dr7 = kom7.ExecuteReader();
            while (dr7.Read())
            {
                label9.Text = dr7[0].ToString();
            }


            if (label9.Text == labelmal.Text)
            {
                pictureBox24.Visible = false;
            }
            else
            {
                pictureBox15.Visible = false;
            }
            baglan.Close();

            // *************************




            if (a > b)
            {

            }
            else
            {

            }
            if (pictureBox3.Visible == true)
            {
                label11.Text = "1";
            }
            if (pictureBox29.Visible == true)
            {
                label12.Text = "1";
            }
            if (pictureBox23.Visible == true)
            {
                label20.Text = "1";
            }



            baglan.Open();
            SqlCommand kom41 = new SqlCommand("   SELECT MONTH(getdate()) AS Month; ");
            kom41.Connection = baglan;
            SqlDataReader dr51 = kom41.ExecuteReader();
            while (dr51.Read())
            {

                r = dr51[0].GetHashCode();
                z = dr51[0].GetHashCode() - 1;

            }
            baglan.Close();
            baglan.Open();
            SqlCommand kom32 = new SqlCommand("   select top 1 ay2 from ay3 where Ad_Soyad ='" + labelmal.Text + "'");
            kom32.Connection = baglan;
            SqlDataReader dr32 = kom32.ExecuteReader();
            while (dr32.Read())
            {

                t = dr32[0].GetHashCode();

            }
            dr32.Close();
       



          
            //************************************************************************************************************************************************




            //************************************************************************************************************************************************
            if (pictureBox3.Visible == true && a == 1 && b == 12)
            {
                baglan.Open();
                SqlCommand komut14 = new SqlCommand();
                komut14.Connection = baglan;
                komut14.CommandText = "Insert Into ay3(ay2,Ad_Soyad)Values(" + r + ",'" + labelmal.Text + "' )";
                komut14.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut24 = new SqlCommand();
                komut24.Connection = baglan;
                komut24.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay3 where ad_soyad ='" + labelmal.Text + "' if (@ali > 2) begin       DELETE FROM Ay3 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay3  where Ad_Soyad = '" + labelmal.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut24.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut25 = new SqlCommand();
                komut25.Connection = baglan;
                komut25.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('" + labelmal.Text + "',200 ,'BİLGİÇ SATICI ROZET ÖDÜLÜ',GETDATE() )";
                komut25.ExecuteNonQuery();
                baglan.Close();

            }



            else if (pictureBox3.Visible == true && t < r)
            {


                baglan.Close();
                baglan.Open();
                SqlCommand komut12 = new SqlCommand();
                komut12.Connection = baglan;
                komut12.CommandText = "Insert Into ay3(ay2,Ad_Soyad)Values(" + r + ",'" + labelmal.Text + "' )";
                komut12.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut2 = new SqlCommand();
                komut2.Connection = baglan;
                komut2.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay3 where ad_soyad = '" + labelmal.Text + "' if (@ali > 2) begin       DELETE FROM Ay3 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay3 where ad_soyad = '" + labelmal.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut2.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut25 = new SqlCommand();
                komut25.Connection = baglan;
                komut25.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('" + labelmal.Text + "',200 ,'BİLGİÇ SATICI ROZET ÖDÜLÜ',GETDATE() )";
                komut25.ExecuteNonQuery();
                baglan.Close();

            }


            else
            {


            }

            if (pictureBox29.Visible == true && a == 1 && b == 12)
            {
                baglan.Open();
                SqlCommand komut14 = new SqlCommand();
                komut14.Connection = baglan;
                komut14.CommandText = "Insert Into ay3(ay2,Ad_Soyad)Values(" + r + ",'" + labelmal.Text + "' )";
                komut14.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut24 = new SqlCommand();
                komut24.Connection = baglan;
                komut24.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay3 where ad_soyad ='" + labelmal.Text + "' if (@ali > 2) begin       DELETE FROM Ay3 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay3  where Ad_Soyad = '" + labelmal.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut24.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut25 = new SqlCommand();
                komut25.Connection = baglan;
                komut25.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('" + labelmal.Text + "',200 ,'SÜPER SATICI ROZET ÖDÜLÜ',GETDATE() )";
                komut25.ExecuteNonQuery();
                baglan.Close();

            }



            else if (pictureBox29.Visible == true && t < r)
            {


                baglan.Close();
                baglan.Open();
                SqlCommand komut121 = new SqlCommand();
                komut121.Connection = baglan;
                komut121.CommandText = "Insert Into ay3(ay2,Ad_Soyad)Values(" + r + ",'" + labelmal.Text + "' )";
                komut121.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut2 = new SqlCommand();
                komut2.Connection = baglan;
                komut2.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay3 where ad_soyad = '" + labelmal.Text + "' if (@ali > 2) begin       DELETE FROM Ay3 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay3 where ad_soyad = '" + labelmal.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut2.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut25 = new SqlCommand();
                komut25.Connection = baglan;
                komut25.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('" + labelmal.Text + "',200 ,'Süper SATICI ROZET ÖDÜLÜ',GETDATE() )";
                komut25.ExecuteNonQuery();
                baglan.Close();

            }


            else
            {


            }

            baglan.Close();
            baglan.Open();
            SqlCommand komE = new SqlCommand("SELECT year(getdate()) AS year");
            komE.Connection = baglan;
            SqlDataReader drE = kome.ExecuteReader();
            while (drE.Read())
            {

                c = drE[0].GetHashCode();
            }
            drE.Close();
            baglan.Close();

            baglan.Open();
            SqlCommand kom42E = new SqlCommand("SELECT MONTH(getdate()) AS Month;");
            kom42E.Connection = baglan;
            SqlDataReader dr42E = kom42E.ExecuteReader();
            while (dr42E.Read())
            {
                g = dr42E[0].GetHashCode();


            }

            dr42E.Close();
            baglan.Close();


            if (n == 6 && ü == 2022)
            {

                baglan.Open();
                SqlCommand komut140E = new SqlCommand();
                komut140E.Connection = baglan;
                komut140E.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('" + labelmal.Text + "',100 ,'Hoşgeldin ROZET ÖDÜLÜ',GETDATE() )";
                komut140E.ExecuteNonQuery();
                baglan.Close();



            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (pictureBox18.Visible == true && t == 1 && r == 12)
            {
                baglan.Open();
                SqlCommand komut14 = new SqlCommand();
                komut14.Connection = baglan;
                komut14.CommandText = "Insert Into ay3(ay2,Ad_Soyad)Values(" + r + ",'" + labelmal.Text + "' )";
                komut14.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut24 = new SqlCommand();
                komut24.Connection = baglan;
                komut24.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay3 where ad_soyad ='" + labelmal.Text + "' if (@ali > 2) begin       DELETE FROM Ay3 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay3  where Ad_Soyad = '" + labelmal.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut24.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut25 = new SqlCommand();
                komut25.Connection = baglan;
                komut25.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('" + labelmal.Text + "',500 ,'HEDEFİNİ TUTTURAN SATICI ROZET ÖDÜLÜ',GETDATE() )";
                komut25.ExecuteNonQuery();
                baglan.Close();

            }



            else if (pictureBox18.Visible == true && t < r)
            {


                baglan.Close();
                baglan.Open();
                SqlCommand komut61 = new SqlCommand();
                komut61.Connection = baglan;
                komut61.CommandText = "Insert Into ay3(ay2,Ad_Soyad)Values(" + r + ",'" + labelmal.Text + "' )";
                komut61.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut2 = new SqlCommand();
                komut2.Connection = baglan;
                komut2.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay3 where ad_soyad = '" + labelmal.Text + "' if (@ali > 2) begin       DELETE FROM Ay3 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay3 where ad_soyad = '" + labelmal.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut2.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut25 = new SqlCommand();
                komut25.Connection = baglan;
                komut25.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('" + labelmal.Text + "',500 ,'HEDEFİNİ TUTTURAN SATICI ROZET ÖDÜLÜ',GETDATE() )";
                komut25.ExecuteNonQuery();
                baglan.Close();

            }


            else
            {


            }

            if (pictureBox17.Visible == true && t == 1 && r == 12)
            {
                baglan.Open();
                SqlCommand komut14 = new SqlCommand();
                komut14.Connection = baglan;
                komut14.CommandText = "Insert Into ay3(ay2,Ad_Soyad)Values(" + r + ",'" + labelmal.Text + "' )";
                komut14.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut24 = new SqlCommand();
                komut24.Connection = baglan;
                komut24.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay3 where ad_soyad ='" + labelmal.Text + "' if (@ali > 2) begin       DELETE FROM Ay3 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay3  where Ad_Soyad = '" + labelmal.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut24.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut25 = new SqlCommand();
                komut25.Connection = baglan;
                komut25.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('" + labelmal.Text + "',-300 ,'HEDEFİNİ TUTTURAMAYAN SATICI ROZET ÖDÜLÜ',GETDATE() )";
                komut25.ExecuteNonQuery();
                baglan.Close();

            }



            else if (pictureBox17.Visible == true && t < r)
            {


                baglan.Close();
                baglan.Open();
                SqlCommand komut19 = new SqlCommand();
                komut19.Connection = baglan;
                komut19.CommandText = "Insert Into ay3(ay2,Ad_Soyad)Values(" + r + ",'" + labelmal.Text + "' )";
                komut19.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut22 = new SqlCommand();
                komut22.Connection = baglan;
                komut22.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay3 where ad_soyad = '" + labelmal.Text + "' if (@ali > 2) begin       DELETE FROM Ay3 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay3 where ad_soyad = '" + labelmal.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut22.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut25 = new SqlCommand();
                komut25.Connection = baglan;
                komut25.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('" + labelmal.Text + "',-300 ,'HEDEFİNİ TUTTURAMAYAN SATICI ROZET ÖDÜLÜ',GETDATE() )";
                komut25.ExecuteNonQuery();
                baglan.Close();

            }


            else
            {


            }





            if (pictureBox23.Visible == true && t == 1 && r == 12)
            {
                baglan.Open();
                SqlCommand komut14 = new SqlCommand();
                komut14.Connection = baglan;
                komut14.CommandText = "Insert Into ay3(ay2,Ad_Soyad)Values(" + r + ",'" + labelmal.Text + "' )";
                komut14.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut24 = new SqlCommand();
                komut24.Connection = baglan;
                komut24.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay3 where ad_soyad ='" + labelmal.Text + "' if (@ali > 2) begin       DELETE FROM Ay3 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay3  where Ad_Soyad = '" + labelmal.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut24.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut25 = new SqlCommand();
                komut25.Connection = baglan;
                komut25.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('" + labelmal.Text + "',200 ,'SOSYAL SATICI ROZET ÖDÜLÜ',GETDATE() )";
                komut25.ExecuteNonQuery();
                baglan.Close();

            }



            else if (pictureBox23.Visible == true && t < r)
            {


                baglan.Close();
                baglan.Open();
                SqlCommand komut01 = new SqlCommand();
                komut01.Connection = baglan;
                komut01.CommandText = "Insert Into ay3(ay2,Ad_Soyad)Values(" + r + ",'" + labelmal.Text + "' )";
                komut01.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut2 = new SqlCommand();
                komut2.Connection = baglan;
                komut2.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay3 where ad_soyad = '" + labelmal.Text + "' if (@ali > 2) begin       DELETE FROM Ay3 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay3 where ad_soyad = '" + labelmal.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut2.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut25 = new SqlCommand();
                komut25.Connection = baglan;
                komut25.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('" + labelmal.Text + "',200 ,'SOSYAL SATICI ROZET ÖDÜLÜ',GETDATE() )";
                komut25.ExecuteNonQuery();
                baglan.Close();

            }


            else
            {


            }






            if (pictureBox15.Visible == true && a == 1 && b == 12)
            {
                baglan.Open();
                SqlCommand komut14 = new SqlCommand();
                komut14.Connection = baglan;
                komut14.CommandText = "Insert Into ay3(ay2,Ad_Soyad)Values(" + r + ",'" + labelmal.Text + "' )";
                komut14.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut24 = new SqlCommand();
                komut24.Connection = baglan;
                komut24.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay3 where ad_soyad ='" + labelmal.Text + "' if (@ali > 2) begin       DELETE FROM Ay3 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay3  where Ad_Soyad = '" + labelmal.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut24.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut25 = new SqlCommand();
                komut25.Connection = baglan;
                komut25.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('" + labelmal.Text + "',400 ,'ÖDÜL SEVER SATICI ROZET ÖDÜLÜ',GETDATE() )";
                komut25.ExecuteNonQuery();
                baglan.Close();

            }



            else if (pictureBox3.Visible == true && t < r)
            {


                baglan.Close();
                baglan.Open();
                SqlCommand komut001 = new SqlCommand();
                komut001.Connection = baglan;
                komut001.CommandText = "Insert Into ay3(ay2,Ad_Soyad)Values(" + r + ",'" + labelmal.Text + "' )";
                komut001.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut2 = new SqlCommand();
                komut2.Connection = baglan;
                komut2.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay3 where ad_soyad = '" + labelmal.Text + "' if (@ali > 2) begin       DELETE FROM Ay3 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay3 where ad_soyad = '" + labelmal.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut2.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut25 = new SqlCommand();
                komut25.Connection = baglan;
                komut25.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('" + labelmal.Text + "',400 ,'ÖDÜLSEVER SATICI ROZET ÖDÜLÜ',GETDATE() )";
                komut25.ExecuteNonQuery();
                baglan.Close();

            }


            else
            {


            }

            if (pictureBox2.Visible == true && a == 1 && b == 12)
            {
                baglan.Open();
                SqlCommand komut14 = new SqlCommand();
                komut14.Connection = baglan;
                komut14.CommandText = "Insert Into ay3(ay2,Ad_Soyad)Values(" + r + ",'" + labelmal.Text + "' )";
                komut14.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut24 = new SqlCommand();
                komut24.Connection = baglan;
                komut24.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay3 where ad_soyad ='" + labelmal.Text + "' if (@ali > 2) begin       DELETE FROM Ay3 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay3  where Ad_Soyad = '" + labelmal.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut24.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut25 = new SqlCommand();
                komut25.Connection = baglan;
                komut25.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('" + labelmal.Text + "',300 ,'SEÇKİN SATICI ROZET ÖDÜLÜ',GETDATE() )";
                komut25.ExecuteNonQuery();
                baglan.Close();

            }



            else if (pictureBox2.Visible == true && t < r)
            {


                baglan.Close();
                baglan.Open();
                SqlCommand komut12 = new SqlCommand();
                komut12.Connection = baglan;
                komut12.CommandText = "Insert Into ay3(ay2,Ad_Soyad)Values(" + r + ",'" + labelmal.Text + "' )";
                komut12.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut2 = new SqlCommand();
                komut2.Connection = baglan;
                komut2.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay3 where ad_soyad = '" + labelmal.Text + "' if (@ali > 2) begin       DELETE FROM Ay3 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay3 where ad_soyad = '" + labelmal.Text + "' ORDER  BY Kimlik aSC   );    end ";
                komut2.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                SqlCommand komut25 = new SqlCommand();
                komut25.Connection = baglan;
                komut25.CommandText = "Insert Into Puanlar(Ad_Soyad,Puan,Kategori,Tarih)Values('" + labelmal.Text + "',300 ,'SEÇKİN SATICI ROZET ÖDÜLÜ',GETDATE() )";
                komut25.ExecuteNonQuery();
                baglan.Close();

            }

       

            sayac26();

            baglan.Open();
            SqlCommand komut24t = new SqlCommand();
            komut24t.Connection = baglan;
            komut24t.CommandText = " declare @ali  tinyint select @ali = Count(ay2)  from ay3 where ad_soyad ='" + labelmal.Text + "' if (@ali > 2) begin       DELETE FROM Ay3 WHERE Kimlik = (SELECT top 1 Kimlik FROM   Ay3  where Ad_Soyad = '" + labelmal.Text + "' ORDER  BY Kimlik aSC   );    end ";
            komut24t.ExecuteNonQuery();
            baglan.Close();
        }






        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form36 f9 = new Form36();
            f9.label2.Text = Form2.kadi;
            f9.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form42 f9 = new Form42();
            f9.label2.Text = Form2.kadi;
            f9.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form48 f9 = new Form48();
            f9.label2.Text =  Form2.kadi;
            f9.label3.Text = "sattı "+Form2.kadi; 
            f9.Show();
            this.Hide();
        }
   
     
        private void button6_Click_2(object sender, EventArgs e)
        {
            Form36 f9 = new Form36();
            f9.label2.Text = Form2.kadi;
            f9.Show();
            this.Hide();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Form48 f9 = new Form48();
            f9.label2.Text = Form2.kadi;
            f9.label3.Text = "sattı " + Form2.kadi;
            f9.Show();
            this.Hide();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Form42 f9 = new Form42();
            f9.label2.Text = Form2.kadi;
            f9.Show();
            this.Hide();
        }

       
      
        
      
       
        
  
      

        
        
        
 
    }
    }

    
