// -------------------- The Fountain of Objects --------------------

Game game = new();
game.Run();


public class Room
{
    public int Row { get; set; }
    public int Column { get; set; }
}

class Entrance : Room { }
class EmptyRoom : Room { }
class FountainRoom : Room
{
    public bool FountainState { get; set; } = false;
}