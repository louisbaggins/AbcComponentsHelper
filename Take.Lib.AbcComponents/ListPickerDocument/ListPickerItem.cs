using System.Runtime.Serialization;

namespace AbcComponentsHelper.ListPickerDocument
{
    [DataContract]
    public class ListPickerItem
    {
        [DataMember(Name = "style")]
        public string Style { get; set; } = "default";

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "imageIdentifier")]
        public string ImageIdentifier { get; set; }

        [DataMember(Name = "order")]
        public int? Order { get; set; }

        [DataMember(Name = "identifier")]
        public string Identifier { get; set; }

        private string ImageUrl { get; set; }

        public ListPickerItem(string style, string title, string imageIdentifier, int order, string identifier)
        {
            Style = style;
            Title = title;
            Identifier = identifier;
            ImageIdentifier = imageIdentifier;
            Order = order;
        }

        public ListPickerItem(string title, string identifier) : this("default", title, default, default, identifier)
        {
        }

        public ListPickerItem(string title, string imageIdentifier, string identifier) : this("default", title, imageIdentifier, default, identifier)
        {
        }

        public ListPickerItem(string title) : this("default", title, default, default, title)
        {
        }
    }
}