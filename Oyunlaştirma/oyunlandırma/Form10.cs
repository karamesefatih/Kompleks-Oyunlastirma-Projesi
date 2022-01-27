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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form50 f45 = new Form50();
        

            f45.Show();
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form49 f45 = new Form49();
            f45.label1.Text = label2.Text;
            f45.label2.Text = label3.Text;
            f45.label3.Text = label4.Text;
      
            f45.Show();
            this.Hide();


        }
    }
}
