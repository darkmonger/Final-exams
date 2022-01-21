using System;

namespace Csharp_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, ctr, startno, endno;

            Console.Write("\n\n");
            Console.Write("Find the prime numbers within a range of numbers:\n");
            Console.Write("---------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input starting number of range: ");
            startno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input ending number of range : ");
            endno = Convert.ToInt32(Console.ReadLine());

            Console.Write("The prime numbers between {0} and {1} are : \n", startno, endno);

            for (num = startno; num <= endno; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");
        }
    }
}
