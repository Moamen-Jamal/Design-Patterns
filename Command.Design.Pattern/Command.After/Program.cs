using Command.After;

var AliInvoker = new Invoker();

var MomenReceiver = new Receiver(1);

var sendMoneyCommand = new SendMoneyCommand(MomenReceiver);

AliInvoker.Execute(sendMoneyCommand);

AliInvoker.Undo(sendMoneyCommand);

Console.WriteLine("Second Case ------");

var OmarReceiver = new Receiver(2);
var AmrReceiver = new Receiver(3);

var SendMoneyToAllCommand = new SendMoneyToAllCommand(new List<Receiver>() { OmarReceiver, AmrReceiver });

AliInvoker.Execute(SendMoneyToAllCommand);

AliInvoker.Undo(SendMoneyToAllCommand);

Console.ReadLine();