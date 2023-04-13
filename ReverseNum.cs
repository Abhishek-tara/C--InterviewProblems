using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class ReverseNum
    {
        public static void printRev()
        {
            int num = 45896;
            int rev = 0,rem;

            Console.WriteLine($"Given number is: {num}");


            while (num > 0)
            {
                rem = num%10;
                rev = rev * 10 + rem;
                num /= 10;
            }

            Console.WriteLine($"Reverse of a number is: {rev}");
        }
    }
}
