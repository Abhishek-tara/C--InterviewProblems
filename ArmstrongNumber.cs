using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class ArmstrongNumber
    {
        public static void Check(int num)
        {
            int temp = num;
            int sum = 0, rem;
            while(num > 0)
            {
                rem = num % 10;
                sum += rem*rem*rem;
                num /= 10;
            }
            if(temp == sum)
            {
                Console.WriteLine("Arsmstrong");
            }
            else
            {
                Console.WriteLine("Not an Armstrong");
            }
        }
    }
}
