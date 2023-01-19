using Api.Services.Songs;
using Domain;
using Domain.Interfaces;
using Domain.Entities.Songs;
using Infrastructure.Data;
using Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(
            this IServiceCollection services) => services
                .AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>))
                .AddScoped<ISongRepository, SongRepository>();

        public static IServiceCollection AddUnitOfWork(this IServiceCollection services) => services
                .AddScoped<IUnitOfWork, UnitOfWork>();

        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration) => services
                .AddDbContext<EFContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        public static IServiceCollection AddBusinessServices(this IServiceCollection services) =>
            services.AddScoped<SongService>();
    }
}
