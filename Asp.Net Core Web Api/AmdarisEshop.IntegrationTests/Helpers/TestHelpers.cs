using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Application.Commands;
using AmdarisEshop.Application.Queries;
using AmdarisEshop.Application.QueryHandlers;
using AmdarisEshop.Domain.Models;
using AmdarisEshop.Presentation;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace AmdarisEshop.IntegrationTests.Helpers
{
    public static class TestHelpers
    {
        public static IMapper CreateMapper()
        {
            var services = new ServiceCollection();
            services.AddAutoMapper(typeof(AssemblyMarketPresentation));
            var serviceProvider = services.BuildServiceProvider();
            return serviceProvider.GetRequiredService<IMapper>();
        }

        public static IMediator CreateMediator(IUnitOfWork unitOfWork)
        {
            var services = new ServiceCollection();
            services.AddMediatR(typeof(CreateProduct));
            services.AddSingleton(unitOfWork);
            services.AddScoped<IRequestHandler<GetAllCategories, List<Category>>, GetAllCategoriesHandler>();

            var serviceProvider = services.BuildServiceProvider();
            return serviceProvider.GetRequiredService<IMediator>();
        }
    }
}
