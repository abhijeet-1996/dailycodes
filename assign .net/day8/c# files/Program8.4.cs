using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eightfourth
{
    class swapdemo
    { 
        public void swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            swapdemo s = new swapdemo();
            int no1 = 10, no2 = 20;
            Console.WriteLine(no1 +"\t"+no2);
            s.swap(ref no1,ref no2);
            Console.WriteLine(no1 + "\t" + no2);
        }
    }
}
