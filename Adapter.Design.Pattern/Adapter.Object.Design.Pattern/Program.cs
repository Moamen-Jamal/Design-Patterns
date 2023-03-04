//Client Code
//The Client class can only see the Target interface

using Adapter.Object.Design.Pattern;

IEmployeeTarget employee = new EmployeeAdapter();
string employeesJson = employee.GetAllEmployee();
Console.WriteLine(employeesJson);
Console.ReadLine();

//Pros Of Adapter
//Single Responsibility Principle. You can separate the interface or data conversion code from the primary business logic of the program.
// Open/Closed Principle. You can introduce new types of adapters into the program without breaking the existing client code, as long as they work with the adapters through the client interface.

//Cons Of Adapter 
//The overall complexity of the code increases because you need to introduce a set of new interfaces and classes.Sometimes it’s simpler just to change the service class so that it matches the rest of your code.