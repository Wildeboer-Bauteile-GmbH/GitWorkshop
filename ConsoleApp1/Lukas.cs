﻿namespace ConsoleApp1;

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
}