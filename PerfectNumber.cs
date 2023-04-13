using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class PerfectNumber
    {
        public static void FindPerfectNum()
        {


            //---------------For a Single NUmber--------------//

            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int i;
            //for (i = 1; i < num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        sum += i;
            //    }
            //}

            //if (sum == num)
            //{
            //    Console.Write("{0} is Perfet number", num);
            //}
            //else
            //{
            //    Console.WriteLine("Not a perfect number");
            //}

            //-------------for a Range---------------------//

            Console.Write("Enter min range: ");
            int min = int.Parse(Console.ReadLine());


            Console.Write("Enter max range: ");
            int max = int.Parse(Console.ReadLine());

            int sum, n, i;
            for (n = min; n <= max; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                    {
                        sum += i;

                    }
                    i++;

                }

                if (sum == n)
                {
                    Console.Write(n + " ");
                }

            }

        }
    }
}
