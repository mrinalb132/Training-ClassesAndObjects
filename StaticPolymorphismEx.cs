using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_ClassesAndObjects
{
    public class StaticPolymorphismEx
    {
        /*Method Overloading*/
        public double Area(int side)
        {

            return side * side;
        }

        public double Area(int length, int breadth)
        {
            return length * breadth;
        }
    }
}
