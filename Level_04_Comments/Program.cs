// -------------------- The Thing Namer 3000 --------------------

WriteLine("What kind of thing are we talking about?");
string a = ReadLine()!; // thing

WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = ReadLine()!; /* description */

string c = "Doom"; // removed "of" to fix "of of" bug
string d = "3000"; // number

WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");

/* 
  Answer this question: Aside from comments, what else could you do to make this code more
  understandable?

  Properly naming variables.
 */