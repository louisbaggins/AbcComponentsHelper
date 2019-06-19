using System.Runtime.Serialization;

namespace AbcComponentsHelper.ListPickerDocument
{
    [DataContract]
    public class ReceivedMessage
    {
        [DataMember(Name = "style")]
        public string Style { get; set; } = "small";

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "subtitle")]
        public string Subtitle { get; set; }

        [DataMember(Name = "imageIdentifier")]
        public string ImageIdentifier { get; set; }

        public ReceivedMessage(string style, string title, string subtitle, string imageIdentifier)
        {
            Style = style;
            Title = title;
            Subtitle = subtitle;
            ImageIdentifier = imageIdentifier;
        }

        public ReceivedMessage(string title, string subtitle, string imageIdentifier) : this("small", title, subtitle, imageIdentifier)
        {
        }

        public ReceivedMessage(string title, string subtitle) : this("small", title, subtitle, default)
        {
        }

        public ReceivedMessage(string title) : this("small", title, default, default)
        {
        }
    }
}