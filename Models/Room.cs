public class Room
{
    public int Id { get; set; }
    public string ?Name { get; set;}
    public List<Player>? Players { get; set;}
    public List<Action>? Actions { get; set;}
    public Player? CurrentTurn { get; set; }
    public bool GameStarted { get; set; }

    public Room()
    {
        Players = new List<Player>();
        Actions = new List<Action>();
        GameStarted = false;
    }

    public void NextTurn(){
        if (CurrentTurn != null)
        {
            
        }
    }

}