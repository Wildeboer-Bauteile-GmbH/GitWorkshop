namespace ConsoleApp1;

internal class Lukas
{
    public Lukas(string vorname)
    {
        Vorname = vorname;
    }

    internal string Vorname { get; set; }

    public void TellAnotherJoke()
    {
        Console.WriteLine("Warum sind Computer so schlecht im Boxen? Weil sie immer abstürzen!");
    }

    public void TellJoke()
    {
        Console.WriteLine("Warum können Geister so gut programmieren? Weil sie immer den Durchblick haben!");
    }

    public void TellNonProgrammingJoke()
    {
        Console.WriteLine("Warum können Seeräuber keine Kreise zeichnen? Weil sie immer Pi raten!");
    }

    /// <summary>
    /// :-)
    /// </summary>
    public void ImAJokerIAmASmokerImAMidnightTalker()
    { 
        Console.WriteLine("I'm a joker");
    }
}