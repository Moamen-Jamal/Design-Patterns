using FactoryMethod.Before.Start;

Car car;

Console.WriteLine("Please Select Car type S = Sedan, U = SUV ??");

string? carType = Console.ReadLine();

switch (carType)
{
    case "S":
        car = new SedanCar();
        break;
    case "U":
        car = new SUVCar();
        break;
    default:
        car = new SedanCar();
        break;
}
RunCommand();

void RunCommand()
{
    car.RunCar();
    car.RepairCar();
}
Console.ReadKey();

//Pros of Factory Method Design Pattern

//1- You avoid tight coupling between the creator and the concrete products.
//2- Single Responsibility Principle. You can move the product creation code into one place in the program, making the code easier to support.
//3- Open/Closed Principle. You can introduce new types of products into the program without breaking existing client code.

//Cons of Factory Method Design Pattern
//1- The code may become more complicated since you need to introduce a lot of new subclasses to implement the pattern. The best case scenario is when you’re introducing the pattern into an existing hierarchy of creator classes.
