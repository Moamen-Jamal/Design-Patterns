using Template.Method.After;

var order1 = new MakeRoundedPizza();
order1.MakePizza();
Console.WriteLine("--------------------");
var order2 = new MakeRectanglePizza();
order2.MakePizza();

Console.Read();
