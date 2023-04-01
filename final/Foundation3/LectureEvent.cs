using System;

public class LectureEvent : Event 
{
    private string _speakerName;
    private int _capacity;

    public LectureEvent(string title, string description, DateTime dateTime, Address address, string speakerName, int capacity) : base(title, description, dateTime, address, EventType.Lecture) 
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override string GetFullDetails() 
    {
        return $"{base.GetFullDetails()}\nSpeaker: {_speakerName}\nCapacity: {_capacity}";
    }
}