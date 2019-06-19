using System.Runtime.Serialization;

namespace AbcComponentsHelper.ListPickerDocument
{
    [DataContract]
    public class InteractiveData
    {
        [DataMember(Name = "bid")]
        public string Bid { get; set; } = "com.apple.messages.MSMessageExtensionBalloonPlugin:0000000000:com.apple.icloud.apps.messages.business.extension";

        [DataMember(Name = "data")]
        public Data Data { get; set; }

        [DataMember(Name = "useLiveLayout")]
        public bool UseLiveLayout { get; set; } = true;

        [DataMember(Name = "receivedMessage")]
        public ReceivedMessage ReceivedMessage { get; set; }

        [DataMember(Name = "replyMessage")]
        public ReplyMessage ReplyMessage { get; set; }

        public InteractiveData(Data data, ReceivedMessage receivedMessage, ReplyMessage replyMessage)
        {
            Data = data;
            ReceivedMessage = receivedMessage;
            ReplyMessage = replyMessage;
        }

        public InteractiveData(Data data, ReceivedMessage receivedMessage) : this(data, receivedMessage, new ReplyMessage())
        {
        }
    }
}