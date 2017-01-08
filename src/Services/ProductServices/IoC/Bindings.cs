using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComparisonOne.Core.Interfaces;
using ComparisonOne.Services.ProductServices.Interfaces;
using ComparisonOne.Services.ProductServices.Repo;
using Microsoft.Extensions.DependencyInjection;

namespace ComparisonOne.Services.ProductServices.IoC
{
    public static class Bindings
    {
        public static void Bind(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IProductRepo, ProductRepo>();
            serviceCollection.AddSingleton<IProductService, ProductService>();
            serviceCollection.AddSingleton<ICartService, CartService>();
        }
    }
}
