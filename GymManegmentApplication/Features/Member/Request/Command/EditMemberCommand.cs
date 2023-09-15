using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentApplication.DTOs.MemberDTOs;
using MediatR;

namespace GymManegmentApplication.Features.Member.Request.Command
{
    public class EditMemberCommand:IRequest<Unit>
    {
        public EditMemberDto EditMemberDto { get; set; }
    }
}
