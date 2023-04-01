using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("50 N W Temple St", "Salt Lake City", "UT", "84150");

        LectureEvent lecture = new LectureEvent(
            "Intro to C# Programming",
            "Learn the basics of C# programming",
            new DateTime(2023, 3, 25, 10, 0, 0),
            address,
            "John Smith",
            50
        );

        ReceptionEvent reception = new ReceptionEvent(
            "Networking Mixer",
            "A chance to meet and network with other professionals",
            new DateTime(2023, 4, 1, 18, 0, 0),
            address,
            "rsvp@example.com"
        );

        OutdoorGatheringEvent gathering = new OutdoorGatheringEvent(
            "Picnic in the Park",
            "Enjoy a relaxing afternoon in the park with friends and family",
            new DateTime(2023, 4, 15, 12, 0, 0),
            address,
            "Sunny with a high of 75 degrees"
        );

        // Print standard event details
        Console.WriteLine("Standard details:");
        Console.WriteLine(lecture.GetDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetDetails());
        Console.WriteLine();
        Console.WriteLine(gathering.GetDetails());
        Console.WriteLine();

        // Print full event details
        Console.WriteLine("Full details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(gathering.GetFullDetails());
        Console.WriteLine();

        // Print short event description
        Console.WriteLine("Short description:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(gathering.GetShortDescription());
    }
}