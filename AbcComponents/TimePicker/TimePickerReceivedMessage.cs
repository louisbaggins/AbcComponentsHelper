using System.Runtime.Serialization;

namespace AbcComponentsHelper.TimePicker
{
    [DataContract]
    public class TimePickerReceivedMessage
    {
        [DataMember(Name = "style")]
        public string Style { get; set; } = "small";

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "subtitle")]
        public string Subtitle { get; set; }

        [DataMember(Name = "imageIdentifier")]
        public string ImageIdentifier { get; set; }

        public TimePickerReceivedMessage(string style, string title, string subtitle, string imageIdentifier)
        {
            Style = style;
            Title = title;
            Subtitle = subtitle;
            ImageIdentifier = imageIdentifier;
        }

        public TimePickerReceivedMessage(string title, string subtitle, string imageIdentifier) : this("icon", title, subtitle, imageIdentifier)
        {
        }

        public TimePickerReceivedMessage(string title, string subtitle) : this("icon", title, subtitle, default)
        {
        }

        public TimePickerReceivedMessage(string title) : this("icon", title, default, default)
        {
        }
    }
}