using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixththirdassign
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp,sum = 0;
            int[,] arr = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++ )
                {
                    temp = int.Parse(Console.ReadLine());
                    arr[i, j] = temp;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i,j]+"\t");
                    sum += arr[i, j];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}
