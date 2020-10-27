using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixthFourthassign
{
    class outdemo
    {

        public int[] sqrarray(int[] arr, out int sum)
        {
            sum = 0;
            int[] sqr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                sqr[i] = arr[i] * arr[i];
            }
            return sqr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            outdemo o = new outdemo();
            Console.WriteLine("enter how many elements you want");
            int no, sum = 0;
            no = int.Parse(Console.ReadLine());
            int[] arr = new int[no], s;
            Console.WriteLine("enter elements in the array");
            for (int i = 0; i < no; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            s = o.sqrarray(arr,out sum);
            Console.WriteLine("sum is " + sum);
            for (int i = 0; i < no; i++)
            {
                Console.Write(s[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}