using Application.Api;
using Application.Test.ApplicatiuonTests.Fixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Test.ApplicatiuonTests
{
    public class ApiIntegrationTests : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _client;

        public ApiIntegrationTests(CustomWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Get_Endpoint_ReturnsSuccess()
        {
            // Act
            var response = await _client.GetAsync("/WeatherForecast");

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.NotEmpty(responseString);
            Assert.Contains("{", responseString);
        }
    }
}
