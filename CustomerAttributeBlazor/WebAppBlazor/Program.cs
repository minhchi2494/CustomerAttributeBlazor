using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebAppBlazor.Services;

namespace WebAppBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped<ICustomerService, CustomerService>();

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:46109") });

            await builder.Build().RunAsync();
        }
    }
}
