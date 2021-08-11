using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI_Sample
{
    public static class DependencyInjectionContainer
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<IMyService, MyService>();

            return services;
        }

        public static IServiceCollection ConfigureViewModels(this IServiceCollection services)
        {
            services.AddTransient<MainPageModel>();

            return services;
        }
    }
}
