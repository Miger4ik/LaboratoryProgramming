using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourthLab
{
    public partial class Form1 : Form
    {
        // Оголошуєм змінні
        private double a;
        private double b;
        private double h;

        private IIntegral rectanglesMethod;
        private IIntegral trapezoidMethod;
        private IIntegral simpsonMethod;

        public Form1()
        {
            // Ініціалізуємо змінні
            InitializeComponent();
            a = 0;
            b = 0;
            h = 0;

            rectanglesMethod = new RectanglesMethod();
            trapezoidMethod = new TrapezoidMethod();
            simpsonMethod = new SimpsonMethod();
        }

        private void Components(object sender, EventArgs e)
        {
            // Передаємо змінні
            a = (double)numeric1.Value;
            b = (double)numeric2.Value;
            h = (double)numeric3.Value;

            rectanglesMethod.Integrate(a, b, h);
            trapezoidMethod.Integrate(a, b, h);
            simpsonMethod.Integrate(a, b, h);
        }

        public interface IIntegral
        {
            // Передаємо змінні у класи 
            double[] Integrate(double a, double b, double h);
        }       

        // Оголошуємо клас методу Прямокутників
        public class RectanglesMethod : IIntegral
        {         
            public double[] Integrate(double a, double b, double h)
            {
                double[] resault = new double[3];
                var sum = 0d;
                var c = (b - a) / h;
                double f(double x) => x / (x - 1);

                // Лівий Трикутник    
                for (var i = 0; i <= h - 1; i++)
                {
                    var x = a + i * c;
                    sum += f(x);
                }              
                resault[0] = c * sum;
                sum = 0d;

                // Правий Трикутник
                for (var i = 1; i <= h; i++)
                {
                    var x = a + i * c;
                    sum += f(x);
                }             
                resault[1] = c * sum;
                sum = 0d;

                // Центральний Трикутник
                for (var i = 0; i < h; i++)
                {
                    var x = a + i / 2d * c;
                    sum += f(x);
                }
                resault[2] = c * sum;

                return resault;
            }                          
        }

        // Оголошуємо клас методу Трапецій
        public class TrapezoidMethod : IIntegral
        {
            public double[] Integrate(double a, double b, double h)
            {              
                var sum = 0d;             
                var c = (b - a) / h;

                for (int i = 0; i < h; i++)
                {
                    var xk = a + i * c;
                    var xk_1 = a + (i + 1) * c;
                    sum += (Math.Exp(Math.Sin(xk)) + Math.Exp(Math.Sin(xk_1)));
                }

                return new double[]
                {
                  sum * c / 2
                };
            }
        }

        // Оголошуємо клас методу Сімпсона
        public class SimpsonMethod : IIntegral
        {
            public double[] Integrate(double a, double b, double h)
            {               
                double f(double x) => x / (x - 1);
                var c = (b - a) / h;
                var sum1 = 0d;
                var sum2 = 0d; 
                
                for (var k = 1; k <= h; k++)
                {
                    var xk = a + k * c;
                    if (k <= h - 1)
                    {
                        sum1 += f(xk);
                    }

                    var xk_1 = a + (k - 1) * c;
                    sum2 += f((xk + xk_1) / 2);
                }

                return new double[]
                {
                    c / 3d * (1d / 2d * f(a) + sum1 + 2 * sum2 + 1d / 2d * f(b))
                };
            }
        
        }

        // Виводимо методи
        private void button_show_Click(object sender, EventArgs e)
        {
            // Створюємо масив для методу Прямокутників
            double[] result = new double[3];

            // Передаємо значення у методи
            a = (double)numeric1.Value;
            b = (double)numeric2.Value;
            h = (double)numeric3.Value;

            // Перевіряємо чекбокси для:
            // Методу Прямокутників
            if (radioButton1.Checked)
            {
                result = rectanglesMethod.Integrate(a, b, h);
                textBox1.Text = Convert.ToString(result[0]);
                textBox2.Text = Convert.ToString(result[1]);
                textBox3.Text = Convert.ToString(result[2]);
            }

            // Методу Трапецій
            if (radioButton2.Checked)
            {
                result = trapezoidMethod.Integrate(a, b, h);
                textBox1.Text = Convert.ToString(result[0]);
            }

            // Методу Сімпсона
            if (radioButton3.Checked)
            {
                result = simpsonMethod.Integrate(a, b, h);
                textBox1.Text = Convert.ToString(result[0]);
            }         
        }

        
    }
}
