using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    //public class Abstraction
    //{
    //}

    abstract class Human
    {
       
        public abstract void SkinColour();

        
        public void Species()
        {
            Console.WriteLine("Homo-Sapiens");
        }
    }

    class child : Human
    {
        public override void SkinColour()
        {
            
            Console.WriteLine("Brown skin");
        }
    }
}
