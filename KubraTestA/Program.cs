using System;

namespace KubraTestA
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherToday w = new WeatherToday();
            Console.WriteLine(w.GetWeather());
            Console.ReadKey();

        }
    }


    public class WeatherDefault
    {

        public virtual string GetWeather()
        {
            return GetWeatherToday();
        }

        public virtual string GetWeatherToday()
        {
            return "sunshine";
        }
       

    }


    public class WeatherToday: WeatherDefault
    {
        public virtual string GetWeatherToday()
        {
            return "snow";
        }
    }

}
