using Decorator.Design.Pattern;

//Before Decorator
PlainPizzaConcreteComponent plainPizzaObj = new();
string plainPizza = plainPizzaObj.MakePizza();
Console.WriteLine(plainPizza);

//After Chicken Decorator
PizzaDecorator chickenPizzaDecorator = new ChickenPizzaConcerateDecorator(plainPizzaObj);
string chickenPizza = chickenPizzaDecorator.MakePizza();
Console.WriteLine("\n'" + chickenPizza + "' using ChickenPizzaDecorator");

//After Veg Decorator
VegPizzaConcerateDecorator vegPizzaDecorator = new(plainPizzaObj);
string vegPizza = vegPizzaDecorator.MakePizza();
Console.WriteLine("\n'" + vegPizza + "' using VegPizzaDecorator");

Console.Read();

//Pros of Decorator

//You can extend an object’s behavior without making a new subclass.
//You can add or remove responsibilities from an object at runtime.
//You can combine several behaviors by wrapping an object into multiple decorators.
// Single Responsibility Principle. You can divide a monolithic class that implements many possible variants of behavior into several smaller classes.

//Cons of Decorator
// It’s hard to remove a specific wrapper from the wrappers stack.
// It’s hard to implement a decorator in such a way that its behavior doesn’t depend on the order in the decorators stack.
// The initial configuration code of layers might look pretty ugly.