
using System.Text.Json.Serialization;

namespace BlazorWasmBrasilApiCep.Models
{
    public class Cep
    {
        [JsonPropertyName("cep")]
        public string? CodigoCep { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }

        [JsonPropertyName("city")]
        public string? City { get; set; }

        [JsonPropertyName("neighborhood")]
        public string? Neighborhood { get; set; }

        [JsonPropertyName("street")]
        public string? Street { get; set; }

        [JsonPropertyName("service")]
        public string? Service { get; set; }

        [JsonPropertyName("ibge")]
        public IbgeInfo? Ibge { get; set; }
    }

    public class IbgeInfo
    {
        [JsonPropertyName("city")]
        public string? City { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }
    }
}
