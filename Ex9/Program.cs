//Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 

using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int n = int.Parse(Console.ReadLine());

        int[] secventa = new int[n];

        Console.WriteLine("Introduceti elementele secventei:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elementul {i + 1}: ");
            secventa[i] = int.Parse(Console.ReadLine());
        }

        // Verificarea dacă secvența este monoton crescătoare sau descrescătoare
        bool monotonCrescatoare = true;
        bool monotonDescrescatoare = true;

        for (int i = 1; i < n; i++)
        {
            if (secventa[i] < secventa[i - 1])
            {
                monotonCrescatoare = false;
            }

            if (secventa[i] > secventa[i - 1])
            {
                monotonDescrescatoare = false;
            }
        }

        // Verificarea rezultatului și afișarea acestuia
        if (monotonCrescatoare)
        {
            Console.WriteLine("Secventa este monoton crescatoare.");
        }
        else if (monotonDescrescatoare)
        {
            Console.WriteLine("Secventa este monoton descrescatoare.");
        }
        else
        {
            Console.WriteLine("Secventa nu este monotona.");
        }
    }
}
