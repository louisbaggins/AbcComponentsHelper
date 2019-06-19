using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AbcComponentsHelper.TimePicker
{
    [DataContract]
    public class TimePickerInteractiveData
    {
        [DataMember(Name = "bid")]
        public string Bid { get; set; } = "com.apple.messages.MSMessageExtensionBalloonPlugin:0000000000:com.apple.icloud.apps.messages.business.extension";

        [DataMember(Name = "data")]
        public TimePickerData Data { get; set; }

        [DataMember(Name = "useLiveLayout")]
        public bool UseLiveLayout { get; set; }

        [DataMember(Name = "receivedMessage")]
        public TimePickerReceivedMessage ReceivedMessage { get; set; }

        [DataMember(Name = "replyMessage")]
        public TimePickerReplyMessage ReplyMessage { get; set; }

        public TimePickerInteractiveData(TimePickerData data, bool useLiveLayout, TimePickerReceivedMessage receivedMessage, TimePickerReplyMessage replyMessage)
        {
            Data = data;
            UseLiveLayout = useLiveLayout;
            ReceivedMessage = receivedMessage;
            ReplyMessage = replyMessage;
        }

        public TimePickerInteractiveData(TimePickerData data, TimePickerReceivedMessage receivedMessage, TimePickerReplyMessage replyMessage) : this(data, true, receivedMessage, replyMessage)
        {
        }

        public TimePickerInteractiveData(TimePickerData data, TimePickerReceivedMessage receivedMessage) : this(data, true, receivedMessage, new TimePickerReplyMessage())
        {
        }

        public TimePickerInteractiveData(TimePickerData data, bool useLiveLayout, TimePickerReceivedMessage receivedMessage) : this(data, useLiveLayout, receivedMessage, new TimePickerReplyMessage())
        {
        }
    }

}
