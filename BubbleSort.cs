using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class BubbleSort
    {
        

        public static void Sort()
        {
            int[] arr = { 5, 4, 8, 1, 2, 9, 7 };

            for(int i=0;i<arr.Length-1;i++)
            {
                for(int j=0;j<arr.Length-1;j++)
                {
                    int temp;
                    if (arr[j] < arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }

            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }

        }
    }
}
