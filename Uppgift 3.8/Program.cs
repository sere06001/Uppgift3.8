using System;
namespace Uppgift3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett ord.");
            string ord1 = Console.ReadLine();
            Console.WriteLine("Skriv ett andra ord.");
            string ord2 = Console.ReadLine();
            Console.WriteLine("Skriv ett tredje ord.");
            string ord3 = Console.ReadLine();

            List<string> lista = new List<string>();
            lista.Add(ord1);
            lista.Add(ord2);
            lista.Add(ord3);
            lista.Sort();
            Console.WriteLine($"{lista[0]} är det ordet som kommer först i bokstavs ordning.");
            Console.ReadKey();
        }
    }
}