using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentApplication.Model;

namespace GymManegmentApplication.Contracts.Infrastructures
{
    public interface IEmailSender
    {
        Task<bool> SendEmail(Email email);
    }
}
