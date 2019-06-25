using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcComponentsHelper.ApplePayDocument
{
    class Item
    {
        [JsonProperty("unit")]
        public decimal Unit { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("complement")]
        public string Complement { get; set; }
    }
}
