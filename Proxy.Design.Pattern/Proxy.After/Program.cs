using Proxy.After;
using ProxyClass = Proxy.After.Proxy;

Client client = new Client();

Console.WriteLine("Client: Executing the same client code with a proxy:");
RealSubject realSubject = new RealSubject();
ProxyClass proxy = new ProxyClass(realSubject);
client.ClientCode(proxy);

Console.ReadKey();