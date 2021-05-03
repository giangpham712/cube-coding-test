using System.Collections.Generic;
using CubeCodingTest.Api.Domain;

namespace CubeCodingTest.Api.Services.Interfaces
{
    public interface ITemperatureConversionService
    {
        IEnumerable<(string, string)> ListTemperatureScales();
        double Convert(double temperature, TemperatureScale fromScale, TemperatureScale toScale);
    }
}