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
    public partial class Form69 : Form
    {
        public Form69()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form41 f69 = new Form41();
            f69.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 f9 = new Form3();
            f9.label1.Text = Form2.kadi;
            f9.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form41 f9 = new Form41();
            f9.label1.Text = Form2.kadi;
            f9.Show();
            this.Hide();
        }
    }
}
