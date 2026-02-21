using System.Text.Json.Serialization;

namespace RclOrdering.Dto
{
    public class OrderDto
    {
        [JsonPropertyName("uid")]
        public string? Uid { get; set; }

        [JsonPropertyName("user_uid")]
        public string? UidUser { get; set; }

        [JsonPropertyName("order_data")]
        public DateTime OrderData { get; set; }

        [JsonPropertyName("itens")]
        public List<ItensDto>? Itens { get; set; }

        [JsonPropertyName("tax")]
        public float Tax { get; set; }

        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

    }
}
