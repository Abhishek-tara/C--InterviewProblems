using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class ArrayMaxMin
    {
        public static void FindMinMax()
        {
            int[] arr = { 58, 96, 12, 15, 2, 4 };
            int min, max;
            min = max = arr[0];

            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine($"Min value is: {min}");
            Console.WriteLine($"Max value is: {max}");
        }
    }
}
