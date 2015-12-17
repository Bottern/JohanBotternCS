using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning6
{
    class Program
    {
        static void Main(string[] args)
        {
            PointMethod();
            MyDoubleTypeMethod();
        }

        private static void MyDoubleTypeMethod()
        {
            MyDoubleType myDoubleType = new MyDoubleType(5);
            MyDoubleType myDoubleType2 = myDoubleType + 5;
            MyDoubleType myDoubleType3 = myDoubleType + myDoubleType2;
            MyDoubleType myDoubleType4 = new MyDoubleType(5);
            Console.WriteLine("{0}, {1}, {2},{3},{4}", myDoubleType, myDoubleType2, myDoubleType3, myDoubleType > myDoubleType2, myDoubleType == myDoubleType4);
            Console.ReadLine();
        }

        private static void PointMethod()
        {
            Point3D point3D = new Point3D(50, 52, 54);
            Console.WriteLine($"Point3D: {point3D.Z}");

            Point point = (Point)point3D;
            Console.WriteLine($"Point:{point.X}, {point.Y}");

            Point3D point3D1 = (Point3D)point;
            Console.WriteLine($"Point3D: {point3D1.Z}");
        }
    }
}
