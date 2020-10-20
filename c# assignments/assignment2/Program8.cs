using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_concat
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1,s2,s3;
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
            s3 = String.Concat(s1,s2);
            Console.WriteLine(s3);
            Console.ReadLine();
        }
    }
}
