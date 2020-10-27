using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seventhsixth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a name ");
            String s = Console.ReadLine();
            Console.WriteLine("enter a password ");
            String s1 = Console.ReadLine();
            Console.WriteLine("confirm password ");
            String s2 = Console.ReadLine();
            if (Object.Equals(s2, s1))
            Console.WriteLine("valid data");
            else
                Console.WriteLine("Invalid data");
        }
    }
}
