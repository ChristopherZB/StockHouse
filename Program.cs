using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StockHouse.Database;
using StockHouse.Helpers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StockHouse
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            ConfigureServices(builder.Services, builder.Configuration);

            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services, IConfiguration config)
        {
            services.AddTransient<TestingData>();
            
            /*services.AddDbContext<MainDbContext>(options =>
                options.UseMySql(config.GetConnectionString("MainConnection"), ServerVersion.AutoDetect(config.GetConnectionString("MainConnection")))
            );*/
        }
    }
}
