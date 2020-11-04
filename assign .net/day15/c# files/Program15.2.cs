using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._2
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] arr = new int[5] { 1,3,3,8,3};

            HashSet<int> hs = new HashSet<int>();
            foreach (int i in arr)
            {
                hs.Add(i);
            }
            foreach (var z in hs)
            {
                Console.Write(z+"\t");
            }
        }
    }
}
