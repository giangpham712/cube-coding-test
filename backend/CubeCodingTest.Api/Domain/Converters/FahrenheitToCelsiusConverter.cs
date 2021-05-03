using System;
using CubeCodingTest.Api.Domain.Interfaces;

namespace CubeCodingTest.Api.Domain.Converters
{
    public class FahrenheitToCelsiusConverter : ITemperatureConverter
    {
        public double Convert(double temperature)
        {
            return (temperature - 32) * 5 / 9;
        }
    }
}