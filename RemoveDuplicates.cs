using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class RemoveDuplicates
    {
        public static void PrintDistinct()
        {
            int[] arr = { 1, 2, 3, 1, 2, 4, 5 };
            int i, j;
            

            for(i=0;i<arr.Length;i++)
            {
                int count = 0;
                for( j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                        count++;
                }
                if(count==1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
