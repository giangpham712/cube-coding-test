using System;
using CubeCodingTest.Api.Domain.Interfaces;

namespace CubeCodingTest.Api.Domain.Converters
{
    public class FahrenheitToKelvinConverter : ITemperatureConverter
    {
        public double Convert(double temperature)
        {
            return (temperature + 459.67) * 5 / 9;
        }
    }
}