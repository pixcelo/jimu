using System.Text.Json.Serialization;

namespace jimu
{
    public class CandleStickData
    {
        [JsonPropertyName("60")]
        public List<List<double>>? Candlesticks { get; set; }
    }
}
