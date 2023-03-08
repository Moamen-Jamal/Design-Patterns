using Bridge.Design.Pattern;

Console.WriteLine("Select the Message Type 1. For longmessage or 2. For shortmessage");
int MessageType = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the message that you want to send");
string Message = Console.ReadLine();
if (MessageType == 1)
{
    AbstractMessage longMessage = new LongMessage(new EmailMessageSender());
    longMessage.SendMessage(Message);
}
else
{
    AbstractMessage shortMessage = new ShortMessage(new SmsMessageSender());
    shortMessage.SendMessage(Message);
}
Console.ReadKey();

//Pros of Bridge Design Pattern

// You can create platform-independent classes and apps.
// The client code works with high-level abstractions. It isn’t exposed to the platform details.
// Open/Closed Principle. You can introduce new abstractions and implementations independently from each other.
// Single Responsibility Principle. You can focus on high-level logic in the abstraction and on platform details in the implementation.

//Cons of Bridge Design Pattern
// You might make the code more complicated by applying the pattern to a highly cohesive class.