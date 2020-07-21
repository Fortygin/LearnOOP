using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP
{
    class Point2D
    {
        private double _x { get; set; }
        private double _y { get; set; }


        public Point2D() { _x = 0; _y = 0; }

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double GetDistanceTo(Point2D point1, Point2D point2) 
        {
            double result = Math.Sqrt((point1._x - point2._x) * (point1._x - point2._x) + (point1._y - point2._y) * (point1._y - point2._y));
            return result;
        }

        public double GetVectorLength(double x1, double y1, double x2, double y2)
        {
            double length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            return length;
        }

        public override string ToString()
        {
            return base.ToString();
        }





    }
}
