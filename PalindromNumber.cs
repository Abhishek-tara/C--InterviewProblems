using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class PalindromNumber
    {
        public static void Check(int num)
        {
            int temp = num;
            int rem, sum = 0;
            while(num > 0)
            {
                rem = num % 10;
                sum = sum*10+rem;
                num /= 10;
            }

            if(temp == sum)
            {
                Console.WriteLine("palindrom");
            }
            else
            {
                Console.WriteLine("Not Palindrom");
            }
        }
    }
}
