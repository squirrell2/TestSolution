using Application.Api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Application.Test.ApplicatiuonTests.Fixture
{
    public class CustomWebApplicationFactory : WebApplicationFactory<Startup>
    //public class CustomWebApplicationFactory<TProgram>
    //    : WebApplicationFactory<TProgram> where TProgram : class
    {
        protected override IHost CreateHost(IHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                // Настройка In-Memory БД для тестирования
                //services.AddDbContext<MyDbContext>(options =>
                //{
                //    options.UseInMemoryDatabase("InMemoryDbForTesting");
                //});

                // Можно добавить другие настройки сервиса, если требуется
            });

            return base.CreateHost(builder);
        }
    }
}
