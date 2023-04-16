using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class OddEvenArray
    {
        public static void FindOddEven()
        {
            int[] arr = { 2, 5, 8, 9, 11, 15, 16, 19, 20 };
            int[] odd = new int[arr.Length];
            int[] even = new int[arr.Length];
            int x = 0, y = 0;


            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 != 0)
                {
                    odd[y] = arr[i];
                    y++;
                }
                else if (arr[i] % 2 == 0)
                {
                    even[x] = arr[i];
                    x++;
                }
                
            }



            Console.WriteLine("Even Arrays:");
            foreach(var e in even)
            {
                if(e != 0)
                {
                    Console.Write(e + " ");
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Odd Arrays:");
            foreach (var z in odd)
            {
                if (z != 0)
                {
                    Console.Write(z + " ");
                }
            }
        }
    }
}
