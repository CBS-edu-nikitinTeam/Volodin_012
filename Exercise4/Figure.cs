using System;
using System.Collections.Generic;

namespace Exercise4
{
    public class Figure
    {
        private List<Point> points = new List<Point>();

        public Figure(Point a, Point b, Point c)
        {
            points.Add(a); 
            points.Add(b); 
            points.Add(c); 
        }

        public Figure(Point a, Point b, Point c, Point d) : this(a, b, c)
        {
            points.Add(d);
        }

        public Figure(Point a, Point b, Point c, Point d, Point e) : this(a, b, c, d)
        {
            points.Add(e);
        }

        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt((Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2)));
        }

        public void PerimeterCalculator()
        {
            double perimeter = default;
            string perimeterName = string.Empty;

            for (int i = 0; i < points.Count; i++)
            {
                if (i + 1 == points.Count)
                {
                    perimeter += LengthSide(points[i], points[0]);
                    perimeterName = string.Concat(perimeterName, $"{points[i].Name}{points[0].Name}");
                }
                else
                {
                    perimeter += LengthSide(points[i], points[i + 1]);
                    perimeterName = string.Concat(perimeterName, $"{points[i].Name}{points[i + 1].Name}, ");
                }
            }
            
            Console.WriteLine($"Периметр многоугольника со сторонами {perimeterName} равен {perimeter}");
        }
    }
}