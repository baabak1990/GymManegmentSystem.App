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
    public class CreatememberCommand:IRequest<BaseCommonResponse>
    {
        public CreateMemberDto CreateMemberDto { get; set; }
    }
}
