using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixthassign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter how many elements you want");
            int no, sum = 0;
            no = int.Parse(Console.ReadLine());
            int[] arr = new int[no];
            Console.WriteLine("enter elements in the array");
            for (int i = 0; i < no; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine("average is " + sum/no);
        }
    }
}
