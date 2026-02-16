namespace RclOrdering.Dto
{
    internal class OrderDto
    {
        public string? Uid { get; set; }

        public string? UidUser { get; set; }

        public DateTime OrderData { get; set; }

        public List<Itens>? Itens { get; set; }
    }
}
