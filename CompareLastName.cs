using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class CompareLastName
    {
           public static void Compare()
        {
            string s1 = "John Peterson";
            string s2 = "Michal Jhonson";
            char[] ch = new char[s1.Length];
            char[] ch2 = new char[s2.Length];

            string[] str = s1.Split(" ");
            string[] str2 = s2.Split(" ");

            for (int i = 1; i < str.Length; i++)
            {
                ch = str[i].ToCharArray();
                
            }

            for (int i = 1; i < str.Length; i++)
            {
                ch2 = str2[i].ToCharArray();
            }

            if (ch[0] > ch2[0])
            {
                Console.WriteLine(s2);
                Console.WriteLine(s1);
            }
        }
    
     }
}
           