using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GymManegmentApplication.Features.Member.Request.Query
{
    public class IsUserExistedByMobileNumRequest:IRequest<bool>
    {
        public string MobileNum { get; set;}
    }
}
