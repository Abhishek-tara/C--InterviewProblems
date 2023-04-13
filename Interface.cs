using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    //public class Interface
    //{
    //}

    interface Icat
    {
         void Sound();
    }

    interface Idog
    {
         void Sound();
    }

    class Animal : Icat , Idog
    {
        void Icat.Sound()
        {
            Console.WriteLine("Meoow");
        }

         void Idog.Sound()
        {
            Console.WriteLine("barkk");
        }
    }
}
