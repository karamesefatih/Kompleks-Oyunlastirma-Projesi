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
    public partial class Form42 : Form
    {
        public Form42()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form38 f9 = new Form38();
            f9.label2.Text = Form2.kadi;
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

        private void Form42_Load(object sender, EventArgs e)
        {

        }
    }
}
