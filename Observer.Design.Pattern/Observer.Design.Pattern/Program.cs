//Create a Product with Out Of Stock Status
using Observer.Design.Pattern;

Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");
//User Anurag will be created and user1 object will be registered to the subject
ObserverClass user1 = new ObserverClass("Moamen", RedMI);
//User Pranaya will be created and user1 object will be registered to the subject
ObserverClass user2 = new ObserverClass("Jamal", RedMI);
//User Priyanka will be created and user3 object will be registered to the subject
ObserverClass user3 = new ObserverClass("Mohamed", RedMI);

Console.WriteLine("Red MI Mobile current state : " + RedMI.getAvailability());
Console.WriteLine();
// Now product is available
RedMI.setAvailability("Available");
Console.Read();

//Pros of Observer

// Open / Closed Principle.You can introduce new subscriber classes without having to change the publisher’s code (and vice versa if there’s a publisher interface).
// You can establish relations between objects at runtime.

//Cons of Observer 
//Subscribers are notified in random order.