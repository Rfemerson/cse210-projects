using System;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video("taking off with my car", "EmersonVLOG", 120);
        
        video.AddComment("Peter", "Great video!");
        video.AddComment("Jacob", "So cool!");

        Console.WriteLine("Title: {0}", video._title);
        Console.WriteLine("Author: {0}", video._author);
        Console.WriteLine("Length: {0} seconds", video._length);
        Console.WriteLine("Number of comments: {0}", video.GetNumberOfComments());

        foreach (Comment comment in video.Comments) {
            Console.WriteLine("{0}: {1}", comment._name, comment._text);
        }

        Console.WriteLine();

        Video video1 = new Video("Chocolate Cake", "Ana", 660);
        
        video1.AddComment("Alice", "Great video!");
        video1.AddComment("Rachel", "Thanks for sharing!");

        Console.WriteLine("Title: {0}", video1._title);
        Console.WriteLine("Author: {0}", video1._author);
        Console.WriteLine("Length: {0} seconds", video1._length);
        Console.WriteLine("Number of comments: {0}", video1.GetNumberOfComments());

        foreach (Comment comment in video1.Comments) {
            Console.WriteLine("{0}: {1}", comment._name, comment._text);
        }

        Console.WriteLine();

        Video video2 = new Video("Super Bowl Highlights", "NFL Highlights", 1060);
        
        video2.AddComment("Jack", "Go Eagles!");
        video2.AddComment("Emma", "I love Chiefs");

        Console.WriteLine("Title: {0}", video2._title);
        Console.WriteLine("Author: {0}", video2._author);
        Console.WriteLine("Length: {0} seconds", video2._length);
        Console.WriteLine("Number of comments: {0}", video2.GetNumberOfComments());

        foreach (Comment comment in video2.Comments) {
            Console.WriteLine("{0}: {1}", comment._name, comment._text);
        }
    }
}