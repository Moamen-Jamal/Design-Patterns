using Prototype.Before;
using static Prototype.Before.Employee;

Employee emp1 = new Employee();
emp1.Name = "Fathy";
emp1.Department = "IT";
emp1.EmpAddress = new Address() { address = "Cairo" }; 

//override on values of emp1
Employee emp2 = emp1;
emp2.Name = "Sayed";
emp2.Department = "Dev";
emp2.EmpAddress.address = "Giza";

Console.WriteLine($"emp1 : Name: {emp1.Name}  Department: {emp1.Department}  Address: {emp1.EmpAddress.address}");
Console.WriteLine("------------");
Console.WriteLine($"emp2 : Name: {emp2.Name}  Department: {emp2.Department} Address: {emp2.EmpAddress.address}");

Console.ReadLine();

//Pros of Prototype Design Pattern
// You can clone objects without coupling to their concrete classes.
// You can get rid of repeated initialization code in favor of cloning pre-built prototypes.
// You can produce complex objects more conveniently.
// You get an alternative to inheritance when dealing with configuration presets for complex objects.

//Cons of Prototype Design Pattern
//Cloning complex objects that have circular references might be very tricky.