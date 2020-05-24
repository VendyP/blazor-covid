using Application.Data;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System;

namespace Application
{
    public static class DepedencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddRefitClient<ICovidApi>().ConfigureHttpClient(c =>
            {
                c.BaseAddress = new Uri("https://api.covid19api.com/");
            });
        }
    }
}
