using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AbcComponentsHelper.TimePicker
{
    [DataContract]
    public class TimePickerReplyMessage
    {
        [DataMember(Name = "style")]
        public string Style { get; set; } = "icon";

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "subtitle")]
        public string Subtitle { get; set; }

        [DataMember(Name = "imageIdentifier")]
        public string ImageIdentifier { get; set; }

        public TimePickerReplyMessage(string style, string title, string subtitle, string imageIdentifier)
        {
            Style = style;
            Title = title;
            Subtitle = subtitle;
            ImageIdentifier = imageIdentifier;
        }

        public TimePickerReplyMessage(string title, string subtitle) : this("icon", title, subtitle, default)
        {
        }

        public TimePickerReplyMessage(string title = "Quero esse") : this("icon", title, default, default)
        {
        }
    }
}
