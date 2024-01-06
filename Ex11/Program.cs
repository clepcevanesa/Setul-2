//Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti numarul de elemente din secventa:");
        int n = int.Parse(Console.ReadLine());

        double sumaInverselor = 0.0;

        Console.WriteLine("Introduceti secventa de numere:");

        for (int i = 0; i < n; i++)
        {
            double numar = double.Parse(Console.ReadLine());
            sumaInverselor += 1.0 / numar;
        }

        Console.WriteLine($"Suma inverselor este: {sumaInverselor}");
    }
}
