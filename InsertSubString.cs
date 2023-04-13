using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class InsertSubString
    {
        public static void insert()
        {
            //String Original
            string s1 = "This is a sample";
            Console.WriteLine(s1);

            //Search for
            string s2 = "sample";

            //Insert string.
            string s3 = "test";

            //Search index of nagguu
            int i = s1.IndexOf(s2);

            s3 = s3.Trim() + " ";

            s1 = s1.Insert(i, s3);

            
            Console.WriteLine("The Modified string is: {0}", s1);
        }
    }
}
