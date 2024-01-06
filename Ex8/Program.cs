//Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...

using System;

class Fibonacci
{
    static int FibonacciNumber(int n)
    {
        if (n <= 0)
            return 0;
        else if (n == 1)
            return 1;
        else
        {
            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }

    static void Main()
    {
        Console.WriteLine("Introduceti n pentru a calcula al n-lea numar din sirul lui Fibonacci:");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = FibonacciNumber(n);
        Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este: {result}");
    }
}
