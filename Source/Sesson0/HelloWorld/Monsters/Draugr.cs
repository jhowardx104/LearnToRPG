namespace HelloWorld.Monsters;

public class Draugr
{
    public Draugr(int? hp = null)
    {
        if(hp is not null)
        {
            HP = (int)hp;
        }
    }

    private int _hp = 25;
    private int HP { 
        get {
            return _hp;
        }
        set{
            if(value < 0)
            {
                _hp = 0;
            }
            else
            {
                _hp = value;
            }
        }
    }
    public bool HasFallen => HP == 0;
    public string CharacterType { get; set; }
    public List<string> Attacks { get; set; }
    public List<string> Armor {get; set; }
    public List<string> Weapons { get; set; }
    public void BattleCry()
    {
        Console.WriteLine("Balooga.");
    }
}