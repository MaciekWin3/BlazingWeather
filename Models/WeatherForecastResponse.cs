namespace BlazingWeather.Models
{

    public class WeatherForecastResponse
    {
        public Coordinates? Coord { get; set; }
        public Description[]? Weather { get; set; }
        public Weather? Main { get; set; }
        public int Visibility { get; set; }
        public Wind? Wind { get; set; }
        public int Dt { get; set; }
        public string? Name { get; set; }
    }
}
