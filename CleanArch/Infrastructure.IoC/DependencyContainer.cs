using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            
            return services
            
            //Application Layer
            .AddScoped<ICourseService, CourseService>()

            //Infrastructure.Data
            .AddScoped<ICourseRepository, CourseRepository>();

        }
    }
}