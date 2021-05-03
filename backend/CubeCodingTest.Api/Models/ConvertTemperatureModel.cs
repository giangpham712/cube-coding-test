using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CubeCodingTest.Api.Domain;

namespace CubeCodingTest.Api.Models
{
    public class ConvertTemperatureModel
    {
        public TemperatureScale FromScale { get; set; }
        public TemperatureScale ToScale { get; set; }
        public double Value { get; set; }
    }
}
