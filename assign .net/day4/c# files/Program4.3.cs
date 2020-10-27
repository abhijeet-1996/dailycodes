using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign4._3
{
    class customer
    {
        private int Id;
        private string name;
        private int billamount;
        static void Main(string[] args)
        {
            customer c = new customer();
            Console.Write("{0}\t{1}\t{2}",c.Id,c.name,c.billamount);
        }
    }
}
