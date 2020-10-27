using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seventhfourth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string ");
            String s = Console.ReadLine();
            String s1 = s.ToLower();
            Console.WriteLine(Object.ReferenceEquals(s,s1));//false
        }
    }
}
