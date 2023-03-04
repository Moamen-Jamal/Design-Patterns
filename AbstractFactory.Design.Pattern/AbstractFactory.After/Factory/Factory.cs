using AbstractFactory.After.CarProduct;
using AbstractFactory.After.TruckProduct;

namespace AbstractFactory.After.Factory
{
    class Factory : IFactory
    {
        public ICar GetCarType(string? carType)
        {
            switch (carType)
            {
                case "S":
                    return new SedanCar();
                case "U":
                    return new SUVCar();
                default:
                    return new SedanCar();
            }
        }

        public ITruck GetTruckType(string? truckType)
        {
            switch (truckType)
            {
                case "T1":
                    return new Truck1();
                case "T2":
                    return new Truck2();
                default:
                    return new Truck1();
            }
        }
    }
}
