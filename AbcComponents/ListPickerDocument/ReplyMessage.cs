using System.Runtime.Serialization;

namespace AbcComponentsHelper.ListPickerDocument
{
    [DataContract]
    public class ReplyMessage
    {
        [DataMember(Name = "style")]
        public string Style { get; set; } = "icon";

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "subtitle")]
        public string Subtitle { get; set; }

        [DataMember(Name = "imageIdentifier")]
        public string ImageIdentifier { get; set; }

        public ReplyMessage(string style, string title, string subtitle, string imageIdentifier)
        {
            Style = style;
            Title = title;
            Subtitle = subtitle;
            ImageIdentifier = imageIdentifier;
        }

        public ReplyMessage(string title, string subtitle) : this("icon", title, subtitle, default)
        {
        }

        public ReplyMessage(string title = "Quero esse") : this("icon", title, default, default)
        {
        }
    }
}