using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class MergeTwoSortArray
    {
        public static void Merge()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 1, 2, 3 };
            int l = arr1.Length + arr2.Length;

            int[] arr3 = new int[l];
            int i, j, k;

            for(i=0;i<arr1.Length;i++)
            {
                arr3[i] = arr1[i]; 
            }

            int L = arr1.Length; 

            for (j = 0; j < arr2.Length; j++)
            {
                arr3[L] = arr2[j];
                L++;
            }

            for(int z=0;z<arr3.Length;z++)
            {
                for(int m=0;m<arr3.Length -1; m++)
                {
                    if (arr3[m] > arr3[m + 1])
                    {
                        int temp = arr3[m];
                        arr3[m] = arr3[m + 1];
                        arr3[m + 1] = temp;
                    }
                }
            }
            foreach(var e in arr3)
            {
                Console.Write(e + " ");
            }
        }
    }
}
