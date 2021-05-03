using System;
using System.Collections.Generic;
using System.Linq;
using CubeCodingTest.Api.Domain;
using CubeCodingTest.Api.Domain.Interfaces;
using CubeCodingTest.Api.Helpers;
using CubeCodingTest.Api.Services.Interfaces;

namespace CubeCodingTest.Api.Services
{
    public class TemperatureConversionService : ITemperatureConversionService
    {
        private readonly ITemperatureConverterFactory _temperatureConverterFactory;

        public TemperatureConversionService(ITemperatureConverterFactory temperatureConverterFactory)
        {
            _temperatureConverterFactory = temperatureConverterFactory;
        }

        public IEnumerable<(string, string)> ListTemperatureScales()
        {
            return Enum.GetValues<TemperatureScale>().Select(x =>
            {
                var temperatureScaleAttribute = x.GetAttribute<TemperatureScaleAttribute>();
                return (temperatureScaleAttribute?.Name ?? x.ToString(), temperatureScaleAttribute?.Symbol);
            });
        }

        public double Convert(double temperature, TemperatureScale fromScale, TemperatureScale toScale)
        {
            if (fromScale == toScale)
            {
                throw new Exception("To scale must be different from from scale");
            }

            var converter = _temperatureConverterFactory.Create(fromScale, toScale);
            return converter.Convert(temperature);
        }
    }
}
