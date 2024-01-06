//Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 

using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int n = int.Parse(Console.ReadLine());

        int[] sequence = new int[n];

        Console.WriteLine("Introduceti elementele secventei:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elementul {i + 1}: ");
            sequence[i] = int.Parse(Console.ReadLine());
        }

        // Găsirea numărului maxim de numere consecutive egale
        int maxCount = 1;
        int currentCount = 1;

        for (int i = 1; i < n; i++)
        {
            if (sequence[i] == sequence[i - 1])
            {
                currentCount++;
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            else
            {
                currentCount = 1;
            }
        }

        Console.WriteLine($"Numarul maxim de numere consecutive egale: {maxCount}");
    }
}
