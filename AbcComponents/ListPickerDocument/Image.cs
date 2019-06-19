using System;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace AbcComponentsHelper.ListPickerDocument
{
    [DataContract]
    public class Image
    {
        [DataMember(Name = "identifier")]
        public string Identifier { get; set; }

        [DataMember(Name = "data")]
        public string Data { get; set; }

        public Image(string identifier, string data)
        {
            Identifier = identifier;
            Data = data;
        }

        public Image()
        {
        }

        public Image(string identifier, byte[] data)
        {
            Identifier = identifier;
            Data = Convert.ToBase64String(data);
        }

        public Image(string identifier, Uri imageUrl)
        {
            Identifier = identifier;
            InitializeAsync(imageUrl.ToString()).Wait();
        }

        private async Task<Image> InitializeAsync(string imageUrl)
        {
            Data = await GetBase64ImageByUrlAsync(imageUrl);
            return this;
        }

        internal async Task<string> GetBase64ImageByUrlAsync(string url)
        {
            using (var httpClient = new HttpClient())
            using (var response = await httpClient.GetAsync(url))
            {
                var bytes = await response.Content.ReadAsByteArrayAsync();
                return Convert.ToBase64String(bytes);
            }
        }
    }
}