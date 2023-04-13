using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class PrimeNumber
    {
        public static void FindPrime()
        {
            int i, j;
            Console.Write("Enter min range: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter max range: ");
            int max = int.Parse(Console.ReadLine());

            for(i=min; i<=max; i++)
            {
                for(j=2;j<=i;j++)
                {
                    if(i%j ==0)
                    {
                        break;
                    }
                    
                }
                if (i == j)
                {
                    Console.Write(j + " ");
                }
            }
        }
    }
}
