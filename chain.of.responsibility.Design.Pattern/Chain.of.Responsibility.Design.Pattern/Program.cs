using Chain.of.Responsibility.Design.Pattern;

var userName = new UserNameHandler();
var emailAddress = new EmailHandler();
var phoneNumber = new PhoneNumberHandler();

userName.SetNext(emailAddress).SetNext(phoneNumber);

// The client should be able to send a request to any handler, not
// just the first one in the chain.
Console.WriteLine("Chain: UserName > Email > PhoneNumber\n");
Client.ClientCode(userName);
Console.WriteLine();

Console.WriteLine("Subchain: Email > PhoneNumber\n");
Client.ClientCode(emailAddress);

Console.ReadLine();

//Pros of Chain of Responsibility

// You can control the order of request handling.
// Single Responsibility Principle. You can decouple classes that invoke operations from classes that perform operations.
// Open/Closed Principle. You can introduce new handlers into the app without breaking the existing client code.

//Cons of Chain of Responsibility

// Some requests may end up unhandled.
