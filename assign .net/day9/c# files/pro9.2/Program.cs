using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ninthtwo
{
    class Program
    {
        static void Main(string[] args)
        {
            person[] p = new person[3]{new programmer(),new singer(),new dancer()};

            for (int i = 0; i < 3; i++)
            {
               Console.WriteLine( p[i].dojob());
               if (p[i] is programmer)
               {
                   programmer a = (programmer) p[i];
                   a.testing();
               }

               programmer b = p[i] as programmer;

               if (b != null)
                   b.testing();
            }
        }
    }
}
