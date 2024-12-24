using Business.BusinessRules.Auth;
using Microsoft.Extensions.DependencyInjection;

namespace Business
{
    public static class BusinessRegistration
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<AuthBusinessRules>();
        }
    }
}
