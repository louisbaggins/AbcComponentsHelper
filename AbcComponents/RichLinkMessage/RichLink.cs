using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace AbcComponentsHelper.RichLinkMessage
{
    public class RichLink
    {
        [JsonProperty("body")]
        public Uri Body { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; } = "<populated on send>";

        [JsonProperty("destinationId")]
        public string DestinationId { get; set; } = "<populated on send>";

        [JsonProperty("v")]
        public int V { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; } = "richLink";

        [JsonProperty("id")]
        public string Id { get; set; } = "<populated on send>";

        [DataMember(Name = "richLinkData")]
        public RichLinkData RichLinkData { get; set; }

        internal RichLink(Uri body, int v, RichLinkData richLinkData)
        {
            Body = body;
            V = v;
            RichLinkData = richLinkData;
        }

        internal RichLink(Uri body, RichLinkData richLinkData) : this(body, 1, richLinkData)
        {
        }

        public RichLink(string url, string title, string image, ImageType imageType) : this(new Uri(url), new RichLinkData(new Uri(url), title, new Assets(new ThumbNail(image, ImageType.png))))
        {
            Body = new Uri(url);
            V = 1;
            RichLinkData = new RichLinkData(new Uri(url), title, new Assets(new ThumbNail(image, imageType)));
        }
    }
}