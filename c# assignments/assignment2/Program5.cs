using System;
using ClassLibrary2;

namespace client_CL2_assign2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            Console.WriteLine(c.sqr(7));
            Console.WriteLine(c.cube(3));
            Console.ReadLine();
        }
    }
}
