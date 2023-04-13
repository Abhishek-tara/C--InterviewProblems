using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class StringRev
    {
        public static void PrintString()
        {
            string str = "Hello how are you";
            Console.WriteLine($"Given string is: {str}");

            int l = str.Length;

            string rev = "";

            for (int i = l - 1; i >= 0; i--)
            {
                rev += str[i];
            }

            Console.WriteLine($"Reverse of string is: {rev}");

        }

        public static void PrintWords()
        {
            string str = "Hello how are you";
            Console.WriteLine($"Given string is: {str}");       

            string rev = "";

            string[] arr = str.Split(' ');

            int l = arr.Length;

            for (int i = l - 1; i >= 0; i--)
            {
                rev += arr[i] + " ";              
            }

            Console.WriteLine($"Reverse of string is: {rev}");
        }
    }
}