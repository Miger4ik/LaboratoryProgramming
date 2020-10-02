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

        private IIntegral integralRectangles = new IntegralRectangles();
        private IIntegral integralTrapezoid = new IntegralTrapezoid();
        private IIntegral integralSimpson = new IntegralSimpson();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIntegrate_Click(object sender, EventArgs e)
        {
            a = (double)numericA.Value;
            b = (double)numericB.Value;
            h = (double)numericH.Value;

            integralRectangles.Integrate(a, b, h);
            integralTrapezoid.Integrate(a, b, h);
            integralSimpson.Integrate(a, b, h);
        }
    }

    public interface IIntegral
    {
        void Integrate(double a, double b, double h);
    }

    public class IntegralRectangles : IIntegral
    {
        public void Integrate(double a, double b, double h)
        {
            
        }
    }

    public class IntegralTrapezoid : IIntegral
    {
        public void Integrate(double a, double b, double h)
        {

        }
    }

    public class IntegralSimpson : IIntegral
    {
        public void Integrate(double a, double b, double h)
        {

        }
    }
}
