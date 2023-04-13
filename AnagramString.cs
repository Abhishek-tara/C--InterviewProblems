using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class AnagramString
    {
        //Check Anagram 
        public static void Check()
        {
            string str1 = "silent";
            string str2 = "listen";

            char[] c1 = str1.ToCharArray(); 
            char[] c2 = str2.ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);

            string result1 = new string(c1);
            string result2 = new string(c2);

            if(result1 == result2)
            {
                Console.WriteLine("Strings are Anagram");
            }
            else
            {
                Console.WriteLine("Not anagram");
            }
        }
    }
}
