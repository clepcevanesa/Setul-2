//Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. 

using System;

class MainClass
{
    static void Main()
    {
        int n = 10; 
        int[] secventa = new int[n];

        for (int i = 0; i < n; i++)
        {
            secventa[i] = i; 
        }

        // Afișați elementele care sunt egale cu poziția lor în secvență
        Console.WriteLine("Elementele care sunt egale cu pozitia lor in secventa sunt:");
        for (int i = 0; i < n; i++)
        {
            if (secventa[i] == i)
            {
                Console.WriteLine($"Elementul {secventa[i]} se afla pe pozitia {i} în secventa.");
            }
        }
    }
}
