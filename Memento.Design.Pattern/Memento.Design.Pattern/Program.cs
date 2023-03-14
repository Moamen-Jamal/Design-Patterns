using Memento.Design.Pattern;

var game = new GameOriginator("Moamen Jamal", 0);
var caretaker =  new Caretaker();

//save
caretaker.Save(game);

//change in score
game.playerScore = 50;

Console.WriteLine($"Before undo --> Secore: {game.playerScore}");

//play from last checkpoint
caretaker.Revert(game);
Console.WriteLine($"After undo --> Secore: {game.playerScore}");

Console.ReadLine();

//Pros of Memento Design Pattern
// You can produce snapshots of the object’s state without violating its encapsulation.
// You can simplify the originator’s code by letting the caretaker maintain the history of the originator’s state.

//Cons of Memento Design Pattern
// The app might consume lots of RAM if clients create mementos too often.
// Caretakers should track the originator’s lifecycle to be able to destroy obsolete mementos.
// Most dynamic programming languages, such as PHP, Python and JavaScript, can’t guarantee that the state within the memento stays untouched.
