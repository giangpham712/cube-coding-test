using System;
using CubeCodingTest.Api.Domain.Converters;
using Xunit;

namespace CubeCodingTest.Tests
{
    public class TemperatureConverterTests
    {
        [Theory]
        [InlineData(10, 50)]
        [InlineData(25, 77)]
        [InlineData(-40, -40)]
        [InlineData(150, 302)]
        public void CelsiusToFahrenheitConverter_Convert(double input, double output)
        {
            var converter = new CelsiusToFahrenheitConverter();
            var result = converter.Convert(input);
            Assert.Equal(output, Math.Round(result, 2));
        }

        [Theory]
        [InlineData(10, 283.15)]
        [InlineData(25, 298.15)]
        [InlineData(-40, 233.15)]
        [InlineData(150, 423.15)]
        public void CelsiusToKelvinConverter_Convert(double input, double output)
        {
            var converter = new CelsiusToKelvinConverter();
            var result = converter.Convert(input);
            Assert.Equal(output, Math.Round(result, 2));
        }

        [Theory]
        [InlineData(10, -12.22)]
        [InlineData(25, -3.89)]
        [InlineData(-40, -40)]
        [InlineData(150, 65.56)]
        public void FahrenheitToCelsiusConverter_Convert(double input, double output)
        {
            var converter = new FahrenheitToCelsiusConverter();
            var result = converter.Convert(input);
            Assert.Equal(output, Math.Round(result, 2));
        }

        [Theory]
        [InlineData(10, 260.93)]
        [InlineData(25, 269.26)]
        [InlineData(-40, 233.15)]
        [InlineData(150, 338.71)]
        public void FahrenheitToKelvinConverter_Convert(double input, double output)
        {
            var converter = new FahrenheitToKelvinConverter();
            var result = converter.Convert(input);
            Assert.Equal(output, Math.Round(result, 2));
        }

        [Theory]
        [InlineData(10, -263.15)]
        [InlineData(25, -248.15)]
        [InlineData(-40, -313.15)]
        [InlineData(150, -123.15)]
        public void KelvinToCelsiusConverter_Convert(double input, double output)
        {
            var converter = new KelvinToCelsiusConverter();
            var result = converter.Convert(input);
            Assert.Equal(output, Math.Round(result, 2));
        }

        [Theory]
        [InlineData(10, -441.67)]
        [InlineData(25, -414.67)]
        [InlineData(-40, -531.67)]
        [InlineData(150, -189.67)]
        public void KelvinToFahrenheitConverter_Convert(double input, double output)
        {
            var converter = new KelvinToFahrenheitConverter();
            var result = converter.Convert(input);
            Assert.Equal(output, Math.Round(result, 2));
        }
    }
}
