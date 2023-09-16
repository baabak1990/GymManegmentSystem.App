using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentApplication.DTOs.MemberDTOs;
using GymManegmentApplication.Response;
using MediatR;

namespace GymManegmentApplication.Features.Member.Request.Command
{
    public class EditMemberCommand:IRequest<BaseCommonResponse>
    {
        public EditMemberDto EditMemberDto { get; set; }
    }
}
