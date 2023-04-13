using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class BinarySearch
    {
        public static int BS(int[] arr,int target)
        {
            int left = 0;
            int right = arr.Length;
            while(left <= right)
            {
                int mid = (left + right)/2;
            
                if(arr[mid] == target)
                {
                    return mid;
                }
                else if (target > arr[mid])
                {
                    left = mid+1;
                }
                else
                {
                    right = mid - 1;
                }
               
            }
            return -1;
        }
    }
}
