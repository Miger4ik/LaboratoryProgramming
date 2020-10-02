using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chart
{
    public partial class Form1 : Form
    {
        // кількість точок на графіку
        private int dotNumber = 100000;
        public Form1()
        {
            InitializeComponent();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].SetDefault(true);

            // визначаємо зсув фаз
            double alpha = Convert.ToInt32(PiMultiplier.Value) * Math.PI / 4;
            // оголошуємо два масиви для збереження точок які мають відображатись на графіку
            double[] x = new double[dotNumber];
            double[] y = new double[dotNumber];
            // заповнюємо масиви точками
            for (int i = 0; i < dotNumber; i++)
            {
                // обчислюємо розміщення точок за формулами
                // x(t) = Asin(at + alpha)
                // y(t) = Bsin(bt)
                // де A,B - Амплітуди коливань
                // a,b - частоти
                // alpha - зсув фаз

                x[i] = Convert.ToInt32(FirstAmpl.Value) * Math.Sin( i * Convert.ToInt32(FirstFrequency.Value) + alpha);
                y[i] = Convert.ToInt32(SecondAmpl.Value) * Math.Sin( i * Convert.ToInt32(SecondFrequency.Value));
            }
            chart1.Series[0].Points.DataBindXY(x, y);

        }

    }
}
