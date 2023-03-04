using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.After.CarProduct
{
    interface ICar
    {
        string carName { get; set; }
        int modelNumber { get; set; }

        void RunCar()
        {
            Console.WriteLine(carName + " is running.");
        }

        void RepairCar()
        {
            Console.WriteLine(carName + " with model no " + modelNumber + " is being repaired");
        }
    }
}
