using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class SwapNumbers
    {
        public static void Swap(int n1,int n2)
        {
            Console.WriteLine($"Before swapping given numbers are: n1 = {n1},n2 = {n2}");
            n1 = n1 * n2;
            n2 = n1 / n2;
            n1 = n1 / n2;

            Console.WriteLine($"After swapping given numbers are: n1 = {n1},n2 = {n2}");

        }
    }
}
