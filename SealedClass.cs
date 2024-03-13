using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_ClassesAndObjects
{
    public sealed class SealedClass
    {
        public void InvokeMethod()
        {
            Console.WriteLine("Invoking seal");
        }
    }
}
