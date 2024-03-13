using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_ClassesAndObjects
{
    class NewCircle : IShape, IPerimeter
    {
        public int Side { get; set; }
        public NewCircle(int r)
        {
            Side = r;
        }
        public double Area()
        {
            Console.Write($"Area of a circle is: ");
            return 3.14 * Side * Side;
        }

        public double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
