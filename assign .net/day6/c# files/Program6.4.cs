using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixthFourthassign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter how many elements you want");
            int no, sum = 0;
                no = int.Parse(Console.ReadLine());
            int [] arr = new int[no],sqr = new int[no];
            Console.WriteLine("enter elements in the array");
            for (int i = 0; i < no; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
                sqr[i] = arr[i] * arr[i];
            }
            Console.WriteLine("sum is "+sum);
            for (int i = 0; i < no; i++)
            {
                Console.Write(sqr[i]+"\t");
            }
            Console.WriteLine();
        }
    }
}
