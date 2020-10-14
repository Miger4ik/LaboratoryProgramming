using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private double a = 0;
        private double b = 0;
        private double h = 0;

        private IIntegral integral;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIntegrate_Click(object sender, EventArgs e)
        {
            a = (double)numericA.Value;
            b = (double)numericB.Value;
            h = (double)numericH.Value;

            if (radioButtonRectangles.Checked)
            {
                integral = new IntegralRectangles();
            }
            else if (radioButtonTrapezoid.Checked)
            {
                integral = new IntegralTrapezoid();
            }
            else if (radioButtonSimpson.Checked)
            {
                integral = new IntegralSimpson();
            }

            label4.Text = "" + integral.Integrate(a, b, h);
        }
    }

    public interface IIntegral
    {
        double Integrate(double a, double b, double h);
    }

    public class IntegralRectangles : IIntegral
    {
        public double Integrate(double a, double b, double h)
        {
            double sum = 0d;
            double c = (b - a) / h;
            double f(double x) => x / (x - 1);

            // Центральний Трикутник
            for (double i = 0; i < h; i++)
            {
                double x = a + i / 2d * c;
                sum += f(x);
            }
            return c * sum;
        }
    }

    public class IntegralTrapezoid : IIntegral
    {
        public double Integrate(double a, double b, double h)
        {
            double sum = 0d;
            double c = (b - a) / h;

            for (int i = 0; i < h; i++)
            {
                double xk = a + i * c;
                double xk_1 = a + (i + 1) * c;
                sum += (Math.Exp(Math.Sin(xk)) + Math.Exp(Math.Sin(xk_1)));
            }

            return sum * c / 2;

        }
    }

    public class IntegralSimpson : IIntegral
    {
        public double Integrate(double a, double b, double h)
        {
            double f(double x) => x / (x - 1);
            double c = (b - a) / h;
            double sum1 = 0d;
            double sum2 = 0d;

            for (int i = 1; i <= h; i++)
            {
                double xk = a + i * c;
                if (i <= h - 1)
                {
                    sum1 += f(xk);
                }

                double xk_1 = a + (i - 1) * c;
                sum2 += f((xk + xk_1) / 2);
            }

            return c / 3d * (1d / 2d * f(a) + sum1 + 2 * sum2 + 1d / 2d * f(b));
        }
    }
}
