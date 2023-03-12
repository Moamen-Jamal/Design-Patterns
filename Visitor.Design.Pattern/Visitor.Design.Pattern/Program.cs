using Visitor.Design.Pattern;

School school = new School();
var visitor1 = new Doctor("James");
school.PerformOperation(visitor1);
Console.WriteLine();
var visitor2 = new Salesman("John");
school.PerformOperation(visitor2);
Console.Read();

//Pros of Visitor Design Pattern
//Open / Closed Principle.You can introduce a new behavior that can work with objects of different classes without changing these classes.
// Single Responsibility Principle. You can move multiple versions of the same behavior into the same class.
// A visitor object can accumulate some useful information while working with various objects. This might be handy when you want to traverse some complex object structure, such as an object tree, and apply the visitor to each object of this structure.

//Cons of Visitor Design Pattern
// You need to update all visitors each time a class gets added to or removed from the element hierarchy.
// Visitors might lack the necessary access to the private fields and methods of the elements that they’re supposed to work with.