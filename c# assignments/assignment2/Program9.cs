using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryparse_assign2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int no;
            string s;
            s = Console.ReadLine();
            if (int.TryParse(s,out no))
            {
                Console.WriteLine(no* no);
                Console.ReadLine();
            }
        }
    }
}
