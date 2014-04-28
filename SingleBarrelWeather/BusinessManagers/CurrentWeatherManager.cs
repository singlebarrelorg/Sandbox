using System;

namespace BusinessManagers
{
	public class CurrentWeatherManager
	{
		string weatherApiUrl = "http://api.openweathermap.org/data/2.5/weather";
		string locationQueryString = "?q=";
		string modeQueryString = "&mode=";
		string currentWeatherApiUrl;

		public CurrentWeatherManager (string weatherLocation)
		{
			// Example URL: http://api.openweathermap.org/data/2.5/weather?q=London&mode=xml

			string location = string.Format (locationQueryString, weatherLocation);
			string returnMode = string.Format (modeQueryString, "xml");
			currentWeatherApiUrl = string.Concat (weatherApiUrl, location, returnMode);
		}

		public string GetCurrentWeather()
		{
			return currentWeatherApiUrl;
		}
	}
}

