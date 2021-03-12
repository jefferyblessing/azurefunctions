namespace Application
{
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class FetchWeatherRequestHandler : AsyncRequestHandler<FetchWeatherRequest>
    {
        protected override async Task<WeatherForecast> Handle(FetchWeatherRequest request, CancellationToken cancellationToken)
        {
            // Scaffold/ task delay to simulate async api calls vs my random numbers
            await Task.Delay(1).ConfigureAwait(false);

            WeatherForecast forecast;

            // Sunny at home!
            if (request.ZipCode == 33624)
            {
                forecast = new WeatherForecast.Builder()
                                              .WithOverview(WeatherOverview.Sunny)
                                              .WithHigh(90)
                                              .WithLow(70)
                                              .WithChanceOfRain(10)
                                              .Build();
            }
            else
            {
                forecast = new WeatherForecast.Builder()
                                              .WithOverview(WeatherOverview.Hurricane)
                                              .WithHigh(50)
                                              .WithLow(20)
                                              .WithChanceOfRain(100)
                                              .Build();
            }

            return forecast;
        }
    }
}