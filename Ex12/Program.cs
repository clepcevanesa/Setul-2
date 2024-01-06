//Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 

using System;

class NumarGrupuriConsecutive
{
    static void Main()
    {
        int[] secventa = { 1, 2, 0, 6, 3, 4, 5, 0, 0, 6, 7, 0, 0 };
        int numarGrupuri = NumarGrupuriConsecutiveNonZero(secventa);
        Console.WriteLine($"Numarul de grupuri de numere consecutive diferite de zero este: {numarGrupuri}");
    }

    static int NumarGrupuriConsecutiveNonZero(int[] secventa)
    {
        int numarGrupuri = 0;
        bool inGrup = false;

        foreach (int numar in secventa)
        {
            if (numar != 0)
            {
                if (!inGrup)
                {
                    inGrup = true;
                    numarGrupuri++;
                }
            }
            else
            {
                inGrup = false;
            }
        }

        return numarGrupuri;
    }
}
