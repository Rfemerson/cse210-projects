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

        Video video1 = new Video("Chocolate Cake", "Ana", 660);
        
        video.AddComment("Alice", "Great video!");
        video.AddComment("Rachel", "Thanks for sharing!");

        Console.WriteLine("Title: {0}", video._title);
        Console.WriteLine("Author: {0}", video._author);
        Console.WriteLine("Length: {0} seconds", video._length);
        Console.WriteLine("Number of comments: {0}", video.GetNumberOfComments());

        foreach (Comment comment in video.Comments) {
            Console.WriteLine("{0}: {1}", comment._name, comment._text);
        }

        Video video2 = new Video("Super Bowl Highlights", "NFL Highlights", 660);
        
        video.AddComment("Jack", "Go Eagles!");
        video.AddComment("Emma", "I love Chiefs");

        Console.WriteLine("Title: {0}", video._title);
        Console.WriteLine("Author: {0}", video._author);
        Console.WriteLine("Length: {0} seconds", video._length);
        Console.WriteLine("Number of comments: {0}", video.GetNumberOfComments());

        foreach (Comment comment in video.Comments) {
            Console.WriteLine("{0}: {1}", comment._name, comment._text);
        }
    }
}