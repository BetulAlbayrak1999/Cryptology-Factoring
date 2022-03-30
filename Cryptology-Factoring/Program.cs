using System;
/*
 * This code is written by Betül ALBAYRAK
 * This code is written for finding all of factors for multiple two of prime numbers.
 * exceptions also is added in the code. 
 * 
 * the result that I've got when I excuted it, is:
    Time now is :1648641645
    Enter 1. Number:
    216347

    Enter 2. Number:
    291677
    Factors:
    1
    216347
    291677
    -216347
    -291677
    -1
    Exception caught: System.DivideByZeroException: Attempted to divide by zero.
    Time now is :16486416106

    Time was taken: 61
*/
namespace Cryptology_Factoring
{
    class Program
    {
        private static void Calculate(long n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
        static void Main(string[] args)
        {
            var Timestamp1 = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            long n1, n2, current;

            Console.WriteLine("Time now is :" + Timestamp1);

            Console.WriteLine("Enter 1. Number: ");
            n1 = long.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter 2. Number: ");
            n2 = long.Parse(Console.ReadLine());

            current = n1 * n2;
            Console.WriteLine("Factors:");
            try
            {
                Calculate(current);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }

            var Timestamp2 = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            Console.WriteLine("Time now is :" + Timestamp2);
            Console.WriteLine("\nTime was taken: " + (Timestamp2 - Timestamp1));

        }
    }

}
