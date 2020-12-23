using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            new Figure(
                new Point(1, 3, "A"),
                new Point(4, 7, "B"),
                new Point(4, 3, "C")).PerimeterCalculator();
        }
    }
}