//O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. 

using System;

class MainClass
{
    static bool IsRotatedIncreasingSequence(int[] arr)
    {
        int n = arr.Length;

        // Cautăm poziția minimă în șir
        int minIndex = 0;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] < arr[minIndex])
            {
                minIndex = i;
            }
        }

        // Verificăm dacă secvența este crescătoare
        bool increasing = true;
        for (int i = 0; i < n; i++)
        {
            int index = (i + minIndex) % n;
            int nextIndex = (index + 1) % n;

            if (arr[index] > arr[nextIndex])
            {
                increasing = false;
                break;
            }
        }

        return increasing;
    }

    public static void Main(string[] args)
    {
        int[] sequence = { 4, 5, 6, 7, 1, 2, 3 };

        bool isRotatedIncreasing = IsRotatedIncreasingSequence(sequence);

        if (isRotatedIncreasing)
        {
            Console.WriteLine("Secventa este o secventa crescatoare rotita.");
        }
        else
        {
            Console.WriteLine("Secventa NU este o secventa crescatoare rotita.");
        }
    }
}
