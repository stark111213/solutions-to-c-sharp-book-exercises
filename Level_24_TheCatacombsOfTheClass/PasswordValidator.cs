using System.Runtime.InteropServices;

internal class PasswordValidator
{
    private string _password;

    private string AskForPassword(string text)
    {
        Write(text);
        return ReadLine()!;
    }
    private void DisplayRules()
    {
        WriteLine("Password:");
        WriteLine("> must be more than 6 and less than 13 letters long.");
        WriteLine("> must contain at least one uppercase letter," +
            " one lowercase letter, and one number.");
        WriteLine("> cannot contain a capital T or an ampersand (&)\n");
    }

    private bool IsValidLength()
    {
        foreach (char c in _password)
        {
            if (_password.Length >= 6 && _password.Length <= 13) return true;
        }
        return false;
    }

    private bool ContainsLowerCase()
    {
        foreach (char c in _password)
        {
            if (char.IsLower(c)) return true;
        }
        return false;
    }

    private bool ContainsUpperCase()
    {
        foreach (char c in _password)
        {
            if (char.IsUpper(c)) return true;
        }
        return false;
    }

    private bool ContainsNumber()
    {
        foreach (char c in _password)
        {
            if (char.IsNumber(c)) return true;
        }
        return false;
    }

    private bool AllowedCharacters()
    {
        foreach (char c in _password)
        {
            if (c == 'T' || c == '&') return false;
        }
        return true;
    }

    public void IsValidPassword()
    {
        if (IsValidLength()     &&
            ContainsLowerCase() &&
            ContainsUpperCase() && 
            ContainsNumber()    &&
            AllowedCharacters()
            )
        {
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine("Password is valid.\n");
            ForegroundColor = ConsoleColor.White;
        }
        else
        {
            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("Invalid password.\n");
            ForegroundColor = ConsoleColor.White;
        }
    }

    public void Run()
    {
        DisplayRules();
        ForegroundColor = ConsoleColor.Blue;
        _password = AskForPassword("Enter valid password: ");
        IsValidPassword();
    }
}

/*
 
PasswordValidator a = new();

while(true)
{
    a.Run();
} 

*/