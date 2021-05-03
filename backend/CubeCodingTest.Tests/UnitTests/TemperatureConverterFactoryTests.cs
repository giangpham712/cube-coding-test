using System;
using CubeCodingTest.Api.Domain;
using CubeCodingTest.Api.Domain.Converters;
using Xunit;

namespace CubeCodingTest.Tests
{
    public class TemperatureConverterFactoryTests
    {
        [Theory]
        [InlineData(TemperatureScale.Celsius, TemperatureScale.Fahrenheit, typeof(CelsiusToFahrenheitConverter))]
        [InlineData(TemperatureScale.Celsius, TemperatureScale.Kelvin, typeof(CelsiusToKelvinConverter))]
        [InlineData(TemperatureScale.Fahrenheit, TemperatureScale.Celsius, typeof(FahrenheitToCelsiusConverter))]
        [InlineData(TemperatureScale.Fahrenheit, TemperatureScale.Kelvin, typeof(FahrenheitToKelvinConverter))]
        [InlineData(TemperatureScale.Kelvin, TemperatureScale.Celsius, typeof(KelvinToCelsiusConverter))]
        [InlineData(TemperatureScale.Kelvin, TemperatureScale.Fahrenheit, typeof(KelvinToFahrenheitConverter))]
        public void Create_ValidConversion_ReturnConverter(TemperatureScale fromScale, TemperatureScale toScale, Type converterType)
        {
            var factory = new TemperatureConverterFactory();
            var converter = factory.Create(fromScale, toScale);
            Assert.Equal(converterType, converter.GetType());
        }

        [Theory]
        [InlineData(TemperatureScale.Celsius, TemperatureScale.Celsius)]
        [InlineData(TemperatureScale.Kelvin, TemperatureScale.Kelvin)]
        [InlineData(TemperatureScale.Fahrenheit, TemperatureScale.Fahrenheit)]
        public void Create_InvalidConversion_ReturnConverter(TemperatureScale fromScale, TemperatureScale toScale)
        {
            var factory = new TemperatureConverterFactory();
            var exception = Assert.Throws<Exception>(() => factory.Create(fromScale, toScale));
            Assert.Equal($"Conversion from {fromScale} to {toScale} is not supported", exception.Message);
        }
    }
}
