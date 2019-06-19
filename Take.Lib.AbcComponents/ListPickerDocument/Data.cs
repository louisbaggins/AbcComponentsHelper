using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AbcComponentsHelper.ListPickerDocument
{
    [DataContract]
    public class Data
    {
        [DataMember(Name = "version")]
        public string Version { get; set; } = "1.0";

        [DataMember(Name = "requestIdentifier")]
        public string RequestIdentifier { get; set; } = "<populated on send>";

        [DataMember(Name = "images")]
        public IEnumerable<Image> Images { get; set; }

        [DataMember(Name = "listPicker")]
        public ListPicker ListPicker { get; set; }

        public Data(string version, IEnumerable<Image> images, IEnumerable<Section> sections)
        {
            Version = version;
            Images = images;
            ListPicker = new ListPicker(sections);
        }

        public Data(IEnumerable<Section> sections) : this("1.0", new List<Image>(), sections)
        {
        }

        public Data(Section sections) : this("1.0", new List<Image>(), new Section[] { sections })
        {
        }

        public Data(string version, Section sections) : this(version, new List<Image>(), new Section[] { sections })
        {
        }

        public Data(string version, IEnumerable<Image> images, Section sections) : this(version, images, new Section[] { sections })
        {
        }
    }
}