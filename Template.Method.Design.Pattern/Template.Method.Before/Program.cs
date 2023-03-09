using Template.Method.Before;

var order1 = new MakeRoundedPizza();
order1.MakePizza();
Console.WriteLine("--------------------");
var order2 = new MakeRectanglePizza();
order2.MakePizza();

Console.Read();

//Pros of Template Method Design Pattern
// You can let clients override only certain parts of a large algorithm, making them less affected by changes that happen to other parts of the algorithm.
// You can pull the duplicate code into a superclass.

//Cons of Template Method Design Pattern
// Some clients may be limited by the provided skeleton of an algorithm.
// You might violate the Liskov Substitution Principle by suppressing a default step implementation via a subclass.
// Template methods tend to be harder to maintain the more steps they have.