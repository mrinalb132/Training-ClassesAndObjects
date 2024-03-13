using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_ClassesAndObjects
{
    class NewSquare: IShape, IPerimeter
    {
        public int Side { get; set; }
        public NewSquare(int s)
        {
            Side = s;
        }

        public double Area()
        {
            Console.Write($"Area of a square is: ");
            return Side * Side;
        }

        public double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
