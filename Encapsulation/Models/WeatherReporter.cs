using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        public string Location { get; private set; }
        public double TemperatureInCelcius { get; private set; }

        public WeatherReporter(string location, double temperatureInCelcius)
        {
            Location = location;
            TemperatureInCelcius = temperatureInCelcius;
        }

        public string Print_Location_and_weather()
        {
            const double farenheitMultiplier = 1.8;
            const int farenheitadditon = 32;
            double fahrenheit = farenheitMultiplier * TemperatureInCelcius + farenheitadditon;
            return $"I am in {Location} and it is {Check_Location_Symbol()}. {Check_TemperatureInCelcius()}. The temperature in Fahrenheit is {fahrenheit}.";
        }

        public string Check_Location_Symbol()
        {
            if (Location == "London")
            {

                return "🌦";

            }
            else if (Location == "California")
            {

                return "🌅";

            }
            else if (Location == "Cape Town")
            {

                return "🌤";
            }

            else
                return "🔆";
        }

        public string Check_TemperatureInCelcius()
        {
            const int tempUpperLimit = 30;
            const int templowerLimit = 10;

            if (TemperatureInCelcius > tempUpperLimit)
            {

                return "It's too hot 🥵!";

            }
            else if (TemperatureInCelcius < templowerLimit)
            {

                return "It's too cold 🥶!";

            }
            return "Ahhh...it's just right 😊!";
        }

    }
}

