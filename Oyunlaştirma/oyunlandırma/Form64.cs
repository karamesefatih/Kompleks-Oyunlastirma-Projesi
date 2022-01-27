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
    public partial class Form64 : Form
    {
        public Form64()
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


                Form51 Formx = new Form51(); //FORMx= name of form

                Formx.Show();



                this.Hide();

            }

            if (a == 2)

            {

                Form52 Formy = new Form52();

                Formy.Show();


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

                Form60 F57 = new Form60(); //FORMx= name of form

                F57.Show();



                this.Hide();

            }

            if (a == 8)

            {

                Form59 F58 = new Form59();

                F58.Show();


                this.Hide();

            }
        }
    }
}
