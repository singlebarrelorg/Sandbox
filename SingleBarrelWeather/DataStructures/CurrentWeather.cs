using System;

namespace DataStructures
{
	public class CurrentWeather
	{
        public City City { get; set; }
        public Temperature Temperature { get; set; }
        public Humidity Humidity { get; set; }
        public Pressure Pressure { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public Precipitation Precipitation { get; set; }
        public Weather Weather { get; set; }
        public DateTime LastUpdate { get; set; }
	}
}

