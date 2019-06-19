using Newtonsoft.Json;
using System;

namespace AbcComponentsHelper.RichLinkMessage
{
    public class RichLinkData
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("assets")]
        public Assets Assets { get; set; }

        internal RichLinkData(Uri url, string title, Assets assets)
        {
            Url = url;
            Title = title;
            Assets = assets;
        }
    }
}