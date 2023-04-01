using System;

public enum EventType
{
    Lecture,
    Reception,
    OutdoorGathering
}

public abstract class Event 
{
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;
    private EventType _type;

    public Event(string title, string description, DateTime dateTime, Address address, EventType type) {
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
        _type = type;
    }

    public virtual string GetDetails() 
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_dateTime.ToShortDateString()}\nTime: {_dateTime.ToShortTimeString()}\nAddress: {_address.GetFullAddress()}";
    }

    public virtual string GetFullDetails() 
    {
        return GetDetails();
    }

    public virtual string GetShortDescription() 
    {
        return $"{_type} - {_title} ({_dateTime.ToShortDateString()})";
    }
}