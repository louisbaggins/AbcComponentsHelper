using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AbcComponentsHelper.TimePicker
{
    [DataContract]
    public class TimePickerData
    {
        [DataMember(Name = "version")]
        public string Version { get; set; } = "1.0";

        [DataMember(Name = "requestIdentifier")]
        public string RequestIdentifier { get; set; } = "<populated on send>";

        [DataMember(Name = "event")]
        public Event Event { get; set; }

        public TimePickerData(string version, Event events)
        {
            Version = version;
            Event = events;
        }

        public TimePickerData(Event events) : this(default, events)
        {
        }
    }
}
