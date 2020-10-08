using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace nextLab3
{
    public partial class Form1 : Form
    {
        Series sinusoidSeries;
        Series lineSeries;
        Series hermiteSeries;

        List<double> xDots;
        List<double> yDots;

        // інтервал між точками синусоїди
        double interval = 1;

        // кількість періодів синусоїди
        double periodNumber = 1;

        public Form1()
        {
            InitializeComponent();
            // ініціалізуємо два різних графіка
            // один для вхідних даних(синусоїди)
            // інші для вихідних (інтерполяції)
            sinusoidSeries = chart1.Series.Add("SinusoidData");
            sinusoidSeries.Color = Color.Blue;
            sinusoidSeries.ChartType = SeriesChartType.Point;

            lineSeries = chart1.Series.Add("LineData");
            lineSeries.ChartType = SeriesChartType.Point;
            lineSeries.Color = Color.Red;

            hermiteSeries = chart1.Series.Add("HermiteData");
            hermiteSeries.ChartType = SeriesChartType.Point;
            hermiteSeries.Color = Color.Green;

            // ініціалізуємо колекції для збереження точок синусоїди
            xDots = new List<double>();
            yDots = new List<double>();

            // створюємо синусоїду за заданими параметрами
            createSin(periodNumber, interval);
        }

        // метод для отримання вхідних даних
        void createSin(double periods, double interval)
        {
            // визначаємо довжину синусоїди
            double lenght = 2 * Math.PI * periods;
            // створюємо початкові знінні X та Y
            double x = 0;
            double y = 0;
            // додаємо координату (0 0) в колекції
            xDots.Add(x);
            yDots.Add(y);

            // створюємо та запам'ятовуємо координати точок синусоїди
            while (x < lenght)
            {
                x += interval;
                y = Math.Sin(x);
                xDots.Add(x);
                yDots.Add(y);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // очищаємо графік перед його заповненням
            sinusoidSeries.Points.Clear();
            lineSeries.Points.Clear();
            hermiteSeries.Points.Clear();

            int interpolationDotNumber = 0;

            Data data;

            if (showSinCheckBox.Checked)
            {
                sinusoidSeries.Points.DataBindXY(xDots, yDots);
            }

            if (showLineCheckBox.Checked)
            {
                // створюємо об'єкт для лінійної інтерполяції
                СInterpolation lineInterpolation = new LineInterpolation();

                // отримуємо кількість точок які будуть інтерпольовані
                interpolationDotNumber = (int)dotsUpDown.Value;

                // отримуємо інтервал через який будуємо інтерпольовані точки
                double interpolationInterval = interval / (interpolationDotNumber + 1);

                // перебираємо всі пари точок синусоїди
                for (int i = 0; i < xDots.Count; i++)
                {
                    // для кожної точки користувача інтерполюємо значення
                    for (int j = 1; j <= interpolationDotNumber; j++)
                    {
                        // визначаємо координати на осі Х для яких ми будемо шукати координати на осі У
                        double xFind = xDots[i] + (interpolationInterval * j);

                        if (i < (xDots.Count - 1))
                        {
                            // заповнюємо об'єкт Data потрібними значеннями
                            data = new Data(xDots[i], yDots[i], xDots[i + 1], yDots[i + 1], xFind);
                            // малюємо на графіку інтерполбовані точки
                            lineSeries.Points.AddXY(xFind, lineInterpolation.interpolation(data));
                        }
                    }
                }
            }

            if (showErmiteCheckBox.Checked)
            {
                // створюємо об'єкт для лінійної інтерполяції
                СInterpolation hermiteInterpolation = new HermiteInterpolation();

                // отримуємо кількість точок які будуть інтерпольовані
                interpolationDotNumber = (int)dotsUpDown.Value;

                // отримуємо інтервал через який будуємо інтерпольовані точки
                double interpolationInterval = interval / (interpolationDotNumber + 1);

                // перебираємо всі пари точок синусоїди
                for (int i = 0; i < xDots.Count; i++)
                {
                    // для кожної точки користувача інтерполюємо значення
                    for (int j = 1; j <= interpolationDotNumber; j++)
                    {
                        // визначаємо координати на осі Х для яких ми будемо шукати координати на осі У
                        double xFind = xDots[i] + (interpolationInterval * j);

                        // шукаємо значення k для конкретної точки
                        double k = ((interval * (1 / interval)) / (interpolationDotNumber + 1)) * j;

                        // перевіряємо чи ми не вийшли за межі графіка
                        if (i < (xDots.Count - 1))
                        {
                            // заповнюємо об'єкт Data потрібними значеннями
                            data = new Data(xDots[i], yDots[i], xDots[i + 1], yDots[i + 1], k);
                            // малюємо на графіку інтерполбовані точки
                            hermiteSeries.Points.AddXY(xFind, hermiteInterpolation.interpolation(data));
                        }
                    }
                }
            }
        }
    }

    class Data
    {
        private double coordinatesX1;
        private double coordinatesY1;
        private double coordinatesX2;
        private double coordinatesY2;
        private double findX;

        public Data() { }

        public Data(double coordinatesX1, double coordinatesY1, double coordinatesX2, double coordinatesY2, double findX)
        {
            this.coordinatesX1 = coordinatesX1;
            this.coordinatesY1 = coordinatesY1;
            this.coordinatesX2 = coordinatesX2;
            this.coordinatesY2 = coordinatesY2;
            this.findX = findX;
        }

        public double getCoordinatesX1()
        {
            return this.coordinatesX1;
        }

        public void setCoordinatesX1(double coordinate)
        {
            this.coordinatesX1 = coordinate;
        }

        public double getCoordinatesY1()
        {
            return this.coordinatesY1;
        }

        public void setCoordinatesY1(double coordinate)
        {
            this.coordinatesY1 = coordinate;
        }

        public double getCoordinatesX2()
        {
            return this.coordinatesX2;
        }

        public void setCoordinatesX2(double coordinate)
        {
            this.coordinatesX2 = coordinate;
        }

        public double getCoordinatesY2()
        {
            return this.coordinatesY2;
        }

        public void setCoordinatesY2(double coordinate)
        {
            this.coordinatesY2 = coordinate;
        }

        public double getFindX()
        {
            return this.findX;
        }

        public void setFindX(double coordinate)
        {
            this.findX = coordinate;
        }
    }

    abstract class СInterpolation
    {
        public abstract double interpolation(Data data);
    }

    class LineInterpolation : СInterpolation
    {
        // переоприділяємо метод для пошуку невідомих координат методом лінійної інтерполяції
        // формула лінійної інтерполяції
        // y = y1 + (y2 - y1) * (x - x1) / (x2 - x1)
        public override double interpolation(Data data)
        {
            return data.getCoordinatesY1() + (data.getCoordinatesY2() - data.getCoordinatesY1()) * (data.getFindX() - data.getCoordinatesX1()) / (data.getCoordinatesX2() - data.getCoordinatesX1());
        }
    }

    class HermiteInterpolation : СInterpolation
    {
        // проводимо хермітову інтерполяцію
        // формула: H3(x)=(1-3*k2+2*k3)*y0+(3*k2-2*k3)*y1+(k-2*k2+k3)*y'0+(-k2+k3)*y'1
        // k - це значення x для якого ми шукаємо інтерпольоване значення але належить відрізку [0; 1]
        // тобто якщо ми шукаємо значення y, для x, в межах [1; 2], для двох точок, з інтервалом синусоїди 0.5 тоді
        // x1 = 1; x2 = 2; dotCaunt = 2; i = 0.5; 
        // k = ((i * (1 / i)) / (dotCaunt + 1)) * номер точки
        public override double interpolation(Data data)
        {

            return (1 - 3 * Math.Pow(data.getFindX(), 2) + 2 * Math.Pow(data.getFindX(), 3)) * data.getCoordinatesY1() +
                (3 * Math.Pow(data.getFindX(), 2) - 2 * Math.Pow(data.getFindX(), 3)) * data.getCoordinatesY2() +
                (data.getFindX() - 2 * Math.Pow(data.getFindX(), 2) + Math.Pow(data.getFindX(), 3)) * Math.Cos(data.getCoordinatesX1()) +
                (-1 * Math.Pow(data.getFindX(), 2) + Math.Pow(data.getFindX(), 3)) * Math.Cos(data.getCoordinatesX2());

        }
    }
}
