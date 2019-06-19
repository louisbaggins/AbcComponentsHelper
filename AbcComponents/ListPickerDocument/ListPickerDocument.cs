using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AbcComponentsHelper.ListPickerDocument
{
    [DataContract]
    public class ListPickerDocument
    {
        [DataMember(Name = "id")]
        public string Id { get; set; } = "<populated on send>";

        [DataMember(Name = "sourceId")]
        public string SourceId { get; set; } = "<populated on send>";

        [DataMember(Name = "destinationId")]
        public string DestinationId { get; set; } = "<populated on send>";

        [DataMember(Name = "interactiveData")]
        public InteractiveData InteractiveData { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        public ListPickerDocument(InteractiveData interactiveData, string type)
        {
            InteractiveData = interactiveData;
            Type = type;
        }

        public ListPickerDocument(InteractiveData interactiveData) : this(interactiveData, "interactive")
        {
        }

        public ListPickerDocument(string name, string version, string style, string title, string subtitle, IEnumerable<Items> items, bool multipleSelection, byte[] ReceivedMessageImage, string ReceivedMessageImageIdentifier)
        {
            var imagesArray = CreateImageArray(items);

            InteractiveData = new InteractiveData(new Data(version,
                CreateImageArray(items),
                new Section(CreateListPickerItemArray(items), name, multipleSelection)),
                new ReceivedMessage(style, title, subtitle, ReceivedMessageImageIdentifier),
                new ReplyMessage());
            Type = "interactive";
        }

        public ListPickerDocument(string version, string style, string title, string subtitle, IEnumerable<Items> items, bool multipleSelection, byte[] ReceivedMessageImage, string ReceivedMessageImageIdentifier)
        {
            var imagesArray = CreateImageArray(items);

            InteractiveData = new InteractiveData(new Data(version,
                imagesArray,
                new Section(CreateListPickerItemArray(items), multipleSelection)),
                new ReceivedMessage(style, title, subtitle, ReceivedMessageImageIdentifier),
                new ReplyMessage());
            Type = "interactive";
        }

        public ListPickerDocument(string name, string version, string style, string title, string subtitle, IEnumerable<Items> items, bool multipleSelection)
        {
            InteractiveData = new InteractiveData(new Data(version,
                CreateImageArray(items),
                new Section(CreateListPickerItemArray(items), name, multipleSelection)),
                new ReceivedMessage(style, title, subtitle),
                new ReplyMessage());
            Type = "interactive";
        }

        public ListPickerDocument(string style, string title, string subtitle, IEnumerable<Items> items, bool multipleSelection)
        {
            InteractiveData = new InteractiveData(new Data("1.0",
                CreateImageArray(items),
                new Section(CreateListPickerItemArray(items), multipleSelection)),
                new ReceivedMessage(style, title, subtitle),
                new ReplyMessage());
            Type = "interactive";
        }

        public ListPickerDocument(string title, string subtitle, IEnumerable<Items> items, bool multipleSelection)
        {
            InteractiveData = new InteractiveData(new Data("1.0",
                CreateImageArray(items),
                new Section(CreateListPickerItemArray(items), multipleSelection)),
                new ReceivedMessage(title, subtitle),
                new ReplyMessage());
            Type = "interactive";
        }

        public ListPickerDocument(string style, string title, string subtitle, IEnumerable<Items> items)
        {
            InteractiveData = new InteractiveData(new Data(
                new Section(CreateListPickerItemArray(items))),
                new ReceivedMessage(style, title, subtitle),
                new ReplyMessage());
            Type = "interactive";
        }

        public ListPickerDocument(string name, string version, string style, string title, string subtitle, IEnumerable<ListPickerItem> items, IEnumerable<Image> images, bool multipleSelection, string receivedMessageImage)
        {
            InteractiveData = new InteractiveData(new Data(version,
                images,
                new Section(items, name, multipleSelection)),
                new ReceivedMessage(style, title, subtitle, receivedMessageImage),
                new ReplyMessage());
            Type = "interactive";
        }

        private IEnumerable<ListPickerItem> CreateListPickerItemArray(IEnumerable<Items> items)
        {
            var listPickerItems = new List<ListPickerItem>();
            foreach (var item in items)
            {
                listPickerItems.Add(new ListPickerItem(item.Title, item.Identifier + "-image", item.Identifier));
            }

            return listPickerItems;
        }

        private IEnumerable<Image> CreateImageArray(IEnumerable<Items> images)
        {
            var imagesArray = new List<Image>();
            foreach (var image in images)
            {
                imagesArray.Add(new Image(image.Identifier + "-image", image.Image));
            }

            return imagesArray;
        }
    }

    public partial class Items
    {
        public string Title { get; set; }
        public string Identifier { get; set; }
        public string Image { get; set; } = string.Empty;
        public int? Order { get; set; } = 0;

        public Items(string title, string identifier, string image, int order)
        {
            Title = title;
            Identifier = identifier;
            Image = image;
            Order = order;
        }

        public Items(string title, string identifier, byte[] image, int order) : this(title, identifier, Convert.ToBase64String(image), order)
        {
        }

        public Items(string title, byte[] image, int order) : this(title, title, image, order)
        {
            Image = Convert.ToBase64String(image);
        }

        public Items(string title, byte[] image) : this(title, title, Convert.ToBase64String(image), default)
        {
        }

        public Items(string title, string image) : this(title, title, image, default)
        {
        }

        public Items(string title, string identifier, int order) : this(title, identifier, string.Empty, order)
        {
        }
    }
}