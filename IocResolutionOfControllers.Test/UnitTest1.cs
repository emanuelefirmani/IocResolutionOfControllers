using FluentAssertions;
using IocResolutionOfControllers.Controllers;
using Microsoft.AspNetCore.Builder;
using Xunit;

namespace IocResolutionOfControllers.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var builder = WebApplication.CreateBuilder();
        
        IocModule.AddDependencies(builder.Services);
        
        var application = builder.Build();

        application.Services.GetService(typeof(WeatherForecastController)).Should().BeOfType<WeatherForecastController>();
    }
}