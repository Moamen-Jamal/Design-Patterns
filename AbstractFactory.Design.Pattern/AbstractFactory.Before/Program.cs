using AbstractFactory.Before.Start;

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

//Pros of Abstract Factory

//1- You can be sure that the products you’re getting from a factory are compatible with each other.
//2- You avoid tight coupling between concrete products and client code.
//3- Single Responsibility Principle. You can extract the product creation code into one place, making the code easier to support.
//4- Open/Closed Principle. You can introduce new variants of products without breaking existing client code.

//Cons of Abstract Factory
//1- The code may become more complicated than it should be, since a lot of new interfaces and classes are introduced along with the pattern.