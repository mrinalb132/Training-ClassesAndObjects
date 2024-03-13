using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_ClassesAndObjects
{
    public class Car: Vehicle
    {
        public void PurchaseCar()
        {
            PurchaseVehicle();
            Console.WriteLine($"Purchased Car");
        }
    }
}
