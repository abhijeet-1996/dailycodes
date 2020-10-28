using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ninththree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no");
            int a = int.Parse(Console.ReadLine());
            object o = a;
            Console.WriteLine("before\t"+a+"\t"+o);
            a = 999;
            Console.WriteLine("after\t"+a+"\t"+o);
        }
    }
}
