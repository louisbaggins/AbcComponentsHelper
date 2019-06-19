using Newtonsoft.Json;
using System;

namespace AbcComponentsHelper.RichLinkMessage
{
    public class ThumbNail
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        public ThumbNail(string data, ImageType mimeType)
        {
            Data = data;
            switch (mimeType)
            {
                case ImageType.png:
                    MimeType = "image/png";
                    break;

                case ImageType.jpg:
                    MimeType = "image/jpg";
                    break;

                case ImageType.jpeg:
                    MimeType = "image/jpeg";
                    break;
            }
        }

        public ThumbNail(byte[] data, ImageType mimeType)
        {
            Data = Convert.ToBase64String(data);
            switch (mimeType)
            {
                case ImageType.png:
                    MimeType = "image/png";
                    break;

                case ImageType.jpg:
                    MimeType = "image/jpg";
                    break;

                case ImageType.jpeg:
                    MimeType = "image/jpeg";
                    break;
            }
        }
    }
}