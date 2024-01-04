//Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 

using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int lungimeSecventa = int.Parse(Console.ReadLine());

        int[] secventa = new int[lungimeSecventa];
        int numerePare = 0;

        for (int i = 0; i < lungimeSecventa; i++)
        {
            Console.Write($"Introduceti numarul {i + 1}: ");
            secventa[i] = int.Parse(Console.ReadLine());

            if (secventa[i] % 2 == 0)
            {
                numerePare++;
            }
        }

        Console.WriteLine($"In secventa data sunt {numerePare} numere pare.");
    }
}
