using RclOrdering.Dto;
using RclOrdering.Services.Interfaces;
using System.Text.Json;

namespace RclOrdering.Services
{
    public class OrderingRestServices : IOrderingRestServices   
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;

        private List<OrderDto> _orders;
        public OrderingRestServices()
        {
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true
            };

            
        }

        public async Task<List<OrderDto>> GetAll()
        {
            _orders = new List<OrderDto>();
            Uri uri = new Uri("https://localhost:7235/");
           
            try
            {
                HttpResponseMessage httpResponseMessage = await _client.GetAsync($"{uri}/_content/MauiApp1.Shared/sample-data/pedidos.json");
                if ( httpResponseMessage != null)
                {
                    string content = await httpResponseMessage.Content.ReadAsStringAsync();
                    _orders = JsonSerializer.Deserialize<List<OrderDto>>( content, _serializerOptions )!;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.Message );
            } 
            return _orders;
        }
    }
}
