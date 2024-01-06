//Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 

using System;

class Program
{
    static int FindPosition(int[] sequence, int numberToFind)
    {
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] == numberToFind)
            {
                return i; // Returnează poziția numărului găsit în secvență
            }
        }
        return -1; // Returnează -1 dacă numărul nu a fost găsit în secvență
    }

    static void Main()
    {
        int[] numbers = { 2, 5, 8, 10, 13, 6, 4 }; // Secvența dată de numere
        int numberToFind = 13; // Numărul căutat în secvență
        int position = FindPosition(numbers, numberToFind);

        if (position != -1)
        {
            Console.WriteLine($"Numarul {numberToFind} se afla pe pozitia {position} in secventa.");
        }
        else
        {
            Console.WriteLine($"Numarul {numberToFind} nu se afla in secventa.");
        }
    }
}
