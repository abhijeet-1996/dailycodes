using System;

namespace factor_of_nos_assign3._2
{

    struct calculator 
    {
        public static void factors(int no)
        {
            for (int i = no; i >= 1; i--)
            {
                if (no % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    class Program12
    {
        static void Main(string[] args)
        {
            calculator.factors(19);
            Console.ReadLine();
        }
    }
}
