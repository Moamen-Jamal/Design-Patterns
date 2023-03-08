using Facade.Before;

Console.WriteLine("Place Order Started");
Product product = new Product();
product.GetProductDetails();
Payment payment = new Payment();
payment.MakePayment();
Invoice invoice = new Invoice();
invoice.Sendinvoice();
Console.WriteLine("Order Placed Successfully");
Console.Read();

//Pros of Facade Design Pattern
//You can isolate your code from the complexity of a subsystem.

//Cons of Facade Design Pattern
//A facade can become a god object coupled to all classes of an app.