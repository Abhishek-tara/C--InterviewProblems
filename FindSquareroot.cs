using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class FindSquareroot
    {
        public static void FindSqrt()
        {
            Console.Write("Enter a numbr:");
            int num = Convert.ToInt32(Console.ReadLine());

            double temp;
            double sqrt = num / 2;

            do
            {
                temp = sqrt;
                sqrt = (temp + (num / temp)) / 2;
            } while ((temp - sqrt) != 0);

            Console.WriteLine($"The square root of the number {num} is {sqrt}");

           
        }
    }
}
