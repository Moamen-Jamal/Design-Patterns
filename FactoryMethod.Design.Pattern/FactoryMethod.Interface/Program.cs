using FactoryMethod.Interface.Factory;

ICar car;

Console.WriteLine("Please Select Car type S = Sedan, U = SUV ??");

string? carType = Console.ReadLine();

car = new CarFactory().GetCarType(carType);
RunCommand();

void RunCommand()
{
    car.RunCar();
    car.RepairCar();
}
Console.ReadKey();