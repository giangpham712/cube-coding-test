using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace CubeCodingTest.Api.Domain
{
    public class TemperatureScaleAttribute : Attribute
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
    }
}
