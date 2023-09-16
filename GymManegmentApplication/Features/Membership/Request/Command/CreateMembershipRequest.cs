using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentApplication.DTOs.MemberDTOs;
using GymManegmentApplication.DTOs.MemberShipDTOs;
using GymManegmentApplication.Response;
using MediatR;

namespace GymManegmentApplication.Features.Membership.Request.Command
{
    public class CreateMembershipRequest:IRequest<BaseCommonResponse>
    {
        public CreateMembershipDTO DTO { get; set; }
    }
}
