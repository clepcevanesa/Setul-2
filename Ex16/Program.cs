//O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 

using System;

class Program
{
    static bool IsRotatedBitonicSequence(int[] arr)
    {
        int n = arr.Length;
        int maxIndex = 0;

        // Găsește indexul maximului din secvență
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > arr[maxIndex])
            {
                maxIndex = i;
            }
        }

        // Verifică dacă secvența este bitonică rotită
        bool increasing = true;
        for (int i = 0; i < n; i++)
        {
            int index = (maxIndex + i) % n;
            int nextIndex = (maxIndex + i + 1) % n;

            if (arr[index] > arr[nextIndex])
            {
                increasing = false;
                break;
            }
        }

        return increasing;
    }

    static void Main()
    {
        int[] sequence = { 4, 5, 6, 7, 8, 2, 3 }; 

        bool isBitonicRotated = IsRotatedBitonicSequence(sequence);

        if (isBitonicRotated)
        {
            Console.WriteLine("Secventa este o secventa bitonica rotita.");
        }
        else
        {
            Console.WriteLine("Secventa NU este o secventa bitonica rotita.");
        }
    }
}

