namespace Application
{
    using MediatR;
    using System;

    public class FetchWeatherRequest : IRequest
    {
        private readonly DateTime dateTime;
        private readonly int zipCode;

        public FetchWeatherRequest(DateTime dateTime, int zipCode)
        {
            this.dateTime = dateTime;
            this.zipCode = zipCode;
        }

        public int ZipCode => zipCode;
        public DateTime Date => dateTime;
    }
}