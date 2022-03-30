using System;
/*
 * This code is written by Betül ALBAYRAK
 * This code is written for finding all of factors for number which 9 digits or more.
 * exceptions for digits count also is added in the code. 
 * 
 * the result that I've got when I excuted it is:
 * Time now is :1648622475
    Enter 1. Number, and it should be 9 digits:
    1672839402
    Factors:
    1
    2
    3
    6
    13
    26
    39
    78
    169
    338
    507
    1014
    1649743
    3299486
    4949229
    9898458
    21446659
    42893318
    64339977
    128679954
    278806567
    557613134
    836419701
    1672839402

    Enter 2. Number, and it should be 9 digits:
    278493093
    Factors:
    1
    3
    9
    27
    127
    241
    337
    381
    723
    1011
    1143
    2169
    3033
    3429
    6507
    9099
    30607
    42799
    81217
    91821
    128397
    243651
    275463
    385191
    730953
    826389
    1155573
    2192859
    10314559
    30943677
    92831031
    278493093
    Time now is :1648622536

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
        private static int FindNumberOfDigit(long number)
        {
            int count = 0;
            while (number > 0)
            {
                number /= 10;
                count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            var Timestamp1 = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            long n;
            
            Console.WriteLine("Time now is :" + Timestamp1);
            Console.WriteLine("Enter 1. Number, and it should be 9 digits:");
            n = long.Parse(Console.ReadLine());
            int count = FindNumberOfDigit(n);
            while (count < 9) {
                Console.WriteLine("The number you have entered less than 9 digits, so enter 1. number again");
                n = long.Parse(Console.ReadLine());
            }
            Console.WriteLine("Factors:");
            Calculate(n);

            Console.WriteLine("\nEnter 2. Number, and it should be 9 digits:");
            n = long.Parse(Console.ReadLine());
            count = FindNumberOfDigit(n);
            while (count < 9)
            {
                Console.WriteLine("The number you have entered less than 9 digits, so enter 2. number again");
                n = long.Parse(Console.ReadLine());
            }
            Console.WriteLine("Factors:");
            Calculate(n);


            var Timestamp2 = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            Console.WriteLine("Time now is :" + Timestamp2);
            Console.WriteLine("\nTime was taken: " + (Timestamp2- Timestamp1));

        }
    }
    
}
