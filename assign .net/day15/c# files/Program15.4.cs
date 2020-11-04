using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5] { "vita", "vidya", "dac", "edac","dbda"};

            var ab = arr.Where(str => (str.StartsWith("v")));

            foreach (var a in ab)
                Console.WriteLine(a);
        }
    }
}
