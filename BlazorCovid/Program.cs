using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Application;

namespace BlazorCovid
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddDevExpressBlazor();
            builder.Services.AddApplication();
            builder.Services.AddLogging();

            await builder.Build().RunAsync();
        }
    }
}
