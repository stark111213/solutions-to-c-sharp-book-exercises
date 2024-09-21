internal class Door
{
    ChestState currentState = ChestState.Locked;

    private int passcode;
    public Door (int Passcode)
    {
        passcode = Passcode;
    }

    void ChangePasscode()
    {
        int currentCode = AskForNumber("Enter current passcode: ");

        if (currentCode == passcode)
        {
            passcode = AskForNumber("Enter new code: ");
        }
        else
        {
            WriteLine("Wrong passcode.");
        }
    }

    int AskForNumber(string text)
    {
        Write(text);
        return int.Parse(ReadLine()!);
    }

    public void bla()
    {
        while (true)
        {
            Write($"The chest is {currentState.ToString().ToLower()}. " +
                "What do you want to do? " +
                "(open, close, lock, unlock, change code) "
                );
            string userInput = ReadLine()!;

            if (currentState == ChestState.Locked && userInput == "unlock")
            {
                int currentCode = AskForNumber("Enter current passcode: ");
                
                if (currentCode == passcode)
                {
                    currentState = ChestState.Unlocked;
                }
                else
                {
                    WriteLine("Wrong passcode");
                }
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
            else if (userInput == "change code")
            {
                ChangePasscode();
            }
        }
    }
}

enum ChestState { Locked, Unlocked, Open }


/*

Door door = new(123);
door.bla(); 

*/