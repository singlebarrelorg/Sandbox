using System;
using System.Web;
using System.Web.UI;
using BusinessManagers;

namespace SingleBarrelWeather
{
	public partial class Default : System.Web.UI.Page
	{
		public void button1Clicked (object sender, EventArgs args)
		{
			btnGetWeather.Text = "You clicked me";
			lblReturnedXML.Text = new CurrentWeatherManager ("London").GetCurrentWeather ();
		}
	}
}

