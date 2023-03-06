using State.Before;

ATMMachine ATMMachine = new ATMMachine();
if(ATMMachine != null)
{
    // Initially ATM Machine in DebitCardNotInsertedState
    if (ATMMachine.atmMachineState == "DebitCardNotInsertedState")
    {
        
        Console.WriteLine("ATM Machine Current state : "
                                + ATMMachine.atmMachineState);

        Console.WriteLine("you cannot enter the pin, as No Debit Card in ATM Machine slot");

        Console.WriteLine("you cannot withdraw money, as No Debit Card in ATM Machine slot");

        Console.WriteLine("You cannot eject the Debit CardNo, as no Debit Card in ATM Machine slot");

        Console.WriteLine("DebitCard Inserted");

        ATMMachine.atmMachineState = "DebitCardInsertedState";
    }

    if (ATMMachine.atmMachineState == "DebitCardInsertedState")
    {
        Console.WriteLine();

        Console.WriteLine("ATM Machine internal state has been moved to : "
                                + ATMMachine.atmMachineState);

        Console.WriteLine("ATM Machine Current state : "
                                + ATMMachine.atmMachineState);

        Console.WriteLine("Pin number has been entered correctly");

        Console.WriteLine("Money has been withdrawn");

        Console.WriteLine("Debit Card is ejected");

        Console.WriteLine("You cannot insert the Debit Card, as the Debit card is already there ");

        Console.WriteLine("Debit Card is ejected");

        ATMMachine.atmMachineState = "DebitCardNotInsertedState";
    }

    Console.Read();
}

//Pros of State Design Pattern

// Single Responsibility Principle. Organize the code related to particular states into separate classes.
// Open/Closed Principle. Introduce new states without changing existing state classes or the context.
// Simplify the code of the context by eliminating bulky state machine conditionals.

//Cons of State Design Pattern

// Applying the pattern can be overkill if a state machine has only a few states or rarely changes.
