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
    public partial class Form41 : Form
    {
        public Form41()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        private void Form41_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form37 f9 = new Form37();
           
            f9.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f9 = new Form3();
            f9.label1.Text = Form2.kadi;
            f9.Show();
            this.Hide();
        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form69 f69 = new Form69();
            f69.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form40 f9 = new Form40();
            f9.label1.Text = Form2.kadi;
            f9.Show();
            this.Hide();
        }
    }
}
