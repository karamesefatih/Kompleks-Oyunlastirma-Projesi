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
    public partial class Form28 : Form
    {
        public Form28()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();


        DataTable tablo = new DataTable();
        void denetim()
        {
            try
            {
                DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
                if (dt != null)
                {
                    List<StokHakkı> sorun = new List<StokHakkı>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        StokHakkı soruu = new StokHakkı();
                        soruu.Kimlik = dt.Rows[i]["Kimlik"].ToString();
                        soruu.Ad_Soyad = dt.Rows[i]["Ad_Soyad"].ToString();
                        soruu.Stok_Hakkı_Kodu = dt.Rows[i]["Stok_Hakkı_Kodu"].ToString();
                        soruu.Başlama_Tarihi = dt.Rows[i]["Başlama_Tarihi"].ToString();
                        soruu.Bitiş_Tarihi = dt.Rows[i]["Bitiş_Tarihi"].ToString();
              
                        sorun.Add(soruu);
                    }
                       
                   stokHakkıBindingSource.DataSource = sorun;
                }
            }
            catch (Exception)
            {
                label2.Text = "i";
                button3.Visible = false;
                MessageBox.Show("Stok Hakkı listesi haricinde başka liste kullanılamaz,lütfen soru listesi yükleyiniz", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private void Form28_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'oyunlaştırmaDataSet.Stok_Hakkı' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

 
     

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form28 f7 = new Form28();
            f7.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
            denetim();
            if (label2.Text == "i")
            {
                label2.Text = "Tekrar Deneyin";
            }
            else
            {
                dataGridView1.DataSource = dt;
                string a = dataGridView1.Rows[0].Cells[0].Value.ToString();
                string b = dataGridView1.Rows[0].Cells[1].Value.ToString();
                string c = dataGridView1.Rows[0].Cells[2].Value.ToString();
                string d = dataGridView1.Rows[0].Cells[3].Value.ToString();
           
                if (a == "" || b == "" || c == "" || d == "" )
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
               OleDbConnection baglanexcel = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox1.Text + "; Extended Preporties ='Excel 12.0 Xml;HDR=Yes' ");
                baglanexcel.Open();
                int kayıtsayısı = 0;
                OleDbCommand komut = new OleDbCommand("Select * from[Sayfa1$]", baglanexcel);
                OleDbDataReader okuyucu = komut.ExecuteReader();

                SqlConnection baglan2 = new SqlConnection(bgl.Adres);
                baglan2.Open();
                while (okuyucu.Read())
                {
                    Form6 f5 = new Form6();
                    f5.Show();
                    this.Hide();
                    BaglantiSinif bgl = new BaglantiSinif();


                    SqlConnection baglan = new SqlConnection(bgl.Adres);
                    baglan.Open();
                    SqlCommand komut2 = new SqlCommand("INSERT INTO StokHakkı(Kimlik,Ad_Soyad,Stok_Hakkı_Kodu,Başlama_Tarihi,Bitiş_Tarihi)values('" + okuyucu[" Kimlik "].ToString() + okuyucu["Ad_Soyad "].ToString() + "','" + okuyucu["Stok_Hakkı_Kodu"].ToString() + "','" + okuyucu["Başlama_Tarihi"].ToString() + "','" + okuyucu["Bitiş_Tarihi"].ToString() + "'", baglan);
                    komut2.ExecuteNonQuery();
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


