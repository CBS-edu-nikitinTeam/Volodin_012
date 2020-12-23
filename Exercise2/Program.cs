using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Console.WriteLine("Вычислим площадь и периметр прямоугольника:");
            Console.WriteLine("Введите длину:");
            if (!double.TryParse(Console.ReadLine(), out double side1))
            {
                Console.WriteLine("Длина указана некоректно");
                return;
            }
            Console.WriteLine("Введите ширину:");
            if (!double.TryParse(Console.ReadLine(), out double side2))
            {
                Console.WriteLine("Ширина указана некорректно");
                return;
            }
            
            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Площадь равна {rectangle.AreaCalculator()}, периметр равен {rectangle.PerimeterCalculator()}");
        }
    }
}