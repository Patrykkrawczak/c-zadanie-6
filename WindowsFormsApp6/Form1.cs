using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            float true_wynik = 1000000 / 3;


            double n = double.Parse(k_box.Text);
            n = Math.Pow(10, n);
            int m = int.Parse(m_box.Text);
            Random rnd = new Random();

            double f = 0.0F;
            int o = 0;
            WindowsFormsApp.SingleCount single = new SingleCount();
            single.X1 = 0;
            single.X2 = 100;
            Random rmd = new Random();
            double min = Double.MaxValue;
            double min2 = Double.MaxValue;
            double minx11 = 0F;
            double minx12 = 0F;
            double minx21 = 0F;
            double minx22 = 0F;
            double minx111 = 0F;
            double minx112 = 0F;
            double minx121 = 0F;
            double minx122 = 0F;
            for (int j = 0; j < m; j++)
            {


                f = 0.0F;
                int licz = 0;
                double old_i = 0;

                
                single.X1 = rmd.Next(0,50);
                single.X2 = rmd.Next(50, 100);

                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += (i * i) * (i - old_i);

                    old_i = i;
                };
                double f1 = 0.0F;

                old_i = 0;

                double x1old = single.X1;
                double x2old = single.X2;

                single.X1 = rmd.Next(0, 50);
                single.X2 = rmd.Next(50, 100);

                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {


                    f1 += (i * i * i) * (i - old_i);

                    old_i = i;
                };
                double roznica = Math.Abs(f - f1);
                if (roznica < min) 
                {
                    min = roznica;
                    minx11 = x1old;
                    minx12 = x2old;
                    minx21 = single.X1;
                    minx22 = single.X2;
                }
                f = 0.0F;

                single.X1 = rmd.Next(0, 50);
                single.X2 = rmd.Next(50, 100);
                old_i = 0;
                for (double i = 0.0F; i <= 100.0; i = i + 100F / n)
                {

                    licz += 1;
                    f += (((i * i) + (old_i * old_i)) / 2) * (i - old_i);

                    old_i = i;
                };


                f1 = 0.0F;
                single.X1 = rmd.Next(0, 50);
                single.X2 = rmd.Next(50, 100);
                old_i = 0;
                for (double i = 0.0F; i <= 100.0; i = i + 100F / n)
                {

                    licz += 1;
                    f1 += (((i * i) + (old_i * old_i)) / 2) * (i - old_i);

                    old_i = i;
                };

                roznica = Math.Abs(f - f1);
                if (roznica < min2)
                {
                    min = roznica;
                    minx111 = x1old;
                    minx112 = x2old;
                    minx121 = single.X1;
                    minx122 = single.X2;
                }
            };

            wynik_box.Text += "  prostokąty: x1 = " + minx11.ToString() + " x2 = " + minx12.ToString() + " x1 = " + minx21.ToString() + " x2 = " + minx22.ToString() + " roznica = " + min.ToString();
            wynik_box.Text += "  trapezy: x1 = " + minx111.ToString() + " x2 = " + minx112.ToString() + " x1 = " + minx121.ToString() + " x2 = " + minx122.ToString() + " roznica = " + min2.ToString();

        }
    }
}
