//Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 

using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] secventa = new int[n];

        // Citirea secventei de numere
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Determinarea celei mai mari valori
        int max = secventa[0];
        for (int i = 1; i < n; i++)
        {
            if (secventa[i] > max)
            {
                max = secventa[i];
            }
        }

        // Determinarea celei mai mici valori
        int min = secventa[0];
        for (int i = 1; i < n; i++)
        {
            if (secventa[i] < min)
            {
                min = secventa[i];
            }
        }

        Console.WriteLine($"Cea mai mare valoare din secventa este: {max}");
        Console.WriteLine($"Cea mai mica valoare din secventa este: {min}");

        Console.ReadLine();
    }
}
