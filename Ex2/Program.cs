//Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 

using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int lungime = Convert.ToInt32(Console.ReadLine());

        int negative = 0, zero = 0, pozitive = 0;

        Console.WriteLine("Introduceti secventa de numere:");
        for (int i = 0; i < lungime; i++)
        {
            int numar = Convert.ToInt32(Console.ReadLine());

            if (numar < 0)
            {
                negative++;
            }
            else if (numar == 0)
            {
                zero++;
            }
            else
            {
                pozitive++;
            }
        }

        Console.WriteLine($"Numere negative: {negative}");
        Console.WriteLine($"Numere zero: {zero}");
        Console.WriteLine($"Numere pozitive: {pozitive}");

        Console.ReadKey();
    }
}
