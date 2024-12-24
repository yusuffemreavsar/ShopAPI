using Business.Abstract;
using Business.BusinessRules.Auth;
using Business.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace Business
{
    public static class BusinessRegistration
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthManager>();
            services.AddScoped<AuthBusinessRules>();
        }
    }
}
