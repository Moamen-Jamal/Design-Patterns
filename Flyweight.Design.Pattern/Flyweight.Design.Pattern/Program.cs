using Flyweight.Design.Pattern;

var player1 = PlayerFactory.GetPlayer("BlueTeam");
player1.Weapon = "AK47";
Console.WriteLine("Player One");
player1.Render();



var player2 = PlayerFactory.GetPlayer("BlueTeam");
player2.Weapon = "M4";
Console.WriteLine("Player Two");
player2.Render();
Console.WriteLine("ReferenceEquals(player1, player2) = {0}",
                            ReferenceEquals(player1, player2));

Console.Read();

//Pros of Flyweight Design Pattern
//You can save lots of RAM, assuming your program has tons of similar objects.

//Cons of Flyweight Design Pattern

// You might be trading RAM over CPU cycles when some of the context data needs to be recalculated each time somebody calls a flyweight method.
// The code becomes much more complicated. New team members will always be wondering why the state of an entity was separated in such a way.