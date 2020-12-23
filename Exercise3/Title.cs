using System;

namespace Exercise3
{
    public class Title : IShowable
    {
        public string Name { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Name);
        }
    }
}