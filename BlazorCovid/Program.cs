using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Refit;
using BlazorCovid.Data;

namespace BlazorCovid
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddRefitClient<IKawalCorona>().ConfigureHttpClient(c => 
            {
                c.BaseAddress = new Uri("https://api.kawalcorona.com/");
                c.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                c.DefaultRequestHeaders.Add("Access-Control-Allow-Credentials", "true");
            });

            await builder.Build().RunAsync();
        }
    }
}
