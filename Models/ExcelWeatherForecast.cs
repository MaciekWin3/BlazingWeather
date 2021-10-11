namespace BlazingWeather.Models
{
    public class ExcelWeatherForecast
    {
        public string? City { get; set; }
        public double Temperature { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public double WindSpeed { get; set; }
        public double WindDegree { get; set; }
    }
}
