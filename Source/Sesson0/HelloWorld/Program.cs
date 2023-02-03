using HelloWorld.Monsters;
// See https://aka.ms/new-console-template for more information
Draugr? dr = null;

try
{
    int i = 0;
    dr = new Draugr();
    dr.CharacterType = "Undead";
}
catch (System.Exception ex)
{
    Console.WriteLine("Error thrown");
}

Console.WriteLine(dr.CharacterType);
dr.BattleCry();
