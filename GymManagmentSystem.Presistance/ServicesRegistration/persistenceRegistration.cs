using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagmentSystem.Presistance.Context;
using GymManagmentSystem.Presistance.Repositories;
using GymManegmentApplication.Contracts.Presistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GymManagmentSystem.Presistance.ServicesRegistration
{
    public static class persistenceRegistration
    {
        public static IServiceCollection persistenceServiceCollection(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<GymManagementDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString(""));
            });

            //Using Dependency injection To inject our Repositories 
            services.AddScoped( typeof(IGenericRepository<>),typeof(GenericRepository<>));

            services.AddScoped<IMemberRepository, MemberRepository>();
            services.AddScoped<IMemberShipRepository, MembershipRepository>();

            return services;
        }
    }
}
