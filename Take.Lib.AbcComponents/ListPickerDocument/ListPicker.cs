using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AbcComponentsHelper.ListPickerDocument
{
    public class ListPicker
    {
        [DataMember(Name = "sections")]
        public IEnumerable<Section> Sections { get; set; }

        public ListPicker(IEnumerable<Section> sections)
        {
            Sections = sections;
        }
    }

    //public partial class Items
    //{
    //    public string Title { get; set; }
    //    public string Identifier { get; set; }
    //    public string Image { get; set; } = string.Empty;
    //    public int? Order { get; set; } = 0;

    //    public Items(string title, string identifier, string image, int order)
    //    {
    //        Title = title;
    //        Identifier = identifier;
    //        Image = image;
    //        Order = order;
    //    }

    //    public Items(string title, string identifier, byte[] image, int order) : this(title, identifier, Convert.ToBase64String(image), order)
    //    {
    //    }

    //    public Items(string title, byte[] image, int order) : this(title, title, image, order)
    //    {
    //        Image = Convert.ToBase64String(image);
    //    }

    //    public Items(string title, byte[] image) : this(title, title, Convert.ToBase64String(image), default)
    //    {
    //    }

    //    public Items(string title, string image) : this(title, title, image, default)
    //    {
    //    }

    //    public Items(string title, string identifier, int order) : this(title, identifier, string.Empty, order)
    //    {
    //    }

    //}
}

//[DataContract]
//public partial class ListPickerDocument
//{
//    [DataMember(Name = "id")]
//    public string Id { get; set; } = "<populated on send>";

//    [DataMember(Name = "sourceId")]
//    public string SourceId { get; set; } = "<populated on send>";

//    [DataMember(Name = "destinationId")]
//    public string DestinationId { get; set; } = "<populated on send>";

//    [DataMember(Name = "interactiveData")]
//    public InteractiveData InteractiveData { get; set; }

//    [DataMember(Name = "type")]
//    public string Type { get; set; }

//    public ListPickerDocument(InteractiveData interactiveData, string type)
//    {
//        InteractiveData = interactiveData;
//        Type = type;
//    }

//    public ListPickerDocument(InteractiveData interactiveData) : this(interactiveData, "interactive")
//    {
//    }
//}

//[DataContract]
//public partial class InteractiveData
//{
//    [DataMember(Name = "bid")]
//    public string Bid { get; set; } = "com.apple.messages.MSMessageExtensionBalloonPlugin:0000000000:com.apple.icloud.apps.messages.business.extension";

//    [DataMember(Name = "data")]
//    public Data Data { get; set; }

//    [DataMember(Name = "useLiveLayout")]
//    public bool UseLiveLayout { get; set; } = true;

//    [DataMember(Name = "receivedMessage")]
//    public ReceivedMessage ReceivedMessage { get; set; }

//    [DataMember(Name = "replyMessage")]
//    public ReplyMessage ReplyMessage { get; set; }

//    public InteractiveData(Data data, ReceivedMessage receivedMessage, ReplyMessage replyMessage)
//    {
//        Data = data;
//        ReceivedMessage = receivedMessage;
//        ReplyMessage = replyMessage;
//    }

//    public InteractiveData(Data data, ReceivedMessage receivedMessage) : this(data, receivedMessage, new ReplyMessage())
//    {
//    }
//}

//[DataContract]
//public partial class Data
//{
//    [DataMember(Name = "version")]
//    public string Version { get; set; } = "1.0";

//    [DataMember(Name = "requestIdentifier")]
//    public string RequestIdentifier { get; set; } = "<populated on send>";

//    [DataMember(Name = "images")]
//    public IEnumerable<Image> Images { get; set; }

//    [DataMember(Name = "listPicker")]
//    public ListPicker ListPicker { get; set; }

//    public Data(string version, IEnumerable<Image> images, IEnumerable<Section> sections)
//    {
//        Version = version;
//        Images = images;
//        ListPicker = new ListPicker(sections);
//    }

//    public Data(IEnumerable<Section> sections) : this("1.0", new List<Image>(), sections)
//    {
//    }

//    public Data(Section sections) : this("1.0", new List<Image>(), new Section[] { sections })
//    {
//    }

//    public Data(string version, Section sections) : this(version, new List<Image>(), new Section[] { sections })
//    {
//    }
//}

//[DataContract]
//public partial class Image
//{
//    [DataMember(Name = "identifier")]
//    public string Identifier { get; set; }

//    [DataMember(Name = "data")]
//    public string Data { get; set; }

//    public Image(string identifier, string data)
//    {
//        Identifier = identifier;
//        Data = data;
//    }

//    public Image()
//    {
//    }

//    public Image(string identifier, byte[] data)
//    {
//        Identifier = identifier;
//        Data = Convert.ToBase64String(data);
//    }
//    public Image(string identifier, Uri imageUrl)
//    {
//        Identifier = identifier;
//        InitializeAsync(imageUrl.ToString()).Wait();
//    }

//    private async Task<Image> InitializeAsync(string imageUrl)
//    {
//        Data = await GetBase64ImageByUrlAsync(imageUrl);
//        return this;
//    }

//    internal async Task<string> GetBase64ImageByUrlAsync(string url)
//    {
//        using (var httpClient = new HttpClient())
//        using (var response = await httpClient.GetAsync(url))
//        {
//            var bytes = await response.Content.ReadAsByteArrayAsync();
//            return Convert.ToBase64String(bytes);
//        }
//    }
//}

//[DataContract]
//public partial class Section
//{
//    [DataMember(Name = "items")]
//    public IEnumerable<ListPickerItem> Items { get; set; }

//    [DataMember(Name = "title")]
//    public string Title { get; set; }

//    [DataMember(Name = "multipleSelection")]
//    public bool MultipleSelection { get; set; }

//    [DataMember(Name = "order")]
//    public int? Order { get; set; }

//    public Section(IEnumerable<ListPickerItem> listPickerItems, string title, bool multipleSelection, int order)
//    {
//        Items = listPickerItems;
//        Title = title;
//        MultipleSelection = multipleSelection;
//        Order = order;
//    }

//    public Section(IEnumerable<ListPickerItem> listPickerItems, bool multipleSelection) : this(listPickerItems, default, multipleSelection, default)
//    {
//    }

//    public Section(IEnumerable<ListPickerItem> listPickerItems, string title, bool multipleSelection) : this(listPickerItems, title, multipleSelection, default)
//    {
//    }

//    public Section(IEnumerable<ListPickerItem> listPickerItems) : this(listPickerItems, default, false, default)
//    {
//    }

//    public Section(params ListPickerItem[] items) : this(items, default, false, default)
//    {
//    }

//    public Section(bool multipleSelection, params ListPickerItem[] items) : this(items, default, multipleSelection, default)
//    {
//    }
//}

//[DataContract]
//public partial class ListPickerItem
//{
//    [DataMember(Name = "style")]
//    public string Style { get; set; } = "default";

//    [DataMember(Name = "title")]
//    public string Title { get; set; }

//    [DataMember(Name = "imageIdentifier")]
//    public string ImageIdentifier { get; set; }

//    [DataMember(Name = "order")]
//    public int? Order { get; set; }

//    [DataMember(Name = "identifier")]
//    public string Identifier { get; set; }

//    private string ImageUrl { get; set; }

//    public ListPickerItem(string style, string title, string imageIdentifier, int order, string identifier)
//    {
//        Style = style;
//        Title = title;
//        Identifier = identifier;
//        ImageIdentifier = imageIdentifier;
//        Order = order;
//    }

//    public ListPickerItem(string title, string identifier) : this("default", title, default, default, identifier)
//    {
//    }

//    public ListPickerItem(string title, string imageIdentifier, string identifier) : this("default", title, imageIdentifier, default, identifier)
//    {
//    }

//    public ListPickerItem(string title) : this("default", title, default, default, title)
//    {
//    }
//}

//[DataContract]
//public partial class ReceivedMessage
//{
//    [DataMember(Name = "style")]
//    public string Style { get; set; } = "small";

//    [DataMember(Name = "title")]
//    public string Title { get; set; }

//    [DataMember(Name = "subtitle")]
//    public string Subtitle { get; set; }

//    [DataMember(Name = "imageIdentifier")]
//    public string ImageIdentifier { get; set; }

//    public ReceivedMessage(string style, string title, string subtitle, string imageIdentifier)
//    {
//        Style = style;
//        Title = title;
//        Subtitle = subtitle;
//        ImageIdentifier = imageIdentifier;
//    }

//    public ReceivedMessage(string title, string subtitle, string imageIdentifier) : this("small", title, subtitle, imageIdentifier)
//    {
//    }

//    public ReceivedMessage(string title, string subtitle) : this("small", title, subtitle, default)
//    {
//    }

//    public ReceivedMessage(string title) : this("small", title, default, default)
//    {
//    }
//}

//[DataContract]
//public partial class ReplyMessage
//{
//    [DataMember(Name = "style")]
//    public string Style { get; set; } = "icon";

//    [DataMember(Name = "title")]
//    public string Title { get; set; }

//    [DataMember(Name = "subtitle")]
//    public string Subtitle { get; set; }

//    [DataMember(Name = "imageIdentifier")]
//    public string ImageIdentifier { get; set; }

//    public ReplyMessage(string style, string title, string subtitle, string imageIdentifier)
//    {
//        Style = style;
//        Title = title;
//        Subtitle = subtitle;
//        ImageIdentifier = imageIdentifier;
//    }

//    public ReplyMessage(string title, string subtitle) : this("icon", title, subtitle, default)
//    {
//    }

//    public ReplyMessage(string title = "Quero esse") : this("icon", title, default, default)
//    {
//    }
//}