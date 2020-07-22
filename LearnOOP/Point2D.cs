using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP
{
    public class Point2D
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point2D() { X = 0; Y = 0; }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public double GetDistanceTo(Point2D point1)
        {
            double result = Math.Sqrt(Math.Pow(X - point1.X, 2) + Math.Pow(Y - point1.Y, 2));
            return result;
        }
        public double GetVectorLength()
        {
            double length = GetDistanceTo(new Point2D(0, 0));
            return length;
        }


    }
}
