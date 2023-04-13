using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class StringCase
    {
        public static void ChangeCase(string str)
        {
            int l = str.Length;
            char ch;
            Console.Write(str + "\n");
            for(int i=0;i<l;i++)
            {
                ch = str[i];
                if(char.IsUpper(ch))
                {
                    Console.Write(char.ToLower(ch));
                }
                else if(char.IsLower(ch))
                {
                    Console.Write(char.ToUpper(ch));
                }
            }
        }
    }
}
