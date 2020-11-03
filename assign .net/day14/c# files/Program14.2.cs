using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._2
{
    class employee
    {
        public string a;
        public employee(string a)
        {
            this.a = a;
        }

        public override string ToString()
        {
            return a;
        }
    }
    class Program
    {
        static void swap<T>(ref T a,ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {

            dynamic a = 10, b = 20;
            Console.WriteLine("before"+a + "\t" + b);
            swap(ref a,ref b);
            Console.WriteLine("after "+a+"\t"+b);

            a = new employee("abhijeet");
            b = new employee("omkar");

            Console.WriteLine("before" + a + "\t" + b);
            swap(ref a, ref b);
            Console.WriteLine("after " + a + "\t" + b);
        }
    }
}
