using System;
using System.Collections.Generic;
using System.Linq;

namespace MakeaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(GetArea(radius));
            //Console.WriteLine(GetPerimeter(radius));

            int i=0;
            Circle[] circles = new Circle[100];
            for (int radius = 0; radius < 100; radius++)
            {
                var circleA = new Circle(radius);
                Console.WriteLine(circleA.Perimeter);

                i++;
                circles[i] = circleA;

            }
            Console.WriteLine(circles[5].Area);



            var lotsOfCircles = GenerateCircles().ToArray();
            var evenMoreCircles = Enumerable.Range(0, 1000).Select(rad => new Circle(rad)).ToArray();

            var sortedByArea =
                from circle in evenMoreCircles
                where circle.Perimeter > 50
                orderby circle.Area
                select circle;
        }

        public static IEnumerable<Circle> GenerateCircles()
        {
            for (int r = 0; r < 100; r++)
            {
                yield return new Circle(r);
            }
        }

        //static double GetArea(double radius)
        //{
        //    return Math.PI * radius * radius;
        //}
        //static double GetPerimeter(double radius)
        //{
        //    return Math.PI * 2 * radius;
        //}
    }
    public class Circle
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Area => Math.PI * this.radius * this.radius;
        public double Perimeter => 2 * Math.PI * this.radius;
    }
    public class Square
    {
        private double _width;
        public Square(double width)
        {
            this._width = width;
        }
        public double GetArea() => _width * _width;
        public double GetPerimeter() => 4 * _width;
    }
}

