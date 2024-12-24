using DataAccess.Context;
using DataAccess.Repositories.Abstract;
using DataAccess.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class DataAccessRegistration
    {
        public static void AddDataAccessServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ShopAPIDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ShopAPIConnection")));
            services.AddScoped<IUserReadRepository,UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();
        }
    }
}
