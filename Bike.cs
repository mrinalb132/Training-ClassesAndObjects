using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_ClassesAndObjects
{
    public class Bike: Vehicle
    {
        public void PurchaseBike()
        {
            PurchaseVehicle();
            Console.WriteLine($"Purchased Bike");
        }
    }
}
