using System;
using System.Text;

namespace BonusExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Address adr = new Address(); // Используем блок инициализатора. Если нужно задать
                                         // начальное значение свойствам.  
            adr.Index = 404;
            adr.Country = "Some country";
            adr.City = "Some city";
            adr.Street = "Some street";
            adr.House = "1A";
            adr.Apartment = 101;

            Console.WriteLine("Адрес:");
            Console.WriteLine($"Индекс: {adr.Index}");
            Console.WriteLine(new StringBuilder().Append(
                "Адрес:").Append(Environment.NewLine).Append(
                $"Индекс: {adr.Index}").Append(Environment.NewLine).Append(
                $"Страна: {adr.Country}").Append(Environment.NewLine).Append(
                $"Город: {adr.City}").Append(Environment.NewLine).Append(
                $"Улица: {adr.Street}").Append(Environment.NewLine).Append(
                $"Дом: {adr.House}").Append(Environment.NewLine).Append(
                $"Квартира: {adr.City}").Append(Environment.NewLine).ToString());
        }
    }
}