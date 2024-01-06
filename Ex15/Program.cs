//O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. 

using System;

class Program
{
    static bool IsBitonic(int[] arr, int n)
    {
        int i = 1;

        while (i < n && arr[i] > arr[i - 1])
        {
            i++;
        }

        while (i < n && arr[i] < arr[i - 1])
        {
            i++;
        }

        // Dacă i este egal cu lungimea secvenței, înseamnă că este bitonică
        return i == n;
    }

    static void Main()
    {
        int[] sequence = { 1, 2, 2, 3, 5, 4, 4, 3 };
        int length = sequence.Length;

        bool isBitonic = IsBitonic(sequence, length);

        if (isBitonic)
        {
            Console.WriteLine("Secventa data este bitonica.");
        }
        else
        {
            Console.WriteLine("Secventa data nu este bitonica.");
        }
    }
}
