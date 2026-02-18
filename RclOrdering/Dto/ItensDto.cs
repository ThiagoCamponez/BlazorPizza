using System.Text.Json.Serialization;

namespace RclOrdering.Dto
{
    public class ItensDto
    {
        [JsonPropertyName("uid_item")]
        public string? Uid { get; set; }

        [JsonPropertyName("item")]
        public string? Item { get; set; }

        [JsonPropertyName("size")]
        public string? Size { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("value")]
        public float Value { get; set; }

    }

}