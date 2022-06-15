using FluentAssertions;
using IocResolutionOfControllers.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace IocResolutionOfControllers.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var builder = Startup.CreateBuilder();
        Startup.ConfigureServices(builder.Services);
        
        var application = builder.Build();

        application.Services.GetRequiredService<WeatherForecastController>().Should().BeOfType<WeatherForecastController>();
    }
}