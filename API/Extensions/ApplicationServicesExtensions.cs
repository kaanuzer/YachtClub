using Application.BrokerageFirms;
using Application.Core;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;


namespace API.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            //Mediator
            services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssembly(typeof(List.Handler).Assembly)
            );

            //AutoMapper
            services.AddAutoMapper(typeof(MappingProfiles).Assembly);

            //DBContext
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}
