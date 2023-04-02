

using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 4;
        PrintNumbers(n);
    }

    static void PrintNumbers(int n)
    {
        if (n == 1)
        {
            Console.Write(n);
            return;
        }

        Console.Write(n + ", ");
        PrintNumbers(n - 1);
    }
}