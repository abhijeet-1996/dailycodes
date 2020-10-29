using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenthFifth
{
    interface Itaxtogov
    {
        void paytax(double amt);
    }

    class myindia : Itaxtogov
    {

        public void paytax(double amt)
        {
            Console.WriteLine("you have to pay tax of "+(amt*0.4));
        }
    }

    class europe : Itaxtogov
    {

        public void paytax(double amt)
        {
            Console.WriteLine("you have to pay tax of " + (amt * 0.3));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Itaxtogov it = new myindia();
            it.paytax(10000);

            Itaxtogov it1 = new europe();
            it1.paytax(10000);
            
        }
    }
}
