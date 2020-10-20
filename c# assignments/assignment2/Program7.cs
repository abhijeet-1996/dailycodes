using System;
using ClassLibrary3;

namespace shared_assembly_client
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
