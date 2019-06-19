using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AbcComponentsHelper.TimePicker
{
    [DataContract]
    public class Event
    {
        [DataMember(Name = "timezoneOffSet")]
        public int TimezoneOffSet { get; set; } = -180;

        [DataMember(Name = "identifier")]
        public string Identifier { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "timeslots")]
        public IEnumerable<TimeSlots> TimeSlots { get; set; }

        [DataMember(Name = "location")]
        public Location Location { get; set; }

        public Event(int timeZoneOffSet, string identifier, string title, IEnumerable<TimeSlots> timeSlots, Location location)
        {
            TimezoneOffSet = timeZoneOffSet;
            Identifier = identifier;
            Title = title;
            TimeSlots = timeSlots;
            Location = location;
        }

        public Event(string identifier, string title, IEnumerable<TimeSlots> timeSlots, Location location) : this(-180, identifier, title, timeSlots, location)
        {
        }

        public Event(string identifier, string title, Location location, params TimeSlots[] timeSlots) : this(-180, identifier, title, timeSlots, location)
        {
        }

        public Event(string identifier, IEnumerable<TimeSlots> timeSlots) : this(-180, identifier, default, timeSlots, default)
        {
        }

        public Event(string identifier, params TimeSlots[] timeSlots) : this(-180, identifier, default, timeSlots, default)
        {
        }

        public Event(string identifier, IEnumerable<TimeSlots> timeSlots, Location location) : this(-180, identifier, default, timeSlots, location)
        {
        }

        public Event(string identifier, Location location, params TimeSlots[] timeSlots) : this(-180, identifier, default, timeSlots, location)
        {
        }

        public Event(string identifier, string title, IEnumerable<TimeSlots> timeSlots) : this(-180, identifier, title, timeSlots, default)
        {
        }

        public Event(string identifier, string title, params TimeSlots[] timeSlots) : this(-180, identifier, title, timeSlots, default)
        {
        }

        public Event(params TimeSlots[] timeSlots) : this(-180, default, default, timeSlots, default)
        {
        }

        public Event(IEnumerable<TimeSlots> timeSlots) : this(-180, default, default, timeSlots, default)
        {
        }
    }
}
