using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixthfifthassign
{
    class Program
    {
        static void cube(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i] * arr[i];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter how many elements you want");
            int no;
            no = int.Parse(Console.ReadLine());
            int[] arr = new int[no];
            Console.WriteLine("enter elements in the array");
            for (int i = 0; i < no; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            cube(arr);
            for (int i = 0; i < no; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }
    }
}
