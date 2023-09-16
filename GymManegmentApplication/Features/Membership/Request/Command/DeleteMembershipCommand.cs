using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentApplication.Response;
using MediatR;

namespace GymManegmentApplication.Features.Membership.Request.Command
{
    public class DeleteMembershipCommand:IRequest<BaseCommonResponse>
    {
        public int Id { get; set; }
    }
}
