using System;

namespace hello
{
        class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 4 - i; j >= 0; j--)
                    Console.Write("{0} ", j);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}