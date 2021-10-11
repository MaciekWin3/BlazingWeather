using System.Text.Json.Serialization;

namespace BlazingWeather.Models
{
    public class Weather
    {
        [JsonPropertyName("temp")]
        public double Temperature { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
    }
}
