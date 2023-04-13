using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class CountOccurence
    {
        public static void Count(string str)
        {
            int alph, digit, spcl;
            int l = Convert.ToInt32(str.Length);
            alph = digit = spcl = 0;



            for (int i = 0; i < l; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z')
                {
                    alph++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    spcl++;
                }
            }

            Console.Write("digitber of Alphabets in the string is : {0}\n", alph);
            Console.Write("digitber of Digits in the string is : {0}\n", digit);
            Console.Write("digitber of Special characters in the string is : {0}\n\n", spcl);

        }

    }
}
