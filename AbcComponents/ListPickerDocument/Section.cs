using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AbcComponentsHelper.ListPickerDocument
{
    [DataContract]
    public class Section
    {
        [DataMember(Name = "items")]
        public IEnumerable<ListPickerItem> Items { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "multipleSelection")]
        public bool MultipleSelection { get; set; }

        [DataMember(Name = "order")]
        public int? Order { get; set; }

        public Section(IEnumerable<ListPickerItem> listPickerItems, string title, bool multipleSelection, int order)
        {
            Items = listPickerItems;
            Title = title;
            MultipleSelection = multipleSelection;
            Order = order;
        }

        public Section(IEnumerable<ListPickerItem> listPickerItems, bool multipleSelection) : this(listPickerItems, default, multipleSelection, default)
        {
        }

        public Section(IEnumerable<ListPickerItem> listPickerItems, string title, bool multipleSelection) : this(listPickerItems, title, multipleSelection, default)
        {
        }

        public Section(IEnumerable<ListPickerItem> listPickerItems) : this(listPickerItems, default, false, default)
        {
        }

        public Section(params ListPickerItem[] items) : this(items, default, false, default)
        {
        }

        public Section(bool multipleSelection, params ListPickerItem[] items) : this(items, default, multipleSelection, default)
        {
        }
    }
}