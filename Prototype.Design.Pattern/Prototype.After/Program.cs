using Prototype.After;
using static Prototype.After.Employee;

Employee emp1 = new Employee();
emp1.Name = "Fathy";
emp1.Department = "IT";
emp1.EmpAddress = new Address() { address = "Cairo" };


Employee emp2 = emp1.ShallowCopy();
emp2.Name = "Sayed";
emp2.Department = "Dev";
emp2.EmpAddress.address = "Giza";

Console.WriteLine("ShallowCopy: ");
Console.WriteLine();
Console.WriteLine($"emp1 : Name: {emp1.Name}  Department: {emp1.Department}  Address: {emp1.EmpAddress.address}");
Console.WriteLine("------------");
Console.WriteLine($"emp2 : Name: {emp2.Name}  Department: {emp2.Department} Address: {emp2.EmpAddress.address}");

Employee emp3 = emp1.DeepCopy();
emp3.Name = "Moamen";
emp3.Department = "Tester";
emp3.EmpAddress.address = "Luxor";

Console.WriteLine();
Console.WriteLine("DeepCopy: ");
Console.WriteLine();
Console.WriteLine($"emp1 : Name: {emp1.Name}  Department: {emp1.Department}  Address: {emp1.EmpAddress.address}");
Console.WriteLine("------------");
Console.WriteLine($"emp3 : Name: {emp3.Name}  Department: {emp3.Department} Address: {emp3.EmpAddress.address}");

//Note That the object Reference (Address) is the different between ShallowCopy and DeepCopy

Console.ReadLine();