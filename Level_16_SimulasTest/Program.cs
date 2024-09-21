// -------------------- Simula's Test --------------------

ChestState currentState = ChestState.Locked;

while (true)
{
    Console.Write($"The chest is {currentState.ToString().ToLower()}. " +
        "What do you want to do? ");
    string userInput = Console.ReadLine()!;

    if (currentState == ChestState.Locked && userInput == "unlock")
    {
        currentState = ChestState.Unlocked;
    }
    else if (currentState == ChestState.Unlocked && userInput == "lock")
    {
        currentState = ChestState.Locked;
    }
    else if (currentState == ChestState.Unlocked && userInput == "open")
    {
        currentState = ChestState.Open;
    }
    else if (currentState == ChestState.Open && userInput == "close")
    {
        currentState = ChestState.Unlocked;
    }
}

enum ChestState { Locked, Unlocked, Open }
