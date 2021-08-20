using System;
using System.Text.Json.Serialization;

namespace ApiClient
{
    public class Item
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("type")]
        public string type { get; set; }

        [JsonPropertyName("setup")]
        public string setup { get; set; }

        [JsonPropertyName("punchline")]
        public string punchline { get; set; }

    }
}