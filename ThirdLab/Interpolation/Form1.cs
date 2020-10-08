using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Interpolation
{
    public partial class InterpolationForm : Form
    {
        class Point
        {
            public double x;
            public double y;

            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
        }

        abstract class СInterpolation
        {
            // Дані для створення Синусоїди
            const int Period = 1;
            // Кількість точок
            const int PeriodPoints = 9;
            public const int PointsAmount = PeriodPoints * Period;
            const int Am = 1;
            const double Phase = 0;
            const double MathPeriod = 2 * Math.PI;

            public static Point[] defaultPoints = new Point[PointsAmount];

            // Помістимо усі данні у один клас
            static СInterpolation()
            {
                SinusoidalValues();
            }

            private static void SinusoidalValues()
            {
                double step = MathPeriod / (PeriodPoints - 1);
                double x = 0;

                for (int i = 0; i < PointsAmount; i++)
                {
                    double y = Am * Math.Sin((2 * Math.PI / MathPeriod) * x + Phase);
                    defaultPoints[i] = new Point(x, y);
                    x += step;
                }
            }
            protected abstract void InterpolatePoints();
        }

        class LineInterpolation : СInterpolation
        {
            // Кількість точок  і проміжків між ними
            const int SinPointsAmount = 10;
            public Point[,] interpolatedSegmentsOfPoints = new Point[PointsAmount - 1, SinPointsAmount];

            public LineInterpolation()
            {
                InterpolatePoints();
            }

            // Реалізуєм Лінійну Інтерполяцію
            protected override void InterpolatePoints()
            {
                double step = (defaultPoints[1].x - defaultPoints[0].x) / (SinPointsAmount - 1);
                double x = 0;
                for (int i = 0; i < PointsAmount - 1; i++)
                {
                    x = defaultPoints[i].x;
                    for (int j = 0; j < SinPointsAmount; j++)
                    {
                        double y = defaultPoints[i].y + (x - defaultPoints[i].x) * (defaultPoints[i + 1].y - defaultPoints[i].y) / (defaultPoints[i + 1].x - defaultPoints[i].x);
                        interpolatedSegmentsOfPoints[i, j] = new Point(x, y);
                        x += step;
                    }
                }
            }
        }

        //class HermiteInterpolation : СInterpolation
        //{

        //} 


        public InterpolationForm()
        {
            InitializeComponent();
            DrawPoints();

            LineInterpolation LineInterpolator = new LineInterpolation();
            DrawLineInterpolatedPoints(LineInterpolator);

            //HermiteInterpolation HermiteInterpolator = new HermiteInterpolation();
            //DrawHermiteInterpolatedPoints(HermiteInterpolator);
        }

        // Малюємо точки на чарті
        private void DrawPoints()
        {
            foreach (Point defaultPoint in СInterpolation.defaultPoints)
            {
                chart1.Series[0].Points.AddXY(defaultPoint.x, defaultPoint.y);
            }
        }

        // Малюэмо Лінійну Інтерполяцію на чарті
        private void DrawLineInterpolatedPoints(LineInterpolation LineInterpolator)
        {
            foreach (Point lineInterpolatedPoint in LineInterpolator.interpolatedSegmentsOfPoints)
            {
                chart1.Series[1].Points.AddXY(lineInterpolatedPoint.x, lineInterpolatedPoint.y);
            }
        }

        //private void DrawHermiteInterpolatedPoints(HermiteInterpolation HermiteInterpolator)
        //{   

        //}


        // Cтворюємо список вибору
        private void button1_Click(object sender, EventArgs e)
        {
            panelLeft.Height = ShowPointsButton.Height;
            panelLeft.Top = ShowPointsButton.Top;

            List<int> seriesToShow = new List<int>();
            List<int> seriesToHide = new List<int>();

            if (DefaultPoints.Checked)
            {
                seriesToShow.Add(0);
            }

            else
            {
                seriesToHide.Add(0);
            }

            if (LinearInterpolation.Checked)
            {
                seriesToShow.Add(1);
            }

            else
            {
                seriesToHide.Add(1);
            }

            if (HermiteInterpolation.Checked)
            {
                seriesToShow.Add(2);
            }

            else
            {
                seriesToHide.Add(2);
            }

            ShowPoints(seriesToShow);
            HidePoints(seriesToHide);
        }

        // Видаляє точки
        private void HidePoints(List<int> seriesToHide)
        {
            foreach (int serie in seriesToHide)
            {
                chart1.Series[serie].Enabled = false;
            }
        }

        // Відображає точки
        private void ShowPoints(List<int> seriesToShow)
        {
            foreach (int serie in seriesToShow)
            {
                chart1.Series[serie].Enabled = true;
            }

        }
   
    }
}
