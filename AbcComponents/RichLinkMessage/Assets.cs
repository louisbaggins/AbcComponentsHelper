using Newtonsoft.Json;

namespace AbcComponentsHelper.RichLinkMessage
{
    public class Assets
    {
        [JsonProperty("image")]
        public ThumbNail Image { get; set; }

        public Assets(ThumbNail image)
        {
            Image = image;
        }
    }
}