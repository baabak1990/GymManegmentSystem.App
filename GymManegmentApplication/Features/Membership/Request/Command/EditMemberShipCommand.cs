using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentApplication.DTOs.MemberShipDTOs;
using MediatR;

namespace GymManegmentApplication.Features.Membership.Request.Command
{
    public class EditMemberShipCommand:IRequest<Unit>
    {
        public EditMemberShipDTo EditMemberShipDTo { get; set; }
    }
}
