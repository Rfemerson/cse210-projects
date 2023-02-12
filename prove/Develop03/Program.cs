using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("Proverbs", 3, new VerseRange(5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
        Game game = new Game(scripture);
        game.Play();
    }
}