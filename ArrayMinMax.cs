using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class ArrayMinMax
    {
        // Write a C# Sharp program to find the maximum and minimum number from a given string of numbers separated by single space.
        public static void MinMax()
        {
            string s1 = "3 2 4 7 8 9";
            var s2 = s1.Split(" ").Select(int.Parse).ToArray();
            Console.WriteLine($"Max : {s2.Max()}, Min : {s2.Min()}");
        }
    }
}
