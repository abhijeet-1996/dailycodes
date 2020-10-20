using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byte_limit_assign_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            short st;
            Console.WriteLine("enter no to convert into byte");
            String s = Console.ReadLine();
            short.TryParse(s,out st);
            byte b = (byte)st;
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
