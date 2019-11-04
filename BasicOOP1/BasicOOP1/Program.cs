using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint p1 = new MyPoint(1, 2);
            // MyPoint p2 = new MyPoint(2, 4);
            // MyPoint p3 = new MyPoint(3, 6);
            // Console.WriteLine(p1.distance(5, 6));
            //Console.WriteLine(p1.distance(p2));
            // Console.WriteLine(p1.distance());
            // p1.setXY(3, 0);
            Console.WriteLine(p1.getXY()[0]);
            Console.WriteLine(p1.getXY()[1]);
            //Console.WriteLine(p1);
            //MyPoint[] points = new MyPoint[10];
            //for(int i = 0; i < points.Length; i++)
            //{
            //    points[i] = new MyPoint(i+1,i+1);
            //    Console.WriteLine(points[i]);
            //}

            //MyCircle c1 = new MyCircle();
            //MyCircle c2 = new MyCircle(p2,1);
            //c1.setCenterXY(2, 3);
            //Console.WriteLine(c1.getCenterX());
            //Console.WriteLine(c1.distance(c2));
            //Console.WriteLine(c1.getArea());
            //Console.WriteLine(c1.getCircumference());

            // MyTriangle mt = new MyTriangle(p1, p2, p3);
            //  Console.WriteLine("Perimeter of MyTriangle is: " +mt.getPerimeter() + " and type of: " + mt.getType());

        }
    }
}
