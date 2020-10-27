using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accountclasslib;
namespace assign4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            account a = new account(1, "abhijeet", 100000);
            a.disp();
            a.deposit(20000);
            a.disp();
            a.withdraw(15000);
            a.disp();
            account b = new account(2, "omkar", 200000);
            b.disp();
            b.deposit(20000);
            b.disp();
            b.withdraw(15000);
            b.disp();
        }
    }
}
