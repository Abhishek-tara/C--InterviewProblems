using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class PowerOfNum
    {
        public static void FindPow(int num,int pow)
        {
            int result = 1;

            for(int i=1;i<=pow;i++)
            {
                result*= num;
            }

            Console.WriteLine($"Power of {num} is {result}");
        }
    }
}
