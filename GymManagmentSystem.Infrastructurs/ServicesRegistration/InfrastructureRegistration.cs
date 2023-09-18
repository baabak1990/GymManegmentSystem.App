using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagmentSystem.Infrastructurs.Email;
using GymManegmentApplication.Contracts.Infrastructures;
using GymManegmentApplication.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GymManagmentSystem.Infrastructurs.ServicesRegistration
{
    public static class InfrastructureRegistration
    {
        public static IServiceCollection RegisterServiceCollection(IServiceCollection service,IConfiguration configuration)
        {
            service.Configure<EmailSetting>(configuration.GetSection("EmailSettings"));
            service.AddTransient<IEmailSender, EmailSender>();

            return service;

        }
    }
}
