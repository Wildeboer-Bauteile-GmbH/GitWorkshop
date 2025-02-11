namespace ConsoleApp1;

internal class Lukas
{
    public Lukas(string vorname)
    {
        Vorname = vorname;
    }

    internal string Vorname { get; set; }

    public void TellJoke()
    {
        Console.WriteLine("Warum können Geister so gut programmieren? Weil sie immer den Durchblick haben!");

    }
    public void TellAnotherJoke()
    {
        Console.WriteLine("Warum sind Computer so schlecht im Boxen? Weil sie immer abstürzen!");
    }
    public void TellThirdJoke()
    {
        Console.WriteLine("Warum können Programmierer keine guten Tänzer sein? Weil sie immer nur in Schleifen denken!");
    }

    
}