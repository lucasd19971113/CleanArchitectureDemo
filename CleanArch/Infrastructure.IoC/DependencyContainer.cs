using Application.Interfaces;
using Application.Services;
using Domain.CommandHandlers;
using Domain.Commands;
using Domain.Core.Bus;
using Domain.Interfaces;
using Infrastructure.Bus;
using Infrastructure.Data.Context;
using Infrastructure.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            
            return services

            //Domain InMemoryBus MediatR
            .AddScoped<IMediatorHandler, InMemoryBus>()

            //Domain Handlers
            .AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>()
            
            //Application Layer
            .AddScoped<ICourseService, CourseService>()

            //Infrastructure.Data Layer
            .AddScoped<ICourseRepository, CourseRepository>();
            
            //.AddScoped<AppDbContext>();

        }
    }
}