using Command.Before;

var MomenReceiver = new Receiver(1);
var AliSender = new Sender(MomenReceiver);

AliSender.Execute();

AliSender.Undo();

Console.WriteLine("Second Case ------");

var OmarReceiver = new Receiver(2);
var AmrReceiver = new Receiver(3);

var MohamedSender = new Sender(new List<Receiver>() { OmarReceiver, AmrReceiver });

MohamedSender.Execute();

MohamedSender.Undo();

Console.ReadLine();

//Pros of Command Design Pattern
// Single Responsibility Principle. You can decouple classes that invoke operations from classes that perform these operations.
// Open/Closed Principle. You can introduce new commands into the app without breaking existing client code.
// You can implement undo/redo.
// You can implement deferred execution of operations.
// You can assemble a set of simple commands into a complex one.

//Cons of Command Design Pattern
//The code may become more complicated since you’re introducing a whole new layer between senders and receivers.
