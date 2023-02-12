using System;

public class Game
{
    private Scripture _scripture;
    private List<int> hiddenWords;

    public Game(Scripture scripture)
    {
        _scripture = scripture;
        hiddenWords = new List<int>();
    }

    public void Play()
    {
        string[] words = _scripture.Text.Split(' ');

        while (hiddenWords.Count < words.Length)
        {
            Console.Clear();
            Console.Write(_scripture.Book + " " + _scripture.Chapter + ":" + _scripture.VerseRange.StartVerse + "-" + _scripture.VerseRange.EndVerse + " ");

            for (int i = 0; i < words.Length; i++)
            {
                if (hiddenWords.Contains(i))
                {
                    Console.Write("_ ");
                }
                else
                {
                    Console.Write(words[i] + " ");
                }
            }
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }
            else
            {
                int randomIndex = new Random().Next(0, words.Length);
                if (!hiddenWords.Contains(randomIndex))
                {
                    hiddenWords.Add(randomIndex);
                }
            }
        }
        
        Console.Clear();
        Console.WriteLine("Congratulations! You've successfully memorized the scripture:");
        Console.WriteLine(_scripture.Book + " " + _scripture.Chapter + ":" + _scripture.VerseRange.StartVerse + "-" + _scripture.VerseRange.EndVerse);
        Console.WriteLine();
        Console.WriteLine(_scripture.Text);  
    }
}
