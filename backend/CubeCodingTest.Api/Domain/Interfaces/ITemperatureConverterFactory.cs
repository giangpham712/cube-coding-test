namespace CubeCodingTest.Api.Domain.Interfaces
{
    public interface ITemperatureConverterFactory
    {
        ITemperatureConverter Create(TemperatureScale fromScale, TemperatureScale toScale);
    }
}