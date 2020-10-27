using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevenththird
{
       class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter how many nos you want");
                int r = int.Parse(Console.ReadLine());
                int[] arr = new int[r];
                int[] cpy = new int[r];
                for (int i = 0; i < r; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                arr.CopyTo(cpy,0);
                for (int i = 0; i < r; i++)
                {
                    Console.Write(cpy[i] + "\t");
                }
                Console.ReadLine();
            }
        }
}
