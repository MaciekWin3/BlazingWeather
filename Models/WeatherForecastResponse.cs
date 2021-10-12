namespace BlazingWeather.Models
{

    public class WeatherForecastResponse
    {
        public Summary[]? Weather { get; set; }
        public Weather? Main { get; set; }
        public int Visibility { get; set; }
        public Wind? Wind { get; set; }
        public string? Name { get; set; }
    }
}
