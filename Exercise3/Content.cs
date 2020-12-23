using System;

namespace Exercise3
{
    public class Content : IShowable
    {
        public string Name { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Name);
        }
    }
}