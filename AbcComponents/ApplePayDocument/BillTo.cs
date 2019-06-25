using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcComponentsHelper.ApplePayDocument
{
    class BillTo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("taxDocument")]
        public string TaxDocument { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("birthDate")]
        public DateTime BirthDate { get; set; }
    }
}
