using Mediator.Design.Pattern;
using System;

FacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();
User Ram = new ConcreteUser(facebookMediator, "Ram");
User Dave = new ConcreteUser(facebookMediator, "Dave");
User Smith = new ConcreteUser(facebookMediator, "Smith");
User Rajesh = new ConcreteUser(facebookMediator, "Rajesh");
User Sam = new ConcreteUser(facebookMediator, "Sam");
User Pam = new ConcreteUser(facebookMediator, "Pam");
User Anurag = new ConcreteUser(facebookMediator, "Anurag");
User John = new ConcreteUser(facebookMediator, "John");
facebookMediator.RegisterUser(Ram);
facebookMediator.RegisterUser(Dave);
facebookMediator.RegisterUser(Smith);
facebookMediator.RegisterUser(Rajesh);
facebookMediator.RegisterUser(Sam);
facebookMediator.RegisterUser(Pam);
facebookMediator.RegisterUser(Anurag);
facebookMediator.RegisterUser(John);
Rajesh.Send("What is Design Patterns? Please explain ");
Console.Read();

//Pros of Mediator Design Pattern
// Single Responsibility Principle. You can extract the communications between various components into a single place, making it easier to comprehend and maintain.
// Open/Closed Principle. You can introduce new mediators without having to change the actual components.
// You can reduce coupling between various components of a program.
// You can reuse individual components more easily.

//Cons of Mediator Design Pattern
//Over time a mediator can evolve into a God Object.