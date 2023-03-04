using AbstractFactory.After.CarProduct;
using AbstractFactory.After.Factory;
using AbstractFactory.After.TruckProduct;

ICar car;
ITruck truck;
Console.WriteLine("Please Select Car type S = Sedan, U = SUV ??");

string? carType = Console.ReadLine();


car = new Factory().GetCarType(carType);

Console.WriteLine("Please Select Truck type T1 = Truck1, T2 = Truck2 ??");

string? truckType = Console.ReadLine();


truck = new Factory().GetTruckType(truckType);

RunCommand();

void RunCommand()
{
    car.RunCar();
    car.RepairCar();
    Console.WriteLine("----------------------------------");
    truck.RunTruck();
    truck.RepairTruck();
}
Console.ReadKey();