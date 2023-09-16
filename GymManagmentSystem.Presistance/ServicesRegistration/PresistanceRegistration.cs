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
    public static class PresistanceRegistration
    {
        public static IServiceCollection PresistanceServiceCollection(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<GymManagementDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString(""));
            });

            services.AddScoped( typeof(IGenericRepository<>),typeof(GenericRepository<>));

            services.AddScoped<IMemberRepository, MemberRepository>();
            services.AddScoped<IMemberShipRepository, MembershipRepository>();

            return services;
        }
    }
}
