using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;


namespace oyunlandırma
{
    public partial class Form31 : Form
    {
        public Form31()
        {
            InitializeComponent();
        }


        BaglantiSinif bgl = new BaglantiSinif();

        DataTable tablo = new DataTable();
        int n;
        void denetim()
        {
            try
            {
                DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
                if (dt != null)
                {
                    List<Kullanıcı> sorun = new List<Kullanıcı>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Kullanıcı soruu = new Kullanıcı();
              
                        soruu.Ad_Soyad = dt.Rows[i]["Ad_Soyad"].ToString();
                        soruu.Şifre = dt.Rows[i]["Şifre"].ToString();
                        soruu.Rütbe = dt.Rows[i]["Rütbe"].ToString();
                
                  
                        sorun.Add(soruu);
                    }
                    kullanıcılarBindingSource.DataSource = sorun;
                }
            }
            catch (Exception)
            {
                label2.Text = "Tekrar Deneyin";
                button3.Visible = false;
                MessageBox.Show("Kullanıcı listesi haricinde başka liste kullanılamaz,lütfen soru listesi yükleyiniz", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }






        DataTableCollection tableCollection;
        private void button1_Click(object sender, EventArgs e)
        {
            using (var o = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xlsx|Excel Workbook|*.xls" })
            {
                if (o.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = o.FileName;
                    using (var stream = File.Open(o.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }

                            });
                            tableCollection = result.Tables;
                            comboBox1.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                comboBox1.Items.Add(table.TableName);
                        }
                    }
                }

            }
        }

        private void Form31_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'oyunlaştırmaDataSet.Kullanıcılar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
       


    

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form16 f7 = new Form16();
            f7.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
            denetim();
            if (label2.Text == "Tekrar Deneyin")
            {
                label2.Text = "2";
            }
            else
            {
                dataGridView1.DataSource = dt;
            
                string b = dataGridView1.Rows[0].Cells[1].Value.ToString();
                string c = dataGridView1.Rows[0].Cells[2].Value.ToString();
                string d = dataGridView1.Rows[0].Cells[3].Value.ToString();
              
                if ( b == "" || c == "" || d == "" )
                {
                    MessageBox.Show("Lütfen boş sütunları doldurup tekrar deneyiniz");
                    label3.Visible = true;
                    label3.Text = "Lütfen hataları düzeltip tekrar deneyin";
                }
                else
                {
                    button4.Visible = true;
                    label3.Text = " işlemi onaylayabilirsiniz";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            try
            {
      
                SqlConnection baglan = new SqlConnection(bgl.Adres);
                baglan.Open();
                SqlCommand kom42 = new SqlCommand("SELECT MONTH(getdate()) AS Month;");
                kom42.Connection = baglan;
                SqlDataReader dr42 = kom42.ExecuteReader();
                while (dr42.Read())
                {
                    n = dr42[0].GetHashCode() - 1;


                }
                baglan.Close();
                dr42.Close();

                OleDbConnection baglanexcel = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox1.Text + "; Extended Properties ='Excel 12.0 Xml;HDR=Yes' ");
                baglanexcel.Open();
                int kayıtsayısı = 0;
                OleDbCommand komut = new OleDbCommand("Select * from["+comboBox1.Text+"$]", baglanexcel);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                SqlConnection baglan2 = new SqlConnection(bgl.Adres);
                baglan2.Open();
                while (okuyucu.Read())
                {
                    baglan.Open();
                    SqlCommand komut14 = new SqlCommand();
                    komut14.Connection = baglan;
                    komut14.CommandText = "Insert Into ay3(ay2,Ad_Soyad)Values(" + n + ",'" + okuyucu["Ad_Soyad"].ToString()  + "' )";
                    komut14.ExecuteNonQuery();
                    SqlCommand komut14y = new SqlCommand();
                    komut14y.Connection = baglan;
                    komut14y.CommandText = "Insert Into ay2(ay2,Ad_Soyad)Values(" + n + ",'" + okuyucu["Ad_Soyad"].ToString() + "' )";
                    komut14y.ExecuteNonQuery();
                    SqlCommand komut14z = new SqlCommand();
                    komut14z.Connection = baglan;
                    komut14z.CommandText = "Insert Into ay(ay2,Ad_Soyad)Values(" + n + ",'" + okuyucu["Ad_Soyad"].ToString() + "' )";
                    komut14z.ExecuteNonQuery();
                    SqlCommand komut14q = new SqlCommand();
                    komut14q.Connection = baglan;
                    komut14q.CommandText = "Insert Into ay4(ay2,Ad_Soyad)Values(" + n + ",'" + okuyucu["Ad_Soyad"].ToString() + "' )";
                    komut14q.ExecuteNonQuery();
                    SqlCommand komut141q = new SqlCommand();
                    komut141q.Connection = baglan;
                    komut141q.CommandText = "Insert Into ay4(ay2,Ad_Soyad)Values(" + n + ",'" + okuyucu["Ad_Soyad"].ToString() + "' )";
                    komut141q.ExecuteNonQuery();
             
                    SqlCommand komut2 = new SqlCommand("INSERT INTO Kullanıcılar(Ad_Soyad,Şifre,Rütbe)values('" + okuyucu["Ad_Soyad"].ToString() + "','" + okuyucu["Şifre"].ToString() + "','" + okuyucu["Rütbe"].ToString() + "' ) ", baglan);
                    komut2.ExecuteNonQuery();
                   

                    SqlCommand komut141 = new SqlCommand();
                    komut141.Connection = baglan;
                    komut141.CommandText = "insert into puanlar(Ad_soyad,Kategori,puan,tarih)values('" + okuyucu["Ad_Soyad"].ToString() + "','HOŞGELDİN satıcı rozeti',100,getdate())";
                    komut141.ExecuteNonQuery();
                    kayıtsayısı++;
                    baglan.Close();

                }
                baglanexcel.Close();
                baglan2.Close();
                MessageBox.Show("toplam: " + kayıtsayısı + "tane kayıt başarılı şekilde kayıt edildi.", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (OleDbException HATA)
            {
                MessageBox.Show("hata kodu : " + HATA.ErrorCode.ToString() + " hata mesajı : " + HATA.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int sutun = 1;
            int satir = 1;
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Workbooks.Add();
            ExcelApp.Visible = true;
            ExcelApp.Worksheets[1].Activate();
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                ExcelApp.Cells[satir, sutun + j].Value = dataGridView1.Columns[j].HeaderText;

            }
            satir++;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    ExcelApp.Cells[satir + i, sutun + j].Value = dataGridView1[j, i].Value;
                }
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}


