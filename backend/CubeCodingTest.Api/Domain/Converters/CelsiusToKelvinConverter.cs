using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CubeCodingTest.Api.Domain.Interfaces;

namespace CubeCodingTest.Api.Domain.Converters
{
    public class CelsiusToKelvinConverter : ITemperatureConverter
    {
        public double Convert(double temperature)
        {
            return temperature + 273.15;
        }
    }
}
