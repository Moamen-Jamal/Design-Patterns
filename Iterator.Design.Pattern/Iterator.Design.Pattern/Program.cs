using Iterator.Design.Pattern;
using IteratorClass = Iterator.Design.Pattern.Iterator;

// Build a collection

CompanyAEmployees companyACollection = new CompanyAEmployees();
companyACollection.AddEmployee(new Employee(1, "Momen"));
companyACollection.AddEmployee(new Employee(2, "Jamal"));
companyACollection.AddEmployee(new Employee(3, "Amr"));

// Create iterator
IteratorClass iterator = companyACollection.CreateIterator();

//looping iterator      
Console.WriteLine("Iterating over companyACollection:");

for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
{
    Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
}

CompanyBEmployees companyBCollection = new CompanyBEmployees();
companyBCollection.AddEmployee(new Employee(1, "Sayed"));
companyBCollection.AddEmployee(new Employee(2, "Ahmed"));
companyBCollection.AddEmployee(new Employee(3, "Mohamed"));

// Create iterator
IteratorClass iteratorB = companyACollection.CreateIterator();

//looping iterator      
Console.WriteLine("Iterating over companyBCollection:");

for (Employee emp = iteratorB.First(); !iteratorB.IsCompleted; emp = iteratorB.Next())
{
    Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
}

Console.ReadLine();

//Pros of Iterator Design Pattern
// Single Responsibility Principle. You can clean up the client code and the collections by extracting bulky traversal algorithms into separate classes.
// Open/Closed Principle. You can implement new types of collections and iterators and pass them to existing code without breaking anything.
// You can iterate over the same collection in parallel because each iterator object contains its own iteration state.
// For the same reason, you can delay an iteration and continue it when needed.

//Cons of Iterator Design Pattern
// Applying the pattern can be an overkill if your app only works with simple collections.
// Using an iterator may be less efficient than going through elements of some specialized collections directly.
