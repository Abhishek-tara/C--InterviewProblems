using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class Stringsort
    {
        public static void SortString(string str1)
        {
            char temp;
            string str = str1.ToLower();
            char[] ch = str.ToCharArray();

            for(int i=0;i<ch.Length-1;i++)
            {
                for(int j=0;j<ch.Length-1;j++)
                {
                    if (ch[j] > ch[j+1])
                    {
                        temp = ch[j];
                        ch[j] = ch[j+1];
                        ch[j+1] = temp;
                    }
                }
            }

            Console.WriteLine(ch);
        }
    }
}
