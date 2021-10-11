namespace BlazingWeather.Models
{
    public class CountryResponse
    {
        public bool Error { get; set; }
        public string? Msg { get; set; }
        public Country[]? Data { get; set; }
    }
}
