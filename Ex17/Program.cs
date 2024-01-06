//Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta.

using System;

class Program
{
    static int MaxParenthesisNesting(string sequence)
    {
        int maxDepth = 0;
        int currentDepth = 0;

        foreach (char c in sequence)
        {
            if (c == '0')
            {
                currentDepth++;
                if (currentDepth > maxDepth)
                {
                    maxDepth = currentDepth;
                }
            }
            else if (c == '1')
            {
                if (currentDepth == 0)
                {
                    return -1; // Secvența este incorectă
                }
                currentDepth--;
            }
            else
            {
                return -1; // Caracter invalid în secvență
            }
        }

        if (currentDepth != 0)
        {
            return -1; // Secvența este incorectă
        }

        return maxDepth;
    }

    static void Main()
    {
        Console.WriteLine("Introduceti secventa de 0 și 1 separate prin spatiu:");
        string inputSequence = Console.ReadLine();

        int maxNestingLevel = MaxParenthesisNesting(inputSequence.Replace(" ", ""));

        if (maxNestingLevel != -1)
        {
            Console.WriteLine($"Secventa este corecta si nivelul maxim de inchidere este: {maxNestingLevel}");
        }
        else
        {
            Console.WriteLine("Secvenaa introdusa este incorecta!");
        }
    }
}
