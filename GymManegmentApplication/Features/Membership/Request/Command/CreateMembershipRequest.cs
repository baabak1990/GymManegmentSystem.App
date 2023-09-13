using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentApplication.DTOs.MemberDTOs;
using MediatR;

namespace GymManegmentApplication.Features.Membership.Request.Command
{
    public class CreateMembershipRequest:IRequest<int>
    {
        public CreateMemberDto DTO { get; set; }
    }
}
