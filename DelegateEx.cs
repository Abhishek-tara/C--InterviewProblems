using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public delegate void MyDelegate();
    public class DelegateEx
    {
        public static void MethodA()
        {
            Console.WriteLine("MethodA");
        }

        public static void MethodB()
        {
            Console.WriteLine("MethodB");
        }
    }
}
