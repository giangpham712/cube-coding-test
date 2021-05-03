using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CubeCodingTest.Api.Domain
{
    public enum TemperatureScale
    {
        [TemperatureScale(Name = "Celsius", Symbol = "°C")]
        Celsius,
        [TemperatureScale(Name = "Fahrenheit", Symbol = "°F")]
        Fahrenheit,
        [TemperatureScale(Name = "Kelvin", Symbol = "°K")]
        Kelvin
    }
}
