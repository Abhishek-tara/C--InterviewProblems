using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class Max2InArray
    {
        public static void Max2nd()
        {
            int[] array = { 5, 4, 2, 8, 6, 9, 3 };
            int max1, max2;

            foreach(int i in array)
            {
                Console.Write(i+" ");
            }

            max1 = max2 = array[0];

            for (int i =0;i< array.Length;i++)
            {
                if (array[i] > max1)
                {
                    max2 = max1; 
                    max1 = array[i]; 
                }
                else if (array[i] > max2) 
                {
                    max2= array[i];
                }
            }

            Console.WriteLine($"\nFirst max element is : {max1}");
            Console.WriteLine($"First max element is : {max2}");
        }
    }
}
