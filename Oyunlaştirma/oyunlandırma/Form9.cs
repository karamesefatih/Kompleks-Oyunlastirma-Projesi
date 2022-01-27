using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyunlandırma
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form3 f3 = new Form3();
           
            f3.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            label2.Text = Form2.kadi;
        }
    }
}
