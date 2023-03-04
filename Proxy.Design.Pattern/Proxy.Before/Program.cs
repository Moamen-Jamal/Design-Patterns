

using Proxy.Before;

Client client = new Client();

Console.WriteLine("Client: Executing the client code with a real subject:");

RealSubject realSubject = new RealSubject();
client.ClientCode(realSubject);

Console.ReadLine();

//Pros of Proxy Design Pattern

// You can control the service object without clients knowing about it.
// You can manage the lifecycle of the service object when clients don’t care about it.
// The proxy works even if the service object isn’t ready or is not available.
// Open/Closed Principle. You can introduce new proxies without changing the service or clients.

//Cons of Proxy Design Pattern

// The code may become more complicated since you need to introduce a lot of new classes.
// The response from the service might get delayed.
