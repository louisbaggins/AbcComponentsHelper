using System.Runtime.Serialization;

namespace AbcComponentsHelper.TimePicker
{
    [DataContract]
    public class TimePickerDocument
    {
        [DataMember(Name = "id")]
        public string Id { get; set; } = "<populated on send>";

        [DataMember(Name = "sourceId")]
        public string SourceId { get; set; } = "<populated on send>";

        [DataMember(Name = "destinationId")]
        public string DestinationId { get; set; } = "<populated on send>";

        [DataMember(Name = "interactiveData")]
        public TimePickerInteractiveData InteractiveData { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        public TimePickerDocument(TimePickerInteractiveData interactiveData, string type)
        {
            InteractiveData = interactiveData;
            Type = type;
        }

        public TimePickerDocument(TimePickerInteractiveData interactiveData) : this(interactiveData, "interactive")
        {
        }
    }
}