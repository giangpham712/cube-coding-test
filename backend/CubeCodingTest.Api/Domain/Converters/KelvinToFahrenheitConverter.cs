using System;
using CubeCodingTest.Api.Domain.Interfaces;

namespace CubeCodingTest.Api.Domain.Converters
{
    public class KelvinToFahrenheitConverter : ITemperatureConverter
    {
        public double Convert(double temperature)
        {
            return temperature * 9 / 5 - 459.67;
        }
    }
}