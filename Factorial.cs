using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class Factorial
    {
        public static void Find(int num)
        {
            int fact = 1;
            for(int i=1;i<=num;i++)
            {
                fact *=  i;
            }

            Console.WriteLine(fact);
        }
    }
}
