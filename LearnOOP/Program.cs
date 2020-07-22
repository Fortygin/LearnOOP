using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            Point2D point2D = new Point2D();
            Point2D point2D1 = new Point2D(23, 32);
            Console.WriteLine(point2D.X);
            Console.WriteLine(point2D1.Y);
            Console.WriteLine(point2D);
            Console.WriteLine(point2D1);
            Console.WriteLine(point2D.GetDistanceTo(point2D));
            Console.WriteLine(new Point2D(2,0).GetVectorLength());
            Console.ReadKey();
        }
    }
}
