using System;

namespace Exercise3
{
    public class Author : IShowable
    {
        public string Name { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Name);
        }
    }
}