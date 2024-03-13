using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_ClassesAndObjects
{
    public class Circle: DefinedShape
    {
        public int Side { get; set; }
        public Circle(int r = 0)
        {
            Side = r;
        }

        public override double area()
        {
            Console.Write($"Area of a circle is: ");
            return 3.14 *Side * Side;
        }
    }
}


