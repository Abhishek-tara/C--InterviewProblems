using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class FruitColor
    {
        string colour = "red";
    }

    public class Taste : FruitColor 
    {
        string fruit = "apple";
        string FruitTaste = "Sweet";
    }

    public class Orange : FruitColor
    {
        string colour = "orange";
    }

    public class Body : Taste
    {
        string bodyType = "Solid";
    }
}
