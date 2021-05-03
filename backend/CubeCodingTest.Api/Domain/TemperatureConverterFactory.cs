using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CubeCodingTest.Api.Domain.Converters;
using CubeCodingTest.Api.Domain.Interfaces;

namespace CubeCodingTest.Api.Domain
{
    public class TemperatureConverterFactory : ITemperatureConverterFactory
    {
        public ITemperatureConverter Create(TemperatureScale fromScale, TemperatureScale toScale)
        {
            switch ((fromScale, toScale))
            {
                case (TemperatureScale.Celsius, TemperatureScale.Fahrenheit):
                    return new CelsiusToFahrenheitConverter();
                case (TemperatureScale.Celsius, TemperatureScale.Kelvin):
                    return new CelsiusToKelvinConverter();
                case (TemperatureScale.Fahrenheit, TemperatureScale.Celsius):
                    return new FahrenheitToCelsiusConverter();
                case (TemperatureScale.Fahrenheit, TemperatureScale.Kelvin):
                    return new FahrenheitToKelvinConverter();
                case (TemperatureScale.Kelvin, TemperatureScale.Celsius):
                    return new KelvinToCelsiusConverter();
                case (TemperatureScale.Kelvin, TemperatureScale.Fahrenheit):
                    return new KelvinToFahrenheitConverter();
                default:
                    throw new Exception($"Conversion from {fromScale} to {toScale} is not supported");
            }
        }
    }
}
