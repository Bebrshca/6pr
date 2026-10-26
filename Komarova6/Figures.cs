using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komarova6
{
    public class GeometricFigure
    {
        public double X { get; set; }
        public double Y { get; set; }

        public GeometricFigure(double x, double y)
        {
            X = x;
            Y = y;
        }

        public virtual string Draw()
        {
            return "Фигура: центр (" + X + "; " + Y + ")";
        }
    }

    // Окружность
    public class Circle : GeometricFigure
    {
        public double Radius { get; set; }

        public Circle(double x, double y, double radius) : base(x, y)
        {
            Radius = radius;
        }

        public override string Draw()
        {
            return "Окружность: центр (" + X + "; " + Y + "), радиус " + Radius;
        }
    }

    // Треугольник
    public class Triangle : GeometricFigure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double x, double y, double a, double b, double c) : base(x, y)
        {
            A = a;
            B = b;
            C = c;
        }

        public override string Draw()
        {
            return "Треугольник: центр (" + X + "; " + Y + "), стороны " + A + ", " + B + ", " + C;
        }
    }
}