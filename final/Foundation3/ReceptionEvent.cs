using System;

public class ReceptionEvent : Event 
{
    private string _rsvpEmail;

    public ReceptionEvent(string title, string description, DateTime dateTime, Address address, string rsvpEmail) : base(title, description, dateTime, address, EventType.Reception) 
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails() 
    {
        return $"{base.GetFullDetails()}\nRSVP email: {_rsvpEmail}";
    }
}