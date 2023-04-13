using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class FindSubstr
    {
        public static void Find()
        {
            string str = "Hey check out my code";

            string target = "out";
            int idx = str.IndexOf(target);

            if(str.Contains(target))
            {
                Console.WriteLine($"{target} is present in the given string");
            }

            if (idx > 0)
            {
                Console.WriteLine($"{target} is present in the given index {idx}");
            }
            else
            {
                Console.WriteLine("Not present");
            }
            
        }
    }
}
