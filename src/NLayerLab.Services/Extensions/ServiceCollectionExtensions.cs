using Microsoft.Extensions.DependencyInjection;
using NLayerLab.Data.Abstract;
using NLayerLab.Data.Concrete;
using NLayerLab.Data.Concrete.EntityFramework.Contexts;
using NLayerLab.Services.Abstract;
using NLayerLab.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerLab.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<NLayerLabContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IArticleService, ArticleManager >();
            return serviceCollection;
        }
    }
}
