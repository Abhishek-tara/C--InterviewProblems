using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class Polymorphism
    {
        public static void StudentInfo(string name)
        {
            Console.WriteLine(name);
        }

        public static void StudentInfo(int roll)
        {
            Console.WriteLine(roll);
        }

        public  virtual void StudentSkills()
        {
            Console.WriteLine("Singing");
        }
    }

    public class Student : Polymorphism
    {
        public override void StudentSkills()
        {
            Console.WriteLine("Running");
        }
    }
}
