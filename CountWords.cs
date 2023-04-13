using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class CountWords
    {
        public static void CountWord(string str)
        {
            int l = 0;
            int wrds = 1;

            while(l < str.Length)
            {
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    wrds++;
                }
                l++;
            }

            Console.WriteLine($"Total number of words are: {wrds}");
        }
    }
}
