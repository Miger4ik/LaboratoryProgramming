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
            const int NUMBER_OF_PERIODS = 1;
            const int NUMBER_OF_POINTS_PER_PERIOD = 9;
            public const int NUMBER_OF_POINTS = NUMBER_OF_POINTS_PER_PERIOD * NUMBER_OF_PERIODS;
            const int AMPLITUDE = 1;
            const double PHASE = 0;
            const double PERIOD = 2 * Math.PI;

            public static Point[] defaultPointsForInterpolation = new Point[NUMBER_OF_POINTS];

            static СInterpolation()
            {
                FillDefaultPointsArrayWithSinusoidalValues();
            }
            private static void FillDefaultPointsArrayWithSinusoidalValues()
            {
                double step = PERIOD / (NUMBER_OF_POINTS_PER_PERIOD-1);
                double x = 0;
                for (int i = 0; i < NUMBER_OF_POINTS; i++)
                {
                    double y = AMPLITUDE * Math.Sin((2 * Math.PI / PERIOD) * x + PHASE);
                    defaultPointsForInterpolation[i] = new Point(x, y);
                    x += step;
                }
            }
            protected abstract void InterpolatePoints();
        }

        class LineInterpolation : СInterpolation
        {
            const int NUMBER_OF_POINTS_BETWEEN_TWO_SINUSOIDA_POINTS = 10;
            public Point[,] interpolatedSegmentsOfPoints = new Point[NUMBER_OF_POINTS - 1, NUMBER_OF_POINTS_BETWEEN_TWO_SINUSOIDA_POINTS];

            public LineInterpolation()
            {
                InterpolatePoints();
            }
            protected override void InterpolatePoints()
            {
                double step = (defaultPointsForInterpolation[1].x - defaultPointsForInterpolation[0].x) / (NUMBER_OF_POINTS_BETWEEN_TWO_SINUSOIDA_POINTS - 1);
                double x = 0;
                for (int i = 0; i < NUMBER_OF_POINTS - 1; i++)
                {
                    x = defaultPointsForInterpolation[i].x;
                    for (int j = 0; j < NUMBER_OF_POINTS_BETWEEN_TWO_SINUSOIDA_POINTS; j++)
                    {
                        double y = defaultPointsForInterpolation[i].y + (x - defaultPointsForInterpolation[i].x) * (defaultPointsForInterpolation[i + 1].y - defaultPointsForInterpolation[i].y) / (defaultPointsForInterpolation[i + 1].x - defaultPointsForInterpolation[i].x);
                        interpolatedSegmentsOfPoints[i, j] = new Point(x, y);
                        x += step;
                    }
                }
            }
        }

        class HermiteInterpolation : СInterpolation
        {
            const int NUMBER_OF_POINTS_BETWEEN_TWO_SINUSOIDA_POINTS = 10;
            public Point[,] interpolatedSegmentsOfPoints = new Point[NUMBER_OF_POINTS-1, NUMBER_OF_POINTS_BETWEEN_TWO_SINUSOIDA_POINTS];

            public HermiteInterpolation()
            {
                InterpolatePoints();
            }

            protected override void InterpolatePoints()
            {
                double step;

                Point v, w; // Вектора
                double x, y;    

                for (int i = 0; i < NUMBER_OF_POINTS - 1; i++)
                {
                    Point Ap; //Точка перед А
                    Point A;  //Начальная точка отрезка
                    Point B;  //Конечная точка отрезка
                    if (i == 0)
                        Ap = new Point(0, 0);
                    else Ap = defaultPointsForInterpolation[i - 1];
                    A = defaultPointsForInterpolation[i];
                    B = defaultPointsForInterpolation[i + 1];
                    //Находим вектор который соответствует направлению точки А
                    v = new Point(A.x- Ap.x, A.y - Ap.y);
                    //Находим вектор который соответствует направлению точки Б
                    w = new Point(B.x - A.x, B.y - A.y);

                    //Ищем коефициенты первого многочлена (для оси Х)
                    double xn1 = A.x;
                    double xn2 = v.x;
                    double xn3 = ((-3) * A.x) + (3 * B.x) + ((-2) * v.x) + ((-1) * w.x);
                    double xn4 = (2 * A.x) + ((-2) * B.x) + v.x + w.x;

                    //Ищем коефициенты второго многочлена (для оси Y)
                    double yn1 = A.y;
                    double yn2 = v.y;
                    double yn3 = ((-3) * A.y) + (3 * B.y) + ((-2) * v.y) + ((-1) * w.y);
                    double yn4 = (2 * A.y) + ((-2) * B.y) + v.y + w.y;

                    //
                    double step1 = 1 / ((double)NUMBER_OF_POINTS_BETWEEN_TWO_SINUSOIDA_POINTS);

                    for (int j = 0; j < NUMBER_OF_POINTS_BETWEEN_TWO_SINUSOIDA_POINTS; j++)
                    {
                        //Значение step должно находится в пределах от 0 до 1, 
                        //где 0 - это точка А, 1 - Точка Б, например 0,5 - это точка между точкой А и точкой Б 
                        step = step1 * (j);
                        //Подставляем значение step (или же n) в формулу.
                        x = xn1 + xn2 * step + xn3 * (step * step) + xn4 * (step * step * step);
                        y = yn1 + yn2 * step + yn3 * (step * step) + yn4 * (step * step * step);
                        interpolatedSegmentsOfPoints[i, j] = new Point(x, y);
                    }
                }
            }
        }

        public InterpolationForm()
        {
            InitializeComponent();
            DrawDefaultPoints();
            LineInterpolation LineInterpolator = new LineInterpolation();
            DrawLineInterpolatedPoints(LineInterpolator);
            HermiteInterpolation HermiteInterpolator = new HermiteInterpolation();
            DrawHermiteInterpolatedPoints(HermiteInterpolator);
        }

        private void DrawDefaultPoints()
        {
            foreach (Point defaultPoint in СInterpolation.defaultPointsForInterpolation)
            {
                InterpolationChart.Series[0].Points.AddXY(defaultPoint.x, defaultPoint.y);
            }
        }

        private void DrawLineInterpolatedPoints(LineInterpolation LineInterpolator)
        {
            foreach (Point lineInterpolatedPoint in LineInterpolator.interpolatedSegmentsOfPoints)
            {
                InterpolationChart.Series[1].Points.AddXY(lineInterpolatedPoint.x, lineInterpolatedPoint.y);
            }
        }

        private void DrawHermiteInterpolatedPoints(HermiteInterpolation HermiteInterpolator)
        {
            foreach (Point hermiteInterpolatedPoint in HermiteInterpolator.interpolatedSegmentsOfPoints)
            {
                InterpolationChart.Series[2].Points.AddXY(hermiteInterpolatedPoint.x, hermiteInterpolatedPoint.y);
            }
        }

        private void ShowPointsButton_Click(object sender, EventArgs e)
        {
            List<int> seriesToShow = new List<int>();
            List<int> seriesToHide = new List<int>();

            if (DefaultPointsCheckBox.Checked)
            {
                seriesToShow.Add(0);
            }
            else
            {
                seriesToHide.Add(0);
            }

            if (LinearInterpolationCheckBox.Checked)
            {
                seriesToShow.Add(1);
            }
            else
            {
                seriesToHide.Add(1);
            }

            if (HermiteInterpolationCheckBox.Checked)
            {
                seriesToShow.Add(2);
            }
            else
            {
                seriesToHide.Add(2);
            }

            ShowCheckedPoints(seriesToShow);
            HideUncheckedPoints(seriesToHide);
        }

        private void ShowCheckedPoints(List<int> seriesToShow)
        {
            foreach(int serie in seriesToShow)
            {
                InterpolationChart.Series[serie].Enabled = true;
            }
           
        }
        
        private void HideUncheckedPoints(List<int> seriesToHide)
        {
            foreach (int serie in seriesToHide)
            {
                InterpolationChart.Series[serie].Enabled = false;
            }
        }
    }
}
