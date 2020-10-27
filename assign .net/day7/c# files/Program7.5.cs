using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryaccount74;
namespace seventhFifth
{
    class Program
    {
        static void Main(string[] args)
        {
            account[] a = new account[2] { new account("abhijeet", 720000), new account("omkar", 1000000)};
            a[1].deposit(200000);
            a[0].withdraw(50000);
            for (int i = 0; i < 2; i++)
            {
                a[i].disp();
            }
        }
    }
}
