// -------------------- The Defense of Consolas --------------------

using static System.Console;

Title = "Defense of Consolas";

Write("Target Row? ");
int row = int.Parse(ReadLine()!);

Write("Target Column? ");
int column = int.Parse(ReadLine()!);

WriteLine("\nDeploy to:");

ForegroundColor = ConsoleColor.DarkBlue;

WriteLine($"({row + 1}, {column})");
WriteLine($"({row}, {column + 1})");
WriteLine($"({row - 1}, {column})");
WriteLine($"({row}, {column - 1})");

Beep();
