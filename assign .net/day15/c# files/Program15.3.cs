using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 4, 3, 8, 3 };

            var a = arr.Where(no =>(no%2 ==0));

            foreach(var b in a)
            {
                Console.Write(b+"\t");
            }
            Console.WriteLine("\noriginal array");
            foreach (var b in arr)
            {
                Console.Write(b + "\t");
            }
            Console.WriteLine();
        }
    }
}
