using App.Logic;
using App.Logic.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Simple.DAL;
using Simple.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.WebAPI.DI
{
    public static class ScopeModule
    {
        public static void AddScopeModule(this IServiceCollection services)
        {
            services.AddScoped<ICartService, CartService>();
            services.AddSingleton<ICartDataService, CartDataService>();
        }
    }
}
