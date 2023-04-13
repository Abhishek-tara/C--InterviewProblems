using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class Fibonacci
    {
        public static void PrintSeries(int num)
        {
            int a = 0,b=1,c;

            for(int i=0;i<num;i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
