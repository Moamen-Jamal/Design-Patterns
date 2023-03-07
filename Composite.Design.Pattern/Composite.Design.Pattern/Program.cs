//Creating Leaf Objects
using Composite.Design.Pattern;
using CompositeClass = Composite.Design.Pattern.Composite;

IComponent hardDisk = new Leaf("Hard Disk", 2000);
IComponent ram = new Leaf("RAM", 3000);
IComponent cpu = new Leaf("CPU", 2000);
IComponent mouse = new Leaf("Mouse", 2000);
IComponent keyboard = new Leaf("Keyboard", 2000);

//Creating composite objects
CompositeClass motherBoard = new CompositeClass("motherBoard");
CompositeClass cabinet = new CompositeClass("Cabinet");
CompositeClass peripherals = new CompositeClass("Peripherals");
CompositeClass computer = new CompositeClass("Computer");

//Creating tree structure
//Ading CPU and RAM in Mother board
motherBoard.AddComponent(cpu);
motherBoard.AddComponent(ram);

//Ading mother board and hard disk in Cabinet
cabinet.AddComponent(motherBoard);
cabinet.AddComponent(hardDisk);

//Ading mouse and keyborad in peripherals
peripherals.AddComponent(mouse);
peripherals.AddComponent(keyboard);

//Ading cabinet and peripherals in computer
computer.AddComponent(cabinet);
computer.AddComponent(peripherals);

//To display the Price of Computer
computer.DisplayPrice();
Console.WriteLine();

//To display the Price of Keyboard
keyboard.DisplayPrice();
Console.WriteLine();

//To display the Price of Cabinet
cabinet.DisplayPrice();
Console.Read();

//Pros of Composite Design Pattern

// You can work with complex tree structures more conveniently: use polymorphism and recursion to your advantage.
// Open/Closed Principle. You can introduce new element types into the app without breaking the existing code, which now works with the object tree.

//Cons of Composite Design Pattern
//It might be difficult to provide a common interface for classes whose functionality differs too much.In certain scenarios, you’d need to overgeneralize the component interface, making it harder to comprehend.