using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AbcComponentsHelper.TimePicker
{
    [DataContract]
    public class TimePickerDocument
    {
        [DataMember(Name = "id")]
        public string Id { get; set; } = "<populated on send>";

        [DataMember(Name = "sourceId")]
        public string SourceId { get; set; } = "<populated on send>";

        [DataMember(Name = "destinationId")]
        public string DestinationId { get; set; } = "<populated on send>";

        [DataMember(Name = "interactiveData")]
        public TimePickerInteractiveData InteractiveData { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        public TimePickerDocument(TimePickerInteractiveData interactiveData, string type)
        {
            InteractiveData = interactiveData;
            Type = type;
        }

        public TimePickerDocument(TimePickerInteractiveData interactiveData) : this(interactiveData, "interactive")
        {
        }
    }

    //[DataContract]
    //public class TimePickerInteractiveData
    //{
    //    [DataMember(Name = "bid")]
    //    public string Bid { get; set; } = "com.apple.messages.MSMessageExtensionBalloonPlugin:0000000000:com.apple.icloud.apps.messages.business.extension";

    //    [DataMember(Name = "data")]
    //    public TimePickerData Data { get; set; }

    //    [DataMember(Name = "useLiveLayout")]
    //    public bool UseLiveLayout { get; set; }

    //    [DataMember(Name = "receivedMessage")]
    //    public TimePickerReceivedMessage ReceivedMessage { get; set; }

    //    [DataMember(Name = "replyMessage")]
    //    public TimePickerReplyMessage ReplyMessage { get; set; }

    //    public TimePickerInteractiveData(TimePickerData data, bool useLiveLayout, TimePickerReceivedMessage receivedMessage, TimePickerReplyMessage replyMessage)
    //    {
    //        Data = data;
    //        UseLiveLayout = useLiveLayout;
    //        ReceivedMessage = receivedMessage;
    //        ReplyMessage = replyMessage;
    //    }

    //    public TimePickerInteractiveData(TimePickerData data, TimePickerReceivedMessage receivedMessage, TimePickerReplyMessage replyMessage) : this(data, true, receivedMessage, replyMessage)
    //    {
    //    }

    //    public TimePickerInteractiveData(TimePickerData data, TimePickerReceivedMessage receivedMessage) : this(data, true, receivedMessage, new TimePickerReplyMessage())
    //    {
    //    }

    //    public TimePickerInteractiveData(TimePickerData data, bool useLiveLayout, TimePickerReceivedMessage receivedMessage) : this(data, useLiveLayout, receivedMessage, new TimePickerReplyMessage())
    //    {
    //    }
    //}

    //[DataContract]
    //public class TimePickerData
    //{
    //    [DataMember(Name = "version")]
    //    public string Version { get; set; } = "1.0";

    //    [DataMember(Name = "requestIdentifier")]
    //    public string RequestIdentifier { get; set; } = "<populated on send>";

    //    [DataMember(Name = "event")]
    //    public Event Event { get; set; }

    //    public TimePickerData(string version, Event events)
    //    {
    //        Version = version;
    //        Event = events;
    //    }

    //    public TimePickerData(Event events) : this(default, events)
    //    {
    //    }
    //}

    //[DataContract]
    //public class Event
    //{
    //    [DataMember(Name = "timezoneOffSet")]
    //    public int TimezoneOffSet { get; set; } = -180;

    //    [DataMember(Name = "identifier")]
    //    public string Identifier { get; set; }

    //    [DataMember(Name = "title")]
    //    public string Title { get; set; }

    //    [DataMember(Name = "timeslots")]
    //    public IEnumerable<TimeSlots> TimeSlots { get; set; }

    //    [DataMember(Name = "location")]
    //    public Location Location { get; set; }

    //    public Event(int timeZoneOffSet, string identifier, string title, IEnumerable<TimeSlots> timeSlots, Location location)
    //    {
    //        TimezoneOffSet = timeZoneOffSet;
    //        Identifier = identifier;
    //        Title = title;
    //        TimeSlots = timeSlots;
    //        Location = location;
    //    }

    //    public Event(string identifier, string title, IEnumerable<TimeSlots> timeSlots, Location location) : this(-180, identifier, title, timeSlots, location)
    //    {
    //    }

    //    public Event(string identifier, string title, Location location, params TimeSlots[] timeSlots) : this(-180, identifier, title, timeSlots, location)
    //    {
    //    }

    //    public Event(string identifier, IEnumerable<TimeSlots> timeSlots) : this(-180, identifier, default, timeSlots, default)
    //    {
    //    }

    //    public Event(string identifier, params TimeSlots[] timeSlots) : this(-180, identifier, default, timeSlots, default)
    //    {
    //    }

    //    public Event(string identifier, IEnumerable<TimeSlots> timeSlots, Location location) : this(-180, identifier, default, timeSlots, location)
    //    {
    //    }

    //    public Event(string identifier, Location location, params TimeSlots[] timeSlots) : this(-180, identifier, default, timeSlots, location)
    //    {
    //    }

    //    public Event(string identifier, string title, IEnumerable<TimeSlots> timeSlots) : this(-180, identifier, title, timeSlots, default)
    //    {
    //    }

    //    public Event(string identifier, string title, params TimeSlots[] timeSlots) : this(-180, identifier, title, timeSlots, default)
    //    {
    //    }

    //    public Event(params TimeSlots[] timeSlots) : this(-180, default, default, timeSlots, default)
    //    {
    //    }

    //    public Event(IEnumerable<TimeSlots> timeSlots) : this(-180, default, default, timeSlots, default)
    //    {
    //    }
    //}

    //[DataContract]
    //public class Location
    //{
    //    [DataMember(Name = "latitude")]
    //    public double Latitude { get; set; }

    //    [DataMember(Name = "longitude")]
    //    public double Longitude { get; set; }

    //    [DataMember(Name = "radius")]
    //    public double Radius { get; set; }

    //    [DataMember(Name = "title")]
    //    public double Title { get; set; }

    //    public Location(double latitude, double longitude, double radius, double title)
    //    {
    //        Latitude = latitude;
    //        Longitude = longitude;
    //        Radius = radius;
    //        Title = title;
    //    }
    //}

    //[DataContract]
    //public class TimeSlots
    //{
    //    [DataMember(Name = "duration")]
    //    public int Duration { get; set; } = 3600;

    //    [DataMember(Name = "startTime")]
    //    public string StartTime { get; set; }

    //    [DataMember(Name = "identifier")]
    //    public string Identifier { get; set; }

    //    public TimeSlots(int duration, string startTime, string identifier)
    //    {
    //        Duration = duration;
    //        StartTime = startTime;
    //        Identifier = identifier;
    //    }

    //    public TimeSlots(string startTime, string identifier) : this(3600, startTime, identifier)
    //    {
    //    }

    //    public TimeSlots(string startTime) : this(3600, startTime, startTime)
    //    {
    //    }
    //}

    //[DataContract]
    //public partial class TimePickerReceivedMessage
    //{
    //    [DataMember(Name = "style")]
    //    public string Style { get; set; } = "small";

    //    [DataMember(Name = "title")]
    //    public string Title { get; set; }

    //    [DataMember(Name = "subtitle")]
    //    public string Subtitle { get; set; }

    //    [DataMember(Name = "imageIdentifier")]
    //    public string ImageIdentifier { get; set; }

    //    public TimePickerReceivedMessage(string style, string title, string subtitle, string imageIdentifier)
    //    {
    //        Style = style;
    //        Title = title;
    //        Subtitle = subtitle;
    //        ImageIdentifier = imageIdentifier;
    //    }

    //    public TimePickerReceivedMessage(string title, string subtitle, string imageIdentifier) : this("icon", title, subtitle, imageIdentifier)
    //    {
    //    }

    //    public TimePickerReceivedMessage(string title, string subtitle) : this("icon", title, subtitle, default)
    //    {
    //    }

    //    public TimePickerReceivedMessage(string title) : this("icon", title, default, default)
    //    {
    //    }
    //}

    //[DataContract]
    //public partial class TimePickerReplyMessage
    //{
    //    [DataMember(Name = "style")]
    //    public string Style { get; set; } = "icon";

    //    [DataMember(Name = "title")]
    //    public string Title { get; set; }

    //    [DataMember(Name = "subtitle")]
    //    public string Subtitle { get; set; }

    //    [DataMember(Name = "imageIdentifier")]
    //    public string ImageIdentifier { get; set; }

    //    public TimePickerReplyMessage(string style, string title, string subtitle, string imageIdentifier)
    //    {
    //        Style = style;
    //        Title = title;
    //        Subtitle = subtitle;
    //        ImageIdentifier = imageIdentifier;
    //    }

    //    public TimePickerReplyMessage(string title, string subtitle) : this("icon", title, subtitle, default)
    //    {
    //    }

    //    public TimePickerReplyMessage(string title = "Quero esse") : this("icon", title, default, default)
    //    {
    //    }
    //}
}