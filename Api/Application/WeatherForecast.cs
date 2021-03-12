using System;

namespace Application
{
    public enum WeatherOverview
    {
        Sunny, MostlySunny, PartlyCloudy, Cloudy, Hurricane
    }

    public class WeatherForecast
    {
        public WeatherOverview Overview { get; set; }
        public int ChanceOfRain { get; set; }
        public int Humidity { get; set; }
        public int High { get; set; }
        public int Low { get; set; }


        public class Builder
        {
            private WeatherOverview overview { get; set; }
            private int chanceOfRain { get; set; }
            private int humidity { get; set; }
            private int high { get; set; }
            private int low { get; set; }

            public Builder WithOverview(WeatherOverview overview)
            {
                this.overview = overview;
                return this;
            }

            public Builder WithChanceOfRain(int changeOfRain)
            {
                this.chanceOfRain = chanceOfRain;
                return this;
            }

            public Builder WithHumidity(int humidity)
            {
                this.humidity = humidity;
                return this;
            }

            public Builder WithHigh(int high)
            {
                this.high = high;
                return this;
            }

            public Builder WithLow(int low)
            {
                this.low = low;
                return this;
            }

            public WeatherForecast Build()
            {
                if (low > high)
                {
                    throw new InvalidOperationException("Low must be less than high.");
                }

                // No validation currently, so builder might not be ideal but sample project
                return new WeatherForecast()
                {
                    Overview = overview,
                    High = high,
                    Low = low,
                    Humidity = humidity,
                    ChanceOfRain = chanceOfRain,
                };
            }
        }
    }
}