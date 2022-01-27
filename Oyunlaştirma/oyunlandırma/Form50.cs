using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyunlandırma
{
    public partial class Form50 : Form
    {
        public Form50()
        {
            InitializeComponent();
        }
        Timer t = new Timer();
        Random Rast = new Random();
        int toplamben = 0;
     
        private void button1_Click(object sender, EventArgs e)
        {
           
            t.Interval = 3000;
            t.Tick += new EventHandler(OnTimerTicked);

            t.Start();


        }

        private void OnTimerTicked(object sender, EventArgs e)
        {
            t.Stop();

            int a = Rast.Next(1, 8);

            if (a == 1)

            {


                Form51 F51 = new Form51(); //FORMx= name of form

                F51.Show();



                this.Hide();

            }

            if (a == 2)

            {

                Form52 F52 = new Form52();

                F52.Show();


                this.Hide();

            }
            if (a == 3)

            {

                Form53 F53 = new Form53(); //FORMx= name of form

                F53.Show();



                this.Hide();

            }

            if (a == 4)

            {

                Form54 F54 = new Form54();

                F54.Show();


                this.Hide();

            }

            if (a == 5)

            {
                Form55 F55 = new Form55(); //FORMx= name of form

                F55.Show();



                this.Hide();

            }

            if (a == 6)

            {


                Form56 F56 = new Form56();

                F56.Show();


                this.Hide();

            }
            if (a == 7)

            {

                Form57 F57 = new Form57(); //FORMx= name of form

                F57.Show();



                this.Hide();

            }

            if (a == 8)

            {

                Form58 F58 = new Form58();

                F58.Show();


                this.Hide();

            }
        }

        private void Form50_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
