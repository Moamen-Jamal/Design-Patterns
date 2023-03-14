using Dependency.Injection.Before;

Client client = new Client();
Console.ReadKey();

//Pros of Dependency Injection Design Pattern
//Improved testability: By decoupling the client from its dependencies, dependency injection makes it easier to write unit tests for the client. Dependencies can be replaced with mock implementations that allow the client to be tested in isolation.
//Increased flexibility: Dependency injection allows the client to work with different implementations of its dependencies without needing to be modified. This can make it easier to reuse the client in different contexts or to switch out dependencies as needed.
//Better maintainability: Dependency injection can make it easier to update or change the dependencies used by the client since the client does not need to be modified in order for the change to take effect.
//Improved readability: Dependency injection can make it easier to understand the relationships between different components in a system since the dependencies are explicitly defined and injected rather than being hard-coded into the client.
//Loose coupling: Dependency injection promotes loose coupling between components, which can make it easier to change or extend a system over time.

//Cons Dependency Injection Design Pattern
//Performance overhead: Dependency injection frameworks can add performance overhead to the application, as they need to create and inject the dependencies at runtime. This can be especially noticeable in applications with high-performance requirements or with a large number of dependencies.
//Increased complexity: Implementing dependency injection can add additional complexity to the code, especially if it involves creating a large number of interfaces and injectors. This can make the code more difficult to understand and maintain, especially for developers who are new to the codebase.
//Dependency on a framework: Using a dependency injection framework can introduce a dependency on that framework, which can make it more difficult to switch to a different framework or to remove the dependency injection framework altogether.
//Lack of control: Dependency injection frameworks can provide less control over the creation and injection of dependencies, as they handle these tasks automatically. This can make it more difficult to customize the injection process or to debug issues that arise.