using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_ClassesAndObjects
{
    public class Cat: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The cat is making sound: meow");
        }
    }
}
