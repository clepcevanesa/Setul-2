//O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. 

using System;

class Program
{
    static bool EsteSecventaMonotonaRotita(int[] nums)
    {
        int n = nums.Length;
        bool crescatoare = false;
        bool descrescatoare = false;

        // Verificăm dacă secvența este strict crescătoare sau strict descrescătoare
        for (int i = 1; i < n; i++)
        {
            if (nums[i] > nums[i - 1])
                crescatoare = true;
            else if (nums[i] < nums[i - 1])
                descrescatoare = true;
        }

        return (crescatoare && !descrescatoare) || (!crescatoare && descrescatoare);
    }

    static void Main()
    {
        int[] secventa = { 4, 5, 6, 7, 1, 2, 3 }; 
        bool esteMonotonaRotita = EsteSecventaMonotonaRotita(secventa);

        if (esteMonotonaRotita)
            Console.WriteLine("Secventa este o secventa monotonica rotita.");
        else
            Console.WriteLine("Secventa NU este o secventa monotonica rotita.");
    }
}
