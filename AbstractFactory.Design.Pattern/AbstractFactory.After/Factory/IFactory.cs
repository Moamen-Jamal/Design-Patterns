using AbstractFactory.After.CarProduct;
using AbstractFactory.After.TruckProduct;

namespace AbstractFactory.After.Factory
{
    interface IFactory
    {
        ICar GetCarType(string? carType);
        ITruck GetTruckType(string? truckType);

    }
}
