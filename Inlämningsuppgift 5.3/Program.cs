using System;

namespace uppgift_5._3
{
    class program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[3];
            Console.WriteLine("skriv in 3 heltal");
            tal[0] = int.Parse(Console.ReadLine());
            tal[1] = int.Parse(Console.ReadLine());
            tal[2] = int.Parse(Console.ReadLine());
            int summa = tal[0] + tal[1] + tal[2];
            Console.WriteLine("summan av talen är; " + summa);
            Console.Read();
        }
    }
}