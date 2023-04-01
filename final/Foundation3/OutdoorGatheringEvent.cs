using System;

public class OutdoorGatheringEvent : Event 
{
    private string _weatherForecast;

    public OutdoorGatheringEvent(string title, string description, DateTime dateTime, Address address, string weatherForecast) : base(title, description, dateTime, address, EventType.OutdoorGathering) 
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails() {
        return $"{base.GetFullDetails()}\nWeather forecast: {_weatherForecast}";
    }
}