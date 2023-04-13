using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class CountFrequency
    {
        public static void Count()
        {
            int[] arr = { 1, 2, 3, 3, 5, 2, 2, 2, 2, 3, 4, 6, 1, 1, 8 };
            

            for(int i=0;i<arr.Length; i++)
            {
                int target = arr[i];
                int count = 0;

                if (target == -1)
                {
                    continue;
                }

                
                for (int j=0;j<arr.Length;j++)
                {
                    if (arr[j] == target)
                    {
                        count++;
                        arr[j] = -1;
                    }
                    
                }
                Console.Write(target + " : " + count +" times" + "\n");
                
                
            }
            
        }
    }
}
