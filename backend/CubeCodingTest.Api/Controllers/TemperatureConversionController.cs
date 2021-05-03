using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CubeCodingTest.Api.Models;
using CubeCodingTest.Api.Services;
using CubeCodingTest.Api.Services.Interfaces;

namespace CubeCodingTest.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemperatureConversionController : ControllerBase
    {
        private readonly ITemperatureConversionService _temperatureConversionService;

        public TemperatureConversionController(ITemperatureConversionService temperatureConversionService)
        {
            _temperatureConversionService = temperatureConversionService;
        }

        [HttpGet]
        [Route("ListTemperatureScales")]
        public IEnumerable<TemperatureScaleModel> ListTemperatureScales()
        {
            var temperatureScales = _temperatureConversionService.ListTemperatureScales();
            return temperatureScales.Select(x => new TemperatureScaleModel()
            {
                Name = x.Item1,
                Symbol = x.Item2
            }).ToList();
        }

        [HttpPost]
        [Route("Convert")]
        public ConvertTemperatureResultModel Convert([FromBody] ConvertTemperatureModel model)
        {
            var convertedTemperature =
                _temperatureConversionService.Convert(model.Value, model.FromScale, model.ToScale);
            return new ConvertTemperatureResultModel()
            {
                FromScale = model.FromScale,
                ToScale = model.ToScale,
                Value = model.Value,
                ConvertedValue = convertedTemperature
            };
        }
    }
}
