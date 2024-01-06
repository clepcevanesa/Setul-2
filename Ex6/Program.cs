//Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 

using System;

class VerificareOrdineCrescatoare
{
    static void Main()
    {
        Console.Write("Introduceti numarul de elemente in secventa: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] secventa = new int[n];

        Console.WriteLine("Introduceti elementele secventei:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elementul {i + 1}: ");
            secventa[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Verificarea dacă secvența este în ordine crescătoare
        bool esteCrescatoare = VerificaOrdineCrescatoare(secventa);

        // Afișarea rezultatului
        if (esteCrescatoare)
        {
            Console.WriteLine("Secventa este in ordine crescatoare.");
        }
        else
        {
            Console.WriteLine("Secventa nu este in ordine crescatoare.");
        }
    }

    // Funcția care verifică dacă secvența este în ordine crescătoare
    static bool VerificaOrdineCrescatoare(int[] secventa)
    {
        for (int i = 0; i < secventa.Length - 1; i++)
        {
            if (secventa[i] > secventa[i + 1])
            {
                return false;
            }
        }
        return true;
    }
}
