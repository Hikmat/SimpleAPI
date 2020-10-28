using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.TEST
{
    public class UnitTest1
    {

        WeatherForecastController weatherForestContoller = new WeatherForecastController();

        [Fact]
        public void CheckMyName()
        {
            var name = weatherForestContoller.GetName();
            Assert.Equal("Khikmat", name);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
