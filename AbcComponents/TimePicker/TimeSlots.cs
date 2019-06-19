using System.Runtime.Serialization;

namespace AbcComponentsHelper.TimePicker
{
    [DataContract]
    public class TimeSlots
    {
        [DataMember(Name = "duration")]
        public int Duration { get; set; } = 3600;

        [DataMember(Name = "startTime")]
        public string StartTime { get; set; }

        [DataMember(Name = "identifier")]
        public string Identifier { get; set; }

        public TimeSlots(int duration, string startTime, string identifier)
        {
            Duration = duration;
            StartTime = startTime;
            Identifier = identifier;
        }

        public TimeSlots(string startTime, string identifier) : this(3600, startTime, identifier)
        {
        }

        public TimeSlots(string startTime) : this(3600, startTime, startTime)
        {
        }
    }
}