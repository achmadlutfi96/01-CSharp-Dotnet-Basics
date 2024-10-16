using System;

namespace _02ConsoleClassMethodsPropertiesCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Console Class");
            //Console.Title = "Achmad Lutfi";
            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            ConsoleKeyInfo k = Console.ReadKey();
            Console.WriteLine($"\n{k.Key} {k.KeyChar}");
        }
    }
}
