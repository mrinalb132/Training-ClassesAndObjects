using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_ClassesAndObjects
{
    public class Square : DefinedShape
    {
        public int Side { get; set; }
        public Square(int s =0)
        {
            Side = s;
        }

        public override double area()
        {
            Console.Write($"Area of a square is: ");
            return Side * Side;
        }
    }
}
