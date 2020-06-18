using System.Text.Json.Serialization;

namespace KoreanGovernment.OpenAPI.Health.Corona19Mask
{
    internal class Response
    {
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("stores")]
        public Store[] Stores { get; set; }
    }
}
